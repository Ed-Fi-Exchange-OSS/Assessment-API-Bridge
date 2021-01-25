
 
using System;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Http.Results;
using EdFi.Ods.Api.Architecture;
using EdFi.Ods.Api.ExceptionHandling;
using EdFi.Ods.Common.Context;
using EdFi.Ods.Entities.Common;
using EdFi.Ods.Pipelines.Factories;
using EdFi.Ods.Api.Services.CustomActionResults;
using EdFi.Ods.Api.Services.Queries;
using EdFi.Ods.Api.Services.Requests;


namespace EdFi.Ods.Api.Services.Controllers.v2.AcademicHonorCategoryTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class AcademicHonorCategoryTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.AcademicHonorCategoryType.AcademicHonorCategoryType, 
        EdFi.Ods.Api.Models.Resources.V2.AcademicHonorCategoryType.AcademicHonorCategoryType, 
        EdFi.Ods.Entities.Common.IAcademicHonorCategoryType, 
        // EdFi.Ods.Entities.NHibernate.AcademicHonorCategoryTypeAggregate.AcademicHonorCategoryType, 
        Api.Models.Requests.v2.AcademicHonorCategoryTypes.AcademicHonorCategoryTypeGetByKey, 
        Api.Models.Requests.v2.AcademicHonorCategoryTypes.AcademicHonorCategoryTypePut,
        Api.Models.Requests.v2.AcademicHonorCategoryTypes.AcademicHonorCategoryTypePost,
        Api.Models.Requests.v2.AcademicHonorCategoryTypes.AcademicHonorCategoryTypeDelete,
        Api.Models.Requests.v2.AcademicHonorCategoryTypes.AcademicHonorCategoryTypeGetByExample>
    {
        public AcademicHonorCategoryTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.AcademicHonorCategoryTypes.AcademicHonorCategoryTypeGetByKey request, IAcademicHonorCategoryType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.AcademicHonorCategoryTypeId = request.AcademicHonorCategoryTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.AcademicHonorCategoryTypes.AcademicHonorCategoryTypeGetByExample request, IAcademicHonorCategoryType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.AcademicHonorCategoryTypeId = request.AcademicHonorCategoryTypeId;
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int academicHonorCategoryTypeId)
        {
            var request = new Api.Models.Requests.v2.AcademicHonorCategoryTypes.AcademicHonorCategoryTypeGetByKey
            {
                AcademicHonorCategoryTypeId = academicHonorCategoryTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IAcademicHonorCategoryType request)
        {
            return 
                request.AcademicHonorCategoryTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "academicHonorCategoryTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.AcademicSubjectDescriptors
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class AcademicSubjectDescriptorsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.AcademicSubjectDescriptor.AcademicSubjectDescriptor, 
        EdFi.Ods.Api.Models.Resources.V2.AcademicSubjectDescriptor.AcademicSubjectDescriptor, 
        EdFi.Ods.Entities.Common.IAcademicSubjectDescriptor, 
        // EdFi.Ods.Entities.NHibernate.AcademicSubjectDescriptorAggregate.AcademicSubjectDescriptor, 
        Api.Models.Requests.v2.AcademicSubjectDescriptors.AcademicSubjectDescriptorGetByKey, 
        Api.Models.Requests.v2.AcademicSubjectDescriptors.AcademicSubjectDescriptorPut,
        Api.Models.Requests.v2.AcademicSubjectDescriptors.AcademicSubjectDescriptorPost,
        Api.Models.Requests.v2.AcademicSubjectDescriptors.AcademicSubjectDescriptorDelete,
        Api.Models.Requests.v2.AcademicSubjectDescriptors.AcademicSubjectDescriptorGetByExample>
    {
        public AcademicSubjectDescriptorsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.AcademicSubjectDescriptors.AcademicSubjectDescriptorGetByKey request, IAcademicSubjectDescriptor specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.AcademicSubjectDescriptorId = request.AcademicSubjectDescriptorId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.AcademicSubjectDescriptors.AcademicSubjectDescriptorGetByExample request, IAcademicSubjectDescriptor specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.AcademicSubjectDescriptorId = request.AcademicSubjectDescriptorId;
            specification.AcademicSubjectType = request.AcademicSubjectType;
                    }
                public IHttpActionResult GetByKey([FromUri] int academicSubjectDescriptorId)
        {
            var request = new Api.Models.Requests.v2.AcademicSubjectDescriptors.AcademicSubjectDescriptorGetByKey
            {
                AcademicSubjectDescriptorId = academicSubjectDescriptorId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IAcademicSubjectDescriptor request)
        {
            return 
                request.AcademicSubjectDescriptorId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "academicSubjectDescriptors";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.AcademicSubjectTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class AcademicSubjectTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.AcademicSubjectType.AcademicSubjectType, 
        EdFi.Ods.Api.Models.Resources.V2.AcademicSubjectType.AcademicSubjectType, 
        EdFi.Ods.Entities.Common.IAcademicSubjectType, 
        // EdFi.Ods.Entities.NHibernate.AcademicSubjectTypeAggregate.AcademicSubjectType, 
        Api.Models.Requests.v2.AcademicSubjectTypes.AcademicSubjectTypeGetByKey, 
        Api.Models.Requests.v2.AcademicSubjectTypes.AcademicSubjectTypePut,
        Api.Models.Requests.v2.AcademicSubjectTypes.AcademicSubjectTypePost,
        Api.Models.Requests.v2.AcademicSubjectTypes.AcademicSubjectTypeDelete,
        Api.Models.Requests.v2.AcademicSubjectTypes.AcademicSubjectTypeGetByExample>
    {
        public AcademicSubjectTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.AcademicSubjectTypes.AcademicSubjectTypeGetByKey request, IAcademicSubjectType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.AcademicSubjectTypeId = request.AcademicSubjectTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.AcademicSubjectTypes.AcademicSubjectTypeGetByExample request, IAcademicSubjectType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.AcademicSubjectTypeId = request.AcademicSubjectTypeId;
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int academicSubjectTypeId)
        {
            var request = new Api.Models.Requests.v2.AcademicSubjectTypes.AcademicSubjectTypeGetByKey
            {
                AcademicSubjectTypeId = academicSubjectTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IAcademicSubjectType request)
        {
            return 
                request.AcademicSubjectTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "academicSubjectTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.AcademicWeeks
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class AcademicWeeksController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.AcademicWeek.AcademicWeek, 
        EdFi.Ods.Api.Models.Resources.V2.AcademicWeek.AcademicWeek, 
        EdFi.Ods.Entities.Common.IAcademicWeek, 
        // EdFi.Ods.Entities.NHibernate.AcademicWeekAggregate.AcademicWeek, 
        Api.Models.Requests.v2.AcademicWeeks.AcademicWeekGetByKey, 
        Api.Models.Requests.v2.AcademicWeeks.AcademicWeekPut,
        Api.Models.Requests.v2.AcademicWeeks.AcademicWeekPost,
        Api.Models.Requests.v2.AcademicWeeks.AcademicWeekDelete,
        Api.Models.Requests.v2.AcademicWeeks.AcademicWeekGetByExample>
    {
        public AcademicWeeksController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.AcademicWeeks.AcademicWeekGetByKey request, IAcademicWeek specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.SchoolId = request.SchoolId;
            specification.WeekIdentifier = request.WeekIdentifier;
                    }

        protected override void MapAll(Api.Models.Requests.v2.AcademicWeeks.AcademicWeekGetByExample request, IAcademicWeek specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.BeginDate = request.BeginDate;
            specification.EndDate = request.EndDate;
            specification.Id = request.Id;
            specification.SchoolId = request.SchoolId;
            specification.TotalInstructionalDays = request.TotalInstructionalDays;
            specification.WeekIdentifier = request.WeekIdentifier;
                    }
                public IHttpActionResult GetByKey([FromUri] int schoolId, string weekIdentifier)
        {
            var request = new Api.Models.Requests.v2.AcademicWeeks.AcademicWeekGetByKey
            {
                SchoolId = schoolId,
                WeekIdentifier = weekIdentifier,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IAcademicWeek request)
        {
            return 
                request.SchoolId != default(int)
                && request.WeekIdentifier != default(string);
        }

        protected override string GetResourceCollectionName()
        {
            return "academicWeeks";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.AccommodationDescriptors
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class AccommodationDescriptorsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.AccommodationDescriptor.AccommodationDescriptor, 
        EdFi.Ods.Api.Models.Resources.V2.AccommodationDescriptor.AccommodationDescriptor, 
        EdFi.Ods.Entities.Common.IAccommodationDescriptor, 
        // EdFi.Ods.Entities.NHibernate.AccommodationDescriptorAggregate.AccommodationDescriptor, 
        Api.Models.Requests.v2.AccommodationDescriptors.AccommodationDescriptorGetByKey, 
        Api.Models.Requests.v2.AccommodationDescriptors.AccommodationDescriptorPut,
        Api.Models.Requests.v2.AccommodationDescriptors.AccommodationDescriptorPost,
        Api.Models.Requests.v2.AccommodationDescriptors.AccommodationDescriptorDelete,
        Api.Models.Requests.v2.AccommodationDescriptors.AccommodationDescriptorGetByExample>
    {
        public AccommodationDescriptorsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.AccommodationDescriptors.AccommodationDescriptorGetByKey request, IAccommodationDescriptor specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.AccommodationDescriptorId = request.AccommodationDescriptorId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.AccommodationDescriptors.AccommodationDescriptorGetByExample request, IAccommodationDescriptor specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.AccommodationDescriptorId = request.AccommodationDescriptorId;
            specification.AccommodationType = request.AccommodationType;
                    }
                public IHttpActionResult GetByKey([FromUri] int accommodationDescriptorId)
        {
            var request = new Api.Models.Requests.v2.AccommodationDescriptors.AccommodationDescriptorGetByKey
            {
                AccommodationDescriptorId = accommodationDescriptorId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IAccommodationDescriptor request)
        {
            return 
                request.AccommodationDescriptorId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "accommodationDescriptors";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.AccommodationTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class AccommodationTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.AccommodationType.AccommodationType, 
        EdFi.Ods.Api.Models.Resources.V2.AccommodationType.AccommodationType, 
        EdFi.Ods.Entities.Common.IAccommodationType, 
        // EdFi.Ods.Entities.NHibernate.AccommodationTypeAggregate.AccommodationType, 
        Api.Models.Requests.v2.AccommodationTypes.AccommodationTypeGetByKey, 
        Api.Models.Requests.v2.AccommodationTypes.AccommodationTypePut,
        Api.Models.Requests.v2.AccommodationTypes.AccommodationTypePost,
        Api.Models.Requests.v2.AccommodationTypes.AccommodationTypeDelete,
        Api.Models.Requests.v2.AccommodationTypes.AccommodationTypeGetByExample>
    {
        public AccommodationTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.AccommodationTypes.AccommodationTypeGetByKey request, IAccommodationType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.AccommodationTypeId = request.AccommodationTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.AccommodationTypes.AccommodationTypeGetByExample request, IAccommodationType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.AccommodationTypeId = request.AccommodationTypeId;
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int accommodationTypeId)
        {
            var request = new Api.Models.Requests.v2.AccommodationTypes.AccommodationTypeGetByKey
            {
                AccommodationTypeId = accommodationTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IAccommodationType request)
        {
            return 
                request.AccommodationTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "accommodationTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.Accounts
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class AccountsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.Account.Account, 
        EdFi.Ods.Api.Models.Resources.V2.Account.Account, 
        EdFi.Ods.Entities.Common.IAccount, 
        // EdFi.Ods.Entities.NHibernate.AccountAggregate.Account, 
        Api.Models.Requests.v2.Accounts.AccountGetByKey, 
        Api.Models.Requests.v2.Accounts.AccountPut,
        Api.Models.Requests.v2.Accounts.AccountPost,
        Api.Models.Requests.v2.Accounts.AccountDelete,
        Api.Models.Requests.v2.Accounts.AccountGetByExample>
    {
        public AccountsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.Accounts.AccountGetByKey request, IAccount specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.AccountNumber = request.Number;
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.FiscalYear = request.FiscalYear;
                    }

        protected override void MapAll(Api.Models.Requests.v2.Accounts.AccountGetByExample request, IAccount specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.AccountNumber = request.Number;
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.FiscalYear = request.FiscalYear;
            specification.Id = request.Id;
                    }
                public IHttpActionResult GetByKey([FromUri] string number, int educationOrganizationId, int fiscalYear)
        {
            var request = new Api.Models.Requests.v2.Accounts.AccountGetByKey
            {
                Number = number,
                EducationOrganizationId = educationOrganizationId,
                FiscalYear = fiscalYear,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IAccount request)
        {
            return 
                request.AccountNumber != default(string)
                && request.EducationOrganizationId != default(int)
                && request.FiscalYear != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "accounts";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.AccountabilityRatings
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class AccountabilityRatingsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.AccountabilityRating.AccountabilityRating, 
        EdFi.Ods.Api.Models.Resources.V2.AccountabilityRating.AccountabilityRating, 
        EdFi.Ods.Entities.Common.IAccountabilityRating, 
        // EdFi.Ods.Entities.NHibernate.AccountabilityRatingAggregate.AccountabilityRating, 
        Api.Models.Requests.v2.AccountabilityRatings.AccountabilityRatingGetByKey, 
        Api.Models.Requests.v2.AccountabilityRatings.AccountabilityRatingPut,
        Api.Models.Requests.v2.AccountabilityRatings.AccountabilityRatingPost,
        Api.Models.Requests.v2.AccountabilityRatings.AccountabilityRatingDelete,
        Api.Models.Requests.v2.AccountabilityRatings.AccountabilityRatingGetByExample>
    {
        public AccountabilityRatingsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.AccountabilityRatings.AccountabilityRatingGetByKey request, IAccountabilityRating specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.RatingTitle = request.RatingTitle;
            specification.SchoolYear = request.SchoolYear;
                    }

        protected override void MapAll(Api.Models.Requests.v2.AccountabilityRatings.AccountabilityRatingGetByExample request, IAccountabilityRating specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.Id = request.Id;
            specification.Rating = request.Rating;
            specification.RatingDate = request.RatingDate;
            specification.RatingOrganization = request.RatingOrganization;
            specification.RatingProgram = request.RatingProgram;
            specification.RatingTitle = request.RatingTitle;
            specification.SchoolYear = request.SchoolYear;
                    }
                public IHttpActionResult GetByKey([FromUri] int educationOrganizationId, string ratingTitle, short schoolYear)
        {
            var request = new Api.Models.Requests.v2.AccountabilityRatings.AccountabilityRatingGetByKey
            {
                EducationOrganizationId = educationOrganizationId,
                RatingTitle = ratingTitle,
                SchoolYear = schoolYear,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IAccountabilityRating request)
        {
            return 
                request.EducationOrganizationId != default(int)
                && request.RatingTitle != default(string)
                && request.SchoolYear != default(short);
        }

        protected override string GetResourceCollectionName()
        {
            return "accountabilityRatings";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.AccountCodeDescriptors
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class AccountCodeDescriptorsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.AccountCodeDescriptor.AccountCodeDescriptor, 
        EdFi.Ods.Api.Models.Resources.V2.AccountCodeDescriptor.AccountCodeDescriptor, 
        EdFi.Ods.Entities.Common.IAccountCodeDescriptor, 
        // EdFi.Ods.Entities.NHibernate.AccountCodeDescriptorAggregate.AccountCodeDescriptor, 
        Api.Models.Requests.v2.AccountCodeDescriptors.AccountCodeDescriptorGetByKey, 
        Api.Models.Requests.v2.AccountCodeDescriptors.AccountCodeDescriptorPut,
        Api.Models.Requests.v2.AccountCodeDescriptors.AccountCodeDescriptorPost,
        Api.Models.Requests.v2.AccountCodeDescriptors.AccountCodeDescriptorDelete,
        Api.Models.Requests.v2.AccountCodeDescriptors.AccountCodeDescriptorGetByExample>
    {
        public AccountCodeDescriptorsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.AccountCodeDescriptors.AccountCodeDescriptorGetByKey request, IAccountCodeDescriptor specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.AccountCodeDescriptorId = request.AccountCodeDescriptorId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.AccountCodeDescriptors.AccountCodeDescriptorGetByExample request, IAccountCodeDescriptor specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.AccountCodeCategory = request.AccountCodeCategory;
            specification.AccountCodeDescriptorId = request.AccountCodeDescriptorId;
            specification.BeginDate = request.BeginDate;
            specification.EndDate = request.EndDate;
                    }
                public IHttpActionResult GetByKey([FromUri] int accountCodeDescriptorId)
        {
            var request = new Api.Models.Requests.v2.AccountCodeDescriptors.AccountCodeDescriptorGetByKey
            {
                AccountCodeDescriptorId = accountCodeDescriptorId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IAccountCodeDescriptor request)
        {
            return 
                request.AccountCodeDescriptorId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "accountCodeDescriptors";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.AchievementCategoryDescriptors
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class AchievementCategoryDescriptorsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.AchievementCategoryDescriptor.AchievementCategoryDescriptor, 
        EdFi.Ods.Api.Models.Resources.V2.AchievementCategoryDescriptor.AchievementCategoryDescriptor, 
        EdFi.Ods.Entities.Common.IAchievementCategoryDescriptor, 
        // EdFi.Ods.Entities.NHibernate.AchievementCategoryDescriptorAggregate.AchievementCategoryDescriptor, 
        Api.Models.Requests.v2.AchievementCategoryDescriptors.AchievementCategoryDescriptorGetByKey, 
        Api.Models.Requests.v2.AchievementCategoryDescriptors.AchievementCategoryDescriptorPut,
        Api.Models.Requests.v2.AchievementCategoryDescriptors.AchievementCategoryDescriptorPost,
        Api.Models.Requests.v2.AchievementCategoryDescriptors.AchievementCategoryDescriptorDelete,
        Api.Models.Requests.v2.AchievementCategoryDescriptors.AchievementCategoryDescriptorGetByExample>
    {
        public AchievementCategoryDescriptorsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.AchievementCategoryDescriptors.AchievementCategoryDescriptorGetByKey request, IAchievementCategoryDescriptor specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.AchievementCategoryDescriptorId = request.AchievementCategoryDescriptorId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.AchievementCategoryDescriptors.AchievementCategoryDescriptorGetByExample request, IAchievementCategoryDescriptor specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.AchievementCategoryDescriptorId = request.AchievementCategoryDescriptorId;
            specification.AchievementCategoryType = request.AchievementCategoryType;
                    }
                public IHttpActionResult GetByKey([FromUri] int achievementCategoryDescriptorId)
        {
            var request = new Api.Models.Requests.v2.AchievementCategoryDescriptors.AchievementCategoryDescriptorGetByKey
            {
                AchievementCategoryDescriptorId = achievementCategoryDescriptorId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IAchievementCategoryDescriptor request)
        {
            return 
                request.AchievementCategoryDescriptorId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "achievementCategoryDescriptors";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.AchievementCategoryTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class AchievementCategoryTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.AchievementCategoryType.AchievementCategoryType, 
        EdFi.Ods.Api.Models.Resources.V2.AchievementCategoryType.AchievementCategoryType, 
        EdFi.Ods.Entities.Common.IAchievementCategoryType, 
        // EdFi.Ods.Entities.NHibernate.AchievementCategoryTypeAggregate.AchievementCategoryType, 
        Api.Models.Requests.v2.AchievementCategoryTypes.AchievementCategoryTypeGetByKey, 
        Api.Models.Requests.v2.AchievementCategoryTypes.AchievementCategoryTypePut,
        Api.Models.Requests.v2.AchievementCategoryTypes.AchievementCategoryTypePost,
        Api.Models.Requests.v2.AchievementCategoryTypes.AchievementCategoryTypeDelete,
        Api.Models.Requests.v2.AchievementCategoryTypes.AchievementCategoryTypeGetByExample>
    {
        public AchievementCategoryTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.AchievementCategoryTypes.AchievementCategoryTypeGetByKey request, IAchievementCategoryType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.AchievementCategoryTypeId = request.AchievementCategoryTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.AchievementCategoryTypes.AchievementCategoryTypeGetByExample request, IAchievementCategoryType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.AchievementCategoryTypeId = request.AchievementCategoryTypeId;
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int achievementCategoryTypeId)
        {
            var request = new Api.Models.Requests.v2.AchievementCategoryTypes.AchievementCategoryTypeGetByKey
            {
                AchievementCategoryTypeId = achievementCategoryTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IAchievementCategoryType request)
        {
            return 
                request.AchievementCategoryTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "achievementCategoryTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.Actuals
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class ActualsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.Actual.Actual, 
        EdFi.Ods.Api.Models.Resources.V2.Actual.Actual, 
        EdFi.Ods.Entities.Common.IActual, 
        // EdFi.Ods.Entities.NHibernate.ActualAggregate.Actual, 
        Api.Models.Requests.v2.Actuals.ActualGetByKey, 
        Api.Models.Requests.v2.Actuals.ActualPut,
        Api.Models.Requests.v2.Actuals.ActualPost,
        Api.Models.Requests.v2.Actuals.ActualDelete,
        Api.Models.Requests.v2.Actuals.ActualGetByExample>
    {
        public ActualsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.Actuals.ActualGetByKey request, IActual specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.AccountNumber = request.AccountNumber;
            specification.AsOfDate = request.AsOfDate;
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.FiscalYear = request.FiscalYear;
                    }

        protected override void MapAll(Api.Models.Requests.v2.Actuals.ActualGetByExample request, IActual specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.AccountNumber = request.AccountNumber;
            specification.AmountToDate = request.AmountToDate;
            specification.AsOfDate = request.AsOfDate;
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.FiscalYear = request.FiscalYear;
            specification.Id = request.Id;
                    }
                public IHttpActionResult GetByKey([FromUri] string accountNumber, DateTime asOfDate, int educationOrganizationId, int fiscalYear)
        {
            var request = new Api.Models.Requests.v2.Actuals.ActualGetByKey
            {
                AccountNumber = accountNumber,
                AsOfDate = asOfDate,
                EducationOrganizationId = educationOrganizationId,
                FiscalYear = fiscalYear,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IActual request)
        {
            return 
                request.AccountNumber != default(string)
                && request.AsOfDate != default(DateTime)
                && request.EducationOrganizationId != default(int)
                && request.FiscalYear != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "actuals";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.AdditionalCreditTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class AdditionalCreditTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.AdditionalCreditType.AdditionalCreditType, 
        EdFi.Ods.Api.Models.Resources.V2.AdditionalCreditType.AdditionalCreditType, 
        EdFi.Ods.Entities.Common.IAdditionalCreditType, 
        // EdFi.Ods.Entities.NHibernate.AdditionalCreditTypeAggregate.AdditionalCreditType, 
        Api.Models.Requests.v2.AdditionalCreditTypes.AdditionalCreditTypeGetByKey, 
        Api.Models.Requests.v2.AdditionalCreditTypes.AdditionalCreditTypePut,
        Api.Models.Requests.v2.AdditionalCreditTypes.AdditionalCreditTypePost,
        Api.Models.Requests.v2.AdditionalCreditTypes.AdditionalCreditTypeDelete,
        Api.Models.Requests.v2.AdditionalCreditTypes.AdditionalCreditTypeGetByExample>
    {
        public AdditionalCreditTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.AdditionalCreditTypes.AdditionalCreditTypeGetByKey request, IAdditionalCreditType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.AdditionalCreditTypeId = request.AdditionalCreditTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.AdditionalCreditTypes.AdditionalCreditTypeGetByExample request, IAdditionalCreditType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.AdditionalCreditTypeId = request.AdditionalCreditTypeId;
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int additionalCreditTypeId)
        {
            var request = new Api.Models.Requests.v2.AdditionalCreditTypes.AdditionalCreditTypeGetByKey
            {
                AdditionalCreditTypeId = additionalCreditTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IAdditionalCreditType request)
        {
            return 
                request.AdditionalCreditTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "additionalCreditTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.AddressTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class AddressTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.AddressType.AddressType, 
        EdFi.Ods.Api.Models.Resources.V2.AddressType.AddressType, 
        EdFi.Ods.Entities.Common.IAddressType, 
        // EdFi.Ods.Entities.NHibernate.AddressTypeAggregate.AddressType, 
        Api.Models.Requests.v2.AddressTypes.AddressTypeGetByKey, 
        Api.Models.Requests.v2.AddressTypes.AddressTypePut,
        Api.Models.Requests.v2.AddressTypes.AddressTypePost,
        Api.Models.Requests.v2.AddressTypes.AddressTypeDelete,
        Api.Models.Requests.v2.AddressTypes.AddressTypeGetByExample>
    {
        public AddressTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.AddressTypes.AddressTypeGetByKey request, IAddressType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.AddressTypeId = request.AddressTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.AddressTypes.AddressTypeGetByExample request, IAddressType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.AddressTypeId = request.AddressTypeId;
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int addressTypeId)
        {
            var request = new Api.Models.Requests.v2.AddressTypes.AddressTypeGetByKey
            {
                AddressTypeId = addressTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IAddressType request)
        {
            return 
                request.AddressTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "addressTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.AdministrationEnvironmentTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class AdministrationEnvironmentTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.AdministrationEnvironmentType.AdministrationEnvironmentType, 
        EdFi.Ods.Api.Models.Resources.V2.AdministrationEnvironmentType.AdministrationEnvironmentType, 
        EdFi.Ods.Entities.Common.IAdministrationEnvironmentType, 
        // EdFi.Ods.Entities.NHibernate.AdministrationEnvironmentTypeAggregate.AdministrationEnvironmentType, 
        Api.Models.Requests.v2.AdministrationEnvironmentTypes.AdministrationEnvironmentTypeGetByKey, 
        Api.Models.Requests.v2.AdministrationEnvironmentTypes.AdministrationEnvironmentTypePut,
        Api.Models.Requests.v2.AdministrationEnvironmentTypes.AdministrationEnvironmentTypePost,
        Api.Models.Requests.v2.AdministrationEnvironmentTypes.AdministrationEnvironmentTypeDelete,
        Api.Models.Requests.v2.AdministrationEnvironmentTypes.AdministrationEnvironmentTypeGetByExample>
    {
        public AdministrationEnvironmentTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.AdministrationEnvironmentTypes.AdministrationEnvironmentTypeGetByKey request, IAdministrationEnvironmentType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.AdministrationEnvironmentTypeId = request.AdministrationEnvironmentTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.AdministrationEnvironmentTypes.AdministrationEnvironmentTypeGetByExample request, IAdministrationEnvironmentType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.AdministrationEnvironmentTypeId = request.AdministrationEnvironmentTypeId;
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int administrationEnvironmentTypeId)
        {
            var request = new Api.Models.Requests.v2.AdministrationEnvironmentTypes.AdministrationEnvironmentTypeGetByKey
            {
                AdministrationEnvironmentTypeId = administrationEnvironmentTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IAdministrationEnvironmentType request)
        {
            return 
                request.AdministrationEnvironmentTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "administrationEnvironmentTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.AdministrativeFundingControlDescriptors
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class AdministrativeFundingControlDescriptorsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.AdministrativeFundingControlDescriptor.AdministrativeFundingControlDescriptor, 
        EdFi.Ods.Api.Models.Resources.V2.AdministrativeFundingControlDescriptor.AdministrativeFundingControlDescriptor, 
        EdFi.Ods.Entities.Common.IAdministrativeFundingControlDescriptor, 
        // EdFi.Ods.Entities.NHibernate.AdministrativeFundingControlDescriptorAggregate.AdministrativeFundingControlDescriptor, 
        Api.Models.Requests.v2.AdministrativeFundingControlDescriptors.AdministrativeFundingControlDescriptorGetByKey, 
        Api.Models.Requests.v2.AdministrativeFundingControlDescriptors.AdministrativeFundingControlDescriptorPut,
        Api.Models.Requests.v2.AdministrativeFundingControlDescriptors.AdministrativeFundingControlDescriptorPost,
        Api.Models.Requests.v2.AdministrativeFundingControlDescriptors.AdministrativeFundingControlDescriptorDelete,
        Api.Models.Requests.v2.AdministrativeFundingControlDescriptors.AdministrativeFundingControlDescriptorGetByExample>
    {
        public AdministrativeFundingControlDescriptorsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.AdministrativeFundingControlDescriptors.AdministrativeFundingControlDescriptorGetByKey request, IAdministrativeFundingControlDescriptor specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.AdministrativeFundingControlDescriptorId = request.AdministrativeFundingControlDescriptorId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.AdministrativeFundingControlDescriptors.AdministrativeFundingControlDescriptorGetByExample request, IAdministrativeFundingControlDescriptor specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.AdministrativeFundingControlDescriptorId = request.AdministrativeFundingControlDescriptorId;
            specification.AdministrativeFundingControlType = request.AdministrativeFundingControlType;
                    }
                public IHttpActionResult GetByKey([FromUri] int administrativeFundingControlDescriptorId)
        {
            var request = new Api.Models.Requests.v2.AdministrativeFundingControlDescriptors.AdministrativeFundingControlDescriptorGetByKey
            {
                AdministrativeFundingControlDescriptorId = administrativeFundingControlDescriptorId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IAdministrativeFundingControlDescriptor request)
        {
            return 
                request.AdministrativeFundingControlDescriptorId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "administrativeFundingControlDescriptors";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.AdministrativeFundingControlTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class AdministrativeFundingControlTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.AdministrativeFundingControlType.AdministrativeFundingControlType, 
        EdFi.Ods.Api.Models.Resources.V2.AdministrativeFundingControlType.AdministrativeFundingControlType, 
        EdFi.Ods.Entities.Common.IAdministrativeFundingControlType, 
        // EdFi.Ods.Entities.NHibernate.AdministrativeFundingControlTypeAggregate.AdministrativeFundingControlType, 
        Api.Models.Requests.v2.AdministrativeFundingControlTypes.AdministrativeFundingControlTypeGetByKey, 
        Api.Models.Requests.v2.AdministrativeFundingControlTypes.AdministrativeFundingControlTypePut,
        Api.Models.Requests.v2.AdministrativeFundingControlTypes.AdministrativeFundingControlTypePost,
        Api.Models.Requests.v2.AdministrativeFundingControlTypes.AdministrativeFundingControlTypeDelete,
        Api.Models.Requests.v2.AdministrativeFundingControlTypes.AdministrativeFundingControlTypeGetByExample>
    {
        public AdministrativeFundingControlTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.AdministrativeFundingControlTypes.AdministrativeFundingControlTypeGetByKey request, IAdministrativeFundingControlType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.AdministrativeFundingControlTypeId = request.AdministrativeFundingControlTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.AdministrativeFundingControlTypes.AdministrativeFundingControlTypeGetByExample request, IAdministrativeFundingControlType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.AdministrativeFundingControlTypeId = request.AdministrativeFundingControlTypeId;
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int administrativeFundingControlTypeId)
        {
            var request = new Api.Models.Requests.v2.AdministrativeFundingControlTypes.AdministrativeFundingControlTypeGetByKey
            {
                AdministrativeFundingControlTypeId = administrativeFundingControlTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IAdministrativeFundingControlType request)
        {
            return 
                request.AdministrativeFundingControlTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "administrativeFundingControlTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.Assessments
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class AssessmentsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.Assessment.Assessment, 
        EdFi.Ods.Api.Models.Resources.V2.Assessment.Assessment, 
        EdFi.Ods.Entities.Common.IAssessment, 
        // EdFi.Ods.Entities.NHibernate.AssessmentAggregate.Assessment, 
        Api.Models.Requests.v2.Assessments.AssessmentGetByKey, 
        Api.Models.Requests.v2.Assessments.AssessmentPut,
        Api.Models.Requests.v2.Assessments.AssessmentPost,
        Api.Models.Requests.v2.Assessments.AssessmentDelete,
        Api.Models.Requests.v2.Assessments.AssessmentGetByExample>
    {
        public AssessmentsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.Assessments.AssessmentGetByKey request, IAssessment specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.AssessmentIdentifier = request.Identifier;
            specification.Namespace = request.Namespace;
                    }

        protected override void MapAll(Api.Models.Requests.v2.Assessments.AssessmentGetByExample request, IAssessment specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.AdaptiveAssessment = request.AdaptiveAssessment;
            specification.AssessmentCategoryDescriptor = request.CategoryDescriptor;
            specification.AssessmentFamilyTitle = request.FamilyTitle;
            specification.AssessmentForm = request.Form;
            specification.AssessmentIdentifier = request.Identifier;
            specification.AssessmentPeriodDescriptor = request.PeriodDescriptor;
            specification.AssessmentTitle = request.Title;
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.Id = request.Id;
            specification.MaxRawScore = request.MaxRawScore;
            specification.Namespace = request.Namespace;
            specification.Nomenclature = request.Nomenclature;
            specification.RevisionDate = request.RevisionDate;
            specification.Version = request.Version;
                    }
                public IHttpActionResult GetByKey([FromUri] string identifier, string @namespace)
        {
            var request = new Api.Models.Requests.v2.Assessments.AssessmentGetByKey
            {
                Identifier = identifier,
                Namespace = @namespace,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IAssessment request)
        {
            return 
                request.AssessmentIdentifier != default(string)
                && request.Namespace != default(string);
        }

        protected override string GetResourceCollectionName()
        {
            return "assessments";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.AssessmentCategoryDescriptors
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class AssessmentCategoryDescriptorsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.AssessmentCategoryDescriptor.AssessmentCategoryDescriptor, 
        EdFi.Ods.Api.Models.Resources.V2.AssessmentCategoryDescriptor.AssessmentCategoryDescriptor, 
        EdFi.Ods.Entities.Common.IAssessmentCategoryDescriptor, 
        // EdFi.Ods.Entities.NHibernate.AssessmentCategoryDescriptorAggregate.AssessmentCategoryDescriptor, 
        Api.Models.Requests.v2.AssessmentCategoryDescriptors.AssessmentCategoryDescriptorGetByKey, 
        Api.Models.Requests.v2.AssessmentCategoryDescriptors.AssessmentCategoryDescriptorPut,
        Api.Models.Requests.v2.AssessmentCategoryDescriptors.AssessmentCategoryDescriptorPost,
        Api.Models.Requests.v2.AssessmentCategoryDescriptors.AssessmentCategoryDescriptorDelete,
        Api.Models.Requests.v2.AssessmentCategoryDescriptors.AssessmentCategoryDescriptorGetByExample>
    {
        public AssessmentCategoryDescriptorsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.AssessmentCategoryDescriptors.AssessmentCategoryDescriptorGetByKey request, IAssessmentCategoryDescriptor specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.AssessmentCategoryDescriptorId = request.AssessmentCategoryDescriptorId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.AssessmentCategoryDescriptors.AssessmentCategoryDescriptorGetByExample request, IAssessmentCategoryDescriptor specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.AssessmentCategoryDescriptorId = request.AssessmentCategoryDescriptorId;
            specification.AssessmentCategoryType = request.AssessmentCategoryType;
                    }
                public IHttpActionResult GetByKey([FromUri] int assessmentCategoryDescriptorId)
        {
            var request = new Api.Models.Requests.v2.AssessmentCategoryDescriptors.AssessmentCategoryDescriptorGetByKey
            {
                AssessmentCategoryDescriptorId = assessmentCategoryDescriptorId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IAssessmentCategoryDescriptor request)
        {
            return 
                request.AssessmentCategoryDescriptorId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "assessmentCategoryDescriptors";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.AssessmentCategoryTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class AssessmentCategoryTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.AssessmentCategoryType.AssessmentCategoryType, 
        EdFi.Ods.Api.Models.Resources.V2.AssessmentCategoryType.AssessmentCategoryType, 
        EdFi.Ods.Entities.Common.IAssessmentCategoryType, 
        // EdFi.Ods.Entities.NHibernate.AssessmentCategoryTypeAggregate.AssessmentCategoryType, 
        Api.Models.Requests.v2.AssessmentCategoryTypes.AssessmentCategoryTypeGetByKey, 
        Api.Models.Requests.v2.AssessmentCategoryTypes.AssessmentCategoryTypePut,
        Api.Models.Requests.v2.AssessmentCategoryTypes.AssessmentCategoryTypePost,
        Api.Models.Requests.v2.AssessmentCategoryTypes.AssessmentCategoryTypeDelete,
        Api.Models.Requests.v2.AssessmentCategoryTypes.AssessmentCategoryTypeGetByExample>
    {
        public AssessmentCategoryTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.AssessmentCategoryTypes.AssessmentCategoryTypeGetByKey request, IAssessmentCategoryType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.AssessmentCategoryTypeId = request.AssessmentCategoryTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.AssessmentCategoryTypes.AssessmentCategoryTypeGetByExample request, IAssessmentCategoryType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.AssessmentCategoryTypeId = request.AssessmentCategoryTypeId;
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int assessmentCategoryTypeId)
        {
            var request = new Api.Models.Requests.v2.AssessmentCategoryTypes.AssessmentCategoryTypeGetByKey
            {
                AssessmentCategoryTypeId = assessmentCategoryTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IAssessmentCategoryType request)
        {
            return 
                request.AssessmentCategoryTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "assessmentCategoryTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.AssessmentFamilies
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class AssessmentFamiliesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.AssessmentFamily.AssessmentFamily, 
        EdFi.Ods.Api.Models.Resources.V2.AssessmentFamily.AssessmentFamily, 
        EdFi.Ods.Entities.Common.IAssessmentFamily, 
        // EdFi.Ods.Entities.NHibernate.AssessmentFamilyAggregate.AssessmentFamily, 
        Api.Models.Requests.v2.AssessmentFamilies.AssessmentFamilyGetByKey, 
        Api.Models.Requests.v2.AssessmentFamilies.AssessmentFamilyPut,
        Api.Models.Requests.v2.AssessmentFamilies.AssessmentFamilyPost,
        Api.Models.Requests.v2.AssessmentFamilies.AssessmentFamilyDelete,
        Api.Models.Requests.v2.AssessmentFamilies.AssessmentFamilyGetByExample>
    {
        public AssessmentFamiliesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.AssessmentFamilies.AssessmentFamilyGetByKey request, IAssessmentFamily specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.AssessmentFamilyTitle = request.Title;
                    }

        protected override void MapAll(Api.Models.Requests.v2.AssessmentFamilies.AssessmentFamilyGetByExample request, IAssessmentFamily specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.AcademicSubjectDescriptor = request.AcademicSubjectDescriptor;
            specification.AssessedGradeLevelDescriptor = request.AssessedGradeLevelDescriptor;
            specification.AssessmentCategoryDescriptor = request.AssessmentCategoryDescriptor;
            specification.AssessmentFamilyTitle = request.Title;
            specification.Id = request.Id;
            specification.LowestAssessedGradeLevelDescriptor = request.LowestAssessedGradeLevelDescriptor;
            specification.Namespace = request.Namespace;
            specification.Nomenclature = request.Nomenclature;
            specification.ParentAssessmentFamilyTitle = request.ParentAssessmentFamilyTitle;
            specification.RevisionDate = request.RevisionDate;
            specification.Version = request.Version;
                    }
                public IHttpActionResult GetByKey([FromUri] string title)
        {
            var request = new Api.Models.Requests.v2.AssessmentFamilies.AssessmentFamilyGetByKey
            {
                Title = title,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IAssessmentFamily request)
        {
            return 
                request.AssessmentFamilyTitle != default(string);
        }

        protected override string GetResourceCollectionName()
        {
            return "assessmentFamilies";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.AssessmentIdentificationSystemDescriptors
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class AssessmentIdentificationSystemDescriptorsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.AssessmentIdentificationSystemDescriptor.AssessmentIdentificationSystemDescriptor, 
        EdFi.Ods.Api.Models.Resources.V2.AssessmentIdentificationSystemDescriptor.AssessmentIdentificationSystemDescriptor, 
        EdFi.Ods.Entities.Common.IAssessmentIdentificationSystemDescriptor, 
        // EdFi.Ods.Entities.NHibernate.AssessmentIdentificationSystemDescriptorAggregate.AssessmentIdentificationSystemDescriptor, 
        Api.Models.Requests.v2.AssessmentIdentificationSystemDescriptors.AssessmentIdentificationSystemDescriptorGetByKey, 
        Api.Models.Requests.v2.AssessmentIdentificationSystemDescriptors.AssessmentIdentificationSystemDescriptorPut,
        Api.Models.Requests.v2.AssessmentIdentificationSystemDescriptors.AssessmentIdentificationSystemDescriptorPost,
        Api.Models.Requests.v2.AssessmentIdentificationSystemDescriptors.AssessmentIdentificationSystemDescriptorDelete,
        Api.Models.Requests.v2.AssessmentIdentificationSystemDescriptors.AssessmentIdentificationSystemDescriptorGetByExample>
    {
        public AssessmentIdentificationSystemDescriptorsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.AssessmentIdentificationSystemDescriptors.AssessmentIdentificationSystemDescriptorGetByKey request, IAssessmentIdentificationSystemDescriptor specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.AssessmentIdentificationSystemDescriptorId = request.AssessmentIdentificationSystemDescriptorId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.AssessmentIdentificationSystemDescriptors.AssessmentIdentificationSystemDescriptorGetByExample request, IAssessmentIdentificationSystemDescriptor specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.AssessmentIdentificationSystemDescriptorId = request.AssessmentIdentificationSystemDescriptorId;
            specification.AssessmentIdentificationSystemType = request.AssessmentIdentificationSystemType;
                    }
                public IHttpActionResult GetByKey([FromUri] int assessmentIdentificationSystemDescriptorId)
        {
            var request = new Api.Models.Requests.v2.AssessmentIdentificationSystemDescriptors.AssessmentIdentificationSystemDescriptorGetByKey
            {
                AssessmentIdentificationSystemDescriptorId = assessmentIdentificationSystemDescriptorId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IAssessmentIdentificationSystemDescriptor request)
        {
            return 
                request.AssessmentIdentificationSystemDescriptorId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "assessmentIdentificationSystemDescriptors";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.AssessmentIdentificationSystemTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class AssessmentIdentificationSystemTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.AssessmentIdentificationSystemType.AssessmentIdentificationSystemType, 
        EdFi.Ods.Api.Models.Resources.V2.AssessmentIdentificationSystemType.AssessmentIdentificationSystemType, 
        EdFi.Ods.Entities.Common.IAssessmentIdentificationSystemType, 
        // EdFi.Ods.Entities.NHibernate.AssessmentIdentificationSystemTypeAggregate.AssessmentIdentificationSystemType, 
        Api.Models.Requests.v2.AssessmentIdentificationSystemTypes.AssessmentIdentificationSystemTypeGetByKey, 
        Api.Models.Requests.v2.AssessmentIdentificationSystemTypes.AssessmentIdentificationSystemTypePut,
        Api.Models.Requests.v2.AssessmentIdentificationSystemTypes.AssessmentIdentificationSystemTypePost,
        Api.Models.Requests.v2.AssessmentIdentificationSystemTypes.AssessmentIdentificationSystemTypeDelete,
        Api.Models.Requests.v2.AssessmentIdentificationSystemTypes.AssessmentIdentificationSystemTypeGetByExample>
    {
        public AssessmentIdentificationSystemTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.AssessmentIdentificationSystemTypes.AssessmentIdentificationSystemTypeGetByKey request, IAssessmentIdentificationSystemType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.AssessmentIdentificationSystemTypeId = request.AssessmentIdentificationSystemTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.AssessmentIdentificationSystemTypes.AssessmentIdentificationSystemTypeGetByExample request, IAssessmentIdentificationSystemType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.AssessmentIdentificationSystemTypeId = request.AssessmentIdentificationSystemTypeId;
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int assessmentIdentificationSystemTypeId)
        {
            var request = new Api.Models.Requests.v2.AssessmentIdentificationSystemTypes.AssessmentIdentificationSystemTypeGetByKey
            {
                AssessmentIdentificationSystemTypeId = assessmentIdentificationSystemTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IAssessmentIdentificationSystemType request)
        {
            return 
                request.AssessmentIdentificationSystemTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "assessmentIdentificationSystemTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.AssessmentItems
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class AssessmentItemsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.AssessmentItem.AssessmentItem, 
        EdFi.Ods.Api.Models.Resources.V2.AssessmentItem.AssessmentItem, 
        EdFi.Ods.Entities.Common.IAssessmentItem, 
        // EdFi.Ods.Entities.NHibernate.AssessmentItemAggregate.AssessmentItem, 
        Api.Models.Requests.v2.AssessmentItems.AssessmentItemGetByKey, 
        Api.Models.Requests.v2.AssessmentItems.AssessmentItemPut,
        Api.Models.Requests.v2.AssessmentItems.AssessmentItemPost,
        Api.Models.Requests.v2.AssessmentItems.AssessmentItemDelete,
        Api.Models.Requests.v2.AssessmentItems.AssessmentItemGetByExample>
    {
        public AssessmentItemsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.AssessmentItems.AssessmentItemGetByKey request, IAssessmentItem specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.AssessmentIdentifier = request.AssessmentIdentifier;
            specification.IdentificationCode = request.IdentificationCode;
            specification.Namespace = request.Namespace;
                    }

        protected override void MapAll(Api.Models.Requests.v2.AssessmentItems.AssessmentItemGetByExample request, IAssessmentItem specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.AssessmentIdentifier = request.AssessmentIdentifier;
            specification.AssessmentItemCategoryType = request.CategoryType;
            specification.CorrectResponse = request.CorrectResponse;
            specification.ExpectedTimeAssessed = request.ExpectedTimeAssessed;
            specification.Id = request.Id;
            specification.IdentificationCode = request.IdentificationCode;
            specification.MaxRawScore = request.MaxRawScore;
            specification.Namespace = request.Namespace;
            specification.Nomenclature = request.Nomenclature;
                    }
                public IHttpActionResult GetByKey([FromUri] string assessmentIdentifier, string identificationCode, string @namespace)
        {
            var request = new Api.Models.Requests.v2.AssessmentItems.AssessmentItemGetByKey
            {
                AssessmentIdentifier = assessmentIdentifier,
                IdentificationCode = identificationCode,
                Namespace = @namespace,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IAssessmentItem request)
        {
            return 
                request.AssessmentIdentifier != default(string)
                && request.IdentificationCode != default(string)
                && request.Namespace != default(string);
        }

        protected override string GetResourceCollectionName()
        {
            return "assessmentItems";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.AssessmentItemCategoryTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class AssessmentItemCategoryTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.AssessmentItemCategoryType.AssessmentItemCategoryType, 
        EdFi.Ods.Api.Models.Resources.V2.AssessmentItemCategoryType.AssessmentItemCategoryType, 
        EdFi.Ods.Entities.Common.IAssessmentItemCategoryType, 
        // EdFi.Ods.Entities.NHibernate.AssessmentItemCategoryTypeAggregate.AssessmentItemCategoryType, 
        Api.Models.Requests.v2.AssessmentItemCategoryTypes.AssessmentItemCategoryTypeGetByKey, 
        Api.Models.Requests.v2.AssessmentItemCategoryTypes.AssessmentItemCategoryTypePut,
        Api.Models.Requests.v2.AssessmentItemCategoryTypes.AssessmentItemCategoryTypePost,
        Api.Models.Requests.v2.AssessmentItemCategoryTypes.AssessmentItemCategoryTypeDelete,
        Api.Models.Requests.v2.AssessmentItemCategoryTypes.AssessmentItemCategoryTypeGetByExample>
    {
        public AssessmentItemCategoryTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.AssessmentItemCategoryTypes.AssessmentItemCategoryTypeGetByKey request, IAssessmentItemCategoryType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.AssessmentItemCategoryTypeId = request.AssessmentItemCategoryTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.AssessmentItemCategoryTypes.AssessmentItemCategoryTypeGetByExample request, IAssessmentItemCategoryType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.AssessmentItemCategoryTypeId = request.AssessmentItemCategoryTypeId;
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int assessmentItemCategoryTypeId)
        {
            var request = new Api.Models.Requests.v2.AssessmentItemCategoryTypes.AssessmentItemCategoryTypeGetByKey
            {
                AssessmentItemCategoryTypeId = assessmentItemCategoryTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IAssessmentItemCategoryType request)
        {
            return 
                request.AssessmentItemCategoryTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "assessmentItemCategoryTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.AssessmentItemResultTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class AssessmentItemResultTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.AssessmentItemResultType.AssessmentItemResultType, 
        EdFi.Ods.Api.Models.Resources.V2.AssessmentItemResultType.AssessmentItemResultType, 
        EdFi.Ods.Entities.Common.IAssessmentItemResultType, 
        // EdFi.Ods.Entities.NHibernate.AssessmentItemResultTypeAggregate.AssessmentItemResultType, 
        Api.Models.Requests.v2.AssessmentItemResultTypes.AssessmentItemResultTypeGetByKey, 
        Api.Models.Requests.v2.AssessmentItemResultTypes.AssessmentItemResultTypePut,
        Api.Models.Requests.v2.AssessmentItemResultTypes.AssessmentItemResultTypePost,
        Api.Models.Requests.v2.AssessmentItemResultTypes.AssessmentItemResultTypeDelete,
        Api.Models.Requests.v2.AssessmentItemResultTypes.AssessmentItemResultTypeGetByExample>
    {
        public AssessmentItemResultTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.AssessmentItemResultTypes.AssessmentItemResultTypeGetByKey request, IAssessmentItemResultType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.AssessmentItemResultTypeId = request.AssessmentItemResultTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.AssessmentItemResultTypes.AssessmentItemResultTypeGetByExample request, IAssessmentItemResultType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.AssessmentItemResultTypeId = request.AssessmentItemResultTypeId;
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int assessmentItemResultTypeId)
        {
            var request = new Api.Models.Requests.v2.AssessmentItemResultTypes.AssessmentItemResultTypeGetByKey
            {
                AssessmentItemResultTypeId = assessmentItemResultTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IAssessmentItemResultType request)
        {
            return 
                request.AssessmentItemResultTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "assessmentItemResultTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.AssessmentPeriodDescriptors
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class AssessmentPeriodDescriptorsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.AssessmentPeriodDescriptor.AssessmentPeriodDescriptor, 
        EdFi.Ods.Api.Models.Resources.V2.AssessmentPeriodDescriptor.AssessmentPeriodDescriptor, 
        EdFi.Ods.Entities.Common.IAssessmentPeriodDescriptor, 
        // EdFi.Ods.Entities.NHibernate.AssessmentPeriodDescriptorAggregate.AssessmentPeriodDescriptor, 
        Api.Models.Requests.v2.AssessmentPeriodDescriptors.AssessmentPeriodDescriptorGetByKey, 
        Api.Models.Requests.v2.AssessmentPeriodDescriptors.AssessmentPeriodDescriptorPut,
        Api.Models.Requests.v2.AssessmentPeriodDescriptors.AssessmentPeriodDescriptorPost,
        Api.Models.Requests.v2.AssessmentPeriodDescriptors.AssessmentPeriodDescriptorDelete,
        Api.Models.Requests.v2.AssessmentPeriodDescriptors.AssessmentPeriodDescriptorGetByExample>
    {
        public AssessmentPeriodDescriptorsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.AssessmentPeriodDescriptors.AssessmentPeriodDescriptorGetByKey request, IAssessmentPeriodDescriptor specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.AssessmentPeriodDescriptorId = request.AssessmentPeriodDescriptorId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.AssessmentPeriodDescriptors.AssessmentPeriodDescriptorGetByExample request, IAssessmentPeriodDescriptor specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.AssessmentPeriodDescriptorId = request.AssessmentPeriodDescriptorId;
            specification.BeginDate = request.BeginDate;
            specification.EndDate = request.EndDate;
                    }
                public IHttpActionResult GetByKey([FromUri] int assessmentPeriodDescriptorId)
        {
            var request = new Api.Models.Requests.v2.AssessmentPeriodDescriptors.AssessmentPeriodDescriptorGetByKey
            {
                AssessmentPeriodDescriptorId = assessmentPeriodDescriptorId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IAssessmentPeriodDescriptor request)
        {
            return 
                request.AssessmentPeriodDescriptorId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "assessmentPeriodDescriptors";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.AssessmentReportingMethodTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class AssessmentReportingMethodTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.AssessmentReportingMethodType.AssessmentReportingMethodType, 
        EdFi.Ods.Api.Models.Resources.V2.AssessmentReportingMethodType.AssessmentReportingMethodType, 
        EdFi.Ods.Entities.Common.IAssessmentReportingMethodType, 
        // EdFi.Ods.Entities.NHibernate.AssessmentReportingMethodTypeAggregate.AssessmentReportingMethodType, 
        Api.Models.Requests.v2.AssessmentReportingMethodTypes.AssessmentReportingMethodTypeGetByKey, 
        Api.Models.Requests.v2.AssessmentReportingMethodTypes.AssessmentReportingMethodTypePut,
        Api.Models.Requests.v2.AssessmentReportingMethodTypes.AssessmentReportingMethodTypePost,
        Api.Models.Requests.v2.AssessmentReportingMethodTypes.AssessmentReportingMethodTypeDelete,
        Api.Models.Requests.v2.AssessmentReportingMethodTypes.AssessmentReportingMethodTypeGetByExample>
    {
        public AssessmentReportingMethodTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.AssessmentReportingMethodTypes.AssessmentReportingMethodTypeGetByKey request, IAssessmentReportingMethodType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.AssessmentReportingMethodTypeId = request.AssessmentReportingMethodTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.AssessmentReportingMethodTypes.AssessmentReportingMethodTypeGetByExample request, IAssessmentReportingMethodType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.AssessmentReportingMethodTypeId = request.AssessmentReportingMethodTypeId;
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int assessmentReportingMethodTypeId)
        {
            var request = new Api.Models.Requests.v2.AssessmentReportingMethodTypes.AssessmentReportingMethodTypeGetByKey
            {
                AssessmentReportingMethodTypeId = assessmentReportingMethodTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IAssessmentReportingMethodType request)
        {
            return 
                request.AssessmentReportingMethodTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "assessmentReportingMethodTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.AttendanceEventCategoryDescriptors
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class AttendanceEventCategoryDescriptorsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.AttendanceEventCategoryDescriptor.AttendanceEventCategoryDescriptor, 
        EdFi.Ods.Api.Models.Resources.V2.AttendanceEventCategoryDescriptor.AttendanceEventCategoryDescriptor, 
        EdFi.Ods.Entities.Common.IAttendanceEventCategoryDescriptor, 
        // EdFi.Ods.Entities.NHibernate.AttendanceEventCategoryDescriptorAggregate.AttendanceEventCategoryDescriptor, 
        Api.Models.Requests.v2.AttendanceEventCategoryDescriptors.AttendanceEventCategoryDescriptorGetByKey, 
        Api.Models.Requests.v2.AttendanceEventCategoryDescriptors.AttendanceEventCategoryDescriptorPut,
        Api.Models.Requests.v2.AttendanceEventCategoryDescriptors.AttendanceEventCategoryDescriptorPost,
        Api.Models.Requests.v2.AttendanceEventCategoryDescriptors.AttendanceEventCategoryDescriptorDelete,
        Api.Models.Requests.v2.AttendanceEventCategoryDescriptors.AttendanceEventCategoryDescriptorGetByExample>
    {
        public AttendanceEventCategoryDescriptorsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.AttendanceEventCategoryDescriptors.AttendanceEventCategoryDescriptorGetByKey request, IAttendanceEventCategoryDescriptor specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.AttendanceEventCategoryDescriptorId = request.AttendanceEventCategoryDescriptorId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.AttendanceEventCategoryDescriptors.AttendanceEventCategoryDescriptorGetByExample request, IAttendanceEventCategoryDescriptor specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.AttendanceEventCategoryDescriptorId = request.AttendanceEventCategoryDescriptorId;
            specification.AttendanceEventCategoryType = request.AttendanceEventCategoryType;
                    }
                public IHttpActionResult GetByKey([FromUri] int attendanceEventCategoryDescriptorId)
        {
            var request = new Api.Models.Requests.v2.AttendanceEventCategoryDescriptors.AttendanceEventCategoryDescriptorGetByKey
            {
                AttendanceEventCategoryDescriptorId = attendanceEventCategoryDescriptorId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IAttendanceEventCategoryDescriptor request)
        {
            return 
                request.AttendanceEventCategoryDescriptorId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "attendanceEventCategoryDescriptors";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.AttendanceEventCategoryTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class AttendanceEventCategoryTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.AttendanceEventCategoryType.AttendanceEventCategoryType, 
        EdFi.Ods.Api.Models.Resources.V2.AttendanceEventCategoryType.AttendanceEventCategoryType, 
        EdFi.Ods.Entities.Common.IAttendanceEventCategoryType, 
        // EdFi.Ods.Entities.NHibernate.AttendanceEventCategoryTypeAggregate.AttendanceEventCategoryType, 
        Api.Models.Requests.v2.AttendanceEventCategoryTypes.AttendanceEventCategoryTypeGetByKey, 
        Api.Models.Requests.v2.AttendanceEventCategoryTypes.AttendanceEventCategoryTypePut,
        Api.Models.Requests.v2.AttendanceEventCategoryTypes.AttendanceEventCategoryTypePost,
        Api.Models.Requests.v2.AttendanceEventCategoryTypes.AttendanceEventCategoryTypeDelete,
        Api.Models.Requests.v2.AttendanceEventCategoryTypes.AttendanceEventCategoryTypeGetByExample>
    {
        public AttendanceEventCategoryTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.AttendanceEventCategoryTypes.AttendanceEventCategoryTypeGetByKey request, IAttendanceEventCategoryType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.AttendanceEventCategoryTypeId = request.AttendanceEventCategoryTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.AttendanceEventCategoryTypes.AttendanceEventCategoryTypeGetByExample request, IAttendanceEventCategoryType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.AttendanceEventCategoryTypeId = request.AttendanceEventCategoryTypeId;
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int attendanceEventCategoryTypeId)
        {
            var request = new Api.Models.Requests.v2.AttendanceEventCategoryTypes.AttendanceEventCategoryTypeGetByKey
            {
                AttendanceEventCategoryTypeId = attendanceEventCategoryTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IAttendanceEventCategoryType request)
        {
            return 
                request.AttendanceEventCategoryTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "attendanceEventCategoryTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.BehaviorDescriptors
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class BehaviorDescriptorsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.BehaviorDescriptor.BehaviorDescriptor, 
        EdFi.Ods.Api.Models.Resources.V2.BehaviorDescriptor.BehaviorDescriptor, 
        EdFi.Ods.Entities.Common.IBehaviorDescriptor, 
        // EdFi.Ods.Entities.NHibernate.BehaviorDescriptorAggregate.BehaviorDescriptor, 
        Api.Models.Requests.v2.BehaviorDescriptors.BehaviorDescriptorGetByKey, 
        Api.Models.Requests.v2.BehaviorDescriptors.BehaviorDescriptorPut,
        Api.Models.Requests.v2.BehaviorDescriptors.BehaviorDescriptorPost,
        Api.Models.Requests.v2.BehaviorDescriptors.BehaviorDescriptorDelete,
        Api.Models.Requests.v2.BehaviorDescriptors.BehaviorDescriptorGetByExample>
    {
        public BehaviorDescriptorsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.BehaviorDescriptors.BehaviorDescriptorGetByKey request, IBehaviorDescriptor specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.BehaviorDescriptorId = request.BehaviorDescriptorId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.BehaviorDescriptors.BehaviorDescriptorGetByExample request, IBehaviorDescriptor specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.BehaviorDescriptorId = request.BehaviorDescriptorId;
            specification.BehaviorType = request.BehaviorType;
                    }
                public IHttpActionResult GetByKey([FromUri] int behaviorDescriptorId)
        {
            var request = new Api.Models.Requests.v2.BehaviorDescriptors.BehaviorDescriptorGetByKey
            {
                BehaviorDescriptorId = behaviorDescriptorId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IBehaviorDescriptor request)
        {
            return 
                request.BehaviorDescriptorId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "behaviorDescriptors";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.BehaviorTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class BehaviorTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.BehaviorType.BehaviorType, 
        EdFi.Ods.Api.Models.Resources.V2.BehaviorType.BehaviorType, 
        EdFi.Ods.Entities.Common.IBehaviorType, 
        // EdFi.Ods.Entities.NHibernate.BehaviorTypeAggregate.BehaviorType, 
        Api.Models.Requests.v2.BehaviorTypes.BehaviorTypeGetByKey, 
        Api.Models.Requests.v2.BehaviorTypes.BehaviorTypePut,
        Api.Models.Requests.v2.BehaviorTypes.BehaviorTypePost,
        Api.Models.Requests.v2.BehaviorTypes.BehaviorTypeDelete,
        Api.Models.Requests.v2.BehaviorTypes.BehaviorTypeGetByExample>
    {
        public BehaviorTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.BehaviorTypes.BehaviorTypeGetByKey request, IBehaviorType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.BehaviorTypeId = request.BehaviorTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.BehaviorTypes.BehaviorTypeGetByExample request, IBehaviorType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.BehaviorTypeId = request.BehaviorTypeId;
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int behaviorTypeId)
        {
            var request = new Api.Models.Requests.v2.BehaviorTypes.BehaviorTypeGetByKey
            {
                BehaviorTypeId = behaviorTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IBehaviorType request)
        {
            return 
                request.BehaviorTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "behaviorTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.BellSchedules
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class BellSchedulesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.BellSchedule.BellSchedule, 
        EdFi.Ods.Api.Models.Resources.V2.BellSchedule.BellSchedule, 
        EdFi.Ods.Entities.Common.IBellSchedule, 
        // EdFi.Ods.Entities.NHibernate.BellScheduleAggregate.BellSchedule, 
        Api.Models.Requests.v2.BellSchedules.BellScheduleGetByKey, 
        Api.Models.Requests.v2.BellSchedules.BellSchedulePut,
        Api.Models.Requests.v2.BellSchedules.BellSchedulePost,
        Api.Models.Requests.v2.BellSchedules.BellScheduleDelete,
        Api.Models.Requests.v2.BellSchedules.BellScheduleGetByExample>
    {
        public BellSchedulesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.BellSchedules.BellScheduleGetByKey request, IBellSchedule specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.BellScheduleName = request.Name;
            specification.Date = request.Date;
            specification.GradeLevelDescriptor = request.GradeLevelDescriptor;
            specification.SchoolId = request.SchoolId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.BellSchedules.BellScheduleGetByExample request, IBellSchedule specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.BellScheduleName = request.Name;
            specification.Date = request.Date;
            specification.GradeLevelDescriptor = request.GradeLevelDescriptor;
            specification.Id = request.Id;
            specification.SchoolId = request.SchoolId;
                    }
                public IHttpActionResult GetByKey([FromUri] string name, DateTime date, string gradeLevelDescriptor, int schoolId)
        {
            var request = new Api.Models.Requests.v2.BellSchedules.BellScheduleGetByKey
            {
                Name = name,
                Date = date,
                GradeLevelDescriptor = gradeLevelDescriptor,
                SchoolId = schoolId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IBellSchedule request)
        {
            return 
                request.BellScheduleName != default(string)
                && request.Date != default(DateTime)
                && request.GradeLevelDescriptor != null
                && request.SchoolId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "bellSchedules";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.Budgets
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class BudgetsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.Budget.Budget, 
        EdFi.Ods.Api.Models.Resources.V2.Budget.Budget, 
        EdFi.Ods.Entities.Common.IBudget, 
        // EdFi.Ods.Entities.NHibernate.BudgetAggregate.Budget, 
        Api.Models.Requests.v2.Budgets.BudgetGetByKey, 
        Api.Models.Requests.v2.Budgets.BudgetPut,
        Api.Models.Requests.v2.Budgets.BudgetPost,
        Api.Models.Requests.v2.Budgets.BudgetDelete,
        Api.Models.Requests.v2.Budgets.BudgetGetByExample>
    {
        public BudgetsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.Budgets.BudgetGetByKey request, IBudget specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.AccountNumber = request.AccountNumber;
            specification.AsOfDate = request.AsOfDate;
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.FiscalYear = request.FiscalYear;
                    }

        protected override void MapAll(Api.Models.Requests.v2.Budgets.BudgetGetByExample request, IBudget specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.AccountNumber = request.AccountNumber;
            specification.Amount = request.Amount;
            specification.AsOfDate = request.AsOfDate;
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.FiscalYear = request.FiscalYear;
            specification.Id = request.Id;
                    }
                public IHttpActionResult GetByKey([FromUri] string accountNumber, DateTime asOfDate, int educationOrganizationId, int fiscalYear)
        {
            var request = new Api.Models.Requests.v2.Budgets.BudgetGetByKey
            {
                AccountNumber = accountNumber,
                AsOfDate = asOfDate,
                EducationOrganizationId = educationOrganizationId,
                FiscalYear = fiscalYear,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IBudget request)
        {
            return 
                request.AccountNumber != default(string)
                && request.AsOfDate != default(DateTime)
                && request.EducationOrganizationId != default(int)
                && request.FiscalYear != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "budgets";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.CalendarDates
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class CalendarDatesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.CalendarDate.CalendarDate, 
        EdFi.Ods.Api.Models.Resources.V2.CalendarDate.CalendarDate, 
        EdFi.Ods.Entities.Common.ICalendarDate, 
        // EdFi.Ods.Entities.NHibernate.CalendarDateAggregate.CalendarDate, 
        Api.Models.Requests.v2.CalendarDates.CalendarDateGetByKey, 
        Api.Models.Requests.v2.CalendarDates.CalendarDatePut,
        Api.Models.Requests.v2.CalendarDates.CalendarDatePost,
        Api.Models.Requests.v2.CalendarDates.CalendarDateDelete,
        Api.Models.Requests.v2.CalendarDates.CalendarDateGetByExample>
    {
        public CalendarDatesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.CalendarDates.CalendarDateGetByKey request, ICalendarDate specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.Date = request.Date;
            specification.SchoolId = request.SchoolId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.CalendarDates.CalendarDateGetByExample request, ICalendarDate specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.Date = request.Date;
            specification.Id = request.Id;
            specification.SchoolId = request.SchoolId;
                    }
                public IHttpActionResult GetByKey([FromUri] DateTime date, int schoolId)
        {
            var request = new Api.Models.Requests.v2.CalendarDates.CalendarDateGetByKey
            {
                Date = date,
                SchoolId = schoolId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(ICalendarDate request)
        {
            return 
                request.Date != default(DateTime)
                && request.SchoolId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "calendarDates";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.CalendarEventDescriptors
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class CalendarEventDescriptorsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.CalendarEventDescriptor.CalendarEventDescriptor, 
        EdFi.Ods.Api.Models.Resources.V2.CalendarEventDescriptor.CalendarEventDescriptor, 
        EdFi.Ods.Entities.Common.ICalendarEventDescriptor, 
        // EdFi.Ods.Entities.NHibernate.CalendarEventDescriptorAggregate.CalendarEventDescriptor, 
        Api.Models.Requests.v2.CalendarEventDescriptors.CalendarEventDescriptorGetByKey, 
        Api.Models.Requests.v2.CalendarEventDescriptors.CalendarEventDescriptorPut,
        Api.Models.Requests.v2.CalendarEventDescriptors.CalendarEventDescriptorPost,
        Api.Models.Requests.v2.CalendarEventDescriptors.CalendarEventDescriptorDelete,
        Api.Models.Requests.v2.CalendarEventDescriptors.CalendarEventDescriptorGetByExample>
    {
        public CalendarEventDescriptorsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.CalendarEventDescriptors.CalendarEventDescriptorGetByKey request, ICalendarEventDescriptor specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.CalendarEventDescriptorId = request.CalendarEventDescriptorId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.CalendarEventDescriptors.CalendarEventDescriptorGetByExample request, ICalendarEventDescriptor specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CalendarEventDescriptorId = request.CalendarEventDescriptorId;
            specification.CalendarEventType = request.CalendarEventType;
                    }
                public IHttpActionResult GetByKey([FromUri] int calendarEventDescriptorId)
        {
            var request = new Api.Models.Requests.v2.CalendarEventDescriptors.CalendarEventDescriptorGetByKey
            {
                CalendarEventDescriptorId = calendarEventDescriptorId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(ICalendarEventDescriptor request)
        {
            return 
                request.CalendarEventDescriptorId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "calendarEventDescriptors";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.CalendarEventTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class CalendarEventTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.CalendarEventType.CalendarEventType, 
        EdFi.Ods.Api.Models.Resources.V2.CalendarEventType.CalendarEventType, 
        EdFi.Ods.Entities.Common.ICalendarEventType, 
        // EdFi.Ods.Entities.NHibernate.CalendarEventTypeAggregate.CalendarEventType, 
        Api.Models.Requests.v2.CalendarEventTypes.CalendarEventTypeGetByKey, 
        Api.Models.Requests.v2.CalendarEventTypes.CalendarEventTypePut,
        Api.Models.Requests.v2.CalendarEventTypes.CalendarEventTypePost,
        Api.Models.Requests.v2.CalendarEventTypes.CalendarEventTypeDelete,
        Api.Models.Requests.v2.CalendarEventTypes.CalendarEventTypeGetByExample>
    {
        public CalendarEventTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.CalendarEventTypes.CalendarEventTypeGetByKey request, ICalendarEventType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.CalendarEventTypeId = request.CalendarEventTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.CalendarEventTypes.CalendarEventTypeGetByExample request, ICalendarEventType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CalendarEventTypeId = request.CalendarEventTypeId;
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int calendarEventTypeId)
        {
            var request = new Api.Models.Requests.v2.CalendarEventTypes.CalendarEventTypeGetByKey
            {
                CalendarEventTypeId = calendarEventTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(ICalendarEventType request)
        {
            return 
                request.CalendarEventTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "calendarEventTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.CareerPathwayTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class CareerPathwayTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.CareerPathwayType.CareerPathwayType, 
        EdFi.Ods.Api.Models.Resources.V2.CareerPathwayType.CareerPathwayType, 
        EdFi.Ods.Entities.Common.ICareerPathwayType, 
        // EdFi.Ods.Entities.NHibernate.CareerPathwayTypeAggregate.CareerPathwayType, 
        Api.Models.Requests.v2.CareerPathwayTypes.CareerPathwayTypeGetByKey, 
        Api.Models.Requests.v2.CareerPathwayTypes.CareerPathwayTypePut,
        Api.Models.Requests.v2.CareerPathwayTypes.CareerPathwayTypePost,
        Api.Models.Requests.v2.CareerPathwayTypes.CareerPathwayTypeDelete,
        Api.Models.Requests.v2.CareerPathwayTypes.CareerPathwayTypeGetByExample>
    {
        public CareerPathwayTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.CareerPathwayTypes.CareerPathwayTypeGetByKey request, ICareerPathwayType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.CareerPathwayTypeId = request.CareerPathwayTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.CareerPathwayTypes.CareerPathwayTypeGetByExample request, ICareerPathwayType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CareerPathwayTypeId = request.CareerPathwayTypeId;
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int careerPathwayTypeId)
        {
            var request = new Api.Models.Requests.v2.CareerPathwayTypes.CareerPathwayTypeGetByKey
            {
                CareerPathwayTypeId = careerPathwayTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(ICareerPathwayType request)
        {
            return 
                request.CareerPathwayTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "careerPathwayTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.CharterApprovalAgencyTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class CharterApprovalAgencyTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.CharterApprovalAgencyType.CharterApprovalAgencyType, 
        EdFi.Ods.Api.Models.Resources.V2.CharterApprovalAgencyType.CharterApprovalAgencyType, 
        EdFi.Ods.Entities.Common.ICharterApprovalAgencyType, 
        // EdFi.Ods.Entities.NHibernate.CharterApprovalAgencyTypeAggregate.CharterApprovalAgencyType, 
        Api.Models.Requests.v2.CharterApprovalAgencyTypes.CharterApprovalAgencyTypeGetByKey, 
        Api.Models.Requests.v2.CharterApprovalAgencyTypes.CharterApprovalAgencyTypePut,
        Api.Models.Requests.v2.CharterApprovalAgencyTypes.CharterApprovalAgencyTypePost,
        Api.Models.Requests.v2.CharterApprovalAgencyTypes.CharterApprovalAgencyTypeDelete,
        Api.Models.Requests.v2.CharterApprovalAgencyTypes.CharterApprovalAgencyTypeGetByExample>
    {
        public CharterApprovalAgencyTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.CharterApprovalAgencyTypes.CharterApprovalAgencyTypeGetByKey request, ICharterApprovalAgencyType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.CharterApprovalAgencyTypeId = request.CharterApprovalAgencyTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.CharterApprovalAgencyTypes.CharterApprovalAgencyTypeGetByExample request, ICharterApprovalAgencyType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CharterApprovalAgencyTypeId = request.CharterApprovalAgencyTypeId;
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int charterApprovalAgencyTypeId)
        {
            var request = new Api.Models.Requests.v2.CharterApprovalAgencyTypes.CharterApprovalAgencyTypeGetByKey
            {
                CharterApprovalAgencyTypeId = charterApprovalAgencyTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(ICharterApprovalAgencyType request)
        {
            return 
                request.CharterApprovalAgencyTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "charterApprovalAgencyTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.CharterStatusTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class CharterStatusTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.CharterStatusType.CharterStatusType, 
        EdFi.Ods.Api.Models.Resources.V2.CharterStatusType.CharterStatusType, 
        EdFi.Ods.Entities.Common.ICharterStatusType, 
        // EdFi.Ods.Entities.NHibernate.CharterStatusTypeAggregate.CharterStatusType, 
        Api.Models.Requests.v2.CharterStatusTypes.CharterStatusTypeGetByKey, 
        Api.Models.Requests.v2.CharterStatusTypes.CharterStatusTypePut,
        Api.Models.Requests.v2.CharterStatusTypes.CharterStatusTypePost,
        Api.Models.Requests.v2.CharterStatusTypes.CharterStatusTypeDelete,
        Api.Models.Requests.v2.CharterStatusTypes.CharterStatusTypeGetByExample>
    {
        public CharterStatusTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.CharterStatusTypes.CharterStatusTypeGetByKey request, ICharterStatusType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.CharterStatusTypeId = request.CharterStatusTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.CharterStatusTypes.CharterStatusTypeGetByExample request, ICharterStatusType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CharterStatusTypeId = request.CharterStatusTypeId;
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int charterStatusTypeId)
        {
            var request = new Api.Models.Requests.v2.CharterStatusTypes.CharterStatusTypeGetByKey
            {
                CharterStatusTypeId = charterStatusTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(ICharterStatusType request)
        {
            return 
                request.CharterStatusTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "charterStatusTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.CitizenshipStatusTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class CitizenshipStatusTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.CitizenshipStatusType.CitizenshipStatusType, 
        EdFi.Ods.Api.Models.Resources.V2.CitizenshipStatusType.CitizenshipStatusType, 
        EdFi.Ods.Entities.Common.ICitizenshipStatusType, 
        // EdFi.Ods.Entities.NHibernate.CitizenshipStatusTypeAggregate.CitizenshipStatusType, 
        Api.Models.Requests.v2.CitizenshipStatusTypes.CitizenshipStatusTypeGetByKey, 
        Api.Models.Requests.v2.CitizenshipStatusTypes.CitizenshipStatusTypePut,
        Api.Models.Requests.v2.CitizenshipStatusTypes.CitizenshipStatusTypePost,
        Api.Models.Requests.v2.CitizenshipStatusTypes.CitizenshipStatusTypeDelete,
        Api.Models.Requests.v2.CitizenshipStatusTypes.CitizenshipStatusTypeGetByExample>
    {
        public CitizenshipStatusTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.CitizenshipStatusTypes.CitizenshipStatusTypeGetByKey request, ICitizenshipStatusType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.CitizenshipStatusTypeId = request.CitizenshipStatusTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.CitizenshipStatusTypes.CitizenshipStatusTypeGetByExample request, ICitizenshipStatusType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CitizenshipStatusTypeId = request.CitizenshipStatusTypeId;
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int citizenshipStatusTypeId)
        {
            var request = new Api.Models.Requests.v2.CitizenshipStatusTypes.CitizenshipStatusTypeGetByKey
            {
                CitizenshipStatusTypeId = citizenshipStatusTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(ICitizenshipStatusType request)
        {
            return 
                request.CitizenshipStatusTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "citizenshipStatusTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.ClassPeriods
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class ClassPeriodsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.ClassPeriod.ClassPeriod, 
        EdFi.Ods.Api.Models.Resources.V2.ClassPeriod.ClassPeriod, 
        EdFi.Ods.Entities.Common.IClassPeriod, 
        // EdFi.Ods.Entities.NHibernate.ClassPeriodAggregate.ClassPeriod, 
        Api.Models.Requests.v2.ClassPeriods.ClassPeriodGetByKey, 
        Api.Models.Requests.v2.ClassPeriods.ClassPeriodPut,
        Api.Models.Requests.v2.ClassPeriods.ClassPeriodPost,
        Api.Models.Requests.v2.ClassPeriods.ClassPeriodDelete,
        Api.Models.Requests.v2.ClassPeriods.ClassPeriodGetByExample>
    {
        public ClassPeriodsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.ClassPeriods.ClassPeriodGetByKey request, IClassPeriod specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.ClassPeriodName = request.Name;
            specification.SchoolId = request.SchoolId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.ClassPeriods.ClassPeriodGetByExample request, IClassPeriod specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.ClassPeriodName = request.Name;
            specification.Id = request.Id;
            specification.SchoolId = request.SchoolId;
                    }
                public IHttpActionResult GetByKey([FromUri] string name, int schoolId)
        {
            var request = new Api.Models.Requests.v2.ClassPeriods.ClassPeriodGetByKey
            {
                Name = name,
                SchoolId = schoolId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IClassPeriod request)
        {
            return 
                request.ClassPeriodName != default(string)
                && request.SchoolId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "classPeriods";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.ClassroomPositionDescriptors
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class ClassroomPositionDescriptorsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.ClassroomPositionDescriptor.ClassroomPositionDescriptor, 
        EdFi.Ods.Api.Models.Resources.V2.ClassroomPositionDescriptor.ClassroomPositionDescriptor, 
        EdFi.Ods.Entities.Common.IClassroomPositionDescriptor, 
        // EdFi.Ods.Entities.NHibernate.ClassroomPositionDescriptorAggregate.ClassroomPositionDescriptor, 
        Api.Models.Requests.v2.ClassroomPositionDescriptors.ClassroomPositionDescriptorGetByKey, 
        Api.Models.Requests.v2.ClassroomPositionDescriptors.ClassroomPositionDescriptorPut,
        Api.Models.Requests.v2.ClassroomPositionDescriptors.ClassroomPositionDescriptorPost,
        Api.Models.Requests.v2.ClassroomPositionDescriptors.ClassroomPositionDescriptorDelete,
        Api.Models.Requests.v2.ClassroomPositionDescriptors.ClassroomPositionDescriptorGetByExample>
    {
        public ClassroomPositionDescriptorsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.ClassroomPositionDescriptors.ClassroomPositionDescriptorGetByKey request, IClassroomPositionDescriptor specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.ClassroomPositionDescriptorId = request.ClassroomPositionDescriptorId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.ClassroomPositionDescriptors.ClassroomPositionDescriptorGetByExample request, IClassroomPositionDescriptor specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.ClassroomPositionDescriptorId = request.ClassroomPositionDescriptorId;
            specification.ClassroomPositionType = request.ClassroomPositionType;
                    }
                public IHttpActionResult GetByKey([FromUri] int classroomPositionDescriptorId)
        {
            var request = new Api.Models.Requests.v2.ClassroomPositionDescriptors.ClassroomPositionDescriptorGetByKey
            {
                ClassroomPositionDescriptorId = classroomPositionDescriptorId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IClassroomPositionDescriptor request)
        {
            return 
                request.ClassroomPositionDescriptorId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "classroomPositionDescriptors";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.ClassroomPositionTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class ClassroomPositionTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.ClassroomPositionType.ClassroomPositionType, 
        EdFi.Ods.Api.Models.Resources.V2.ClassroomPositionType.ClassroomPositionType, 
        EdFi.Ods.Entities.Common.IClassroomPositionType, 
        // EdFi.Ods.Entities.NHibernate.ClassroomPositionTypeAggregate.ClassroomPositionType, 
        Api.Models.Requests.v2.ClassroomPositionTypes.ClassroomPositionTypeGetByKey, 
        Api.Models.Requests.v2.ClassroomPositionTypes.ClassroomPositionTypePut,
        Api.Models.Requests.v2.ClassroomPositionTypes.ClassroomPositionTypePost,
        Api.Models.Requests.v2.ClassroomPositionTypes.ClassroomPositionTypeDelete,
        Api.Models.Requests.v2.ClassroomPositionTypes.ClassroomPositionTypeGetByExample>
    {
        public ClassroomPositionTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.ClassroomPositionTypes.ClassroomPositionTypeGetByKey request, IClassroomPositionType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.ClassroomPositionTypeId = request.ClassroomPositionTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.ClassroomPositionTypes.ClassroomPositionTypeGetByExample request, IClassroomPositionType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.ClassroomPositionTypeId = request.ClassroomPositionTypeId;
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int classroomPositionTypeId)
        {
            var request = new Api.Models.Requests.v2.ClassroomPositionTypes.ClassroomPositionTypeGetByKey
            {
                ClassroomPositionTypeId = classroomPositionTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IClassroomPositionType request)
        {
            return 
                request.ClassroomPositionTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "classroomPositionTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.Cohorts
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class CohortsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.Cohort.Cohort, 
        EdFi.Ods.Api.Models.Resources.V2.Cohort.Cohort, 
        EdFi.Ods.Entities.Common.ICohort, 
        // EdFi.Ods.Entities.NHibernate.CohortAggregate.Cohort, 
        Api.Models.Requests.v2.Cohorts.CohortGetByKey, 
        Api.Models.Requests.v2.Cohorts.CohortPut,
        Api.Models.Requests.v2.Cohorts.CohortPost,
        Api.Models.Requests.v2.Cohorts.CohortDelete,
        Api.Models.Requests.v2.Cohorts.CohortGetByExample>
    {
        public CohortsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.Cohorts.CohortGetByKey request, ICohort specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.CohortIdentifier = request.Identifier;
            specification.EducationOrganizationId = request.EducationOrganizationId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.Cohorts.CohortGetByExample request, ICohort specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.AcademicSubjectDescriptor = request.AcademicSubjectDescriptor;
            specification.CohortDescription = request.Description;
            specification.CohortIdentifier = request.Identifier;
            specification.CohortScopeType = request.ScopeType;
            specification.CohortType = request.Type;
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.Id = request.Id;
                    }
                public IHttpActionResult GetByKey([FromUri] string identifier, int educationOrganizationId)
        {
            var request = new Api.Models.Requests.v2.Cohorts.CohortGetByKey
            {
                Identifier = identifier,
                EducationOrganizationId = educationOrganizationId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(ICohort request)
        {
            return 
                request.CohortIdentifier != default(string)
                && request.EducationOrganizationId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "cohorts";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.CohortScopeTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class CohortScopeTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.CohortScopeType.CohortScopeType, 
        EdFi.Ods.Api.Models.Resources.V2.CohortScopeType.CohortScopeType, 
        EdFi.Ods.Entities.Common.ICohortScopeType, 
        // EdFi.Ods.Entities.NHibernate.CohortScopeTypeAggregate.CohortScopeType, 
        Api.Models.Requests.v2.CohortScopeTypes.CohortScopeTypeGetByKey, 
        Api.Models.Requests.v2.CohortScopeTypes.CohortScopeTypePut,
        Api.Models.Requests.v2.CohortScopeTypes.CohortScopeTypePost,
        Api.Models.Requests.v2.CohortScopeTypes.CohortScopeTypeDelete,
        Api.Models.Requests.v2.CohortScopeTypes.CohortScopeTypeGetByExample>
    {
        public CohortScopeTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.CohortScopeTypes.CohortScopeTypeGetByKey request, ICohortScopeType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.CohortScopeTypeId = request.CohortScopeTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.CohortScopeTypes.CohortScopeTypeGetByExample request, ICohortScopeType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.CohortScopeTypeId = request.CohortScopeTypeId;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int cohortScopeTypeId)
        {
            var request = new Api.Models.Requests.v2.CohortScopeTypes.CohortScopeTypeGetByKey
            {
                CohortScopeTypeId = cohortScopeTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(ICohortScopeType request)
        {
            return 
                request.CohortScopeTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "cohortScopeTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.CohortTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class CohortTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.CohortType.CohortType, 
        EdFi.Ods.Api.Models.Resources.V2.CohortType.CohortType, 
        EdFi.Ods.Entities.Common.ICohortType, 
        // EdFi.Ods.Entities.NHibernate.CohortTypeAggregate.CohortType, 
        Api.Models.Requests.v2.CohortTypes.CohortTypeGetByKey, 
        Api.Models.Requests.v2.CohortTypes.CohortTypePut,
        Api.Models.Requests.v2.CohortTypes.CohortTypePost,
        Api.Models.Requests.v2.CohortTypes.CohortTypeDelete,
        Api.Models.Requests.v2.CohortTypes.CohortTypeGetByExample>
    {
        public CohortTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.CohortTypes.CohortTypeGetByKey request, ICohortType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.CohortTypeId = request.CohortTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.CohortTypes.CohortTypeGetByExample request, ICohortType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.CohortTypeId = request.CohortTypeId;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int cohortTypeId)
        {
            var request = new Api.Models.Requests.v2.CohortTypes.CohortTypeGetByKey
            {
                CohortTypeId = cohortTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(ICohortType request)
        {
            return 
                request.CohortTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "cohortTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.CohortYearTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class CohortYearTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.CohortYearType.CohortYearType, 
        EdFi.Ods.Api.Models.Resources.V2.CohortYearType.CohortYearType, 
        EdFi.Ods.Entities.Common.ICohortYearType, 
        // EdFi.Ods.Entities.NHibernate.CohortYearTypeAggregate.CohortYearType, 
        Api.Models.Requests.v2.CohortYearTypes.CohortYearTypeGetByKey, 
        Api.Models.Requests.v2.CohortYearTypes.CohortYearTypePut,
        Api.Models.Requests.v2.CohortYearTypes.CohortYearTypePost,
        Api.Models.Requests.v2.CohortYearTypes.CohortYearTypeDelete,
        Api.Models.Requests.v2.CohortYearTypes.CohortYearTypeGetByExample>
    {
        public CohortYearTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.CohortYearTypes.CohortYearTypeGetByKey request, ICohortYearType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.CohortYearTypeId = request.CohortYearTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.CohortYearTypes.CohortYearTypeGetByExample request, ICohortYearType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.CohortYearTypeId = request.CohortYearTypeId;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int cohortYearTypeId)
        {
            var request = new Api.Models.Requests.v2.CohortYearTypes.CohortYearTypeGetByKey
            {
                CohortYearTypeId = cohortYearTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(ICohortYearType request)
        {
            return 
                request.CohortYearTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "cohortYearTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.CompetencyLevelDescriptors
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class CompetencyLevelDescriptorsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.CompetencyLevelDescriptor.CompetencyLevelDescriptor, 
        EdFi.Ods.Api.Models.Resources.V2.CompetencyLevelDescriptor.CompetencyLevelDescriptor, 
        EdFi.Ods.Entities.Common.ICompetencyLevelDescriptor, 
        // EdFi.Ods.Entities.NHibernate.CompetencyLevelDescriptorAggregate.CompetencyLevelDescriptor, 
        Api.Models.Requests.v2.CompetencyLevelDescriptors.CompetencyLevelDescriptorGetByKey, 
        Api.Models.Requests.v2.CompetencyLevelDescriptors.CompetencyLevelDescriptorPut,
        Api.Models.Requests.v2.CompetencyLevelDescriptors.CompetencyLevelDescriptorPost,
        Api.Models.Requests.v2.CompetencyLevelDescriptors.CompetencyLevelDescriptorDelete,
        Api.Models.Requests.v2.CompetencyLevelDescriptors.CompetencyLevelDescriptorGetByExample>
    {
        public CompetencyLevelDescriptorsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.CompetencyLevelDescriptors.CompetencyLevelDescriptorGetByKey request, ICompetencyLevelDescriptor specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.CompetencyLevelDescriptorId = request.CompetencyLevelDescriptorId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.CompetencyLevelDescriptors.CompetencyLevelDescriptorGetByExample request, ICompetencyLevelDescriptor specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CompetencyLevelDescriptorId = request.CompetencyLevelDescriptorId;
            specification.PerformanceBaseConversionType = request.PerformanceBaseConversionType;
                    }
                public IHttpActionResult GetByKey([FromUri] int competencyLevelDescriptorId)
        {
            var request = new Api.Models.Requests.v2.CompetencyLevelDescriptors.CompetencyLevelDescriptorGetByKey
            {
                CompetencyLevelDescriptorId = competencyLevelDescriptorId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(ICompetencyLevelDescriptor request)
        {
            return 
                request.CompetencyLevelDescriptorId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "competencyLevelDescriptors";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.CompetencyObjectives
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class CompetencyObjectivesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.CompetencyObjective.CompetencyObjective, 
        EdFi.Ods.Api.Models.Resources.V2.CompetencyObjective.CompetencyObjective, 
        EdFi.Ods.Entities.Common.ICompetencyObjective, 
        // EdFi.Ods.Entities.NHibernate.CompetencyObjectiveAggregate.CompetencyObjective, 
        Api.Models.Requests.v2.CompetencyObjectives.CompetencyObjectiveGetByKey, 
        Api.Models.Requests.v2.CompetencyObjectives.CompetencyObjectivePut,
        Api.Models.Requests.v2.CompetencyObjectives.CompetencyObjectivePost,
        Api.Models.Requests.v2.CompetencyObjectives.CompetencyObjectiveDelete,
        Api.Models.Requests.v2.CompetencyObjectives.CompetencyObjectiveGetByExample>
    {
        public CompetencyObjectivesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.CompetencyObjectives.CompetencyObjectiveGetByKey request, ICompetencyObjective specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.Objective = request.Objective;
            specification.ObjectiveGradeLevelDescriptor = request.ObjectiveGradeLevelDescriptor;
                    }

        protected override void MapAll(Api.Models.Requests.v2.CompetencyObjectives.CompetencyObjectiveGetByExample request, ICompetencyObjective specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CompetencyObjectiveId = request.CompetencyObjectiveId;
            specification.Description = request.Description;
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.Id = request.Id;
            specification.Objective = request.Objective;
            specification.ObjectiveGradeLevelDescriptor = request.ObjectiveGradeLevelDescriptor;
            specification.SuccessCriteria = request.SuccessCriteria;
                    }
                public IHttpActionResult GetByKey([FromUri] int educationOrganizationId, string objective, string objectiveGradeLevelDescriptor)
        {
            var request = new Api.Models.Requests.v2.CompetencyObjectives.CompetencyObjectiveGetByKey
            {
                EducationOrganizationId = educationOrganizationId,
                Objective = objective,
                ObjectiveGradeLevelDescriptor = objectiveGradeLevelDescriptor,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(ICompetencyObjective request)
        {
            return 
                request.EducationOrganizationId != default(int)
                && request.Objective != default(string)
                && request.ObjectiveGradeLevelDescriptor != null;
        }

        protected override string GetResourceCollectionName()
        {
            return "competencyObjectives";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.ContentClassTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class ContentClassTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.ContentClassType.ContentClassType, 
        EdFi.Ods.Api.Models.Resources.V2.ContentClassType.ContentClassType, 
        EdFi.Ods.Entities.Common.IContentClassType, 
        // EdFi.Ods.Entities.NHibernate.ContentClassTypeAggregate.ContentClassType, 
        Api.Models.Requests.v2.ContentClassTypes.ContentClassTypeGetByKey, 
        Api.Models.Requests.v2.ContentClassTypes.ContentClassTypePut,
        Api.Models.Requests.v2.ContentClassTypes.ContentClassTypePost,
        Api.Models.Requests.v2.ContentClassTypes.ContentClassTypeDelete,
        Api.Models.Requests.v2.ContentClassTypes.ContentClassTypeGetByExample>
    {
        public ContentClassTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.ContentClassTypes.ContentClassTypeGetByKey request, IContentClassType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.ContentClassTypeId = request.ContentClassTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.ContentClassTypes.ContentClassTypeGetByExample request, IContentClassType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.ContentClassTypeId = request.ContentClassTypeId;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int contentClassTypeId)
        {
            var request = new Api.Models.Requests.v2.ContentClassTypes.ContentClassTypeGetByKey
            {
                ContentClassTypeId = contentClassTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IContentClassType request)
        {
            return 
                request.ContentClassTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "contentClassTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.ContinuationOfServicesReasonDescriptors
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class ContinuationOfServicesReasonDescriptorsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.ContinuationOfServicesReasonDescriptor.ContinuationOfServicesReasonDescriptor, 
        EdFi.Ods.Api.Models.Resources.V2.ContinuationOfServicesReasonDescriptor.ContinuationOfServicesReasonDescriptor, 
        EdFi.Ods.Entities.Common.IContinuationOfServicesReasonDescriptor, 
        // EdFi.Ods.Entities.NHibernate.ContinuationOfServicesReasonDescriptorAggregate.ContinuationOfServicesReasonDescriptor, 
        Api.Models.Requests.v2.ContinuationOfServicesReasonDescriptors.ContinuationOfServicesReasonDescriptorGetByKey, 
        Api.Models.Requests.v2.ContinuationOfServicesReasonDescriptors.ContinuationOfServicesReasonDescriptorPut,
        Api.Models.Requests.v2.ContinuationOfServicesReasonDescriptors.ContinuationOfServicesReasonDescriptorPost,
        Api.Models.Requests.v2.ContinuationOfServicesReasonDescriptors.ContinuationOfServicesReasonDescriptorDelete,
        Api.Models.Requests.v2.ContinuationOfServicesReasonDescriptors.ContinuationOfServicesReasonDescriptorGetByExample>
    {
        public ContinuationOfServicesReasonDescriptorsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.ContinuationOfServicesReasonDescriptors.ContinuationOfServicesReasonDescriptorGetByKey request, IContinuationOfServicesReasonDescriptor specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.ContinuationOfServicesReasonDescriptorId = request.ContinuationOfServicesReasonDescriptorId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.ContinuationOfServicesReasonDescriptors.ContinuationOfServicesReasonDescriptorGetByExample request, IContinuationOfServicesReasonDescriptor specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.ContinuationOfServicesReasonDescriptorId = request.ContinuationOfServicesReasonDescriptorId;
            specification.ContinuationOfServicesReasonType = request.ContinuationOfServicesReasonType;
                    }
                public IHttpActionResult GetByKey([FromUri] int continuationOfServicesReasonDescriptorId)
        {
            var request = new Api.Models.Requests.v2.ContinuationOfServicesReasonDescriptors.ContinuationOfServicesReasonDescriptorGetByKey
            {
                ContinuationOfServicesReasonDescriptorId = continuationOfServicesReasonDescriptorId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IContinuationOfServicesReasonDescriptor request)
        {
            return 
                request.ContinuationOfServicesReasonDescriptorId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "continuationOfServicesReasonDescriptors";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.ContinuationOfServicesReasonTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class ContinuationOfServicesReasonTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.ContinuationOfServicesReasonType.ContinuationOfServicesReasonType, 
        EdFi.Ods.Api.Models.Resources.V2.ContinuationOfServicesReasonType.ContinuationOfServicesReasonType, 
        EdFi.Ods.Entities.Common.IContinuationOfServicesReasonType, 
        // EdFi.Ods.Entities.NHibernate.ContinuationOfServicesReasonTypeAggregate.ContinuationOfServicesReasonType, 
        Api.Models.Requests.v2.ContinuationOfServicesReasonTypes.ContinuationOfServicesReasonTypeGetByKey, 
        Api.Models.Requests.v2.ContinuationOfServicesReasonTypes.ContinuationOfServicesReasonTypePut,
        Api.Models.Requests.v2.ContinuationOfServicesReasonTypes.ContinuationOfServicesReasonTypePost,
        Api.Models.Requests.v2.ContinuationOfServicesReasonTypes.ContinuationOfServicesReasonTypeDelete,
        Api.Models.Requests.v2.ContinuationOfServicesReasonTypes.ContinuationOfServicesReasonTypeGetByExample>
    {
        public ContinuationOfServicesReasonTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.ContinuationOfServicesReasonTypes.ContinuationOfServicesReasonTypeGetByKey request, IContinuationOfServicesReasonType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.ContinuationOfServicesReasonTypeId = request.ContinuationOfServicesReasonTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.ContinuationOfServicesReasonTypes.ContinuationOfServicesReasonTypeGetByExample request, IContinuationOfServicesReasonType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.ContinuationOfServicesReasonTypeId = request.ContinuationOfServicesReasonTypeId;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int continuationOfServicesReasonTypeId)
        {
            var request = new Api.Models.Requests.v2.ContinuationOfServicesReasonTypes.ContinuationOfServicesReasonTypeGetByKey
            {
                ContinuationOfServicesReasonTypeId = continuationOfServicesReasonTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IContinuationOfServicesReasonType request)
        {
            return 
                request.ContinuationOfServicesReasonTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "continuationOfServicesReasonTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.ContractedStaffs
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class ContractedStaffsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.ContractedStaff.ContractedStaff, 
        EdFi.Ods.Api.Models.Resources.V2.ContractedStaff.ContractedStaff, 
        EdFi.Ods.Entities.Common.IContractedStaff, 
        // EdFi.Ods.Entities.NHibernate.ContractedStaffAggregate.ContractedStaff, 
        Api.Models.Requests.v2.ContractedStaffs.ContractedStaffGetByKey, 
        Api.Models.Requests.v2.ContractedStaffs.ContractedStaffPut,
        Api.Models.Requests.v2.ContractedStaffs.ContractedStaffPost,
        Api.Models.Requests.v2.ContractedStaffs.ContractedStaffDelete,
        Api.Models.Requests.v2.ContractedStaffs.ContractedStaffGetByExample>
    {
        public ContractedStaffsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.ContractedStaffs.ContractedStaffGetByKey request, IContractedStaff specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.AccountNumber = request.AccountNumber;
            specification.AsOfDate = request.AsOfDate;
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.FiscalYear = request.FiscalYear;
            specification.StaffUniqueId = request.StaffUniqueId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.ContractedStaffs.ContractedStaffGetByExample request, IContractedStaff specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.AccountNumber = request.AccountNumber;
            specification.AmountToDate = request.AmountToDate;
            specification.AsOfDate = request.AsOfDate;
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.FiscalYear = request.FiscalYear;
            specification.Id = request.Id;
            specification.StaffUniqueId = request.StaffUniqueId;
                    }
                public IHttpActionResult GetByKey([FromUri] string accountNumber, DateTime asOfDate, int educationOrganizationId, int fiscalYear, string staffUniqueId)
        {
            var request = new Api.Models.Requests.v2.ContractedStaffs.ContractedStaffGetByKey
            {
                AccountNumber = accountNumber,
                AsOfDate = asOfDate,
                EducationOrganizationId = educationOrganizationId,
                FiscalYear = fiscalYear,
                StaffUniqueId = staffUniqueId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IContractedStaff request)
        {
            return 
                request.AccountNumber != default(string)
                && request.AsOfDate != default(DateTime)
                && request.EducationOrganizationId != default(int)
                && request.FiscalYear != default(int)
                && request.StaffUniqueId != default(string);
        }

        protected override string GetResourceCollectionName()
        {
            return "contractedStaffs";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.CostRateTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class CostRateTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.CostRateType.CostRateType, 
        EdFi.Ods.Api.Models.Resources.V2.CostRateType.CostRateType, 
        EdFi.Ods.Entities.Common.ICostRateType, 
        // EdFi.Ods.Entities.NHibernate.CostRateTypeAggregate.CostRateType, 
        Api.Models.Requests.v2.CostRateTypes.CostRateTypeGetByKey, 
        Api.Models.Requests.v2.CostRateTypes.CostRateTypePut,
        Api.Models.Requests.v2.CostRateTypes.CostRateTypePost,
        Api.Models.Requests.v2.CostRateTypes.CostRateTypeDelete,
        Api.Models.Requests.v2.CostRateTypes.CostRateTypeGetByExample>
    {
        public CostRateTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.CostRateTypes.CostRateTypeGetByKey request, ICostRateType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.CostRateTypeId = request.CostRateTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.CostRateTypes.CostRateTypeGetByExample request, ICostRateType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.CostRateTypeId = request.CostRateTypeId;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int costRateTypeId)
        {
            var request = new Api.Models.Requests.v2.CostRateTypes.CostRateTypeGetByKey
            {
                CostRateTypeId = costRateTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(ICostRateType request)
        {
            return 
                request.CostRateTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "costRateTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.CountryDescriptors
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class CountryDescriptorsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.CountryDescriptor.CountryDescriptor, 
        EdFi.Ods.Api.Models.Resources.V2.CountryDescriptor.CountryDescriptor, 
        EdFi.Ods.Entities.Common.ICountryDescriptor, 
        // EdFi.Ods.Entities.NHibernate.CountryDescriptorAggregate.CountryDescriptor, 
        Api.Models.Requests.v2.CountryDescriptors.CountryDescriptorGetByKey, 
        Api.Models.Requests.v2.CountryDescriptors.CountryDescriptorPut,
        Api.Models.Requests.v2.CountryDescriptors.CountryDescriptorPost,
        Api.Models.Requests.v2.CountryDescriptors.CountryDescriptorDelete,
        Api.Models.Requests.v2.CountryDescriptors.CountryDescriptorGetByExample>
    {
        public CountryDescriptorsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.CountryDescriptors.CountryDescriptorGetByKey request, ICountryDescriptor specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.CountryDescriptorId = request.CountryDescriptorId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.CountryDescriptors.CountryDescriptorGetByExample request, ICountryDescriptor specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CountryDescriptorId = request.CountryDescriptorId;
                    }
                public IHttpActionResult GetByKey([FromUri] int countryDescriptorId)
        {
            var request = new Api.Models.Requests.v2.CountryDescriptors.CountryDescriptorGetByKey
            {
                CountryDescriptorId = countryDescriptorId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(ICountryDescriptor request)
        {
            return 
                request.CountryDescriptorId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "countryDescriptors";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.Courses
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class CoursesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.Course.Course, 
        EdFi.Ods.Api.Models.Resources.V2.Course.Course, 
        EdFi.Ods.Entities.Common.ICourse, 
        // EdFi.Ods.Entities.NHibernate.CourseAggregate.Course, 
        Api.Models.Requests.v2.Courses.CourseGetByKey, 
        Api.Models.Requests.v2.Courses.CoursePut,
        Api.Models.Requests.v2.Courses.CoursePost,
        Api.Models.Requests.v2.Courses.CourseDelete,
        Api.Models.Requests.v2.Courses.CourseGetByExample>
    {
        public CoursesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.Courses.CourseGetByKey request, ICourse specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.CourseCode = request.Code;
            specification.EducationOrganizationId = request.EducationOrganizationId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.Courses.CourseGetByExample request, ICourse specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.AcademicSubjectDescriptor = request.AcademicSubjectDescriptor;
            specification.CareerPathwayType = request.CareerPathwayType;
            specification.CourseCode = request.Code;
            specification.CourseDefinedByType = request.DefinedByType;
            specification.CourseDescription = request.Description;
            specification.CourseGPAApplicabilityType = request.GPAApplicabilityType;
            specification.CourseTitle = request.Title;
            specification.DateCourseAdopted = request.DateCourseAdopted;
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.HighSchoolCourseRequirement = request.HighSchoolCourseRequirement;
            specification.Id = request.Id;
            specification.MaximumAvailableCreditConversion = request.MaximumAvailableCreditConversion;
            specification.MaximumAvailableCredits = request.MaximumAvailableCredits;
            specification.MaximumAvailableCreditType = request.MaximumAvailableCreditType;
            specification.MinimumAvailableCreditConversion = request.MinimumAvailableCreditConversion;
            specification.MinimumAvailableCredits = request.MinimumAvailableCredits;
            specification.MinimumAvailableCreditType = request.MinimumAvailableCreditType;
            specification.NumberOfParts = request.NumberOfParts;
            specification.TimeRequiredForCompletion = request.TimeRequiredForCompletion;
                    }
                public IHttpActionResult GetByKey([FromUri] string code, int educationOrganizationId)
        {
            var request = new Api.Models.Requests.v2.Courses.CourseGetByKey
            {
                Code = code,
                EducationOrganizationId = educationOrganizationId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(ICourse request)
        {
            return 
                request.CourseCode != default(string)
                && request.EducationOrganizationId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "courses";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.CourseAttemptResultTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class CourseAttemptResultTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.CourseAttemptResultType.CourseAttemptResultType, 
        EdFi.Ods.Api.Models.Resources.V2.CourseAttemptResultType.CourseAttemptResultType, 
        EdFi.Ods.Entities.Common.ICourseAttemptResultType, 
        // EdFi.Ods.Entities.NHibernate.CourseAttemptResultTypeAggregate.CourseAttemptResultType, 
        Api.Models.Requests.v2.CourseAttemptResultTypes.CourseAttemptResultTypeGetByKey, 
        Api.Models.Requests.v2.CourseAttemptResultTypes.CourseAttemptResultTypePut,
        Api.Models.Requests.v2.CourseAttemptResultTypes.CourseAttemptResultTypePost,
        Api.Models.Requests.v2.CourseAttemptResultTypes.CourseAttemptResultTypeDelete,
        Api.Models.Requests.v2.CourseAttemptResultTypes.CourseAttemptResultTypeGetByExample>
    {
        public CourseAttemptResultTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.CourseAttemptResultTypes.CourseAttemptResultTypeGetByKey request, ICourseAttemptResultType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.CourseAttemptResultTypeId = request.CourseAttemptResultTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.CourseAttemptResultTypes.CourseAttemptResultTypeGetByExample request, ICourseAttemptResultType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.CourseAttemptResultTypeId = request.CourseAttemptResultTypeId;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int courseAttemptResultTypeId)
        {
            var request = new Api.Models.Requests.v2.CourseAttemptResultTypes.CourseAttemptResultTypeGetByKey
            {
                CourseAttemptResultTypeId = courseAttemptResultTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(ICourseAttemptResultType request)
        {
            return 
                request.CourseAttemptResultTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "courseAttemptResultTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.CourseDefinedByTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class CourseDefinedByTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.CourseDefinedByType.CourseDefinedByType, 
        EdFi.Ods.Api.Models.Resources.V2.CourseDefinedByType.CourseDefinedByType, 
        EdFi.Ods.Entities.Common.ICourseDefinedByType, 
        // EdFi.Ods.Entities.NHibernate.CourseDefinedByTypeAggregate.CourseDefinedByType, 
        Api.Models.Requests.v2.CourseDefinedByTypes.CourseDefinedByTypeGetByKey, 
        Api.Models.Requests.v2.CourseDefinedByTypes.CourseDefinedByTypePut,
        Api.Models.Requests.v2.CourseDefinedByTypes.CourseDefinedByTypePost,
        Api.Models.Requests.v2.CourseDefinedByTypes.CourseDefinedByTypeDelete,
        Api.Models.Requests.v2.CourseDefinedByTypes.CourseDefinedByTypeGetByExample>
    {
        public CourseDefinedByTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.CourseDefinedByTypes.CourseDefinedByTypeGetByKey request, ICourseDefinedByType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.CourseDefinedByTypeId = request.CourseDefinedByTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.CourseDefinedByTypes.CourseDefinedByTypeGetByExample request, ICourseDefinedByType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.CourseDefinedByTypeId = request.CourseDefinedByTypeId;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int courseDefinedByTypeId)
        {
            var request = new Api.Models.Requests.v2.CourseDefinedByTypes.CourseDefinedByTypeGetByKey
            {
                CourseDefinedByTypeId = courseDefinedByTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(ICourseDefinedByType request)
        {
            return 
                request.CourseDefinedByTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "courseDefinedByTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.CourseGPAApplicabilityTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class CourseGPAApplicabilityTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.CourseGPAApplicabilityType.CourseGPAApplicabilityType, 
        EdFi.Ods.Api.Models.Resources.V2.CourseGPAApplicabilityType.CourseGPAApplicabilityType, 
        EdFi.Ods.Entities.Common.ICourseGPAApplicabilityType, 
        // EdFi.Ods.Entities.NHibernate.CourseGPAApplicabilityTypeAggregate.CourseGPAApplicabilityType, 
        Api.Models.Requests.v2.CourseGPAApplicabilityTypes.CourseGPAApplicabilityTypeGetByKey, 
        Api.Models.Requests.v2.CourseGPAApplicabilityTypes.CourseGPAApplicabilityTypePut,
        Api.Models.Requests.v2.CourseGPAApplicabilityTypes.CourseGPAApplicabilityTypePost,
        Api.Models.Requests.v2.CourseGPAApplicabilityTypes.CourseGPAApplicabilityTypeDelete,
        Api.Models.Requests.v2.CourseGPAApplicabilityTypes.CourseGPAApplicabilityTypeGetByExample>
    {
        public CourseGPAApplicabilityTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.CourseGPAApplicabilityTypes.CourseGPAApplicabilityTypeGetByKey request, ICourseGPAApplicabilityType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.CourseGPAApplicabilityTypeId = request.CourseGPAApplicabilityTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.CourseGPAApplicabilityTypes.CourseGPAApplicabilityTypeGetByExample request, ICourseGPAApplicabilityType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.CourseGPAApplicabilityTypeId = request.CourseGPAApplicabilityTypeId;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int courseGPAApplicabilityTypeId)
        {
            var request = new Api.Models.Requests.v2.CourseGPAApplicabilityTypes.CourseGPAApplicabilityTypeGetByKey
            {
                CourseGPAApplicabilityTypeId = courseGPAApplicabilityTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(ICourseGPAApplicabilityType request)
        {
            return 
                request.CourseGPAApplicabilityTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "courseGPAApplicabilityTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.CourseIdentificationSystemDescriptors
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class CourseIdentificationSystemDescriptorsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.CourseIdentificationSystemDescriptor.CourseIdentificationSystemDescriptor, 
        EdFi.Ods.Api.Models.Resources.V2.CourseIdentificationSystemDescriptor.CourseIdentificationSystemDescriptor, 
        EdFi.Ods.Entities.Common.ICourseIdentificationSystemDescriptor, 
        // EdFi.Ods.Entities.NHibernate.CourseIdentificationSystemDescriptorAggregate.CourseIdentificationSystemDescriptor, 
        Api.Models.Requests.v2.CourseIdentificationSystemDescriptors.CourseIdentificationSystemDescriptorGetByKey, 
        Api.Models.Requests.v2.CourseIdentificationSystemDescriptors.CourseIdentificationSystemDescriptorPut,
        Api.Models.Requests.v2.CourseIdentificationSystemDescriptors.CourseIdentificationSystemDescriptorPost,
        Api.Models.Requests.v2.CourseIdentificationSystemDescriptors.CourseIdentificationSystemDescriptorDelete,
        Api.Models.Requests.v2.CourseIdentificationSystemDescriptors.CourseIdentificationSystemDescriptorGetByExample>
    {
        public CourseIdentificationSystemDescriptorsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.CourseIdentificationSystemDescriptors.CourseIdentificationSystemDescriptorGetByKey request, ICourseIdentificationSystemDescriptor specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.CourseIdentificationSystemDescriptorId = request.CourseIdentificationSystemDescriptorId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.CourseIdentificationSystemDescriptors.CourseIdentificationSystemDescriptorGetByExample request, ICourseIdentificationSystemDescriptor specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CourseIdentificationSystemDescriptorId = request.CourseIdentificationSystemDescriptorId;
            specification.CourseIdentificationSystemType = request.CourseIdentificationSystemType;
                    }
                public IHttpActionResult GetByKey([FromUri] int courseIdentificationSystemDescriptorId)
        {
            var request = new Api.Models.Requests.v2.CourseIdentificationSystemDescriptors.CourseIdentificationSystemDescriptorGetByKey
            {
                CourseIdentificationSystemDescriptorId = courseIdentificationSystemDescriptorId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(ICourseIdentificationSystemDescriptor request)
        {
            return 
                request.CourseIdentificationSystemDescriptorId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "courseIdentificationSystemDescriptors";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.CourseIdentificationSystemTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class CourseIdentificationSystemTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.CourseIdentificationSystemType.CourseIdentificationSystemType, 
        EdFi.Ods.Api.Models.Resources.V2.CourseIdentificationSystemType.CourseIdentificationSystemType, 
        EdFi.Ods.Entities.Common.ICourseIdentificationSystemType, 
        // EdFi.Ods.Entities.NHibernate.CourseIdentificationSystemTypeAggregate.CourseIdentificationSystemType, 
        Api.Models.Requests.v2.CourseIdentificationSystemTypes.CourseIdentificationSystemTypeGetByKey, 
        Api.Models.Requests.v2.CourseIdentificationSystemTypes.CourseIdentificationSystemTypePut,
        Api.Models.Requests.v2.CourseIdentificationSystemTypes.CourseIdentificationSystemTypePost,
        Api.Models.Requests.v2.CourseIdentificationSystemTypes.CourseIdentificationSystemTypeDelete,
        Api.Models.Requests.v2.CourseIdentificationSystemTypes.CourseIdentificationSystemTypeGetByExample>
    {
        public CourseIdentificationSystemTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.CourseIdentificationSystemTypes.CourseIdentificationSystemTypeGetByKey request, ICourseIdentificationSystemType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.CourseIdentificationSystemTypeId = request.CourseIdentificationSystemTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.CourseIdentificationSystemTypes.CourseIdentificationSystemTypeGetByExample request, ICourseIdentificationSystemType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.CourseIdentificationSystemTypeId = request.CourseIdentificationSystemTypeId;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int courseIdentificationSystemTypeId)
        {
            var request = new Api.Models.Requests.v2.CourseIdentificationSystemTypes.CourseIdentificationSystemTypeGetByKey
            {
                CourseIdentificationSystemTypeId = courseIdentificationSystemTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(ICourseIdentificationSystemType request)
        {
            return 
                request.CourseIdentificationSystemTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "courseIdentificationSystemTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.CourseLevelCharacteristicTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class CourseLevelCharacteristicTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.CourseLevelCharacteristicType.CourseLevelCharacteristicType, 
        EdFi.Ods.Api.Models.Resources.V2.CourseLevelCharacteristicType.CourseLevelCharacteristicType, 
        EdFi.Ods.Entities.Common.ICourseLevelCharacteristicType, 
        // EdFi.Ods.Entities.NHibernate.CourseLevelCharacteristicTypeAggregate.CourseLevelCharacteristicType, 
        Api.Models.Requests.v2.CourseLevelCharacteristicTypes.CourseLevelCharacteristicTypeGetByKey, 
        Api.Models.Requests.v2.CourseLevelCharacteristicTypes.CourseLevelCharacteristicTypePut,
        Api.Models.Requests.v2.CourseLevelCharacteristicTypes.CourseLevelCharacteristicTypePost,
        Api.Models.Requests.v2.CourseLevelCharacteristicTypes.CourseLevelCharacteristicTypeDelete,
        Api.Models.Requests.v2.CourseLevelCharacteristicTypes.CourseLevelCharacteristicTypeGetByExample>
    {
        public CourseLevelCharacteristicTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.CourseLevelCharacteristicTypes.CourseLevelCharacteristicTypeGetByKey request, ICourseLevelCharacteristicType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.CourseLevelCharacteristicTypeId = request.CourseLevelCharacteristicTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.CourseLevelCharacteristicTypes.CourseLevelCharacteristicTypeGetByExample request, ICourseLevelCharacteristicType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.CourseLevelCharacteristicTypeId = request.CourseLevelCharacteristicTypeId;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int courseLevelCharacteristicTypeId)
        {
            var request = new Api.Models.Requests.v2.CourseLevelCharacteristicTypes.CourseLevelCharacteristicTypeGetByKey
            {
                CourseLevelCharacteristicTypeId = courseLevelCharacteristicTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(ICourseLevelCharacteristicType request)
        {
            return 
                request.CourseLevelCharacteristicTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "courseLevelCharacteristicTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.CourseOfferings
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class CourseOfferingsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.CourseOffering.CourseOffering, 
        EdFi.Ods.Api.Models.Resources.V2.CourseOffering.CourseOffering, 
        EdFi.Ods.Entities.Common.ICourseOffering, 
        // EdFi.Ods.Entities.NHibernate.CourseOfferingAggregate.CourseOffering, 
        Api.Models.Requests.v2.CourseOfferings.CourseOfferingGetByKey, 
        Api.Models.Requests.v2.CourseOfferings.CourseOfferingPut,
        Api.Models.Requests.v2.CourseOfferings.CourseOfferingPost,
        Api.Models.Requests.v2.CourseOfferings.CourseOfferingDelete,
        Api.Models.Requests.v2.CourseOfferings.CourseOfferingGetByExample>
    {
        public CourseOfferingsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.CourseOfferings.CourseOfferingGetByKey request, ICourseOffering specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.LocalCourseCode = request.LocalCourseCode;
            specification.SchoolId = request.SchoolId;
            specification.SchoolYear = request.SchoolYear;
            specification.TermDescriptor = request.TermDescriptor;
                    }

        protected override void MapAll(Api.Models.Requests.v2.CourseOfferings.CourseOfferingGetByExample request, ICourseOffering specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CourseCode = request.CourseCode;
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.Id = request.Id;
            specification.InstructionalTimePlanned = request.InstructionalTimePlanned;
            specification.LocalCourseCode = request.LocalCourseCode;
            specification.LocalCourseTitle = request.LocalCourseTitle;
            specification.SchoolId = request.SchoolId;
            specification.SchoolYear = request.SchoolYear;
            specification.TermDescriptor = request.TermDescriptor;
                    }
                public IHttpActionResult GetByKey([FromUri] string localCourseCode, int schoolId, short schoolYear, string termDescriptor)
        {
            var request = new Api.Models.Requests.v2.CourseOfferings.CourseOfferingGetByKey
            {
                LocalCourseCode = localCourseCode,
                SchoolId = schoolId,
                SchoolYear = schoolYear,
                TermDescriptor = termDescriptor,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(ICourseOffering request)
        {
            return 
                request.LocalCourseCode != default(string)
                && request.SchoolId != default(int)
                && request.SchoolYear != default(short)
                && request.TermDescriptor != null;
        }

        protected override string GetResourceCollectionName()
        {
            return "courseOfferings";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.CourseRepeatCodeTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class CourseRepeatCodeTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.CourseRepeatCodeType.CourseRepeatCodeType, 
        EdFi.Ods.Api.Models.Resources.V2.CourseRepeatCodeType.CourseRepeatCodeType, 
        EdFi.Ods.Entities.Common.ICourseRepeatCodeType, 
        // EdFi.Ods.Entities.NHibernate.CourseRepeatCodeTypeAggregate.CourseRepeatCodeType, 
        Api.Models.Requests.v2.CourseRepeatCodeTypes.CourseRepeatCodeTypeGetByKey, 
        Api.Models.Requests.v2.CourseRepeatCodeTypes.CourseRepeatCodeTypePut,
        Api.Models.Requests.v2.CourseRepeatCodeTypes.CourseRepeatCodeTypePost,
        Api.Models.Requests.v2.CourseRepeatCodeTypes.CourseRepeatCodeTypeDelete,
        Api.Models.Requests.v2.CourseRepeatCodeTypes.CourseRepeatCodeTypeGetByExample>
    {
        public CourseRepeatCodeTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.CourseRepeatCodeTypes.CourseRepeatCodeTypeGetByKey request, ICourseRepeatCodeType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.CourseRepeatCodeTypeId = request.CourseRepeatCodeTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.CourseRepeatCodeTypes.CourseRepeatCodeTypeGetByExample request, ICourseRepeatCodeType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.CourseRepeatCodeTypeId = request.CourseRepeatCodeTypeId;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int courseRepeatCodeTypeId)
        {
            var request = new Api.Models.Requests.v2.CourseRepeatCodeTypes.CourseRepeatCodeTypeGetByKey
            {
                CourseRepeatCodeTypeId = courseRepeatCodeTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(ICourseRepeatCodeType request)
        {
            return 
                request.CourseRepeatCodeTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "courseRepeatCodeTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.CourseTranscripts
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class CourseTranscriptsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.CourseTranscript.CourseTranscript, 
        EdFi.Ods.Api.Models.Resources.V2.CourseTranscript.CourseTranscript, 
        EdFi.Ods.Entities.Common.ICourseTranscript, 
        // EdFi.Ods.Entities.NHibernate.CourseTranscriptAggregate.CourseTranscript, 
        Api.Models.Requests.v2.CourseTranscripts.CourseTranscriptGetByKey, 
        Api.Models.Requests.v2.CourseTranscripts.CourseTranscriptPut,
        Api.Models.Requests.v2.CourseTranscripts.CourseTranscriptPost,
        Api.Models.Requests.v2.CourseTranscripts.CourseTranscriptDelete,
        Api.Models.Requests.v2.CourseTranscripts.CourseTranscriptGetByExample>
    {
        public CourseTranscriptsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.CourseTranscripts.CourseTranscriptGetByKey request, ICourseTranscript specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.CourseAttemptResultType = request.CourseAttemptResultType;
            specification.CourseCode = request.CourseCode;
            specification.CourseEducationOrganizationId = request.CourseEducationOrganizationId;
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.SchoolYear = request.SchoolYear;
            specification.StudentUniqueId = request.StudentUniqueId;
            specification.TermDescriptor = request.TermDescriptor;
                    }

        protected override void MapAll(Api.Models.Requests.v2.CourseTranscripts.CourseTranscriptGetByExample request, ICourseTranscript specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.AlternativeCourseCode = request.AlternativeCourseCode;
            specification.AlternativeCourseTitle = request.AlternativeCourseTitle;
            specification.AttemptedCreditConversion = request.AttemptedCreditConversion;
            specification.AttemptedCredits = request.AttemptedCredits;
            specification.AttemptedCreditType = request.AttemptedCreditType;
            specification.CourseAttemptResultType = request.CourseAttemptResultType;
            specification.CourseCode = request.CourseCode;
            specification.CourseEducationOrganizationId = request.CourseEducationOrganizationId;
            specification.CourseRepeatCodeType = request.CourseRepeatCodeType;
            specification.CourseTitle = request.CourseTitle;
            specification.EarnedCreditConversion = request.EarnedCreditConversion;
            specification.EarnedCredits = request.EarnedCredits;
            specification.EarnedCreditType = request.EarnedCreditType;
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.FinalLetterGradeEarned = request.FinalLetterGradeEarned;
            specification.FinalNumericGradeEarned = request.FinalNumericGradeEarned;
            specification.Id = request.Id;
            specification.MethodCreditEarnedType = request.MethodCreditEarnedType;
            specification.SchoolId = request.SchoolId;
            specification.SchoolYear = request.SchoolYear;
            specification.StudentUniqueId = request.StudentUniqueId;
            specification.TermDescriptor = request.TermDescriptor;
            specification.WhenTakenGradeLevelDescriptor = request.WhenTakenGradeLevelDescriptor;
                    }
                public IHttpActionResult GetByKey([FromUri] string courseAttemptResultType, string courseCode, int courseEducationOrganizationId, int educationOrganizationId, short schoolYear, string studentUniqueId, string termDescriptor)
        {
            var request = new Api.Models.Requests.v2.CourseTranscripts.CourseTranscriptGetByKey
            {
                CourseAttemptResultType = courseAttemptResultType,
                CourseCode = courseCode,
                CourseEducationOrganizationId = courseEducationOrganizationId,
                EducationOrganizationId = educationOrganizationId,
                SchoolYear = schoolYear,
                StudentUniqueId = studentUniqueId,
                TermDescriptor = termDescriptor,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(ICourseTranscript request)
        {
            return 
                request.CourseAttemptResultType != null
                && request.CourseCode != default(string)
                && request.CourseEducationOrganizationId != default(int)
                && request.EducationOrganizationId != default(int)
                && request.SchoolYear != default(short)
                && request.StudentUniqueId != default(string)
                && request.TermDescriptor != null;
        }

        protected override string GetResourceCollectionName()
        {
            return "courseTranscripts";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.CredentialFieldDescriptors
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class CredentialFieldDescriptorsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.CredentialFieldDescriptor.CredentialFieldDescriptor, 
        EdFi.Ods.Api.Models.Resources.V2.CredentialFieldDescriptor.CredentialFieldDescriptor, 
        EdFi.Ods.Entities.Common.ICredentialFieldDescriptor, 
        // EdFi.Ods.Entities.NHibernate.CredentialFieldDescriptorAggregate.CredentialFieldDescriptor, 
        Api.Models.Requests.v2.CredentialFieldDescriptors.CredentialFieldDescriptorGetByKey, 
        Api.Models.Requests.v2.CredentialFieldDescriptors.CredentialFieldDescriptorPut,
        Api.Models.Requests.v2.CredentialFieldDescriptors.CredentialFieldDescriptorPost,
        Api.Models.Requests.v2.CredentialFieldDescriptors.CredentialFieldDescriptorDelete,
        Api.Models.Requests.v2.CredentialFieldDescriptors.CredentialFieldDescriptorGetByExample>
    {
        public CredentialFieldDescriptorsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.CredentialFieldDescriptors.CredentialFieldDescriptorGetByKey request, ICredentialFieldDescriptor specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.CredentialFieldDescriptorId = request.CredentialFieldDescriptorId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.CredentialFieldDescriptors.CredentialFieldDescriptorGetByExample request, ICredentialFieldDescriptor specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.AcademicSubjectDescriptor = request.AcademicSubjectDescriptor;
            specification.CredentialFieldDescriptorId = request.CredentialFieldDescriptorId;
                    }
                public IHttpActionResult GetByKey([FromUri] int credentialFieldDescriptorId)
        {
            var request = new Api.Models.Requests.v2.CredentialFieldDescriptors.CredentialFieldDescriptorGetByKey
            {
                CredentialFieldDescriptorId = credentialFieldDescriptorId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(ICredentialFieldDescriptor request)
        {
            return 
                request.CredentialFieldDescriptorId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "credentialFieldDescriptors";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.CredentialTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class CredentialTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.CredentialType.CredentialType, 
        EdFi.Ods.Api.Models.Resources.V2.CredentialType.CredentialType, 
        EdFi.Ods.Entities.Common.ICredentialType, 
        // EdFi.Ods.Entities.NHibernate.CredentialTypeAggregate.CredentialType, 
        Api.Models.Requests.v2.CredentialTypes.CredentialTypeGetByKey, 
        Api.Models.Requests.v2.CredentialTypes.CredentialTypePut,
        Api.Models.Requests.v2.CredentialTypes.CredentialTypePost,
        Api.Models.Requests.v2.CredentialTypes.CredentialTypeDelete,
        Api.Models.Requests.v2.CredentialTypes.CredentialTypeGetByExample>
    {
        public CredentialTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.CredentialTypes.CredentialTypeGetByKey request, ICredentialType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.CredentialTypeId = request.CredentialTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.CredentialTypes.CredentialTypeGetByExample request, ICredentialType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.CredentialTypeId = request.CredentialTypeId;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int credentialTypeId)
        {
            var request = new Api.Models.Requests.v2.CredentialTypes.CredentialTypeGetByKey
            {
                CredentialTypeId = credentialTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(ICredentialType request)
        {
            return 
                request.CredentialTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "credentialTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.CreditTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class CreditTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.CreditType.CreditType, 
        EdFi.Ods.Api.Models.Resources.V2.CreditType.CreditType, 
        EdFi.Ods.Entities.Common.ICreditType, 
        // EdFi.Ods.Entities.NHibernate.CreditTypeAggregate.CreditType, 
        Api.Models.Requests.v2.CreditTypes.CreditTypeGetByKey, 
        Api.Models.Requests.v2.CreditTypes.CreditTypePut,
        Api.Models.Requests.v2.CreditTypes.CreditTypePost,
        Api.Models.Requests.v2.CreditTypes.CreditTypeDelete,
        Api.Models.Requests.v2.CreditTypes.CreditTypeGetByExample>
    {
        public CreditTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.CreditTypes.CreditTypeGetByKey request, ICreditType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.CreditTypeId = request.CreditTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.CreditTypes.CreditTypeGetByExample request, ICreditType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.CreditTypeId = request.CreditTypeId;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int creditTypeId)
        {
            var request = new Api.Models.Requests.v2.CreditTypes.CreditTypeGetByKey
            {
                CreditTypeId = creditTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(ICreditType request)
        {
            return 
                request.CreditTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "creditTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.CurriculumUsedTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class CurriculumUsedTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.CurriculumUsedType.CurriculumUsedType, 
        EdFi.Ods.Api.Models.Resources.V2.CurriculumUsedType.CurriculumUsedType, 
        EdFi.Ods.Entities.Common.ICurriculumUsedType, 
        // EdFi.Ods.Entities.NHibernate.CurriculumUsedTypeAggregate.CurriculumUsedType, 
        Api.Models.Requests.v2.CurriculumUsedTypes.CurriculumUsedTypeGetByKey, 
        Api.Models.Requests.v2.CurriculumUsedTypes.CurriculumUsedTypePut,
        Api.Models.Requests.v2.CurriculumUsedTypes.CurriculumUsedTypePost,
        Api.Models.Requests.v2.CurriculumUsedTypes.CurriculumUsedTypeDelete,
        Api.Models.Requests.v2.CurriculumUsedTypes.CurriculumUsedTypeGetByExample>
    {
        public CurriculumUsedTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.CurriculumUsedTypes.CurriculumUsedTypeGetByKey request, ICurriculumUsedType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.CurriculumUsedTypeId = request.CurriculumUsedTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.CurriculumUsedTypes.CurriculumUsedTypeGetByExample request, ICurriculumUsedType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.CurriculumUsedTypeId = request.CurriculumUsedTypeId;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int curriculumUsedTypeId)
        {
            var request = new Api.Models.Requests.v2.CurriculumUsedTypes.CurriculumUsedTypeGetByKey
            {
                CurriculumUsedTypeId = curriculumUsedTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(ICurriculumUsedType request)
        {
            return 
                request.CurriculumUsedTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "curriculumUsedTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.DeliveryMethodTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class DeliveryMethodTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.DeliveryMethodType.DeliveryMethodType, 
        EdFi.Ods.Api.Models.Resources.V2.DeliveryMethodType.DeliveryMethodType, 
        EdFi.Ods.Entities.Common.IDeliveryMethodType, 
        // EdFi.Ods.Entities.NHibernate.DeliveryMethodTypeAggregate.DeliveryMethodType, 
        Api.Models.Requests.v2.DeliveryMethodTypes.DeliveryMethodTypeGetByKey, 
        Api.Models.Requests.v2.DeliveryMethodTypes.DeliveryMethodTypePut,
        Api.Models.Requests.v2.DeliveryMethodTypes.DeliveryMethodTypePost,
        Api.Models.Requests.v2.DeliveryMethodTypes.DeliveryMethodTypeDelete,
        Api.Models.Requests.v2.DeliveryMethodTypes.DeliveryMethodTypeGetByExample>
    {
        public DeliveryMethodTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.DeliveryMethodTypes.DeliveryMethodTypeGetByKey request, IDeliveryMethodType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.DeliveryMethodTypeId = request.DeliveryMethodTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.DeliveryMethodTypes.DeliveryMethodTypeGetByExample request, IDeliveryMethodType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.DeliveryMethodTypeId = request.DeliveryMethodTypeId;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int deliveryMethodTypeId)
        {
            var request = new Api.Models.Requests.v2.DeliveryMethodTypes.DeliveryMethodTypeGetByKey
            {
                DeliveryMethodTypeId = deliveryMethodTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IDeliveryMethodType request)
        {
            return 
                request.DeliveryMethodTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "deliveryMethodTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.DiagnosisDescriptors
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class DiagnosisDescriptorsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.DiagnosisDescriptor.DiagnosisDescriptor, 
        EdFi.Ods.Api.Models.Resources.V2.DiagnosisDescriptor.DiagnosisDescriptor, 
        EdFi.Ods.Entities.Common.IDiagnosisDescriptor, 
        // EdFi.Ods.Entities.NHibernate.DiagnosisDescriptorAggregate.DiagnosisDescriptor, 
        Api.Models.Requests.v2.DiagnosisDescriptors.DiagnosisDescriptorGetByKey, 
        Api.Models.Requests.v2.DiagnosisDescriptors.DiagnosisDescriptorPut,
        Api.Models.Requests.v2.DiagnosisDescriptors.DiagnosisDescriptorPost,
        Api.Models.Requests.v2.DiagnosisDescriptors.DiagnosisDescriptorDelete,
        Api.Models.Requests.v2.DiagnosisDescriptors.DiagnosisDescriptorGetByExample>
    {
        public DiagnosisDescriptorsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.DiagnosisDescriptors.DiagnosisDescriptorGetByKey request, IDiagnosisDescriptor specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.DiagnosisDescriptorId = request.DiagnosisDescriptorId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.DiagnosisDescriptors.DiagnosisDescriptorGetByExample request, IDiagnosisDescriptor specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.DiagnosisDescriptorId = request.DiagnosisDescriptorId;
            specification.DiagnosisType = request.DiagnosisType;
                    }
                public IHttpActionResult GetByKey([FromUri] int diagnosisDescriptorId)
        {
            var request = new Api.Models.Requests.v2.DiagnosisDescriptors.DiagnosisDescriptorGetByKey
            {
                DiagnosisDescriptorId = diagnosisDescriptorId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IDiagnosisDescriptor request)
        {
            return 
                request.DiagnosisDescriptorId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "diagnosisDescriptors";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.DiagnosisTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class DiagnosisTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.DiagnosisType.DiagnosisType, 
        EdFi.Ods.Api.Models.Resources.V2.DiagnosisType.DiagnosisType, 
        EdFi.Ods.Entities.Common.IDiagnosisType, 
        // EdFi.Ods.Entities.NHibernate.DiagnosisTypeAggregate.DiagnosisType, 
        Api.Models.Requests.v2.DiagnosisTypes.DiagnosisTypeGetByKey, 
        Api.Models.Requests.v2.DiagnosisTypes.DiagnosisTypePut,
        Api.Models.Requests.v2.DiagnosisTypes.DiagnosisTypePost,
        Api.Models.Requests.v2.DiagnosisTypes.DiagnosisTypeDelete,
        Api.Models.Requests.v2.DiagnosisTypes.DiagnosisTypeGetByExample>
    {
        public DiagnosisTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.DiagnosisTypes.DiagnosisTypeGetByKey request, IDiagnosisType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.DiagnosisTypeId = request.DiagnosisTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.DiagnosisTypes.DiagnosisTypeGetByExample request, IDiagnosisType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.DiagnosisTypeId = request.DiagnosisTypeId;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int diagnosisTypeId)
        {
            var request = new Api.Models.Requests.v2.DiagnosisTypes.DiagnosisTypeGetByKey
            {
                DiagnosisTypeId = diagnosisTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IDiagnosisType request)
        {
            return 
                request.DiagnosisTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "diagnosisTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.DiplomaLevelTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class DiplomaLevelTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.DiplomaLevelType.DiplomaLevelType, 
        EdFi.Ods.Api.Models.Resources.V2.DiplomaLevelType.DiplomaLevelType, 
        EdFi.Ods.Entities.Common.IDiplomaLevelType, 
        // EdFi.Ods.Entities.NHibernate.DiplomaLevelTypeAggregate.DiplomaLevelType, 
        Api.Models.Requests.v2.DiplomaLevelTypes.DiplomaLevelTypeGetByKey, 
        Api.Models.Requests.v2.DiplomaLevelTypes.DiplomaLevelTypePut,
        Api.Models.Requests.v2.DiplomaLevelTypes.DiplomaLevelTypePost,
        Api.Models.Requests.v2.DiplomaLevelTypes.DiplomaLevelTypeDelete,
        Api.Models.Requests.v2.DiplomaLevelTypes.DiplomaLevelTypeGetByExample>
    {
        public DiplomaLevelTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.DiplomaLevelTypes.DiplomaLevelTypeGetByKey request, IDiplomaLevelType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.DiplomaLevelTypeId = request.DiplomaLevelTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.DiplomaLevelTypes.DiplomaLevelTypeGetByExample request, IDiplomaLevelType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.DiplomaLevelTypeId = request.DiplomaLevelTypeId;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int diplomaLevelTypeId)
        {
            var request = new Api.Models.Requests.v2.DiplomaLevelTypes.DiplomaLevelTypeGetByKey
            {
                DiplomaLevelTypeId = diplomaLevelTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IDiplomaLevelType request)
        {
            return 
                request.DiplomaLevelTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "diplomaLevelTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.DiplomaTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class DiplomaTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.DiplomaType.DiplomaType, 
        EdFi.Ods.Api.Models.Resources.V2.DiplomaType.DiplomaType, 
        EdFi.Ods.Entities.Common.IDiplomaType, 
        // EdFi.Ods.Entities.NHibernate.DiplomaTypeAggregate.DiplomaType, 
        Api.Models.Requests.v2.DiplomaTypes.DiplomaTypeGetByKey, 
        Api.Models.Requests.v2.DiplomaTypes.DiplomaTypePut,
        Api.Models.Requests.v2.DiplomaTypes.DiplomaTypePost,
        Api.Models.Requests.v2.DiplomaTypes.DiplomaTypeDelete,
        Api.Models.Requests.v2.DiplomaTypes.DiplomaTypeGetByExample>
    {
        public DiplomaTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.DiplomaTypes.DiplomaTypeGetByKey request, IDiplomaType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.DiplomaTypeId = request.DiplomaTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.DiplomaTypes.DiplomaTypeGetByExample request, IDiplomaType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.DiplomaTypeId = request.DiplomaTypeId;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int diplomaTypeId)
        {
            var request = new Api.Models.Requests.v2.DiplomaTypes.DiplomaTypeGetByKey
            {
                DiplomaTypeId = diplomaTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IDiplomaType request)
        {
            return 
                request.DiplomaTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "diplomaTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.DisabilityCategoryTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class DisabilityCategoryTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.DisabilityCategoryType.DisabilityCategoryType, 
        EdFi.Ods.Api.Models.Resources.V2.DisabilityCategoryType.DisabilityCategoryType, 
        EdFi.Ods.Entities.Common.IDisabilityCategoryType, 
        // EdFi.Ods.Entities.NHibernate.DisabilityCategoryTypeAggregate.DisabilityCategoryType, 
        Api.Models.Requests.v2.DisabilityCategoryTypes.DisabilityCategoryTypeGetByKey, 
        Api.Models.Requests.v2.DisabilityCategoryTypes.DisabilityCategoryTypePut,
        Api.Models.Requests.v2.DisabilityCategoryTypes.DisabilityCategoryTypePost,
        Api.Models.Requests.v2.DisabilityCategoryTypes.DisabilityCategoryTypeDelete,
        Api.Models.Requests.v2.DisabilityCategoryTypes.DisabilityCategoryTypeGetByExample>
    {
        public DisabilityCategoryTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.DisabilityCategoryTypes.DisabilityCategoryTypeGetByKey request, IDisabilityCategoryType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.DisabilityCategoryTypeId = request.DisabilityCategoryTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.DisabilityCategoryTypes.DisabilityCategoryTypeGetByExample request, IDisabilityCategoryType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.DisabilityCategoryTypeId = request.DisabilityCategoryTypeId;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int disabilityCategoryTypeId)
        {
            var request = new Api.Models.Requests.v2.DisabilityCategoryTypes.DisabilityCategoryTypeGetByKey
            {
                DisabilityCategoryTypeId = disabilityCategoryTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IDisabilityCategoryType request)
        {
            return 
                request.DisabilityCategoryTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "disabilityCategoryTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.DisabilityDescriptors
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class DisabilityDescriptorsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.DisabilityDescriptor.DisabilityDescriptor, 
        EdFi.Ods.Api.Models.Resources.V2.DisabilityDescriptor.DisabilityDescriptor, 
        EdFi.Ods.Entities.Common.IDisabilityDescriptor, 
        // EdFi.Ods.Entities.NHibernate.DisabilityDescriptorAggregate.DisabilityDescriptor, 
        Api.Models.Requests.v2.DisabilityDescriptors.DisabilityDescriptorGetByKey, 
        Api.Models.Requests.v2.DisabilityDescriptors.DisabilityDescriptorPut,
        Api.Models.Requests.v2.DisabilityDescriptors.DisabilityDescriptorPost,
        Api.Models.Requests.v2.DisabilityDescriptors.DisabilityDescriptorDelete,
        Api.Models.Requests.v2.DisabilityDescriptors.DisabilityDescriptorGetByExample>
    {
        public DisabilityDescriptorsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.DisabilityDescriptors.DisabilityDescriptorGetByKey request, IDisabilityDescriptor specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.DisabilityDescriptorId = request.DisabilityDescriptorId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.DisabilityDescriptors.DisabilityDescriptorGetByExample request, IDisabilityDescriptor specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.DisabilityCategoryType = request.DisabilityCategoryType;
            specification.DisabilityDescriptorId = request.DisabilityDescriptorId;
            specification.DisabilityType = request.DisabilityType;
                    }
                public IHttpActionResult GetByKey([FromUri] int disabilityDescriptorId)
        {
            var request = new Api.Models.Requests.v2.DisabilityDescriptors.DisabilityDescriptorGetByKey
            {
                DisabilityDescriptorId = disabilityDescriptorId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IDisabilityDescriptor request)
        {
            return 
                request.DisabilityDescriptorId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "disabilityDescriptors";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.DisabilityDeterminationSourceTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class DisabilityDeterminationSourceTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.DisabilityDeterminationSourceType.DisabilityDeterminationSourceType, 
        EdFi.Ods.Api.Models.Resources.V2.DisabilityDeterminationSourceType.DisabilityDeterminationSourceType, 
        EdFi.Ods.Entities.Common.IDisabilityDeterminationSourceType, 
        // EdFi.Ods.Entities.NHibernate.DisabilityDeterminationSourceTypeAggregate.DisabilityDeterminationSourceType, 
        Api.Models.Requests.v2.DisabilityDeterminationSourceTypes.DisabilityDeterminationSourceTypeGetByKey, 
        Api.Models.Requests.v2.DisabilityDeterminationSourceTypes.DisabilityDeterminationSourceTypePut,
        Api.Models.Requests.v2.DisabilityDeterminationSourceTypes.DisabilityDeterminationSourceTypePost,
        Api.Models.Requests.v2.DisabilityDeterminationSourceTypes.DisabilityDeterminationSourceTypeDelete,
        Api.Models.Requests.v2.DisabilityDeterminationSourceTypes.DisabilityDeterminationSourceTypeGetByExample>
    {
        public DisabilityDeterminationSourceTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.DisabilityDeterminationSourceTypes.DisabilityDeterminationSourceTypeGetByKey request, IDisabilityDeterminationSourceType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.DisabilityDeterminationSourceTypeId = request.DisabilityDeterminationSourceTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.DisabilityDeterminationSourceTypes.DisabilityDeterminationSourceTypeGetByExample request, IDisabilityDeterminationSourceType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.DisabilityDeterminationSourceTypeId = request.DisabilityDeterminationSourceTypeId;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int disabilityDeterminationSourceTypeId)
        {
            var request = new Api.Models.Requests.v2.DisabilityDeterminationSourceTypes.DisabilityDeterminationSourceTypeGetByKey
            {
                DisabilityDeterminationSourceTypeId = disabilityDeterminationSourceTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IDisabilityDeterminationSourceType request)
        {
            return 
                request.DisabilityDeterminationSourceTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "disabilityDeterminationSourceTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.DisabilityTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class DisabilityTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.DisabilityType.DisabilityType, 
        EdFi.Ods.Api.Models.Resources.V2.DisabilityType.DisabilityType, 
        EdFi.Ods.Entities.Common.IDisabilityType, 
        // EdFi.Ods.Entities.NHibernate.DisabilityTypeAggregate.DisabilityType, 
        Api.Models.Requests.v2.DisabilityTypes.DisabilityTypeGetByKey, 
        Api.Models.Requests.v2.DisabilityTypes.DisabilityTypePut,
        Api.Models.Requests.v2.DisabilityTypes.DisabilityTypePost,
        Api.Models.Requests.v2.DisabilityTypes.DisabilityTypeDelete,
        Api.Models.Requests.v2.DisabilityTypes.DisabilityTypeGetByExample>
    {
        public DisabilityTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.DisabilityTypes.DisabilityTypeGetByKey request, IDisabilityType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.DisabilityTypeId = request.DisabilityTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.DisabilityTypes.DisabilityTypeGetByExample request, IDisabilityType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.DisabilityTypeId = request.DisabilityTypeId;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int disabilityTypeId)
        {
            var request = new Api.Models.Requests.v2.DisabilityTypes.DisabilityTypeGetByKey
            {
                DisabilityTypeId = disabilityTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IDisabilityType request)
        {
            return 
                request.DisabilityTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "disabilityTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.DisciplineActions
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class DisciplineActionsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.DisciplineAction.DisciplineAction, 
        EdFi.Ods.Api.Models.Resources.V2.DisciplineAction.DisciplineAction, 
        EdFi.Ods.Entities.Common.IDisciplineAction, 
        // EdFi.Ods.Entities.NHibernate.DisciplineActionAggregate.DisciplineAction, 
        Api.Models.Requests.v2.DisciplineActions.DisciplineActionGetByKey, 
        Api.Models.Requests.v2.DisciplineActions.DisciplineActionPut,
        Api.Models.Requests.v2.DisciplineActions.DisciplineActionPost,
        Api.Models.Requests.v2.DisciplineActions.DisciplineActionDelete,
        Api.Models.Requests.v2.DisciplineActions.DisciplineActionGetByExample>
    {
        public DisciplineActionsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.DisciplineActions.DisciplineActionGetByKey request, IDisciplineAction specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.DisciplineActionIdentifier = request.Identifier;
            specification.DisciplineDate = request.DisciplineDate;
            specification.StudentUniqueId = request.StudentUniqueId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.DisciplineActions.DisciplineActionGetByExample request, IDisciplineAction specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.ActualDisciplineActionLength = request.ActualDisciplineActionLength;
            specification.AssignmentSchoolId = request.AssignmentSchoolId;
            specification.DisciplineActionIdentifier = request.Identifier;
            specification.DisciplineActionLength = request.Length;
            specification.DisciplineActionLengthDifferenceReasonType = request.LengthDifferenceReasonType;
            specification.DisciplineDate = request.DisciplineDate;
            specification.Id = request.Id;
            specification.RelatedToZeroTolerancePolicy = request.RelatedToZeroTolerancePolicy;
            specification.ResponsibilitySchoolId = request.ResponsibilitySchoolId;
            specification.StudentUniqueId = request.StudentUniqueId;
                    }
                public IHttpActionResult GetByKey([FromUri] string identifier, DateTime disciplineDate, string studentUniqueId)
        {
            var request = new Api.Models.Requests.v2.DisciplineActions.DisciplineActionGetByKey
            {
                Identifier = identifier,
                DisciplineDate = disciplineDate,
                StudentUniqueId = studentUniqueId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IDisciplineAction request)
        {
            return 
                request.DisciplineActionIdentifier != default(string)
                && request.DisciplineDate != default(DateTime)
                && request.StudentUniqueId != default(string);
        }

        protected override string GetResourceCollectionName()
        {
            return "disciplineActions";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.DisciplineActionLengthDifferenceReasonTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class DisciplineActionLengthDifferenceReasonTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.DisciplineActionLengthDifferenceReasonType.DisciplineActionLengthDifferenceReasonType, 
        EdFi.Ods.Api.Models.Resources.V2.DisciplineActionLengthDifferenceReasonType.DisciplineActionLengthDifferenceReasonType, 
        EdFi.Ods.Entities.Common.IDisciplineActionLengthDifferenceReasonType, 
        // EdFi.Ods.Entities.NHibernate.DisciplineActionLengthDifferenceReasonTypeAggregate.DisciplineActionLengthDifferenceReasonType, 
        Api.Models.Requests.v2.DisciplineActionLengthDifferenceReasonTypes.DisciplineActionLengthDifferenceReasonTypeGetByKey, 
        Api.Models.Requests.v2.DisciplineActionLengthDifferenceReasonTypes.DisciplineActionLengthDifferenceReasonTypePut,
        Api.Models.Requests.v2.DisciplineActionLengthDifferenceReasonTypes.DisciplineActionLengthDifferenceReasonTypePost,
        Api.Models.Requests.v2.DisciplineActionLengthDifferenceReasonTypes.DisciplineActionLengthDifferenceReasonTypeDelete,
        Api.Models.Requests.v2.DisciplineActionLengthDifferenceReasonTypes.DisciplineActionLengthDifferenceReasonTypeGetByExample>
    {
        public DisciplineActionLengthDifferenceReasonTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.DisciplineActionLengthDifferenceReasonTypes.DisciplineActionLengthDifferenceReasonTypeGetByKey request, IDisciplineActionLengthDifferenceReasonType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.DisciplineActionLengthDifferenceReasonTypeId = request.DisciplineActionLengthDifferenceReasonTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.DisciplineActionLengthDifferenceReasonTypes.DisciplineActionLengthDifferenceReasonTypeGetByExample request, IDisciplineActionLengthDifferenceReasonType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.DisciplineActionLengthDifferenceReasonTypeId = request.DisciplineActionLengthDifferenceReasonTypeId;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int disciplineActionLengthDifferenceReasonTypeId)
        {
            var request = new Api.Models.Requests.v2.DisciplineActionLengthDifferenceReasonTypes.DisciplineActionLengthDifferenceReasonTypeGetByKey
            {
                DisciplineActionLengthDifferenceReasonTypeId = disciplineActionLengthDifferenceReasonTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IDisciplineActionLengthDifferenceReasonType request)
        {
            return 
                request.DisciplineActionLengthDifferenceReasonTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "disciplineActionLengthDifferenceReasonTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.DisciplineDescriptors
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class DisciplineDescriptorsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.DisciplineDescriptor.DisciplineDescriptor, 
        EdFi.Ods.Api.Models.Resources.V2.DisciplineDescriptor.DisciplineDescriptor, 
        EdFi.Ods.Entities.Common.IDisciplineDescriptor, 
        // EdFi.Ods.Entities.NHibernate.DisciplineDescriptorAggregate.DisciplineDescriptor, 
        Api.Models.Requests.v2.DisciplineDescriptors.DisciplineDescriptorGetByKey, 
        Api.Models.Requests.v2.DisciplineDescriptors.DisciplineDescriptorPut,
        Api.Models.Requests.v2.DisciplineDescriptors.DisciplineDescriptorPost,
        Api.Models.Requests.v2.DisciplineDescriptors.DisciplineDescriptorDelete,
        Api.Models.Requests.v2.DisciplineDescriptors.DisciplineDescriptorGetByExample>
    {
        public DisciplineDescriptorsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.DisciplineDescriptors.DisciplineDescriptorGetByKey request, IDisciplineDescriptor specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.DisciplineDescriptorId = request.DisciplineDescriptorId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.DisciplineDescriptors.DisciplineDescriptorGetByExample request, IDisciplineDescriptor specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.DisciplineDescriptorId = request.DisciplineDescriptorId;
            specification.DisciplineType = request.DisciplineType;
                    }
                public IHttpActionResult GetByKey([FromUri] int disciplineDescriptorId)
        {
            var request = new Api.Models.Requests.v2.DisciplineDescriptors.DisciplineDescriptorGetByKey
            {
                DisciplineDescriptorId = disciplineDescriptorId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IDisciplineDescriptor request)
        {
            return 
                request.DisciplineDescriptorId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "disciplineDescriptors";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.DisciplineIncidents
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class DisciplineIncidentsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.DisciplineIncident.DisciplineIncident, 
        EdFi.Ods.Api.Models.Resources.V2.DisciplineIncident.DisciplineIncident, 
        EdFi.Ods.Entities.Common.IDisciplineIncident, 
        // EdFi.Ods.Entities.NHibernate.DisciplineIncidentAggregate.DisciplineIncident, 
        Api.Models.Requests.v2.DisciplineIncidents.DisciplineIncidentGetByKey, 
        Api.Models.Requests.v2.DisciplineIncidents.DisciplineIncidentPut,
        Api.Models.Requests.v2.DisciplineIncidents.DisciplineIncidentPost,
        Api.Models.Requests.v2.DisciplineIncidents.DisciplineIncidentDelete,
        Api.Models.Requests.v2.DisciplineIncidents.DisciplineIncidentGetByExample>
    {
        public DisciplineIncidentsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.DisciplineIncidents.DisciplineIncidentGetByKey request, IDisciplineIncident specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.IncidentIdentifier = request.IncidentIdentifier;
            specification.SchoolId = request.SchoolId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.DisciplineIncidents.DisciplineIncidentGetByExample request, IDisciplineIncident specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CaseNumber = request.CaseNumber;
            specification.Id = request.Id;
            specification.IncidentCost = request.IncidentCost;
            specification.IncidentDate = request.IncidentDate;
            specification.IncidentDescription = request.IncidentDescription;
            specification.IncidentIdentifier = request.IncidentIdentifier;
            specification.IncidentLocationType = request.IncidentLocationType;
            specification.IncidentTime = request.IncidentTime;
            specification.ReportedToLawEnforcement = request.ReportedToLawEnforcement;
            specification.ReporterDescriptionDescriptor = request.ReporterDescriptionDescriptor;
            specification.ReporterName = request.ReporterName;
            specification.SchoolId = request.SchoolId;
            specification.StaffUniqueId = request.StaffUniqueId;
                    }
                public IHttpActionResult GetByKey([FromUri] string incidentIdentifier, int schoolId)
        {
            var request = new Api.Models.Requests.v2.DisciplineIncidents.DisciplineIncidentGetByKey
            {
                IncidentIdentifier = incidentIdentifier,
                SchoolId = schoolId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IDisciplineIncident request)
        {
            return 
                request.IncidentIdentifier != default(string)
                && request.SchoolId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "disciplineIncidents";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.DisciplineTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class DisciplineTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.DisciplineType.DisciplineType, 
        EdFi.Ods.Api.Models.Resources.V2.DisciplineType.DisciplineType, 
        EdFi.Ods.Entities.Common.IDisciplineType, 
        // EdFi.Ods.Entities.NHibernate.DisciplineTypeAggregate.DisciplineType, 
        Api.Models.Requests.v2.DisciplineTypes.DisciplineTypeGetByKey, 
        Api.Models.Requests.v2.DisciplineTypes.DisciplineTypePut,
        Api.Models.Requests.v2.DisciplineTypes.DisciplineTypePost,
        Api.Models.Requests.v2.DisciplineTypes.DisciplineTypeDelete,
        Api.Models.Requests.v2.DisciplineTypes.DisciplineTypeGetByExample>
    {
        public DisciplineTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.DisciplineTypes.DisciplineTypeGetByKey request, IDisciplineType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.DisciplineTypeId = request.DisciplineTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.DisciplineTypes.DisciplineTypeGetByExample request, IDisciplineType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.DisciplineTypeId = request.DisciplineTypeId;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int disciplineTypeId)
        {
            var request = new Api.Models.Requests.v2.DisciplineTypes.DisciplineTypeGetByKey
            {
                DisciplineTypeId = disciplineTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IDisciplineType request)
        {
            return 
                request.DisciplineTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "disciplineTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.EducationalEnvironmentTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class EducationalEnvironmentTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.EducationalEnvironmentType.EducationalEnvironmentType, 
        EdFi.Ods.Api.Models.Resources.V2.EducationalEnvironmentType.EducationalEnvironmentType, 
        EdFi.Ods.Entities.Common.IEducationalEnvironmentType, 
        // EdFi.Ods.Entities.NHibernate.EducationalEnvironmentTypeAggregate.EducationalEnvironmentType, 
        Api.Models.Requests.v2.EducationalEnvironmentTypes.EducationalEnvironmentTypeGetByKey, 
        Api.Models.Requests.v2.EducationalEnvironmentTypes.EducationalEnvironmentTypePut,
        Api.Models.Requests.v2.EducationalEnvironmentTypes.EducationalEnvironmentTypePost,
        Api.Models.Requests.v2.EducationalEnvironmentTypes.EducationalEnvironmentTypeDelete,
        Api.Models.Requests.v2.EducationalEnvironmentTypes.EducationalEnvironmentTypeGetByExample>
    {
        public EducationalEnvironmentTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.EducationalEnvironmentTypes.EducationalEnvironmentTypeGetByKey request, IEducationalEnvironmentType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.EducationalEnvironmentTypeId = request.EducationalEnvironmentTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.EducationalEnvironmentTypes.EducationalEnvironmentTypeGetByExample request, IEducationalEnvironmentType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.EducationalEnvironmentTypeId = request.EducationalEnvironmentTypeId;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int educationalEnvironmentTypeId)
        {
            var request = new Api.Models.Requests.v2.EducationalEnvironmentTypes.EducationalEnvironmentTypeGetByKey
            {
                EducationalEnvironmentTypeId = educationalEnvironmentTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IEducationalEnvironmentType request)
        {
            return 
                request.EducationalEnvironmentTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "educationalEnvironmentTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.EducationContents
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class EducationContentsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.EducationContent.EducationContent, 
        EdFi.Ods.Api.Models.Resources.V2.EducationContent.EducationContent, 
        EdFi.Ods.Entities.Common.IEducationContent, 
        // EdFi.Ods.Entities.NHibernate.EducationContentAggregate.EducationContent, 
        Api.Models.Requests.v2.EducationContents.EducationContentGetByKey, 
        Api.Models.Requests.v2.EducationContents.EducationContentPut,
        Api.Models.Requests.v2.EducationContents.EducationContentPost,
        Api.Models.Requests.v2.EducationContents.EducationContentDelete,
        Api.Models.Requests.v2.EducationContents.EducationContentGetByExample>
    {
        public EducationContentsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.EducationContents.EducationContentGetByKey request, IEducationContent specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.ContentIdentifier = request.ContentIdentifier;
                    }

        protected override void MapAll(Api.Models.Requests.v2.EducationContents.EducationContentGetByExample request, IEducationContent specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.AdditionalAuthorsIndicator = request.AdditionalAuthorsIndicator;
            specification.ContentClassType = request.ContentClassType;
            specification.ContentIdentifier = request.ContentIdentifier;
            specification.Cost = request.Cost;
            specification.CostRateType = request.CostRateType;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.InteractivityStyleType = request.InteractivityStyleType;
            specification.LearningResourceMetadataURI = request.LearningResourceMetadataURI;
            specification.LearningStandardId = request.LearningStandardId;
            specification.Namespace = request.Namespace;
            specification.PublicationDate = request.PublicationDate;
            specification.PublicationYear = request.PublicationYear;
            specification.Publisher = request.Publisher;
            specification.ShortDescription = request.ShortDescription;
            specification.TimeRequired = request.TimeRequired;
            specification.UseRightsURL = request.UseRightsURL;
            specification.Version = request.Version;
                    }
                public IHttpActionResult GetByKey([FromUri] string contentIdentifier)
        {
            var request = new Api.Models.Requests.v2.EducationContents.EducationContentGetByKey
            {
                ContentIdentifier = contentIdentifier,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IEducationContent request)
        {
            return 
                request.ContentIdentifier != default(string);
        }

        protected override string GetResourceCollectionName()
        {
            return "educationContents";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.EducationOrganizationCategoryTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class EducationOrganizationCategoryTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.EducationOrganizationCategoryType.EducationOrganizationCategoryType, 
        EdFi.Ods.Api.Models.Resources.V2.EducationOrganizationCategoryType.EducationOrganizationCategoryType, 
        EdFi.Ods.Entities.Common.IEducationOrganizationCategoryType, 
        // EdFi.Ods.Entities.NHibernate.EducationOrganizationCategoryTypeAggregate.EducationOrganizationCategoryType, 
        Api.Models.Requests.v2.EducationOrganizationCategoryTypes.EducationOrganizationCategoryTypeGetByKey, 
        Api.Models.Requests.v2.EducationOrganizationCategoryTypes.EducationOrganizationCategoryTypePut,
        Api.Models.Requests.v2.EducationOrganizationCategoryTypes.EducationOrganizationCategoryTypePost,
        Api.Models.Requests.v2.EducationOrganizationCategoryTypes.EducationOrganizationCategoryTypeDelete,
        Api.Models.Requests.v2.EducationOrganizationCategoryTypes.EducationOrganizationCategoryTypeGetByExample>
    {
        public EducationOrganizationCategoryTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.EducationOrganizationCategoryTypes.EducationOrganizationCategoryTypeGetByKey request, IEducationOrganizationCategoryType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.EducationOrganizationCategoryTypeId = request.EducationOrganizationCategoryTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.EducationOrganizationCategoryTypes.EducationOrganizationCategoryTypeGetByExample request, IEducationOrganizationCategoryType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.EducationOrganizationCategoryTypeId = request.EducationOrganizationCategoryTypeId;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int educationOrganizationCategoryTypeId)
        {
            var request = new Api.Models.Requests.v2.EducationOrganizationCategoryTypes.EducationOrganizationCategoryTypeGetByKey
            {
                EducationOrganizationCategoryTypeId = educationOrganizationCategoryTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IEducationOrganizationCategoryType request)
        {
            return 
                request.EducationOrganizationCategoryTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "educationOrganizationCategoryTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.EducationOrganizationIdentificationSystemDescriptors
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class EducationOrganizationIdentificationSystemDescriptorsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.EducationOrganizationIdentificationSystemDescriptor.EducationOrganizationIdentificationSystemDescriptor, 
        EdFi.Ods.Api.Models.Resources.V2.EducationOrganizationIdentificationSystemDescriptor.EducationOrganizationIdentificationSystemDescriptor, 
        EdFi.Ods.Entities.Common.IEducationOrganizationIdentificationSystemDescriptor, 
        // EdFi.Ods.Entities.NHibernate.EducationOrganizationIdentificationSystemDescriptorAggregate.EducationOrganizationIdentificationSystemDescriptor, 
        Api.Models.Requests.v2.EducationOrganizationIdentificationSystemDescriptors.EducationOrganizationIdentificationSystemDescriptorGetByKey, 
        Api.Models.Requests.v2.EducationOrganizationIdentificationSystemDescriptors.EducationOrganizationIdentificationSystemDescriptorPut,
        Api.Models.Requests.v2.EducationOrganizationIdentificationSystemDescriptors.EducationOrganizationIdentificationSystemDescriptorPost,
        Api.Models.Requests.v2.EducationOrganizationIdentificationSystemDescriptors.EducationOrganizationIdentificationSystemDescriptorDelete,
        Api.Models.Requests.v2.EducationOrganizationIdentificationSystemDescriptors.EducationOrganizationIdentificationSystemDescriptorGetByExample>
    {
        public EducationOrganizationIdentificationSystemDescriptorsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.EducationOrganizationIdentificationSystemDescriptors.EducationOrganizationIdentificationSystemDescriptorGetByKey request, IEducationOrganizationIdentificationSystemDescriptor specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.EducationOrganizationIdentificationSystemDescriptorId = request.EducationOrganizationIdentificationSystemDescriptorId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.EducationOrganizationIdentificationSystemDescriptors.EducationOrganizationIdentificationSystemDescriptorGetByExample request, IEducationOrganizationIdentificationSystemDescriptor specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.EducationOrganizationIdentificationSystemDescriptorId = request.EducationOrganizationIdentificationSystemDescriptorId;
            specification.EducationOrganizationIdentificationSystemType = request.EducationOrganizationIdentificationSystemType;
                    }
                public IHttpActionResult GetByKey([FromUri] int educationOrganizationIdentificationSystemDescriptorId)
        {
            var request = new Api.Models.Requests.v2.EducationOrganizationIdentificationSystemDescriptors.EducationOrganizationIdentificationSystemDescriptorGetByKey
            {
                EducationOrganizationIdentificationSystemDescriptorId = educationOrganizationIdentificationSystemDescriptorId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IEducationOrganizationIdentificationSystemDescriptor request)
        {
            return 
                request.EducationOrganizationIdentificationSystemDescriptorId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "educationOrganizationIdentificationSystemDescriptors";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.EducationOrganizationIdentificationSystemTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class EducationOrganizationIdentificationSystemTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.EducationOrganizationIdentificationSystemType.EducationOrganizationIdentificationSystemType, 
        EdFi.Ods.Api.Models.Resources.V2.EducationOrganizationIdentificationSystemType.EducationOrganizationIdentificationSystemType, 
        EdFi.Ods.Entities.Common.IEducationOrganizationIdentificationSystemType, 
        // EdFi.Ods.Entities.NHibernate.EducationOrganizationIdentificationSystemTypeAggregate.EducationOrganizationIdentificationSystemType, 
        Api.Models.Requests.v2.EducationOrganizationIdentificationSystemTypes.EducationOrganizationIdentificationSystemTypeGetByKey, 
        Api.Models.Requests.v2.EducationOrganizationIdentificationSystemTypes.EducationOrganizationIdentificationSystemTypePut,
        Api.Models.Requests.v2.EducationOrganizationIdentificationSystemTypes.EducationOrganizationIdentificationSystemTypePost,
        Api.Models.Requests.v2.EducationOrganizationIdentificationSystemTypes.EducationOrganizationIdentificationSystemTypeDelete,
        Api.Models.Requests.v2.EducationOrganizationIdentificationSystemTypes.EducationOrganizationIdentificationSystemTypeGetByExample>
    {
        public EducationOrganizationIdentificationSystemTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.EducationOrganizationIdentificationSystemTypes.EducationOrganizationIdentificationSystemTypeGetByKey request, IEducationOrganizationIdentificationSystemType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.EducationOrganizationIdentificationSystemTypeId = request.EducationOrganizationIdentificationSystemTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.EducationOrganizationIdentificationSystemTypes.EducationOrganizationIdentificationSystemTypeGetByExample request, IEducationOrganizationIdentificationSystemType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.EducationOrganizationIdentificationSystemTypeId = request.EducationOrganizationIdentificationSystemTypeId;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int educationOrganizationIdentificationSystemTypeId)
        {
            var request = new Api.Models.Requests.v2.EducationOrganizationIdentificationSystemTypes.EducationOrganizationIdentificationSystemTypeGetByKey
            {
                EducationOrganizationIdentificationSystemTypeId = educationOrganizationIdentificationSystemTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IEducationOrganizationIdentificationSystemType request)
        {
            return 
                request.EducationOrganizationIdentificationSystemTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "educationOrganizationIdentificationSystemTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.EducationOrganizationInterventionPrescriptionAssociations
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class EducationOrganizationInterventionPrescriptionAssociationsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.EducationOrganizationInterventionPrescriptionAssociation.EducationOrganizationInterventionPrescriptionAssociation, 
        EdFi.Ods.Api.Models.Resources.V2.EducationOrganizationInterventionPrescriptionAssociation.EducationOrganizationInterventionPrescriptionAssociation, 
        EdFi.Ods.Entities.Common.IEducationOrganizationInterventionPrescriptionAssociation, 
        // EdFi.Ods.Entities.NHibernate.EducationOrganizationInterventionPrescriptionAssociationAggregate.EducationOrganizationInterventionPrescriptionAssociation, 
        Api.Models.Requests.v2.EducationOrganizationInterventionPrescriptionAssociations.EducationOrganizationInterventionPrescriptionAssociationGetByKey, 
        Api.Models.Requests.v2.EducationOrganizationInterventionPrescriptionAssociations.EducationOrganizationInterventionPrescriptionAssociationPut,
        Api.Models.Requests.v2.EducationOrganizationInterventionPrescriptionAssociations.EducationOrganizationInterventionPrescriptionAssociationPost,
        Api.Models.Requests.v2.EducationOrganizationInterventionPrescriptionAssociations.EducationOrganizationInterventionPrescriptionAssociationDelete,
        Api.Models.Requests.v2.EducationOrganizationInterventionPrescriptionAssociations.EducationOrganizationInterventionPrescriptionAssociationGetByExample>
    {
        public EducationOrganizationInterventionPrescriptionAssociationsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.EducationOrganizationInterventionPrescriptionAssociations.EducationOrganizationInterventionPrescriptionAssociationGetByKey request, IEducationOrganizationInterventionPrescriptionAssociation specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.InterventionPrescriptionEducationOrganizationId = request.InterventionPrescriptionEducationOrganizationId;
            specification.InterventionPrescriptionIdentificationCode = request.InterventionPrescriptionIdentificationCode;
                    }

        protected override void MapAll(Api.Models.Requests.v2.EducationOrganizationInterventionPrescriptionAssociations.EducationOrganizationInterventionPrescriptionAssociationGetByExample request, IEducationOrganizationInterventionPrescriptionAssociation specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.BeginDate = request.BeginDate;
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.EndDate = request.EndDate;
            specification.Id = request.Id;
            specification.InterventionPrescriptionEducationOrganizationId = request.InterventionPrescriptionEducationOrganizationId;
            specification.InterventionPrescriptionIdentificationCode = request.InterventionPrescriptionIdentificationCode;
                    }
                public IHttpActionResult GetByKey([FromUri] int educationOrganizationId, int interventionPrescriptionEducationOrganizationId, string interventionPrescriptionIdentificationCode)
        {
            var request = new Api.Models.Requests.v2.EducationOrganizationInterventionPrescriptionAssociations.EducationOrganizationInterventionPrescriptionAssociationGetByKey
            {
                EducationOrganizationId = educationOrganizationId,
                InterventionPrescriptionEducationOrganizationId = interventionPrescriptionEducationOrganizationId,
                InterventionPrescriptionIdentificationCode = interventionPrescriptionIdentificationCode,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IEducationOrganizationInterventionPrescriptionAssociation request)
        {
            return 
                request.EducationOrganizationId != default(int)
                && request.InterventionPrescriptionEducationOrganizationId != default(int)
                && request.InterventionPrescriptionIdentificationCode != default(string);
        }

        protected override string GetResourceCollectionName()
        {
            return "educationOrganizationInterventionPrescriptionAssociations";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.EducationOrganizationNetworks
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class EducationOrganizationNetworksController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.EducationOrganizationNetwork.EducationOrganizationNetwork, 
        EdFi.Ods.Api.Models.Resources.V2.EducationOrganizationNetwork.EducationOrganizationNetwork, 
        EdFi.Ods.Entities.Common.IEducationOrganizationNetwork, 
        // EdFi.Ods.Entities.NHibernate.EducationOrganizationNetworkAggregate.EducationOrganizationNetwork, 
        Api.Models.Requests.v2.EducationOrganizationNetworks.EducationOrganizationNetworkGetByKey, 
        Api.Models.Requests.v2.EducationOrganizationNetworks.EducationOrganizationNetworkPut,
        Api.Models.Requests.v2.EducationOrganizationNetworks.EducationOrganizationNetworkPost,
        Api.Models.Requests.v2.EducationOrganizationNetworks.EducationOrganizationNetworkDelete,
        Api.Models.Requests.v2.EducationOrganizationNetworks.EducationOrganizationNetworkGetByExample>
    {
        public EducationOrganizationNetworksController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.EducationOrganizationNetworks.EducationOrganizationNetworkGetByKey request, IEducationOrganizationNetwork specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.EducationOrganizationNetworkId = request.EducationOrganizationNetworkId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.EducationOrganizationNetworks.EducationOrganizationNetworkGetByExample request, IEducationOrganizationNetwork specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.EducationOrganizationNetworkId = request.EducationOrganizationNetworkId;
            specification.NetworkPurposeType = request.NetworkPurposeType;
                    }
                public IHttpActionResult GetByKey([FromUri] int educationOrganizationNetworkId)
        {
            var request = new Api.Models.Requests.v2.EducationOrganizationNetworks.EducationOrganizationNetworkGetByKey
            {
                EducationOrganizationNetworkId = educationOrganizationNetworkId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IEducationOrganizationNetwork request)
        {
            return 
                request.EducationOrganizationNetworkId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "educationOrganizationNetworks";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.EducationOrganizationNetworkAssociations
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class EducationOrganizationNetworkAssociationsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.EducationOrganizationNetworkAssociation.EducationOrganizationNetworkAssociation, 
        EdFi.Ods.Api.Models.Resources.V2.EducationOrganizationNetworkAssociation.EducationOrganizationNetworkAssociation, 
        EdFi.Ods.Entities.Common.IEducationOrganizationNetworkAssociation, 
        // EdFi.Ods.Entities.NHibernate.EducationOrganizationNetworkAssociationAggregate.EducationOrganizationNetworkAssociation, 
        Api.Models.Requests.v2.EducationOrganizationNetworkAssociations.EducationOrganizationNetworkAssociationGetByKey, 
        Api.Models.Requests.v2.EducationOrganizationNetworkAssociations.EducationOrganizationNetworkAssociationPut,
        Api.Models.Requests.v2.EducationOrganizationNetworkAssociations.EducationOrganizationNetworkAssociationPost,
        Api.Models.Requests.v2.EducationOrganizationNetworkAssociations.EducationOrganizationNetworkAssociationDelete,
        Api.Models.Requests.v2.EducationOrganizationNetworkAssociations.EducationOrganizationNetworkAssociationGetByExample>
    {
        public EducationOrganizationNetworkAssociationsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.EducationOrganizationNetworkAssociations.EducationOrganizationNetworkAssociationGetByKey request, IEducationOrganizationNetworkAssociation specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.EducationOrganizationNetworkId = request.EducationOrganizationNetworkId;
            specification.MemberEducationOrganizationId = request.MemberEducationOrganizationId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.EducationOrganizationNetworkAssociations.EducationOrganizationNetworkAssociationGetByExample request, IEducationOrganizationNetworkAssociation specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.BeginDate = request.BeginDate;
            specification.EducationOrganizationNetworkId = request.EducationOrganizationNetworkId;
            specification.EndDate = request.EndDate;
            specification.Id = request.Id;
            specification.MemberEducationOrganizationId = request.MemberEducationOrganizationId;
                    }
                public IHttpActionResult GetByKey([FromUri] int educationOrganizationNetworkId, int memberEducationOrganizationId)
        {
            var request = new Api.Models.Requests.v2.EducationOrganizationNetworkAssociations.EducationOrganizationNetworkAssociationGetByKey
            {
                EducationOrganizationNetworkId = educationOrganizationNetworkId,
                MemberEducationOrganizationId = memberEducationOrganizationId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IEducationOrganizationNetworkAssociation request)
        {
            return 
                request.EducationOrganizationNetworkId != default(int)
                && request.MemberEducationOrganizationId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "educationOrganizationNetworkAssociations";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.EducationOrganizationPeerAssociations
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class EducationOrganizationPeerAssociationsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.EducationOrganizationPeerAssociation.EducationOrganizationPeerAssociation, 
        EdFi.Ods.Api.Models.Resources.V2.EducationOrganizationPeerAssociation.EducationOrganizationPeerAssociation, 
        EdFi.Ods.Entities.Common.IEducationOrganizationPeerAssociation, 
        // EdFi.Ods.Entities.NHibernate.EducationOrganizationPeerAssociationAggregate.EducationOrganizationPeerAssociation, 
        Api.Models.Requests.v2.EducationOrganizationPeerAssociations.EducationOrganizationPeerAssociationGetByKey, 
        Api.Models.Requests.v2.EducationOrganizationPeerAssociations.EducationOrganizationPeerAssociationPut,
        Api.Models.Requests.v2.EducationOrganizationPeerAssociations.EducationOrganizationPeerAssociationPost,
        Api.Models.Requests.v2.EducationOrganizationPeerAssociations.EducationOrganizationPeerAssociationDelete,
        Api.Models.Requests.v2.EducationOrganizationPeerAssociations.EducationOrganizationPeerAssociationGetByExample>
    {
        public EducationOrganizationPeerAssociationsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.EducationOrganizationPeerAssociations.EducationOrganizationPeerAssociationGetByKey request, IEducationOrganizationPeerAssociation specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.PeerEducationOrganizationId = request.PeerEducationOrganizationId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.EducationOrganizationPeerAssociations.EducationOrganizationPeerAssociationGetByExample request, IEducationOrganizationPeerAssociation specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.Id = request.Id;
            specification.PeerEducationOrganizationId = request.PeerEducationOrganizationId;
                    }
                public IHttpActionResult GetByKey([FromUri] int educationOrganizationId, int peerEducationOrganizationId)
        {
            var request = new Api.Models.Requests.v2.EducationOrganizationPeerAssociations.EducationOrganizationPeerAssociationGetByKey
            {
                EducationOrganizationId = educationOrganizationId,
                PeerEducationOrganizationId = peerEducationOrganizationId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IEducationOrganizationPeerAssociation request)
        {
            return 
                request.EducationOrganizationId != default(int)
                && request.PeerEducationOrganizationId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "educationOrganizationPeerAssociations";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.EducationPlanTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class EducationPlanTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.EducationPlanType.EducationPlanType, 
        EdFi.Ods.Api.Models.Resources.V2.EducationPlanType.EducationPlanType, 
        EdFi.Ods.Entities.Common.IEducationPlanType, 
        // EdFi.Ods.Entities.NHibernate.EducationPlanTypeAggregate.EducationPlanType, 
        Api.Models.Requests.v2.EducationPlanTypes.EducationPlanTypeGetByKey, 
        Api.Models.Requests.v2.EducationPlanTypes.EducationPlanTypePut,
        Api.Models.Requests.v2.EducationPlanTypes.EducationPlanTypePost,
        Api.Models.Requests.v2.EducationPlanTypes.EducationPlanTypeDelete,
        Api.Models.Requests.v2.EducationPlanTypes.EducationPlanTypeGetByExample>
    {
        public EducationPlanTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.EducationPlanTypes.EducationPlanTypeGetByKey request, IEducationPlanType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.EducationPlanTypeId = request.EducationPlanTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.EducationPlanTypes.EducationPlanTypeGetByExample request, IEducationPlanType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.EducationPlanTypeId = request.EducationPlanTypeId;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int educationPlanTypeId)
        {
            var request = new Api.Models.Requests.v2.EducationPlanTypes.EducationPlanTypeGetByKey
            {
                EducationPlanTypeId = educationPlanTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IEducationPlanType request)
        {
            return 
                request.EducationPlanTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "educationPlanTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.EducationServiceCenters
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class EducationServiceCentersController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.EducationServiceCenter.EducationServiceCenter, 
        EdFi.Ods.Api.Models.Resources.V2.EducationServiceCenter.EducationServiceCenter, 
        EdFi.Ods.Entities.Common.IEducationServiceCenter, 
        // EdFi.Ods.Entities.NHibernate.EducationServiceCenterAggregate.EducationServiceCenter, 
        Api.Models.Requests.v2.EducationServiceCenters.EducationServiceCenterGetByKey, 
        Api.Models.Requests.v2.EducationServiceCenters.EducationServiceCenterPut,
        Api.Models.Requests.v2.EducationServiceCenters.EducationServiceCenterPost,
        Api.Models.Requests.v2.EducationServiceCenters.EducationServiceCenterDelete,
        Api.Models.Requests.v2.EducationServiceCenters.EducationServiceCenterGetByExample>
    {
        public EducationServiceCentersController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.EducationServiceCenters.EducationServiceCenterGetByKey request, IEducationServiceCenter specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.EducationServiceCenterId = request.EducationServiceCenterId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.EducationServiceCenters.EducationServiceCenterGetByExample request, IEducationServiceCenter specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.EducationServiceCenterId = request.EducationServiceCenterId;
            specification.StateEducationAgencyId = request.StateEducationAgencyId;
                    }
                public IHttpActionResult GetByKey([FromUri] int educationServiceCenterId)
        {
            var request = new Api.Models.Requests.v2.EducationServiceCenters.EducationServiceCenterGetByKey
            {
                EducationServiceCenterId = educationServiceCenterId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IEducationServiceCenter request)
        {
            return 
                request.EducationServiceCenterId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "educationServiceCenters";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.ElectronicMailTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class ElectronicMailTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.ElectronicMailType.ElectronicMailType, 
        EdFi.Ods.Api.Models.Resources.V2.ElectronicMailType.ElectronicMailType, 
        EdFi.Ods.Entities.Common.IElectronicMailType, 
        // EdFi.Ods.Entities.NHibernate.ElectronicMailTypeAggregate.ElectronicMailType, 
        Api.Models.Requests.v2.ElectronicMailTypes.ElectronicMailTypeGetByKey, 
        Api.Models.Requests.v2.ElectronicMailTypes.ElectronicMailTypePut,
        Api.Models.Requests.v2.ElectronicMailTypes.ElectronicMailTypePost,
        Api.Models.Requests.v2.ElectronicMailTypes.ElectronicMailTypeDelete,
        Api.Models.Requests.v2.ElectronicMailTypes.ElectronicMailTypeGetByExample>
    {
        public ElectronicMailTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.ElectronicMailTypes.ElectronicMailTypeGetByKey request, IElectronicMailType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.ElectronicMailTypeId = request.ElectronicMailTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.ElectronicMailTypes.ElectronicMailTypeGetByExample request, IElectronicMailType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.ElectronicMailTypeId = request.ElectronicMailTypeId;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int electronicMailTypeId)
        {
            var request = new Api.Models.Requests.v2.ElectronicMailTypes.ElectronicMailTypeGetByKey
            {
                ElectronicMailTypeId = electronicMailTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IElectronicMailType request)
        {
            return 
                request.ElectronicMailTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "electronicMailTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.EmploymentStatusDescriptors
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class EmploymentStatusDescriptorsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.EmploymentStatusDescriptor.EmploymentStatusDescriptor, 
        EdFi.Ods.Api.Models.Resources.V2.EmploymentStatusDescriptor.EmploymentStatusDescriptor, 
        EdFi.Ods.Entities.Common.IEmploymentStatusDescriptor, 
        // EdFi.Ods.Entities.NHibernate.EmploymentStatusDescriptorAggregate.EmploymentStatusDescriptor, 
        Api.Models.Requests.v2.EmploymentStatusDescriptors.EmploymentStatusDescriptorGetByKey, 
        Api.Models.Requests.v2.EmploymentStatusDescriptors.EmploymentStatusDescriptorPut,
        Api.Models.Requests.v2.EmploymentStatusDescriptors.EmploymentStatusDescriptorPost,
        Api.Models.Requests.v2.EmploymentStatusDescriptors.EmploymentStatusDescriptorDelete,
        Api.Models.Requests.v2.EmploymentStatusDescriptors.EmploymentStatusDescriptorGetByExample>
    {
        public EmploymentStatusDescriptorsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.EmploymentStatusDescriptors.EmploymentStatusDescriptorGetByKey request, IEmploymentStatusDescriptor specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.EmploymentStatusDescriptorId = request.EmploymentStatusDescriptorId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.EmploymentStatusDescriptors.EmploymentStatusDescriptorGetByExample request, IEmploymentStatusDescriptor specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.EmploymentStatusDescriptorId = request.EmploymentStatusDescriptorId;
            specification.EmploymentStatusType = request.EmploymentStatusType;
                    }
                public IHttpActionResult GetByKey([FromUri] int employmentStatusDescriptorId)
        {
            var request = new Api.Models.Requests.v2.EmploymentStatusDescriptors.EmploymentStatusDescriptorGetByKey
            {
                EmploymentStatusDescriptorId = employmentStatusDescriptorId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IEmploymentStatusDescriptor request)
        {
            return 
                request.EmploymentStatusDescriptorId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "employmentStatusDescriptors";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.EmploymentStatusTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class EmploymentStatusTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.EmploymentStatusType.EmploymentStatusType, 
        EdFi.Ods.Api.Models.Resources.V2.EmploymentStatusType.EmploymentStatusType, 
        EdFi.Ods.Entities.Common.IEmploymentStatusType, 
        // EdFi.Ods.Entities.NHibernate.EmploymentStatusTypeAggregate.EmploymentStatusType, 
        Api.Models.Requests.v2.EmploymentStatusTypes.EmploymentStatusTypeGetByKey, 
        Api.Models.Requests.v2.EmploymentStatusTypes.EmploymentStatusTypePut,
        Api.Models.Requests.v2.EmploymentStatusTypes.EmploymentStatusTypePost,
        Api.Models.Requests.v2.EmploymentStatusTypes.EmploymentStatusTypeDelete,
        Api.Models.Requests.v2.EmploymentStatusTypes.EmploymentStatusTypeGetByExample>
    {
        public EmploymentStatusTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.EmploymentStatusTypes.EmploymentStatusTypeGetByKey request, IEmploymentStatusType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.EmploymentStatusTypeId = request.EmploymentStatusTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.EmploymentStatusTypes.EmploymentStatusTypeGetByExample request, IEmploymentStatusType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.EmploymentStatusTypeId = request.EmploymentStatusTypeId;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int employmentStatusTypeId)
        {
            var request = new Api.Models.Requests.v2.EmploymentStatusTypes.EmploymentStatusTypeGetByKey
            {
                EmploymentStatusTypeId = employmentStatusTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IEmploymentStatusType request)
        {
            return 
                request.EmploymentStatusTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "employmentStatusTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.EntryGradeLevelReasonTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class EntryGradeLevelReasonTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.EntryGradeLevelReasonType.EntryGradeLevelReasonType, 
        EdFi.Ods.Api.Models.Resources.V2.EntryGradeLevelReasonType.EntryGradeLevelReasonType, 
        EdFi.Ods.Entities.Common.IEntryGradeLevelReasonType, 
        // EdFi.Ods.Entities.NHibernate.EntryGradeLevelReasonTypeAggregate.EntryGradeLevelReasonType, 
        Api.Models.Requests.v2.EntryGradeLevelReasonTypes.EntryGradeLevelReasonTypeGetByKey, 
        Api.Models.Requests.v2.EntryGradeLevelReasonTypes.EntryGradeLevelReasonTypePut,
        Api.Models.Requests.v2.EntryGradeLevelReasonTypes.EntryGradeLevelReasonTypePost,
        Api.Models.Requests.v2.EntryGradeLevelReasonTypes.EntryGradeLevelReasonTypeDelete,
        Api.Models.Requests.v2.EntryGradeLevelReasonTypes.EntryGradeLevelReasonTypeGetByExample>
    {
        public EntryGradeLevelReasonTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.EntryGradeLevelReasonTypes.EntryGradeLevelReasonTypeGetByKey request, IEntryGradeLevelReasonType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.EntryGradeLevelReasonTypeId = request.EntryGradeLevelReasonTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.EntryGradeLevelReasonTypes.EntryGradeLevelReasonTypeGetByExample request, IEntryGradeLevelReasonType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.EntryGradeLevelReasonTypeId = request.EntryGradeLevelReasonTypeId;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int entryGradeLevelReasonTypeId)
        {
            var request = new Api.Models.Requests.v2.EntryGradeLevelReasonTypes.EntryGradeLevelReasonTypeGetByKey
            {
                EntryGradeLevelReasonTypeId = entryGradeLevelReasonTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IEntryGradeLevelReasonType request)
        {
            return 
                request.EntryGradeLevelReasonTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "entryGradeLevelReasonTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.EntryTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class EntryTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.EntryType.EntryType, 
        EdFi.Ods.Api.Models.Resources.V2.EntryType.EntryType, 
        EdFi.Ods.Entities.Common.IEntryType, 
        // EdFi.Ods.Entities.NHibernate.EntryTypeAggregate.EntryType, 
        Api.Models.Requests.v2.EntryTypes.EntryTypeGetByKey, 
        Api.Models.Requests.v2.EntryTypes.EntryTypePut,
        Api.Models.Requests.v2.EntryTypes.EntryTypePost,
        Api.Models.Requests.v2.EntryTypes.EntryTypeDelete,
        Api.Models.Requests.v2.EntryTypes.EntryTypeGetByExample>
    {
        public EntryTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.EntryTypes.EntryTypeGetByKey request, IEntryType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.EntryTypeId = request.EntryTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.EntryTypes.EntryTypeGetByExample request, IEntryType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.EntryTypeId = request.EntryTypeId;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int entryTypeId)
        {
            var request = new Api.Models.Requests.v2.EntryTypes.EntryTypeGetByKey
            {
                EntryTypeId = entryTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IEntryType request)
        {
            return 
                request.EntryTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "entryTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.EntryTypeDescriptors
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class EntryTypeDescriptorsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.EntryTypeDescriptor.EntryTypeDescriptor, 
        EdFi.Ods.Api.Models.Resources.V2.EntryTypeDescriptor.EntryTypeDescriptor, 
        EdFi.Ods.Entities.Common.IEntryTypeDescriptor, 
        // EdFi.Ods.Entities.NHibernate.EntryTypeDescriptorAggregate.EntryTypeDescriptor, 
        Api.Models.Requests.v2.EntryTypeDescriptors.EntryTypeDescriptorGetByKey, 
        Api.Models.Requests.v2.EntryTypeDescriptors.EntryTypeDescriptorPut,
        Api.Models.Requests.v2.EntryTypeDescriptors.EntryTypeDescriptorPost,
        Api.Models.Requests.v2.EntryTypeDescriptors.EntryTypeDescriptorDelete,
        Api.Models.Requests.v2.EntryTypeDescriptors.EntryTypeDescriptorGetByExample>
    {
        public EntryTypeDescriptorsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.EntryTypeDescriptors.EntryTypeDescriptorGetByKey request, IEntryTypeDescriptor specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.EntryTypeDescriptorId = request.EntryTypeDescriptorId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.EntryTypeDescriptors.EntryTypeDescriptorGetByExample request, IEntryTypeDescriptor specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.EntryTypeDescriptorId = request.EntryTypeDescriptorId;
            specification.EntryType = request.EntryType;
                    }
                public IHttpActionResult GetByKey([FromUri] int entryTypeDescriptorId)
        {
            var request = new Api.Models.Requests.v2.EntryTypeDescriptors.EntryTypeDescriptorGetByKey
            {
                EntryTypeDescriptorId = entryTypeDescriptorId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IEntryTypeDescriptor request)
        {
            return 
                request.EntryTypeDescriptorId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "entryTypeDescriptors";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.EventCircumstanceTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class EventCircumstanceTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.EventCircumstanceType.EventCircumstanceType, 
        EdFi.Ods.Api.Models.Resources.V2.EventCircumstanceType.EventCircumstanceType, 
        EdFi.Ods.Entities.Common.IEventCircumstanceType, 
        // EdFi.Ods.Entities.NHibernate.EventCircumstanceTypeAggregate.EventCircumstanceType, 
        Api.Models.Requests.v2.EventCircumstanceTypes.EventCircumstanceTypeGetByKey, 
        Api.Models.Requests.v2.EventCircumstanceTypes.EventCircumstanceTypePut,
        Api.Models.Requests.v2.EventCircumstanceTypes.EventCircumstanceTypePost,
        Api.Models.Requests.v2.EventCircumstanceTypes.EventCircumstanceTypeDelete,
        Api.Models.Requests.v2.EventCircumstanceTypes.EventCircumstanceTypeGetByExample>
    {
        public EventCircumstanceTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.EventCircumstanceTypes.EventCircumstanceTypeGetByKey request, IEventCircumstanceType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.EventCircumstanceTypeId = request.EventCircumstanceTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.EventCircumstanceTypes.EventCircumstanceTypeGetByExample request, IEventCircumstanceType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.EventCircumstanceTypeId = request.EventCircumstanceTypeId;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int eventCircumstanceTypeId)
        {
            var request = new Api.Models.Requests.v2.EventCircumstanceTypes.EventCircumstanceTypeGetByKey
            {
                EventCircumstanceTypeId = eventCircumstanceTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IEventCircumstanceType request)
        {
            return 
                request.EventCircumstanceTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "eventCircumstanceTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.ExitWithdrawTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class ExitWithdrawTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.ExitWithdrawType.ExitWithdrawType, 
        EdFi.Ods.Api.Models.Resources.V2.ExitWithdrawType.ExitWithdrawType, 
        EdFi.Ods.Entities.Common.IExitWithdrawType, 
        // EdFi.Ods.Entities.NHibernate.ExitWithdrawTypeAggregate.ExitWithdrawType, 
        Api.Models.Requests.v2.ExitWithdrawTypes.ExitWithdrawTypeGetByKey, 
        Api.Models.Requests.v2.ExitWithdrawTypes.ExitWithdrawTypePut,
        Api.Models.Requests.v2.ExitWithdrawTypes.ExitWithdrawTypePost,
        Api.Models.Requests.v2.ExitWithdrawTypes.ExitWithdrawTypeDelete,
        Api.Models.Requests.v2.ExitWithdrawTypes.ExitWithdrawTypeGetByExample>
    {
        public ExitWithdrawTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.ExitWithdrawTypes.ExitWithdrawTypeGetByKey request, IExitWithdrawType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.ExitWithdrawTypeId = request.ExitWithdrawTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.ExitWithdrawTypes.ExitWithdrawTypeGetByExample request, IExitWithdrawType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.ExitWithdrawTypeId = request.ExitWithdrawTypeId;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int exitWithdrawTypeId)
        {
            var request = new Api.Models.Requests.v2.ExitWithdrawTypes.ExitWithdrawTypeGetByKey
            {
                ExitWithdrawTypeId = exitWithdrawTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IExitWithdrawType request)
        {
            return 
                request.ExitWithdrawTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "exitWithdrawTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.ExitWithdrawTypeDescriptors
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class ExitWithdrawTypeDescriptorsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.ExitWithdrawTypeDescriptor.ExitWithdrawTypeDescriptor, 
        EdFi.Ods.Api.Models.Resources.V2.ExitWithdrawTypeDescriptor.ExitWithdrawTypeDescriptor, 
        EdFi.Ods.Entities.Common.IExitWithdrawTypeDescriptor, 
        // EdFi.Ods.Entities.NHibernate.ExitWithdrawTypeDescriptorAggregate.ExitWithdrawTypeDescriptor, 
        Api.Models.Requests.v2.ExitWithdrawTypeDescriptors.ExitWithdrawTypeDescriptorGetByKey, 
        Api.Models.Requests.v2.ExitWithdrawTypeDescriptors.ExitWithdrawTypeDescriptorPut,
        Api.Models.Requests.v2.ExitWithdrawTypeDescriptors.ExitWithdrawTypeDescriptorPost,
        Api.Models.Requests.v2.ExitWithdrawTypeDescriptors.ExitWithdrawTypeDescriptorDelete,
        Api.Models.Requests.v2.ExitWithdrawTypeDescriptors.ExitWithdrawTypeDescriptorGetByExample>
    {
        public ExitWithdrawTypeDescriptorsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.ExitWithdrawTypeDescriptors.ExitWithdrawTypeDescriptorGetByKey request, IExitWithdrawTypeDescriptor specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.ExitWithdrawTypeDescriptorId = request.ExitWithdrawTypeDescriptorId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.ExitWithdrawTypeDescriptors.ExitWithdrawTypeDescriptorGetByExample request, IExitWithdrawTypeDescriptor specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.ExitWithdrawTypeDescriptorId = request.ExitWithdrawTypeDescriptorId;
            specification.ExitWithdrawType = request.ExitWithdrawType;
                    }
                public IHttpActionResult GetByKey([FromUri] int exitWithdrawTypeDescriptorId)
        {
            var request = new Api.Models.Requests.v2.ExitWithdrawTypeDescriptors.ExitWithdrawTypeDescriptorGetByKey
            {
                ExitWithdrawTypeDescriptorId = exitWithdrawTypeDescriptorId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IExitWithdrawTypeDescriptor request)
        {
            return 
                request.ExitWithdrawTypeDescriptorId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "exitWithdrawTypeDescriptors";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.FeederSchoolAssociations
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class FeederSchoolAssociationsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.FeederSchoolAssociation.FeederSchoolAssociation, 
        EdFi.Ods.Api.Models.Resources.V2.FeederSchoolAssociation.FeederSchoolAssociation, 
        EdFi.Ods.Entities.Common.IFeederSchoolAssociation, 
        // EdFi.Ods.Entities.NHibernate.FeederSchoolAssociationAggregate.FeederSchoolAssociation, 
        Api.Models.Requests.v2.FeederSchoolAssociations.FeederSchoolAssociationGetByKey, 
        Api.Models.Requests.v2.FeederSchoolAssociations.FeederSchoolAssociationPut,
        Api.Models.Requests.v2.FeederSchoolAssociations.FeederSchoolAssociationPost,
        Api.Models.Requests.v2.FeederSchoolAssociations.FeederSchoolAssociationDelete,
        Api.Models.Requests.v2.FeederSchoolAssociations.FeederSchoolAssociationGetByExample>
    {
        public FeederSchoolAssociationsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.FeederSchoolAssociations.FeederSchoolAssociationGetByKey request, IFeederSchoolAssociation specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.BeginDate = request.BeginDate;
            specification.FeederSchoolId = request.FeederSchoolId;
            specification.SchoolId = request.SchoolId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.FeederSchoolAssociations.FeederSchoolAssociationGetByExample request, IFeederSchoolAssociation specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.BeginDate = request.BeginDate;
            specification.EndDate = request.EndDate;
            specification.FeederRelationshipDescription = request.FeederRelationshipDescription;
            specification.FeederSchoolId = request.FeederSchoolId;
            specification.Id = request.Id;
            specification.SchoolId = request.SchoolId;
                    }
                public IHttpActionResult GetByKey([FromUri] DateTime beginDate, int feederSchoolId, int schoolId)
        {
            var request = new Api.Models.Requests.v2.FeederSchoolAssociations.FeederSchoolAssociationGetByKey
            {
                BeginDate = beginDate,
                FeederSchoolId = feederSchoolId,
                SchoolId = schoolId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IFeederSchoolAssociation request)
        {
            return 
                request.BeginDate != default(DateTime)
                && request.FeederSchoolId != default(int)
                && request.SchoolId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "feederSchoolAssociations";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.Grades
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class GradesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.Grade.Grade, 
        EdFi.Ods.Api.Models.Resources.V2.Grade.Grade, 
        EdFi.Ods.Entities.Common.IGrade, 
        // EdFi.Ods.Entities.NHibernate.GradeAggregate.Grade, 
        Api.Models.Requests.v2.Grades.GradeGetByKey, 
        Api.Models.Requests.v2.Grades.GradePut,
        Api.Models.Requests.v2.Grades.GradePost,
        Api.Models.Requests.v2.Grades.GradeDelete,
        Api.Models.Requests.v2.Grades.GradeGetByExample>
    {
        public GradesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.Grades.GradeGetByKey request, IGrade specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.BeginDate = request.BeginDate;
            specification.ClassPeriodName = request.ClassPeriodName;
            specification.ClassroomIdentificationCode = request.ClassroomIdentificationCode;
            specification.GradeType = request.Type;
            specification.GradingPeriodBeginDate = request.GradingPeriodBeginDate;
            specification.GradingPeriodDescriptor = request.GradingPeriodDescriptor;
            specification.LocalCourseCode = request.LocalCourseCode;
            specification.SchoolId = request.SchoolId;
            specification.SchoolYear = request.SchoolYear;
            specification.SequenceOfCourse = request.SequenceOfCourse;
            specification.StudentUniqueId = request.StudentUniqueId;
            specification.TermDescriptor = request.TermDescriptor;
            specification.UniqueSectionCode = request.UniqueSectionCode;
                    }

        protected override void MapAll(Api.Models.Requests.v2.Grades.GradeGetByExample request, IGrade specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.BeginDate = request.BeginDate;
            specification.ClassPeriodName = request.ClassPeriodName;
            specification.ClassroomIdentificationCode = request.ClassroomIdentificationCode;
            specification.DiagnosticStatement = request.DiagnosticStatement;
            specification.GradeType = request.Type;
            specification.GradingPeriodBeginDate = request.GradingPeriodBeginDate;
            specification.GradingPeriodDescriptor = request.GradingPeriodDescriptor;
            specification.Id = request.Id;
            specification.LetterGradeEarned = request.LetterGradeEarned;
            specification.LocalCourseCode = request.LocalCourseCode;
            specification.NumericGradeEarned = request.NumericGradeEarned;
            specification.PerformanceBaseConversionType = request.PerformanceBaseConversionType;
            specification.SchoolId = request.SchoolId;
            specification.SchoolYear = request.SchoolYear;
            specification.SequenceOfCourse = request.SequenceOfCourse;
            specification.StudentUniqueId = request.StudentUniqueId;
            specification.TermDescriptor = request.TermDescriptor;
            specification.UniqueSectionCode = request.UniqueSectionCode;
                    }
                public IHttpActionResult GetByKey([FromUri] DateTime beginDate, string classPeriodName, string classroomIdentificationCode, string type, DateTime gradingPeriodBeginDate, string gradingPeriodDescriptor, string localCourseCode, int schoolId, short schoolYear, int sequenceOfCourse, string studentUniqueId, string termDescriptor, string uniqueSectionCode)
        {
            var request = new Api.Models.Requests.v2.Grades.GradeGetByKey
            {
                BeginDate = beginDate,
                ClassPeriodName = classPeriodName,
                ClassroomIdentificationCode = classroomIdentificationCode,
                Type = type,
                GradingPeriodBeginDate = gradingPeriodBeginDate,
                GradingPeriodDescriptor = gradingPeriodDescriptor,
                LocalCourseCode = localCourseCode,
                SchoolId = schoolId,
                SchoolYear = schoolYear,
                SequenceOfCourse = sequenceOfCourse,
                StudentUniqueId = studentUniqueId,
                TermDescriptor = termDescriptor,
                UniqueSectionCode = uniqueSectionCode,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IGrade request)
        {
            return 
                request.BeginDate != default(DateTime)
                && request.ClassPeriodName != default(string)
                && request.ClassroomIdentificationCode != default(string)
                && request.GradeType != null
                && request.GradingPeriodBeginDate != default(DateTime)
                && request.GradingPeriodDescriptor != null
                && request.LocalCourseCode != default(string)
                && request.SchoolId != default(int)
                && request.SchoolYear != default(short)
                && request.SequenceOfCourse != default(int)
                && request.StudentUniqueId != default(string)
                && request.TermDescriptor != null
                && request.UniqueSectionCode != default(string);
        }

        protected override string GetResourceCollectionName()
        {
            return "grades";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.GradebookEntries
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class GradebookEntriesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.GradebookEntry.GradebookEntry, 
        EdFi.Ods.Api.Models.Resources.V2.GradebookEntry.GradebookEntry, 
        EdFi.Ods.Entities.Common.IGradebookEntry, 
        // EdFi.Ods.Entities.NHibernate.GradebookEntryAggregate.GradebookEntry, 
        Api.Models.Requests.v2.GradebookEntries.GradebookEntryGetByKey, 
        Api.Models.Requests.v2.GradebookEntries.GradebookEntryPut,
        Api.Models.Requests.v2.GradebookEntries.GradebookEntryPost,
        Api.Models.Requests.v2.GradebookEntries.GradebookEntryDelete,
        Api.Models.Requests.v2.GradebookEntries.GradebookEntryGetByExample>
    {
        public GradebookEntriesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.GradebookEntries.GradebookEntryGetByKey request, IGradebookEntry specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.ClassPeriodName = request.ClassPeriodName;
            specification.ClassroomIdentificationCode = request.ClassroomIdentificationCode;
            specification.DateAssigned = request.DateAssigned;
            specification.GradebookEntryTitle = request.Title;
            specification.LocalCourseCode = request.LocalCourseCode;
            specification.SchoolId = request.SchoolId;
            specification.SchoolYear = request.SchoolYear;
            specification.SequenceOfCourse = request.SequenceOfCourse;
            specification.TermDescriptor = request.TermDescriptor;
            specification.UniqueSectionCode = request.UniqueSectionCode;
                    }

        protected override void MapAll(Api.Models.Requests.v2.GradebookEntries.GradebookEntryGetByExample request, IGradebookEntry specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.BeginDate = request.BeginDate;
            specification.ClassPeriodName = request.ClassPeriodName;
            specification.ClassroomIdentificationCode = request.ClassroomIdentificationCode;
            specification.DateAssigned = request.DateAssigned;
            specification.Description = request.Description;
            specification.GradebookEntryTitle = request.Title;
            specification.GradebookEntryType = request.Type;
            specification.GradingPeriodDescriptor = request.GradingPeriodDescriptor;
            specification.Id = request.Id;
            specification.LocalCourseCode = request.LocalCourseCode;
            specification.SchoolId = request.SchoolId;
            specification.SchoolYear = request.SchoolYear;
            specification.SequenceOfCourse = request.SequenceOfCourse;
            specification.TermDescriptor = request.TermDescriptor;
            specification.UniqueSectionCode = request.UniqueSectionCode;
                    }
                public IHttpActionResult GetByKey([FromUri] string classPeriodName, string classroomIdentificationCode, DateTime dateAssigned, string title, string localCourseCode, int schoolId, short schoolYear, int sequenceOfCourse, string termDescriptor, string uniqueSectionCode)
        {
            var request = new Api.Models.Requests.v2.GradebookEntries.GradebookEntryGetByKey
            {
                ClassPeriodName = classPeriodName,
                ClassroomIdentificationCode = classroomIdentificationCode,
                DateAssigned = dateAssigned,
                Title = title,
                LocalCourseCode = localCourseCode,
                SchoolId = schoolId,
                SchoolYear = schoolYear,
                SequenceOfCourse = sequenceOfCourse,
                TermDescriptor = termDescriptor,
                UniqueSectionCode = uniqueSectionCode,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IGradebookEntry request)
        {
            return 
                request.ClassPeriodName != default(string)
                && request.ClassroomIdentificationCode != default(string)
                && request.DateAssigned != default(DateTime)
                && request.GradebookEntryTitle != default(string)
                && request.LocalCourseCode != default(string)
                && request.SchoolId != default(int)
                && request.SchoolYear != default(short)
                && request.SequenceOfCourse != default(int)
                && request.TermDescriptor != null
                && request.UniqueSectionCode != default(string);
        }

        protected override string GetResourceCollectionName()
        {
            return "gradebookEntries";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.GradebookEntryTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class GradebookEntryTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.GradebookEntryType.GradebookEntryType, 
        EdFi.Ods.Api.Models.Resources.V2.GradebookEntryType.GradebookEntryType, 
        EdFi.Ods.Entities.Common.IGradebookEntryType, 
        // EdFi.Ods.Entities.NHibernate.GradebookEntryTypeAggregate.GradebookEntryType, 
        Api.Models.Requests.v2.GradebookEntryTypes.GradebookEntryTypeGetByKey, 
        Api.Models.Requests.v2.GradebookEntryTypes.GradebookEntryTypePut,
        Api.Models.Requests.v2.GradebookEntryTypes.GradebookEntryTypePost,
        Api.Models.Requests.v2.GradebookEntryTypes.GradebookEntryTypeDelete,
        Api.Models.Requests.v2.GradebookEntryTypes.GradebookEntryTypeGetByExample>
    {
        public GradebookEntryTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.GradebookEntryTypes.GradebookEntryTypeGetByKey request, IGradebookEntryType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.GradebookEntryTypeId = request.GradebookEntryTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.GradebookEntryTypes.GradebookEntryTypeGetByExample request, IGradebookEntryType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.GradebookEntryTypeId = request.GradebookEntryTypeId;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int gradebookEntryTypeId)
        {
            var request = new Api.Models.Requests.v2.GradebookEntryTypes.GradebookEntryTypeGetByKey
            {
                GradebookEntryTypeId = gradebookEntryTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IGradebookEntryType request)
        {
            return 
                request.GradebookEntryTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "gradebookEntryTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.GradeLevelDescriptors
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class GradeLevelDescriptorsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.GradeLevelDescriptor.GradeLevelDescriptor, 
        EdFi.Ods.Api.Models.Resources.V2.GradeLevelDescriptor.GradeLevelDescriptor, 
        EdFi.Ods.Entities.Common.IGradeLevelDescriptor, 
        // EdFi.Ods.Entities.NHibernate.GradeLevelDescriptorAggregate.GradeLevelDescriptor, 
        Api.Models.Requests.v2.GradeLevelDescriptors.GradeLevelDescriptorGetByKey, 
        Api.Models.Requests.v2.GradeLevelDescriptors.GradeLevelDescriptorPut,
        Api.Models.Requests.v2.GradeLevelDescriptors.GradeLevelDescriptorPost,
        Api.Models.Requests.v2.GradeLevelDescriptors.GradeLevelDescriptorDelete,
        Api.Models.Requests.v2.GradeLevelDescriptors.GradeLevelDescriptorGetByExample>
    {
        public GradeLevelDescriptorsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.GradeLevelDescriptors.GradeLevelDescriptorGetByKey request, IGradeLevelDescriptor specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.GradeLevelDescriptorId = request.GradeLevelDescriptorId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.GradeLevelDescriptors.GradeLevelDescriptorGetByExample request, IGradeLevelDescriptor specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.GradeLevelDescriptorId = request.GradeLevelDescriptorId;
            specification.GradeLevelType = request.GradeLevelType;
                    }
                public IHttpActionResult GetByKey([FromUri] int gradeLevelDescriptorId)
        {
            var request = new Api.Models.Requests.v2.GradeLevelDescriptors.GradeLevelDescriptorGetByKey
            {
                GradeLevelDescriptorId = gradeLevelDescriptorId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IGradeLevelDescriptor request)
        {
            return 
                request.GradeLevelDescriptorId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "gradeLevelDescriptors";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.GradeLevelTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class GradeLevelTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.GradeLevelType.GradeLevelType, 
        EdFi.Ods.Api.Models.Resources.V2.GradeLevelType.GradeLevelType, 
        EdFi.Ods.Entities.Common.IGradeLevelType, 
        // EdFi.Ods.Entities.NHibernate.GradeLevelTypeAggregate.GradeLevelType, 
        Api.Models.Requests.v2.GradeLevelTypes.GradeLevelTypeGetByKey, 
        Api.Models.Requests.v2.GradeLevelTypes.GradeLevelTypePut,
        Api.Models.Requests.v2.GradeLevelTypes.GradeLevelTypePost,
        Api.Models.Requests.v2.GradeLevelTypes.GradeLevelTypeDelete,
        Api.Models.Requests.v2.GradeLevelTypes.GradeLevelTypeGetByExample>
    {
        public GradeLevelTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.GradeLevelTypes.GradeLevelTypeGetByKey request, IGradeLevelType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.GradeLevelTypeId = request.GradeLevelTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.GradeLevelTypes.GradeLevelTypeGetByExample request, IGradeLevelType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.GradeLevelTypeId = request.GradeLevelTypeId;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int gradeLevelTypeId)
        {
            var request = new Api.Models.Requests.v2.GradeLevelTypes.GradeLevelTypeGetByKey
            {
                GradeLevelTypeId = gradeLevelTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IGradeLevelType request)
        {
            return 
                request.GradeLevelTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "gradeLevelTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.GradeTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class GradeTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.GradeType.GradeType, 
        EdFi.Ods.Api.Models.Resources.V2.GradeType.GradeType, 
        EdFi.Ods.Entities.Common.IGradeType, 
        // EdFi.Ods.Entities.NHibernate.GradeTypeAggregate.GradeType, 
        Api.Models.Requests.v2.GradeTypes.GradeTypeGetByKey, 
        Api.Models.Requests.v2.GradeTypes.GradeTypePut,
        Api.Models.Requests.v2.GradeTypes.GradeTypePost,
        Api.Models.Requests.v2.GradeTypes.GradeTypeDelete,
        Api.Models.Requests.v2.GradeTypes.GradeTypeGetByExample>
    {
        public GradeTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.GradeTypes.GradeTypeGetByKey request, IGradeType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.GradeTypeId = request.GradeTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.GradeTypes.GradeTypeGetByExample request, IGradeType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.GradeTypeId = request.GradeTypeId;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int gradeTypeId)
        {
            var request = new Api.Models.Requests.v2.GradeTypes.GradeTypeGetByKey
            {
                GradeTypeId = gradeTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IGradeType request)
        {
            return 
                request.GradeTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "gradeTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.GradingPeriods
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class GradingPeriodsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.GradingPeriod.GradingPeriod, 
        EdFi.Ods.Api.Models.Resources.V2.GradingPeriod.GradingPeriod, 
        EdFi.Ods.Entities.Common.IGradingPeriod, 
        // EdFi.Ods.Entities.NHibernate.GradingPeriodAggregate.GradingPeriod, 
        Api.Models.Requests.v2.GradingPeriods.GradingPeriodGetByKey, 
        Api.Models.Requests.v2.GradingPeriods.GradingPeriodPut,
        Api.Models.Requests.v2.GradingPeriods.GradingPeriodPost,
        Api.Models.Requests.v2.GradingPeriods.GradingPeriodDelete,
        Api.Models.Requests.v2.GradingPeriods.GradingPeriodGetByExample>
    {
        public GradingPeriodsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.GradingPeriods.GradingPeriodGetByKey request, IGradingPeriod specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.BeginDate = request.BeginDate;
            specification.GradingPeriodDescriptor = request.Descriptor;
            specification.SchoolId = request.SchoolId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.GradingPeriods.GradingPeriodGetByExample request, IGradingPeriod specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.BeginDate = request.BeginDate;
            specification.EndDate = request.EndDate;
            specification.GradingPeriodDescriptor = request.Descriptor;
            specification.Id = request.Id;
            specification.PeriodSequence = request.PeriodSequence;
            specification.SchoolId = request.SchoolId;
            specification.TotalInstructionalDays = request.TotalInstructionalDays;
                    }
                public IHttpActionResult GetByKey([FromUri] DateTime beginDate, string descriptor, int schoolId)
        {
            var request = new Api.Models.Requests.v2.GradingPeriods.GradingPeriodGetByKey
            {
                BeginDate = beginDate,
                Descriptor = descriptor,
                SchoolId = schoolId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IGradingPeriod request)
        {
            return 
                request.BeginDate != default(DateTime)
                && request.GradingPeriodDescriptor != null
                && request.SchoolId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "gradingPeriods";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.GradingPeriodDescriptors
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class GradingPeriodDescriptorsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.GradingPeriodDescriptor.GradingPeriodDescriptor, 
        EdFi.Ods.Api.Models.Resources.V2.GradingPeriodDescriptor.GradingPeriodDescriptor, 
        EdFi.Ods.Entities.Common.IGradingPeriodDescriptor, 
        // EdFi.Ods.Entities.NHibernate.GradingPeriodDescriptorAggregate.GradingPeriodDescriptor, 
        Api.Models.Requests.v2.GradingPeriodDescriptors.GradingPeriodDescriptorGetByKey, 
        Api.Models.Requests.v2.GradingPeriodDescriptors.GradingPeriodDescriptorPut,
        Api.Models.Requests.v2.GradingPeriodDescriptors.GradingPeriodDescriptorPost,
        Api.Models.Requests.v2.GradingPeriodDescriptors.GradingPeriodDescriptorDelete,
        Api.Models.Requests.v2.GradingPeriodDescriptors.GradingPeriodDescriptorGetByExample>
    {
        public GradingPeriodDescriptorsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.GradingPeriodDescriptors.GradingPeriodDescriptorGetByKey request, IGradingPeriodDescriptor specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.GradingPeriodDescriptorId = request.GradingPeriodDescriptorId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.GradingPeriodDescriptors.GradingPeriodDescriptorGetByExample request, IGradingPeriodDescriptor specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.GradingPeriodDescriptorId = request.GradingPeriodDescriptorId;
            specification.GradingPeriodType = request.GradingPeriodType;
                    }
                public IHttpActionResult GetByKey([FromUri] int gradingPeriodDescriptorId)
        {
            var request = new Api.Models.Requests.v2.GradingPeriodDescriptors.GradingPeriodDescriptorGetByKey
            {
                GradingPeriodDescriptorId = gradingPeriodDescriptorId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IGradingPeriodDescriptor request)
        {
            return 
                request.GradingPeriodDescriptorId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "gradingPeriodDescriptors";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.GradingPeriodTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class GradingPeriodTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.GradingPeriodType.GradingPeriodType, 
        EdFi.Ods.Api.Models.Resources.V2.GradingPeriodType.GradingPeriodType, 
        EdFi.Ods.Entities.Common.IGradingPeriodType, 
        // EdFi.Ods.Entities.NHibernate.GradingPeriodTypeAggregate.GradingPeriodType, 
        Api.Models.Requests.v2.GradingPeriodTypes.GradingPeriodTypeGetByKey, 
        Api.Models.Requests.v2.GradingPeriodTypes.GradingPeriodTypePut,
        Api.Models.Requests.v2.GradingPeriodTypes.GradingPeriodTypePost,
        Api.Models.Requests.v2.GradingPeriodTypes.GradingPeriodTypeDelete,
        Api.Models.Requests.v2.GradingPeriodTypes.GradingPeriodTypeGetByExample>
    {
        public GradingPeriodTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.GradingPeriodTypes.GradingPeriodTypeGetByKey request, IGradingPeriodType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.GradingPeriodTypeId = request.GradingPeriodTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.GradingPeriodTypes.GradingPeriodTypeGetByExample request, IGradingPeriodType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.GradingPeriodTypeId = request.GradingPeriodTypeId;
            specification.Id = request.Id;
            specification.PeriodSequence = request.PeriodSequence;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int gradingPeriodTypeId)
        {
            var request = new Api.Models.Requests.v2.GradingPeriodTypes.GradingPeriodTypeGetByKey
            {
                GradingPeriodTypeId = gradingPeriodTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IGradingPeriodType request)
        {
            return 
                request.GradingPeriodTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "gradingPeriodTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.GraduationPlans
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class GraduationPlansController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.GraduationPlan.GraduationPlan, 
        EdFi.Ods.Api.Models.Resources.V2.GraduationPlan.GraduationPlan, 
        EdFi.Ods.Entities.Common.IGraduationPlan, 
        // EdFi.Ods.Entities.NHibernate.GraduationPlanAggregate.GraduationPlan, 
        Api.Models.Requests.v2.GraduationPlans.GraduationPlanGetByKey, 
        Api.Models.Requests.v2.GraduationPlans.GraduationPlanPut,
        Api.Models.Requests.v2.GraduationPlans.GraduationPlanPost,
        Api.Models.Requests.v2.GraduationPlans.GraduationPlanDelete,
        Api.Models.Requests.v2.GraduationPlans.GraduationPlanGetByExample>
    {
        public GraduationPlansController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.GraduationPlans.GraduationPlanGetByKey request, IGraduationPlan specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.GraduationPlanTypeDescriptor = request.TypeDescriptor;
            specification.GraduationSchoolYear = request.GraduationSchoolYear;
                    }

        protected override void MapAll(Api.Models.Requests.v2.GraduationPlans.GraduationPlanGetByExample request, IGraduationPlan specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.GraduationPlanTypeDescriptor = request.TypeDescriptor;
            specification.GraduationSchoolYear = request.GraduationSchoolYear;
            specification.Id = request.Id;
            specification.IndividualPlan = request.IndividualPlan;
            specification.TotalRequiredCreditConversion = request.TotalRequiredCreditConversion;
            specification.TotalRequiredCredits = request.TotalRequiredCredits;
            specification.TotalRequiredCreditType = request.TotalRequiredCreditType;
                    }
                public IHttpActionResult GetByKey([FromUri] int educationOrganizationId, string typeDescriptor, short graduationSchoolYear)
        {
            var request = new Api.Models.Requests.v2.GraduationPlans.GraduationPlanGetByKey
            {
                EducationOrganizationId = educationOrganizationId,
                TypeDescriptor = typeDescriptor,
                GraduationSchoolYear = graduationSchoolYear,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IGraduationPlan request)
        {
            return 
                request.EducationOrganizationId != default(int)
                && request.GraduationPlanTypeDescriptor != null
                && request.GraduationSchoolYear != default(short);
        }

        protected override string GetResourceCollectionName()
        {
            return "graduationPlans";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.GraduationPlanTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class GraduationPlanTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.GraduationPlanType.GraduationPlanType, 
        EdFi.Ods.Api.Models.Resources.V2.GraduationPlanType.GraduationPlanType, 
        EdFi.Ods.Entities.Common.IGraduationPlanType, 
        // EdFi.Ods.Entities.NHibernate.GraduationPlanTypeAggregate.GraduationPlanType, 
        Api.Models.Requests.v2.GraduationPlanTypes.GraduationPlanTypeGetByKey, 
        Api.Models.Requests.v2.GraduationPlanTypes.GraduationPlanTypePut,
        Api.Models.Requests.v2.GraduationPlanTypes.GraduationPlanTypePost,
        Api.Models.Requests.v2.GraduationPlanTypes.GraduationPlanTypeDelete,
        Api.Models.Requests.v2.GraduationPlanTypes.GraduationPlanTypeGetByExample>
    {
        public GraduationPlanTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.GraduationPlanTypes.GraduationPlanTypeGetByKey request, IGraduationPlanType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.GraduationPlanTypeId = request.GraduationPlanTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.GraduationPlanTypes.GraduationPlanTypeGetByExample request, IGraduationPlanType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.GraduationPlanTypeId = request.GraduationPlanTypeId;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int graduationPlanTypeId)
        {
            var request = new Api.Models.Requests.v2.GraduationPlanTypes.GraduationPlanTypeGetByKey
            {
                GraduationPlanTypeId = graduationPlanTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IGraduationPlanType request)
        {
            return 
                request.GraduationPlanTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "graduationPlanTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.GraduationPlanTypeDescriptors
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class GraduationPlanTypeDescriptorsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.GraduationPlanTypeDescriptor.GraduationPlanTypeDescriptor, 
        EdFi.Ods.Api.Models.Resources.V2.GraduationPlanTypeDescriptor.GraduationPlanTypeDescriptor, 
        EdFi.Ods.Entities.Common.IGraduationPlanTypeDescriptor, 
        // EdFi.Ods.Entities.NHibernate.GraduationPlanTypeDescriptorAggregate.GraduationPlanTypeDescriptor, 
        Api.Models.Requests.v2.GraduationPlanTypeDescriptors.GraduationPlanTypeDescriptorGetByKey, 
        Api.Models.Requests.v2.GraduationPlanTypeDescriptors.GraduationPlanTypeDescriptorPut,
        Api.Models.Requests.v2.GraduationPlanTypeDescriptors.GraduationPlanTypeDescriptorPost,
        Api.Models.Requests.v2.GraduationPlanTypeDescriptors.GraduationPlanTypeDescriptorDelete,
        Api.Models.Requests.v2.GraduationPlanTypeDescriptors.GraduationPlanTypeDescriptorGetByExample>
    {
        public GraduationPlanTypeDescriptorsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.GraduationPlanTypeDescriptors.GraduationPlanTypeDescriptorGetByKey request, IGraduationPlanTypeDescriptor specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.GraduationPlanTypeDescriptorId = request.GraduationPlanTypeDescriptorId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.GraduationPlanTypeDescriptors.GraduationPlanTypeDescriptorGetByExample request, IGraduationPlanTypeDescriptor specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.GraduationPlanTypeDescriptorId = request.GraduationPlanTypeDescriptorId;
            specification.GraduationPlanType = request.GraduationPlanType;
                    }
                public IHttpActionResult GetByKey([FromUri] int graduationPlanTypeDescriptorId)
        {
            var request = new Api.Models.Requests.v2.GraduationPlanTypeDescriptors.GraduationPlanTypeDescriptorGetByKey
            {
                GraduationPlanTypeDescriptorId = graduationPlanTypeDescriptorId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IGraduationPlanTypeDescriptor request)
        {
            return 
                request.GraduationPlanTypeDescriptorId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "graduationPlanTypeDescriptors";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.GunFreeSchoolsActReportingStatusTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class GunFreeSchoolsActReportingStatusTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.GunFreeSchoolsActReportingStatusType.GunFreeSchoolsActReportingStatusType, 
        EdFi.Ods.Api.Models.Resources.V2.GunFreeSchoolsActReportingStatusType.GunFreeSchoolsActReportingStatusType, 
        EdFi.Ods.Entities.Common.IGunFreeSchoolsActReportingStatusType, 
        // EdFi.Ods.Entities.NHibernate.GunFreeSchoolsActReportingStatusTypeAggregate.GunFreeSchoolsActReportingStatusType, 
        Api.Models.Requests.v2.GunFreeSchoolsActReportingStatusTypes.GunFreeSchoolsActReportingStatusTypeGetByKey, 
        Api.Models.Requests.v2.GunFreeSchoolsActReportingStatusTypes.GunFreeSchoolsActReportingStatusTypePut,
        Api.Models.Requests.v2.GunFreeSchoolsActReportingStatusTypes.GunFreeSchoolsActReportingStatusTypePost,
        Api.Models.Requests.v2.GunFreeSchoolsActReportingStatusTypes.GunFreeSchoolsActReportingStatusTypeDelete,
        Api.Models.Requests.v2.GunFreeSchoolsActReportingStatusTypes.GunFreeSchoolsActReportingStatusTypeGetByExample>
    {
        public GunFreeSchoolsActReportingStatusTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.GunFreeSchoolsActReportingStatusTypes.GunFreeSchoolsActReportingStatusTypeGetByKey request, IGunFreeSchoolsActReportingStatusType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.GunFreeSchoolsActReportingStatusTypeId = request.GunFreeSchoolsActReportingStatusTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.GunFreeSchoolsActReportingStatusTypes.GunFreeSchoolsActReportingStatusTypeGetByExample request, IGunFreeSchoolsActReportingStatusType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.GunFreeSchoolsActReportingStatusTypeId = request.GunFreeSchoolsActReportingStatusTypeId;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int gunFreeSchoolsActReportingStatusTypeId)
        {
            var request = new Api.Models.Requests.v2.GunFreeSchoolsActReportingStatusTypes.GunFreeSchoolsActReportingStatusTypeGetByKey
            {
                GunFreeSchoolsActReportingStatusTypeId = gunFreeSchoolsActReportingStatusTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IGunFreeSchoolsActReportingStatusType request)
        {
            return 
                request.GunFreeSchoolsActReportingStatusTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "gunFreeSchoolsActReportingStatusTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.IdentificationDocumentUseTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class IdentificationDocumentUseTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.IdentificationDocumentUseType.IdentificationDocumentUseType, 
        EdFi.Ods.Api.Models.Resources.V2.IdentificationDocumentUseType.IdentificationDocumentUseType, 
        EdFi.Ods.Entities.Common.IIdentificationDocumentUseType, 
        // EdFi.Ods.Entities.NHibernate.IdentificationDocumentUseTypeAggregate.IdentificationDocumentUseType, 
        Api.Models.Requests.v2.IdentificationDocumentUseTypes.IdentificationDocumentUseTypeGetByKey, 
        Api.Models.Requests.v2.IdentificationDocumentUseTypes.IdentificationDocumentUseTypePut,
        Api.Models.Requests.v2.IdentificationDocumentUseTypes.IdentificationDocumentUseTypePost,
        Api.Models.Requests.v2.IdentificationDocumentUseTypes.IdentificationDocumentUseTypeDelete,
        Api.Models.Requests.v2.IdentificationDocumentUseTypes.IdentificationDocumentUseTypeGetByExample>
    {
        public IdentificationDocumentUseTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.IdentificationDocumentUseTypes.IdentificationDocumentUseTypeGetByKey request, IIdentificationDocumentUseType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.IdentificationDocumentUseTypeId = request.IdentificationDocumentUseTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.IdentificationDocumentUseTypes.IdentificationDocumentUseTypeGetByExample request, IIdentificationDocumentUseType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.IdentificationDocumentUseTypeId = request.IdentificationDocumentUseTypeId;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int identificationDocumentUseTypeId)
        {
            var request = new Api.Models.Requests.v2.IdentificationDocumentUseTypes.IdentificationDocumentUseTypeGetByKey
            {
                IdentificationDocumentUseTypeId = identificationDocumentUseTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IIdentificationDocumentUseType request)
        {
            return 
                request.IdentificationDocumentUseTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "identificationDocumentUseTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.IncidentLocationTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class IncidentLocationTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.IncidentLocationType.IncidentLocationType, 
        EdFi.Ods.Api.Models.Resources.V2.IncidentLocationType.IncidentLocationType, 
        EdFi.Ods.Entities.Common.IIncidentLocationType, 
        // EdFi.Ods.Entities.NHibernate.IncidentLocationTypeAggregate.IncidentLocationType, 
        Api.Models.Requests.v2.IncidentLocationTypes.IncidentLocationTypeGetByKey, 
        Api.Models.Requests.v2.IncidentLocationTypes.IncidentLocationTypePut,
        Api.Models.Requests.v2.IncidentLocationTypes.IncidentLocationTypePost,
        Api.Models.Requests.v2.IncidentLocationTypes.IncidentLocationTypeDelete,
        Api.Models.Requests.v2.IncidentLocationTypes.IncidentLocationTypeGetByExample>
    {
        public IncidentLocationTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.IncidentLocationTypes.IncidentLocationTypeGetByKey request, IIncidentLocationType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.IncidentLocationTypeId = request.IncidentLocationTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.IncidentLocationTypes.IncidentLocationTypeGetByExample request, IIncidentLocationType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.IncidentLocationTypeId = request.IncidentLocationTypeId;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int incidentLocationTypeId)
        {
            var request = new Api.Models.Requests.v2.IncidentLocationTypes.IncidentLocationTypeGetByKey
            {
                IncidentLocationTypeId = incidentLocationTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IIncidentLocationType request)
        {
            return 
                request.IncidentLocationTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "incidentLocationTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.InstitutionTelephoneNumberTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class InstitutionTelephoneNumberTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.InstitutionTelephoneNumberType.InstitutionTelephoneNumberType, 
        EdFi.Ods.Api.Models.Resources.V2.InstitutionTelephoneNumberType.InstitutionTelephoneNumberType, 
        EdFi.Ods.Entities.Common.IInstitutionTelephoneNumberType, 
        // EdFi.Ods.Entities.NHibernate.InstitutionTelephoneNumberTypeAggregate.InstitutionTelephoneNumberType, 
        Api.Models.Requests.v2.InstitutionTelephoneNumberTypes.InstitutionTelephoneNumberTypeGetByKey, 
        Api.Models.Requests.v2.InstitutionTelephoneNumberTypes.InstitutionTelephoneNumberTypePut,
        Api.Models.Requests.v2.InstitutionTelephoneNumberTypes.InstitutionTelephoneNumberTypePost,
        Api.Models.Requests.v2.InstitutionTelephoneNumberTypes.InstitutionTelephoneNumberTypeDelete,
        Api.Models.Requests.v2.InstitutionTelephoneNumberTypes.InstitutionTelephoneNumberTypeGetByExample>
    {
        public InstitutionTelephoneNumberTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.InstitutionTelephoneNumberTypes.InstitutionTelephoneNumberTypeGetByKey request, IInstitutionTelephoneNumberType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.InstitutionTelephoneNumberTypeId = request.InstitutionTelephoneNumberTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.InstitutionTelephoneNumberTypes.InstitutionTelephoneNumberTypeGetByExample request, IInstitutionTelephoneNumberType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.InstitutionTelephoneNumberTypeId = request.InstitutionTelephoneNumberTypeId;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int institutionTelephoneNumberTypeId)
        {
            var request = new Api.Models.Requests.v2.InstitutionTelephoneNumberTypes.InstitutionTelephoneNumberTypeGetByKey
            {
                InstitutionTelephoneNumberTypeId = institutionTelephoneNumberTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IInstitutionTelephoneNumberType request)
        {
            return 
                request.InstitutionTelephoneNumberTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "institutionTelephoneNumberTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.IntegratedTechnologyStatusTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class IntegratedTechnologyStatusTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.IntegratedTechnologyStatusType.IntegratedTechnologyStatusType, 
        EdFi.Ods.Api.Models.Resources.V2.IntegratedTechnologyStatusType.IntegratedTechnologyStatusType, 
        EdFi.Ods.Entities.Common.IIntegratedTechnologyStatusType, 
        // EdFi.Ods.Entities.NHibernate.IntegratedTechnologyStatusTypeAggregate.IntegratedTechnologyStatusType, 
        Api.Models.Requests.v2.IntegratedTechnologyStatusTypes.IntegratedTechnologyStatusTypeGetByKey, 
        Api.Models.Requests.v2.IntegratedTechnologyStatusTypes.IntegratedTechnologyStatusTypePut,
        Api.Models.Requests.v2.IntegratedTechnologyStatusTypes.IntegratedTechnologyStatusTypePost,
        Api.Models.Requests.v2.IntegratedTechnologyStatusTypes.IntegratedTechnologyStatusTypeDelete,
        Api.Models.Requests.v2.IntegratedTechnologyStatusTypes.IntegratedTechnologyStatusTypeGetByExample>
    {
        public IntegratedTechnologyStatusTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.IntegratedTechnologyStatusTypes.IntegratedTechnologyStatusTypeGetByKey request, IIntegratedTechnologyStatusType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.IntegratedTechnologyStatusTypeId = request.IntegratedTechnologyStatusTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.IntegratedTechnologyStatusTypes.IntegratedTechnologyStatusTypeGetByExample request, IIntegratedTechnologyStatusType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.IntegratedTechnologyStatusTypeId = request.IntegratedTechnologyStatusTypeId;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int integratedTechnologyStatusTypeId)
        {
            var request = new Api.Models.Requests.v2.IntegratedTechnologyStatusTypes.IntegratedTechnologyStatusTypeGetByKey
            {
                IntegratedTechnologyStatusTypeId = integratedTechnologyStatusTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IIntegratedTechnologyStatusType request)
        {
            return 
                request.IntegratedTechnologyStatusTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "integratedTechnologyStatusTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.InteractivityStyleTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class InteractivityStyleTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.InteractivityStyleType.InteractivityStyleType, 
        EdFi.Ods.Api.Models.Resources.V2.InteractivityStyleType.InteractivityStyleType, 
        EdFi.Ods.Entities.Common.IInteractivityStyleType, 
        // EdFi.Ods.Entities.NHibernate.InteractivityStyleTypeAggregate.InteractivityStyleType, 
        Api.Models.Requests.v2.InteractivityStyleTypes.InteractivityStyleTypeGetByKey, 
        Api.Models.Requests.v2.InteractivityStyleTypes.InteractivityStyleTypePut,
        Api.Models.Requests.v2.InteractivityStyleTypes.InteractivityStyleTypePost,
        Api.Models.Requests.v2.InteractivityStyleTypes.InteractivityStyleTypeDelete,
        Api.Models.Requests.v2.InteractivityStyleTypes.InteractivityStyleTypeGetByExample>
    {
        public InteractivityStyleTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.InteractivityStyleTypes.InteractivityStyleTypeGetByKey request, IInteractivityStyleType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.InteractivityStyleTypeId = request.InteractivityStyleTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.InteractivityStyleTypes.InteractivityStyleTypeGetByExample request, IInteractivityStyleType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.InteractivityStyleTypeId = request.InteractivityStyleTypeId;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int interactivityStyleTypeId)
        {
            var request = new Api.Models.Requests.v2.InteractivityStyleTypes.InteractivityStyleTypeGetByKey
            {
                InteractivityStyleTypeId = interactivityStyleTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IInteractivityStyleType request)
        {
            return 
                request.InteractivityStyleTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "interactivityStyleTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.InternetAccessTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class InternetAccessTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.InternetAccessType.InternetAccessType, 
        EdFi.Ods.Api.Models.Resources.V2.InternetAccessType.InternetAccessType, 
        EdFi.Ods.Entities.Common.IInternetAccessType, 
        // EdFi.Ods.Entities.NHibernate.InternetAccessTypeAggregate.InternetAccessType, 
        Api.Models.Requests.v2.InternetAccessTypes.InternetAccessTypeGetByKey, 
        Api.Models.Requests.v2.InternetAccessTypes.InternetAccessTypePut,
        Api.Models.Requests.v2.InternetAccessTypes.InternetAccessTypePost,
        Api.Models.Requests.v2.InternetAccessTypes.InternetAccessTypeDelete,
        Api.Models.Requests.v2.InternetAccessTypes.InternetAccessTypeGetByExample>
    {
        public InternetAccessTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.InternetAccessTypes.InternetAccessTypeGetByKey request, IInternetAccessType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.InternetAccessTypeId = request.InternetAccessTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.InternetAccessTypes.InternetAccessTypeGetByExample request, IInternetAccessType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.InternetAccessTypeId = request.InternetAccessTypeId;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int internetAccessTypeId)
        {
            var request = new Api.Models.Requests.v2.InternetAccessTypes.InternetAccessTypeGetByKey
            {
                InternetAccessTypeId = internetAccessTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IInternetAccessType request)
        {
            return 
                request.InternetAccessTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "internetAccessTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.Interventions
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class InterventionsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.Intervention.Intervention, 
        EdFi.Ods.Api.Models.Resources.V2.Intervention.Intervention, 
        EdFi.Ods.Entities.Common.IIntervention, 
        // EdFi.Ods.Entities.NHibernate.InterventionAggregate.Intervention, 
        Api.Models.Requests.v2.Interventions.InterventionGetByKey, 
        Api.Models.Requests.v2.Interventions.InterventionPut,
        Api.Models.Requests.v2.Interventions.InterventionPost,
        Api.Models.Requests.v2.Interventions.InterventionDelete,
        Api.Models.Requests.v2.Interventions.InterventionGetByExample>
    {
        public InterventionsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.Interventions.InterventionGetByKey request, IIntervention specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.InterventionIdentificationCode = request.IdentificationCode;
                    }

        protected override void MapAll(Api.Models.Requests.v2.Interventions.InterventionGetByExample request, IIntervention specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.BeginDate = request.BeginDate;
            specification.DeliveryMethodType = request.DeliveryMethodType;
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.EndDate = request.EndDate;
            specification.Id = request.Id;
            specification.InterventionClassType = request.ClassType;
            specification.InterventionIdentificationCode = request.IdentificationCode;
                    }
                public IHttpActionResult GetByKey([FromUri] int educationOrganizationId, string identificationCode)
        {
            var request = new Api.Models.Requests.v2.Interventions.InterventionGetByKey
            {
                EducationOrganizationId = educationOrganizationId,
                IdentificationCode = identificationCode,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IIntervention request)
        {
            return 
                request.EducationOrganizationId != default(int)
                && request.InterventionIdentificationCode != default(string);
        }

        protected override string GetResourceCollectionName()
        {
            return "interventions";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.InterventionClassTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class InterventionClassTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.InterventionClassType.InterventionClassType, 
        EdFi.Ods.Api.Models.Resources.V2.InterventionClassType.InterventionClassType, 
        EdFi.Ods.Entities.Common.IInterventionClassType, 
        // EdFi.Ods.Entities.NHibernate.InterventionClassTypeAggregate.InterventionClassType, 
        Api.Models.Requests.v2.InterventionClassTypes.InterventionClassTypeGetByKey, 
        Api.Models.Requests.v2.InterventionClassTypes.InterventionClassTypePut,
        Api.Models.Requests.v2.InterventionClassTypes.InterventionClassTypePost,
        Api.Models.Requests.v2.InterventionClassTypes.InterventionClassTypeDelete,
        Api.Models.Requests.v2.InterventionClassTypes.InterventionClassTypeGetByExample>
    {
        public InterventionClassTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.InterventionClassTypes.InterventionClassTypeGetByKey request, IInterventionClassType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.InterventionClassTypeId = request.InterventionClassTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.InterventionClassTypes.InterventionClassTypeGetByExample request, IInterventionClassType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.InterventionClassTypeId = request.InterventionClassTypeId;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int interventionClassTypeId)
        {
            var request = new Api.Models.Requests.v2.InterventionClassTypes.InterventionClassTypeGetByKey
            {
                InterventionClassTypeId = interventionClassTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IInterventionClassType request)
        {
            return 
                request.InterventionClassTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "interventionClassTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.InterventionEffectivenessRatingTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class InterventionEffectivenessRatingTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.InterventionEffectivenessRatingType.InterventionEffectivenessRatingType, 
        EdFi.Ods.Api.Models.Resources.V2.InterventionEffectivenessRatingType.InterventionEffectivenessRatingType, 
        EdFi.Ods.Entities.Common.IInterventionEffectivenessRatingType, 
        // EdFi.Ods.Entities.NHibernate.InterventionEffectivenessRatingTypeAggregate.InterventionEffectivenessRatingType, 
        Api.Models.Requests.v2.InterventionEffectivenessRatingTypes.InterventionEffectivenessRatingTypeGetByKey, 
        Api.Models.Requests.v2.InterventionEffectivenessRatingTypes.InterventionEffectivenessRatingTypePut,
        Api.Models.Requests.v2.InterventionEffectivenessRatingTypes.InterventionEffectivenessRatingTypePost,
        Api.Models.Requests.v2.InterventionEffectivenessRatingTypes.InterventionEffectivenessRatingTypeDelete,
        Api.Models.Requests.v2.InterventionEffectivenessRatingTypes.InterventionEffectivenessRatingTypeGetByExample>
    {
        public InterventionEffectivenessRatingTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.InterventionEffectivenessRatingTypes.InterventionEffectivenessRatingTypeGetByKey request, IInterventionEffectivenessRatingType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.InterventionEffectivenessRatingTypeId = request.InterventionEffectivenessRatingTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.InterventionEffectivenessRatingTypes.InterventionEffectivenessRatingTypeGetByExample request, IInterventionEffectivenessRatingType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.InterventionEffectivenessRatingTypeId = request.InterventionEffectivenessRatingTypeId;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int interventionEffectivenessRatingTypeId)
        {
            var request = new Api.Models.Requests.v2.InterventionEffectivenessRatingTypes.InterventionEffectivenessRatingTypeGetByKey
            {
                InterventionEffectivenessRatingTypeId = interventionEffectivenessRatingTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IInterventionEffectivenessRatingType request)
        {
            return 
                request.InterventionEffectivenessRatingTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "interventionEffectivenessRatingTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.InterventionPrescriptions
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class InterventionPrescriptionsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.InterventionPrescription.InterventionPrescription, 
        EdFi.Ods.Api.Models.Resources.V2.InterventionPrescription.InterventionPrescription, 
        EdFi.Ods.Entities.Common.IInterventionPrescription, 
        // EdFi.Ods.Entities.NHibernate.InterventionPrescriptionAggregate.InterventionPrescription, 
        Api.Models.Requests.v2.InterventionPrescriptions.InterventionPrescriptionGetByKey, 
        Api.Models.Requests.v2.InterventionPrescriptions.InterventionPrescriptionPut,
        Api.Models.Requests.v2.InterventionPrescriptions.InterventionPrescriptionPost,
        Api.Models.Requests.v2.InterventionPrescriptions.InterventionPrescriptionDelete,
        Api.Models.Requests.v2.InterventionPrescriptions.InterventionPrescriptionGetByExample>
    {
        public InterventionPrescriptionsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.InterventionPrescriptions.InterventionPrescriptionGetByKey request, IInterventionPrescription specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.InterventionPrescriptionIdentificationCode = request.IdentificationCode;
                    }

        protected override void MapAll(Api.Models.Requests.v2.InterventionPrescriptions.InterventionPrescriptionGetByExample request, IInterventionPrescription specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.DeliveryMethodType = request.DeliveryMethodType;
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.Id = request.Id;
            specification.InterventionClassType = request.InterventionClassType;
            specification.InterventionPrescriptionIdentificationCode = request.IdentificationCode;
                    }
                public IHttpActionResult GetByKey([FromUri] int educationOrganizationId, string identificationCode)
        {
            var request = new Api.Models.Requests.v2.InterventionPrescriptions.InterventionPrescriptionGetByKey
            {
                EducationOrganizationId = educationOrganizationId,
                IdentificationCode = identificationCode,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IInterventionPrescription request)
        {
            return 
                request.EducationOrganizationId != default(int)
                && request.InterventionPrescriptionIdentificationCode != default(string);
        }

        protected override string GetResourceCollectionName()
        {
            return "interventionPrescriptions";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.InterventionStudies
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class InterventionStudiesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.InterventionStudy.InterventionStudy, 
        EdFi.Ods.Api.Models.Resources.V2.InterventionStudy.InterventionStudy, 
        EdFi.Ods.Entities.Common.IInterventionStudy, 
        // EdFi.Ods.Entities.NHibernate.InterventionStudyAggregate.InterventionStudy, 
        Api.Models.Requests.v2.InterventionStudies.InterventionStudyGetByKey, 
        Api.Models.Requests.v2.InterventionStudies.InterventionStudyPut,
        Api.Models.Requests.v2.InterventionStudies.InterventionStudyPost,
        Api.Models.Requests.v2.InterventionStudies.InterventionStudyDelete,
        Api.Models.Requests.v2.InterventionStudies.InterventionStudyGetByExample>
    {
        public InterventionStudiesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.InterventionStudies.InterventionStudyGetByKey request, IInterventionStudy specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.InterventionStudyIdentificationCode = request.IdentificationCode;
                    }

        protected override void MapAll(Api.Models.Requests.v2.InterventionStudies.InterventionStudyGetByExample request, IInterventionStudy specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.DeliveryMethodType = request.DeliveryMethodType;
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.Id = request.Id;
            specification.InterventionClassType = request.InterventionClassType;
            specification.InterventionPrescriptionEducationOrganizationId = request.InterventionPrescriptionEducationOrganizationId;
            specification.InterventionPrescriptionIdentificationCode = request.InterventionPrescriptionIdentificationCode;
            specification.InterventionStudyIdentificationCode = request.IdentificationCode;
            specification.Participants = request.Participants;
                    }
                public IHttpActionResult GetByKey([FromUri] int educationOrganizationId, string identificationCode)
        {
            var request = new Api.Models.Requests.v2.InterventionStudies.InterventionStudyGetByKey
            {
                EducationOrganizationId = educationOrganizationId,
                IdentificationCode = identificationCode,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IInterventionStudy request)
        {
            return 
                request.EducationOrganizationId != default(int)
                && request.InterventionStudyIdentificationCode != default(string);
        }

        protected override string GetResourceCollectionName()
        {
            return "interventionStudies";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.LanguageDescriptors
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class LanguageDescriptorsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.LanguageDescriptor.LanguageDescriptor, 
        EdFi.Ods.Api.Models.Resources.V2.LanguageDescriptor.LanguageDescriptor, 
        EdFi.Ods.Entities.Common.ILanguageDescriptor, 
        // EdFi.Ods.Entities.NHibernate.LanguageDescriptorAggregate.LanguageDescriptor, 
        Api.Models.Requests.v2.LanguageDescriptors.LanguageDescriptorGetByKey, 
        Api.Models.Requests.v2.LanguageDescriptors.LanguageDescriptorPut,
        Api.Models.Requests.v2.LanguageDescriptors.LanguageDescriptorPost,
        Api.Models.Requests.v2.LanguageDescriptors.LanguageDescriptorDelete,
        Api.Models.Requests.v2.LanguageDescriptors.LanguageDescriptorGetByExample>
    {
        public LanguageDescriptorsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.LanguageDescriptors.LanguageDescriptorGetByKey request, ILanguageDescriptor specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.LanguageDescriptorId = request.LanguageDescriptorId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.LanguageDescriptors.LanguageDescriptorGetByExample request, ILanguageDescriptor specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.LanguageDescriptorId = request.LanguageDescriptorId;
            specification.LanguageType = request.LanguageType;
                    }
                public IHttpActionResult GetByKey([FromUri] int languageDescriptorId)
        {
            var request = new Api.Models.Requests.v2.LanguageDescriptors.LanguageDescriptorGetByKey
            {
                LanguageDescriptorId = languageDescriptorId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(ILanguageDescriptor request)
        {
            return 
                request.LanguageDescriptorId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "languageDescriptors";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.LanguageTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class LanguageTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.LanguageType.LanguageType, 
        EdFi.Ods.Api.Models.Resources.V2.LanguageType.LanguageType, 
        EdFi.Ods.Entities.Common.ILanguageType, 
        // EdFi.Ods.Entities.NHibernate.LanguageTypeAggregate.LanguageType, 
        Api.Models.Requests.v2.LanguageTypes.LanguageTypeGetByKey, 
        Api.Models.Requests.v2.LanguageTypes.LanguageTypePut,
        Api.Models.Requests.v2.LanguageTypes.LanguageTypePost,
        Api.Models.Requests.v2.LanguageTypes.LanguageTypeDelete,
        Api.Models.Requests.v2.LanguageTypes.LanguageTypeGetByExample>
    {
        public LanguageTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.LanguageTypes.LanguageTypeGetByKey request, ILanguageType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.LanguageTypeId = request.LanguageTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.LanguageTypes.LanguageTypeGetByExample request, ILanguageType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.LanguageTypeId = request.LanguageTypeId;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int languageTypeId)
        {
            var request = new Api.Models.Requests.v2.LanguageTypes.LanguageTypeGetByKey
            {
                LanguageTypeId = languageTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(ILanguageType request)
        {
            return 
                request.LanguageTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "languageTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.LanguageUseTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class LanguageUseTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.LanguageUseType.LanguageUseType, 
        EdFi.Ods.Api.Models.Resources.V2.LanguageUseType.LanguageUseType, 
        EdFi.Ods.Entities.Common.ILanguageUseType, 
        // EdFi.Ods.Entities.NHibernate.LanguageUseTypeAggregate.LanguageUseType, 
        Api.Models.Requests.v2.LanguageUseTypes.LanguageUseTypeGetByKey, 
        Api.Models.Requests.v2.LanguageUseTypes.LanguageUseTypePut,
        Api.Models.Requests.v2.LanguageUseTypes.LanguageUseTypePost,
        Api.Models.Requests.v2.LanguageUseTypes.LanguageUseTypeDelete,
        Api.Models.Requests.v2.LanguageUseTypes.LanguageUseTypeGetByExample>
    {
        public LanguageUseTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.LanguageUseTypes.LanguageUseTypeGetByKey request, ILanguageUseType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.LanguageUseTypeId = request.LanguageUseTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.LanguageUseTypes.LanguageUseTypeGetByExample request, ILanguageUseType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.LanguageUseTypeId = request.LanguageUseTypeId;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int languageUseTypeId)
        {
            var request = new Api.Models.Requests.v2.LanguageUseTypes.LanguageUseTypeGetByKey
            {
                LanguageUseTypeId = languageUseTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(ILanguageUseType request)
        {
            return 
                request.LanguageUseTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "languageUseTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.LearningObjectives
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class LearningObjectivesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.LearningObjective.LearningObjective, 
        EdFi.Ods.Api.Models.Resources.V2.LearningObjective.LearningObjective, 
        EdFi.Ods.Entities.Common.ILearningObjective, 
        // EdFi.Ods.Entities.NHibernate.LearningObjectiveAggregate.LearningObjective, 
        Api.Models.Requests.v2.LearningObjectives.LearningObjectiveGetByKey, 
        Api.Models.Requests.v2.LearningObjectives.LearningObjectivePut,
        Api.Models.Requests.v2.LearningObjectives.LearningObjectivePost,
        Api.Models.Requests.v2.LearningObjectives.LearningObjectiveDelete,
        Api.Models.Requests.v2.LearningObjectives.LearningObjectiveGetByExample>
    {
        public LearningObjectivesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.LearningObjectives.LearningObjectiveGetByKey request, ILearningObjective specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.LearningObjectiveId = request.LearningObjectiveId;
            specification.Namespace = request.Namespace;
                    }

        protected override void MapAll(Api.Models.Requests.v2.LearningObjectives.LearningObjectiveGetByExample request, ILearningObjective specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.LearningObjectiveId = request.LearningObjectiveId;
            specification.Namespace = request.Namespace;
            specification.Nomenclature = request.Nomenclature;
            specification.Objective = request.Objective;
            specification.ParentLearningObjectiveId = request.ParentLearningObjectiveId;
            specification.ParentNamespace = request.ParentNamespace;
            specification.SuccessCriteria = request.SuccessCriteria;
                    }
                public IHttpActionResult GetByKey([FromUri] string learningObjectiveId, string @namespace)
        {
            var request = new Api.Models.Requests.v2.LearningObjectives.LearningObjectiveGetByKey
            {
                LearningObjectiveId = learningObjectiveId,
                Namespace = @namespace,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(ILearningObjective request)
        {
            return 
                request.LearningObjectiveId != default(string)
                && request.Namespace != default(string);
        }

        protected override string GetResourceCollectionName()
        {
            return "learningObjectives";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.LearningStandards
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class LearningStandardsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.LearningStandard.LearningStandard, 
        EdFi.Ods.Api.Models.Resources.V2.LearningStandard.LearningStandard, 
        EdFi.Ods.Entities.Common.ILearningStandard, 
        // EdFi.Ods.Entities.NHibernate.LearningStandardAggregate.LearningStandard, 
        Api.Models.Requests.v2.LearningStandards.LearningStandardGetByKey, 
        Api.Models.Requests.v2.LearningStandards.LearningStandardPut,
        Api.Models.Requests.v2.LearningStandards.LearningStandardPost,
        Api.Models.Requests.v2.LearningStandards.LearningStandardDelete,
        Api.Models.Requests.v2.LearningStandards.LearningStandardGetByExample>
    {
        public LearningStandardsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.LearningStandards.LearningStandardGetByKey request, ILearningStandard specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.LearningStandardId = request.LearningStandardId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.LearningStandards.LearningStandardGetByExample request, ILearningStandard specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.AcademicSubjectDescriptor = request.AcademicSubjectDescriptor;
            specification.CourseTitle = request.CourseTitle;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.LearningStandardId = request.LearningStandardId;
            specification.LearningStandardItemCode = request.ItemCode;
            specification.Namespace = request.Namespace;
            specification.ParentLearningStandardId = request.ParentLearningStandardId;
            specification.SuccessCriteria = request.SuccessCriteria;
            specification.URI = request.URI;
                    }
                public IHttpActionResult GetByKey([FromUri] string learningStandardId)
        {
            var request = new Api.Models.Requests.v2.LearningStandards.LearningStandardGetByKey
            {
                LearningStandardId = learningStandardId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(ILearningStandard request)
        {
            return 
                request.LearningStandardId != default(string);
        }

        protected override string GetResourceCollectionName()
        {
            return "learningStandards";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.LeaveEvents
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class LeaveEventsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.LeaveEvent.LeaveEvent, 
        EdFi.Ods.Api.Models.Resources.V2.LeaveEvent.LeaveEvent, 
        EdFi.Ods.Entities.Common.ILeaveEvent, 
        // EdFi.Ods.Entities.NHibernate.LeaveEventAggregate.LeaveEvent, 
        Api.Models.Requests.v2.LeaveEvents.LeaveEventGetByKey, 
        Api.Models.Requests.v2.LeaveEvents.LeaveEventPut,
        Api.Models.Requests.v2.LeaveEvents.LeaveEventPost,
        Api.Models.Requests.v2.LeaveEvents.LeaveEventDelete,
        Api.Models.Requests.v2.LeaveEvents.LeaveEventGetByExample>
    {
        public LeaveEventsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.LeaveEvents.LeaveEventGetByKey request, ILeaveEvent specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.EventDate = request.EventDate;
            specification.LeaveEventCategoryType = request.CategoryType;
            specification.StaffUniqueId = request.StaffUniqueId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.LeaveEvents.LeaveEventGetByExample request, ILeaveEvent specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.EventDate = request.EventDate;
            specification.HoursOnLeave = request.HoursOnLeave;
            specification.Id = request.Id;
            specification.LeaveEventCategoryType = request.CategoryType;
            specification.LeaveEventReason = request.Reason;
            specification.StaffUniqueId = request.StaffUniqueId;
            specification.SubstituteAssigned = request.SubstituteAssigned;
                    }
                public IHttpActionResult GetByKey([FromUri] DateTime eventDate, string categoryType, string staffUniqueId)
        {
            var request = new Api.Models.Requests.v2.LeaveEvents.LeaveEventGetByKey
            {
                EventDate = eventDate,
                CategoryType = categoryType,
                StaffUniqueId = staffUniqueId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(ILeaveEvent request)
        {
            return 
                request.EventDate != default(DateTime)
                && request.LeaveEventCategoryType != null
                && request.StaffUniqueId != default(string);
        }

        protected override string GetResourceCollectionName()
        {
            return "leaveEvents";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.LeaveEventCategoryTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class LeaveEventCategoryTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.LeaveEventCategoryType.LeaveEventCategoryType, 
        EdFi.Ods.Api.Models.Resources.V2.LeaveEventCategoryType.LeaveEventCategoryType, 
        EdFi.Ods.Entities.Common.ILeaveEventCategoryType, 
        // EdFi.Ods.Entities.NHibernate.LeaveEventCategoryTypeAggregate.LeaveEventCategoryType, 
        Api.Models.Requests.v2.LeaveEventCategoryTypes.LeaveEventCategoryTypeGetByKey, 
        Api.Models.Requests.v2.LeaveEventCategoryTypes.LeaveEventCategoryTypePut,
        Api.Models.Requests.v2.LeaveEventCategoryTypes.LeaveEventCategoryTypePost,
        Api.Models.Requests.v2.LeaveEventCategoryTypes.LeaveEventCategoryTypeDelete,
        Api.Models.Requests.v2.LeaveEventCategoryTypes.LeaveEventCategoryTypeGetByExample>
    {
        public LeaveEventCategoryTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.LeaveEventCategoryTypes.LeaveEventCategoryTypeGetByKey request, ILeaveEventCategoryType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.LeaveEventCategoryTypeId = request.LeaveEventCategoryTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.LeaveEventCategoryTypes.LeaveEventCategoryTypeGetByExample request, ILeaveEventCategoryType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.LeaveEventCategoryTypeId = request.LeaveEventCategoryTypeId;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int leaveEventCategoryTypeId)
        {
            var request = new Api.Models.Requests.v2.LeaveEventCategoryTypes.LeaveEventCategoryTypeGetByKey
            {
                LeaveEventCategoryTypeId = leaveEventCategoryTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(ILeaveEventCategoryType request)
        {
            return 
                request.LeaveEventCategoryTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "leaveEventCategoryTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.LevelDescriptors
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class LevelDescriptorsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.LevelDescriptor.LevelDescriptor, 
        EdFi.Ods.Api.Models.Resources.V2.LevelDescriptor.LevelDescriptor, 
        EdFi.Ods.Entities.Common.ILevelDescriptor, 
        // EdFi.Ods.Entities.NHibernate.LevelDescriptorAggregate.LevelDescriptor, 
        Api.Models.Requests.v2.LevelDescriptors.LevelDescriptorGetByKey, 
        Api.Models.Requests.v2.LevelDescriptors.LevelDescriptorPut,
        Api.Models.Requests.v2.LevelDescriptors.LevelDescriptorPost,
        Api.Models.Requests.v2.LevelDescriptors.LevelDescriptorDelete,
        Api.Models.Requests.v2.LevelDescriptors.LevelDescriptorGetByExample>
    {
        public LevelDescriptorsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.LevelDescriptors.LevelDescriptorGetByKey request, ILevelDescriptor specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.LevelDescriptorId = request.LevelDescriptorId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.LevelDescriptors.LevelDescriptorGetByExample request, ILevelDescriptor specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.LevelDescriptorId = request.LevelDescriptorId;
                    }
                public IHttpActionResult GetByKey([FromUri] int levelDescriptorId)
        {
            var request = new Api.Models.Requests.v2.LevelDescriptors.LevelDescriptorGetByKey
            {
                LevelDescriptorId = levelDescriptorId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(ILevelDescriptor request)
        {
            return 
                request.LevelDescriptorId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "levelDescriptors";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.LevelOfEducationDescriptors
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class LevelOfEducationDescriptorsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.LevelOfEducationDescriptor.LevelOfEducationDescriptor, 
        EdFi.Ods.Api.Models.Resources.V2.LevelOfEducationDescriptor.LevelOfEducationDescriptor, 
        EdFi.Ods.Entities.Common.ILevelOfEducationDescriptor, 
        // EdFi.Ods.Entities.NHibernate.LevelOfEducationDescriptorAggregate.LevelOfEducationDescriptor, 
        Api.Models.Requests.v2.LevelOfEducationDescriptors.LevelOfEducationDescriptorGetByKey, 
        Api.Models.Requests.v2.LevelOfEducationDescriptors.LevelOfEducationDescriptorPut,
        Api.Models.Requests.v2.LevelOfEducationDescriptors.LevelOfEducationDescriptorPost,
        Api.Models.Requests.v2.LevelOfEducationDescriptors.LevelOfEducationDescriptorDelete,
        Api.Models.Requests.v2.LevelOfEducationDescriptors.LevelOfEducationDescriptorGetByExample>
    {
        public LevelOfEducationDescriptorsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.LevelOfEducationDescriptors.LevelOfEducationDescriptorGetByKey request, ILevelOfEducationDescriptor specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.LevelOfEducationDescriptorId = request.LevelOfEducationDescriptorId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.LevelOfEducationDescriptors.LevelOfEducationDescriptorGetByExample request, ILevelOfEducationDescriptor specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.LevelOfEducationDescriptorId = request.LevelOfEducationDescriptorId;
            specification.LevelOfEducationType = request.LevelOfEducationType;
                    }
                public IHttpActionResult GetByKey([FromUri] int levelOfEducationDescriptorId)
        {
            var request = new Api.Models.Requests.v2.LevelOfEducationDescriptors.LevelOfEducationDescriptorGetByKey
            {
                LevelOfEducationDescriptorId = levelOfEducationDescriptorId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(ILevelOfEducationDescriptor request)
        {
            return 
                request.LevelOfEducationDescriptorId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "levelOfEducationDescriptors";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.LevelOfEducationTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class LevelOfEducationTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.LevelOfEducationType.LevelOfEducationType, 
        EdFi.Ods.Api.Models.Resources.V2.LevelOfEducationType.LevelOfEducationType, 
        EdFi.Ods.Entities.Common.ILevelOfEducationType, 
        // EdFi.Ods.Entities.NHibernate.LevelOfEducationTypeAggregate.LevelOfEducationType, 
        Api.Models.Requests.v2.LevelOfEducationTypes.LevelOfEducationTypeGetByKey, 
        Api.Models.Requests.v2.LevelOfEducationTypes.LevelOfEducationTypePut,
        Api.Models.Requests.v2.LevelOfEducationTypes.LevelOfEducationTypePost,
        Api.Models.Requests.v2.LevelOfEducationTypes.LevelOfEducationTypeDelete,
        Api.Models.Requests.v2.LevelOfEducationTypes.LevelOfEducationTypeGetByExample>
    {
        public LevelOfEducationTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.LevelOfEducationTypes.LevelOfEducationTypeGetByKey request, ILevelOfEducationType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.LevelOfEducationTypeId = request.LevelOfEducationTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.LevelOfEducationTypes.LevelOfEducationTypeGetByExample request, ILevelOfEducationType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.LevelOfEducationTypeId = request.LevelOfEducationTypeId;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int levelOfEducationTypeId)
        {
            var request = new Api.Models.Requests.v2.LevelOfEducationTypes.LevelOfEducationTypeGetByKey
            {
                LevelOfEducationTypeId = levelOfEducationTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(ILevelOfEducationType request)
        {
            return 
                request.LevelOfEducationTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "levelOfEducationTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.LimitedEnglishProficiencyDescriptors
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class LimitedEnglishProficiencyDescriptorsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.LimitedEnglishProficiencyDescriptor.LimitedEnglishProficiencyDescriptor, 
        EdFi.Ods.Api.Models.Resources.V2.LimitedEnglishProficiencyDescriptor.LimitedEnglishProficiencyDescriptor, 
        EdFi.Ods.Entities.Common.ILimitedEnglishProficiencyDescriptor, 
        // EdFi.Ods.Entities.NHibernate.LimitedEnglishProficiencyDescriptorAggregate.LimitedEnglishProficiencyDescriptor, 
        Api.Models.Requests.v2.LimitedEnglishProficiencyDescriptors.LimitedEnglishProficiencyDescriptorGetByKey, 
        Api.Models.Requests.v2.LimitedEnglishProficiencyDescriptors.LimitedEnglishProficiencyDescriptorPut,
        Api.Models.Requests.v2.LimitedEnglishProficiencyDescriptors.LimitedEnglishProficiencyDescriptorPost,
        Api.Models.Requests.v2.LimitedEnglishProficiencyDescriptors.LimitedEnglishProficiencyDescriptorDelete,
        Api.Models.Requests.v2.LimitedEnglishProficiencyDescriptors.LimitedEnglishProficiencyDescriptorGetByExample>
    {
        public LimitedEnglishProficiencyDescriptorsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.LimitedEnglishProficiencyDescriptors.LimitedEnglishProficiencyDescriptorGetByKey request, ILimitedEnglishProficiencyDescriptor specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.LimitedEnglishProficiencyDescriptorId = request.LimitedEnglishProficiencyDescriptorId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.LimitedEnglishProficiencyDescriptors.LimitedEnglishProficiencyDescriptorGetByExample request, ILimitedEnglishProficiencyDescriptor specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.LimitedEnglishProficiencyDescriptorId = request.LimitedEnglishProficiencyDescriptorId;
            specification.LimitedEnglishProficiencyType = request.LimitedEnglishProficiencyType;
                    }
                public IHttpActionResult GetByKey([FromUri] int limitedEnglishProficiencyDescriptorId)
        {
            var request = new Api.Models.Requests.v2.LimitedEnglishProficiencyDescriptors.LimitedEnglishProficiencyDescriptorGetByKey
            {
                LimitedEnglishProficiencyDescriptorId = limitedEnglishProficiencyDescriptorId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(ILimitedEnglishProficiencyDescriptor request)
        {
            return 
                request.LimitedEnglishProficiencyDescriptorId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "limitedEnglishProficiencyDescriptors";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.LimitedEnglishProficiencyTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class LimitedEnglishProficiencyTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.LimitedEnglishProficiencyType.LimitedEnglishProficiencyType, 
        EdFi.Ods.Api.Models.Resources.V2.LimitedEnglishProficiencyType.LimitedEnglishProficiencyType, 
        EdFi.Ods.Entities.Common.ILimitedEnglishProficiencyType, 
        // EdFi.Ods.Entities.NHibernate.LimitedEnglishProficiencyTypeAggregate.LimitedEnglishProficiencyType, 
        Api.Models.Requests.v2.LimitedEnglishProficiencyTypes.LimitedEnglishProficiencyTypeGetByKey, 
        Api.Models.Requests.v2.LimitedEnglishProficiencyTypes.LimitedEnglishProficiencyTypePut,
        Api.Models.Requests.v2.LimitedEnglishProficiencyTypes.LimitedEnglishProficiencyTypePost,
        Api.Models.Requests.v2.LimitedEnglishProficiencyTypes.LimitedEnglishProficiencyTypeDelete,
        Api.Models.Requests.v2.LimitedEnglishProficiencyTypes.LimitedEnglishProficiencyTypeGetByExample>
    {
        public LimitedEnglishProficiencyTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.LimitedEnglishProficiencyTypes.LimitedEnglishProficiencyTypeGetByKey request, ILimitedEnglishProficiencyType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.LimitedEnglishProficiencyTypeId = request.LimitedEnglishProficiencyTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.LimitedEnglishProficiencyTypes.LimitedEnglishProficiencyTypeGetByExample request, ILimitedEnglishProficiencyType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.LimitedEnglishProficiencyTypeId = request.LimitedEnglishProficiencyTypeId;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int limitedEnglishProficiencyTypeId)
        {
            var request = new Api.Models.Requests.v2.LimitedEnglishProficiencyTypes.LimitedEnglishProficiencyTypeGetByKey
            {
                LimitedEnglishProficiencyTypeId = limitedEnglishProficiencyTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(ILimitedEnglishProficiencyType request)
        {
            return 
                request.LimitedEnglishProficiencyTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "limitedEnglishProficiencyTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.LocalEducationAgencies
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class LocalEducationAgenciesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.LocalEducationAgency.LocalEducationAgency, 
        EdFi.Ods.Api.Models.Resources.V2.LocalEducationAgency.LocalEducationAgency, 
        EdFi.Ods.Entities.Common.ILocalEducationAgency, 
        // EdFi.Ods.Entities.NHibernate.LocalEducationAgencyAggregate.LocalEducationAgency, 
        Api.Models.Requests.v2.LocalEducationAgencies.LocalEducationAgencyGetByKey, 
        Api.Models.Requests.v2.LocalEducationAgencies.LocalEducationAgencyPut,
        Api.Models.Requests.v2.LocalEducationAgencies.LocalEducationAgencyPost,
        Api.Models.Requests.v2.LocalEducationAgencies.LocalEducationAgencyDelete,
        Api.Models.Requests.v2.LocalEducationAgencies.LocalEducationAgencyGetByExample>
    {
        public LocalEducationAgenciesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.LocalEducationAgencies.LocalEducationAgencyGetByKey request, ILocalEducationAgency specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.LocalEducationAgencyId = request.LocalEducationAgencyId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.LocalEducationAgencies.LocalEducationAgencyGetByExample request, ILocalEducationAgency specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CharterStatusType = request.CharterStatusType;
            specification.EducationServiceCenterId = request.EducationServiceCenterId;
            specification.LocalEducationAgencyCategoryType = request.CategoryType;
            specification.LocalEducationAgencyId = request.LocalEducationAgencyId;
            specification.ParentLocalEducationAgencyId = request.ParentLocalEducationAgencyId;
            specification.StateEducationAgencyId = request.StateEducationAgencyId;
                    }
                public IHttpActionResult GetByKey([FromUri] int localEducationAgencyId)
        {
            var request = new Api.Models.Requests.v2.LocalEducationAgencies.LocalEducationAgencyGetByKey
            {
                LocalEducationAgencyId = localEducationAgencyId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(ILocalEducationAgency request)
        {
            return 
                request.LocalEducationAgencyId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "localEducationAgencies";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.LocalEducationAgencyCategoryTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class LocalEducationAgencyCategoryTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.LocalEducationAgencyCategoryType.LocalEducationAgencyCategoryType, 
        EdFi.Ods.Api.Models.Resources.V2.LocalEducationAgencyCategoryType.LocalEducationAgencyCategoryType, 
        EdFi.Ods.Entities.Common.ILocalEducationAgencyCategoryType, 
        // EdFi.Ods.Entities.NHibernate.LocalEducationAgencyCategoryTypeAggregate.LocalEducationAgencyCategoryType, 
        Api.Models.Requests.v2.LocalEducationAgencyCategoryTypes.LocalEducationAgencyCategoryTypeGetByKey, 
        Api.Models.Requests.v2.LocalEducationAgencyCategoryTypes.LocalEducationAgencyCategoryTypePut,
        Api.Models.Requests.v2.LocalEducationAgencyCategoryTypes.LocalEducationAgencyCategoryTypePost,
        Api.Models.Requests.v2.LocalEducationAgencyCategoryTypes.LocalEducationAgencyCategoryTypeDelete,
        Api.Models.Requests.v2.LocalEducationAgencyCategoryTypes.LocalEducationAgencyCategoryTypeGetByExample>
    {
        public LocalEducationAgencyCategoryTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.LocalEducationAgencyCategoryTypes.LocalEducationAgencyCategoryTypeGetByKey request, ILocalEducationAgencyCategoryType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.LocalEducationAgencyCategoryTypeId = request.LocalEducationAgencyCategoryTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.LocalEducationAgencyCategoryTypes.LocalEducationAgencyCategoryTypeGetByExample request, ILocalEducationAgencyCategoryType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.LocalEducationAgencyCategoryTypeId = request.LocalEducationAgencyCategoryTypeId;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int localEducationAgencyCategoryTypeId)
        {
            var request = new Api.Models.Requests.v2.LocalEducationAgencyCategoryTypes.LocalEducationAgencyCategoryTypeGetByKey
            {
                LocalEducationAgencyCategoryTypeId = localEducationAgencyCategoryTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(ILocalEducationAgencyCategoryType request)
        {
            return 
                request.LocalEducationAgencyCategoryTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "localEducationAgencyCategoryTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.Locations
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class LocationsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.Location.Location, 
        EdFi.Ods.Api.Models.Resources.V2.Location.Location, 
        EdFi.Ods.Entities.Common.ILocation, 
        // EdFi.Ods.Entities.NHibernate.LocationAggregate.Location, 
        Api.Models.Requests.v2.Locations.LocationGetByKey, 
        Api.Models.Requests.v2.Locations.LocationPut,
        Api.Models.Requests.v2.Locations.LocationPost,
        Api.Models.Requests.v2.Locations.LocationDelete,
        Api.Models.Requests.v2.Locations.LocationGetByExample>
    {
        public LocationsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.Locations.LocationGetByKey request, ILocation specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.ClassroomIdentificationCode = request.ClassroomIdentificationCode;
            specification.SchoolId = request.SchoolId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.Locations.LocationGetByExample request, ILocation specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.ClassroomIdentificationCode = request.ClassroomIdentificationCode;
            specification.Id = request.Id;
            specification.MaximumNumberOfSeats = request.MaximumNumberOfSeats;
            specification.OptimalNumberOfSeats = request.OptimalNumberOfSeats;
            specification.SchoolId = request.SchoolId;
                    }
                public IHttpActionResult GetByKey([FromUri] string classroomIdentificationCode, int schoolId)
        {
            var request = new Api.Models.Requests.v2.Locations.LocationGetByKey
            {
                ClassroomIdentificationCode = classroomIdentificationCode,
                SchoolId = schoolId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(ILocation request)
        {
            return 
                request.ClassroomIdentificationCode != default(string)
                && request.SchoolId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "locations";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.MagnetSpecialProgramEmphasisSchoolTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class MagnetSpecialProgramEmphasisSchoolTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.MagnetSpecialProgramEmphasisSchoolType.MagnetSpecialProgramEmphasisSchoolType, 
        EdFi.Ods.Api.Models.Resources.V2.MagnetSpecialProgramEmphasisSchoolType.MagnetSpecialProgramEmphasisSchoolType, 
        EdFi.Ods.Entities.Common.IMagnetSpecialProgramEmphasisSchoolType, 
        // EdFi.Ods.Entities.NHibernate.MagnetSpecialProgramEmphasisSchoolTypeAggregate.MagnetSpecialProgramEmphasisSchoolType, 
        Api.Models.Requests.v2.MagnetSpecialProgramEmphasisSchoolTypes.MagnetSpecialProgramEmphasisSchoolTypeGetByKey, 
        Api.Models.Requests.v2.MagnetSpecialProgramEmphasisSchoolTypes.MagnetSpecialProgramEmphasisSchoolTypePut,
        Api.Models.Requests.v2.MagnetSpecialProgramEmphasisSchoolTypes.MagnetSpecialProgramEmphasisSchoolTypePost,
        Api.Models.Requests.v2.MagnetSpecialProgramEmphasisSchoolTypes.MagnetSpecialProgramEmphasisSchoolTypeDelete,
        Api.Models.Requests.v2.MagnetSpecialProgramEmphasisSchoolTypes.MagnetSpecialProgramEmphasisSchoolTypeGetByExample>
    {
        public MagnetSpecialProgramEmphasisSchoolTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.MagnetSpecialProgramEmphasisSchoolTypes.MagnetSpecialProgramEmphasisSchoolTypeGetByKey request, IMagnetSpecialProgramEmphasisSchoolType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.MagnetSpecialProgramEmphasisSchoolTypeId = request.MagnetSpecialProgramEmphasisSchoolTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.MagnetSpecialProgramEmphasisSchoolTypes.MagnetSpecialProgramEmphasisSchoolTypeGetByExample request, IMagnetSpecialProgramEmphasisSchoolType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.MagnetSpecialProgramEmphasisSchoolTypeId = request.MagnetSpecialProgramEmphasisSchoolTypeId;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int magnetSpecialProgramEmphasisSchoolTypeId)
        {
            var request = new Api.Models.Requests.v2.MagnetSpecialProgramEmphasisSchoolTypes.MagnetSpecialProgramEmphasisSchoolTypeGetByKey
            {
                MagnetSpecialProgramEmphasisSchoolTypeId = magnetSpecialProgramEmphasisSchoolTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IMagnetSpecialProgramEmphasisSchoolType request)
        {
            return 
                request.MagnetSpecialProgramEmphasisSchoolTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "magnetSpecialProgramEmphasisSchoolTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.MediumOfInstructionTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class MediumOfInstructionTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.MediumOfInstructionType.MediumOfInstructionType, 
        EdFi.Ods.Api.Models.Resources.V2.MediumOfInstructionType.MediumOfInstructionType, 
        EdFi.Ods.Entities.Common.IMediumOfInstructionType, 
        // EdFi.Ods.Entities.NHibernate.MediumOfInstructionTypeAggregate.MediumOfInstructionType, 
        Api.Models.Requests.v2.MediumOfInstructionTypes.MediumOfInstructionTypeGetByKey, 
        Api.Models.Requests.v2.MediumOfInstructionTypes.MediumOfInstructionTypePut,
        Api.Models.Requests.v2.MediumOfInstructionTypes.MediumOfInstructionTypePost,
        Api.Models.Requests.v2.MediumOfInstructionTypes.MediumOfInstructionTypeDelete,
        Api.Models.Requests.v2.MediumOfInstructionTypes.MediumOfInstructionTypeGetByExample>
    {
        public MediumOfInstructionTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.MediumOfInstructionTypes.MediumOfInstructionTypeGetByKey request, IMediumOfInstructionType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.MediumOfInstructionTypeId = request.MediumOfInstructionTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.MediumOfInstructionTypes.MediumOfInstructionTypeGetByExample request, IMediumOfInstructionType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.MediumOfInstructionTypeId = request.MediumOfInstructionTypeId;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int mediumOfInstructionTypeId)
        {
            var request = new Api.Models.Requests.v2.MediumOfInstructionTypes.MediumOfInstructionTypeGetByKey
            {
                MediumOfInstructionTypeId = mediumOfInstructionTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IMediumOfInstructionType request)
        {
            return 
                request.MediumOfInstructionTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "mediumOfInstructionTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.MeetingDayTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class MeetingDayTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.MeetingDayType.MeetingDayType, 
        EdFi.Ods.Api.Models.Resources.V2.MeetingDayType.MeetingDayType, 
        EdFi.Ods.Entities.Common.IMeetingDayType, 
        // EdFi.Ods.Entities.NHibernate.MeetingDayTypeAggregate.MeetingDayType, 
        Api.Models.Requests.v2.MeetingDayTypes.MeetingDayTypeGetByKey, 
        Api.Models.Requests.v2.MeetingDayTypes.MeetingDayTypePut,
        Api.Models.Requests.v2.MeetingDayTypes.MeetingDayTypePost,
        Api.Models.Requests.v2.MeetingDayTypes.MeetingDayTypeDelete,
        Api.Models.Requests.v2.MeetingDayTypes.MeetingDayTypeGetByExample>
    {
        public MeetingDayTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.MeetingDayTypes.MeetingDayTypeGetByKey request, IMeetingDayType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.MeetingDayTypeId = request.MeetingDayTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.MeetingDayTypes.MeetingDayTypeGetByExample request, IMeetingDayType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.MeetingDayTypeId = request.MeetingDayTypeId;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int meetingDayTypeId)
        {
            var request = new Api.Models.Requests.v2.MeetingDayTypes.MeetingDayTypeGetByKey
            {
                MeetingDayTypeId = meetingDayTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IMeetingDayType request)
        {
            return 
                request.MeetingDayTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "meetingDayTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.MethodCreditEarnedTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class MethodCreditEarnedTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.MethodCreditEarnedType.MethodCreditEarnedType, 
        EdFi.Ods.Api.Models.Resources.V2.MethodCreditEarnedType.MethodCreditEarnedType, 
        EdFi.Ods.Entities.Common.IMethodCreditEarnedType, 
        // EdFi.Ods.Entities.NHibernate.MethodCreditEarnedTypeAggregate.MethodCreditEarnedType, 
        Api.Models.Requests.v2.MethodCreditEarnedTypes.MethodCreditEarnedTypeGetByKey, 
        Api.Models.Requests.v2.MethodCreditEarnedTypes.MethodCreditEarnedTypePut,
        Api.Models.Requests.v2.MethodCreditEarnedTypes.MethodCreditEarnedTypePost,
        Api.Models.Requests.v2.MethodCreditEarnedTypes.MethodCreditEarnedTypeDelete,
        Api.Models.Requests.v2.MethodCreditEarnedTypes.MethodCreditEarnedTypeGetByExample>
    {
        public MethodCreditEarnedTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.MethodCreditEarnedTypes.MethodCreditEarnedTypeGetByKey request, IMethodCreditEarnedType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.MethodCreditEarnedTypeId = request.MethodCreditEarnedTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.MethodCreditEarnedTypes.MethodCreditEarnedTypeGetByExample request, IMethodCreditEarnedType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.MethodCreditEarnedTypeId = request.MethodCreditEarnedTypeId;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int methodCreditEarnedTypeId)
        {
            var request = new Api.Models.Requests.v2.MethodCreditEarnedTypes.MethodCreditEarnedTypeGetByKey
            {
                MethodCreditEarnedTypeId = methodCreditEarnedTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IMethodCreditEarnedType request)
        {
            return 
                request.MethodCreditEarnedTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "methodCreditEarnedTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.NetworkPurposeTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class NetworkPurposeTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.NetworkPurposeType.NetworkPurposeType, 
        EdFi.Ods.Api.Models.Resources.V2.NetworkPurposeType.NetworkPurposeType, 
        EdFi.Ods.Entities.Common.INetworkPurposeType, 
        // EdFi.Ods.Entities.NHibernate.NetworkPurposeTypeAggregate.NetworkPurposeType, 
        Api.Models.Requests.v2.NetworkPurposeTypes.NetworkPurposeTypeGetByKey, 
        Api.Models.Requests.v2.NetworkPurposeTypes.NetworkPurposeTypePut,
        Api.Models.Requests.v2.NetworkPurposeTypes.NetworkPurposeTypePost,
        Api.Models.Requests.v2.NetworkPurposeTypes.NetworkPurposeTypeDelete,
        Api.Models.Requests.v2.NetworkPurposeTypes.NetworkPurposeTypeGetByExample>
    {
        public NetworkPurposeTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.NetworkPurposeTypes.NetworkPurposeTypeGetByKey request, INetworkPurposeType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.NetworkPurposeTypeId = request.NetworkPurposeTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.NetworkPurposeTypes.NetworkPurposeTypeGetByExample request, INetworkPurposeType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.NetworkPurposeTypeId = request.NetworkPurposeTypeId;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int networkPurposeTypeId)
        {
            var request = new Api.Models.Requests.v2.NetworkPurposeTypes.NetworkPurposeTypeGetByKey
            {
                NetworkPurposeTypeId = networkPurposeTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(INetworkPurposeType request)
        {
            return 
                request.NetworkPurposeTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "networkPurposeTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.ObjectiveAssessments
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class ObjectiveAssessmentsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.ObjectiveAssessment.ObjectiveAssessment, 
        EdFi.Ods.Api.Models.Resources.V2.ObjectiveAssessment.ObjectiveAssessment, 
        EdFi.Ods.Entities.Common.IObjectiveAssessment, 
        // EdFi.Ods.Entities.NHibernate.ObjectiveAssessmentAggregate.ObjectiveAssessment, 
        Api.Models.Requests.v2.ObjectiveAssessments.ObjectiveAssessmentGetByKey, 
        Api.Models.Requests.v2.ObjectiveAssessments.ObjectiveAssessmentPut,
        Api.Models.Requests.v2.ObjectiveAssessments.ObjectiveAssessmentPost,
        Api.Models.Requests.v2.ObjectiveAssessments.ObjectiveAssessmentDelete,
        Api.Models.Requests.v2.ObjectiveAssessments.ObjectiveAssessmentGetByExample>
    {
        public ObjectiveAssessmentsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.ObjectiveAssessments.ObjectiveAssessmentGetByKey request, IObjectiveAssessment specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.AssessmentIdentifier = request.AssessmentIdentifier;
            specification.IdentificationCode = request.IdentificationCode;
            specification.Namespace = request.Namespace;
                    }

        protected override void MapAll(Api.Models.Requests.v2.ObjectiveAssessments.ObjectiveAssessmentGetByExample request, IObjectiveAssessment specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.AssessmentIdentifier = request.AssessmentIdentifier;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.IdentificationCode = request.IdentificationCode;
            specification.MaxRawScore = request.MaxRawScore;
            specification.Namespace = request.Namespace;
            specification.Nomenclature = request.Nomenclature;
            specification.ParentIdentificationCode = request.ParentIdentificationCode;
            specification.PercentOfAssessment = request.PercentOfAssessment;
                    }
                public IHttpActionResult GetByKey([FromUri] string assessmentIdentifier, string identificationCode, string @namespace)
        {
            var request = new Api.Models.Requests.v2.ObjectiveAssessments.ObjectiveAssessmentGetByKey
            {
                AssessmentIdentifier = assessmentIdentifier,
                IdentificationCode = identificationCode,
                Namespace = @namespace,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IObjectiveAssessment request)
        {
            return 
                request.AssessmentIdentifier != default(string)
                && request.IdentificationCode != default(string)
                && request.Namespace != default(string);
        }

        protected override string GetResourceCollectionName()
        {
            return "objectiveAssessments";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.OldEthnicityTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class OldEthnicityTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.OldEthnicityType.OldEthnicityType, 
        EdFi.Ods.Api.Models.Resources.V2.OldEthnicityType.OldEthnicityType, 
        EdFi.Ods.Entities.Common.IOldEthnicityType, 
        // EdFi.Ods.Entities.NHibernate.OldEthnicityTypeAggregate.OldEthnicityType, 
        Api.Models.Requests.v2.OldEthnicityTypes.OldEthnicityTypeGetByKey, 
        Api.Models.Requests.v2.OldEthnicityTypes.OldEthnicityTypePut,
        Api.Models.Requests.v2.OldEthnicityTypes.OldEthnicityTypePost,
        Api.Models.Requests.v2.OldEthnicityTypes.OldEthnicityTypeDelete,
        Api.Models.Requests.v2.OldEthnicityTypes.OldEthnicityTypeGetByExample>
    {
        public OldEthnicityTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.OldEthnicityTypes.OldEthnicityTypeGetByKey request, IOldEthnicityType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.OldEthnicityTypeId = request.OldEthnicityTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.OldEthnicityTypes.OldEthnicityTypeGetByExample request, IOldEthnicityType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.OldEthnicityTypeId = request.OldEthnicityTypeId;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int oldEthnicityTypeId)
        {
            var request = new Api.Models.Requests.v2.OldEthnicityTypes.OldEthnicityTypeGetByKey
            {
                OldEthnicityTypeId = oldEthnicityTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IOldEthnicityType request)
        {
            return 
                request.OldEthnicityTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "oldEthnicityTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.OpenStaffPositions
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class OpenStaffPositionsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.OpenStaffPosition.OpenStaffPosition, 
        EdFi.Ods.Api.Models.Resources.V2.OpenStaffPosition.OpenStaffPosition, 
        EdFi.Ods.Entities.Common.IOpenStaffPosition, 
        // EdFi.Ods.Entities.NHibernate.OpenStaffPositionAggregate.OpenStaffPosition, 
        Api.Models.Requests.v2.OpenStaffPositions.OpenStaffPositionGetByKey, 
        Api.Models.Requests.v2.OpenStaffPositions.OpenStaffPositionPut,
        Api.Models.Requests.v2.OpenStaffPositions.OpenStaffPositionPost,
        Api.Models.Requests.v2.OpenStaffPositions.OpenStaffPositionDelete,
        Api.Models.Requests.v2.OpenStaffPositions.OpenStaffPositionGetByExample>
    {
        public OpenStaffPositionsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.OpenStaffPositions.OpenStaffPositionGetByKey request, IOpenStaffPosition specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.DatePosted = request.DatePosted;
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.EmploymentStatusDescriptor = request.EmploymentStatusDescriptor;
            specification.RequisitionNumber = request.RequisitionNumber;
            specification.StaffClassificationDescriptor = request.StaffClassificationDescriptor;
                    }

        protected override void MapAll(Api.Models.Requests.v2.OpenStaffPositions.OpenStaffPositionGetByExample request, IOpenStaffPosition specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.DatePosted = request.DatePosted;
            specification.DatePostingRemoved = request.DatePostingRemoved;
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.EmploymentStatusDescriptor = request.EmploymentStatusDescriptor;
            specification.Id = request.Id;
            specification.PositionTitle = request.PositionTitle;
            specification.PostingResultType = request.PostingResultType;
            specification.ProgramAssignmentDescriptor = request.ProgramAssignmentDescriptor;
            specification.RequisitionNumber = request.RequisitionNumber;
            specification.StaffClassificationDescriptor = request.StaffClassificationDescriptor;
                    }
                public IHttpActionResult GetByKey([FromUri] DateTime datePosted, int educationOrganizationId, string employmentStatusDescriptor, string requisitionNumber, string staffClassificationDescriptor)
        {
            var request = new Api.Models.Requests.v2.OpenStaffPositions.OpenStaffPositionGetByKey
            {
                DatePosted = datePosted,
                EducationOrganizationId = educationOrganizationId,
                EmploymentStatusDescriptor = employmentStatusDescriptor,
                RequisitionNumber = requisitionNumber,
                StaffClassificationDescriptor = staffClassificationDescriptor,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IOpenStaffPosition request)
        {
            return 
                request.DatePosted != default(DateTime)
                && request.EducationOrganizationId != default(int)
                && request.EmploymentStatusDescriptor != null
                && request.RequisitionNumber != default(string)
                && request.StaffClassificationDescriptor != null;
        }

        protected override string GetResourceCollectionName()
        {
            return "openStaffPositions";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.OperationalStatusTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class OperationalStatusTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.OperationalStatusType.OperationalStatusType, 
        EdFi.Ods.Api.Models.Resources.V2.OperationalStatusType.OperationalStatusType, 
        EdFi.Ods.Entities.Common.IOperationalStatusType, 
        // EdFi.Ods.Entities.NHibernate.OperationalStatusTypeAggregate.OperationalStatusType, 
        Api.Models.Requests.v2.OperationalStatusTypes.OperationalStatusTypeGetByKey, 
        Api.Models.Requests.v2.OperationalStatusTypes.OperationalStatusTypePut,
        Api.Models.Requests.v2.OperationalStatusTypes.OperationalStatusTypePost,
        Api.Models.Requests.v2.OperationalStatusTypes.OperationalStatusTypeDelete,
        Api.Models.Requests.v2.OperationalStatusTypes.OperationalStatusTypeGetByExample>
    {
        public OperationalStatusTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.OperationalStatusTypes.OperationalStatusTypeGetByKey request, IOperationalStatusType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.OperationalStatusTypeId = request.OperationalStatusTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.OperationalStatusTypes.OperationalStatusTypeGetByExample request, IOperationalStatusType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.OperationalStatusTypeId = request.OperationalStatusTypeId;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int operationalStatusTypeId)
        {
            var request = new Api.Models.Requests.v2.OperationalStatusTypes.OperationalStatusTypeGetByKey
            {
                OperationalStatusTypeId = operationalStatusTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IOperationalStatusType request)
        {
            return 
                request.OperationalStatusTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "operationalStatusTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.OtherNameTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class OtherNameTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.OtherNameType.OtherNameType, 
        EdFi.Ods.Api.Models.Resources.V2.OtherNameType.OtherNameType, 
        EdFi.Ods.Entities.Common.IOtherNameType, 
        // EdFi.Ods.Entities.NHibernate.OtherNameTypeAggregate.OtherNameType, 
        Api.Models.Requests.v2.OtherNameTypes.OtherNameTypeGetByKey, 
        Api.Models.Requests.v2.OtherNameTypes.OtherNameTypePut,
        Api.Models.Requests.v2.OtherNameTypes.OtherNameTypePost,
        Api.Models.Requests.v2.OtherNameTypes.OtherNameTypeDelete,
        Api.Models.Requests.v2.OtherNameTypes.OtherNameTypeGetByExample>
    {
        public OtherNameTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.OtherNameTypes.OtherNameTypeGetByKey request, IOtherNameType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.OtherNameTypeId = request.OtherNameTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.OtherNameTypes.OtherNameTypeGetByExample request, IOtherNameType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.OtherNameTypeId = request.OtherNameTypeId;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int otherNameTypeId)
        {
            var request = new Api.Models.Requests.v2.OtherNameTypes.OtherNameTypeGetByKey
            {
                OtherNameTypeId = otherNameTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IOtherNameType request)
        {
            return 
                request.OtherNameTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "otherNameTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.Parents
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class ParentsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.Parent.Parent, 
        EdFi.Ods.Api.Models.Resources.V2.Parent.Parent, 
        EdFi.Ods.Entities.Common.IParent, 
        // EdFi.Ods.Entities.NHibernate.ParentAggregate.Parent, 
        Api.Models.Requests.v2.Parents.ParentGetByKey, 
        Api.Models.Requests.v2.Parents.ParentPut,
        Api.Models.Requests.v2.Parents.ParentPost,
        Api.Models.Requests.v2.Parents.ParentDelete,
        Api.Models.Requests.v2.Parents.ParentGetByExample>
    {
        public ParentsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.Parents.ParentGetByKey request, IParent specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.ParentUniqueId = request.ParentUniqueId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.Parents.ParentGetByExample request, IParent specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.FirstName = request.FirstName;
            specification.GenerationCodeSuffix = request.GenerationCodeSuffix;
            specification.Id = request.Id;
            specification.LastSurname = request.LastSurname;
            specification.LoginId = request.LoginId;
            specification.MaidenName = request.MaidenName;
            specification.MiddleName = request.MiddleName;
            specification.ParentUniqueId = request.ParentUniqueId;
            specification.PersonalTitlePrefix = request.PersonalTitlePrefix;
            specification.SexType = request.SexType;
                    }
                public IHttpActionResult GetByKey([FromUri] string parentUniqueId)
        {
            var request = new Api.Models.Requests.v2.Parents.ParentGetByKey
            {
                ParentUniqueId = parentUniqueId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IParent request)
        {
            return 
                request.ParentUniqueId != default(string);
        }

        protected override string GetResourceCollectionName()
        {
            return "parents";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.Payrolls
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class PayrollsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.Payroll.Payroll, 
        EdFi.Ods.Api.Models.Resources.V2.Payroll.Payroll, 
        EdFi.Ods.Entities.Common.IPayroll, 
        // EdFi.Ods.Entities.NHibernate.PayrollAggregate.Payroll, 
        Api.Models.Requests.v2.Payrolls.PayrollGetByKey, 
        Api.Models.Requests.v2.Payrolls.PayrollPut,
        Api.Models.Requests.v2.Payrolls.PayrollPost,
        Api.Models.Requests.v2.Payrolls.PayrollDelete,
        Api.Models.Requests.v2.Payrolls.PayrollGetByExample>
    {
        public PayrollsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.Payrolls.PayrollGetByKey request, IPayroll specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.AccountNumber = request.AccountNumber;
            specification.AsOfDate = request.AsOfDate;
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.FiscalYear = request.FiscalYear;
            specification.StaffUniqueId = request.StaffUniqueId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.Payrolls.PayrollGetByExample request, IPayroll specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.AccountNumber = request.AccountNumber;
            specification.AmountToDate = request.AmountToDate;
            specification.AsOfDate = request.AsOfDate;
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.FiscalYear = request.FiscalYear;
            specification.Id = request.Id;
            specification.StaffUniqueId = request.StaffUniqueId;
                    }
                public IHttpActionResult GetByKey([FromUri] string accountNumber, DateTime asOfDate, int educationOrganizationId, int fiscalYear, string staffUniqueId)
        {
            var request = new Api.Models.Requests.v2.Payrolls.PayrollGetByKey
            {
                AccountNumber = accountNumber,
                AsOfDate = asOfDate,
                EducationOrganizationId = educationOrganizationId,
                FiscalYear = fiscalYear,
                StaffUniqueId = staffUniqueId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IPayroll request)
        {
            return 
                request.AccountNumber != default(string)
                && request.AsOfDate != default(DateTime)
                && request.EducationOrganizationId != default(int)
                && request.FiscalYear != default(int)
                && request.StaffUniqueId != default(string);
        }

        protected override string GetResourceCollectionName()
        {
            return "payrolls";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.PerformanceBaseConversionTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class PerformanceBaseConversionTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.PerformanceBaseConversionType.PerformanceBaseConversionType, 
        EdFi.Ods.Api.Models.Resources.V2.PerformanceBaseConversionType.PerformanceBaseConversionType, 
        EdFi.Ods.Entities.Common.IPerformanceBaseConversionType, 
        // EdFi.Ods.Entities.NHibernate.PerformanceBaseConversionTypeAggregate.PerformanceBaseConversionType, 
        Api.Models.Requests.v2.PerformanceBaseConversionTypes.PerformanceBaseConversionTypeGetByKey, 
        Api.Models.Requests.v2.PerformanceBaseConversionTypes.PerformanceBaseConversionTypePut,
        Api.Models.Requests.v2.PerformanceBaseConversionTypes.PerformanceBaseConversionTypePost,
        Api.Models.Requests.v2.PerformanceBaseConversionTypes.PerformanceBaseConversionTypeDelete,
        Api.Models.Requests.v2.PerformanceBaseConversionTypes.PerformanceBaseConversionTypeGetByExample>
    {
        public PerformanceBaseConversionTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.PerformanceBaseConversionTypes.PerformanceBaseConversionTypeGetByKey request, IPerformanceBaseConversionType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.PerformanceBaseConversionTypeId = request.PerformanceBaseConversionTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.PerformanceBaseConversionTypes.PerformanceBaseConversionTypeGetByExample request, IPerformanceBaseConversionType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.PerformanceBaseConversionTypeId = request.PerformanceBaseConversionTypeId;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int performanceBaseConversionTypeId)
        {
            var request = new Api.Models.Requests.v2.PerformanceBaseConversionTypes.PerformanceBaseConversionTypeGetByKey
            {
                PerformanceBaseConversionTypeId = performanceBaseConversionTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IPerformanceBaseConversionType request)
        {
            return 
                request.PerformanceBaseConversionTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "performanceBaseConversionTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.PerformanceLevelDescriptors
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class PerformanceLevelDescriptorsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.PerformanceLevelDescriptor.PerformanceLevelDescriptor, 
        EdFi.Ods.Api.Models.Resources.V2.PerformanceLevelDescriptor.PerformanceLevelDescriptor, 
        EdFi.Ods.Entities.Common.IPerformanceLevelDescriptor, 
        // EdFi.Ods.Entities.NHibernate.PerformanceLevelDescriptorAggregate.PerformanceLevelDescriptor, 
        Api.Models.Requests.v2.PerformanceLevelDescriptors.PerformanceLevelDescriptorGetByKey, 
        Api.Models.Requests.v2.PerformanceLevelDescriptors.PerformanceLevelDescriptorPut,
        Api.Models.Requests.v2.PerformanceLevelDescriptors.PerformanceLevelDescriptorPost,
        Api.Models.Requests.v2.PerformanceLevelDescriptors.PerformanceLevelDescriptorDelete,
        Api.Models.Requests.v2.PerformanceLevelDescriptors.PerformanceLevelDescriptorGetByExample>
    {
        public PerformanceLevelDescriptorsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.PerformanceLevelDescriptors.PerformanceLevelDescriptorGetByKey request, IPerformanceLevelDescriptor specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.PerformanceLevelDescriptorId = request.PerformanceLevelDescriptorId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.PerformanceLevelDescriptors.PerformanceLevelDescriptorGetByExample request, IPerformanceLevelDescriptor specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.PerformanceBaseConversionType = request.PerformanceBaseConversionType;
            specification.PerformanceLevelDescriptorId = request.PerformanceLevelDescriptorId;
                    }
                public IHttpActionResult GetByKey([FromUri] int performanceLevelDescriptorId)
        {
            var request = new Api.Models.Requests.v2.PerformanceLevelDescriptors.PerformanceLevelDescriptorGetByKey
            {
                PerformanceLevelDescriptorId = performanceLevelDescriptorId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IPerformanceLevelDescriptor request)
        {
            return 
                request.PerformanceLevelDescriptorId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "performanceLevelDescriptors";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.PersonalInformationVerificationTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class PersonalInformationVerificationTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.PersonalInformationVerificationType.PersonalInformationVerificationType, 
        EdFi.Ods.Api.Models.Resources.V2.PersonalInformationVerificationType.PersonalInformationVerificationType, 
        EdFi.Ods.Entities.Common.IPersonalInformationVerificationType, 
        // EdFi.Ods.Entities.NHibernate.PersonalInformationVerificationTypeAggregate.PersonalInformationVerificationType, 
        Api.Models.Requests.v2.PersonalInformationVerificationTypes.PersonalInformationVerificationTypeGetByKey, 
        Api.Models.Requests.v2.PersonalInformationVerificationTypes.PersonalInformationVerificationTypePut,
        Api.Models.Requests.v2.PersonalInformationVerificationTypes.PersonalInformationVerificationTypePost,
        Api.Models.Requests.v2.PersonalInformationVerificationTypes.PersonalInformationVerificationTypeDelete,
        Api.Models.Requests.v2.PersonalInformationVerificationTypes.PersonalInformationVerificationTypeGetByExample>
    {
        public PersonalInformationVerificationTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.PersonalInformationVerificationTypes.PersonalInformationVerificationTypeGetByKey request, IPersonalInformationVerificationType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.PersonalInformationVerificationTypeId = request.PersonalInformationVerificationTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.PersonalInformationVerificationTypes.PersonalInformationVerificationTypeGetByExample request, IPersonalInformationVerificationType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.PersonalInformationVerificationTypeId = request.PersonalInformationVerificationTypeId;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int personalInformationVerificationTypeId)
        {
            var request = new Api.Models.Requests.v2.PersonalInformationVerificationTypes.PersonalInformationVerificationTypeGetByKey
            {
                PersonalInformationVerificationTypeId = personalInformationVerificationTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IPersonalInformationVerificationType request)
        {
            return 
                request.PersonalInformationVerificationTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "personalInformationVerificationTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.PopulationServedTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class PopulationServedTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.PopulationServedType.PopulationServedType, 
        EdFi.Ods.Api.Models.Resources.V2.PopulationServedType.PopulationServedType, 
        EdFi.Ods.Entities.Common.IPopulationServedType, 
        // EdFi.Ods.Entities.NHibernate.PopulationServedTypeAggregate.PopulationServedType, 
        Api.Models.Requests.v2.PopulationServedTypes.PopulationServedTypeGetByKey, 
        Api.Models.Requests.v2.PopulationServedTypes.PopulationServedTypePut,
        Api.Models.Requests.v2.PopulationServedTypes.PopulationServedTypePost,
        Api.Models.Requests.v2.PopulationServedTypes.PopulationServedTypeDelete,
        Api.Models.Requests.v2.PopulationServedTypes.PopulationServedTypeGetByExample>
    {
        public PopulationServedTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.PopulationServedTypes.PopulationServedTypeGetByKey request, IPopulationServedType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.PopulationServedTypeId = request.PopulationServedTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.PopulationServedTypes.PopulationServedTypeGetByExample request, IPopulationServedType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.PopulationServedTypeId = request.PopulationServedTypeId;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int populationServedTypeId)
        {
            var request = new Api.Models.Requests.v2.PopulationServedTypes.PopulationServedTypeGetByKey
            {
                PopulationServedTypeId = populationServedTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IPopulationServedType request)
        {
            return 
                request.PopulationServedTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "populationServedTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.PostingResultTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class PostingResultTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.PostingResultType.PostingResultType, 
        EdFi.Ods.Api.Models.Resources.V2.PostingResultType.PostingResultType, 
        EdFi.Ods.Entities.Common.IPostingResultType, 
        // EdFi.Ods.Entities.NHibernate.PostingResultTypeAggregate.PostingResultType, 
        Api.Models.Requests.v2.PostingResultTypes.PostingResultTypeGetByKey, 
        Api.Models.Requests.v2.PostingResultTypes.PostingResultTypePut,
        Api.Models.Requests.v2.PostingResultTypes.PostingResultTypePost,
        Api.Models.Requests.v2.PostingResultTypes.PostingResultTypeDelete,
        Api.Models.Requests.v2.PostingResultTypes.PostingResultTypeGetByExample>
    {
        public PostingResultTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.PostingResultTypes.PostingResultTypeGetByKey request, IPostingResultType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.PostingResultTypeId = request.PostingResultTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.PostingResultTypes.PostingResultTypeGetByExample request, IPostingResultType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.PostingResultTypeId = request.PostingResultTypeId;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int postingResultTypeId)
        {
            var request = new Api.Models.Requests.v2.PostingResultTypes.PostingResultTypeGetByKey
            {
                PostingResultTypeId = postingResultTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IPostingResultType request)
        {
            return 
                request.PostingResultTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "postingResultTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.PostSecondaryEvents
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class PostSecondaryEventsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.PostSecondaryEvent.PostSecondaryEvent, 
        EdFi.Ods.Api.Models.Resources.V2.PostSecondaryEvent.PostSecondaryEvent, 
        EdFi.Ods.Entities.Common.IPostSecondaryEvent, 
        // EdFi.Ods.Entities.NHibernate.PostSecondaryEventAggregate.PostSecondaryEvent, 
        Api.Models.Requests.v2.PostSecondaryEvents.PostSecondaryEventGetByKey, 
        Api.Models.Requests.v2.PostSecondaryEvents.PostSecondaryEventPut,
        Api.Models.Requests.v2.PostSecondaryEvents.PostSecondaryEventPost,
        Api.Models.Requests.v2.PostSecondaryEvents.PostSecondaryEventDelete,
        Api.Models.Requests.v2.PostSecondaryEvents.PostSecondaryEventGetByExample>
    {
        public PostSecondaryEventsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.PostSecondaryEvents.PostSecondaryEventGetByKey request, IPostSecondaryEvent specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.EventDate = request.EventDate;
            specification.PostSecondaryEventCategoryType = request.CategoryType;
            specification.StudentUniqueId = request.StudentUniqueId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.PostSecondaryEvents.PostSecondaryEventGetByExample request, IPostSecondaryEvent specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.EventDate = request.EventDate;
            specification.Id = request.Id;
            specification.PostSecondaryEventCategoryType = request.CategoryType;
            specification.StudentUniqueId = request.StudentUniqueId;
                    }
                public IHttpActionResult GetByKey([FromUri] DateTime eventDate, string categoryType, string studentUniqueId)
        {
            var request = new Api.Models.Requests.v2.PostSecondaryEvents.PostSecondaryEventGetByKey
            {
                EventDate = eventDate,
                CategoryType = categoryType,
                StudentUniqueId = studentUniqueId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IPostSecondaryEvent request)
        {
            return 
                request.EventDate != default(DateTime)
                && request.PostSecondaryEventCategoryType != null
                && request.StudentUniqueId != default(string);
        }

        protected override string GetResourceCollectionName()
        {
            return "postSecondaryEvents";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.PostSecondaryEventCategoryTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class PostSecondaryEventCategoryTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.PostSecondaryEventCategoryType.PostSecondaryEventCategoryType, 
        EdFi.Ods.Api.Models.Resources.V2.PostSecondaryEventCategoryType.PostSecondaryEventCategoryType, 
        EdFi.Ods.Entities.Common.IPostSecondaryEventCategoryType, 
        // EdFi.Ods.Entities.NHibernate.PostSecondaryEventCategoryTypeAggregate.PostSecondaryEventCategoryType, 
        Api.Models.Requests.v2.PostSecondaryEventCategoryTypes.PostSecondaryEventCategoryTypeGetByKey, 
        Api.Models.Requests.v2.PostSecondaryEventCategoryTypes.PostSecondaryEventCategoryTypePut,
        Api.Models.Requests.v2.PostSecondaryEventCategoryTypes.PostSecondaryEventCategoryTypePost,
        Api.Models.Requests.v2.PostSecondaryEventCategoryTypes.PostSecondaryEventCategoryTypeDelete,
        Api.Models.Requests.v2.PostSecondaryEventCategoryTypes.PostSecondaryEventCategoryTypeGetByExample>
    {
        public PostSecondaryEventCategoryTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.PostSecondaryEventCategoryTypes.PostSecondaryEventCategoryTypeGetByKey request, IPostSecondaryEventCategoryType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.PostSecondaryEventCategoryTypeId = request.PostSecondaryEventCategoryTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.PostSecondaryEventCategoryTypes.PostSecondaryEventCategoryTypeGetByExample request, IPostSecondaryEventCategoryType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.PostSecondaryEventCategoryTypeId = request.PostSecondaryEventCategoryTypeId;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int postSecondaryEventCategoryTypeId)
        {
            var request = new Api.Models.Requests.v2.PostSecondaryEventCategoryTypes.PostSecondaryEventCategoryTypeGetByKey
            {
                PostSecondaryEventCategoryTypeId = postSecondaryEventCategoryTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IPostSecondaryEventCategoryType request)
        {
            return 
                request.PostSecondaryEventCategoryTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "postSecondaryEventCategoryTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.PostSecondaryInstitutionLevelTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class PostSecondaryInstitutionLevelTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.PostSecondaryInstitutionLevelType.PostSecondaryInstitutionLevelType, 
        EdFi.Ods.Api.Models.Resources.V2.PostSecondaryInstitutionLevelType.PostSecondaryInstitutionLevelType, 
        EdFi.Ods.Entities.Common.IPostSecondaryInstitutionLevelType, 
        // EdFi.Ods.Entities.NHibernate.PostSecondaryInstitutionLevelTypeAggregate.PostSecondaryInstitutionLevelType, 
        Api.Models.Requests.v2.PostSecondaryInstitutionLevelTypes.PostSecondaryInstitutionLevelTypeGetByKey, 
        Api.Models.Requests.v2.PostSecondaryInstitutionLevelTypes.PostSecondaryInstitutionLevelTypePut,
        Api.Models.Requests.v2.PostSecondaryInstitutionLevelTypes.PostSecondaryInstitutionLevelTypePost,
        Api.Models.Requests.v2.PostSecondaryInstitutionLevelTypes.PostSecondaryInstitutionLevelTypeDelete,
        Api.Models.Requests.v2.PostSecondaryInstitutionLevelTypes.PostSecondaryInstitutionLevelTypeGetByExample>
    {
        public PostSecondaryInstitutionLevelTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.PostSecondaryInstitutionLevelTypes.PostSecondaryInstitutionLevelTypeGetByKey request, IPostSecondaryInstitutionLevelType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.PostSecondaryInstitutionLevelTypeId = request.PostSecondaryInstitutionLevelTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.PostSecondaryInstitutionLevelTypes.PostSecondaryInstitutionLevelTypeGetByExample request, IPostSecondaryInstitutionLevelType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.PostSecondaryInstitutionLevelTypeId = request.PostSecondaryInstitutionLevelTypeId;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int postSecondaryInstitutionLevelTypeId)
        {
            var request = new Api.Models.Requests.v2.PostSecondaryInstitutionLevelTypes.PostSecondaryInstitutionLevelTypeGetByKey
            {
                PostSecondaryInstitutionLevelTypeId = postSecondaryInstitutionLevelTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IPostSecondaryInstitutionLevelType request)
        {
            return 
                request.PostSecondaryInstitutionLevelTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "postSecondaryInstitutionLevelTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.Programs
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class ProgramsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.Program.Program, 
        EdFi.Ods.Api.Models.Resources.V2.Program.Program, 
        EdFi.Ods.Entities.Common.IProgram, 
        // EdFi.Ods.Entities.NHibernate.ProgramAggregate.Program, 
        Api.Models.Requests.v2.Programs.ProgramGetByKey, 
        Api.Models.Requests.v2.Programs.ProgramPut,
        Api.Models.Requests.v2.Programs.ProgramPost,
        Api.Models.Requests.v2.Programs.ProgramDelete,
        Api.Models.Requests.v2.Programs.ProgramGetByExample>
    {
        public ProgramsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.Programs.ProgramGetByKey request, IProgram specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.ProgramName = request.Name;
            specification.ProgramType = request.Type;
                    }

        protected override void MapAll(Api.Models.Requests.v2.Programs.ProgramGetByExample request, IProgram specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.Id = request.Id;
            specification.ProgramId = request.ProgramId;
            specification.ProgramName = request.Name;
            specification.ProgramSponsorType = request.SponsorType;
            specification.ProgramType = request.Type;
                    }
                public IHttpActionResult GetByKey([FromUri] int educationOrganizationId, string name, string type)
        {
            var request = new Api.Models.Requests.v2.Programs.ProgramGetByKey
            {
                EducationOrganizationId = educationOrganizationId,
                Name = name,
                Type = type,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IProgram request)
        {
            return 
                request.EducationOrganizationId != default(int)
                && request.ProgramName != default(string)
                && request.ProgramType != null;
        }

        protected override string GetResourceCollectionName()
        {
            return "programs";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.ProgramAssignmentDescriptors
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class ProgramAssignmentDescriptorsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.ProgramAssignmentDescriptor.ProgramAssignmentDescriptor, 
        EdFi.Ods.Api.Models.Resources.V2.ProgramAssignmentDescriptor.ProgramAssignmentDescriptor, 
        EdFi.Ods.Entities.Common.IProgramAssignmentDescriptor, 
        // EdFi.Ods.Entities.NHibernate.ProgramAssignmentDescriptorAggregate.ProgramAssignmentDescriptor, 
        Api.Models.Requests.v2.ProgramAssignmentDescriptors.ProgramAssignmentDescriptorGetByKey, 
        Api.Models.Requests.v2.ProgramAssignmentDescriptors.ProgramAssignmentDescriptorPut,
        Api.Models.Requests.v2.ProgramAssignmentDescriptors.ProgramAssignmentDescriptorPost,
        Api.Models.Requests.v2.ProgramAssignmentDescriptors.ProgramAssignmentDescriptorDelete,
        Api.Models.Requests.v2.ProgramAssignmentDescriptors.ProgramAssignmentDescriptorGetByExample>
    {
        public ProgramAssignmentDescriptorsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.ProgramAssignmentDescriptors.ProgramAssignmentDescriptorGetByKey request, IProgramAssignmentDescriptor specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.ProgramAssignmentDescriptorId = request.ProgramAssignmentDescriptorId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.ProgramAssignmentDescriptors.ProgramAssignmentDescriptorGetByExample request, IProgramAssignmentDescriptor specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.ProgramAssignmentDescriptorId = request.ProgramAssignmentDescriptorId;
            specification.ProgramAssignmentType = request.ProgramAssignmentType;
                    }
                public IHttpActionResult GetByKey([FromUri] int programAssignmentDescriptorId)
        {
            var request = new Api.Models.Requests.v2.ProgramAssignmentDescriptors.ProgramAssignmentDescriptorGetByKey
            {
                ProgramAssignmentDescriptorId = programAssignmentDescriptorId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IProgramAssignmentDescriptor request)
        {
            return 
                request.ProgramAssignmentDescriptorId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "programAssignmentDescriptors";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.ProgramAssignmentTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class ProgramAssignmentTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.ProgramAssignmentType.ProgramAssignmentType, 
        EdFi.Ods.Api.Models.Resources.V2.ProgramAssignmentType.ProgramAssignmentType, 
        EdFi.Ods.Entities.Common.IProgramAssignmentType, 
        // EdFi.Ods.Entities.NHibernate.ProgramAssignmentTypeAggregate.ProgramAssignmentType, 
        Api.Models.Requests.v2.ProgramAssignmentTypes.ProgramAssignmentTypeGetByKey, 
        Api.Models.Requests.v2.ProgramAssignmentTypes.ProgramAssignmentTypePut,
        Api.Models.Requests.v2.ProgramAssignmentTypes.ProgramAssignmentTypePost,
        Api.Models.Requests.v2.ProgramAssignmentTypes.ProgramAssignmentTypeDelete,
        Api.Models.Requests.v2.ProgramAssignmentTypes.ProgramAssignmentTypeGetByExample>
    {
        public ProgramAssignmentTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.ProgramAssignmentTypes.ProgramAssignmentTypeGetByKey request, IProgramAssignmentType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.ProgramAssignmentTypeId = request.ProgramAssignmentTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.ProgramAssignmentTypes.ProgramAssignmentTypeGetByExample request, IProgramAssignmentType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.ProgramAssignmentTypeId = request.ProgramAssignmentTypeId;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int programAssignmentTypeId)
        {
            var request = new Api.Models.Requests.v2.ProgramAssignmentTypes.ProgramAssignmentTypeGetByKey
            {
                ProgramAssignmentTypeId = programAssignmentTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IProgramAssignmentType request)
        {
            return 
                request.ProgramAssignmentTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "programAssignmentTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.ProgramCharacteristicDescriptors
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class ProgramCharacteristicDescriptorsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.ProgramCharacteristicDescriptor.ProgramCharacteristicDescriptor, 
        EdFi.Ods.Api.Models.Resources.V2.ProgramCharacteristicDescriptor.ProgramCharacteristicDescriptor, 
        EdFi.Ods.Entities.Common.IProgramCharacteristicDescriptor, 
        // EdFi.Ods.Entities.NHibernate.ProgramCharacteristicDescriptorAggregate.ProgramCharacteristicDescriptor, 
        Api.Models.Requests.v2.ProgramCharacteristicDescriptors.ProgramCharacteristicDescriptorGetByKey, 
        Api.Models.Requests.v2.ProgramCharacteristicDescriptors.ProgramCharacteristicDescriptorPut,
        Api.Models.Requests.v2.ProgramCharacteristicDescriptors.ProgramCharacteristicDescriptorPost,
        Api.Models.Requests.v2.ProgramCharacteristicDescriptors.ProgramCharacteristicDescriptorDelete,
        Api.Models.Requests.v2.ProgramCharacteristicDescriptors.ProgramCharacteristicDescriptorGetByExample>
    {
        public ProgramCharacteristicDescriptorsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.ProgramCharacteristicDescriptors.ProgramCharacteristicDescriptorGetByKey request, IProgramCharacteristicDescriptor specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.ProgramCharacteristicDescriptorId = request.ProgramCharacteristicDescriptorId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.ProgramCharacteristicDescriptors.ProgramCharacteristicDescriptorGetByExample request, IProgramCharacteristicDescriptor specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.ProgramCharacteristicDescriptorId = request.ProgramCharacteristicDescriptorId;
            specification.ProgramCharacteristicType = request.ProgramCharacteristicType;
                    }
                public IHttpActionResult GetByKey([FromUri] int programCharacteristicDescriptorId)
        {
            var request = new Api.Models.Requests.v2.ProgramCharacteristicDescriptors.ProgramCharacteristicDescriptorGetByKey
            {
                ProgramCharacteristicDescriptorId = programCharacteristicDescriptorId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IProgramCharacteristicDescriptor request)
        {
            return 
                request.ProgramCharacteristicDescriptorId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "programCharacteristicDescriptors";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.ProgramCharacteristicTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class ProgramCharacteristicTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.ProgramCharacteristicType.ProgramCharacteristicType, 
        EdFi.Ods.Api.Models.Resources.V2.ProgramCharacteristicType.ProgramCharacteristicType, 
        EdFi.Ods.Entities.Common.IProgramCharacteristicType, 
        // EdFi.Ods.Entities.NHibernate.ProgramCharacteristicTypeAggregate.ProgramCharacteristicType, 
        Api.Models.Requests.v2.ProgramCharacteristicTypes.ProgramCharacteristicTypeGetByKey, 
        Api.Models.Requests.v2.ProgramCharacteristicTypes.ProgramCharacteristicTypePut,
        Api.Models.Requests.v2.ProgramCharacteristicTypes.ProgramCharacteristicTypePost,
        Api.Models.Requests.v2.ProgramCharacteristicTypes.ProgramCharacteristicTypeDelete,
        Api.Models.Requests.v2.ProgramCharacteristicTypes.ProgramCharacteristicTypeGetByExample>
    {
        public ProgramCharacteristicTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.ProgramCharacteristicTypes.ProgramCharacteristicTypeGetByKey request, IProgramCharacteristicType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.ProgramCharacteristicTypeId = request.ProgramCharacteristicTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.ProgramCharacteristicTypes.ProgramCharacteristicTypeGetByExample request, IProgramCharacteristicType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.ProgramCharacteristicTypeId = request.ProgramCharacteristicTypeId;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int programCharacteristicTypeId)
        {
            var request = new Api.Models.Requests.v2.ProgramCharacteristicTypes.ProgramCharacteristicTypeGetByKey
            {
                ProgramCharacteristicTypeId = programCharacteristicTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IProgramCharacteristicType request)
        {
            return 
                request.ProgramCharacteristicTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "programCharacteristicTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.ProgramSponsorTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class ProgramSponsorTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.ProgramSponsorType.ProgramSponsorType, 
        EdFi.Ods.Api.Models.Resources.V2.ProgramSponsorType.ProgramSponsorType, 
        EdFi.Ods.Entities.Common.IProgramSponsorType, 
        // EdFi.Ods.Entities.NHibernate.ProgramSponsorTypeAggregate.ProgramSponsorType, 
        Api.Models.Requests.v2.ProgramSponsorTypes.ProgramSponsorTypeGetByKey, 
        Api.Models.Requests.v2.ProgramSponsorTypes.ProgramSponsorTypePut,
        Api.Models.Requests.v2.ProgramSponsorTypes.ProgramSponsorTypePost,
        Api.Models.Requests.v2.ProgramSponsorTypes.ProgramSponsorTypeDelete,
        Api.Models.Requests.v2.ProgramSponsorTypes.ProgramSponsorTypeGetByExample>
    {
        public ProgramSponsorTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.ProgramSponsorTypes.ProgramSponsorTypeGetByKey request, IProgramSponsorType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.ProgramSponsorTypeId = request.ProgramSponsorTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.ProgramSponsorTypes.ProgramSponsorTypeGetByExample request, IProgramSponsorType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.ProgramSponsorTypeId = request.ProgramSponsorTypeId;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int programSponsorTypeId)
        {
            var request = new Api.Models.Requests.v2.ProgramSponsorTypes.ProgramSponsorTypeGetByKey
            {
                ProgramSponsorTypeId = programSponsorTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IProgramSponsorType request)
        {
            return 
                request.ProgramSponsorTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "programSponsorTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.ProgramTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class ProgramTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.ProgramType.ProgramType, 
        EdFi.Ods.Api.Models.Resources.V2.ProgramType.ProgramType, 
        EdFi.Ods.Entities.Common.IProgramType, 
        // EdFi.Ods.Entities.NHibernate.ProgramTypeAggregate.ProgramType, 
        Api.Models.Requests.v2.ProgramTypes.ProgramTypeGetByKey, 
        Api.Models.Requests.v2.ProgramTypes.ProgramTypePut,
        Api.Models.Requests.v2.ProgramTypes.ProgramTypePost,
        Api.Models.Requests.v2.ProgramTypes.ProgramTypeDelete,
        Api.Models.Requests.v2.ProgramTypes.ProgramTypeGetByExample>
    {
        public ProgramTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.ProgramTypes.ProgramTypeGetByKey request, IProgramType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.ProgramTypeId = request.ProgramTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.ProgramTypes.ProgramTypeGetByExample request, IProgramType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.ProgramTypeId = request.ProgramTypeId;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int programTypeId)
        {
            var request = new Api.Models.Requests.v2.ProgramTypes.ProgramTypeGetByKey
            {
                ProgramTypeId = programTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IProgramType request)
        {
            return 
                request.ProgramTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "programTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.PublicationStatusTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class PublicationStatusTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.PublicationStatusType.PublicationStatusType, 
        EdFi.Ods.Api.Models.Resources.V2.PublicationStatusType.PublicationStatusType, 
        EdFi.Ods.Entities.Common.IPublicationStatusType, 
        // EdFi.Ods.Entities.NHibernate.PublicationStatusTypeAggregate.PublicationStatusType, 
        Api.Models.Requests.v2.PublicationStatusTypes.PublicationStatusTypeGetByKey, 
        Api.Models.Requests.v2.PublicationStatusTypes.PublicationStatusTypePut,
        Api.Models.Requests.v2.PublicationStatusTypes.PublicationStatusTypePost,
        Api.Models.Requests.v2.PublicationStatusTypes.PublicationStatusTypeDelete,
        Api.Models.Requests.v2.PublicationStatusTypes.PublicationStatusTypeGetByExample>
    {
        public PublicationStatusTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.PublicationStatusTypes.PublicationStatusTypeGetByKey request, IPublicationStatusType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.PublicationStatusTypeId = request.PublicationStatusTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.PublicationStatusTypes.PublicationStatusTypeGetByExample request, IPublicationStatusType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.PublicationStatusTypeId = request.PublicationStatusTypeId;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int publicationStatusTypeId)
        {
            var request = new Api.Models.Requests.v2.PublicationStatusTypes.PublicationStatusTypeGetByKey
            {
                PublicationStatusTypeId = publicationStatusTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IPublicationStatusType request)
        {
            return 
                request.PublicationStatusTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "publicationStatusTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.RaceTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class RaceTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.RaceType.RaceType, 
        EdFi.Ods.Api.Models.Resources.V2.RaceType.RaceType, 
        EdFi.Ods.Entities.Common.IRaceType, 
        // EdFi.Ods.Entities.NHibernate.RaceTypeAggregate.RaceType, 
        Api.Models.Requests.v2.RaceTypes.RaceTypeGetByKey, 
        Api.Models.Requests.v2.RaceTypes.RaceTypePut,
        Api.Models.Requests.v2.RaceTypes.RaceTypePost,
        Api.Models.Requests.v2.RaceTypes.RaceTypeDelete,
        Api.Models.Requests.v2.RaceTypes.RaceTypeGetByExample>
    {
        public RaceTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.RaceTypes.RaceTypeGetByKey request, IRaceType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.RaceTypeId = request.RaceTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.RaceTypes.RaceTypeGetByExample request, IRaceType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.RaceTypeId = request.RaceTypeId;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int raceTypeId)
        {
            var request = new Api.Models.Requests.v2.RaceTypes.RaceTypeGetByKey
            {
                RaceTypeId = raceTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IRaceType request)
        {
            return 
                request.RaceTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "raceTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.ReasonExitedDescriptors
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class ReasonExitedDescriptorsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.ReasonExitedDescriptor.ReasonExitedDescriptor, 
        EdFi.Ods.Api.Models.Resources.V2.ReasonExitedDescriptor.ReasonExitedDescriptor, 
        EdFi.Ods.Entities.Common.IReasonExitedDescriptor, 
        // EdFi.Ods.Entities.NHibernate.ReasonExitedDescriptorAggregate.ReasonExitedDescriptor, 
        Api.Models.Requests.v2.ReasonExitedDescriptors.ReasonExitedDescriptorGetByKey, 
        Api.Models.Requests.v2.ReasonExitedDescriptors.ReasonExitedDescriptorPut,
        Api.Models.Requests.v2.ReasonExitedDescriptors.ReasonExitedDescriptorPost,
        Api.Models.Requests.v2.ReasonExitedDescriptors.ReasonExitedDescriptorDelete,
        Api.Models.Requests.v2.ReasonExitedDescriptors.ReasonExitedDescriptorGetByExample>
    {
        public ReasonExitedDescriptorsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.ReasonExitedDescriptors.ReasonExitedDescriptorGetByKey request, IReasonExitedDescriptor specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.ReasonExitedDescriptorId = request.ReasonExitedDescriptorId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.ReasonExitedDescriptors.ReasonExitedDescriptorGetByExample request, IReasonExitedDescriptor specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.ReasonExitedDescriptorId = request.ReasonExitedDescriptorId;
            specification.ReasonExitedType = request.ReasonExitedType;
                    }
                public IHttpActionResult GetByKey([FromUri] int reasonExitedDescriptorId)
        {
            var request = new Api.Models.Requests.v2.ReasonExitedDescriptors.ReasonExitedDescriptorGetByKey
            {
                ReasonExitedDescriptorId = reasonExitedDescriptorId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IReasonExitedDescriptor request)
        {
            return 
                request.ReasonExitedDescriptorId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "reasonExitedDescriptors";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.ReasonExitedTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class ReasonExitedTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.ReasonExitedType.ReasonExitedType, 
        EdFi.Ods.Api.Models.Resources.V2.ReasonExitedType.ReasonExitedType, 
        EdFi.Ods.Entities.Common.IReasonExitedType, 
        // EdFi.Ods.Entities.NHibernate.ReasonExitedTypeAggregate.ReasonExitedType, 
        Api.Models.Requests.v2.ReasonExitedTypes.ReasonExitedTypeGetByKey, 
        Api.Models.Requests.v2.ReasonExitedTypes.ReasonExitedTypePut,
        Api.Models.Requests.v2.ReasonExitedTypes.ReasonExitedTypePost,
        Api.Models.Requests.v2.ReasonExitedTypes.ReasonExitedTypeDelete,
        Api.Models.Requests.v2.ReasonExitedTypes.ReasonExitedTypeGetByExample>
    {
        public ReasonExitedTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.ReasonExitedTypes.ReasonExitedTypeGetByKey request, IReasonExitedType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.ReasonExitedTypeId = request.ReasonExitedTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.ReasonExitedTypes.ReasonExitedTypeGetByExample request, IReasonExitedType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.ReasonExitedTypeId = request.ReasonExitedTypeId;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int reasonExitedTypeId)
        {
            var request = new Api.Models.Requests.v2.ReasonExitedTypes.ReasonExitedTypeGetByKey
            {
                ReasonExitedTypeId = reasonExitedTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IReasonExitedType request)
        {
            return 
                request.ReasonExitedTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "reasonExitedTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.ReasonNotTestedTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class ReasonNotTestedTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.ReasonNotTestedType.ReasonNotTestedType, 
        EdFi.Ods.Api.Models.Resources.V2.ReasonNotTestedType.ReasonNotTestedType, 
        EdFi.Ods.Entities.Common.IReasonNotTestedType, 
        // EdFi.Ods.Entities.NHibernate.ReasonNotTestedTypeAggregate.ReasonNotTestedType, 
        Api.Models.Requests.v2.ReasonNotTestedTypes.ReasonNotTestedTypeGetByKey, 
        Api.Models.Requests.v2.ReasonNotTestedTypes.ReasonNotTestedTypePut,
        Api.Models.Requests.v2.ReasonNotTestedTypes.ReasonNotTestedTypePost,
        Api.Models.Requests.v2.ReasonNotTestedTypes.ReasonNotTestedTypeDelete,
        Api.Models.Requests.v2.ReasonNotTestedTypes.ReasonNotTestedTypeGetByExample>
    {
        public ReasonNotTestedTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.ReasonNotTestedTypes.ReasonNotTestedTypeGetByKey request, IReasonNotTestedType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.ReasonNotTestedTypeId = request.ReasonNotTestedTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.ReasonNotTestedTypes.ReasonNotTestedTypeGetByExample request, IReasonNotTestedType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.ReasonNotTestedTypeId = request.ReasonNotTestedTypeId;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int reasonNotTestedTypeId)
        {
            var request = new Api.Models.Requests.v2.ReasonNotTestedTypes.ReasonNotTestedTypeGetByKey
            {
                ReasonNotTestedTypeId = reasonNotTestedTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IReasonNotTestedType request)
        {
            return 
                request.ReasonNotTestedTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "reasonNotTestedTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.RecognitionTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class RecognitionTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.RecognitionType.RecognitionType, 
        EdFi.Ods.Api.Models.Resources.V2.RecognitionType.RecognitionType, 
        EdFi.Ods.Entities.Common.IRecognitionType, 
        // EdFi.Ods.Entities.NHibernate.RecognitionTypeAggregate.RecognitionType, 
        Api.Models.Requests.v2.RecognitionTypes.RecognitionTypeGetByKey, 
        Api.Models.Requests.v2.RecognitionTypes.RecognitionTypePut,
        Api.Models.Requests.v2.RecognitionTypes.RecognitionTypePost,
        Api.Models.Requests.v2.RecognitionTypes.RecognitionTypeDelete,
        Api.Models.Requests.v2.RecognitionTypes.RecognitionTypeGetByExample>
    {
        public RecognitionTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.RecognitionTypes.RecognitionTypeGetByKey request, IRecognitionType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.RecognitionTypeId = request.RecognitionTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.RecognitionTypes.RecognitionTypeGetByExample request, IRecognitionType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.RecognitionTypeId = request.RecognitionTypeId;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int recognitionTypeId)
        {
            var request = new Api.Models.Requests.v2.RecognitionTypes.RecognitionTypeGetByKey
            {
                RecognitionTypeId = recognitionTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IRecognitionType request)
        {
            return 
                request.RecognitionTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "recognitionTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.RelationTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class RelationTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.RelationType.RelationType, 
        EdFi.Ods.Api.Models.Resources.V2.RelationType.RelationType, 
        EdFi.Ods.Entities.Common.IRelationType, 
        // EdFi.Ods.Entities.NHibernate.RelationTypeAggregate.RelationType, 
        Api.Models.Requests.v2.RelationTypes.RelationTypeGetByKey, 
        Api.Models.Requests.v2.RelationTypes.RelationTypePut,
        Api.Models.Requests.v2.RelationTypes.RelationTypePost,
        Api.Models.Requests.v2.RelationTypes.RelationTypeDelete,
        Api.Models.Requests.v2.RelationTypes.RelationTypeGetByExample>
    {
        public RelationTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.RelationTypes.RelationTypeGetByKey request, IRelationType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.RelationTypeId = request.RelationTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.RelationTypes.RelationTypeGetByExample request, IRelationType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.RelationTypeId = request.RelationTypeId;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int relationTypeId)
        {
            var request = new Api.Models.Requests.v2.RelationTypes.RelationTypeGetByKey
            {
                RelationTypeId = relationTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IRelationType request)
        {
            return 
                request.RelationTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "relationTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.RepeatIdentifierTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class RepeatIdentifierTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.RepeatIdentifierType.RepeatIdentifierType, 
        EdFi.Ods.Api.Models.Resources.V2.RepeatIdentifierType.RepeatIdentifierType, 
        EdFi.Ods.Entities.Common.IRepeatIdentifierType, 
        // EdFi.Ods.Entities.NHibernate.RepeatIdentifierTypeAggregate.RepeatIdentifierType, 
        Api.Models.Requests.v2.RepeatIdentifierTypes.RepeatIdentifierTypeGetByKey, 
        Api.Models.Requests.v2.RepeatIdentifierTypes.RepeatIdentifierTypePut,
        Api.Models.Requests.v2.RepeatIdentifierTypes.RepeatIdentifierTypePost,
        Api.Models.Requests.v2.RepeatIdentifierTypes.RepeatIdentifierTypeDelete,
        Api.Models.Requests.v2.RepeatIdentifierTypes.RepeatIdentifierTypeGetByExample>
    {
        public RepeatIdentifierTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.RepeatIdentifierTypes.RepeatIdentifierTypeGetByKey request, IRepeatIdentifierType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.RepeatIdentifierTypeId = request.RepeatIdentifierTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.RepeatIdentifierTypes.RepeatIdentifierTypeGetByExample request, IRepeatIdentifierType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.RepeatIdentifierTypeId = request.RepeatIdentifierTypeId;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int repeatIdentifierTypeId)
        {
            var request = new Api.Models.Requests.v2.RepeatIdentifierTypes.RepeatIdentifierTypeGetByKey
            {
                RepeatIdentifierTypeId = repeatIdentifierTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IRepeatIdentifierType request)
        {
            return 
                request.RepeatIdentifierTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "repeatIdentifierTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.ReportCards
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class ReportCardsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.ReportCard.ReportCard, 
        EdFi.Ods.Api.Models.Resources.V2.ReportCard.ReportCard, 
        EdFi.Ods.Entities.Common.IReportCard, 
        // EdFi.Ods.Entities.NHibernate.ReportCardAggregate.ReportCard, 
        Api.Models.Requests.v2.ReportCards.ReportCardGetByKey, 
        Api.Models.Requests.v2.ReportCards.ReportCardPut,
        Api.Models.Requests.v2.ReportCards.ReportCardPost,
        Api.Models.Requests.v2.ReportCards.ReportCardDelete,
        Api.Models.Requests.v2.ReportCards.ReportCardGetByExample>
    {
        public ReportCardsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.ReportCards.ReportCardGetByKey request, IReportCard specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.GradingPeriodBeginDate = request.GradingPeriodBeginDate;
            specification.GradingPeriodDescriptor = request.GradingPeriodDescriptor;
            specification.SchoolId = request.SchoolId;
            specification.StudentUniqueId = request.StudentUniqueId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.ReportCards.ReportCardGetByExample request, IReportCard specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.GPACumulative = request.GPACumulative;
            specification.GPAGivenGradingPeriod = request.GPAGivenGradingPeriod;
            specification.GradingPeriodBeginDate = request.GradingPeriodBeginDate;
            specification.GradingPeriodDescriptor = request.GradingPeriodDescriptor;
            specification.Id = request.Id;
            specification.NumberOfDaysAbsent = request.NumberOfDaysAbsent;
            specification.NumberOfDaysInAttendance = request.NumberOfDaysInAttendance;
            specification.NumberOfDaysTardy = request.NumberOfDaysTardy;
            specification.SchoolId = request.SchoolId;
            specification.StudentUniqueId = request.StudentUniqueId;
                    }
                public IHttpActionResult GetByKey([FromUri] int educationOrganizationId, DateTime gradingPeriodBeginDate, string gradingPeriodDescriptor, int schoolId, string studentUniqueId)
        {
            var request = new Api.Models.Requests.v2.ReportCards.ReportCardGetByKey
            {
                EducationOrganizationId = educationOrganizationId,
                GradingPeriodBeginDate = gradingPeriodBeginDate,
                GradingPeriodDescriptor = gradingPeriodDescriptor,
                SchoolId = schoolId,
                StudentUniqueId = studentUniqueId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IReportCard request)
        {
            return 
                request.EducationOrganizationId != default(int)
                && request.GradingPeriodBeginDate != default(DateTime)
                && request.GradingPeriodDescriptor != null
                && request.SchoolId != default(int)
                && request.StudentUniqueId != default(string);
        }

        protected override string GetResourceCollectionName()
        {
            return "reportCards";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.ReporterDescriptionDescriptors
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class ReporterDescriptionDescriptorsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.ReporterDescriptionDescriptor.ReporterDescriptionDescriptor, 
        EdFi.Ods.Api.Models.Resources.V2.ReporterDescriptionDescriptor.ReporterDescriptionDescriptor, 
        EdFi.Ods.Entities.Common.IReporterDescriptionDescriptor, 
        // EdFi.Ods.Entities.NHibernate.ReporterDescriptionDescriptorAggregate.ReporterDescriptionDescriptor, 
        Api.Models.Requests.v2.ReporterDescriptionDescriptors.ReporterDescriptionDescriptorGetByKey, 
        Api.Models.Requests.v2.ReporterDescriptionDescriptors.ReporterDescriptionDescriptorPut,
        Api.Models.Requests.v2.ReporterDescriptionDescriptors.ReporterDescriptionDescriptorPost,
        Api.Models.Requests.v2.ReporterDescriptionDescriptors.ReporterDescriptionDescriptorDelete,
        Api.Models.Requests.v2.ReporterDescriptionDescriptors.ReporterDescriptionDescriptorGetByExample>
    {
        public ReporterDescriptionDescriptorsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.ReporterDescriptionDescriptors.ReporterDescriptionDescriptorGetByKey request, IReporterDescriptionDescriptor specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.ReporterDescriptionDescriptorId = request.ReporterDescriptionDescriptorId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.ReporterDescriptionDescriptors.ReporterDescriptionDescriptorGetByExample request, IReporterDescriptionDescriptor specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.ReporterDescriptionDescriptorId = request.ReporterDescriptionDescriptorId;
            specification.ReporterDescriptionType = request.ReporterDescriptionType;
                    }
                public IHttpActionResult GetByKey([FromUri] int reporterDescriptionDescriptorId)
        {
            var request = new Api.Models.Requests.v2.ReporterDescriptionDescriptors.ReporterDescriptionDescriptorGetByKey
            {
                ReporterDescriptionDescriptorId = reporterDescriptionDescriptorId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IReporterDescriptionDescriptor request)
        {
            return 
                request.ReporterDescriptionDescriptorId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "reporterDescriptionDescriptors";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.ReporterDescriptionTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class ReporterDescriptionTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.ReporterDescriptionType.ReporterDescriptionType, 
        EdFi.Ods.Api.Models.Resources.V2.ReporterDescriptionType.ReporterDescriptionType, 
        EdFi.Ods.Entities.Common.IReporterDescriptionType, 
        // EdFi.Ods.Entities.NHibernate.ReporterDescriptionTypeAggregate.ReporterDescriptionType, 
        Api.Models.Requests.v2.ReporterDescriptionTypes.ReporterDescriptionTypeGetByKey, 
        Api.Models.Requests.v2.ReporterDescriptionTypes.ReporterDescriptionTypePut,
        Api.Models.Requests.v2.ReporterDescriptionTypes.ReporterDescriptionTypePost,
        Api.Models.Requests.v2.ReporterDescriptionTypes.ReporterDescriptionTypeDelete,
        Api.Models.Requests.v2.ReporterDescriptionTypes.ReporterDescriptionTypeGetByExample>
    {
        public ReporterDescriptionTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.ReporterDescriptionTypes.ReporterDescriptionTypeGetByKey request, IReporterDescriptionType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.ReporterDescriptionTypeId = request.ReporterDescriptionTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.ReporterDescriptionTypes.ReporterDescriptionTypeGetByExample request, IReporterDescriptionType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.ReporterDescriptionTypeId = request.ReporterDescriptionTypeId;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int reporterDescriptionTypeId)
        {
            var request = new Api.Models.Requests.v2.ReporterDescriptionTypes.ReporterDescriptionTypeGetByKey
            {
                ReporterDescriptionTypeId = reporterDescriptionTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IReporterDescriptionType request)
        {
            return 
                request.ReporterDescriptionTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "reporterDescriptionTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.ResidencyStatusDescriptors
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class ResidencyStatusDescriptorsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.ResidencyStatusDescriptor.ResidencyStatusDescriptor, 
        EdFi.Ods.Api.Models.Resources.V2.ResidencyStatusDescriptor.ResidencyStatusDescriptor, 
        EdFi.Ods.Entities.Common.IResidencyStatusDescriptor, 
        // EdFi.Ods.Entities.NHibernate.ResidencyStatusDescriptorAggregate.ResidencyStatusDescriptor, 
        Api.Models.Requests.v2.ResidencyStatusDescriptors.ResidencyStatusDescriptorGetByKey, 
        Api.Models.Requests.v2.ResidencyStatusDescriptors.ResidencyStatusDescriptorPut,
        Api.Models.Requests.v2.ResidencyStatusDescriptors.ResidencyStatusDescriptorPost,
        Api.Models.Requests.v2.ResidencyStatusDescriptors.ResidencyStatusDescriptorDelete,
        Api.Models.Requests.v2.ResidencyStatusDescriptors.ResidencyStatusDescriptorGetByExample>
    {
        public ResidencyStatusDescriptorsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.ResidencyStatusDescriptors.ResidencyStatusDescriptorGetByKey request, IResidencyStatusDescriptor specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.ResidencyStatusDescriptorId = request.ResidencyStatusDescriptorId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.ResidencyStatusDescriptors.ResidencyStatusDescriptorGetByExample request, IResidencyStatusDescriptor specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.ResidencyStatusDescriptorId = request.ResidencyStatusDescriptorId;
            specification.ResidencyStatusType = request.ResidencyStatusType;
                    }
                public IHttpActionResult GetByKey([FromUri] int residencyStatusDescriptorId)
        {
            var request = new Api.Models.Requests.v2.ResidencyStatusDescriptors.ResidencyStatusDescriptorGetByKey
            {
                ResidencyStatusDescriptorId = residencyStatusDescriptorId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IResidencyStatusDescriptor request)
        {
            return 
                request.ResidencyStatusDescriptorId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "residencyStatusDescriptors";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.ResidencyStatusTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class ResidencyStatusTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.ResidencyStatusType.ResidencyStatusType, 
        EdFi.Ods.Api.Models.Resources.V2.ResidencyStatusType.ResidencyStatusType, 
        EdFi.Ods.Entities.Common.IResidencyStatusType, 
        // EdFi.Ods.Entities.NHibernate.ResidencyStatusTypeAggregate.ResidencyStatusType, 
        Api.Models.Requests.v2.ResidencyStatusTypes.ResidencyStatusTypeGetByKey, 
        Api.Models.Requests.v2.ResidencyStatusTypes.ResidencyStatusTypePut,
        Api.Models.Requests.v2.ResidencyStatusTypes.ResidencyStatusTypePost,
        Api.Models.Requests.v2.ResidencyStatusTypes.ResidencyStatusTypeDelete,
        Api.Models.Requests.v2.ResidencyStatusTypes.ResidencyStatusTypeGetByExample>
    {
        public ResidencyStatusTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.ResidencyStatusTypes.ResidencyStatusTypeGetByKey request, IResidencyStatusType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.ResidencyStatusTypeId = request.ResidencyStatusTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.ResidencyStatusTypes.ResidencyStatusTypeGetByExample request, IResidencyStatusType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.ResidencyStatusTypeId = request.ResidencyStatusTypeId;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int residencyStatusTypeId)
        {
            var request = new Api.Models.Requests.v2.ResidencyStatusTypes.ResidencyStatusTypeGetByKey
            {
                ResidencyStatusTypeId = residencyStatusTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IResidencyStatusType request)
        {
            return 
                request.ResidencyStatusTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "residencyStatusTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.ResponseIndicatorTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class ResponseIndicatorTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.ResponseIndicatorType.ResponseIndicatorType, 
        EdFi.Ods.Api.Models.Resources.V2.ResponseIndicatorType.ResponseIndicatorType, 
        EdFi.Ods.Entities.Common.IResponseIndicatorType, 
        // EdFi.Ods.Entities.NHibernate.ResponseIndicatorTypeAggregate.ResponseIndicatorType, 
        Api.Models.Requests.v2.ResponseIndicatorTypes.ResponseIndicatorTypeGetByKey, 
        Api.Models.Requests.v2.ResponseIndicatorTypes.ResponseIndicatorTypePut,
        Api.Models.Requests.v2.ResponseIndicatorTypes.ResponseIndicatorTypePost,
        Api.Models.Requests.v2.ResponseIndicatorTypes.ResponseIndicatorTypeDelete,
        Api.Models.Requests.v2.ResponseIndicatorTypes.ResponseIndicatorTypeGetByExample>
    {
        public ResponseIndicatorTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.ResponseIndicatorTypes.ResponseIndicatorTypeGetByKey request, IResponseIndicatorType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.ResponseIndicatorTypeId = request.ResponseIndicatorTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.ResponseIndicatorTypes.ResponseIndicatorTypeGetByExample request, IResponseIndicatorType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.ResponseIndicatorTypeId = request.ResponseIndicatorTypeId;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int responseIndicatorTypeId)
        {
            var request = new Api.Models.Requests.v2.ResponseIndicatorTypes.ResponseIndicatorTypeGetByKey
            {
                ResponseIndicatorTypeId = responseIndicatorTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IResponseIndicatorType request)
        {
            return 
                request.ResponseIndicatorTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "responseIndicatorTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.ResponsibilityDescriptors
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class ResponsibilityDescriptorsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.ResponsibilityDescriptor.ResponsibilityDescriptor, 
        EdFi.Ods.Api.Models.Resources.V2.ResponsibilityDescriptor.ResponsibilityDescriptor, 
        EdFi.Ods.Entities.Common.IResponsibilityDescriptor, 
        // EdFi.Ods.Entities.NHibernate.ResponsibilityDescriptorAggregate.ResponsibilityDescriptor, 
        Api.Models.Requests.v2.ResponsibilityDescriptors.ResponsibilityDescriptorGetByKey, 
        Api.Models.Requests.v2.ResponsibilityDescriptors.ResponsibilityDescriptorPut,
        Api.Models.Requests.v2.ResponsibilityDescriptors.ResponsibilityDescriptorPost,
        Api.Models.Requests.v2.ResponsibilityDescriptors.ResponsibilityDescriptorDelete,
        Api.Models.Requests.v2.ResponsibilityDescriptors.ResponsibilityDescriptorGetByExample>
    {
        public ResponsibilityDescriptorsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.ResponsibilityDescriptors.ResponsibilityDescriptorGetByKey request, IResponsibilityDescriptor specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.ResponsibilityDescriptorId = request.ResponsibilityDescriptorId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.ResponsibilityDescriptors.ResponsibilityDescriptorGetByExample request, IResponsibilityDescriptor specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.ResponsibilityDescriptorId = request.ResponsibilityDescriptorId;
            specification.ResponsibilityType = request.ResponsibilityType;
                    }
                public IHttpActionResult GetByKey([FromUri] int responsibilityDescriptorId)
        {
            var request = new Api.Models.Requests.v2.ResponsibilityDescriptors.ResponsibilityDescriptorGetByKey
            {
                ResponsibilityDescriptorId = responsibilityDescriptorId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IResponsibilityDescriptor request)
        {
            return 
                request.ResponsibilityDescriptorId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "responsibilityDescriptors";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.ResponsibilityTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class ResponsibilityTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.ResponsibilityType.ResponsibilityType, 
        EdFi.Ods.Api.Models.Resources.V2.ResponsibilityType.ResponsibilityType, 
        EdFi.Ods.Entities.Common.IResponsibilityType, 
        // EdFi.Ods.Entities.NHibernate.ResponsibilityTypeAggregate.ResponsibilityType, 
        Api.Models.Requests.v2.ResponsibilityTypes.ResponsibilityTypeGetByKey, 
        Api.Models.Requests.v2.ResponsibilityTypes.ResponsibilityTypePut,
        Api.Models.Requests.v2.ResponsibilityTypes.ResponsibilityTypePost,
        Api.Models.Requests.v2.ResponsibilityTypes.ResponsibilityTypeDelete,
        Api.Models.Requests.v2.ResponsibilityTypes.ResponsibilityTypeGetByExample>
    {
        public ResponsibilityTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.ResponsibilityTypes.ResponsibilityTypeGetByKey request, IResponsibilityType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.ResponsibilityTypeId = request.ResponsibilityTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.ResponsibilityTypes.ResponsibilityTypeGetByExample request, IResponsibilityType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.ResponsibilityTypeId = request.ResponsibilityTypeId;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int responsibilityTypeId)
        {
            var request = new Api.Models.Requests.v2.ResponsibilityTypes.ResponsibilityTypeGetByKey
            {
                ResponsibilityTypeId = responsibilityTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IResponsibilityType request)
        {
            return 
                request.ResponsibilityTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "responsibilityTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.RestraintEvents
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class RestraintEventsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.RestraintEvent.RestraintEvent, 
        EdFi.Ods.Api.Models.Resources.V2.RestraintEvent.RestraintEvent, 
        EdFi.Ods.Entities.Common.IRestraintEvent, 
        // EdFi.Ods.Entities.NHibernate.RestraintEventAggregate.RestraintEvent, 
        Api.Models.Requests.v2.RestraintEvents.RestraintEventGetByKey, 
        Api.Models.Requests.v2.RestraintEvents.RestraintEventPut,
        Api.Models.Requests.v2.RestraintEvents.RestraintEventPost,
        Api.Models.Requests.v2.RestraintEvents.RestraintEventDelete,
        Api.Models.Requests.v2.RestraintEvents.RestraintEventGetByExample>
    {
        public RestraintEventsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.RestraintEvents.RestraintEventGetByKey request, IRestraintEvent specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.EventDate = request.EventDate;
            specification.RestraintEventIdentifier = request.Identifier;
            specification.SchoolId = request.SchoolId;
            specification.StudentUniqueId = request.StudentUniqueId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.RestraintEvents.RestraintEventGetByExample request, IRestraintEvent specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.EducationalEnvironmentType = request.EducationalEnvironmentType;
            specification.EventDate = request.EventDate;
            specification.Id = request.Id;
            specification.RestraintEventIdentifier = request.Identifier;
            specification.SchoolId = request.SchoolId;
            specification.StudentUniqueId = request.StudentUniqueId;
                    }
                public IHttpActionResult GetByKey([FromUri] DateTime eventDate, string identifier, int schoolId, string studentUniqueId)
        {
            var request = new Api.Models.Requests.v2.RestraintEvents.RestraintEventGetByKey
            {
                EventDate = eventDate,
                Identifier = identifier,
                SchoolId = schoolId,
                StudentUniqueId = studentUniqueId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IRestraintEvent request)
        {
            return 
                request.EventDate != default(DateTime)
                && request.RestraintEventIdentifier != default(string)
                && request.SchoolId != default(int)
                && request.StudentUniqueId != default(string);
        }

        protected override string GetResourceCollectionName()
        {
            return "restraintEvents";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.RestraintEventReasonTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class RestraintEventReasonTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.RestraintEventReasonType.RestraintEventReasonType, 
        EdFi.Ods.Api.Models.Resources.V2.RestraintEventReasonType.RestraintEventReasonType, 
        EdFi.Ods.Entities.Common.IRestraintEventReasonType, 
        // EdFi.Ods.Entities.NHibernate.RestraintEventReasonTypeAggregate.RestraintEventReasonType, 
        Api.Models.Requests.v2.RestraintEventReasonTypes.RestraintEventReasonTypeGetByKey, 
        Api.Models.Requests.v2.RestraintEventReasonTypes.RestraintEventReasonTypePut,
        Api.Models.Requests.v2.RestraintEventReasonTypes.RestraintEventReasonTypePost,
        Api.Models.Requests.v2.RestraintEventReasonTypes.RestraintEventReasonTypeDelete,
        Api.Models.Requests.v2.RestraintEventReasonTypes.RestraintEventReasonTypeGetByExample>
    {
        public RestraintEventReasonTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.RestraintEventReasonTypes.RestraintEventReasonTypeGetByKey request, IRestraintEventReasonType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.RestraintEventReasonTypeId = request.RestraintEventReasonTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.RestraintEventReasonTypes.RestraintEventReasonTypeGetByExample request, IRestraintEventReasonType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.RestraintEventReasonTypeId = request.RestraintEventReasonTypeId;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int restraintEventReasonTypeId)
        {
            var request = new Api.Models.Requests.v2.RestraintEventReasonTypes.RestraintEventReasonTypeGetByKey
            {
                RestraintEventReasonTypeId = restraintEventReasonTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IRestraintEventReasonType request)
        {
            return 
                request.RestraintEventReasonTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "restraintEventReasonTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.ResultDatatypeTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class ResultDatatypeTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.ResultDatatypeType.ResultDatatypeType, 
        EdFi.Ods.Api.Models.Resources.V2.ResultDatatypeType.ResultDatatypeType, 
        EdFi.Ods.Entities.Common.IResultDatatypeType, 
        // EdFi.Ods.Entities.NHibernate.ResultDatatypeTypeAggregate.ResultDatatypeType, 
        Api.Models.Requests.v2.ResultDatatypeTypes.ResultDatatypeTypeGetByKey, 
        Api.Models.Requests.v2.ResultDatatypeTypes.ResultDatatypeTypePut,
        Api.Models.Requests.v2.ResultDatatypeTypes.ResultDatatypeTypePost,
        Api.Models.Requests.v2.ResultDatatypeTypes.ResultDatatypeTypeDelete,
        Api.Models.Requests.v2.ResultDatatypeTypes.ResultDatatypeTypeGetByExample>
    {
        public ResultDatatypeTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.ResultDatatypeTypes.ResultDatatypeTypeGetByKey request, IResultDatatypeType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.ResultDatatypeTypeId = request.ResultDatatypeTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.ResultDatatypeTypes.ResultDatatypeTypeGetByExample request, IResultDatatypeType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.ResultDatatypeTypeId = request.ResultDatatypeTypeId;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int resultDatatypeTypeId)
        {
            var request = new Api.Models.Requests.v2.ResultDatatypeTypes.ResultDatatypeTypeGetByKey
            {
                ResultDatatypeTypeId = resultDatatypeTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IResultDatatypeType request)
        {
            return 
                request.ResultDatatypeTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "resultDatatypeTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.RetestIndicatorTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class RetestIndicatorTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.RetestIndicatorType.RetestIndicatorType, 
        EdFi.Ods.Api.Models.Resources.V2.RetestIndicatorType.RetestIndicatorType, 
        EdFi.Ods.Entities.Common.IRetestIndicatorType, 
        // EdFi.Ods.Entities.NHibernate.RetestIndicatorTypeAggregate.RetestIndicatorType, 
        Api.Models.Requests.v2.RetestIndicatorTypes.RetestIndicatorTypeGetByKey, 
        Api.Models.Requests.v2.RetestIndicatorTypes.RetestIndicatorTypePut,
        Api.Models.Requests.v2.RetestIndicatorTypes.RetestIndicatorTypePost,
        Api.Models.Requests.v2.RetestIndicatorTypes.RetestIndicatorTypeDelete,
        Api.Models.Requests.v2.RetestIndicatorTypes.RetestIndicatorTypeGetByExample>
    {
        public RetestIndicatorTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.RetestIndicatorTypes.RetestIndicatorTypeGetByKey request, IRetestIndicatorType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.RetestIndicatorTypeId = request.RetestIndicatorTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.RetestIndicatorTypes.RetestIndicatorTypeGetByExample request, IRetestIndicatorType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.RetestIndicatorTypeId = request.RetestIndicatorTypeId;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int retestIndicatorTypeId)
        {
            var request = new Api.Models.Requests.v2.RetestIndicatorTypes.RetestIndicatorTypeGetByKey
            {
                RetestIndicatorTypeId = retestIndicatorTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IRetestIndicatorType request)
        {
            return 
                request.RetestIndicatorTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "retestIndicatorTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.Schools
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class SchoolsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.School.School, 
        EdFi.Ods.Api.Models.Resources.V2.School.School, 
        EdFi.Ods.Entities.Common.ISchool, 
        // EdFi.Ods.Entities.NHibernate.SchoolAggregate.School, 
        Api.Models.Requests.v2.Schools.SchoolGetByKey, 
        Api.Models.Requests.v2.Schools.SchoolPut,
        Api.Models.Requests.v2.Schools.SchoolPost,
        Api.Models.Requests.v2.Schools.SchoolDelete,
        Api.Models.Requests.v2.Schools.SchoolGetByExample>
    {
        public SchoolsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.Schools.SchoolGetByKey request, ISchool specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.SchoolId = request.SchoolId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.Schools.SchoolGetByExample request, ISchool specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.AdministrativeFundingControlDescriptor = request.AdministrativeFundingControlDescriptor;
            specification.CharterApprovalAgencyType = request.CharterApprovalAgencyType;
            specification.CharterApprovalSchoolYear = request.CharterApprovalSchoolYear;
            specification.CharterStatusType = request.CharterStatusType;
            specification.InternetAccessType = request.InternetAccessType;
            specification.LocalEducationAgencyId = request.LocalEducationAgencyId;
            specification.MagnetSpecialProgramEmphasisSchoolType = request.MagnetSpecialProgramEmphasisSchoolType;
            specification.SchoolId = request.SchoolId;
            specification.SchoolType = request.Type;
            specification.TitleIPartASchoolDesignationType = request.TitleIPartASchoolDesignationType;
                    }
                public IHttpActionResult GetByKey([FromUri] int schoolId)
        {
            var request = new Api.Models.Requests.v2.Schools.SchoolGetByKey
            {
                SchoolId = schoolId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(ISchool request)
        {
            return 
                request.SchoolId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "schools";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.SchoolCategoryTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class SchoolCategoryTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.SchoolCategoryType.SchoolCategoryType, 
        EdFi.Ods.Api.Models.Resources.V2.SchoolCategoryType.SchoolCategoryType, 
        EdFi.Ods.Entities.Common.ISchoolCategoryType, 
        // EdFi.Ods.Entities.NHibernate.SchoolCategoryTypeAggregate.SchoolCategoryType, 
        Api.Models.Requests.v2.SchoolCategoryTypes.SchoolCategoryTypeGetByKey, 
        Api.Models.Requests.v2.SchoolCategoryTypes.SchoolCategoryTypePut,
        Api.Models.Requests.v2.SchoolCategoryTypes.SchoolCategoryTypePost,
        Api.Models.Requests.v2.SchoolCategoryTypes.SchoolCategoryTypeDelete,
        Api.Models.Requests.v2.SchoolCategoryTypes.SchoolCategoryTypeGetByExample>
    {
        public SchoolCategoryTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.SchoolCategoryTypes.SchoolCategoryTypeGetByKey request, ISchoolCategoryType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.SchoolCategoryTypeId = request.SchoolCategoryTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.SchoolCategoryTypes.SchoolCategoryTypeGetByExample request, ISchoolCategoryType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.SchoolCategoryTypeId = request.SchoolCategoryTypeId;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int schoolCategoryTypeId)
        {
            var request = new Api.Models.Requests.v2.SchoolCategoryTypes.SchoolCategoryTypeGetByKey
            {
                SchoolCategoryTypeId = schoolCategoryTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(ISchoolCategoryType request)
        {
            return 
                request.SchoolCategoryTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "schoolCategoryTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.SchoolChoiceImplementStatusTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class SchoolChoiceImplementStatusTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.SchoolChoiceImplementStatusType.SchoolChoiceImplementStatusType, 
        EdFi.Ods.Api.Models.Resources.V2.SchoolChoiceImplementStatusType.SchoolChoiceImplementStatusType, 
        EdFi.Ods.Entities.Common.ISchoolChoiceImplementStatusType, 
        // EdFi.Ods.Entities.NHibernate.SchoolChoiceImplementStatusTypeAggregate.SchoolChoiceImplementStatusType, 
        Api.Models.Requests.v2.SchoolChoiceImplementStatusTypes.SchoolChoiceImplementStatusTypeGetByKey, 
        Api.Models.Requests.v2.SchoolChoiceImplementStatusTypes.SchoolChoiceImplementStatusTypePut,
        Api.Models.Requests.v2.SchoolChoiceImplementStatusTypes.SchoolChoiceImplementStatusTypePost,
        Api.Models.Requests.v2.SchoolChoiceImplementStatusTypes.SchoolChoiceImplementStatusTypeDelete,
        Api.Models.Requests.v2.SchoolChoiceImplementStatusTypes.SchoolChoiceImplementStatusTypeGetByExample>
    {
        public SchoolChoiceImplementStatusTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.SchoolChoiceImplementStatusTypes.SchoolChoiceImplementStatusTypeGetByKey request, ISchoolChoiceImplementStatusType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.SchoolChoiceImplementStatusTypeId = request.SchoolChoiceImplementStatusTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.SchoolChoiceImplementStatusTypes.SchoolChoiceImplementStatusTypeGetByExample request, ISchoolChoiceImplementStatusType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.SchoolChoiceImplementStatusTypeId = request.SchoolChoiceImplementStatusTypeId;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int schoolChoiceImplementStatusTypeId)
        {
            var request = new Api.Models.Requests.v2.SchoolChoiceImplementStatusTypes.SchoolChoiceImplementStatusTypeGetByKey
            {
                SchoolChoiceImplementStatusTypeId = schoolChoiceImplementStatusTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(ISchoolChoiceImplementStatusType request)
        {
            return 
                request.SchoolChoiceImplementStatusTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "schoolChoiceImplementStatusTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.SchoolFoodServicesEligibilityDescriptors
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class SchoolFoodServicesEligibilityDescriptorsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.SchoolFoodServicesEligibilityDescriptor.SchoolFoodServicesEligibilityDescriptor, 
        EdFi.Ods.Api.Models.Resources.V2.SchoolFoodServicesEligibilityDescriptor.SchoolFoodServicesEligibilityDescriptor, 
        EdFi.Ods.Entities.Common.ISchoolFoodServicesEligibilityDescriptor, 
        // EdFi.Ods.Entities.NHibernate.SchoolFoodServicesEligibilityDescriptorAggregate.SchoolFoodServicesEligibilityDescriptor, 
        Api.Models.Requests.v2.SchoolFoodServicesEligibilityDescriptors.SchoolFoodServicesEligibilityDescriptorGetByKey, 
        Api.Models.Requests.v2.SchoolFoodServicesEligibilityDescriptors.SchoolFoodServicesEligibilityDescriptorPut,
        Api.Models.Requests.v2.SchoolFoodServicesEligibilityDescriptors.SchoolFoodServicesEligibilityDescriptorPost,
        Api.Models.Requests.v2.SchoolFoodServicesEligibilityDescriptors.SchoolFoodServicesEligibilityDescriptorDelete,
        Api.Models.Requests.v2.SchoolFoodServicesEligibilityDescriptors.SchoolFoodServicesEligibilityDescriptorGetByExample>
    {
        public SchoolFoodServicesEligibilityDescriptorsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.SchoolFoodServicesEligibilityDescriptors.SchoolFoodServicesEligibilityDescriptorGetByKey request, ISchoolFoodServicesEligibilityDescriptor specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.SchoolFoodServicesEligibilityDescriptorId = request.SchoolFoodServicesEligibilityDescriptorId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.SchoolFoodServicesEligibilityDescriptors.SchoolFoodServicesEligibilityDescriptorGetByExample request, ISchoolFoodServicesEligibilityDescriptor specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.SchoolFoodServicesEligibilityDescriptorId = request.SchoolFoodServicesEligibilityDescriptorId;
            specification.SchoolFoodServicesEligibilityType = request.SchoolFoodServicesEligibilityType;
                    }
                public IHttpActionResult GetByKey([FromUri] int schoolFoodServicesEligibilityDescriptorId)
        {
            var request = new Api.Models.Requests.v2.SchoolFoodServicesEligibilityDescriptors.SchoolFoodServicesEligibilityDescriptorGetByKey
            {
                SchoolFoodServicesEligibilityDescriptorId = schoolFoodServicesEligibilityDescriptorId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(ISchoolFoodServicesEligibilityDescriptor request)
        {
            return 
                request.SchoolFoodServicesEligibilityDescriptorId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "schoolFoodServicesEligibilityDescriptors";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.SchoolFoodServicesEligibilityTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class SchoolFoodServicesEligibilityTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.SchoolFoodServicesEligibilityType.SchoolFoodServicesEligibilityType, 
        EdFi.Ods.Api.Models.Resources.V2.SchoolFoodServicesEligibilityType.SchoolFoodServicesEligibilityType, 
        EdFi.Ods.Entities.Common.ISchoolFoodServicesEligibilityType, 
        // EdFi.Ods.Entities.NHibernate.SchoolFoodServicesEligibilityTypeAggregate.SchoolFoodServicesEligibilityType, 
        Api.Models.Requests.v2.SchoolFoodServicesEligibilityTypes.SchoolFoodServicesEligibilityTypeGetByKey, 
        Api.Models.Requests.v2.SchoolFoodServicesEligibilityTypes.SchoolFoodServicesEligibilityTypePut,
        Api.Models.Requests.v2.SchoolFoodServicesEligibilityTypes.SchoolFoodServicesEligibilityTypePost,
        Api.Models.Requests.v2.SchoolFoodServicesEligibilityTypes.SchoolFoodServicesEligibilityTypeDelete,
        Api.Models.Requests.v2.SchoolFoodServicesEligibilityTypes.SchoolFoodServicesEligibilityTypeGetByExample>
    {
        public SchoolFoodServicesEligibilityTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.SchoolFoodServicesEligibilityTypes.SchoolFoodServicesEligibilityTypeGetByKey request, ISchoolFoodServicesEligibilityType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.SchoolFoodServicesEligibilityTypeId = request.SchoolFoodServicesEligibilityTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.SchoolFoodServicesEligibilityTypes.SchoolFoodServicesEligibilityTypeGetByExample request, ISchoolFoodServicesEligibilityType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.SchoolFoodServicesEligibilityTypeId = request.SchoolFoodServicesEligibilityTypeId;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int schoolFoodServicesEligibilityTypeId)
        {
            var request = new Api.Models.Requests.v2.SchoolFoodServicesEligibilityTypes.SchoolFoodServicesEligibilityTypeGetByKey
            {
                SchoolFoodServicesEligibilityTypeId = schoolFoodServicesEligibilityTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(ISchoolFoodServicesEligibilityType request)
        {
            return 
                request.SchoolFoodServicesEligibilityTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "schoolFoodServicesEligibilityTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.SchoolTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class SchoolTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.SchoolType.SchoolType, 
        EdFi.Ods.Api.Models.Resources.V2.SchoolType.SchoolType, 
        EdFi.Ods.Entities.Common.ISchoolType, 
        // EdFi.Ods.Entities.NHibernate.SchoolTypeAggregate.SchoolType, 
        Api.Models.Requests.v2.SchoolTypes.SchoolTypeGetByKey, 
        Api.Models.Requests.v2.SchoolTypes.SchoolTypePut,
        Api.Models.Requests.v2.SchoolTypes.SchoolTypePost,
        Api.Models.Requests.v2.SchoolTypes.SchoolTypeDelete,
        Api.Models.Requests.v2.SchoolTypes.SchoolTypeGetByExample>
    {
        public SchoolTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.SchoolTypes.SchoolTypeGetByKey request, ISchoolType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.SchoolTypeId = request.SchoolTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.SchoolTypes.SchoolTypeGetByExample request, ISchoolType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.SchoolTypeId = request.SchoolTypeId;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int schoolTypeId)
        {
            var request = new Api.Models.Requests.v2.SchoolTypes.SchoolTypeGetByKey
            {
                SchoolTypeId = schoolTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(ISchoolType request)
        {
            return 
                request.SchoolTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "schoolTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.SchoolYearTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class SchoolYearTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.SchoolYearType.SchoolYearType, 
        EdFi.Ods.Api.Models.Resources.V2.SchoolYearType.SchoolYearType, 
        EdFi.Ods.Entities.Common.ISchoolYearType, 
        // EdFi.Ods.Entities.NHibernate.SchoolYearTypeAggregate.SchoolYearType, 
        Api.Models.Requests.v2.SchoolYearTypes.SchoolYearTypeGetByKey, 
        Api.Models.Requests.v2.SchoolYearTypes.SchoolYearTypePut,
        Api.Models.Requests.v2.SchoolYearTypes.SchoolYearTypePost,
        Api.Models.Requests.v2.SchoolYearTypes.SchoolYearTypeDelete,
        Api.Models.Requests.v2.SchoolYearTypes.SchoolYearTypeGetByExample>
    {
        public SchoolYearTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.SchoolYearTypes.SchoolYearTypeGetByKey request, ISchoolYearType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.SchoolYear = request.SchoolYear;
                    }

        protected override void MapAll(Api.Models.Requests.v2.SchoolYearTypes.SchoolYearTypeGetByExample request, ISchoolYearType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CurrentSchoolYear = request.CurrentSchoolYear;
            specification.Id = request.Id;
            specification.SchoolYear = request.SchoolYear;
            specification.SchoolYearDescription = request.SchoolYearDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] short schoolYear)
        {
            var request = new Api.Models.Requests.v2.SchoolYearTypes.SchoolYearTypeGetByKey
            {
                SchoolYear = schoolYear,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(ISchoolYearType request)
        {
            return 
                request.SchoolYear != default(short);
        }

        protected override string GetResourceCollectionName()
        {
            return "schoolYearTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.Sections
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class SectionsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.Section.Section, 
        EdFi.Ods.Api.Models.Resources.V2.Section.Section, 
        EdFi.Ods.Entities.Common.ISection, 
        // EdFi.Ods.Entities.NHibernate.SectionAggregate.Section, 
        Api.Models.Requests.v2.Sections.SectionGetByKey, 
        Api.Models.Requests.v2.Sections.SectionPut,
        Api.Models.Requests.v2.Sections.SectionPost,
        Api.Models.Requests.v2.Sections.SectionDelete,
        Api.Models.Requests.v2.Sections.SectionGetByExample>
    {
        public SectionsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.Sections.SectionGetByKey request, ISection specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.ClassPeriodName = request.ClassPeriodName;
            specification.ClassroomIdentificationCode = request.ClassroomIdentificationCode;
            specification.LocalCourseCode = request.LocalCourseCode;
            specification.SchoolId = request.SchoolId;
            specification.SchoolYear = request.SchoolYear;
            specification.SequenceOfCourse = request.SequenceOfCourse;
            specification.TermDescriptor = request.TermDescriptor;
            specification.UniqueSectionCode = request.UniqueSectionCode;
                    }

        protected override void MapAll(Api.Models.Requests.v2.Sections.SectionGetByExample request, ISection specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.AvailableCreditConversion = request.AvailableCreditConversion;
            specification.AvailableCredits = request.AvailableCredits;
            specification.AvailableCreditType = request.AvailableCreditType;
            specification.ClassPeriodName = request.ClassPeriodName;
            specification.ClassroomIdentificationCode = request.ClassroomIdentificationCode;
            specification.EducationalEnvironmentType = request.EducationalEnvironmentType;
            specification.Id = request.Id;
            specification.InstructionLanguageDescriptor = request.InstructionLanguageDescriptor;
            specification.LocalCourseCode = request.LocalCourseCode;
            specification.MediumOfInstructionType = request.MediumOfInstructionType;
            specification.PopulationServedType = request.PopulationServedType;
            specification.SchoolId = request.SchoolId;
            specification.SchoolYear = request.SchoolYear;
            specification.SequenceOfCourse = request.SequenceOfCourse;
            specification.TermDescriptor = request.TermDescriptor;
            specification.UniqueSectionCode = request.UniqueSectionCode;
                    }
                public IHttpActionResult GetByKey([FromUri] string classPeriodName, string classroomIdentificationCode, string localCourseCode, int schoolId, short schoolYear, int sequenceOfCourse, string termDescriptor, string uniqueSectionCode)
        {
            var request = new Api.Models.Requests.v2.Sections.SectionGetByKey
            {
                ClassPeriodName = classPeriodName,
                ClassroomIdentificationCode = classroomIdentificationCode,
                LocalCourseCode = localCourseCode,
                SchoolId = schoolId,
                SchoolYear = schoolYear,
                SequenceOfCourse = sequenceOfCourse,
                TermDescriptor = termDescriptor,
                UniqueSectionCode = uniqueSectionCode,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(ISection request)
        {
            return 
                request.ClassPeriodName != default(string)
                && request.ClassroomIdentificationCode != default(string)
                && request.LocalCourseCode != default(string)
                && request.SchoolId != default(int)
                && request.SchoolYear != default(short)
                && request.SequenceOfCourse != default(int)
                && request.TermDescriptor != null
                && request.UniqueSectionCode != default(string);
        }

        protected override string GetResourceCollectionName()
        {
            return "sections";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.SectionAttendanceTakenEvents
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class SectionAttendanceTakenEventsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.SectionAttendanceTakenEvent.SectionAttendanceTakenEvent, 
        EdFi.Ods.Api.Models.Resources.V2.SectionAttendanceTakenEvent.SectionAttendanceTakenEvent, 
        EdFi.Ods.Entities.Common.ISectionAttendanceTakenEvent, 
        // EdFi.Ods.Entities.NHibernate.SectionAttendanceTakenEventAggregate.SectionAttendanceTakenEvent, 
        Api.Models.Requests.v2.SectionAttendanceTakenEvents.SectionAttendanceTakenEventGetByKey, 
        Api.Models.Requests.v2.SectionAttendanceTakenEvents.SectionAttendanceTakenEventPut,
        Api.Models.Requests.v2.SectionAttendanceTakenEvents.SectionAttendanceTakenEventPost,
        Api.Models.Requests.v2.SectionAttendanceTakenEvents.SectionAttendanceTakenEventDelete,
        Api.Models.Requests.v2.SectionAttendanceTakenEvents.SectionAttendanceTakenEventGetByExample>
    {
        public SectionAttendanceTakenEventsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.SectionAttendanceTakenEvents.SectionAttendanceTakenEventGetByKey request, ISectionAttendanceTakenEvent specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.ClassPeriodName = request.ClassPeriodName;
            specification.ClassroomIdentificationCode = request.ClassroomIdentificationCode;
            specification.Date = request.Date;
            specification.LocalCourseCode = request.LocalCourseCode;
            specification.SchoolId = request.SchoolId;
            specification.SchoolYear = request.SchoolYear;
            specification.SequenceOfCourse = request.SequenceOfCourse;
            specification.TermDescriptor = request.TermDescriptor;
            specification.UniqueSectionCode = request.UniqueSectionCode;
                    }

        protected override void MapAll(Api.Models.Requests.v2.SectionAttendanceTakenEvents.SectionAttendanceTakenEventGetByExample request, ISectionAttendanceTakenEvent specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.ClassPeriodName = request.ClassPeriodName;
            specification.ClassroomIdentificationCode = request.ClassroomIdentificationCode;
            specification.Date = request.Date;
            specification.EventDate = request.EventDate;
            specification.Id = request.Id;
            specification.LocalCourseCode = request.LocalCourseCode;
            specification.SchoolId = request.SchoolId;
            specification.SchoolYear = request.SchoolYear;
            specification.SequenceOfCourse = request.SequenceOfCourse;
            specification.StaffUniqueId = request.StaffUniqueId;
            specification.TermDescriptor = request.TermDescriptor;
            specification.UniqueSectionCode = request.UniqueSectionCode;
                    }
                public IHttpActionResult GetByKey([FromUri] string classPeriodName, string classroomIdentificationCode, DateTime date, string localCourseCode, int schoolId, short schoolYear, int sequenceOfCourse, string termDescriptor, string uniqueSectionCode)
        {
            var request = new Api.Models.Requests.v2.SectionAttendanceTakenEvents.SectionAttendanceTakenEventGetByKey
            {
                ClassPeriodName = classPeriodName,
                ClassroomIdentificationCode = classroomIdentificationCode,
                Date = date,
                LocalCourseCode = localCourseCode,
                SchoolId = schoolId,
                SchoolYear = schoolYear,
                SequenceOfCourse = sequenceOfCourse,
                TermDescriptor = termDescriptor,
                UniqueSectionCode = uniqueSectionCode,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(ISectionAttendanceTakenEvent request)
        {
            return 
                request.ClassPeriodName != default(string)
                && request.ClassroomIdentificationCode != default(string)
                && request.Date != default(DateTime)
                && request.LocalCourseCode != default(string)
                && request.SchoolId != default(int)
                && request.SchoolYear != default(short)
                && request.SequenceOfCourse != default(int)
                && request.TermDescriptor != null
                && request.UniqueSectionCode != default(string);
        }

        protected override string GetResourceCollectionName()
        {
            return "sectionAttendanceTakenEvents";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.SectionCharacteristicDescriptors
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class SectionCharacteristicDescriptorsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.SectionCharacteristicDescriptor.SectionCharacteristicDescriptor, 
        EdFi.Ods.Api.Models.Resources.V2.SectionCharacteristicDescriptor.SectionCharacteristicDescriptor, 
        EdFi.Ods.Entities.Common.ISectionCharacteristicDescriptor, 
        // EdFi.Ods.Entities.NHibernate.SectionCharacteristicDescriptorAggregate.SectionCharacteristicDescriptor, 
        Api.Models.Requests.v2.SectionCharacteristicDescriptors.SectionCharacteristicDescriptorGetByKey, 
        Api.Models.Requests.v2.SectionCharacteristicDescriptors.SectionCharacteristicDescriptorPut,
        Api.Models.Requests.v2.SectionCharacteristicDescriptors.SectionCharacteristicDescriptorPost,
        Api.Models.Requests.v2.SectionCharacteristicDescriptors.SectionCharacteristicDescriptorDelete,
        Api.Models.Requests.v2.SectionCharacteristicDescriptors.SectionCharacteristicDescriptorGetByExample>
    {
        public SectionCharacteristicDescriptorsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.SectionCharacteristicDescriptors.SectionCharacteristicDescriptorGetByKey request, ISectionCharacteristicDescriptor specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.SectionCharacteristicDescriptorId = request.SectionCharacteristicDescriptorId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.SectionCharacteristicDescriptors.SectionCharacteristicDescriptorGetByExample request, ISectionCharacteristicDescriptor specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.SectionCharacteristicDescriptorId = request.SectionCharacteristicDescriptorId;
            specification.SectionCharacteristicType = request.SectionCharacteristicType;
                    }
                public IHttpActionResult GetByKey([FromUri] int sectionCharacteristicDescriptorId)
        {
            var request = new Api.Models.Requests.v2.SectionCharacteristicDescriptors.SectionCharacteristicDescriptorGetByKey
            {
                SectionCharacteristicDescriptorId = sectionCharacteristicDescriptorId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(ISectionCharacteristicDescriptor request)
        {
            return 
                request.SectionCharacteristicDescriptorId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "sectionCharacteristicDescriptors";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.SectionCharacteristicTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class SectionCharacteristicTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.SectionCharacteristicType.SectionCharacteristicType, 
        EdFi.Ods.Api.Models.Resources.V2.SectionCharacteristicType.SectionCharacteristicType, 
        EdFi.Ods.Entities.Common.ISectionCharacteristicType, 
        // EdFi.Ods.Entities.NHibernate.SectionCharacteristicTypeAggregate.SectionCharacteristicType, 
        Api.Models.Requests.v2.SectionCharacteristicTypes.SectionCharacteristicTypeGetByKey, 
        Api.Models.Requests.v2.SectionCharacteristicTypes.SectionCharacteristicTypePut,
        Api.Models.Requests.v2.SectionCharacteristicTypes.SectionCharacteristicTypePost,
        Api.Models.Requests.v2.SectionCharacteristicTypes.SectionCharacteristicTypeDelete,
        Api.Models.Requests.v2.SectionCharacteristicTypes.SectionCharacteristicTypeGetByExample>
    {
        public SectionCharacteristicTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.SectionCharacteristicTypes.SectionCharacteristicTypeGetByKey request, ISectionCharacteristicType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.SectionCharacteristicTypeId = request.SectionCharacteristicTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.SectionCharacteristicTypes.SectionCharacteristicTypeGetByExample request, ISectionCharacteristicType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.SectionCharacteristicTypeId = request.SectionCharacteristicTypeId;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int sectionCharacteristicTypeId)
        {
            var request = new Api.Models.Requests.v2.SectionCharacteristicTypes.SectionCharacteristicTypeGetByKey
            {
                SectionCharacteristicTypeId = sectionCharacteristicTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(ISectionCharacteristicType request)
        {
            return 
                request.SectionCharacteristicTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "sectionCharacteristicTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.SeparationReasonDescriptors
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class SeparationReasonDescriptorsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.SeparationReasonDescriptor.SeparationReasonDescriptor, 
        EdFi.Ods.Api.Models.Resources.V2.SeparationReasonDescriptor.SeparationReasonDescriptor, 
        EdFi.Ods.Entities.Common.ISeparationReasonDescriptor, 
        // EdFi.Ods.Entities.NHibernate.SeparationReasonDescriptorAggregate.SeparationReasonDescriptor, 
        Api.Models.Requests.v2.SeparationReasonDescriptors.SeparationReasonDescriptorGetByKey, 
        Api.Models.Requests.v2.SeparationReasonDescriptors.SeparationReasonDescriptorPut,
        Api.Models.Requests.v2.SeparationReasonDescriptors.SeparationReasonDescriptorPost,
        Api.Models.Requests.v2.SeparationReasonDescriptors.SeparationReasonDescriptorDelete,
        Api.Models.Requests.v2.SeparationReasonDescriptors.SeparationReasonDescriptorGetByExample>
    {
        public SeparationReasonDescriptorsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.SeparationReasonDescriptors.SeparationReasonDescriptorGetByKey request, ISeparationReasonDescriptor specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.SeparationReasonDescriptorId = request.SeparationReasonDescriptorId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.SeparationReasonDescriptors.SeparationReasonDescriptorGetByExample request, ISeparationReasonDescriptor specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.SeparationReasonDescriptorId = request.SeparationReasonDescriptorId;
            specification.SeparationReasonType = request.SeparationReasonType;
                    }
                public IHttpActionResult GetByKey([FromUri] int separationReasonDescriptorId)
        {
            var request = new Api.Models.Requests.v2.SeparationReasonDescriptors.SeparationReasonDescriptorGetByKey
            {
                SeparationReasonDescriptorId = separationReasonDescriptorId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(ISeparationReasonDescriptor request)
        {
            return 
                request.SeparationReasonDescriptorId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "separationReasonDescriptors";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.SeparationReasonTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class SeparationReasonTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.SeparationReasonType.SeparationReasonType, 
        EdFi.Ods.Api.Models.Resources.V2.SeparationReasonType.SeparationReasonType, 
        EdFi.Ods.Entities.Common.ISeparationReasonType, 
        // EdFi.Ods.Entities.NHibernate.SeparationReasonTypeAggregate.SeparationReasonType, 
        Api.Models.Requests.v2.SeparationReasonTypes.SeparationReasonTypeGetByKey, 
        Api.Models.Requests.v2.SeparationReasonTypes.SeparationReasonTypePut,
        Api.Models.Requests.v2.SeparationReasonTypes.SeparationReasonTypePost,
        Api.Models.Requests.v2.SeparationReasonTypes.SeparationReasonTypeDelete,
        Api.Models.Requests.v2.SeparationReasonTypes.SeparationReasonTypeGetByExample>
    {
        public SeparationReasonTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.SeparationReasonTypes.SeparationReasonTypeGetByKey request, ISeparationReasonType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.SeparationReasonTypeId = request.SeparationReasonTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.SeparationReasonTypes.SeparationReasonTypeGetByExample request, ISeparationReasonType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.SeparationReasonTypeId = request.SeparationReasonTypeId;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int separationReasonTypeId)
        {
            var request = new Api.Models.Requests.v2.SeparationReasonTypes.SeparationReasonTypeGetByKey
            {
                SeparationReasonTypeId = separationReasonTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(ISeparationReasonType request)
        {
            return 
                request.SeparationReasonTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "separationReasonTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.SeparationTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class SeparationTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.SeparationType.SeparationType, 
        EdFi.Ods.Api.Models.Resources.V2.SeparationType.SeparationType, 
        EdFi.Ods.Entities.Common.ISeparationType, 
        // EdFi.Ods.Entities.NHibernate.SeparationTypeAggregate.SeparationType, 
        Api.Models.Requests.v2.SeparationTypes.SeparationTypeGetByKey, 
        Api.Models.Requests.v2.SeparationTypes.SeparationTypePut,
        Api.Models.Requests.v2.SeparationTypes.SeparationTypePost,
        Api.Models.Requests.v2.SeparationTypes.SeparationTypeDelete,
        Api.Models.Requests.v2.SeparationTypes.SeparationTypeGetByExample>
    {
        public SeparationTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.SeparationTypes.SeparationTypeGetByKey request, ISeparationType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.SeparationTypeId = request.SeparationTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.SeparationTypes.SeparationTypeGetByExample request, ISeparationType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.SeparationTypeId = request.SeparationTypeId;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int separationTypeId)
        {
            var request = new Api.Models.Requests.v2.SeparationTypes.SeparationTypeGetByKey
            {
                SeparationTypeId = separationTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(ISeparationType request)
        {
            return 
                request.SeparationTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "separationTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.ServiceDescriptors
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class ServiceDescriptorsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.ServiceDescriptor.ServiceDescriptor, 
        EdFi.Ods.Api.Models.Resources.V2.ServiceDescriptor.ServiceDescriptor, 
        EdFi.Ods.Entities.Common.IServiceDescriptor, 
        // EdFi.Ods.Entities.NHibernate.ServiceDescriptorAggregate.ServiceDescriptor, 
        Api.Models.Requests.v2.ServiceDescriptors.ServiceDescriptorGetByKey, 
        Api.Models.Requests.v2.ServiceDescriptors.ServiceDescriptorPut,
        Api.Models.Requests.v2.ServiceDescriptors.ServiceDescriptorPost,
        Api.Models.Requests.v2.ServiceDescriptors.ServiceDescriptorDelete,
        Api.Models.Requests.v2.ServiceDescriptors.ServiceDescriptorGetByExample>
    {
        public ServiceDescriptorsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.ServiceDescriptors.ServiceDescriptorGetByKey request, IServiceDescriptor specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.ServiceDescriptorId = request.ServiceDescriptorId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.ServiceDescriptors.ServiceDescriptorGetByExample request, IServiceDescriptor specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.ServiceCategory = request.ServiceCategory;
            specification.ServiceDescriptorId = request.ServiceDescriptorId;
                    }
                public IHttpActionResult GetByKey([FromUri] int serviceDescriptorId)
        {
            var request = new Api.Models.Requests.v2.ServiceDescriptors.ServiceDescriptorGetByKey
            {
                ServiceDescriptorId = serviceDescriptorId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IServiceDescriptor request)
        {
            return 
                request.ServiceDescriptorId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "serviceDescriptors";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.Sessions
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class SessionsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.Session.Session, 
        EdFi.Ods.Api.Models.Resources.V2.Session.Session, 
        EdFi.Ods.Entities.Common.ISession, 
        // EdFi.Ods.Entities.NHibernate.SessionAggregate.Session, 
        Api.Models.Requests.v2.Sessions.SessionGetByKey, 
        Api.Models.Requests.v2.Sessions.SessionPut,
        Api.Models.Requests.v2.Sessions.SessionPost,
        Api.Models.Requests.v2.Sessions.SessionDelete,
        Api.Models.Requests.v2.Sessions.SessionGetByExample>
    {
        public SessionsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.Sessions.SessionGetByKey request, ISession specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.SchoolId = request.SchoolId;
            specification.SchoolYear = request.SchoolYear;
            specification.TermDescriptor = request.TermDescriptor;
                    }

        protected override void MapAll(Api.Models.Requests.v2.Sessions.SessionGetByExample request, ISession specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.BeginDate = request.BeginDate;
            specification.EndDate = request.EndDate;
            specification.Id = request.Id;
            specification.SchoolId = request.SchoolId;
            specification.SchoolYear = request.SchoolYear;
            specification.SessionName = request.Name;
            specification.TermDescriptor = request.TermDescriptor;
            specification.TotalInstructionalDays = request.TotalInstructionalDays;
                    }
                public IHttpActionResult GetByKey([FromUri] int schoolId, short schoolYear, string termDescriptor)
        {
            var request = new Api.Models.Requests.v2.Sessions.SessionGetByKey
            {
                SchoolId = schoolId,
                SchoolYear = schoolYear,
                TermDescriptor = termDescriptor,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(ISession request)
        {
            return 
                request.SchoolId != default(int)
                && request.SchoolYear != default(short)
                && request.TermDescriptor != null;
        }

        protected override string GetResourceCollectionName()
        {
            return "sessions";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.SexTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class SexTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.SexType.SexType, 
        EdFi.Ods.Api.Models.Resources.V2.SexType.SexType, 
        EdFi.Ods.Entities.Common.ISexType, 
        // EdFi.Ods.Entities.NHibernate.SexTypeAggregate.SexType, 
        Api.Models.Requests.v2.SexTypes.SexTypeGetByKey, 
        Api.Models.Requests.v2.SexTypes.SexTypePut,
        Api.Models.Requests.v2.SexTypes.SexTypePost,
        Api.Models.Requests.v2.SexTypes.SexTypeDelete,
        Api.Models.Requests.v2.SexTypes.SexTypeGetByExample>
    {
        public SexTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.SexTypes.SexTypeGetByKey request, ISexType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.SexTypeId = request.SexTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.SexTypes.SexTypeGetByExample request, ISexType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.SexTypeId = request.SexTypeId;
            specification.ShortDescription = request.ShortDescription;
                    }
                public IHttpActionResult GetByKey([FromUri] int sexTypeId)
        {
            var request = new Api.Models.Requests.v2.SexTypes.SexTypeGetByKey
            {
                SexTypeId = sexTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(ISexType request)
        {
            return 
                request.SexTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "sexTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.SpecialEducationSettingDescriptors
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class SpecialEducationSettingDescriptorsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.SpecialEducationSettingDescriptor.SpecialEducationSettingDescriptor, 
        EdFi.Ods.Api.Models.Resources.V2.SpecialEducationSettingDescriptor.SpecialEducationSettingDescriptor, 
        EdFi.Ods.Entities.Common.ISpecialEducationSettingDescriptor, 
        // EdFi.Ods.Entities.NHibernate.SpecialEducationSettingDescriptorAggregate.SpecialEducationSettingDescriptor, 
        Api.Models.Requests.v2.SpecialEducationSettingDescriptors.SpecialEducationSettingDescriptorGetByKey, 
        Api.Models.Requests.v2.SpecialEducationSettingDescriptors.SpecialEducationSettingDescriptorPut,
        Api.Models.Requests.v2.SpecialEducationSettingDescriptors.SpecialEducationSettingDescriptorPost,
        Api.Models.Requests.v2.SpecialEducationSettingDescriptors.SpecialEducationSettingDescriptorDelete,
        Api.Models.Requests.v2.SpecialEducationSettingDescriptors.SpecialEducationSettingDescriptorGetByExample>
    {
        public SpecialEducationSettingDescriptorsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.SpecialEducationSettingDescriptors.SpecialEducationSettingDescriptorGetByKey request, ISpecialEducationSettingDescriptor specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.SpecialEducationSettingDescriptorId = request.SpecialEducationSettingDescriptorId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.SpecialEducationSettingDescriptors.SpecialEducationSettingDescriptorGetByExample request, ISpecialEducationSettingDescriptor specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.SpecialEducationSettingDescriptorId = request.SpecialEducationSettingDescriptorId;
            specification.SpecialEducationSettingType = request.SpecialEducationSettingType;
                    }
                public IHttpActionResult GetByKey([FromUri] int specialEducationSettingDescriptorId)
        {
            var request = new Api.Models.Requests.v2.SpecialEducationSettingDescriptors.SpecialEducationSettingDescriptorGetByKey
            {
                SpecialEducationSettingDescriptorId = specialEducationSettingDescriptorId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(ISpecialEducationSettingDescriptor request)
        {
            return 
                request.SpecialEducationSettingDescriptorId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "specialEducationSettingDescriptors";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.SpecialEducationSettingTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class SpecialEducationSettingTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.SpecialEducationSettingType.SpecialEducationSettingType, 
        EdFi.Ods.Api.Models.Resources.V2.SpecialEducationSettingType.SpecialEducationSettingType, 
        EdFi.Ods.Entities.Common.ISpecialEducationSettingType, 
        // EdFi.Ods.Entities.NHibernate.SpecialEducationSettingTypeAggregate.SpecialEducationSettingType, 
        Api.Models.Requests.v2.SpecialEducationSettingTypes.SpecialEducationSettingTypeGetByKey, 
        Api.Models.Requests.v2.SpecialEducationSettingTypes.SpecialEducationSettingTypePut,
        Api.Models.Requests.v2.SpecialEducationSettingTypes.SpecialEducationSettingTypePost,
        Api.Models.Requests.v2.SpecialEducationSettingTypes.SpecialEducationSettingTypeDelete,
        Api.Models.Requests.v2.SpecialEducationSettingTypes.SpecialEducationSettingTypeGetByExample>
    {
        public SpecialEducationSettingTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.SpecialEducationSettingTypes.SpecialEducationSettingTypeGetByKey request, ISpecialEducationSettingType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.SpecialEducationSettingTypeId = request.SpecialEducationSettingTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.SpecialEducationSettingTypes.SpecialEducationSettingTypeGetByExample request, ISpecialEducationSettingType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
            specification.SpecialEducationSettingTypeId = request.SpecialEducationSettingTypeId;
                    }
                public IHttpActionResult GetByKey([FromUri] int specialEducationSettingTypeId)
        {
            var request = new Api.Models.Requests.v2.SpecialEducationSettingTypes.SpecialEducationSettingTypeGetByKey
            {
                SpecialEducationSettingTypeId = specialEducationSettingTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(ISpecialEducationSettingType request)
        {
            return 
                request.SpecialEducationSettingTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "specialEducationSettingTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.Staffs
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class StaffsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.Staff.Staff, 
        EdFi.Ods.Api.Models.Resources.V2.Staff.Staff, 
        EdFi.Ods.Entities.Common.IStaff, 
        // EdFi.Ods.Entities.NHibernate.StaffAggregate.Staff, 
        Api.Models.Requests.v2.Staffs.StaffGetByKey, 
        Api.Models.Requests.v2.Staffs.StaffPut,
        Api.Models.Requests.v2.Staffs.StaffPost,
        Api.Models.Requests.v2.Staffs.StaffDelete,
        Api.Models.Requests.v2.Staffs.StaffGetByExample>
    {
        public StaffsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.Staffs.StaffGetByKey request, IStaff specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.StaffUniqueId = request.StaffUniqueId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.Staffs.StaffGetByExample request, IStaff specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.BirthDate = request.BirthDate;
            specification.CitizenshipStatusType = request.CitizenshipStatusType;
            specification.FirstName = request.FirstName;
            specification.GenerationCodeSuffix = request.GenerationCodeSuffix;
            specification.HighestCompletedLevelOfEducationDescriptor = request.HighestCompletedLevelOfEducationDescriptor;
            specification.HighlyQualifiedTeacher = request.HighlyQualifiedTeacher;
            specification.HispanicLatinoEthnicity = request.HispanicLatinoEthnicity;
            specification.Id = request.Id;
            specification.LastSurname = request.LastSurname;
            specification.LoginId = request.LoginId;
            specification.MaidenName = request.MaidenName;
            specification.MiddleName = request.MiddleName;
            specification.OldEthnicityType = request.OldEthnicityType;
            specification.PersonalTitlePrefix = request.PersonalTitlePrefix;
            specification.SexType = request.SexType;
            specification.StaffUniqueId = request.StaffUniqueId;
            specification.YearsOfPriorProfessionalExperience = request.YearsOfPriorProfessionalExperience;
            specification.YearsOfPriorTeachingExperience = request.YearsOfPriorTeachingExperience;
                    }
                public IHttpActionResult GetByKey([FromUri] string staffUniqueId)
        {
            var request = new Api.Models.Requests.v2.Staffs.StaffGetByKey
            {
                StaffUniqueId = staffUniqueId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IStaff request)
        {
            return 
                request.StaffUniqueId != default(string);
        }

        protected override string GetResourceCollectionName()
        {
            return "staffs";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.StaffClassificationDescriptors
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class StaffClassificationDescriptorsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.StaffClassificationDescriptor.StaffClassificationDescriptor, 
        EdFi.Ods.Api.Models.Resources.V2.StaffClassificationDescriptor.StaffClassificationDescriptor, 
        EdFi.Ods.Entities.Common.IStaffClassificationDescriptor, 
        // EdFi.Ods.Entities.NHibernate.StaffClassificationDescriptorAggregate.StaffClassificationDescriptor, 
        Api.Models.Requests.v2.StaffClassificationDescriptors.StaffClassificationDescriptorGetByKey, 
        Api.Models.Requests.v2.StaffClassificationDescriptors.StaffClassificationDescriptorPut,
        Api.Models.Requests.v2.StaffClassificationDescriptors.StaffClassificationDescriptorPost,
        Api.Models.Requests.v2.StaffClassificationDescriptors.StaffClassificationDescriptorDelete,
        Api.Models.Requests.v2.StaffClassificationDescriptors.StaffClassificationDescriptorGetByExample>
    {
        public StaffClassificationDescriptorsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.StaffClassificationDescriptors.StaffClassificationDescriptorGetByKey request, IStaffClassificationDescriptor specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.StaffClassificationDescriptorId = request.StaffClassificationDescriptorId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.StaffClassificationDescriptors.StaffClassificationDescriptorGetByExample request, IStaffClassificationDescriptor specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.StaffClassificationDescriptorId = request.StaffClassificationDescriptorId;
            specification.StaffClassificationType = request.StaffClassificationType;
                    }
                public IHttpActionResult GetByKey([FromUri] int staffClassificationDescriptorId)
        {
            var request = new Api.Models.Requests.v2.StaffClassificationDescriptors.StaffClassificationDescriptorGetByKey
            {
                StaffClassificationDescriptorId = staffClassificationDescriptorId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IStaffClassificationDescriptor request)
        {
            return 
                request.StaffClassificationDescriptorId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "staffClassificationDescriptors";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.StaffClassificationTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class StaffClassificationTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.StaffClassificationType.StaffClassificationType, 
        EdFi.Ods.Api.Models.Resources.V2.StaffClassificationType.StaffClassificationType, 
        EdFi.Ods.Entities.Common.IStaffClassificationType, 
        // EdFi.Ods.Entities.NHibernate.StaffClassificationTypeAggregate.StaffClassificationType, 
        Api.Models.Requests.v2.StaffClassificationTypes.StaffClassificationTypeGetByKey, 
        Api.Models.Requests.v2.StaffClassificationTypes.StaffClassificationTypePut,
        Api.Models.Requests.v2.StaffClassificationTypes.StaffClassificationTypePost,
        Api.Models.Requests.v2.StaffClassificationTypes.StaffClassificationTypeDelete,
        Api.Models.Requests.v2.StaffClassificationTypes.StaffClassificationTypeGetByExample>
    {
        public StaffClassificationTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.StaffClassificationTypes.StaffClassificationTypeGetByKey request, IStaffClassificationType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.StaffClassificationTypeId = request.StaffClassificationTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.StaffClassificationTypes.StaffClassificationTypeGetByExample request, IStaffClassificationType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
            specification.StaffClassificationTypeId = request.StaffClassificationTypeId;
                    }
                public IHttpActionResult GetByKey([FromUri] int staffClassificationTypeId)
        {
            var request = new Api.Models.Requests.v2.StaffClassificationTypes.StaffClassificationTypeGetByKey
            {
                StaffClassificationTypeId = staffClassificationTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IStaffClassificationType request)
        {
            return 
                request.StaffClassificationTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "staffClassificationTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.StaffCohortAssociations
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class StaffCohortAssociationsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.StaffCohortAssociation.StaffCohortAssociation, 
        EdFi.Ods.Api.Models.Resources.V2.StaffCohortAssociation.StaffCohortAssociation, 
        EdFi.Ods.Entities.Common.IStaffCohortAssociation, 
        // EdFi.Ods.Entities.NHibernate.StaffCohortAssociationAggregate.StaffCohortAssociation, 
        Api.Models.Requests.v2.StaffCohortAssociations.StaffCohortAssociationGetByKey, 
        Api.Models.Requests.v2.StaffCohortAssociations.StaffCohortAssociationPut,
        Api.Models.Requests.v2.StaffCohortAssociations.StaffCohortAssociationPost,
        Api.Models.Requests.v2.StaffCohortAssociations.StaffCohortAssociationDelete,
        Api.Models.Requests.v2.StaffCohortAssociations.StaffCohortAssociationGetByExample>
    {
        public StaffCohortAssociationsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.StaffCohortAssociations.StaffCohortAssociationGetByKey request, IStaffCohortAssociation specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.BeginDate = request.BeginDate;
            specification.CohortIdentifier = request.CohortIdentifier;
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.StaffUniqueId = request.StaffUniqueId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.StaffCohortAssociations.StaffCohortAssociationGetByExample request, IStaffCohortAssociation specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.BeginDate = request.BeginDate;
            specification.CohortIdentifier = request.CohortIdentifier;
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.EndDate = request.EndDate;
            specification.Id = request.Id;
            specification.StaffUniqueId = request.StaffUniqueId;
            specification.StudentRecordAccess = request.StudentRecordAccess;
                    }
                public IHttpActionResult GetByKey([FromUri] DateTime beginDate, string cohortIdentifier, int educationOrganizationId, string staffUniqueId)
        {
            var request = new Api.Models.Requests.v2.StaffCohortAssociations.StaffCohortAssociationGetByKey
            {
                BeginDate = beginDate,
                CohortIdentifier = cohortIdentifier,
                EducationOrganizationId = educationOrganizationId,
                StaffUniqueId = staffUniqueId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IStaffCohortAssociation request)
        {
            return 
                request.BeginDate != default(DateTime)
                && request.CohortIdentifier != default(string)
                && request.EducationOrganizationId != default(int)
                && request.StaffUniqueId != default(string);
        }

        protected override string GetResourceCollectionName()
        {
            return "staffCohortAssociations";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.StaffEducationOrganizationAssignmentAssociations
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class StaffEducationOrganizationAssignmentAssociationsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.StaffEducationOrganizationAssignmentAssociation.StaffEducationOrganizationAssignmentAssociation, 
        EdFi.Ods.Api.Models.Resources.V2.StaffEducationOrganizationAssignmentAssociation.StaffEducationOrganizationAssignmentAssociation, 
        EdFi.Ods.Entities.Common.IStaffEducationOrganizationAssignmentAssociation, 
        // EdFi.Ods.Entities.NHibernate.StaffEducationOrganizationAssignmentAssociationAggregate.StaffEducationOrganizationAssignmentAssociation, 
        Api.Models.Requests.v2.StaffEducationOrganizationAssignmentAssociations.StaffEducationOrganizationAssignmentAssociationGetByKey, 
        Api.Models.Requests.v2.StaffEducationOrganizationAssignmentAssociations.StaffEducationOrganizationAssignmentAssociationPut,
        Api.Models.Requests.v2.StaffEducationOrganizationAssignmentAssociations.StaffEducationOrganizationAssignmentAssociationPost,
        Api.Models.Requests.v2.StaffEducationOrganizationAssignmentAssociations.StaffEducationOrganizationAssignmentAssociationDelete,
        Api.Models.Requests.v2.StaffEducationOrganizationAssignmentAssociations.StaffEducationOrganizationAssignmentAssociationGetByExample>
    {
        public StaffEducationOrganizationAssignmentAssociationsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.StaffEducationOrganizationAssignmentAssociations.StaffEducationOrganizationAssignmentAssociationGetByKey request, IStaffEducationOrganizationAssignmentAssociation specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.BeginDate = request.BeginDate;
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.StaffClassificationDescriptor = request.StaffClassificationDescriptor;
            specification.StaffUniqueId = request.StaffUniqueId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.StaffEducationOrganizationAssignmentAssociations.StaffEducationOrganizationAssignmentAssociationGetByExample request, IStaffEducationOrganizationAssignmentAssociation specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.BeginDate = request.BeginDate;
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.EmploymentEducationOrganizationId = request.EmploymentEducationOrganizationId;
            specification.EmploymentHireDate = request.EmploymentHireDate;
            specification.EmploymentStatusDescriptor = request.EmploymentStatusDescriptor;
            specification.EndDate = request.EndDate;
            specification.Id = request.Id;
            specification.OrderOfAssignment = request.OrderOfAssignment;
            specification.PositionTitle = request.PositionTitle;
            specification.StaffClassificationDescriptor = request.StaffClassificationDescriptor;
            specification.StaffUniqueId = request.StaffUniqueId;
                    }
                public IHttpActionResult GetByKey([FromUri] DateTime beginDate, int educationOrganizationId, string staffClassificationDescriptor, string staffUniqueId)
        {
            var request = new Api.Models.Requests.v2.StaffEducationOrganizationAssignmentAssociations.StaffEducationOrganizationAssignmentAssociationGetByKey
            {
                BeginDate = beginDate,
                EducationOrganizationId = educationOrganizationId,
                StaffClassificationDescriptor = staffClassificationDescriptor,
                StaffUniqueId = staffUniqueId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IStaffEducationOrganizationAssignmentAssociation request)
        {
            return 
                request.BeginDate != default(DateTime)
                && request.EducationOrganizationId != default(int)
                && request.StaffClassificationDescriptor != null
                && request.StaffUniqueId != default(string);
        }

        protected override string GetResourceCollectionName()
        {
            return "staffEducationOrganizationAssignmentAssociations";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.StaffEducationOrganizationEmploymentAssociations
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class StaffEducationOrganizationEmploymentAssociationsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.StaffEducationOrganizationEmploymentAssociation.StaffEducationOrganizationEmploymentAssociation, 
        EdFi.Ods.Api.Models.Resources.V2.StaffEducationOrganizationEmploymentAssociation.StaffEducationOrganizationEmploymentAssociation, 
        EdFi.Ods.Entities.Common.IStaffEducationOrganizationEmploymentAssociation, 
        // EdFi.Ods.Entities.NHibernate.StaffEducationOrganizationEmploymentAssociationAggregate.StaffEducationOrganizationEmploymentAssociation, 
        Api.Models.Requests.v2.StaffEducationOrganizationEmploymentAssociations.StaffEducationOrganizationEmploymentAssociationGetByKey, 
        Api.Models.Requests.v2.StaffEducationOrganizationEmploymentAssociations.StaffEducationOrganizationEmploymentAssociationPut,
        Api.Models.Requests.v2.StaffEducationOrganizationEmploymentAssociations.StaffEducationOrganizationEmploymentAssociationPost,
        Api.Models.Requests.v2.StaffEducationOrganizationEmploymentAssociations.StaffEducationOrganizationEmploymentAssociationDelete,
        Api.Models.Requests.v2.StaffEducationOrganizationEmploymentAssociations.StaffEducationOrganizationEmploymentAssociationGetByExample>
    {
        public StaffEducationOrganizationEmploymentAssociationsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.StaffEducationOrganizationEmploymentAssociations.StaffEducationOrganizationEmploymentAssociationGetByKey request, IStaffEducationOrganizationEmploymentAssociation specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.EmploymentStatusDescriptor = request.EmploymentStatusDescriptor;
            specification.HireDate = request.HireDate;
            specification.StaffUniqueId = request.StaffUniqueId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.StaffEducationOrganizationEmploymentAssociations.StaffEducationOrganizationEmploymentAssociationGetByExample request, IStaffEducationOrganizationEmploymentAssociation specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.Department = request.Department;
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.EmploymentStatusDescriptor = request.EmploymentStatusDescriptor;
            specification.EndDate = request.EndDate;
            specification.FullTimeEquivalency = request.FullTimeEquivalency;
            specification.HireDate = request.HireDate;
            specification.HourlyWage = request.HourlyWage;
            specification.Id = request.Id;
            specification.OfferDate = request.OfferDate;
            specification.SeparationReasonDescriptor = request.SeparationReasonDescriptor;
            specification.SeparationType = request.SeparationType;
            specification.StaffUniqueId = request.StaffUniqueId;
                    }
                public IHttpActionResult GetByKey([FromUri] int educationOrganizationId, string employmentStatusDescriptor, DateTime hireDate, string staffUniqueId)
        {
            var request = new Api.Models.Requests.v2.StaffEducationOrganizationEmploymentAssociations.StaffEducationOrganizationEmploymentAssociationGetByKey
            {
                EducationOrganizationId = educationOrganizationId,
                EmploymentStatusDescriptor = employmentStatusDescriptor,
                HireDate = hireDate,
                StaffUniqueId = staffUniqueId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IStaffEducationOrganizationEmploymentAssociation request)
        {
            return 
                request.EducationOrganizationId != default(int)
                && request.EmploymentStatusDescriptor != null
                && request.HireDate != default(DateTime)
                && request.StaffUniqueId != default(string);
        }

        protected override string GetResourceCollectionName()
        {
            return "staffEducationOrganizationEmploymentAssociations";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.StaffIdentificationSystemDescriptors
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class StaffIdentificationSystemDescriptorsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.StaffIdentificationSystemDescriptor.StaffIdentificationSystemDescriptor, 
        EdFi.Ods.Api.Models.Resources.V2.StaffIdentificationSystemDescriptor.StaffIdentificationSystemDescriptor, 
        EdFi.Ods.Entities.Common.IStaffIdentificationSystemDescriptor, 
        // EdFi.Ods.Entities.NHibernate.StaffIdentificationSystemDescriptorAggregate.StaffIdentificationSystemDescriptor, 
        Api.Models.Requests.v2.StaffIdentificationSystemDescriptors.StaffIdentificationSystemDescriptorGetByKey, 
        Api.Models.Requests.v2.StaffIdentificationSystemDescriptors.StaffIdentificationSystemDescriptorPut,
        Api.Models.Requests.v2.StaffIdentificationSystemDescriptors.StaffIdentificationSystemDescriptorPost,
        Api.Models.Requests.v2.StaffIdentificationSystemDescriptors.StaffIdentificationSystemDescriptorDelete,
        Api.Models.Requests.v2.StaffIdentificationSystemDescriptors.StaffIdentificationSystemDescriptorGetByExample>
    {
        public StaffIdentificationSystemDescriptorsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.StaffIdentificationSystemDescriptors.StaffIdentificationSystemDescriptorGetByKey request, IStaffIdentificationSystemDescriptor specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.StaffIdentificationSystemDescriptorId = request.StaffIdentificationSystemDescriptorId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.StaffIdentificationSystemDescriptors.StaffIdentificationSystemDescriptorGetByExample request, IStaffIdentificationSystemDescriptor specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.StaffIdentificationSystemDescriptorId = request.StaffIdentificationSystemDescriptorId;
            specification.StaffIdentificationSystemType = request.StaffIdentificationSystemType;
                    }
                public IHttpActionResult GetByKey([FromUri] int staffIdentificationSystemDescriptorId)
        {
            var request = new Api.Models.Requests.v2.StaffIdentificationSystemDescriptors.StaffIdentificationSystemDescriptorGetByKey
            {
                StaffIdentificationSystemDescriptorId = staffIdentificationSystemDescriptorId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IStaffIdentificationSystemDescriptor request)
        {
            return 
                request.StaffIdentificationSystemDescriptorId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "staffIdentificationSystemDescriptors";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.StaffIdentificationSystemTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class StaffIdentificationSystemTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.StaffIdentificationSystemType.StaffIdentificationSystemType, 
        EdFi.Ods.Api.Models.Resources.V2.StaffIdentificationSystemType.StaffIdentificationSystemType, 
        EdFi.Ods.Entities.Common.IStaffIdentificationSystemType, 
        // EdFi.Ods.Entities.NHibernate.StaffIdentificationSystemTypeAggregate.StaffIdentificationSystemType, 
        Api.Models.Requests.v2.StaffIdentificationSystemTypes.StaffIdentificationSystemTypeGetByKey, 
        Api.Models.Requests.v2.StaffIdentificationSystemTypes.StaffIdentificationSystemTypePut,
        Api.Models.Requests.v2.StaffIdentificationSystemTypes.StaffIdentificationSystemTypePost,
        Api.Models.Requests.v2.StaffIdentificationSystemTypes.StaffIdentificationSystemTypeDelete,
        Api.Models.Requests.v2.StaffIdentificationSystemTypes.StaffIdentificationSystemTypeGetByExample>
    {
        public StaffIdentificationSystemTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.StaffIdentificationSystemTypes.StaffIdentificationSystemTypeGetByKey request, IStaffIdentificationSystemType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.StaffIdentificationSystemTypeId = request.StaffIdentificationSystemTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.StaffIdentificationSystemTypes.StaffIdentificationSystemTypeGetByExample request, IStaffIdentificationSystemType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
            specification.StaffIdentificationSystemTypeId = request.StaffIdentificationSystemTypeId;
                    }
                public IHttpActionResult GetByKey([FromUri] int staffIdentificationSystemTypeId)
        {
            var request = new Api.Models.Requests.v2.StaffIdentificationSystemTypes.StaffIdentificationSystemTypeGetByKey
            {
                StaffIdentificationSystemTypeId = staffIdentificationSystemTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IStaffIdentificationSystemType request)
        {
            return 
                request.StaffIdentificationSystemTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "staffIdentificationSystemTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.StaffProgramAssociations
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class StaffProgramAssociationsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.StaffProgramAssociation.StaffProgramAssociation, 
        EdFi.Ods.Api.Models.Resources.V2.StaffProgramAssociation.StaffProgramAssociation, 
        EdFi.Ods.Entities.Common.IStaffProgramAssociation, 
        // EdFi.Ods.Entities.NHibernate.StaffProgramAssociationAggregate.StaffProgramAssociation, 
        Api.Models.Requests.v2.StaffProgramAssociations.StaffProgramAssociationGetByKey, 
        Api.Models.Requests.v2.StaffProgramAssociations.StaffProgramAssociationPut,
        Api.Models.Requests.v2.StaffProgramAssociations.StaffProgramAssociationPost,
        Api.Models.Requests.v2.StaffProgramAssociations.StaffProgramAssociationDelete,
        Api.Models.Requests.v2.StaffProgramAssociations.StaffProgramAssociationGetByExample>
    {
        public StaffProgramAssociationsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.StaffProgramAssociations.StaffProgramAssociationGetByKey request, IStaffProgramAssociation specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.BeginDate = request.BeginDate;
            specification.ProgramEducationOrganizationId = request.ProgramEducationOrganizationId;
            specification.ProgramName = request.ProgramName;
            specification.ProgramType = request.ProgramType;
            specification.StaffUniqueId = request.StaffUniqueId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.StaffProgramAssociations.StaffProgramAssociationGetByExample request, IStaffProgramAssociation specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.BeginDate = request.BeginDate;
            specification.EndDate = request.EndDate;
            specification.Id = request.Id;
            specification.ProgramEducationOrganizationId = request.ProgramEducationOrganizationId;
            specification.ProgramName = request.ProgramName;
            specification.ProgramType = request.ProgramType;
            specification.StaffUniqueId = request.StaffUniqueId;
            specification.StudentRecordAccess = request.StudentRecordAccess;
                    }
                public IHttpActionResult GetByKey([FromUri] DateTime beginDate, int programEducationOrganizationId, string programName, string programType, string staffUniqueId)
        {
            var request = new Api.Models.Requests.v2.StaffProgramAssociations.StaffProgramAssociationGetByKey
            {
                BeginDate = beginDate,
                ProgramEducationOrganizationId = programEducationOrganizationId,
                ProgramName = programName,
                ProgramType = programType,
                StaffUniqueId = staffUniqueId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IStaffProgramAssociation request)
        {
            return 
                request.BeginDate != default(DateTime)
                && request.ProgramEducationOrganizationId != default(int)
                && request.ProgramName != default(string)
                && request.ProgramType != null
                && request.StaffUniqueId != default(string);
        }

        protected override string GetResourceCollectionName()
        {
            return "staffProgramAssociations";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.StaffSchoolAssociations
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class StaffSchoolAssociationsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.StaffSchoolAssociation.StaffSchoolAssociation, 
        EdFi.Ods.Api.Models.Resources.V2.StaffSchoolAssociation.StaffSchoolAssociation, 
        EdFi.Ods.Entities.Common.IStaffSchoolAssociation, 
        // EdFi.Ods.Entities.NHibernate.StaffSchoolAssociationAggregate.StaffSchoolAssociation, 
        Api.Models.Requests.v2.StaffSchoolAssociations.StaffSchoolAssociationGetByKey, 
        Api.Models.Requests.v2.StaffSchoolAssociations.StaffSchoolAssociationPut,
        Api.Models.Requests.v2.StaffSchoolAssociations.StaffSchoolAssociationPost,
        Api.Models.Requests.v2.StaffSchoolAssociations.StaffSchoolAssociationDelete,
        Api.Models.Requests.v2.StaffSchoolAssociations.StaffSchoolAssociationGetByExample>
    {
        public StaffSchoolAssociationsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.StaffSchoolAssociations.StaffSchoolAssociationGetByKey request, IStaffSchoolAssociation specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.ProgramAssignmentDescriptor = request.ProgramAssignmentDescriptor;
            specification.SchoolId = request.SchoolId;
            specification.StaffUniqueId = request.StaffUniqueId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.StaffSchoolAssociations.StaffSchoolAssociationGetByExample request, IStaffSchoolAssociation specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.Id = request.Id;
            specification.ProgramAssignmentDescriptor = request.ProgramAssignmentDescriptor;
            specification.SchoolId = request.SchoolId;
            specification.SchoolYear = request.SchoolYear;
            specification.StaffUniqueId = request.StaffUniqueId;
                    }
                public IHttpActionResult GetByKey([FromUri] string programAssignmentDescriptor, int schoolId, string staffUniqueId)
        {
            var request = new Api.Models.Requests.v2.StaffSchoolAssociations.StaffSchoolAssociationGetByKey
            {
                ProgramAssignmentDescriptor = programAssignmentDescriptor,
                SchoolId = schoolId,
                StaffUniqueId = staffUniqueId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IStaffSchoolAssociation request)
        {
            return 
                request.ProgramAssignmentDescriptor != null
                && request.SchoolId != default(int)
                && request.StaffUniqueId != default(string);
        }

        protected override string GetResourceCollectionName()
        {
            return "staffSchoolAssociations";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.StaffSectionAssociations
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class StaffSectionAssociationsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.StaffSectionAssociation.StaffSectionAssociation, 
        EdFi.Ods.Api.Models.Resources.V2.StaffSectionAssociation.StaffSectionAssociation, 
        EdFi.Ods.Entities.Common.IStaffSectionAssociation, 
        // EdFi.Ods.Entities.NHibernate.StaffSectionAssociationAggregate.StaffSectionAssociation, 
        Api.Models.Requests.v2.StaffSectionAssociations.StaffSectionAssociationGetByKey, 
        Api.Models.Requests.v2.StaffSectionAssociations.StaffSectionAssociationPut,
        Api.Models.Requests.v2.StaffSectionAssociations.StaffSectionAssociationPost,
        Api.Models.Requests.v2.StaffSectionAssociations.StaffSectionAssociationDelete,
        Api.Models.Requests.v2.StaffSectionAssociations.StaffSectionAssociationGetByExample>
    {
        public StaffSectionAssociationsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.StaffSectionAssociations.StaffSectionAssociationGetByKey request, IStaffSectionAssociation specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.ClassPeriodName = request.ClassPeriodName;
            specification.ClassroomIdentificationCode = request.ClassroomIdentificationCode;
            specification.LocalCourseCode = request.LocalCourseCode;
            specification.SchoolId = request.SchoolId;
            specification.SchoolYear = request.SchoolYear;
            specification.SequenceOfCourse = request.SequenceOfCourse;
            specification.StaffUniqueId = request.StaffUniqueId;
            specification.TermDescriptor = request.TermDescriptor;
            specification.UniqueSectionCode = request.UniqueSectionCode;
                    }

        protected override void MapAll(Api.Models.Requests.v2.StaffSectionAssociations.StaffSectionAssociationGetByExample request, IStaffSectionAssociation specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.BeginDate = request.BeginDate;
            specification.ClassPeriodName = request.ClassPeriodName;
            specification.ClassroomIdentificationCode = request.ClassroomIdentificationCode;
            specification.ClassroomPositionDescriptor = request.ClassroomPositionDescriptor;
            specification.EndDate = request.EndDate;
            specification.HighlyQualifiedTeacher = request.HighlyQualifiedTeacher;
            specification.Id = request.Id;
            specification.LocalCourseCode = request.LocalCourseCode;
            specification.PercentageContribution = request.PercentageContribution;
            specification.SchoolId = request.SchoolId;
            specification.SchoolYear = request.SchoolYear;
            specification.SequenceOfCourse = request.SequenceOfCourse;
            specification.StaffUniqueId = request.StaffUniqueId;
            specification.TeacherStudentDataLinkExclusion = request.TeacherStudentDataLinkExclusion;
            specification.TermDescriptor = request.TermDescriptor;
            specification.UniqueSectionCode = request.UniqueSectionCode;
                    }
                public IHttpActionResult GetByKey([FromUri] string classPeriodName, string classroomIdentificationCode, string localCourseCode, int schoolId, short schoolYear, int sequenceOfCourse, string staffUniqueId, string termDescriptor, string uniqueSectionCode)
        {
            var request = new Api.Models.Requests.v2.StaffSectionAssociations.StaffSectionAssociationGetByKey
            {
                ClassPeriodName = classPeriodName,
                ClassroomIdentificationCode = classroomIdentificationCode,
                LocalCourseCode = localCourseCode,
                SchoolId = schoolId,
                SchoolYear = schoolYear,
                SequenceOfCourse = sequenceOfCourse,
                StaffUniqueId = staffUniqueId,
                TermDescriptor = termDescriptor,
                UniqueSectionCode = uniqueSectionCode,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IStaffSectionAssociation request)
        {
            return 
                request.ClassPeriodName != default(string)
                && request.ClassroomIdentificationCode != default(string)
                && request.LocalCourseCode != default(string)
                && request.SchoolId != default(int)
                && request.SchoolYear != default(short)
                && request.SequenceOfCourse != default(int)
                && request.StaffUniqueId != default(string)
                && request.TermDescriptor != null
                && request.UniqueSectionCode != default(string);
        }

        protected override string GetResourceCollectionName()
        {
            return "staffSectionAssociations";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.StateAbbreviationTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class StateAbbreviationTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.StateAbbreviationType.StateAbbreviationType, 
        EdFi.Ods.Api.Models.Resources.V2.StateAbbreviationType.StateAbbreviationType, 
        EdFi.Ods.Entities.Common.IStateAbbreviationType, 
        // EdFi.Ods.Entities.NHibernate.StateAbbreviationTypeAggregate.StateAbbreviationType, 
        Api.Models.Requests.v2.StateAbbreviationTypes.StateAbbreviationTypeGetByKey, 
        Api.Models.Requests.v2.StateAbbreviationTypes.StateAbbreviationTypePut,
        Api.Models.Requests.v2.StateAbbreviationTypes.StateAbbreviationTypePost,
        Api.Models.Requests.v2.StateAbbreviationTypes.StateAbbreviationTypeDelete,
        Api.Models.Requests.v2.StateAbbreviationTypes.StateAbbreviationTypeGetByExample>
    {
        public StateAbbreviationTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.StateAbbreviationTypes.StateAbbreviationTypeGetByKey request, IStateAbbreviationType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.StateAbbreviationTypeId = request.StateAbbreviationTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.StateAbbreviationTypes.StateAbbreviationTypeGetByExample request, IStateAbbreviationType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
            specification.StateAbbreviationTypeId = request.StateAbbreviationTypeId;
                    }
                public IHttpActionResult GetByKey([FromUri] int stateAbbreviationTypeId)
        {
            var request = new Api.Models.Requests.v2.StateAbbreviationTypes.StateAbbreviationTypeGetByKey
            {
                StateAbbreviationTypeId = stateAbbreviationTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IStateAbbreviationType request)
        {
            return 
                request.StateAbbreviationTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "stateAbbreviationTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.StateEducationAgencies
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class StateEducationAgenciesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.StateEducationAgency.StateEducationAgency, 
        EdFi.Ods.Api.Models.Resources.V2.StateEducationAgency.StateEducationAgency, 
        EdFi.Ods.Entities.Common.IStateEducationAgency, 
        // EdFi.Ods.Entities.NHibernate.StateEducationAgencyAggregate.StateEducationAgency, 
        Api.Models.Requests.v2.StateEducationAgencies.StateEducationAgencyGetByKey, 
        Api.Models.Requests.v2.StateEducationAgencies.StateEducationAgencyPut,
        Api.Models.Requests.v2.StateEducationAgencies.StateEducationAgencyPost,
        Api.Models.Requests.v2.StateEducationAgencies.StateEducationAgencyDelete,
        Api.Models.Requests.v2.StateEducationAgencies.StateEducationAgencyGetByExample>
    {
        public StateEducationAgenciesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.StateEducationAgencies.StateEducationAgencyGetByKey request, IStateEducationAgency specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.StateEducationAgencyId = request.StateEducationAgencyId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.StateEducationAgencies.StateEducationAgencyGetByExample request, IStateEducationAgency specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.StateEducationAgencyId = request.StateEducationAgencyId;
                    }
                public IHttpActionResult GetByKey([FromUri] int stateEducationAgencyId)
        {
            var request = new Api.Models.Requests.v2.StateEducationAgencies.StateEducationAgencyGetByKey
            {
                StateEducationAgencyId = stateEducationAgencyId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IStateEducationAgency request)
        {
            return 
                request.StateEducationAgencyId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "stateEducationAgencies";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.Students
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class StudentsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.Student.Student, 
        EdFi.Ods.Api.Models.Resources.V2.Student.Student, 
        EdFi.Ods.Entities.Common.IStudent, 
        // EdFi.Ods.Entities.NHibernate.StudentAggregate.Student, 
        Api.Models.Requests.v2.Students.StudentGetByKey, 
        Api.Models.Requests.v2.Students.StudentPut,
        Api.Models.Requests.v2.Students.StudentPost,
        Api.Models.Requests.v2.Students.StudentDelete,
        Api.Models.Requests.v2.Students.StudentGetByExample>
    {
        public StudentsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.Students.StudentGetByKey request, IStudent specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.StudentUniqueId = request.StudentUniqueId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.Students.StudentGetByExample request, IStudent specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.BirthCity = request.BirthCity;
            specification.BirthCountryDescriptor = request.BirthCountryDescriptor;
            specification.BirthDate = request.BirthDate;
            specification.BirthInternationalProvince = request.BirthInternationalProvince;
            specification.BirthStateAbbreviationType = request.BirthStateAbbreviationType;
            specification.CitizenshipStatusType = request.CitizenshipStatusType;
            specification.DateEnteredUS = request.DateEnteredUS;
            specification.DisplacementStatus = request.DisplacementStatus;
            specification.EconomicDisadvantaged = request.EconomicDisadvantaged;
            specification.FirstName = request.FirstName;
            specification.GenerationCodeSuffix = request.GenerationCodeSuffix;
            specification.HispanicLatinoEthnicity = request.HispanicLatinoEthnicity;
            specification.Id = request.Id;
            specification.LastSurname = request.LastSurname;
            specification.LimitedEnglishProficiencyDescriptor = request.LimitedEnglishProficiencyDescriptor;
            specification.LoginId = request.LoginId;
            specification.MaidenName = request.MaidenName;
            specification.MiddleName = request.MiddleName;
            specification.MultipleBirthStatus = request.MultipleBirthStatus;
            specification.OldEthnicityType = request.OldEthnicityType;
            specification.PersonalTitlePrefix = request.PersonalTitlePrefix;
            specification.ProfileThumbnail = request.ProfileThumbnail;
            specification.SchoolFoodServicesEligibilityDescriptor = request.SchoolFoodServicesEligibilityDescriptor;
            specification.SexType = request.SexType;
            specification.StudentUniqueId = request.StudentUniqueId;
                    }
                public IHttpActionResult GetByKey([FromUri] string studentUniqueId)
        {
            var request = new Api.Models.Requests.v2.Students.StudentGetByKey
            {
                StudentUniqueId = studentUniqueId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IStudent request)
        {
            return 
                request.StudentUniqueId != default(string);
        }

        protected override string GetResourceCollectionName()
        {
            return "students";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.StudentAcademicRecords
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class StudentAcademicRecordsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.StudentAcademicRecord.StudentAcademicRecord, 
        EdFi.Ods.Api.Models.Resources.V2.StudentAcademicRecord.StudentAcademicRecord, 
        EdFi.Ods.Entities.Common.IStudentAcademicRecord, 
        // EdFi.Ods.Entities.NHibernate.StudentAcademicRecordAggregate.StudentAcademicRecord, 
        Api.Models.Requests.v2.StudentAcademicRecords.StudentAcademicRecordGetByKey, 
        Api.Models.Requests.v2.StudentAcademicRecords.StudentAcademicRecordPut,
        Api.Models.Requests.v2.StudentAcademicRecords.StudentAcademicRecordPost,
        Api.Models.Requests.v2.StudentAcademicRecords.StudentAcademicRecordDelete,
        Api.Models.Requests.v2.StudentAcademicRecords.StudentAcademicRecordGetByExample>
    {
        public StudentAcademicRecordsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.StudentAcademicRecords.StudentAcademicRecordGetByKey request, IStudentAcademicRecord specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.SchoolYear = request.SchoolYear;
            specification.StudentUniqueId = request.StudentUniqueId;
            specification.TermDescriptor = request.TermDescriptor;
                    }

        protected override void MapAll(Api.Models.Requests.v2.StudentAcademicRecords.StudentAcademicRecordGetByExample request, IStudentAcademicRecord specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CumulativeAttemptedCreditConversion = request.CumulativeAttemptedCreditConversion;
            specification.CumulativeAttemptedCredits = request.CumulativeAttemptedCredits;
            specification.CumulativeAttemptedCreditType = request.CumulativeAttemptedCreditType;
            specification.CumulativeEarnedCreditConversion = request.CumulativeEarnedCreditConversion;
            specification.CumulativeEarnedCredits = request.CumulativeEarnedCredits;
            specification.CumulativeEarnedCreditType = request.CumulativeEarnedCreditType;
            specification.CumulativeGradePointAverage = request.CumulativeGradePointAverage;
            specification.CumulativeGradePointsEarned = request.CumulativeGradePointsEarned;
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.GradeValueQualifier = request.GradeValueQualifier;
            specification.Id = request.Id;
            specification.ProjectedGraduationDate = request.ProjectedGraduationDate;
            specification.SchoolYear = request.SchoolYear;
            specification.SessionAttemptedCreditConversion = request.SessionAttemptedCreditConversion;
            specification.SessionAttemptedCredits = request.SessionAttemptedCredits;
            specification.SessionAttemptedCreditType = request.SessionAttemptedCreditType;
            specification.SessionEarnedCreditConversion = request.SessionEarnedCreditConversion;
            specification.SessionEarnedCredits = request.SessionEarnedCredits;
            specification.SessionEarnedCreditType = request.SessionEarnedCreditType;
            specification.SessionGradePointAverage = request.SessionGradePointAverage;
            specification.SessionGradePointsEarned = request.SessionGradePointsEarned;
            specification.StudentUniqueId = request.StudentUniqueId;
            specification.TermDescriptor = request.TermDescriptor;
                    }
                public IHttpActionResult GetByKey([FromUri] int educationOrganizationId, short schoolYear, string studentUniqueId, string termDescriptor)
        {
            var request = new Api.Models.Requests.v2.StudentAcademicRecords.StudentAcademicRecordGetByKey
            {
                EducationOrganizationId = educationOrganizationId,
                SchoolYear = schoolYear,
                StudentUniqueId = studentUniqueId,
                TermDescriptor = termDescriptor,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IStudentAcademicRecord request)
        {
            return 
                request.EducationOrganizationId != default(int)
                && request.SchoolYear != default(short)
                && request.StudentUniqueId != default(string)
                && request.TermDescriptor != null;
        }

        protected override string GetResourceCollectionName()
        {
            return "studentAcademicRecords";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.StudentAssessments
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class StudentAssessmentsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.StudentAssessment.StudentAssessment, 
        EdFi.Ods.Api.Models.Resources.V2.StudentAssessment.StudentAssessment, 
        EdFi.Ods.Entities.Common.IStudentAssessment, 
        // EdFi.Ods.Entities.NHibernate.StudentAssessmentAggregate.StudentAssessment, 
        Api.Models.Requests.v2.StudentAssessments.StudentAssessmentGetByKey, 
        Api.Models.Requests.v2.StudentAssessments.StudentAssessmentPut,
        Api.Models.Requests.v2.StudentAssessments.StudentAssessmentPost,
        Api.Models.Requests.v2.StudentAssessments.StudentAssessmentDelete,
        Api.Models.Requests.v2.StudentAssessments.StudentAssessmentGetByExample>
    {
        public StudentAssessmentsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.StudentAssessments.StudentAssessmentGetByKey request, IStudentAssessment specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.AssessmentIdentifier = request.AssessmentIdentifier;
            specification.Namespace = request.Namespace;
            specification.StudentAssessmentIdentifier = request.Identifier;
            specification.StudentUniqueId = request.StudentUniqueId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.StudentAssessments.StudentAssessmentGetByExample request, IStudentAssessment specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.AdministrationDate = request.AdministrationDate;
            specification.AdministrationEndDate = request.AdministrationEndDate;
            specification.AdministrationEnvironmentType = request.AdministrationEnvironmentType;
            specification.AdministrationLanguageDescriptor = request.AdministrationLanguageDescriptor;
            specification.AssessmentIdentifier = request.AssessmentIdentifier;
            specification.EventCircumstanceType = request.EventCircumstanceType;
            specification.EventDescription = request.EventDescription;
            specification.Id = request.Id;
            specification.Namespace = request.Namespace;
            specification.ReasonNotTestedType = request.ReasonNotTestedType;
            specification.RetestIndicatorType = request.RetestIndicatorType;
            specification.SerialNumber = request.SerialNumber;
            specification.StudentAssessmentIdentifier = request.Identifier;
            specification.StudentUniqueId = request.StudentUniqueId;
            specification.WhenAssessedGradeLevelDescriptor = request.WhenAssessedGradeLevelDescriptor;
                    }
                public IHttpActionResult GetByKey([FromUri] string assessmentIdentifier, string @namespace, string identifier, string studentUniqueId)
        {
            var request = new Api.Models.Requests.v2.StudentAssessments.StudentAssessmentGetByKey
            {
                AssessmentIdentifier = assessmentIdentifier,
                Namespace = @namespace,
                Identifier = identifier,
                StudentUniqueId = studentUniqueId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IStudentAssessment request)
        {
            return 
                request.AssessmentIdentifier != default(string)
                && request.Namespace != default(string)
                && request.StudentAssessmentIdentifier != default(string)
                && request.StudentUniqueId != default(string);
        }

        protected override string GetResourceCollectionName()
        {
            return "studentAssessments";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.StudentCharacteristicDescriptors
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class StudentCharacteristicDescriptorsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.StudentCharacteristicDescriptor.StudentCharacteristicDescriptor, 
        EdFi.Ods.Api.Models.Resources.V2.StudentCharacteristicDescriptor.StudentCharacteristicDescriptor, 
        EdFi.Ods.Entities.Common.IStudentCharacteristicDescriptor, 
        // EdFi.Ods.Entities.NHibernate.StudentCharacteristicDescriptorAggregate.StudentCharacteristicDescriptor, 
        Api.Models.Requests.v2.StudentCharacteristicDescriptors.StudentCharacteristicDescriptorGetByKey, 
        Api.Models.Requests.v2.StudentCharacteristicDescriptors.StudentCharacteristicDescriptorPut,
        Api.Models.Requests.v2.StudentCharacteristicDescriptors.StudentCharacteristicDescriptorPost,
        Api.Models.Requests.v2.StudentCharacteristicDescriptors.StudentCharacteristicDescriptorDelete,
        Api.Models.Requests.v2.StudentCharacteristicDescriptors.StudentCharacteristicDescriptorGetByExample>
    {
        public StudentCharacteristicDescriptorsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.StudentCharacteristicDescriptors.StudentCharacteristicDescriptorGetByKey request, IStudentCharacteristicDescriptor specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.StudentCharacteristicDescriptorId = request.StudentCharacteristicDescriptorId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.StudentCharacteristicDescriptors.StudentCharacteristicDescriptorGetByExample request, IStudentCharacteristicDescriptor specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.StudentCharacteristicDescriptorId = request.StudentCharacteristicDescriptorId;
            specification.StudentCharacteristicType = request.StudentCharacteristicType;
                    }
                public IHttpActionResult GetByKey([FromUri] int studentCharacteristicDescriptorId)
        {
            var request = new Api.Models.Requests.v2.StudentCharacteristicDescriptors.StudentCharacteristicDescriptorGetByKey
            {
                StudentCharacteristicDescriptorId = studentCharacteristicDescriptorId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IStudentCharacteristicDescriptor request)
        {
            return 
                request.StudentCharacteristicDescriptorId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "studentCharacteristicDescriptors";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.StudentCharacteristicTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class StudentCharacteristicTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.StudentCharacteristicType.StudentCharacteristicType, 
        EdFi.Ods.Api.Models.Resources.V2.StudentCharacteristicType.StudentCharacteristicType, 
        EdFi.Ods.Entities.Common.IStudentCharacteristicType, 
        // EdFi.Ods.Entities.NHibernate.StudentCharacteristicTypeAggregate.StudentCharacteristicType, 
        Api.Models.Requests.v2.StudentCharacteristicTypes.StudentCharacteristicTypeGetByKey, 
        Api.Models.Requests.v2.StudentCharacteristicTypes.StudentCharacteristicTypePut,
        Api.Models.Requests.v2.StudentCharacteristicTypes.StudentCharacteristicTypePost,
        Api.Models.Requests.v2.StudentCharacteristicTypes.StudentCharacteristicTypeDelete,
        Api.Models.Requests.v2.StudentCharacteristicTypes.StudentCharacteristicTypeGetByExample>
    {
        public StudentCharacteristicTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.StudentCharacteristicTypes.StudentCharacteristicTypeGetByKey request, IStudentCharacteristicType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.StudentCharacteristicTypeId = request.StudentCharacteristicTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.StudentCharacteristicTypes.StudentCharacteristicTypeGetByExample request, IStudentCharacteristicType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
            specification.StudentCharacteristicTypeId = request.StudentCharacteristicTypeId;
                    }
                public IHttpActionResult GetByKey([FromUri] int studentCharacteristicTypeId)
        {
            var request = new Api.Models.Requests.v2.StudentCharacteristicTypes.StudentCharacteristicTypeGetByKey
            {
                StudentCharacteristicTypeId = studentCharacteristicTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IStudentCharacteristicType request)
        {
            return 
                request.StudentCharacteristicTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "studentCharacteristicTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.StudentCohortAssociations
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class StudentCohortAssociationsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.StudentCohortAssociation.StudentCohortAssociation, 
        EdFi.Ods.Api.Models.Resources.V2.StudentCohortAssociation.StudentCohortAssociation, 
        EdFi.Ods.Entities.Common.IStudentCohortAssociation, 
        // EdFi.Ods.Entities.NHibernate.StudentCohortAssociationAggregate.StudentCohortAssociation, 
        Api.Models.Requests.v2.StudentCohortAssociations.StudentCohortAssociationGetByKey, 
        Api.Models.Requests.v2.StudentCohortAssociations.StudentCohortAssociationPut,
        Api.Models.Requests.v2.StudentCohortAssociations.StudentCohortAssociationPost,
        Api.Models.Requests.v2.StudentCohortAssociations.StudentCohortAssociationDelete,
        Api.Models.Requests.v2.StudentCohortAssociations.StudentCohortAssociationGetByExample>
    {
        public StudentCohortAssociationsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.StudentCohortAssociations.StudentCohortAssociationGetByKey request, IStudentCohortAssociation specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.BeginDate = request.BeginDate;
            specification.CohortIdentifier = request.CohortIdentifier;
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.StudentUniqueId = request.StudentUniqueId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.StudentCohortAssociations.StudentCohortAssociationGetByExample request, IStudentCohortAssociation specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.BeginDate = request.BeginDate;
            specification.CohortIdentifier = request.CohortIdentifier;
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.EndDate = request.EndDate;
            specification.Id = request.Id;
            specification.StudentUniqueId = request.StudentUniqueId;
                    }
                public IHttpActionResult GetByKey([FromUri] DateTime beginDate, string cohortIdentifier, int educationOrganizationId, string studentUniqueId)
        {
            var request = new Api.Models.Requests.v2.StudentCohortAssociations.StudentCohortAssociationGetByKey
            {
                BeginDate = beginDate,
                CohortIdentifier = cohortIdentifier,
                EducationOrganizationId = educationOrganizationId,
                StudentUniqueId = studentUniqueId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IStudentCohortAssociation request)
        {
            return 
                request.BeginDate != default(DateTime)
                && request.CohortIdentifier != default(string)
                && request.EducationOrganizationId != default(int)
                && request.StudentUniqueId != default(string);
        }

        protected override string GetResourceCollectionName()
        {
            return "studentCohortAssociations";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.StudentCompetencyObjectives
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class StudentCompetencyObjectivesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.StudentCompetencyObjective.StudentCompetencyObjective, 
        EdFi.Ods.Api.Models.Resources.V2.StudentCompetencyObjective.StudentCompetencyObjective, 
        EdFi.Ods.Entities.Common.IStudentCompetencyObjective, 
        // EdFi.Ods.Entities.NHibernate.StudentCompetencyObjectiveAggregate.StudentCompetencyObjective, 
        Api.Models.Requests.v2.StudentCompetencyObjectives.StudentCompetencyObjectiveGetByKey, 
        Api.Models.Requests.v2.StudentCompetencyObjectives.StudentCompetencyObjectivePut,
        Api.Models.Requests.v2.StudentCompetencyObjectives.StudentCompetencyObjectivePost,
        Api.Models.Requests.v2.StudentCompetencyObjectives.StudentCompetencyObjectiveDelete,
        Api.Models.Requests.v2.StudentCompetencyObjectives.StudentCompetencyObjectiveGetByExample>
    {
        public StudentCompetencyObjectivesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.StudentCompetencyObjectives.StudentCompetencyObjectiveGetByKey request, IStudentCompetencyObjective specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.GradingPeriodBeginDate = request.GradingPeriodBeginDate;
            specification.GradingPeriodDescriptor = request.GradingPeriodDescriptor;
            specification.Objective = request.Objective;
            specification.ObjectiveEducationOrganizationId = request.ObjectiveEducationOrganizationId;
            specification.ObjectiveGradeLevelDescriptor = request.ObjectiveGradeLevelDescriptor;
            specification.SchoolId = request.SchoolId;
            specification.StudentUniqueId = request.StudentUniqueId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.StudentCompetencyObjectives.StudentCompetencyObjectiveGetByExample request, IStudentCompetencyObjective specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.BeginDate = request.BeginDate;
            specification.ClassPeriodName = request.ClassPeriodName;
            specification.ClassroomIdentificationCode = request.ClassroomIdentificationCode;
            specification.CompetencyLevelDescriptor = request.CompetencyLevelDescriptor;
            specification.DiagnosticStatement = request.DiagnosticStatement;
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.GradingPeriodBeginDate = request.GradingPeriodBeginDate;
            specification.GradingPeriodDescriptor = request.GradingPeriodDescriptor;
            specification.Id = request.Id;
            specification.LocalCourseCode = request.LocalCourseCode;
            specification.Objective = request.Objective;
            specification.ObjectiveEducationOrganizationId = request.ObjectiveEducationOrganizationId;
            specification.ObjectiveGradeLevelDescriptor = request.ObjectiveGradeLevelDescriptor;
            specification.ProgramEducationOrganizationId = request.ProgramEducationOrganizationId;
            specification.ProgramName = request.ProgramName;
            specification.ProgramType = request.ProgramType;
            specification.SchoolId = request.SchoolId;
            specification.SchoolYear = request.SchoolYear;
            specification.SequenceOfCourse = request.SequenceOfCourse;
            specification.StudentUniqueId = request.StudentUniqueId;
            specification.TermDescriptor = request.TermDescriptor;
            specification.UniqueSectionCode = request.UniqueSectionCode;
                    }
                public IHttpActionResult GetByKey([FromUri] DateTime gradingPeriodBeginDate, string gradingPeriodDescriptor, string objective, int objectiveEducationOrganizationId, string objectiveGradeLevelDescriptor, int schoolId, string studentUniqueId)
        {
            var request = new Api.Models.Requests.v2.StudentCompetencyObjectives.StudentCompetencyObjectiveGetByKey
            {
                GradingPeriodBeginDate = gradingPeriodBeginDate,
                GradingPeriodDescriptor = gradingPeriodDescriptor,
                Objective = objective,
                ObjectiveEducationOrganizationId = objectiveEducationOrganizationId,
                ObjectiveGradeLevelDescriptor = objectiveGradeLevelDescriptor,
                SchoolId = schoolId,
                StudentUniqueId = studentUniqueId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IStudentCompetencyObjective request)
        {
            return 
                request.GradingPeriodBeginDate != default(DateTime)
                && request.GradingPeriodDescriptor != null
                && request.Objective != default(string)
                && request.ObjectiveEducationOrganizationId != default(int)
                && request.ObjectiveGradeLevelDescriptor != null
                && request.SchoolId != default(int)
                && request.StudentUniqueId != default(string);
        }

        protected override string GetResourceCollectionName()
        {
            return "studentCompetencyObjectives";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.StudentCTEProgramAssociations
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class StudentCTEProgramAssociationsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.StudentCTEProgramAssociation.StudentCTEProgramAssociation, 
        EdFi.Ods.Api.Models.Resources.V2.StudentCTEProgramAssociation.StudentCTEProgramAssociation, 
        EdFi.Ods.Entities.Common.IStudentCTEProgramAssociation, 
        // EdFi.Ods.Entities.NHibernate.StudentCTEProgramAssociationAggregate.StudentCTEProgramAssociation, 
        Api.Models.Requests.v2.StudentCTEProgramAssociations.StudentCTEProgramAssociationGetByKey, 
        Api.Models.Requests.v2.StudentCTEProgramAssociations.StudentCTEProgramAssociationPut,
        Api.Models.Requests.v2.StudentCTEProgramAssociations.StudentCTEProgramAssociationPost,
        Api.Models.Requests.v2.StudentCTEProgramAssociations.StudentCTEProgramAssociationDelete,
        Api.Models.Requests.v2.StudentCTEProgramAssociations.StudentCTEProgramAssociationGetByExample>
    {
        public StudentCTEProgramAssociationsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.StudentCTEProgramAssociations.StudentCTEProgramAssociationGetByKey request, IStudentCTEProgramAssociation specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.BeginDate = request.BeginDate;
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.ProgramEducationOrganizationId = request.ProgramEducationOrganizationId;
            specification.ProgramName = request.ProgramName;
            specification.ProgramType = request.ProgramType;
            specification.StudentUniqueId = request.StudentUniqueId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.StudentCTEProgramAssociations.StudentCTEProgramAssociationGetByExample request, IStudentCTEProgramAssociation specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.BeginDate = request.BeginDate;
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.ProgramEducationOrganizationId = request.ProgramEducationOrganizationId;
            specification.ProgramName = request.ProgramName;
            specification.ProgramType = request.ProgramType;
            specification.StudentUniqueId = request.StudentUniqueId;
                    }
                public IHttpActionResult GetByKey([FromUri] DateTime beginDate, int educationOrganizationId, int programEducationOrganizationId, string programName, string programType, string studentUniqueId)
        {
            var request = new Api.Models.Requests.v2.StudentCTEProgramAssociations.StudentCTEProgramAssociationGetByKey
            {
                BeginDate = beginDate,
                EducationOrganizationId = educationOrganizationId,
                ProgramEducationOrganizationId = programEducationOrganizationId,
                ProgramName = programName,
                ProgramType = programType,
                StudentUniqueId = studentUniqueId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IStudentCTEProgramAssociation request)
        {
            return 
                request.BeginDate != default(DateTime)
                && request.EducationOrganizationId != default(int)
                && request.ProgramEducationOrganizationId != default(int)
                && request.ProgramName != default(string)
                && request.ProgramType != null
                && request.StudentUniqueId != default(string);
        }

        protected override string GetResourceCollectionName()
        {
            return "studentCTEProgramAssociations";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.StudentDisciplineIncidentAssociations
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class StudentDisciplineIncidentAssociationsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.StudentDisciplineIncidentAssociation.StudentDisciplineIncidentAssociation, 
        EdFi.Ods.Api.Models.Resources.V2.StudentDisciplineIncidentAssociation.StudentDisciplineIncidentAssociation, 
        EdFi.Ods.Entities.Common.IStudentDisciplineIncidentAssociation, 
        // EdFi.Ods.Entities.NHibernate.StudentDisciplineIncidentAssociationAggregate.StudentDisciplineIncidentAssociation, 
        Api.Models.Requests.v2.StudentDisciplineIncidentAssociations.StudentDisciplineIncidentAssociationGetByKey, 
        Api.Models.Requests.v2.StudentDisciplineIncidentAssociations.StudentDisciplineIncidentAssociationPut,
        Api.Models.Requests.v2.StudentDisciplineIncidentAssociations.StudentDisciplineIncidentAssociationPost,
        Api.Models.Requests.v2.StudentDisciplineIncidentAssociations.StudentDisciplineIncidentAssociationDelete,
        Api.Models.Requests.v2.StudentDisciplineIncidentAssociations.StudentDisciplineIncidentAssociationGetByExample>
    {
        public StudentDisciplineIncidentAssociationsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.StudentDisciplineIncidentAssociations.StudentDisciplineIncidentAssociationGetByKey request, IStudentDisciplineIncidentAssociation specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.IncidentIdentifier = request.IncidentIdentifier;
            specification.SchoolId = request.SchoolId;
            specification.StudentUniqueId = request.StudentUniqueId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.StudentDisciplineIncidentAssociations.StudentDisciplineIncidentAssociationGetByExample request, IStudentDisciplineIncidentAssociation specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.Id = request.Id;
            specification.IncidentIdentifier = request.IncidentIdentifier;
            specification.SchoolId = request.SchoolId;
            specification.StudentParticipationCodeType = request.StudentParticipationCodeType;
            specification.StudentUniqueId = request.StudentUniqueId;
                    }
                public IHttpActionResult GetByKey([FromUri] string incidentIdentifier, int schoolId, string studentUniqueId)
        {
            var request = new Api.Models.Requests.v2.StudentDisciplineIncidentAssociations.StudentDisciplineIncidentAssociationGetByKey
            {
                IncidentIdentifier = incidentIdentifier,
                SchoolId = schoolId,
                StudentUniqueId = studentUniqueId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IStudentDisciplineIncidentAssociation request)
        {
            return 
                request.IncidentIdentifier != default(string)
                && request.SchoolId != default(int)
                && request.StudentUniqueId != default(string);
        }

        protected override string GetResourceCollectionName()
        {
            return "studentDisciplineIncidentAssociations";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.StudentEducationOrganizationAssociations
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class StudentEducationOrganizationAssociationsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.StudentEducationOrganizationAssociation.StudentEducationOrganizationAssociation, 
        EdFi.Ods.Api.Models.Resources.V2.StudentEducationOrganizationAssociation.StudentEducationOrganizationAssociation, 
        EdFi.Ods.Entities.Common.IStudentEducationOrganizationAssociation, 
        // EdFi.Ods.Entities.NHibernate.StudentEducationOrganizationAssociationAggregate.StudentEducationOrganizationAssociation, 
        Api.Models.Requests.v2.StudentEducationOrganizationAssociations.StudentEducationOrganizationAssociationGetByKey, 
        Api.Models.Requests.v2.StudentEducationOrganizationAssociations.StudentEducationOrganizationAssociationPut,
        Api.Models.Requests.v2.StudentEducationOrganizationAssociations.StudentEducationOrganizationAssociationPost,
        Api.Models.Requests.v2.StudentEducationOrganizationAssociations.StudentEducationOrganizationAssociationDelete,
        Api.Models.Requests.v2.StudentEducationOrganizationAssociations.StudentEducationOrganizationAssociationGetByExample>
    {
        public StudentEducationOrganizationAssociationsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.StudentEducationOrganizationAssociations.StudentEducationOrganizationAssociationGetByKey request, IStudentEducationOrganizationAssociation specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.ResponsibilityDescriptor = request.ResponsibilityDescriptor;
            specification.StudentUniqueId = request.StudentUniqueId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.StudentEducationOrganizationAssociations.StudentEducationOrganizationAssociationGetByExample request, IStudentEducationOrganizationAssociation specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.Id = request.Id;
            specification.ResponsibilityDescriptor = request.ResponsibilityDescriptor;
            specification.StudentUniqueId = request.StudentUniqueId;
                    }
                public IHttpActionResult GetByKey([FromUri] int educationOrganizationId, string responsibilityDescriptor, string studentUniqueId)
        {
            var request = new Api.Models.Requests.v2.StudentEducationOrganizationAssociations.StudentEducationOrganizationAssociationGetByKey
            {
                EducationOrganizationId = educationOrganizationId,
                ResponsibilityDescriptor = responsibilityDescriptor,
                StudentUniqueId = studentUniqueId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IStudentEducationOrganizationAssociation request)
        {
            return 
                request.EducationOrganizationId != default(int)
                && request.ResponsibilityDescriptor != null
                && request.StudentUniqueId != default(string);
        }

        protected override string GetResourceCollectionName()
        {
            return "studentEducationOrganizationAssociations";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.StudentGradebookEntries
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class StudentGradebookEntriesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.StudentGradebookEntry.StudentGradebookEntry, 
        EdFi.Ods.Api.Models.Resources.V2.StudentGradebookEntry.StudentGradebookEntry, 
        EdFi.Ods.Entities.Common.IStudentGradebookEntry, 
        // EdFi.Ods.Entities.NHibernate.StudentGradebookEntryAggregate.StudentGradebookEntry, 
        Api.Models.Requests.v2.StudentGradebookEntries.StudentGradebookEntryGetByKey, 
        Api.Models.Requests.v2.StudentGradebookEntries.StudentGradebookEntryPut,
        Api.Models.Requests.v2.StudentGradebookEntries.StudentGradebookEntryPost,
        Api.Models.Requests.v2.StudentGradebookEntries.StudentGradebookEntryDelete,
        Api.Models.Requests.v2.StudentGradebookEntries.StudentGradebookEntryGetByExample>
    {
        public StudentGradebookEntriesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.StudentGradebookEntries.StudentGradebookEntryGetByKey request, IStudentGradebookEntry specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.BeginDate = request.BeginDate;
            specification.ClassPeriodName = request.ClassPeriodName;
            specification.ClassroomIdentificationCode = request.ClassroomIdentificationCode;
            specification.DateAssigned = request.DateAssigned;
            specification.GradebookEntryTitle = request.GradebookEntryTitle;
            specification.LocalCourseCode = request.LocalCourseCode;
            specification.SchoolId = request.SchoolId;
            specification.SchoolYear = request.SchoolYear;
            specification.SequenceOfCourse = request.SequenceOfCourse;
            specification.StudentUniqueId = request.StudentUniqueId;
            specification.TermDescriptor = request.TermDescriptor;
            specification.UniqueSectionCode = request.UniqueSectionCode;
                    }

        protected override void MapAll(Api.Models.Requests.v2.StudentGradebookEntries.StudentGradebookEntryGetByExample request, IStudentGradebookEntry specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.BeginDate = request.BeginDate;
            specification.ClassPeriodName = request.ClassPeriodName;
            specification.ClassroomIdentificationCode = request.ClassroomIdentificationCode;
            specification.CompetencyLevelDescriptor = request.CompetencyLevelDescriptor;
            specification.DateAssigned = request.DateAssigned;
            specification.DateFulfilled = request.DateFulfilled;
            specification.DiagnosticStatement = request.DiagnosticStatement;
            specification.GradebookEntryTitle = request.GradebookEntryTitle;
            specification.Id = request.Id;
            specification.LetterGradeEarned = request.LetterGradeEarned;
            specification.LocalCourseCode = request.LocalCourseCode;
            specification.NumericGradeEarned = request.NumericGradeEarned;
            specification.SchoolId = request.SchoolId;
            specification.SchoolYear = request.SchoolYear;
            specification.SequenceOfCourse = request.SequenceOfCourse;
            specification.StudentUniqueId = request.StudentUniqueId;
            specification.TermDescriptor = request.TermDescriptor;
            specification.UniqueSectionCode = request.UniqueSectionCode;
                    }
                public IHttpActionResult GetByKey([FromUri] DateTime beginDate, string classPeriodName, string classroomIdentificationCode, DateTime dateAssigned, string gradebookEntryTitle, string localCourseCode, int schoolId, short schoolYear, int sequenceOfCourse, string studentUniqueId, string termDescriptor, string uniqueSectionCode)
        {
            var request = new Api.Models.Requests.v2.StudentGradebookEntries.StudentGradebookEntryGetByKey
            {
                BeginDate = beginDate,
                ClassPeriodName = classPeriodName,
                ClassroomIdentificationCode = classroomIdentificationCode,
                DateAssigned = dateAssigned,
                GradebookEntryTitle = gradebookEntryTitle,
                LocalCourseCode = localCourseCode,
                SchoolId = schoolId,
                SchoolYear = schoolYear,
                SequenceOfCourse = sequenceOfCourse,
                StudentUniqueId = studentUniqueId,
                TermDescriptor = termDescriptor,
                UniqueSectionCode = uniqueSectionCode,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IStudentGradebookEntry request)
        {
            return 
                request.BeginDate != default(DateTime)
                && request.ClassPeriodName != default(string)
                && request.ClassroomIdentificationCode != default(string)
                && request.DateAssigned != default(DateTime)
                && request.GradebookEntryTitle != default(string)
                && request.LocalCourseCode != default(string)
                && request.SchoolId != default(int)
                && request.SchoolYear != default(short)
                && request.SequenceOfCourse != default(int)
                && request.StudentUniqueId != default(string)
                && request.TermDescriptor != null
                && request.UniqueSectionCode != default(string);
        }

        protected override string GetResourceCollectionName()
        {
            return "studentGradebookEntries";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.StudentIdentificationSystemDescriptors
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class StudentIdentificationSystemDescriptorsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.StudentIdentificationSystemDescriptor.StudentIdentificationSystemDescriptor, 
        EdFi.Ods.Api.Models.Resources.V2.StudentIdentificationSystemDescriptor.StudentIdentificationSystemDescriptor, 
        EdFi.Ods.Entities.Common.IStudentIdentificationSystemDescriptor, 
        // EdFi.Ods.Entities.NHibernate.StudentIdentificationSystemDescriptorAggregate.StudentIdentificationSystemDescriptor, 
        Api.Models.Requests.v2.StudentIdentificationSystemDescriptors.StudentIdentificationSystemDescriptorGetByKey, 
        Api.Models.Requests.v2.StudentIdentificationSystemDescriptors.StudentIdentificationSystemDescriptorPut,
        Api.Models.Requests.v2.StudentIdentificationSystemDescriptors.StudentIdentificationSystemDescriptorPost,
        Api.Models.Requests.v2.StudentIdentificationSystemDescriptors.StudentIdentificationSystemDescriptorDelete,
        Api.Models.Requests.v2.StudentIdentificationSystemDescriptors.StudentIdentificationSystemDescriptorGetByExample>
    {
        public StudentIdentificationSystemDescriptorsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.StudentIdentificationSystemDescriptors.StudentIdentificationSystemDescriptorGetByKey request, IStudentIdentificationSystemDescriptor specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.StudentIdentificationSystemDescriptorId = request.StudentIdentificationSystemDescriptorId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.StudentIdentificationSystemDescriptors.StudentIdentificationSystemDescriptorGetByExample request, IStudentIdentificationSystemDescriptor specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.StudentIdentificationSystemDescriptorId = request.StudentIdentificationSystemDescriptorId;
            specification.StudentIdentificationSystemType = request.StudentIdentificationSystemType;
                    }
                public IHttpActionResult GetByKey([FromUri] int studentIdentificationSystemDescriptorId)
        {
            var request = new Api.Models.Requests.v2.StudentIdentificationSystemDescriptors.StudentIdentificationSystemDescriptorGetByKey
            {
                StudentIdentificationSystemDescriptorId = studentIdentificationSystemDescriptorId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IStudentIdentificationSystemDescriptor request)
        {
            return 
                request.StudentIdentificationSystemDescriptorId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "studentIdentificationSystemDescriptors";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.StudentIdentificationSystemTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class StudentIdentificationSystemTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.StudentIdentificationSystemType.StudentIdentificationSystemType, 
        EdFi.Ods.Api.Models.Resources.V2.StudentIdentificationSystemType.StudentIdentificationSystemType, 
        EdFi.Ods.Entities.Common.IStudentIdentificationSystemType, 
        // EdFi.Ods.Entities.NHibernate.StudentIdentificationSystemTypeAggregate.StudentIdentificationSystemType, 
        Api.Models.Requests.v2.StudentIdentificationSystemTypes.StudentIdentificationSystemTypeGetByKey, 
        Api.Models.Requests.v2.StudentIdentificationSystemTypes.StudentIdentificationSystemTypePut,
        Api.Models.Requests.v2.StudentIdentificationSystemTypes.StudentIdentificationSystemTypePost,
        Api.Models.Requests.v2.StudentIdentificationSystemTypes.StudentIdentificationSystemTypeDelete,
        Api.Models.Requests.v2.StudentIdentificationSystemTypes.StudentIdentificationSystemTypeGetByExample>
    {
        public StudentIdentificationSystemTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.StudentIdentificationSystemTypes.StudentIdentificationSystemTypeGetByKey request, IStudentIdentificationSystemType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.StudentIdentificationSystemTypeId = request.StudentIdentificationSystemTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.StudentIdentificationSystemTypes.StudentIdentificationSystemTypeGetByExample request, IStudentIdentificationSystemType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
            specification.StudentIdentificationSystemTypeId = request.StudentIdentificationSystemTypeId;
                    }
                public IHttpActionResult GetByKey([FromUri] int studentIdentificationSystemTypeId)
        {
            var request = new Api.Models.Requests.v2.StudentIdentificationSystemTypes.StudentIdentificationSystemTypeGetByKey
            {
                StudentIdentificationSystemTypeId = studentIdentificationSystemTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IStudentIdentificationSystemType request)
        {
            return 
                request.StudentIdentificationSystemTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "studentIdentificationSystemTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.StudentInterventionAssociations
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class StudentInterventionAssociationsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.StudentInterventionAssociation.StudentInterventionAssociation, 
        EdFi.Ods.Api.Models.Resources.V2.StudentInterventionAssociation.StudentInterventionAssociation, 
        EdFi.Ods.Entities.Common.IStudentInterventionAssociation, 
        // EdFi.Ods.Entities.NHibernate.StudentInterventionAssociationAggregate.StudentInterventionAssociation, 
        Api.Models.Requests.v2.StudentInterventionAssociations.StudentInterventionAssociationGetByKey, 
        Api.Models.Requests.v2.StudentInterventionAssociations.StudentInterventionAssociationPut,
        Api.Models.Requests.v2.StudentInterventionAssociations.StudentInterventionAssociationPost,
        Api.Models.Requests.v2.StudentInterventionAssociations.StudentInterventionAssociationDelete,
        Api.Models.Requests.v2.StudentInterventionAssociations.StudentInterventionAssociationGetByExample>
    {
        public StudentInterventionAssociationsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.StudentInterventionAssociations.StudentInterventionAssociationGetByKey request, IStudentInterventionAssociation specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.InterventionIdentificationCode = request.InterventionIdentificationCode;
            specification.StudentUniqueId = request.StudentUniqueId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.StudentInterventionAssociations.StudentInterventionAssociationGetByExample request, IStudentInterventionAssociation specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CohortEducationOrganizationId = request.CohortEducationOrganizationId;
            specification.CohortIdentifier = request.CohortIdentifier;
            specification.DiagnosticStatement = request.DiagnosticStatement;
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.Id = request.Id;
            specification.InterventionIdentificationCode = request.InterventionIdentificationCode;
            specification.StudentUniqueId = request.StudentUniqueId;
                    }
                public IHttpActionResult GetByKey([FromUri] int educationOrganizationId, string interventionIdentificationCode, string studentUniqueId)
        {
            var request = new Api.Models.Requests.v2.StudentInterventionAssociations.StudentInterventionAssociationGetByKey
            {
                EducationOrganizationId = educationOrganizationId,
                InterventionIdentificationCode = interventionIdentificationCode,
                StudentUniqueId = studentUniqueId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IStudentInterventionAssociation request)
        {
            return 
                request.EducationOrganizationId != default(int)
                && request.InterventionIdentificationCode != default(string)
                && request.StudentUniqueId != default(string);
        }

        protected override string GetResourceCollectionName()
        {
            return "studentInterventionAssociations";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.StudentInterventionAttendanceEvents
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class StudentInterventionAttendanceEventsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.StudentInterventionAttendanceEvent.StudentInterventionAttendanceEvent, 
        EdFi.Ods.Api.Models.Resources.V2.StudentInterventionAttendanceEvent.StudentInterventionAttendanceEvent, 
        EdFi.Ods.Entities.Common.IStudentInterventionAttendanceEvent, 
        // EdFi.Ods.Entities.NHibernate.StudentInterventionAttendanceEventAggregate.StudentInterventionAttendanceEvent, 
        Api.Models.Requests.v2.StudentInterventionAttendanceEvents.StudentInterventionAttendanceEventGetByKey, 
        Api.Models.Requests.v2.StudentInterventionAttendanceEvents.StudentInterventionAttendanceEventPut,
        Api.Models.Requests.v2.StudentInterventionAttendanceEvents.StudentInterventionAttendanceEventPost,
        Api.Models.Requests.v2.StudentInterventionAttendanceEvents.StudentInterventionAttendanceEventDelete,
        Api.Models.Requests.v2.StudentInterventionAttendanceEvents.StudentInterventionAttendanceEventGetByExample>
    {
        public StudentInterventionAttendanceEventsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.StudentInterventionAttendanceEvents.StudentInterventionAttendanceEventGetByKey request, IStudentInterventionAttendanceEvent specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.AttendanceEventCategoryDescriptor = request.AttendanceEventCategoryDescriptor;
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.EventDate = request.EventDate;
            specification.InterventionIdentificationCode = request.InterventionIdentificationCode;
            specification.StudentUniqueId = request.StudentUniqueId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.StudentInterventionAttendanceEvents.StudentInterventionAttendanceEventGetByExample request, IStudentInterventionAttendanceEvent specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.AttendanceEventCategoryDescriptor = request.AttendanceEventCategoryDescriptor;
            specification.AttendanceEventReason = request.AttendanceEventReason;
            specification.EducationalEnvironmentType = request.EducationalEnvironmentType;
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.EventDate = request.EventDate;
            specification.Id = request.Id;
            specification.InterventionIdentificationCode = request.InterventionIdentificationCode;
            specification.StudentUniqueId = request.StudentUniqueId;
                    }
                public IHttpActionResult GetByKey([FromUri] string attendanceEventCategoryDescriptor, int educationOrganizationId, DateTime eventDate, string interventionIdentificationCode, string studentUniqueId)
        {
            var request = new Api.Models.Requests.v2.StudentInterventionAttendanceEvents.StudentInterventionAttendanceEventGetByKey
            {
                AttendanceEventCategoryDescriptor = attendanceEventCategoryDescriptor,
                EducationOrganizationId = educationOrganizationId,
                EventDate = eventDate,
                InterventionIdentificationCode = interventionIdentificationCode,
                StudentUniqueId = studentUniqueId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IStudentInterventionAttendanceEvent request)
        {
            return 
                request.AttendanceEventCategoryDescriptor != null
                && request.EducationOrganizationId != default(int)
                && request.EventDate != default(DateTime)
                && request.InterventionIdentificationCode != default(string)
                && request.StudentUniqueId != default(string);
        }

        protected override string GetResourceCollectionName()
        {
            return "studentInterventionAttendanceEvents";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.StudentLearningObjectives
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class StudentLearningObjectivesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.StudentLearningObjective.StudentLearningObjective, 
        EdFi.Ods.Api.Models.Resources.V2.StudentLearningObjective.StudentLearningObjective, 
        EdFi.Ods.Entities.Common.IStudentLearningObjective, 
        // EdFi.Ods.Entities.NHibernate.StudentLearningObjectiveAggregate.StudentLearningObjective, 
        Api.Models.Requests.v2.StudentLearningObjectives.StudentLearningObjectiveGetByKey, 
        Api.Models.Requests.v2.StudentLearningObjectives.StudentLearningObjectivePut,
        Api.Models.Requests.v2.StudentLearningObjectives.StudentLearningObjectivePost,
        Api.Models.Requests.v2.StudentLearningObjectives.StudentLearningObjectiveDelete,
        Api.Models.Requests.v2.StudentLearningObjectives.StudentLearningObjectiveGetByExample>
    {
        public StudentLearningObjectivesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.StudentLearningObjectives.StudentLearningObjectiveGetByKey request, IStudentLearningObjective specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.GradingPeriodBeginDate = request.GradingPeriodBeginDate;
            specification.GradingPeriodDescriptor = request.GradingPeriodDescriptor;
            specification.LearningObjectiveId = request.LearningObjectiveId;
            specification.Namespace = request.Namespace;
            specification.SchoolId = request.SchoolId;
            specification.StudentUniqueId = request.StudentUniqueId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.StudentLearningObjectives.StudentLearningObjectiveGetByExample request, IStudentLearningObjective specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.BeginDate = request.BeginDate;
            specification.ClassPeriodName = request.ClassPeriodName;
            specification.ClassroomIdentificationCode = request.ClassroomIdentificationCode;
            specification.CompetencyLevelDescriptor = request.CompetencyLevelDescriptor;
            specification.DiagnosticStatement = request.DiagnosticStatement;
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.GradingPeriodBeginDate = request.GradingPeriodBeginDate;
            specification.GradingPeriodDescriptor = request.GradingPeriodDescriptor;
            specification.Id = request.Id;
            specification.LearningObjectiveId = request.LearningObjectiveId;
            specification.LocalCourseCode = request.LocalCourseCode;
            specification.Namespace = request.Namespace;
            specification.ProgramEducationOrganizationId = request.ProgramEducationOrganizationId;
            specification.ProgramName = request.ProgramName;
            specification.ProgramType = request.ProgramType;
            specification.SchoolId = request.SchoolId;
            specification.SchoolYear = request.SchoolYear;
            specification.SequenceOfCourse = request.SequenceOfCourse;
            specification.StudentSectionAssociationBeginDate = request.StudentSectionAssociationBeginDate;
            specification.StudentUniqueId = request.StudentUniqueId;
            specification.TermDescriptor = request.TermDescriptor;
            specification.UniqueSectionCode = request.UniqueSectionCode;
                    }
                public IHttpActionResult GetByKey([FromUri] DateTime gradingPeriodBeginDate, string gradingPeriodDescriptor, string learningObjectiveId, string @namespace, int schoolId, string studentUniqueId)
        {
            var request = new Api.Models.Requests.v2.StudentLearningObjectives.StudentLearningObjectiveGetByKey
            {
                GradingPeriodBeginDate = gradingPeriodBeginDate,
                GradingPeriodDescriptor = gradingPeriodDescriptor,
                LearningObjectiveId = learningObjectiveId,
                Namespace = @namespace,
                SchoolId = schoolId,
                StudentUniqueId = studentUniqueId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IStudentLearningObjective request)
        {
            return 
                request.GradingPeriodBeginDate != default(DateTime)
                && request.GradingPeriodDescriptor != null
                && request.LearningObjectiveId != default(string)
                && request.Namespace != default(string)
                && request.SchoolId != default(int)
                && request.StudentUniqueId != default(string);
        }

        protected override string GetResourceCollectionName()
        {
            return "studentLearningObjectives";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.StudentMigrantEducationProgramAssociations
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class StudentMigrantEducationProgramAssociationsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.StudentMigrantEducationProgramAssociation.StudentMigrantEducationProgramAssociation, 
        EdFi.Ods.Api.Models.Resources.V2.StudentMigrantEducationProgramAssociation.StudentMigrantEducationProgramAssociation, 
        EdFi.Ods.Entities.Common.IStudentMigrantEducationProgramAssociation, 
        // EdFi.Ods.Entities.NHibernate.StudentMigrantEducationProgramAssociationAggregate.StudentMigrantEducationProgramAssociation, 
        Api.Models.Requests.v2.StudentMigrantEducationProgramAssociations.StudentMigrantEducationProgramAssociationGetByKey, 
        Api.Models.Requests.v2.StudentMigrantEducationProgramAssociations.StudentMigrantEducationProgramAssociationPut,
        Api.Models.Requests.v2.StudentMigrantEducationProgramAssociations.StudentMigrantEducationProgramAssociationPost,
        Api.Models.Requests.v2.StudentMigrantEducationProgramAssociations.StudentMigrantEducationProgramAssociationDelete,
        Api.Models.Requests.v2.StudentMigrantEducationProgramAssociations.StudentMigrantEducationProgramAssociationGetByExample>
    {
        public StudentMigrantEducationProgramAssociationsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.StudentMigrantEducationProgramAssociations.StudentMigrantEducationProgramAssociationGetByKey request, IStudentMigrantEducationProgramAssociation specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.BeginDate = request.BeginDate;
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.ProgramEducationOrganizationId = request.ProgramEducationOrganizationId;
            specification.ProgramName = request.ProgramName;
            specification.ProgramType = request.ProgramType;
            specification.StudentUniqueId = request.StudentUniqueId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.StudentMigrantEducationProgramAssociations.StudentMigrantEducationProgramAssociationGetByExample request, IStudentMigrantEducationProgramAssociation specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.BeginDate = request.BeginDate;
            specification.ContinuationOfServicesReasonDescriptor = request.ContinuationOfServicesReasonDescriptor;
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.LastQualifyingMove = request.LastQualifyingMove;
            specification.PriorityForServices = request.PriorityForServices;
            specification.ProgramEducationOrganizationId = request.ProgramEducationOrganizationId;
            specification.ProgramName = request.ProgramName;
            specification.ProgramType = request.ProgramType;
            specification.StudentUniqueId = request.StudentUniqueId;
            specification.USInitialEntry = request.USInitialEntry;
            specification.USInitialSchoolEntry = request.USInitialSchoolEntry;
            specification.USMostRecentEntry = request.USMostRecentEntry;
                    }
                public IHttpActionResult GetByKey([FromUri] DateTime beginDate, int educationOrganizationId, int programEducationOrganizationId, string programName, string programType, string studentUniqueId)
        {
            var request = new Api.Models.Requests.v2.StudentMigrantEducationProgramAssociations.StudentMigrantEducationProgramAssociationGetByKey
            {
                BeginDate = beginDate,
                EducationOrganizationId = educationOrganizationId,
                ProgramEducationOrganizationId = programEducationOrganizationId,
                ProgramName = programName,
                ProgramType = programType,
                StudentUniqueId = studentUniqueId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IStudentMigrantEducationProgramAssociation request)
        {
            return 
                request.BeginDate != default(DateTime)
                && request.EducationOrganizationId != default(int)
                && request.ProgramEducationOrganizationId != default(int)
                && request.ProgramName != default(string)
                && request.ProgramType != null
                && request.StudentUniqueId != default(string);
        }

        protected override string GetResourceCollectionName()
        {
            return "studentMigrantEducationProgramAssociations";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.StudentParentAssociations
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class StudentParentAssociationsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.StudentParentAssociation.StudentParentAssociation, 
        EdFi.Ods.Api.Models.Resources.V2.StudentParentAssociation.StudentParentAssociation, 
        EdFi.Ods.Entities.Common.IStudentParentAssociation, 
        // EdFi.Ods.Entities.NHibernate.StudentParentAssociationAggregate.StudentParentAssociation, 
        Api.Models.Requests.v2.StudentParentAssociations.StudentParentAssociationGetByKey, 
        Api.Models.Requests.v2.StudentParentAssociations.StudentParentAssociationPut,
        Api.Models.Requests.v2.StudentParentAssociations.StudentParentAssociationPost,
        Api.Models.Requests.v2.StudentParentAssociations.StudentParentAssociationDelete,
        Api.Models.Requests.v2.StudentParentAssociations.StudentParentAssociationGetByExample>
    {
        public StudentParentAssociationsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.StudentParentAssociations.StudentParentAssociationGetByKey request, IStudentParentAssociation specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.ParentUniqueId = request.ParentUniqueId;
            specification.StudentUniqueId = request.StudentUniqueId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.StudentParentAssociations.StudentParentAssociationGetByExample request, IStudentParentAssociation specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.ContactPriority = request.ContactPriority;
            specification.ContactRestrictions = request.ContactRestrictions;
            specification.EmergencyContactStatus = request.EmergencyContactStatus;
            specification.Id = request.Id;
            specification.LivesWith = request.LivesWith;
            specification.ParentUniqueId = request.ParentUniqueId;
            specification.PrimaryContactStatus = request.PrimaryContactStatus;
            specification.RelationType = request.RelationType;
            specification.StudentUniqueId = request.StudentUniqueId;
                    }
                public IHttpActionResult GetByKey([FromUri] string parentUniqueId, string studentUniqueId)
        {
            var request = new Api.Models.Requests.v2.StudentParentAssociations.StudentParentAssociationGetByKey
            {
                ParentUniqueId = parentUniqueId,
                StudentUniqueId = studentUniqueId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IStudentParentAssociation request)
        {
            return 
                request.ParentUniqueId != default(string)
                && request.StudentUniqueId != default(string);
        }

        protected override string GetResourceCollectionName()
        {
            return "studentParentAssociations";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.StudentParticipationCodeTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class StudentParticipationCodeTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.StudentParticipationCodeType.StudentParticipationCodeType, 
        EdFi.Ods.Api.Models.Resources.V2.StudentParticipationCodeType.StudentParticipationCodeType, 
        EdFi.Ods.Entities.Common.IStudentParticipationCodeType, 
        // EdFi.Ods.Entities.NHibernate.StudentParticipationCodeTypeAggregate.StudentParticipationCodeType, 
        Api.Models.Requests.v2.StudentParticipationCodeTypes.StudentParticipationCodeTypeGetByKey, 
        Api.Models.Requests.v2.StudentParticipationCodeTypes.StudentParticipationCodeTypePut,
        Api.Models.Requests.v2.StudentParticipationCodeTypes.StudentParticipationCodeTypePost,
        Api.Models.Requests.v2.StudentParticipationCodeTypes.StudentParticipationCodeTypeDelete,
        Api.Models.Requests.v2.StudentParticipationCodeTypes.StudentParticipationCodeTypeGetByExample>
    {
        public StudentParticipationCodeTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.StudentParticipationCodeTypes.StudentParticipationCodeTypeGetByKey request, IStudentParticipationCodeType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.StudentParticipationCodeTypeId = request.StudentParticipationCodeTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.StudentParticipationCodeTypes.StudentParticipationCodeTypeGetByExample request, IStudentParticipationCodeType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
            specification.StudentParticipationCodeTypeId = request.StudentParticipationCodeTypeId;
                    }
                public IHttpActionResult GetByKey([FromUri] int studentParticipationCodeTypeId)
        {
            var request = new Api.Models.Requests.v2.StudentParticipationCodeTypes.StudentParticipationCodeTypeGetByKey
            {
                StudentParticipationCodeTypeId = studentParticipationCodeTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IStudentParticipationCodeType request)
        {
            return 
                request.StudentParticipationCodeTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "studentParticipationCodeTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.StudentProgramAssociations
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class StudentProgramAssociationsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.StudentProgramAssociation.StudentProgramAssociation, 
        EdFi.Ods.Api.Models.Resources.V2.StudentProgramAssociation.StudentProgramAssociation, 
        EdFi.Ods.Entities.Common.IStudentProgramAssociation, 
        // EdFi.Ods.Entities.NHibernate.StudentProgramAssociationAggregate.StudentProgramAssociation, 
        Api.Models.Requests.v2.StudentProgramAssociations.StudentProgramAssociationGetByKey, 
        Api.Models.Requests.v2.StudentProgramAssociations.StudentProgramAssociationPut,
        Api.Models.Requests.v2.StudentProgramAssociations.StudentProgramAssociationPost,
        Api.Models.Requests.v2.StudentProgramAssociations.StudentProgramAssociationDelete,
        Api.Models.Requests.v2.StudentProgramAssociations.StudentProgramAssociationGetByExample>
    {
        public StudentProgramAssociationsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.StudentProgramAssociations.StudentProgramAssociationGetByKey request, IStudentProgramAssociation specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.BeginDate = request.BeginDate;
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.ProgramEducationOrganizationId = request.ProgramEducationOrganizationId;
            specification.ProgramName = request.ProgramName;
            specification.ProgramType = request.ProgramType;
            specification.StudentUniqueId = request.StudentUniqueId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.StudentProgramAssociations.StudentProgramAssociationGetByExample request, IStudentProgramAssociation specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.BeginDate = request.BeginDate;
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.EndDate = request.EndDate;
            specification.Id = request.Id;
            specification.ProgramEducationOrganizationId = request.ProgramEducationOrganizationId;
            specification.ProgramName = request.ProgramName;
            specification.ProgramType = request.ProgramType;
            specification.ReasonExitedDescriptor = request.ReasonExitedDescriptor;
            specification.ServedOutsideOfRegularSession = request.ServedOutsideOfRegularSession;
            specification.StudentUniqueId = request.StudentUniqueId;
                    }
                public IHttpActionResult GetByKey([FromUri] DateTime beginDate, int educationOrganizationId, int programEducationOrganizationId, string programName, string programType, string studentUniqueId)
        {
            var request = new Api.Models.Requests.v2.StudentProgramAssociations.StudentProgramAssociationGetByKey
            {
                BeginDate = beginDate,
                EducationOrganizationId = educationOrganizationId,
                ProgramEducationOrganizationId = programEducationOrganizationId,
                ProgramName = programName,
                ProgramType = programType,
                StudentUniqueId = studentUniqueId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IStudentProgramAssociation request)
        {
            return 
                request.BeginDate != default(DateTime)
                && request.EducationOrganizationId != default(int)
                && request.ProgramEducationOrganizationId != default(int)
                && request.ProgramName != default(string)
                && request.ProgramType != null
                && request.StudentUniqueId != default(string);
        }

        protected override string GetResourceCollectionName()
        {
            return "studentProgramAssociations";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.StudentProgramAttendanceEvents
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class StudentProgramAttendanceEventsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.StudentProgramAttendanceEvent.StudentProgramAttendanceEvent, 
        EdFi.Ods.Api.Models.Resources.V2.StudentProgramAttendanceEvent.StudentProgramAttendanceEvent, 
        EdFi.Ods.Entities.Common.IStudentProgramAttendanceEvent, 
        // EdFi.Ods.Entities.NHibernate.StudentProgramAttendanceEventAggregate.StudentProgramAttendanceEvent, 
        Api.Models.Requests.v2.StudentProgramAttendanceEvents.StudentProgramAttendanceEventGetByKey, 
        Api.Models.Requests.v2.StudentProgramAttendanceEvents.StudentProgramAttendanceEventPut,
        Api.Models.Requests.v2.StudentProgramAttendanceEvents.StudentProgramAttendanceEventPost,
        Api.Models.Requests.v2.StudentProgramAttendanceEvents.StudentProgramAttendanceEventDelete,
        Api.Models.Requests.v2.StudentProgramAttendanceEvents.StudentProgramAttendanceEventGetByExample>
    {
        public StudentProgramAttendanceEventsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.StudentProgramAttendanceEvents.StudentProgramAttendanceEventGetByKey request, IStudentProgramAttendanceEvent specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.AttendanceEventCategoryDescriptor = request.AttendanceEventCategoryDescriptor;
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.EventDate = request.EventDate;
            specification.ProgramEducationOrganizationId = request.ProgramEducationOrganizationId;
            specification.ProgramName = request.ProgramName;
            specification.ProgramType = request.ProgramType;
            specification.StudentUniqueId = request.StudentUniqueId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.StudentProgramAttendanceEvents.StudentProgramAttendanceEventGetByExample request, IStudentProgramAttendanceEvent specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.AttendanceEventCategoryDescriptor = request.AttendanceEventCategoryDescriptor;
            specification.AttendanceEventReason = request.AttendanceEventReason;
            specification.EducationalEnvironmentType = request.EducationalEnvironmentType;
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.EventDate = request.EventDate;
            specification.Id = request.Id;
            specification.ProgramEducationOrganizationId = request.ProgramEducationOrganizationId;
            specification.ProgramName = request.ProgramName;
            specification.ProgramType = request.ProgramType;
            specification.StudentUniqueId = request.StudentUniqueId;
                    }
                public IHttpActionResult GetByKey([FromUri] string attendanceEventCategoryDescriptor, int educationOrganizationId, DateTime eventDate, int programEducationOrganizationId, string programName, string programType, string studentUniqueId)
        {
            var request = new Api.Models.Requests.v2.StudentProgramAttendanceEvents.StudentProgramAttendanceEventGetByKey
            {
                AttendanceEventCategoryDescriptor = attendanceEventCategoryDescriptor,
                EducationOrganizationId = educationOrganizationId,
                EventDate = eventDate,
                ProgramEducationOrganizationId = programEducationOrganizationId,
                ProgramName = programName,
                ProgramType = programType,
                StudentUniqueId = studentUniqueId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IStudentProgramAttendanceEvent request)
        {
            return 
                request.AttendanceEventCategoryDescriptor != null
                && request.EducationOrganizationId != default(int)
                && request.EventDate != default(DateTime)
                && request.ProgramEducationOrganizationId != default(int)
                && request.ProgramName != default(string)
                && request.ProgramType != null
                && request.StudentUniqueId != default(string);
        }

        protected override string GetResourceCollectionName()
        {
            return "studentProgramAttendanceEvents";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.StudentSchoolAssociations
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class StudentSchoolAssociationsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.StudentSchoolAssociation.StudentSchoolAssociation, 
        EdFi.Ods.Api.Models.Resources.V2.StudentSchoolAssociation.StudentSchoolAssociation, 
        EdFi.Ods.Entities.Common.IStudentSchoolAssociation, 
        // EdFi.Ods.Entities.NHibernate.StudentSchoolAssociationAggregate.StudentSchoolAssociation, 
        Api.Models.Requests.v2.StudentSchoolAssociations.StudentSchoolAssociationGetByKey, 
        Api.Models.Requests.v2.StudentSchoolAssociations.StudentSchoolAssociationPut,
        Api.Models.Requests.v2.StudentSchoolAssociations.StudentSchoolAssociationPost,
        Api.Models.Requests.v2.StudentSchoolAssociations.StudentSchoolAssociationDelete,
        Api.Models.Requests.v2.StudentSchoolAssociations.StudentSchoolAssociationGetByExample>
    {
        public StudentSchoolAssociationsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.StudentSchoolAssociations.StudentSchoolAssociationGetByKey request, IStudentSchoolAssociation specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.EntryDate = request.EntryDate;
            specification.SchoolId = request.SchoolId;
            specification.StudentUniqueId = request.StudentUniqueId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.StudentSchoolAssociations.StudentSchoolAssociationGetByExample request, IStudentSchoolAssociation specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.ClassOfSchoolYear = request.ClassOfSchoolYear;
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.EmployedWhileEnrolled = request.EmployedWhileEnrolled;
            specification.EntryDate = request.EntryDate;
            specification.EntryGradeLevelDescriptor = request.EntryGradeLevelDescriptor;
            specification.EntryGradeLevelReasonType = request.EntryGradeLevelReasonType;
            specification.EntryTypeDescriptor = request.EntryTypeDescriptor;
            specification.ExitWithdrawDate = request.ExitWithdrawDate;
            specification.ExitWithdrawTypeDescriptor = request.ExitWithdrawTypeDescriptor;
            specification.GraduationPlanTypeDescriptor = request.GraduationPlanTypeDescriptor;
            specification.GraduationSchoolYear = request.GraduationSchoolYear;
            specification.Id = request.Id;
            specification.PrimarySchool = request.PrimarySchool;
            specification.RepeatGradeIndicator = request.RepeatGradeIndicator;
            specification.ResidencyStatusDescriptor = request.ResidencyStatusDescriptor;
            specification.SchoolChoiceTransfer = request.SchoolChoiceTransfer;
            specification.SchoolId = request.SchoolId;
            specification.SchoolYear = request.SchoolYear;
            specification.StudentUniqueId = request.StudentUniqueId;
                    }
                public IHttpActionResult GetByKey([FromUri] DateTime entryDate, int schoolId, string studentUniqueId)
        {
            var request = new Api.Models.Requests.v2.StudentSchoolAssociations.StudentSchoolAssociationGetByKey
            {
                EntryDate = entryDate,
                SchoolId = schoolId,
                StudentUniqueId = studentUniqueId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IStudentSchoolAssociation request)
        {
            return 
                request.EntryDate != default(DateTime)
                && request.SchoolId != default(int)
                && request.StudentUniqueId != default(string);
        }

        protected override string GetResourceCollectionName()
        {
            return "studentSchoolAssociations";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.StudentSchoolAttendanceEvents
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class StudentSchoolAttendanceEventsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.StudentSchoolAttendanceEvent.StudentSchoolAttendanceEvent, 
        EdFi.Ods.Api.Models.Resources.V2.StudentSchoolAttendanceEvent.StudentSchoolAttendanceEvent, 
        EdFi.Ods.Entities.Common.IStudentSchoolAttendanceEvent, 
        // EdFi.Ods.Entities.NHibernate.StudentSchoolAttendanceEventAggregate.StudentSchoolAttendanceEvent, 
        Api.Models.Requests.v2.StudentSchoolAttendanceEvents.StudentSchoolAttendanceEventGetByKey, 
        Api.Models.Requests.v2.StudentSchoolAttendanceEvents.StudentSchoolAttendanceEventPut,
        Api.Models.Requests.v2.StudentSchoolAttendanceEvents.StudentSchoolAttendanceEventPost,
        Api.Models.Requests.v2.StudentSchoolAttendanceEvents.StudentSchoolAttendanceEventDelete,
        Api.Models.Requests.v2.StudentSchoolAttendanceEvents.StudentSchoolAttendanceEventGetByExample>
    {
        public StudentSchoolAttendanceEventsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.StudentSchoolAttendanceEvents.StudentSchoolAttendanceEventGetByKey request, IStudentSchoolAttendanceEvent specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.AttendanceEventCategoryDescriptor = request.AttendanceEventCategoryDescriptor;
            specification.EventDate = request.EventDate;
            specification.SchoolId = request.SchoolId;
            specification.SchoolYear = request.SchoolYear;
            specification.StudentUniqueId = request.StudentUniqueId;
            specification.TermDescriptor = request.TermDescriptor;
                    }

        protected override void MapAll(Api.Models.Requests.v2.StudentSchoolAttendanceEvents.StudentSchoolAttendanceEventGetByExample request, IStudentSchoolAttendanceEvent specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.AttendanceEventCategoryDescriptor = request.AttendanceEventCategoryDescriptor;
            specification.AttendanceEventReason = request.AttendanceEventReason;
            specification.EducationalEnvironmentType = request.EducationalEnvironmentType;
            specification.EventDate = request.EventDate;
            specification.Id = request.Id;
            specification.SchoolId = request.SchoolId;
            specification.SchoolYear = request.SchoolYear;
            specification.StudentUniqueId = request.StudentUniqueId;
            specification.TermDescriptor = request.TermDescriptor;
                    }
                public IHttpActionResult GetByKey([FromUri] string attendanceEventCategoryDescriptor, DateTime eventDate, int schoolId, short schoolYear, string studentUniqueId, string termDescriptor)
        {
            var request = new Api.Models.Requests.v2.StudentSchoolAttendanceEvents.StudentSchoolAttendanceEventGetByKey
            {
                AttendanceEventCategoryDescriptor = attendanceEventCategoryDescriptor,
                EventDate = eventDate,
                SchoolId = schoolId,
                SchoolYear = schoolYear,
                StudentUniqueId = studentUniqueId,
                TermDescriptor = termDescriptor,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IStudentSchoolAttendanceEvent request)
        {
            return 
                request.AttendanceEventCategoryDescriptor != null
                && request.EventDate != default(DateTime)
                && request.SchoolId != default(int)
                && request.SchoolYear != default(short)
                && request.StudentUniqueId != default(string)
                && request.TermDescriptor != null;
        }

        protected override string GetResourceCollectionName()
        {
            return "studentSchoolAttendanceEvents";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.StudentSectionAssociations
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class StudentSectionAssociationsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.StudentSectionAssociation.StudentSectionAssociation, 
        EdFi.Ods.Api.Models.Resources.V2.StudentSectionAssociation.StudentSectionAssociation, 
        EdFi.Ods.Entities.Common.IStudentSectionAssociation, 
        // EdFi.Ods.Entities.NHibernate.StudentSectionAssociationAggregate.StudentSectionAssociation, 
        Api.Models.Requests.v2.StudentSectionAssociations.StudentSectionAssociationGetByKey, 
        Api.Models.Requests.v2.StudentSectionAssociations.StudentSectionAssociationPut,
        Api.Models.Requests.v2.StudentSectionAssociations.StudentSectionAssociationPost,
        Api.Models.Requests.v2.StudentSectionAssociations.StudentSectionAssociationDelete,
        Api.Models.Requests.v2.StudentSectionAssociations.StudentSectionAssociationGetByExample>
    {
        public StudentSectionAssociationsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.StudentSectionAssociations.StudentSectionAssociationGetByKey request, IStudentSectionAssociation specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.BeginDate = request.BeginDate;
            specification.ClassPeriodName = request.ClassPeriodName;
            specification.ClassroomIdentificationCode = request.ClassroomIdentificationCode;
            specification.LocalCourseCode = request.LocalCourseCode;
            specification.SchoolId = request.SchoolId;
            specification.SchoolYear = request.SchoolYear;
            specification.SequenceOfCourse = request.SequenceOfCourse;
            specification.StudentUniqueId = request.StudentUniqueId;
            specification.TermDescriptor = request.TermDescriptor;
            specification.UniqueSectionCode = request.UniqueSectionCode;
                    }

        protected override void MapAll(Api.Models.Requests.v2.StudentSectionAssociations.StudentSectionAssociationGetByExample request, IStudentSectionAssociation specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.BeginDate = request.BeginDate;
            specification.ClassPeriodName = request.ClassPeriodName;
            specification.ClassroomIdentificationCode = request.ClassroomIdentificationCode;
            specification.EndDate = request.EndDate;
            specification.HomeroomIndicator = request.HomeroomIndicator;
            specification.Id = request.Id;
            specification.LocalCourseCode = request.LocalCourseCode;
            specification.RepeatIdentifierType = request.RepeatIdentifierType;
            specification.SchoolId = request.SchoolId;
            specification.SchoolYear = request.SchoolYear;
            specification.SequenceOfCourse = request.SequenceOfCourse;
            specification.StudentUniqueId = request.StudentUniqueId;
            specification.TeacherStudentDataLinkExclusion = request.TeacherStudentDataLinkExclusion;
            specification.TermDescriptor = request.TermDescriptor;
            specification.UniqueSectionCode = request.UniqueSectionCode;
                    }
                public IHttpActionResult GetByKey([FromUri] DateTime beginDate, string classPeriodName, string classroomIdentificationCode, string localCourseCode, int schoolId, short schoolYear, int sequenceOfCourse, string studentUniqueId, string termDescriptor, string uniqueSectionCode)
        {
            var request = new Api.Models.Requests.v2.StudentSectionAssociations.StudentSectionAssociationGetByKey
            {
                BeginDate = beginDate,
                ClassPeriodName = classPeriodName,
                ClassroomIdentificationCode = classroomIdentificationCode,
                LocalCourseCode = localCourseCode,
                SchoolId = schoolId,
                SchoolYear = schoolYear,
                SequenceOfCourse = sequenceOfCourse,
                StudentUniqueId = studentUniqueId,
                TermDescriptor = termDescriptor,
                UniqueSectionCode = uniqueSectionCode,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IStudentSectionAssociation request)
        {
            return 
                request.BeginDate != default(DateTime)
                && request.ClassPeriodName != default(string)
                && request.ClassroomIdentificationCode != default(string)
                && request.LocalCourseCode != default(string)
                && request.SchoolId != default(int)
                && request.SchoolYear != default(short)
                && request.SequenceOfCourse != default(int)
                && request.StudentUniqueId != default(string)
                && request.TermDescriptor != null
                && request.UniqueSectionCode != default(string);
        }

        protected override string GetResourceCollectionName()
        {
            return "studentSectionAssociations";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.StudentSectionAttendanceEvents
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class StudentSectionAttendanceEventsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.StudentSectionAttendanceEvent.StudentSectionAttendanceEvent, 
        EdFi.Ods.Api.Models.Resources.V2.StudentSectionAttendanceEvent.StudentSectionAttendanceEvent, 
        EdFi.Ods.Entities.Common.IStudentSectionAttendanceEvent, 
        // EdFi.Ods.Entities.NHibernate.StudentSectionAttendanceEventAggregate.StudentSectionAttendanceEvent, 
        Api.Models.Requests.v2.StudentSectionAttendanceEvents.StudentSectionAttendanceEventGetByKey, 
        Api.Models.Requests.v2.StudentSectionAttendanceEvents.StudentSectionAttendanceEventPut,
        Api.Models.Requests.v2.StudentSectionAttendanceEvents.StudentSectionAttendanceEventPost,
        Api.Models.Requests.v2.StudentSectionAttendanceEvents.StudentSectionAttendanceEventDelete,
        Api.Models.Requests.v2.StudentSectionAttendanceEvents.StudentSectionAttendanceEventGetByExample>
    {
        public StudentSectionAttendanceEventsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.StudentSectionAttendanceEvents.StudentSectionAttendanceEventGetByKey request, IStudentSectionAttendanceEvent specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.AttendanceEventCategoryDescriptor = request.AttendanceEventCategoryDescriptor;
            specification.ClassPeriodName = request.ClassPeriodName;
            specification.ClassroomIdentificationCode = request.ClassroomIdentificationCode;
            specification.EventDate = request.EventDate;
            specification.LocalCourseCode = request.LocalCourseCode;
            specification.SchoolId = request.SchoolId;
            specification.SchoolYear = request.SchoolYear;
            specification.SequenceOfCourse = request.SequenceOfCourse;
            specification.StudentUniqueId = request.StudentUniqueId;
            specification.TermDescriptor = request.TermDescriptor;
            specification.UniqueSectionCode = request.UniqueSectionCode;
                    }

        protected override void MapAll(Api.Models.Requests.v2.StudentSectionAttendanceEvents.StudentSectionAttendanceEventGetByExample request, IStudentSectionAttendanceEvent specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.AttendanceEventCategoryDescriptor = request.AttendanceEventCategoryDescriptor;
            specification.AttendanceEventReason = request.AttendanceEventReason;
            specification.ClassPeriodName = request.ClassPeriodName;
            specification.ClassroomIdentificationCode = request.ClassroomIdentificationCode;
            specification.EducationalEnvironmentType = request.EducationalEnvironmentType;
            specification.EventDate = request.EventDate;
            specification.Id = request.Id;
            specification.LocalCourseCode = request.LocalCourseCode;
            specification.SchoolId = request.SchoolId;
            specification.SchoolYear = request.SchoolYear;
            specification.SequenceOfCourse = request.SequenceOfCourse;
            specification.StudentUniqueId = request.StudentUniqueId;
            specification.TermDescriptor = request.TermDescriptor;
            specification.UniqueSectionCode = request.UniqueSectionCode;
                    }
                public IHttpActionResult GetByKey([FromUri] string attendanceEventCategoryDescriptor, string classPeriodName, string classroomIdentificationCode, DateTime eventDate, string localCourseCode, int schoolId, short schoolYear, int sequenceOfCourse, string studentUniqueId, string termDescriptor, string uniqueSectionCode)
        {
            var request = new Api.Models.Requests.v2.StudentSectionAttendanceEvents.StudentSectionAttendanceEventGetByKey
            {
                AttendanceEventCategoryDescriptor = attendanceEventCategoryDescriptor,
                ClassPeriodName = classPeriodName,
                ClassroomIdentificationCode = classroomIdentificationCode,
                EventDate = eventDate,
                LocalCourseCode = localCourseCode,
                SchoolId = schoolId,
                SchoolYear = schoolYear,
                SequenceOfCourse = sequenceOfCourse,
                StudentUniqueId = studentUniqueId,
                TermDescriptor = termDescriptor,
                UniqueSectionCode = uniqueSectionCode,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IStudentSectionAttendanceEvent request)
        {
            return 
                request.AttendanceEventCategoryDescriptor != null
                && request.ClassPeriodName != default(string)
                && request.ClassroomIdentificationCode != default(string)
                && request.EventDate != default(DateTime)
                && request.LocalCourseCode != default(string)
                && request.SchoolId != default(int)
                && request.SchoolYear != default(short)
                && request.SequenceOfCourse != default(int)
                && request.StudentUniqueId != default(string)
                && request.TermDescriptor != null
                && request.UniqueSectionCode != default(string);
        }

        protected override string GetResourceCollectionName()
        {
            return "studentSectionAttendanceEvents";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.StudentSpecialEducationProgramAssociations
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class StudentSpecialEducationProgramAssociationsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.StudentSpecialEducationProgramAssociation.StudentSpecialEducationProgramAssociation, 
        EdFi.Ods.Api.Models.Resources.V2.StudentSpecialEducationProgramAssociation.StudentSpecialEducationProgramAssociation, 
        EdFi.Ods.Entities.Common.IStudentSpecialEducationProgramAssociation, 
        // EdFi.Ods.Entities.NHibernate.StudentSpecialEducationProgramAssociationAggregate.StudentSpecialEducationProgramAssociation, 
        Api.Models.Requests.v2.StudentSpecialEducationProgramAssociations.StudentSpecialEducationProgramAssociationGetByKey, 
        Api.Models.Requests.v2.StudentSpecialEducationProgramAssociations.StudentSpecialEducationProgramAssociationPut,
        Api.Models.Requests.v2.StudentSpecialEducationProgramAssociations.StudentSpecialEducationProgramAssociationPost,
        Api.Models.Requests.v2.StudentSpecialEducationProgramAssociations.StudentSpecialEducationProgramAssociationDelete,
        Api.Models.Requests.v2.StudentSpecialEducationProgramAssociations.StudentSpecialEducationProgramAssociationGetByExample>
    {
        public StudentSpecialEducationProgramAssociationsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.StudentSpecialEducationProgramAssociations.StudentSpecialEducationProgramAssociationGetByKey request, IStudentSpecialEducationProgramAssociation specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.BeginDate = request.BeginDate;
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.ProgramEducationOrganizationId = request.ProgramEducationOrganizationId;
            specification.ProgramName = request.ProgramName;
            specification.ProgramType = request.ProgramType;
            specification.StudentUniqueId = request.StudentUniqueId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.StudentSpecialEducationProgramAssociations.StudentSpecialEducationProgramAssociationGetByExample request, IStudentSpecialEducationProgramAssociation specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.BeginDate = request.BeginDate;
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.IdeaEligibility = request.IdeaEligibility;
            specification.IEPBeginDate = request.IEPBeginDate;
            specification.IEPEndDate = request.IEPEndDate;
            specification.IEPReviewDate = request.IEPReviewDate;
            specification.LastEvaluationDate = request.LastEvaluationDate;
            specification.MedicallyFragile = request.MedicallyFragile;
            specification.MultiplyDisabled = request.MultiplyDisabled;
            specification.ProgramEducationOrganizationId = request.ProgramEducationOrganizationId;
            specification.ProgramName = request.ProgramName;
            specification.ProgramType = request.ProgramType;
            specification.SchoolHoursPerWeek = request.SchoolHoursPerWeek;
            specification.SpecialEducationHoursPerWeek = request.SpecialEducationHoursPerWeek;
            specification.SpecialEducationSettingDescriptor = request.SpecialEducationSettingDescriptor;
            specification.StudentUniqueId = request.StudentUniqueId;
                    }
                public IHttpActionResult GetByKey([FromUri] DateTime beginDate, int educationOrganizationId, int programEducationOrganizationId, string programName, string programType, string studentUniqueId)
        {
            var request = new Api.Models.Requests.v2.StudentSpecialEducationProgramAssociations.StudentSpecialEducationProgramAssociationGetByKey
            {
                BeginDate = beginDate,
                EducationOrganizationId = educationOrganizationId,
                ProgramEducationOrganizationId = programEducationOrganizationId,
                ProgramName = programName,
                ProgramType = programType,
                StudentUniqueId = studentUniqueId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IStudentSpecialEducationProgramAssociation request)
        {
            return 
                request.BeginDate != default(DateTime)
                && request.EducationOrganizationId != default(int)
                && request.ProgramEducationOrganizationId != default(int)
                && request.ProgramName != default(string)
                && request.ProgramType != null
                && request.StudentUniqueId != default(string);
        }

        protected override string GetResourceCollectionName()
        {
            return "studentSpecialEducationProgramAssociations";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.StudentTitleIPartAProgramAssociations
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class StudentTitleIPartAProgramAssociationsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.StudentTitleIPartAProgramAssociation.StudentTitleIPartAProgramAssociation, 
        EdFi.Ods.Api.Models.Resources.V2.StudentTitleIPartAProgramAssociation.StudentTitleIPartAProgramAssociation, 
        EdFi.Ods.Entities.Common.IStudentTitleIPartAProgramAssociation, 
        // EdFi.Ods.Entities.NHibernate.StudentTitleIPartAProgramAssociationAggregate.StudentTitleIPartAProgramAssociation, 
        Api.Models.Requests.v2.StudentTitleIPartAProgramAssociations.StudentTitleIPartAProgramAssociationGetByKey, 
        Api.Models.Requests.v2.StudentTitleIPartAProgramAssociations.StudentTitleIPartAProgramAssociationPut,
        Api.Models.Requests.v2.StudentTitleIPartAProgramAssociations.StudentTitleIPartAProgramAssociationPost,
        Api.Models.Requests.v2.StudentTitleIPartAProgramAssociations.StudentTitleIPartAProgramAssociationDelete,
        Api.Models.Requests.v2.StudentTitleIPartAProgramAssociations.StudentTitleIPartAProgramAssociationGetByExample>
    {
        public StudentTitleIPartAProgramAssociationsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.StudentTitleIPartAProgramAssociations.StudentTitleIPartAProgramAssociationGetByKey request, IStudentTitleIPartAProgramAssociation specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.BeginDate = request.BeginDate;
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.ProgramEducationOrganizationId = request.ProgramEducationOrganizationId;
            specification.ProgramName = request.ProgramName;
            specification.ProgramType = request.ProgramType;
            specification.StudentUniqueId = request.StudentUniqueId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.StudentTitleIPartAProgramAssociations.StudentTitleIPartAProgramAssociationGetByExample request, IStudentTitleIPartAProgramAssociation specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.BeginDate = request.BeginDate;
            specification.EducationOrganizationId = request.EducationOrganizationId;
            specification.ProgramEducationOrganizationId = request.ProgramEducationOrganizationId;
            specification.ProgramName = request.ProgramName;
            specification.ProgramType = request.ProgramType;
            specification.StudentUniqueId = request.StudentUniqueId;
            specification.TitleIPartAParticipantType = request.TitleIPartAParticipantType;
                    }
                public IHttpActionResult GetByKey([FromUri] DateTime beginDate, int educationOrganizationId, int programEducationOrganizationId, string programName, string programType, string studentUniqueId)
        {
            var request = new Api.Models.Requests.v2.StudentTitleIPartAProgramAssociations.StudentTitleIPartAProgramAssociationGetByKey
            {
                BeginDate = beginDate,
                EducationOrganizationId = educationOrganizationId,
                ProgramEducationOrganizationId = programEducationOrganizationId,
                ProgramName = programName,
                ProgramType = programType,
                StudentUniqueId = studentUniqueId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IStudentTitleIPartAProgramAssociation request)
        {
            return 
                request.BeginDate != default(DateTime)
                && request.EducationOrganizationId != default(int)
                && request.ProgramEducationOrganizationId != default(int)
                && request.ProgramName != default(string)
                && request.ProgramType != null
                && request.StudentUniqueId != default(string);
        }

        protected override string GetResourceCollectionName()
        {
            return "studentTitleIPartAProgramAssociations";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.TeachingCredentialBasisTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class TeachingCredentialBasisTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.TeachingCredentialBasisType.TeachingCredentialBasisType, 
        EdFi.Ods.Api.Models.Resources.V2.TeachingCredentialBasisType.TeachingCredentialBasisType, 
        EdFi.Ods.Entities.Common.ITeachingCredentialBasisType, 
        // EdFi.Ods.Entities.NHibernate.TeachingCredentialBasisTypeAggregate.TeachingCredentialBasisType, 
        Api.Models.Requests.v2.TeachingCredentialBasisTypes.TeachingCredentialBasisTypeGetByKey, 
        Api.Models.Requests.v2.TeachingCredentialBasisTypes.TeachingCredentialBasisTypePut,
        Api.Models.Requests.v2.TeachingCredentialBasisTypes.TeachingCredentialBasisTypePost,
        Api.Models.Requests.v2.TeachingCredentialBasisTypes.TeachingCredentialBasisTypeDelete,
        Api.Models.Requests.v2.TeachingCredentialBasisTypes.TeachingCredentialBasisTypeGetByExample>
    {
        public TeachingCredentialBasisTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.TeachingCredentialBasisTypes.TeachingCredentialBasisTypeGetByKey request, ITeachingCredentialBasisType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.TeachingCredentialBasisTypeId = request.TeachingCredentialBasisTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.TeachingCredentialBasisTypes.TeachingCredentialBasisTypeGetByExample request, ITeachingCredentialBasisType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
            specification.TeachingCredentialBasisTypeId = request.TeachingCredentialBasisTypeId;
                    }
                public IHttpActionResult GetByKey([FromUri] int teachingCredentialBasisTypeId)
        {
            var request = new Api.Models.Requests.v2.TeachingCredentialBasisTypes.TeachingCredentialBasisTypeGetByKey
            {
                TeachingCredentialBasisTypeId = teachingCredentialBasisTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(ITeachingCredentialBasisType request)
        {
            return 
                request.TeachingCredentialBasisTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "teachingCredentialBasisTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.TeachingCredentialDescriptors
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class TeachingCredentialDescriptorsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.TeachingCredentialDescriptor.TeachingCredentialDescriptor, 
        EdFi.Ods.Api.Models.Resources.V2.TeachingCredentialDescriptor.TeachingCredentialDescriptor, 
        EdFi.Ods.Entities.Common.ITeachingCredentialDescriptor, 
        // EdFi.Ods.Entities.NHibernate.TeachingCredentialDescriptorAggregate.TeachingCredentialDescriptor, 
        Api.Models.Requests.v2.TeachingCredentialDescriptors.TeachingCredentialDescriptorGetByKey, 
        Api.Models.Requests.v2.TeachingCredentialDescriptors.TeachingCredentialDescriptorPut,
        Api.Models.Requests.v2.TeachingCredentialDescriptors.TeachingCredentialDescriptorPost,
        Api.Models.Requests.v2.TeachingCredentialDescriptors.TeachingCredentialDescriptorDelete,
        Api.Models.Requests.v2.TeachingCredentialDescriptors.TeachingCredentialDescriptorGetByExample>
    {
        public TeachingCredentialDescriptorsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.TeachingCredentialDescriptors.TeachingCredentialDescriptorGetByKey request, ITeachingCredentialDescriptor specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.TeachingCredentialDescriptorId = request.TeachingCredentialDescriptorId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.TeachingCredentialDescriptors.TeachingCredentialDescriptorGetByExample request, ITeachingCredentialDescriptor specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.TeachingCredentialDescriptorId = request.TeachingCredentialDescriptorId;
            specification.TeachingCredentialType = request.TeachingCredentialType;
                    }
                public IHttpActionResult GetByKey([FromUri] int teachingCredentialDescriptorId)
        {
            var request = new Api.Models.Requests.v2.TeachingCredentialDescriptors.TeachingCredentialDescriptorGetByKey
            {
                TeachingCredentialDescriptorId = teachingCredentialDescriptorId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(ITeachingCredentialDescriptor request)
        {
            return 
                request.TeachingCredentialDescriptorId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "teachingCredentialDescriptors";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.TeachingCredentialTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class TeachingCredentialTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.TeachingCredentialType.TeachingCredentialType, 
        EdFi.Ods.Api.Models.Resources.V2.TeachingCredentialType.TeachingCredentialType, 
        EdFi.Ods.Entities.Common.ITeachingCredentialType, 
        // EdFi.Ods.Entities.NHibernate.TeachingCredentialTypeAggregate.TeachingCredentialType, 
        Api.Models.Requests.v2.TeachingCredentialTypes.TeachingCredentialTypeGetByKey, 
        Api.Models.Requests.v2.TeachingCredentialTypes.TeachingCredentialTypePut,
        Api.Models.Requests.v2.TeachingCredentialTypes.TeachingCredentialTypePost,
        Api.Models.Requests.v2.TeachingCredentialTypes.TeachingCredentialTypeDelete,
        Api.Models.Requests.v2.TeachingCredentialTypes.TeachingCredentialTypeGetByExample>
    {
        public TeachingCredentialTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.TeachingCredentialTypes.TeachingCredentialTypeGetByKey request, ITeachingCredentialType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.TeachingCredentialTypeId = request.TeachingCredentialTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.TeachingCredentialTypes.TeachingCredentialTypeGetByExample request, ITeachingCredentialType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
            specification.TeachingCredentialTypeId = request.TeachingCredentialTypeId;
                    }
                public IHttpActionResult GetByKey([FromUri] int teachingCredentialTypeId)
        {
            var request = new Api.Models.Requests.v2.TeachingCredentialTypes.TeachingCredentialTypeGetByKey
            {
                TeachingCredentialTypeId = teachingCredentialTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(ITeachingCredentialType request)
        {
            return 
                request.TeachingCredentialTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "teachingCredentialTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.TelephoneNumberTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class TelephoneNumberTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.TelephoneNumberType.TelephoneNumberType, 
        EdFi.Ods.Api.Models.Resources.V2.TelephoneNumberType.TelephoneNumberType, 
        EdFi.Ods.Entities.Common.ITelephoneNumberType, 
        // EdFi.Ods.Entities.NHibernate.TelephoneNumberTypeAggregate.TelephoneNumberType, 
        Api.Models.Requests.v2.TelephoneNumberTypes.TelephoneNumberTypeGetByKey, 
        Api.Models.Requests.v2.TelephoneNumberTypes.TelephoneNumberTypePut,
        Api.Models.Requests.v2.TelephoneNumberTypes.TelephoneNumberTypePost,
        Api.Models.Requests.v2.TelephoneNumberTypes.TelephoneNumberTypeDelete,
        Api.Models.Requests.v2.TelephoneNumberTypes.TelephoneNumberTypeGetByExample>
    {
        public TelephoneNumberTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.TelephoneNumberTypes.TelephoneNumberTypeGetByKey request, ITelephoneNumberType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.TelephoneNumberTypeId = request.TelephoneNumberTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.TelephoneNumberTypes.TelephoneNumberTypeGetByExample request, ITelephoneNumberType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
            specification.TelephoneNumberTypeId = request.TelephoneNumberTypeId;
                    }
                public IHttpActionResult GetByKey([FromUri] int telephoneNumberTypeId)
        {
            var request = new Api.Models.Requests.v2.TelephoneNumberTypes.TelephoneNumberTypeGetByKey
            {
                TelephoneNumberTypeId = telephoneNumberTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(ITelephoneNumberType request)
        {
            return 
                request.TelephoneNumberTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "telephoneNumberTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.TermDescriptors
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class TermDescriptorsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.TermDescriptor.TermDescriptor, 
        EdFi.Ods.Api.Models.Resources.V2.TermDescriptor.TermDescriptor, 
        EdFi.Ods.Entities.Common.ITermDescriptor, 
        // EdFi.Ods.Entities.NHibernate.TermDescriptorAggregate.TermDescriptor, 
        Api.Models.Requests.v2.TermDescriptors.TermDescriptorGetByKey, 
        Api.Models.Requests.v2.TermDescriptors.TermDescriptorPut,
        Api.Models.Requests.v2.TermDescriptors.TermDescriptorPost,
        Api.Models.Requests.v2.TermDescriptors.TermDescriptorDelete,
        Api.Models.Requests.v2.TermDescriptors.TermDescriptorGetByExample>
    {
        public TermDescriptorsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.TermDescriptors.TermDescriptorGetByKey request, ITermDescriptor specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.TermDescriptorId = request.TermDescriptorId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.TermDescriptors.TermDescriptorGetByExample request, ITermDescriptor specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.TermDescriptorId = request.TermDescriptorId;
            specification.TermType = request.TermType;
                    }
                public IHttpActionResult GetByKey([FromUri] int termDescriptorId)
        {
            var request = new Api.Models.Requests.v2.TermDescriptors.TermDescriptorGetByKey
            {
                TermDescriptorId = termDescriptorId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(ITermDescriptor request)
        {
            return 
                request.TermDescriptorId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "termDescriptors";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.TermTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class TermTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.TermType.TermType, 
        EdFi.Ods.Api.Models.Resources.V2.TermType.TermType, 
        EdFi.Ods.Entities.Common.ITermType, 
        // EdFi.Ods.Entities.NHibernate.TermTypeAggregate.TermType, 
        Api.Models.Requests.v2.TermTypes.TermTypeGetByKey, 
        Api.Models.Requests.v2.TermTypes.TermTypePut,
        Api.Models.Requests.v2.TermTypes.TermTypePost,
        Api.Models.Requests.v2.TermTypes.TermTypeDelete,
        Api.Models.Requests.v2.TermTypes.TermTypeGetByExample>
    {
        public TermTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.TermTypes.TermTypeGetByKey request, ITermType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.TermTypeId = request.TermTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.TermTypes.TermTypeGetByExample request, ITermType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
            specification.TermTypeId = request.TermTypeId;
                    }
                public IHttpActionResult GetByKey([FromUri] int termTypeId)
        {
            var request = new Api.Models.Requests.v2.TermTypes.TermTypeGetByKey
            {
                TermTypeId = termTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(ITermType request)
        {
            return 
                request.TermTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "termTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.TitleIPartAParticipantTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class TitleIPartAParticipantTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.TitleIPartAParticipantType.TitleIPartAParticipantType, 
        EdFi.Ods.Api.Models.Resources.V2.TitleIPartAParticipantType.TitleIPartAParticipantType, 
        EdFi.Ods.Entities.Common.ITitleIPartAParticipantType, 
        // EdFi.Ods.Entities.NHibernate.TitleIPartAParticipantTypeAggregate.TitleIPartAParticipantType, 
        Api.Models.Requests.v2.TitleIPartAParticipantTypes.TitleIPartAParticipantTypeGetByKey, 
        Api.Models.Requests.v2.TitleIPartAParticipantTypes.TitleIPartAParticipantTypePut,
        Api.Models.Requests.v2.TitleIPartAParticipantTypes.TitleIPartAParticipantTypePost,
        Api.Models.Requests.v2.TitleIPartAParticipantTypes.TitleIPartAParticipantTypeDelete,
        Api.Models.Requests.v2.TitleIPartAParticipantTypes.TitleIPartAParticipantTypeGetByExample>
    {
        public TitleIPartAParticipantTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.TitleIPartAParticipantTypes.TitleIPartAParticipantTypeGetByKey request, ITitleIPartAParticipantType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.TitleIPartAParticipantTypeId = request.TitleIPartAParticipantTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.TitleIPartAParticipantTypes.TitleIPartAParticipantTypeGetByExample request, ITitleIPartAParticipantType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
            specification.TitleIPartAParticipantTypeId = request.TitleIPartAParticipantTypeId;
                    }
                public IHttpActionResult GetByKey([FromUri] int titleIPartAParticipantTypeId)
        {
            var request = new Api.Models.Requests.v2.TitleIPartAParticipantTypes.TitleIPartAParticipantTypeGetByKey
            {
                TitleIPartAParticipantTypeId = titleIPartAParticipantTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(ITitleIPartAParticipantType request)
        {
            return 
                request.TitleIPartAParticipantTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "titleIPartAParticipantTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.TitleIPartASchoolDesignationTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class TitleIPartASchoolDesignationTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.TitleIPartASchoolDesignationType.TitleIPartASchoolDesignationType, 
        EdFi.Ods.Api.Models.Resources.V2.TitleIPartASchoolDesignationType.TitleIPartASchoolDesignationType, 
        EdFi.Ods.Entities.Common.ITitleIPartASchoolDesignationType, 
        // EdFi.Ods.Entities.NHibernate.TitleIPartASchoolDesignationTypeAggregate.TitleIPartASchoolDesignationType, 
        Api.Models.Requests.v2.TitleIPartASchoolDesignationTypes.TitleIPartASchoolDesignationTypeGetByKey, 
        Api.Models.Requests.v2.TitleIPartASchoolDesignationTypes.TitleIPartASchoolDesignationTypePut,
        Api.Models.Requests.v2.TitleIPartASchoolDesignationTypes.TitleIPartASchoolDesignationTypePost,
        Api.Models.Requests.v2.TitleIPartASchoolDesignationTypes.TitleIPartASchoolDesignationTypeDelete,
        Api.Models.Requests.v2.TitleIPartASchoolDesignationTypes.TitleIPartASchoolDesignationTypeGetByExample>
    {
        public TitleIPartASchoolDesignationTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.TitleIPartASchoolDesignationTypes.TitleIPartASchoolDesignationTypeGetByKey request, ITitleIPartASchoolDesignationType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.TitleIPartASchoolDesignationTypeId = request.TitleIPartASchoolDesignationTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.TitleIPartASchoolDesignationTypes.TitleIPartASchoolDesignationTypeGetByExample request, ITitleIPartASchoolDesignationType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
            specification.TitleIPartASchoolDesignationTypeId = request.TitleIPartASchoolDesignationTypeId;
                    }
                public IHttpActionResult GetByKey([FromUri] int titleIPartASchoolDesignationTypeId)
        {
            var request = new Api.Models.Requests.v2.TitleIPartASchoolDesignationTypes.TitleIPartASchoolDesignationTypeGetByKey
            {
                TitleIPartASchoolDesignationTypeId = titleIPartASchoolDesignationTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(ITitleIPartASchoolDesignationType request)
        {
            return 
                request.TitleIPartASchoolDesignationTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "titleIPartASchoolDesignationTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.VisaTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class VisaTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.VisaType.VisaType, 
        EdFi.Ods.Api.Models.Resources.V2.VisaType.VisaType, 
        EdFi.Ods.Entities.Common.IVisaType, 
        // EdFi.Ods.Entities.NHibernate.VisaTypeAggregate.VisaType, 
        Api.Models.Requests.v2.VisaTypes.VisaTypeGetByKey, 
        Api.Models.Requests.v2.VisaTypes.VisaTypePut,
        Api.Models.Requests.v2.VisaTypes.VisaTypePost,
        Api.Models.Requests.v2.VisaTypes.VisaTypeDelete,
        Api.Models.Requests.v2.VisaTypes.VisaTypeGetByExample>
    {
        public VisaTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.VisaTypes.VisaTypeGetByKey request, IVisaType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.VisaTypeId = request.VisaTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.VisaTypes.VisaTypeGetByExample request, IVisaType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
            specification.VisaTypeId = request.VisaTypeId;
                    }
                public IHttpActionResult GetByKey([FromUri] int visaTypeId)
        {
            var request = new Api.Models.Requests.v2.VisaTypes.VisaTypeGetByKey
            {
                VisaTypeId = visaTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IVisaType request)
        {
            return 
                request.VisaTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "visaTypes";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.WeaponDescriptors
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class WeaponDescriptorsController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.WeaponDescriptor.WeaponDescriptor, 
        EdFi.Ods.Api.Models.Resources.V2.WeaponDescriptor.WeaponDescriptor, 
        EdFi.Ods.Entities.Common.IWeaponDescriptor, 
        // EdFi.Ods.Entities.NHibernate.WeaponDescriptorAggregate.WeaponDescriptor, 
        Api.Models.Requests.v2.WeaponDescriptors.WeaponDescriptorGetByKey, 
        Api.Models.Requests.v2.WeaponDescriptors.WeaponDescriptorPut,
        Api.Models.Requests.v2.WeaponDescriptors.WeaponDescriptorPost,
        Api.Models.Requests.v2.WeaponDescriptors.WeaponDescriptorDelete,
        Api.Models.Requests.v2.WeaponDescriptors.WeaponDescriptorGetByExample>
    {
        public WeaponDescriptorsController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.WeaponDescriptors.WeaponDescriptorGetByKey request, IWeaponDescriptor specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.WeaponDescriptorId = request.WeaponDescriptorId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.WeaponDescriptors.WeaponDescriptorGetByExample request, IWeaponDescriptor specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.WeaponDescriptorId = request.WeaponDescriptorId;
            specification.WeaponType = request.WeaponType;
                    }
                public IHttpActionResult GetByKey([FromUri] int weaponDescriptorId)
        {
            var request = new Api.Models.Requests.v2.WeaponDescriptors.WeaponDescriptorGetByKey
            {
                WeaponDescriptorId = weaponDescriptorId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IWeaponDescriptor request)
        {
            return 
                request.WeaponDescriptorId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "weaponDescriptors";
        }
    }
}

namespace EdFi.Ods.Api.Services.Controllers.v2.WeaponTypes
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public partial class WeaponTypesController : EdFiControllerBase<
        EdFi.Ods.Api.Models.Resources.V2.WeaponType.WeaponType, 
        EdFi.Ods.Api.Models.Resources.V2.WeaponType.WeaponType, 
        EdFi.Ods.Entities.Common.IWeaponType, 
        // EdFi.Ods.Entities.NHibernate.WeaponTypeAggregate.WeaponType, 
        Api.Models.Requests.v2.WeaponTypes.WeaponTypeGetByKey, 
        Api.Models.Requests.v2.WeaponTypes.WeaponTypePut,
        Api.Models.Requests.v2.WeaponTypes.WeaponTypePost,
        Api.Models.Requests.v2.WeaponTypes.WeaponTypeDelete,
        Api.Models.Requests.v2.WeaponTypes.WeaponTypeGetByExample>
    {
        public WeaponTypesController(IPipelineFactory pipelineFactory, ISchoolYearContextProvider schoolYearContextProvider, IRESTErrorProvider restErrorProvider) 
            : base(pipelineFactory, schoolYearContextProvider, restErrorProvider)
        {
        }
        
        protected override void MapKey(Api.Models.Requests.v2.WeaponTypes.WeaponTypeGetByKey request, IWeaponType specification)
        {
                        // Copy contextual primary key values
            specification.SuspendReferenceAssignmentCheck();
            specification.WeaponTypeId = request.WeaponTypeId;
                    }

        protected override void MapAll(Api.Models.Requests.v2.WeaponTypes.WeaponTypeGetByExample request, IWeaponType specification)
        {
                        // Copy all existing values
            specification.SuspendReferenceAssignmentCheck();
            specification.CodeValue = request.CodeValue;
            specification.Description = request.Description;
            specification.Id = request.Id;
            specification.ShortDescription = request.ShortDescription;
            specification.WeaponTypeId = request.WeaponTypeId;
                    }
                public IHttpActionResult GetByKey([FromUri] int weaponTypeId)
        {
            var request = new Api.Models.Requests.v2.WeaponTypes.WeaponTypeGetByKey
            {
                WeaponTypeId = weaponTypeId,
            };
            return GetByKey(request);
        }
                protected override bool IsGetByNaturalKey(IWeaponType request)
        {
            return 
                request.WeaponTypeId != default(int);
        }

        protected override string GetResourceCollectionName()
        {
            return "weaponTypes";
        }
    }
}

