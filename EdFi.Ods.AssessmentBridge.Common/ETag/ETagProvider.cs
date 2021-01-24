using System;
using System.Globalization;
using EdFi.Ods.Common;

namespace EdFi.Ods.Api.ETag
{
    // TODO: Revisit
    public class ETagProvider : IETagProvider
    {
        public string GetETag(object entity)
        {
            if (entity == null)
            {
                return null;
            }

            var versionEntity = entity as IDateVersionedEntity;

            // Handle entities
            if (versionEntity != null)
            {
                var dateToGenerateEtagFrom = versionEntity.LastModifiedDate;

                if (dateToGenerateEtagFrom == default(DateTime))
                {
                    return null;
                }

                var standardizedEtagDateTime = DateTime.SpecifyKind(dateToGenerateEtagFrom, DateTimeKind.Unspecified);

                return standardizedEtagDateTime.ToBinary()
                                               .ToString(CultureInfo.InvariantCulture);
            }

            // Handle resources
            var resourceEntity = entity as IHasETag;

            if (resourceEntity != null)
            {
                return resourceEntity.ETag;
            }

            // Handle date values
            var dateValue = entity as DateTime?;

            if (dateValue.HasValue)
            {
                var standardizedEtagDateTime = DateTime.SpecifyKind(dateValue.Value, DateTimeKind.Unspecified);

                return standardizedEtagDateTime.ToBinary()
                                               .ToString(CultureInfo.InvariantCulture);
            }

            // Handle guids
            var guidValue = entity as Guid?;

            if (guidValue.HasValue)
            {
                return guidValue.Value.ToString("N");
            }

            // Handle strings
            var stringValue = entity as string;

            if (!string.IsNullOrEmpty(stringValue))
            {
                return stringValue;
            }

            throw new Exception($"Unsupported type for ETag determination: '{entity.GetType().Name}'");
        }

        public DateTime GetDateTime(string etag)
        {
            long result;

            if (!string.IsNullOrWhiteSpace(etag) && long.TryParse(etag, out result))
            {
                try
                {
                    return DateTime.FromBinary(result);
                }
                catch (Exception ex)
                {
                    throw new ArgumentException("Invalid ETag value.", ex);
                }
            }

            return default(DateTime);
        }
    }
}
