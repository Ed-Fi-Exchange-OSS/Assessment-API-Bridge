
using System;
using System.Collections.Generic;
using EdFi.Ods.Common;

namespace EdFi.Ods.Api.Models.Requests.v2.AcademicHonorCategoryTypes
{ 
    public class AcademicHonorCategoryTypeGetByKey
    {
        public int AcademicHonorCategoryTypeId { get; set; }
    }

    public class AcademicHonorCategoryTypeGetByExample
    {
        public int AcademicHonorCategoryTypeId { get; set; }
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
    }

    public class AcademicHonorCategoryTypeGetByIds : IHasIdentifiers<Guid>
    {
        public AcademicHonorCategoryTypeGetByIds() { }

        public AcademicHonorCategoryTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class AcademicHonorCategoryTypePost : EdFi.Ods.Api.Models.Resources.V2.AcademicHonorCategoryType.AcademicHonorCategoryType
    {
    }

    public class AcademicHonorCategoryTypePut : EdFi.Ods.Api.Models.Resources.V2.AcademicHonorCategoryType.AcademicHonorCategoryType
    { 
    }

    public class AcademicHonorCategoryTypeDelete : IHasIdentifier 
    {
        public AcademicHonorCategoryTypeDelete() { }

        public AcademicHonorCategoryTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.AcademicSubjectDescriptors
{ 
    public class AcademicSubjectDescriptorGetByKey
    {
        public int AcademicSubjectDescriptorId { get; set; }
    }

    public class AcademicSubjectDescriptorGetByExample
    {
        public int AcademicSubjectDescriptorId { get; set; }
        public string AcademicSubjectType { get; set; }
    }

    public class AcademicSubjectDescriptorGetByIds : IHasIdentifiers<Guid>
    {
        public AcademicSubjectDescriptorGetByIds() { }

        public AcademicSubjectDescriptorGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class AcademicSubjectDescriptorPost : EdFi.Ods.Api.Models.Resources.V2.AcademicSubjectDescriptor.AcademicSubjectDescriptor
    {
    }

    public class AcademicSubjectDescriptorPut : EdFi.Ods.Api.Models.Resources.V2.AcademicSubjectDescriptor.AcademicSubjectDescriptor
    { 
    }

    public class AcademicSubjectDescriptorDelete : IHasIdentifier 
    {
        public AcademicSubjectDescriptorDelete() { }

        public AcademicSubjectDescriptorDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.AcademicSubjectTypes
{ 
    public class AcademicSubjectTypeGetByKey
    {
        public int AcademicSubjectTypeId { get; set; }
    }

    public class AcademicSubjectTypeGetByExample
    {
        public int AcademicSubjectTypeId { get; set; }
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
    }

    public class AcademicSubjectTypeGetByIds : IHasIdentifiers<Guid>
    {
        public AcademicSubjectTypeGetByIds() { }

        public AcademicSubjectTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class AcademicSubjectTypePost : EdFi.Ods.Api.Models.Resources.V2.AcademicSubjectType.AcademicSubjectType
    {
    }

    public class AcademicSubjectTypePut : EdFi.Ods.Api.Models.Resources.V2.AcademicSubjectType.AcademicSubjectType
    { 
    }

    public class AcademicSubjectTypeDelete : IHasIdentifier 
    {
        public AcademicSubjectTypeDelete() { }

        public AcademicSubjectTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.AcademicWeeks
{ 
    public class AcademicWeekGetByKey
    {
        public int SchoolId { get; set; }
        public string WeekIdentifier { get; set; }
    }

    public class AcademicWeekGetByExample
    {
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid Id { get; set; }
        public int SchoolId { get; set; }
        public int TotalInstructionalDays { get; set; }
        public string WeekIdentifier { get; set; }
    }

    public class AcademicWeekGetByIds : IHasIdentifiers<Guid>
    {
        public AcademicWeekGetByIds() { }

        public AcademicWeekGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class AcademicWeekPost : EdFi.Ods.Api.Models.Resources.V2.AcademicWeek.AcademicWeek
    {
    }

    public class AcademicWeekPut : EdFi.Ods.Api.Models.Resources.V2.AcademicWeek.AcademicWeek
    { 
    }

    public class AcademicWeekDelete : IHasIdentifier 
    {
        public AcademicWeekDelete() { }

        public AcademicWeekDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.AccommodationDescriptors
{ 
    public class AccommodationDescriptorGetByKey
    {
        public int AccommodationDescriptorId { get; set; }
    }

    public class AccommodationDescriptorGetByExample
    {
        public int AccommodationDescriptorId { get; set; }
        public string AccommodationType { get; set; }
    }

    public class AccommodationDescriptorGetByIds : IHasIdentifiers<Guid>
    {
        public AccommodationDescriptorGetByIds() { }

        public AccommodationDescriptorGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class AccommodationDescriptorPost : EdFi.Ods.Api.Models.Resources.V2.AccommodationDescriptor.AccommodationDescriptor
    {
    }

    public class AccommodationDescriptorPut : EdFi.Ods.Api.Models.Resources.V2.AccommodationDescriptor.AccommodationDescriptor
    { 
    }

    public class AccommodationDescriptorDelete : IHasIdentifier 
    {
        public AccommodationDescriptorDelete() { }

        public AccommodationDescriptorDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.AccommodationTypes
{ 
    public class AccommodationTypeGetByKey
    {
        public int AccommodationTypeId { get; set; }
    }

    public class AccommodationTypeGetByExample
    {
        public int AccommodationTypeId { get; set; }
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
    }

    public class AccommodationTypeGetByIds : IHasIdentifiers<Guid>
    {
        public AccommodationTypeGetByIds() { }

        public AccommodationTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class AccommodationTypePost : EdFi.Ods.Api.Models.Resources.V2.AccommodationType.AccommodationType
    {
    }

    public class AccommodationTypePut : EdFi.Ods.Api.Models.Resources.V2.AccommodationType.AccommodationType
    { 
    }

    public class AccommodationTypeDelete : IHasIdentifier 
    {
        public AccommodationTypeDelete() { }

        public AccommodationTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.Accounts
{ 
    public class AccountGetByKey
    {
        public string Number { get; set; }
        public int EducationOrganizationId { get; set; }
        public int FiscalYear { get; set; }
    }

    public class AccountGetByExample
    {
        public string Number { get; set; }
        public int EducationOrganizationId { get; set; }
        public int FiscalYear { get; set; }
        public Guid Id { get; set; }
    }

    public class AccountGetByIds : IHasIdentifiers<Guid>
    {
        public AccountGetByIds() { }

        public AccountGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class AccountPost : EdFi.Ods.Api.Models.Resources.V2.Account.Account
    {
    }

    public class AccountPut : EdFi.Ods.Api.Models.Resources.V2.Account.Account
    { 
    }

    public class AccountDelete : IHasIdentifier 
    {
        public AccountDelete() { }

        public AccountDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.AccountabilityRatings
{ 
    public class AccountabilityRatingGetByKey
    {
        public int EducationOrganizationId { get; set; }
        public string RatingTitle { get; set; }
        public short SchoolYear { get; set; }
    }

    public class AccountabilityRatingGetByExample
    {
        public int EducationOrganizationId { get; set; }
        public Guid Id { get; set; }
        public string Rating { get; set; }
        public DateTime RatingDate { get; set; }
        public string RatingOrganization { get; set; }
        public string RatingProgram { get; set; }
        public string RatingTitle { get; set; }
        public short SchoolYear { get; set; }
    }

    public class AccountabilityRatingGetByIds : IHasIdentifiers<Guid>
    {
        public AccountabilityRatingGetByIds() { }

        public AccountabilityRatingGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class AccountabilityRatingPost : EdFi.Ods.Api.Models.Resources.V2.AccountabilityRating.AccountabilityRating
    {
    }

    public class AccountabilityRatingPut : EdFi.Ods.Api.Models.Resources.V2.AccountabilityRating.AccountabilityRating
    { 
    }

    public class AccountabilityRatingDelete : IHasIdentifier 
    {
        public AccountabilityRatingDelete() { }

        public AccountabilityRatingDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.AccountCodeDescriptors
{ 
    public class AccountCodeDescriptorGetByKey
    {
        public int AccountCodeDescriptorId { get; set; }
    }

    public class AccountCodeDescriptorGetByExample
    {
        public string AccountCodeCategory { get; set; }
        public int AccountCodeDescriptorId { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
    }

    public class AccountCodeDescriptorGetByIds : IHasIdentifiers<Guid>
    {
        public AccountCodeDescriptorGetByIds() { }

        public AccountCodeDescriptorGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class AccountCodeDescriptorPost : EdFi.Ods.Api.Models.Resources.V2.AccountCodeDescriptor.AccountCodeDescriptor
    {
    }

    public class AccountCodeDescriptorPut : EdFi.Ods.Api.Models.Resources.V2.AccountCodeDescriptor.AccountCodeDescriptor
    { 
    }

    public class AccountCodeDescriptorDelete : IHasIdentifier 
    {
        public AccountCodeDescriptorDelete() { }

        public AccountCodeDescriptorDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.AchievementCategoryDescriptors
{ 
    public class AchievementCategoryDescriptorGetByKey
    {
        public int AchievementCategoryDescriptorId { get; set; }
    }

    public class AchievementCategoryDescriptorGetByExample
    {
        public int AchievementCategoryDescriptorId { get; set; }
        public string AchievementCategoryType { get; set; }
    }

    public class AchievementCategoryDescriptorGetByIds : IHasIdentifiers<Guid>
    {
        public AchievementCategoryDescriptorGetByIds() { }

        public AchievementCategoryDescriptorGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class AchievementCategoryDescriptorPost : EdFi.Ods.Api.Models.Resources.V2.AchievementCategoryDescriptor.AchievementCategoryDescriptor
    {
    }

    public class AchievementCategoryDescriptorPut : EdFi.Ods.Api.Models.Resources.V2.AchievementCategoryDescriptor.AchievementCategoryDescriptor
    { 
    }

    public class AchievementCategoryDescriptorDelete : IHasIdentifier 
    {
        public AchievementCategoryDescriptorDelete() { }

        public AchievementCategoryDescriptorDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.AchievementCategoryTypes
{ 
    public class AchievementCategoryTypeGetByKey
    {
        public int AchievementCategoryTypeId { get; set; }
    }

    public class AchievementCategoryTypeGetByExample
    {
        public int AchievementCategoryTypeId { get; set; }
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
    }

    public class AchievementCategoryTypeGetByIds : IHasIdentifiers<Guid>
    {
        public AchievementCategoryTypeGetByIds() { }

        public AchievementCategoryTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class AchievementCategoryTypePost : EdFi.Ods.Api.Models.Resources.V2.AchievementCategoryType.AchievementCategoryType
    {
    }

    public class AchievementCategoryTypePut : EdFi.Ods.Api.Models.Resources.V2.AchievementCategoryType.AchievementCategoryType
    { 
    }

    public class AchievementCategoryTypeDelete : IHasIdentifier 
    {
        public AchievementCategoryTypeDelete() { }

        public AchievementCategoryTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.Actuals
{ 
    public class ActualGetByKey
    {
        public string AccountNumber { get; set; }
        public DateTime AsOfDate { get; set; }
        public int EducationOrganizationId { get; set; }
        public int FiscalYear { get; set; }
    }

    public class ActualGetByExample
    {
        public string AccountNumber { get; set; }
        public decimal AmountToDate { get; set; }
        public DateTime AsOfDate { get; set; }
        public int EducationOrganizationId { get; set; }
        public int FiscalYear { get; set; }
        public Guid Id { get; set; }
    }

    public class ActualGetByIds : IHasIdentifiers<Guid>
    {
        public ActualGetByIds() { }

        public ActualGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class ActualPost : EdFi.Ods.Api.Models.Resources.V2.Actual.Actual
    {
    }

    public class ActualPut : EdFi.Ods.Api.Models.Resources.V2.Actual.Actual
    { 
    }

    public class ActualDelete : IHasIdentifier 
    {
        public ActualDelete() { }

        public ActualDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.AdditionalCreditTypes
{ 
    public class AdditionalCreditTypeGetByKey
    {
        public int AdditionalCreditTypeId { get; set; }
    }

    public class AdditionalCreditTypeGetByExample
    {
        public int AdditionalCreditTypeId { get; set; }
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
    }

    public class AdditionalCreditTypeGetByIds : IHasIdentifiers<Guid>
    {
        public AdditionalCreditTypeGetByIds() { }

        public AdditionalCreditTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class AdditionalCreditTypePost : EdFi.Ods.Api.Models.Resources.V2.AdditionalCreditType.AdditionalCreditType
    {
    }

    public class AdditionalCreditTypePut : EdFi.Ods.Api.Models.Resources.V2.AdditionalCreditType.AdditionalCreditType
    { 
    }

    public class AdditionalCreditTypeDelete : IHasIdentifier 
    {
        public AdditionalCreditTypeDelete() { }

        public AdditionalCreditTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.AddressTypes
{ 
    public class AddressTypeGetByKey
    {
        public int AddressTypeId { get; set; }
    }

    public class AddressTypeGetByExample
    {
        public int AddressTypeId { get; set; }
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
    }

    public class AddressTypeGetByIds : IHasIdentifiers<Guid>
    {
        public AddressTypeGetByIds() { }

        public AddressTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class AddressTypePost : EdFi.Ods.Api.Models.Resources.V2.AddressType.AddressType
    {
    }

    public class AddressTypePut : EdFi.Ods.Api.Models.Resources.V2.AddressType.AddressType
    { 
    }

    public class AddressTypeDelete : IHasIdentifier 
    {
        public AddressTypeDelete() { }

        public AddressTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.AdministrationEnvironmentTypes
{ 
    public class AdministrationEnvironmentTypeGetByKey
    {
        public int AdministrationEnvironmentTypeId { get; set; }
    }

    public class AdministrationEnvironmentTypeGetByExample
    {
        public int AdministrationEnvironmentTypeId { get; set; }
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
    }

    public class AdministrationEnvironmentTypeGetByIds : IHasIdentifiers<Guid>
    {
        public AdministrationEnvironmentTypeGetByIds() { }

        public AdministrationEnvironmentTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class AdministrationEnvironmentTypePost : EdFi.Ods.Api.Models.Resources.V2.AdministrationEnvironmentType.AdministrationEnvironmentType
    {
    }

    public class AdministrationEnvironmentTypePut : EdFi.Ods.Api.Models.Resources.V2.AdministrationEnvironmentType.AdministrationEnvironmentType
    { 
    }

    public class AdministrationEnvironmentTypeDelete : IHasIdentifier 
    {
        public AdministrationEnvironmentTypeDelete() { }

        public AdministrationEnvironmentTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.AdministrativeFundingControlDescriptors
{ 
    public class AdministrativeFundingControlDescriptorGetByKey
    {
        public int AdministrativeFundingControlDescriptorId { get; set; }
    }

    public class AdministrativeFundingControlDescriptorGetByExample
    {
        public int AdministrativeFundingControlDescriptorId { get; set; }
        public string AdministrativeFundingControlType { get; set; }
    }

    public class AdministrativeFundingControlDescriptorGetByIds : IHasIdentifiers<Guid>
    {
        public AdministrativeFundingControlDescriptorGetByIds() { }

        public AdministrativeFundingControlDescriptorGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class AdministrativeFundingControlDescriptorPost : EdFi.Ods.Api.Models.Resources.V2.AdministrativeFundingControlDescriptor.AdministrativeFundingControlDescriptor
    {
    }

    public class AdministrativeFundingControlDescriptorPut : EdFi.Ods.Api.Models.Resources.V2.AdministrativeFundingControlDescriptor.AdministrativeFundingControlDescriptor
    { 
    }

    public class AdministrativeFundingControlDescriptorDelete : IHasIdentifier 
    {
        public AdministrativeFundingControlDescriptorDelete() { }

        public AdministrativeFundingControlDescriptorDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.AdministrativeFundingControlTypes
{ 
    public class AdministrativeFundingControlTypeGetByKey
    {
        public int AdministrativeFundingControlTypeId { get; set; }
    }

    public class AdministrativeFundingControlTypeGetByExample
    {
        public int AdministrativeFundingControlTypeId { get; set; }
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
    }

    public class AdministrativeFundingControlTypeGetByIds : IHasIdentifiers<Guid>
    {
        public AdministrativeFundingControlTypeGetByIds() { }

        public AdministrativeFundingControlTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class AdministrativeFundingControlTypePost : EdFi.Ods.Api.Models.Resources.V2.AdministrativeFundingControlType.AdministrativeFundingControlType
    {
    }

    public class AdministrativeFundingControlTypePut : EdFi.Ods.Api.Models.Resources.V2.AdministrativeFundingControlType.AdministrativeFundingControlType
    { 
    }

    public class AdministrativeFundingControlTypeDelete : IHasIdentifier 
    {
        public AdministrativeFundingControlTypeDelete() { }

        public AdministrativeFundingControlTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.Assessments
{ 
    public class AssessmentGetByKey
    {
        public string Identifier { get; set; }
        public string Namespace { get; set; }
    }

    public class AssessmentGetByExample
    {
        public bool AdaptiveAssessment { get; set; }
        public string CategoryDescriptor { get; set; }
        public string FamilyTitle { get; set; }
        public string Form { get; set; }
        public string Identifier { get; set; }
        public string PeriodDescriptor { get; set; }
        public string Title { get; set; }
        public int EducationOrganizationId { get; set; }
        public Guid Id { get; set; }
        public int MaxRawScore { get; set; }
        public string Namespace { get; set; }
        public string Nomenclature { get; set; }
        public DateTime RevisionDate { get; set; }
        public int Version { get; set; }
    }

    public class AssessmentGetByIds : IHasIdentifiers<Guid>
    {
        public AssessmentGetByIds() { }

        public AssessmentGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class AssessmentPost : EdFi.Ods.Api.Models.Resources.V2.Assessment.Assessment
    {
    }

    public class AssessmentPut : EdFi.Ods.Api.Models.Resources.V2.Assessment.Assessment
    { 
    }

    public class AssessmentDelete : IHasIdentifier 
    {
        public AssessmentDelete() { }

        public AssessmentDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.AssessmentCategoryDescriptors
{ 
    public class AssessmentCategoryDescriptorGetByKey
    {
        public int AssessmentCategoryDescriptorId { get; set; }
    }

    public class AssessmentCategoryDescriptorGetByExample
    {
        public int AssessmentCategoryDescriptorId { get; set; }
        public string AssessmentCategoryType { get; set; }
    }

    public class AssessmentCategoryDescriptorGetByIds : IHasIdentifiers<Guid>
    {
        public AssessmentCategoryDescriptorGetByIds() { }

        public AssessmentCategoryDescriptorGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class AssessmentCategoryDescriptorPost : EdFi.Ods.Api.Models.Resources.V2.AssessmentCategoryDescriptor.AssessmentCategoryDescriptor
    {
    }

    public class AssessmentCategoryDescriptorPut : EdFi.Ods.Api.Models.Resources.V2.AssessmentCategoryDescriptor.AssessmentCategoryDescriptor
    { 
    }

    public class AssessmentCategoryDescriptorDelete : IHasIdentifier 
    {
        public AssessmentCategoryDescriptorDelete() { }

        public AssessmentCategoryDescriptorDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.AssessmentCategoryTypes
{ 
    public class AssessmentCategoryTypeGetByKey
    {
        public int AssessmentCategoryTypeId { get; set; }
    }

    public class AssessmentCategoryTypeGetByExample
    {
        public int AssessmentCategoryTypeId { get; set; }
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
    }

    public class AssessmentCategoryTypeGetByIds : IHasIdentifiers<Guid>
    {
        public AssessmentCategoryTypeGetByIds() { }

        public AssessmentCategoryTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class AssessmentCategoryTypePost : EdFi.Ods.Api.Models.Resources.V2.AssessmentCategoryType.AssessmentCategoryType
    {
    }

    public class AssessmentCategoryTypePut : EdFi.Ods.Api.Models.Resources.V2.AssessmentCategoryType.AssessmentCategoryType
    { 
    }

    public class AssessmentCategoryTypeDelete : IHasIdentifier 
    {
        public AssessmentCategoryTypeDelete() { }

        public AssessmentCategoryTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.AssessmentFamilies
{ 
    public class AssessmentFamilyGetByKey
    {
        public string Title { get; set; }
    }

    public class AssessmentFamilyGetByExample
    {
        public string AcademicSubjectDescriptor { get; set; }
        public string AssessedGradeLevelDescriptor { get; set; }
        public string AssessmentCategoryDescriptor { get; set; }
        public string Title { get; set; }
        public Guid Id { get; set; }
        public string LowestAssessedGradeLevelDescriptor { get; set; }
        public string Namespace { get; set; }
        public string Nomenclature { get; set; }
        public string ParentAssessmentFamilyTitle { get; set; }
        public DateTime RevisionDate { get; set; }
        public int Version { get; set; }
    }

    public class AssessmentFamilyGetByIds : IHasIdentifiers<Guid>
    {
        public AssessmentFamilyGetByIds() { }

        public AssessmentFamilyGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class AssessmentFamilyPost : EdFi.Ods.Api.Models.Resources.V2.AssessmentFamily.AssessmentFamily
    {
    }

    public class AssessmentFamilyPut : EdFi.Ods.Api.Models.Resources.V2.AssessmentFamily.AssessmentFamily
    { 
    }

    public class AssessmentFamilyDelete : IHasIdentifier 
    {
        public AssessmentFamilyDelete() { }

        public AssessmentFamilyDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.AssessmentIdentificationSystemDescriptors
{ 
    public class AssessmentIdentificationSystemDescriptorGetByKey
    {
        public int AssessmentIdentificationSystemDescriptorId { get; set; }
    }

    public class AssessmentIdentificationSystemDescriptorGetByExample
    {
        public int AssessmentIdentificationSystemDescriptorId { get; set; }
        public string AssessmentIdentificationSystemType { get; set; }
    }

    public class AssessmentIdentificationSystemDescriptorGetByIds : IHasIdentifiers<Guid>
    {
        public AssessmentIdentificationSystemDescriptorGetByIds() { }

        public AssessmentIdentificationSystemDescriptorGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class AssessmentIdentificationSystemDescriptorPost : EdFi.Ods.Api.Models.Resources.V2.AssessmentIdentificationSystemDescriptor.AssessmentIdentificationSystemDescriptor
    {
    }

    public class AssessmentIdentificationSystemDescriptorPut : EdFi.Ods.Api.Models.Resources.V2.AssessmentIdentificationSystemDescriptor.AssessmentIdentificationSystemDescriptor
    { 
    }

    public class AssessmentIdentificationSystemDescriptorDelete : IHasIdentifier 
    {
        public AssessmentIdentificationSystemDescriptorDelete() { }

        public AssessmentIdentificationSystemDescriptorDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.AssessmentIdentificationSystemTypes
{ 
    public class AssessmentIdentificationSystemTypeGetByKey
    {
        public int AssessmentIdentificationSystemTypeId { get; set; }
    }

    public class AssessmentIdentificationSystemTypeGetByExample
    {
        public int AssessmentIdentificationSystemTypeId { get; set; }
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
    }

    public class AssessmentIdentificationSystemTypeGetByIds : IHasIdentifiers<Guid>
    {
        public AssessmentIdentificationSystemTypeGetByIds() { }

        public AssessmentIdentificationSystemTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class AssessmentIdentificationSystemTypePost : EdFi.Ods.Api.Models.Resources.V2.AssessmentIdentificationSystemType.AssessmentIdentificationSystemType
    {
    }

    public class AssessmentIdentificationSystemTypePut : EdFi.Ods.Api.Models.Resources.V2.AssessmentIdentificationSystemType.AssessmentIdentificationSystemType
    { 
    }

    public class AssessmentIdentificationSystemTypeDelete : IHasIdentifier 
    {
        public AssessmentIdentificationSystemTypeDelete() { }

        public AssessmentIdentificationSystemTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.AssessmentItems
{ 
    public class AssessmentItemGetByKey
    {
        public string AssessmentIdentifier { get; set; }
        public string IdentificationCode { get; set; }
        public string Namespace { get; set; }
    }

    public class AssessmentItemGetByExample
    {
        public string AssessmentIdentifier { get; set; }
        public string CategoryType { get; set; }
        public string CorrectResponse { get; set; }
        public string ExpectedTimeAssessed { get; set; }
        public Guid Id { get; set; }
        public string IdentificationCode { get; set; }
        public int MaxRawScore { get; set; }
        public string Namespace { get; set; }
        public string Nomenclature { get; set; }
    }

    public class AssessmentItemGetByIds : IHasIdentifiers<Guid>
    {
        public AssessmentItemGetByIds() { }

        public AssessmentItemGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class AssessmentItemPost : EdFi.Ods.Api.Models.Resources.V2.AssessmentItem.AssessmentItem
    {
    }

    public class AssessmentItemPut : EdFi.Ods.Api.Models.Resources.V2.AssessmentItem.AssessmentItem
    { 
    }

    public class AssessmentItemDelete : IHasIdentifier 
    {
        public AssessmentItemDelete() { }

        public AssessmentItemDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.AssessmentItemCategoryTypes
{ 
    public class AssessmentItemCategoryTypeGetByKey
    {
        public int AssessmentItemCategoryTypeId { get; set; }
    }

    public class AssessmentItemCategoryTypeGetByExample
    {
        public int AssessmentItemCategoryTypeId { get; set; }
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
    }

    public class AssessmentItemCategoryTypeGetByIds : IHasIdentifiers<Guid>
    {
        public AssessmentItemCategoryTypeGetByIds() { }

        public AssessmentItemCategoryTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class AssessmentItemCategoryTypePost : EdFi.Ods.Api.Models.Resources.V2.AssessmentItemCategoryType.AssessmentItemCategoryType
    {
    }

    public class AssessmentItemCategoryTypePut : EdFi.Ods.Api.Models.Resources.V2.AssessmentItemCategoryType.AssessmentItemCategoryType
    { 
    }

    public class AssessmentItemCategoryTypeDelete : IHasIdentifier 
    {
        public AssessmentItemCategoryTypeDelete() { }

        public AssessmentItemCategoryTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.AssessmentItemResultTypes
{ 
    public class AssessmentItemResultTypeGetByKey
    {
        public int AssessmentItemResultTypeId { get; set; }
    }

    public class AssessmentItemResultTypeGetByExample
    {
        public int AssessmentItemResultTypeId { get; set; }
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
    }

    public class AssessmentItemResultTypeGetByIds : IHasIdentifiers<Guid>
    {
        public AssessmentItemResultTypeGetByIds() { }

        public AssessmentItemResultTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class AssessmentItemResultTypePost : EdFi.Ods.Api.Models.Resources.V2.AssessmentItemResultType.AssessmentItemResultType
    {
    }

    public class AssessmentItemResultTypePut : EdFi.Ods.Api.Models.Resources.V2.AssessmentItemResultType.AssessmentItemResultType
    { 
    }

    public class AssessmentItemResultTypeDelete : IHasIdentifier 
    {
        public AssessmentItemResultTypeDelete() { }

        public AssessmentItemResultTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.AssessmentPeriodDescriptors
{ 
    public class AssessmentPeriodDescriptorGetByKey
    {
        public int AssessmentPeriodDescriptorId { get; set; }
    }

    public class AssessmentPeriodDescriptorGetByExample
    {
        public int AssessmentPeriodDescriptorId { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
    }

    public class AssessmentPeriodDescriptorGetByIds : IHasIdentifiers<Guid>
    {
        public AssessmentPeriodDescriptorGetByIds() { }

        public AssessmentPeriodDescriptorGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class AssessmentPeriodDescriptorPost : EdFi.Ods.Api.Models.Resources.V2.AssessmentPeriodDescriptor.AssessmentPeriodDescriptor
    {
    }

    public class AssessmentPeriodDescriptorPut : EdFi.Ods.Api.Models.Resources.V2.AssessmentPeriodDescriptor.AssessmentPeriodDescriptor
    { 
    }

    public class AssessmentPeriodDescriptorDelete : IHasIdentifier 
    {
        public AssessmentPeriodDescriptorDelete() { }

        public AssessmentPeriodDescriptorDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.AssessmentReportingMethodTypes
{ 
    public class AssessmentReportingMethodTypeGetByKey
    {
        public int AssessmentReportingMethodTypeId { get; set; }
    }

    public class AssessmentReportingMethodTypeGetByExample
    {
        public int AssessmentReportingMethodTypeId { get; set; }
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
    }

    public class AssessmentReportingMethodTypeGetByIds : IHasIdentifiers<Guid>
    {
        public AssessmentReportingMethodTypeGetByIds() { }

        public AssessmentReportingMethodTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class AssessmentReportingMethodTypePost : EdFi.Ods.Api.Models.Resources.V2.AssessmentReportingMethodType.AssessmentReportingMethodType
    {
    }

    public class AssessmentReportingMethodTypePut : EdFi.Ods.Api.Models.Resources.V2.AssessmentReportingMethodType.AssessmentReportingMethodType
    { 
    }

    public class AssessmentReportingMethodTypeDelete : IHasIdentifier 
    {
        public AssessmentReportingMethodTypeDelete() { }

        public AssessmentReportingMethodTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.AttendanceEventCategoryDescriptors
{ 
    public class AttendanceEventCategoryDescriptorGetByKey
    {
        public int AttendanceEventCategoryDescriptorId { get; set; }
    }

    public class AttendanceEventCategoryDescriptorGetByExample
    {
        public int AttendanceEventCategoryDescriptorId { get; set; }
        public string AttendanceEventCategoryType { get; set; }
    }

    public class AttendanceEventCategoryDescriptorGetByIds : IHasIdentifiers<Guid>
    {
        public AttendanceEventCategoryDescriptorGetByIds() { }

        public AttendanceEventCategoryDescriptorGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class AttendanceEventCategoryDescriptorPost : EdFi.Ods.Api.Models.Resources.V2.AttendanceEventCategoryDescriptor.AttendanceEventCategoryDescriptor
    {
    }

    public class AttendanceEventCategoryDescriptorPut : EdFi.Ods.Api.Models.Resources.V2.AttendanceEventCategoryDescriptor.AttendanceEventCategoryDescriptor
    { 
    }

    public class AttendanceEventCategoryDescriptorDelete : IHasIdentifier 
    {
        public AttendanceEventCategoryDescriptorDelete() { }

        public AttendanceEventCategoryDescriptorDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.AttendanceEventCategoryTypes
{ 
    public class AttendanceEventCategoryTypeGetByKey
    {
        public int AttendanceEventCategoryTypeId { get; set; }
    }

    public class AttendanceEventCategoryTypeGetByExample
    {
        public int AttendanceEventCategoryTypeId { get; set; }
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
    }

    public class AttendanceEventCategoryTypeGetByIds : IHasIdentifiers<Guid>
    {
        public AttendanceEventCategoryTypeGetByIds() { }

        public AttendanceEventCategoryTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class AttendanceEventCategoryTypePost : EdFi.Ods.Api.Models.Resources.V2.AttendanceEventCategoryType.AttendanceEventCategoryType
    {
    }

    public class AttendanceEventCategoryTypePut : EdFi.Ods.Api.Models.Resources.V2.AttendanceEventCategoryType.AttendanceEventCategoryType
    { 
    }

    public class AttendanceEventCategoryTypeDelete : IHasIdentifier 
    {
        public AttendanceEventCategoryTypeDelete() { }

        public AttendanceEventCategoryTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.BehaviorDescriptors
{ 
    public class BehaviorDescriptorGetByKey
    {
        public int BehaviorDescriptorId { get; set; }
    }

    public class BehaviorDescriptorGetByExample
    {
        public int BehaviorDescriptorId { get; set; }
        public string BehaviorType { get; set; }
    }

    public class BehaviorDescriptorGetByIds : IHasIdentifiers<Guid>
    {
        public BehaviorDescriptorGetByIds() { }

        public BehaviorDescriptorGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class BehaviorDescriptorPost : EdFi.Ods.Api.Models.Resources.V2.BehaviorDescriptor.BehaviorDescriptor
    {
    }

    public class BehaviorDescriptorPut : EdFi.Ods.Api.Models.Resources.V2.BehaviorDescriptor.BehaviorDescriptor
    { 
    }

    public class BehaviorDescriptorDelete : IHasIdentifier 
    {
        public BehaviorDescriptorDelete() { }

        public BehaviorDescriptorDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.BehaviorTypes
{ 
    public class BehaviorTypeGetByKey
    {
        public int BehaviorTypeId { get; set; }
    }

    public class BehaviorTypeGetByExample
    {
        public int BehaviorTypeId { get; set; }
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
    }

    public class BehaviorTypeGetByIds : IHasIdentifiers<Guid>
    {
        public BehaviorTypeGetByIds() { }

        public BehaviorTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class BehaviorTypePost : EdFi.Ods.Api.Models.Resources.V2.BehaviorType.BehaviorType
    {
    }

    public class BehaviorTypePut : EdFi.Ods.Api.Models.Resources.V2.BehaviorType.BehaviorType
    { 
    }

    public class BehaviorTypeDelete : IHasIdentifier 
    {
        public BehaviorTypeDelete() { }

        public BehaviorTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.BellSchedules
{ 
    public class BellScheduleGetByKey
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string GradeLevelDescriptor { get; set; }
        public int SchoolId { get; set; }
    }

    public class BellScheduleGetByExample
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string GradeLevelDescriptor { get; set; }
        public Guid Id { get; set; }
        public int SchoolId { get; set; }
    }

    public class BellScheduleGetByIds : IHasIdentifiers<Guid>
    {
        public BellScheduleGetByIds() { }

        public BellScheduleGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class BellSchedulePost : EdFi.Ods.Api.Models.Resources.V2.BellSchedule.BellSchedule
    {
    }

    public class BellSchedulePut : EdFi.Ods.Api.Models.Resources.V2.BellSchedule.BellSchedule
    { 
    }

    public class BellScheduleDelete : IHasIdentifier 
    {
        public BellScheduleDelete() { }

        public BellScheduleDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.Budgets
{ 
    public class BudgetGetByKey
    {
        public string AccountNumber { get; set; }
        public DateTime AsOfDate { get; set; }
        public int EducationOrganizationId { get; set; }
        public int FiscalYear { get; set; }
    }

    public class BudgetGetByExample
    {
        public string AccountNumber { get; set; }
        public decimal Amount { get; set; }
        public DateTime AsOfDate { get; set; }
        public int EducationOrganizationId { get; set; }
        public int FiscalYear { get; set; }
        public Guid Id { get; set; }
    }

    public class BudgetGetByIds : IHasIdentifiers<Guid>
    {
        public BudgetGetByIds() { }

        public BudgetGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class BudgetPost : EdFi.Ods.Api.Models.Resources.V2.Budget.Budget
    {
    }

    public class BudgetPut : EdFi.Ods.Api.Models.Resources.V2.Budget.Budget
    { 
    }

    public class BudgetDelete : IHasIdentifier 
    {
        public BudgetDelete() { }

        public BudgetDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.CalendarDates
{ 
    public class CalendarDateGetByKey
    {
        public DateTime Date { get; set; }
        public int SchoolId { get; set; }
    }

    public class CalendarDateGetByExample
    {
        public DateTime Date { get; set; }
        public Guid Id { get; set; }
        public int SchoolId { get; set; }
    }

    public class CalendarDateGetByIds : IHasIdentifiers<Guid>
    {
        public CalendarDateGetByIds() { }

        public CalendarDateGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class CalendarDatePost : EdFi.Ods.Api.Models.Resources.V2.CalendarDate.CalendarDate
    {
    }

    public class CalendarDatePut : EdFi.Ods.Api.Models.Resources.V2.CalendarDate.CalendarDate
    { 
    }

    public class CalendarDateDelete : IHasIdentifier 
    {
        public CalendarDateDelete() { }

        public CalendarDateDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.CalendarEventDescriptors
{ 
    public class CalendarEventDescriptorGetByKey
    {
        public int CalendarEventDescriptorId { get; set; }
    }

    public class CalendarEventDescriptorGetByExample
    {
        public int CalendarEventDescriptorId { get; set; }
        public string CalendarEventType { get; set; }
    }

    public class CalendarEventDescriptorGetByIds : IHasIdentifiers<Guid>
    {
        public CalendarEventDescriptorGetByIds() { }

        public CalendarEventDescriptorGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class CalendarEventDescriptorPost : EdFi.Ods.Api.Models.Resources.V2.CalendarEventDescriptor.CalendarEventDescriptor
    {
    }

    public class CalendarEventDescriptorPut : EdFi.Ods.Api.Models.Resources.V2.CalendarEventDescriptor.CalendarEventDescriptor
    { 
    }

    public class CalendarEventDescriptorDelete : IHasIdentifier 
    {
        public CalendarEventDescriptorDelete() { }

        public CalendarEventDescriptorDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.CalendarEventTypes
{ 
    public class CalendarEventTypeGetByKey
    {
        public int CalendarEventTypeId { get; set; }
    }

    public class CalendarEventTypeGetByExample
    {
        public int CalendarEventTypeId { get; set; }
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
    }

    public class CalendarEventTypeGetByIds : IHasIdentifiers<Guid>
    {
        public CalendarEventTypeGetByIds() { }

        public CalendarEventTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class CalendarEventTypePost : EdFi.Ods.Api.Models.Resources.V2.CalendarEventType.CalendarEventType
    {
    }

    public class CalendarEventTypePut : EdFi.Ods.Api.Models.Resources.V2.CalendarEventType.CalendarEventType
    { 
    }

    public class CalendarEventTypeDelete : IHasIdentifier 
    {
        public CalendarEventTypeDelete() { }

        public CalendarEventTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.CareerPathwayTypes
{ 
    public class CareerPathwayTypeGetByKey
    {
        public int CareerPathwayTypeId { get; set; }
    }

    public class CareerPathwayTypeGetByExample
    {
        public int CareerPathwayTypeId { get; set; }
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
    }

    public class CareerPathwayTypeGetByIds : IHasIdentifiers<Guid>
    {
        public CareerPathwayTypeGetByIds() { }

        public CareerPathwayTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class CareerPathwayTypePost : EdFi.Ods.Api.Models.Resources.V2.CareerPathwayType.CareerPathwayType
    {
    }

    public class CareerPathwayTypePut : EdFi.Ods.Api.Models.Resources.V2.CareerPathwayType.CareerPathwayType
    { 
    }

    public class CareerPathwayTypeDelete : IHasIdentifier 
    {
        public CareerPathwayTypeDelete() { }

        public CareerPathwayTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.CharterApprovalAgencyTypes
{ 
    public class CharterApprovalAgencyTypeGetByKey
    {
        public int CharterApprovalAgencyTypeId { get; set; }
    }

    public class CharterApprovalAgencyTypeGetByExample
    {
        public int CharterApprovalAgencyTypeId { get; set; }
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
    }

    public class CharterApprovalAgencyTypeGetByIds : IHasIdentifiers<Guid>
    {
        public CharterApprovalAgencyTypeGetByIds() { }

        public CharterApprovalAgencyTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class CharterApprovalAgencyTypePost : EdFi.Ods.Api.Models.Resources.V2.CharterApprovalAgencyType.CharterApprovalAgencyType
    {
    }

    public class CharterApprovalAgencyTypePut : EdFi.Ods.Api.Models.Resources.V2.CharterApprovalAgencyType.CharterApprovalAgencyType
    { 
    }

    public class CharterApprovalAgencyTypeDelete : IHasIdentifier 
    {
        public CharterApprovalAgencyTypeDelete() { }

        public CharterApprovalAgencyTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.CharterStatusTypes
{ 
    public class CharterStatusTypeGetByKey
    {
        public int CharterStatusTypeId { get; set; }
    }

    public class CharterStatusTypeGetByExample
    {
        public int CharterStatusTypeId { get; set; }
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
    }

    public class CharterStatusTypeGetByIds : IHasIdentifiers<Guid>
    {
        public CharterStatusTypeGetByIds() { }

        public CharterStatusTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class CharterStatusTypePost : EdFi.Ods.Api.Models.Resources.V2.CharterStatusType.CharterStatusType
    {
    }

    public class CharterStatusTypePut : EdFi.Ods.Api.Models.Resources.V2.CharterStatusType.CharterStatusType
    { 
    }

    public class CharterStatusTypeDelete : IHasIdentifier 
    {
        public CharterStatusTypeDelete() { }

        public CharterStatusTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.CitizenshipStatusTypes
{ 
    public class CitizenshipStatusTypeGetByKey
    {
        public int CitizenshipStatusTypeId { get; set; }
    }

    public class CitizenshipStatusTypeGetByExample
    {
        public int CitizenshipStatusTypeId { get; set; }
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
    }

    public class CitizenshipStatusTypeGetByIds : IHasIdentifiers<Guid>
    {
        public CitizenshipStatusTypeGetByIds() { }

        public CitizenshipStatusTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class CitizenshipStatusTypePost : EdFi.Ods.Api.Models.Resources.V2.CitizenshipStatusType.CitizenshipStatusType
    {
    }

    public class CitizenshipStatusTypePut : EdFi.Ods.Api.Models.Resources.V2.CitizenshipStatusType.CitizenshipStatusType
    { 
    }

    public class CitizenshipStatusTypeDelete : IHasIdentifier 
    {
        public CitizenshipStatusTypeDelete() { }

        public CitizenshipStatusTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.ClassPeriods
{ 
    public class ClassPeriodGetByKey
    {
        public string Name { get; set; }
        public int SchoolId { get; set; }
    }

    public class ClassPeriodGetByExample
    {
        public string Name { get; set; }
        public Guid Id { get; set; }
        public int SchoolId { get; set; }
    }

    public class ClassPeriodGetByIds : IHasIdentifiers<Guid>
    {
        public ClassPeriodGetByIds() { }

        public ClassPeriodGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class ClassPeriodPost : EdFi.Ods.Api.Models.Resources.V2.ClassPeriod.ClassPeriod
    {
    }

    public class ClassPeriodPut : EdFi.Ods.Api.Models.Resources.V2.ClassPeriod.ClassPeriod
    { 
    }

    public class ClassPeriodDelete : IHasIdentifier 
    {
        public ClassPeriodDelete() { }

        public ClassPeriodDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.ClassroomPositionDescriptors
{ 
    public class ClassroomPositionDescriptorGetByKey
    {
        public int ClassroomPositionDescriptorId { get; set; }
    }

    public class ClassroomPositionDescriptorGetByExample
    {
        public int ClassroomPositionDescriptorId { get; set; }
        public string ClassroomPositionType { get; set; }
    }

    public class ClassroomPositionDescriptorGetByIds : IHasIdentifiers<Guid>
    {
        public ClassroomPositionDescriptorGetByIds() { }

        public ClassroomPositionDescriptorGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class ClassroomPositionDescriptorPost : EdFi.Ods.Api.Models.Resources.V2.ClassroomPositionDescriptor.ClassroomPositionDescriptor
    {
    }

    public class ClassroomPositionDescriptorPut : EdFi.Ods.Api.Models.Resources.V2.ClassroomPositionDescriptor.ClassroomPositionDescriptor
    { 
    }

    public class ClassroomPositionDescriptorDelete : IHasIdentifier 
    {
        public ClassroomPositionDescriptorDelete() { }

        public ClassroomPositionDescriptorDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.ClassroomPositionTypes
{ 
    public class ClassroomPositionTypeGetByKey
    {
        public int ClassroomPositionTypeId { get; set; }
    }

    public class ClassroomPositionTypeGetByExample
    {
        public int ClassroomPositionTypeId { get; set; }
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
    }

    public class ClassroomPositionTypeGetByIds : IHasIdentifiers<Guid>
    {
        public ClassroomPositionTypeGetByIds() { }

        public ClassroomPositionTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class ClassroomPositionTypePost : EdFi.Ods.Api.Models.Resources.V2.ClassroomPositionType.ClassroomPositionType
    {
    }

    public class ClassroomPositionTypePut : EdFi.Ods.Api.Models.Resources.V2.ClassroomPositionType.ClassroomPositionType
    { 
    }

    public class ClassroomPositionTypeDelete : IHasIdentifier 
    {
        public ClassroomPositionTypeDelete() { }

        public ClassroomPositionTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.Cohorts
{ 
    public class CohortGetByKey
    {
        public string Identifier { get; set; }
        public int EducationOrganizationId { get; set; }
    }

    public class CohortGetByExample
    {
        public string AcademicSubjectDescriptor { get; set; }
        public string Description { get; set; }
        public string Identifier { get; set; }
        public string ScopeType { get; set; }
        public string Type { get; set; }
        public int EducationOrganizationId { get; set; }
        public Guid Id { get; set; }
    }

    public class CohortGetByIds : IHasIdentifiers<Guid>
    {
        public CohortGetByIds() { }

        public CohortGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class CohortPost : EdFi.Ods.Api.Models.Resources.V2.Cohort.Cohort
    {
    }

    public class CohortPut : EdFi.Ods.Api.Models.Resources.V2.Cohort.Cohort
    { 
    }

    public class CohortDelete : IHasIdentifier 
    {
        public CohortDelete() { }

        public CohortDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.CohortScopeTypes
{ 
    public class CohortScopeTypeGetByKey
    {
        public int CohortScopeTypeId { get; set; }
    }

    public class CohortScopeTypeGetByExample
    {
        public string CodeValue { get; set; }
        public int CohortScopeTypeId { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
    }

    public class CohortScopeTypeGetByIds : IHasIdentifiers<Guid>
    {
        public CohortScopeTypeGetByIds() { }

        public CohortScopeTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class CohortScopeTypePost : EdFi.Ods.Api.Models.Resources.V2.CohortScopeType.CohortScopeType
    {
    }

    public class CohortScopeTypePut : EdFi.Ods.Api.Models.Resources.V2.CohortScopeType.CohortScopeType
    { 
    }

    public class CohortScopeTypeDelete : IHasIdentifier 
    {
        public CohortScopeTypeDelete() { }

        public CohortScopeTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.CohortTypes
{ 
    public class CohortTypeGetByKey
    {
        public int CohortTypeId { get; set; }
    }

    public class CohortTypeGetByExample
    {
        public string CodeValue { get; set; }
        public int CohortTypeId { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
    }

    public class CohortTypeGetByIds : IHasIdentifiers<Guid>
    {
        public CohortTypeGetByIds() { }

        public CohortTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class CohortTypePost : EdFi.Ods.Api.Models.Resources.V2.CohortType.CohortType
    {
    }

    public class CohortTypePut : EdFi.Ods.Api.Models.Resources.V2.CohortType.CohortType
    { 
    }

    public class CohortTypeDelete : IHasIdentifier 
    {
        public CohortTypeDelete() { }

        public CohortTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.CohortYearTypes
{ 
    public class CohortYearTypeGetByKey
    {
        public int CohortYearTypeId { get; set; }
    }

    public class CohortYearTypeGetByExample
    {
        public string CodeValue { get; set; }
        public int CohortYearTypeId { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
    }

    public class CohortYearTypeGetByIds : IHasIdentifiers<Guid>
    {
        public CohortYearTypeGetByIds() { }

        public CohortYearTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class CohortYearTypePost : EdFi.Ods.Api.Models.Resources.V2.CohortYearType.CohortYearType
    {
    }

    public class CohortYearTypePut : EdFi.Ods.Api.Models.Resources.V2.CohortYearType.CohortYearType
    { 
    }

    public class CohortYearTypeDelete : IHasIdentifier 
    {
        public CohortYearTypeDelete() { }

        public CohortYearTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.CompetencyLevelDescriptors
{ 
    public class CompetencyLevelDescriptorGetByKey
    {
        public int CompetencyLevelDescriptorId { get; set; }
    }

    public class CompetencyLevelDescriptorGetByExample
    {
        public int CompetencyLevelDescriptorId { get; set; }
        public string PerformanceBaseConversionType { get; set; }
    }

    public class CompetencyLevelDescriptorGetByIds : IHasIdentifiers<Guid>
    {
        public CompetencyLevelDescriptorGetByIds() { }

        public CompetencyLevelDescriptorGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class CompetencyLevelDescriptorPost : EdFi.Ods.Api.Models.Resources.V2.CompetencyLevelDescriptor.CompetencyLevelDescriptor
    {
    }

    public class CompetencyLevelDescriptorPut : EdFi.Ods.Api.Models.Resources.V2.CompetencyLevelDescriptor.CompetencyLevelDescriptor
    { 
    }

    public class CompetencyLevelDescriptorDelete : IHasIdentifier 
    {
        public CompetencyLevelDescriptorDelete() { }

        public CompetencyLevelDescriptorDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.CompetencyObjectives
{ 
    public class CompetencyObjectiveGetByKey
    {
        public int EducationOrganizationId { get; set; }
        public string Objective { get; set; }
        public string ObjectiveGradeLevelDescriptor { get; set; }
    }

    public class CompetencyObjectiveGetByExample
    {
        public string CompetencyObjectiveId { get; set; }
        public string Description { get; set; }
        public int EducationOrganizationId { get; set; }
        public Guid Id { get; set; }
        public string Objective { get; set; }
        public string ObjectiveGradeLevelDescriptor { get; set; }
        public string SuccessCriteria { get; set; }
    }

    public class CompetencyObjectiveGetByIds : IHasIdentifiers<Guid>
    {
        public CompetencyObjectiveGetByIds() { }

        public CompetencyObjectiveGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class CompetencyObjectivePost : EdFi.Ods.Api.Models.Resources.V2.CompetencyObjective.CompetencyObjective
    {
    }

    public class CompetencyObjectivePut : EdFi.Ods.Api.Models.Resources.V2.CompetencyObjective.CompetencyObjective
    { 
    }

    public class CompetencyObjectiveDelete : IHasIdentifier 
    {
        public CompetencyObjectiveDelete() { }

        public CompetencyObjectiveDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.ContentClassTypes
{ 
    public class ContentClassTypeGetByKey
    {
        public int ContentClassTypeId { get; set; }
    }

    public class ContentClassTypeGetByExample
    {
        public string CodeValue { get; set; }
        public int ContentClassTypeId { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
    }

    public class ContentClassTypeGetByIds : IHasIdentifiers<Guid>
    {
        public ContentClassTypeGetByIds() { }

        public ContentClassTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class ContentClassTypePost : EdFi.Ods.Api.Models.Resources.V2.ContentClassType.ContentClassType
    {
    }

    public class ContentClassTypePut : EdFi.Ods.Api.Models.Resources.V2.ContentClassType.ContentClassType
    { 
    }

    public class ContentClassTypeDelete : IHasIdentifier 
    {
        public ContentClassTypeDelete() { }

        public ContentClassTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.ContinuationOfServicesReasonDescriptors
{ 
    public class ContinuationOfServicesReasonDescriptorGetByKey
    {
        public int ContinuationOfServicesReasonDescriptorId { get; set; }
    }

    public class ContinuationOfServicesReasonDescriptorGetByExample
    {
        public int ContinuationOfServicesReasonDescriptorId { get; set; }
        public string ContinuationOfServicesReasonType { get; set; }
    }

    public class ContinuationOfServicesReasonDescriptorGetByIds : IHasIdentifiers<Guid>
    {
        public ContinuationOfServicesReasonDescriptorGetByIds() { }

        public ContinuationOfServicesReasonDescriptorGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class ContinuationOfServicesReasonDescriptorPost : EdFi.Ods.Api.Models.Resources.V2.ContinuationOfServicesReasonDescriptor.ContinuationOfServicesReasonDescriptor
    {
    }

    public class ContinuationOfServicesReasonDescriptorPut : EdFi.Ods.Api.Models.Resources.V2.ContinuationOfServicesReasonDescriptor.ContinuationOfServicesReasonDescriptor
    { 
    }

    public class ContinuationOfServicesReasonDescriptorDelete : IHasIdentifier 
    {
        public ContinuationOfServicesReasonDescriptorDelete() { }

        public ContinuationOfServicesReasonDescriptorDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.ContinuationOfServicesReasonTypes
{ 
    public class ContinuationOfServicesReasonTypeGetByKey
    {
        public int ContinuationOfServicesReasonTypeId { get; set; }
    }

    public class ContinuationOfServicesReasonTypeGetByExample
    {
        public string CodeValue { get; set; }
        public int ContinuationOfServicesReasonTypeId { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
    }

    public class ContinuationOfServicesReasonTypeGetByIds : IHasIdentifiers<Guid>
    {
        public ContinuationOfServicesReasonTypeGetByIds() { }

        public ContinuationOfServicesReasonTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class ContinuationOfServicesReasonTypePost : EdFi.Ods.Api.Models.Resources.V2.ContinuationOfServicesReasonType.ContinuationOfServicesReasonType
    {
    }

    public class ContinuationOfServicesReasonTypePut : EdFi.Ods.Api.Models.Resources.V2.ContinuationOfServicesReasonType.ContinuationOfServicesReasonType
    { 
    }

    public class ContinuationOfServicesReasonTypeDelete : IHasIdentifier 
    {
        public ContinuationOfServicesReasonTypeDelete() { }

        public ContinuationOfServicesReasonTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.ContractedStaffs
{ 
    public class ContractedStaffGetByKey
    {
        public string AccountNumber { get; set; }
        public DateTime AsOfDate { get; set; }
        public int EducationOrganizationId { get; set; }
        public int FiscalYear { get; set; }
        public string StaffUniqueId { get; set; }
    }

    public class ContractedStaffGetByExample
    {
        public string AccountNumber { get; set; }
        public decimal AmountToDate { get; set; }
        public DateTime AsOfDate { get; set; }
        public int EducationOrganizationId { get; set; }
        public int FiscalYear { get; set; }
        public Guid Id { get; set; }
        public string StaffUniqueId { get; set; }
    }

    public class ContractedStaffGetByIds : IHasIdentifiers<Guid>
    {
        public ContractedStaffGetByIds() { }

        public ContractedStaffGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class ContractedStaffPost : EdFi.Ods.Api.Models.Resources.V2.ContractedStaff.ContractedStaff
    {
    }

    public class ContractedStaffPut : EdFi.Ods.Api.Models.Resources.V2.ContractedStaff.ContractedStaff
    { 
    }

    public class ContractedStaffDelete : IHasIdentifier 
    {
        public ContractedStaffDelete() { }

        public ContractedStaffDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.CostRateTypes
{ 
    public class CostRateTypeGetByKey
    {
        public int CostRateTypeId { get; set; }
    }

    public class CostRateTypeGetByExample
    {
        public string CodeValue { get; set; }
        public int CostRateTypeId { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
    }

    public class CostRateTypeGetByIds : IHasIdentifiers<Guid>
    {
        public CostRateTypeGetByIds() { }

        public CostRateTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class CostRateTypePost : EdFi.Ods.Api.Models.Resources.V2.CostRateType.CostRateType
    {
    }

    public class CostRateTypePut : EdFi.Ods.Api.Models.Resources.V2.CostRateType.CostRateType
    { 
    }

    public class CostRateTypeDelete : IHasIdentifier 
    {
        public CostRateTypeDelete() { }

        public CostRateTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.CountryDescriptors
{ 
    public class CountryDescriptorGetByKey
    {
        public int CountryDescriptorId { get; set; }
    }

    public class CountryDescriptorGetByExample
    {
        public int CountryDescriptorId { get; set; }
    }

    public class CountryDescriptorGetByIds : IHasIdentifiers<Guid>
    {
        public CountryDescriptorGetByIds() { }

        public CountryDescriptorGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class CountryDescriptorPost : EdFi.Ods.Api.Models.Resources.V2.CountryDescriptor.CountryDescriptor
    {
    }

    public class CountryDescriptorPut : EdFi.Ods.Api.Models.Resources.V2.CountryDescriptor.CountryDescriptor
    { 
    }

    public class CountryDescriptorDelete : IHasIdentifier 
    {
        public CountryDescriptorDelete() { }

        public CountryDescriptorDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.Courses
{ 
    public class CourseGetByKey
    {
        public string Code { get; set; }
        public int EducationOrganizationId { get; set; }
    }

    public class CourseGetByExample
    {
        public string AcademicSubjectDescriptor { get; set; }
        public string CareerPathwayType { get; set; }
        public string Code { get; set; }
        public string DefinedByType { get; set; }
        public string Description { get; set; }
        public string GPAApplicabilityType { get; set; }
        public string Title { get; set; }
        public DateTime DateCourseAdopted { get; set; }
        public int EducationOrganizationId { get; set; }
        public bool HighSchoolCourseRequirement { get; set; }
        public Guid Id { get; set; }
        public decimal MaximumAvailableCreditConversion { get; set; }
        public decimal MaximumAvailableCredits { get; set; }
        public string MaximumAvailableCreditType { get; set; }
        public decimal MinimumAvailableCreditConversion { get; set; }
        public decimal MinimumAvailableCredits { get; set; }
        public string MinimumAvailableCreditType { get; set; }
        public int NumberOfParts { get; set; }
        public int TimeRequiredForCompletion { get; set; }
    }

    public class CourseGetByIds : IHasIdentifiers<Guid>
    {
        public CourseGetByIds() { }

        public CourseGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class CoursePost : EdFi.Ods.Api.Models.Resources.V2.Course.Course
    {
    }

    public class CoursePut : EdFi.Ods.Api.Models.Resources.V2.Course.Course
    { 
    }

    public class CourseDelete : IHasIdentifier 
    {
        public CourseDelete() { }

        public CourseDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.CourseAttemptResultTypes
{ 
    public class CourseAttemptResultTypeGetByKey
    {
        public int CourseAttemptResultTypeId { get; set; }
    }

    public class CourseAttemptResultTypeGetByExample
    {
        public string CodeValue { get; set; }
        public int CourseAttemptResultTypeId { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
    }

    public class CourseAttemptResultTypeGetByIds : IHasIdentifiers<Guid>
    {
        public CourseAttemptResultTypeGetByIds() { }

        public CourseAttemptResultTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class CourseAttemptResultTypePost : EdFi.Ods.Api.Models.Resources.V2.CourseAttemptResultType.CourseAttemptResultType
    {
    }

    public class CourseAttemptResultTypePut : EdFi.Ods.Api.Models.Resources.V2.CourseAttemptResultType.CourseAttemptResultType
    { 
    }

    public class CourseAttemptResultTypeDelete : IHasIdentifier 
    {
        public CourseAttemptResultTypeDelete() { }

        public CourseAttemptResultTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.CourseDefinedByTypes
{ 
    public class CourseDefinedByTypeGetByKey
    {
        public int CourseDefinedByTypeId { get; set; }
    }

    public class CourseDefinedByTypeGetByExample
    {
        public string CodeValue { get; set; }
        public int CourseDefinedByTypeId { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
    }

    public class CourseDefinedByTypeGetByIds : IHasIdentifiers<Guid>
    {
        public CourseDefinedByTypeGetByIds() { }

        public CourseDefinedByTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class CourseDefinedByTypePost : EdFi.Ods.Api.Models.Resources.V2.CourseDefinedByType.CourseDefinedByType
    {
    }

    public class CourseDefinedByTypePut : EdFi.Ods.Api.Models.Resources.V2.CourseDefinedByType.CourseDefinedByType
    { 
    }

    public class CourseDefinedByTypeDelete : IHasIdentifier 
    {
        public CourseDefinedByTypeDelete() { }

        public CourseDefinedByTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.CourseGPAApplicabilityTypes
{ 
    public class CourseGPAApplicabilityTypeGetByKey
    {
        public int CourseGPAApplicabilityTypeId { get; set; }
    }

    public class CourseGPAApplicabilityTypeGetByExample
    {
        public string CodeValue { get; set; }
        public int CourseGPAApplicabilityTypeId { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
    }

    public class CourseGPAApplicabilityTypeGetByIds : IHasIdentifiers<Guid>
    {
        public CourseGPAApplicabilityTypeGetByIds() { }

        public CourseGPAApplicabilityTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class CourseGPAApplicabilityTypePost : EdFi.Ods.Api.Models.Resources.V2.CourseGPAApplicabilityType.CourseGPAApplicabilityType
    {
    }

    public class CourseGPAApplicabilityTypePut : EdFi.Ods.Api.Models.Resources.V2.CourseGPAApplicabilityType.CourseGPAApplicabilityType
    { 
    }

    public class CourseGPAApplicabilityTypeDelete : IHasIdentifier 
    {
        public CourseGPAApplicabilityTypeDelete() { }

        public CourseGPAApplicabilityTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.CourseIdentificationSystemDescriptors
{ 
    public class CourseIdentificationSystemDescriptorGetByKey
    {
        public int CourseIdentificationSystemDescriptorId { get; set; }
    }

    public class CourseIdentificationSystemDescriptorGetByExample
    {
        public int CourseIdentificationSystemDescriptorId { get; set; }
        public string CourseIdentificationSystemType { get; set; }
    }

    public class CourseIdentificationSystemDescriptorGetByIds : IHasIdentifiers<Guid>
    {
        public CourseIdentificationSystemDescriptorGetByIds() { }

        public CourseIdentificationSystemDescriptorGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class CourseIdentificationSystemDescriptorPost : EdFi.Ods.Api.Models.Resources.V2.CourseIdentificationSystemDescriptor.CourseIdentificationSystemDescriptor
    {
    }

    public class CourseIdentificationSystemDescriptorPut : EdFi.Ods.Api.Models.Resources.V2.CourseIdentificationSystemDescriptor.CourseIdentificationSystemDescriptor
    { 
    }

    public class CourseIdentificationSystemDescriptorDelete : IHasIdentifier 
    {
        public CourseIdentificationSystemDescriptorDelete() { }

        public CourseIdentificationSystemDescriptorDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.CourseIdentificationSystemTypes
{ 
    public class CourseIdentificationSystemTypeGetByKey
    {
        public int CourseIdentificationSystemTypeId { get; set; }
    }

    public class CourseIdentificationSystemTypeGetByExample
    {
        public string CodeValue { get; set; }
        public int CourseIdentificationSystemTypeId { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
    }

    public class CourseIdentificationSystemTypeGetByIds : IHasIdentifiers<Guid>
    {
        public CourseIdentificationSystemTypeGetByIds() { }

        public CourseIdentificationSystemTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class CourseIdentificationSystemTypePost : EdFi.Ods.Api.Models.Resources.V2.CourseIdentificationSystemType.CourseIdentificationSystemType
    {
    }

    public class CourseIdentificationSystemTypePut : EdFi.Ods.Api.Models.Resources.V2.CourseIdentificationSystemType.CourseIdentificationSystemType
    { 
    }

    public class CourseIdentificationSystemTypeDelete : IHasIdentifier 
    {
        public CourseIdentificationSystemTypeDelete() { }

        public CourseIdentificationSystemTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.CourseLevelCharacteristicTypes
{ 
    public class CourseLevelCharacteristicTypeGetByKey
    {
        public int CourseLevelCharacteristicTypeId { get; set; }
    }

    public class CourseLevelCharacteristicTypeGetByExample
    {
        public string CodeValue { get; set; }
        public int CourseLevelCharacteristicTypeId { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
    }

    public class CourseLevelCharacteristicTypeGetByIds : IHasIdentifiers<Guid>
    {
        public CourseLevelCharacteristicTypeGetByIds() { }

        public CourseLevelCharacteristicTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class CourseLevelCharacteristicTypePost : EdFi.Ods.Api.Models.Resources.V2.CourseLevelCharacteristicType.CourseLevelCharacteristicType
    {
    }

    public class CourseLevelCharacteristicTypePut : EdFi.Ods.Api.Models.Resources.V2.CourseLevelCharacteristicType.CourseLevelCharacteristicType
    { 
    }

    public class CourseLevelCharacteristicTypeDelete : IHasIdentifier 
    {
        public CourseLevelCharacteristicTypeDelete() { }

        public CourseLevelCharacteristicTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.CourseOfferings
{ 
    public class CourseOfferingGetByKey
    {
        public string LocalCourseCode { get; set; }
        public int SchoolId { get; set; }
        public short SchoolYear { get; set; }
        public string TermDescriptor { get; set; }
    }

    public class CourseOfferingGetByExample
    {
        public string CourseCode { get; set; }
        public int EducationOrganizationId { get; set; }
        public Guid Id { get; set; }
        public int InstructionalTimePlanned { get; set; }
        public string LocalCourseCode { get; set; }
        public string LocalCourseTitle { get; set; }
        public int SchoolId { get; set; }
        public short SchoolYear { get; set; }
        public string TermDescriptor { get; set; }
    }

    public class CourseOfferingGetByIds : IHasIdentifiers<Guid>
    {
        public CourseOfferingGetByIds() { }

        public CourseOfferingGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class CourseOfferingPost : EdFi.Ods.Api.Models.Resources.V2.CourseOffering.CourseOffering
    {
    }

    public class CourseOfferingPut : EdFi.Ods.Api.Models.Resources.V2.CourseOffering.CourseOffering
    { 
    }

    public class CourseOfferingDelete : IHasIdentifier 
    {
        public CourseOfferingDelete() { }

        public CourseOfferingDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.CourseRepeatCodeTypes
{ 
    public class CourseRepeatCodeTypeGetByKey
    {
        public int CourseRepeatCodeTypeId { get; set; }
    }

    public class CourseRepeatCodeTypeGetByExample
    {
        public string CodeValue { get; set; }
        public int CourseRepeatCodeTypeId { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
    }

    public class CourseRepeatCodeTypeGetByIds : IHasIdentifiers<Guid>
    {
        public CourseRepeatCodeTypeGetByIds() { }

        public CourseRepeatCodeTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class CourseRepeatCodeTypePost : EdFi.Ods.Api.Models.Resources.V2.CourseRepeatCodeType.CourseRepeatCodeType
    {
    }

    public class CourseRepeatCodeTypePut : EdFi.Ods.Api.Models.Resources.V2.CourseRepeatCodeType.CourseRepeatCodeType
    { 
    }

    public class CourseRepeatCodeTypeDelete : IHasIdentifier 
    {
        public CourseRepeatCodeTypeDelete() { }

        public CourseRepeatCodeTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.CourseTranscripts
{ 
    public class CourseTranscriptGetByKey
    {
        public string CourseAttemptResultType { get; set; }
        public string CourseCode { get; set; }
        public int CourseEducationOrganizationId { get; set; }
        public int EducationOrganizationId { get; set; }
        public short SchoolYear { get; set; }
        public string StudentUniqueId { get; set; }
        public string TermDescriptor { get; set; }
    }

    public class CourseTranscriptGetByExample
    {
        public string AlternativeCourseCode { get; set; }
        public string AlternativeCourseTitle { get; set; }
        public decimal AttemptedCreditConversion { get; set; }
        public decimal AttemptedCredits { get; set; }
        public string AttemptedCreditType { get; set; }
        public string CourseAttemptResultType { get; set; }
        public string CourseCode { get; set; }
        public int CourseEducationOrganizationId { get; set; }
        public string CourseRepeatCodeType { get; set; }
        public string CourseTitle { get; set; }
        public decimal EarnedCreditConversion { get; set; }
        public decimal EarnedCredits { get; set; }
        public string EarnedCreditType { get; set; }
        public int EducationOrganizationId { get; set; }
        public string FinalLetterGradeEarned { get; set; }
        public decimal FinalNumericGradeEarned { get; set; }
        public Guid Id { get; set; }
        public string MethodCreditEarnedType { get; set; }
        public int SchoolId { get; set; }
        public short SchoolYear { get; set; }
        public string StudentUniqueId { get; set; }
        public string TermDescriptor { get; set; }
        public string WhenTakenGradeLevelDescriptor { get; set; }
    }

    public class CourseTranscriptGetByIds : IHasIdentifiers<Guid>
    {
        public CourseTranscriptGetByIds() { }

        public CourseTranscriptGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class CourseTranscriptPost : EdFi.Ods.Api.Models.Resources.V2.CourseTranscript.CourseTranscript
    {
    }

    public class CourseTranscriptPut : EdFi.Ods.Api.Models.Resources.V2.CourseTranscript.CourseTranscript
    { 
    }

    public class CourseTranscriptDelete : IHasIdentifier 
    {
        public CourseTranscriptDelete() { }

        public CourseTranscriptDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.CredentialFieldDescriptors
{ 
    public class CredentialFieldDescriptorGetByKey
    {
        public int CredentialFieldDescriptorId { get; set; }
    }

    public class CredentialFieldDescriptorGetByExample
    {
        public string AcademicSubjectDescriptor { get; set; }
        public int CredentialFieldDescriptorId { get; set; }
    }

    public class CredentialFieldDescriptorGetByIds : IHasIdentifiers<Guid>
    {
        public CredentialFieldDescriptorGetByIds() { }

        public CredentialFieldDescriptorGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class CredentialFieldDescriptorPost : EdFi.Ods.Api.Models.Resources.V2.CredentialFieldDescriptor.CredentialFieldDescriptor
    {
    }

    public class CredentialFieldDescriptorPut : EdFi.Ods.Api.Models.Resources.V2.CredentialFieldDescriptor.CredentialFieldDescriptor
    { 
    }

    public class CredentialFieldDescriptorDelete : IHasIdentifier 
    {
        public CredentialFieldDescriptorDelete() { }

        public CredentialFieldDescriptorDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.CredentialTypes
{ 
    public class CredentialTypeGetByKey
    {
        public int CredentialTypeId { get; set; }
    }

    public class CredentialTypeGetByExample
    {
        public string CodeValue { get; set; }
        public int CredentialTypeId { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
    }

    public class CredentialTypeGetByIds : IHasIdentifiers<Guid>
    {
        public CredentialTypeGetByIds() { }

        public CredentialTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class CredentialTypePost : EdFi.Ods.Api.Models.Resources.V2.CredentialType.CredentialType
    {
    }

    public class CredentialTypePut : EdFi.Ods.Api.Models.Resources.V2.CredentialType.CredentialType
    { 
    }

    public class CredentialTypeDelete : IHasIdentifier 
    {
        public CredentialTypeDelete() { }

        public CredentialTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.CreditTypes
{ 
    public class CreditTypeGetByKey
    {
        public int CreditTypeId { get; set; }
    }

    public class CreditTypeGetByExample
    {
        public string CodeValue { get; set; }
        public int CreditTypeId { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
    }

    public class CreditTypeGetByIds : IHasIdentifiers<Guid>
    {
        public CreditTypeGetByIds() { }

        public CreditTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class CreditTypePost : EdFi.Ods.Api.Models.Resources.V2.CreditType.CreditType
    {
    }

    public class CreditTypePut : EdFi.Ods.Api.Models.Resources.V2.CreditType.CreditType
    { 
    }

    public class CreditTypeDelete : IHasIdentifier 
    {
        public CreditTypeDelete() { }

        public CreditTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.CurriculumUsedTypes
{ 
    public class CurriculumUsedTypeGetByKey
    {
        public int CurriculumUsedTypeId { get; set; }
    }

    public class CurriculumUsedTypeGetByExample
    {
        public string CodeValue { get; set; }
        public int CurriculumUsedTypeId { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
    }

    public class CurriculumUsedTypeGetByIds : IHasIdentifiers<Guid>
    {
        public CurriculumUsedTypeGetByIds() { }

        public CurriculumUsedTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class CurriculumUsedTypePost : EdFi.Ods.Api.Models.Resources.V2.CurriculumUsedType.CurriculumUsedType
    {
    }

    public class CurriculumUsedTypePut : EdFi.Ods.Api.Models.Resources.V2.CurriculumUsedType.CurriculumUsedType
    { 
    }

    public class CurriculumUsedTypeDelete : IHasIdentifier 
    {
        public CurriculumUsedTypeDelete() { }

        public CurriculumUsedTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.DeliveryMethodTypes
{ 
    public class DeliveryMethodTypeGetByKey
    {
        public int DeliveryMethodTypeId { get; set; }
    }

    public class DeliveryMethodTypeGetByExample
    {
        public string CodeValue { get; set; }
        public int DeliveryMethodTypeId { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
    }

    public class DeliveryMethodTypeGetByIds : IHasIdentifiers<Guid>
    {
        public DeliveryMethodTypeGetByIds() { }

        public DeliveryMethodTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class DeliveryMethodTypePost : EdFi.Ods.Api.Models.Resources.V2.DeliveryMethodType.DeliveryMethodType
    {
    }

    public class DeliveryMethodTypePut : EdFi.Ods.Api.Models.Resources.V2.DeliveryMethodType.DeliveryMethodType
    { 
    }

    public class DeliveryMethodTypeDelete : IHasIdentifier 
    {
        public DeliveryMethodTypeDelete() { }

        public DeliveryMethodTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.DiagnosisDescriptors
{ 
    public class DiagnosisDescriptorGetByKey
    {
        public int DiagnosisDescriptorId { get; set; }
    }

    public class DiagnosisDescriptorGetByExample
    {
        public int DiagnosisDescriptorId { get; set; }
        public string DiagnosisType { get; set; }
    }

    public class DiagnosisDescriptorGetByIds : IHasIdentifiers<Guid>
    {
        public DiagnosisDescriptorGetByIds() { }

        public DiagnosisDescriptorGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class DiagnosisDescriptorPost : EdFi.Ods.Api.Models.Resources.V2.DiagnosisDescriptor.DiagnosisDescriptor
    {
    }

    public class DiagnosisDescriptorPut : EdFi.Ods.Api.Models.Resources.V2.DiagnosisDescriptor.DiagnosisDescriptor
    { 
    }

    public class DiagnosisDescriptorDelete : IHasIdentifier 
    {
        public DiagnosisDescriptorDelete() { }

        public DiagnosisDescriptorDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.DiagnosisTypes
{ 
    public class DiagnosisTypeGetByKey
    {
        public int DiagnosisTypeId { get; set; }
    }

    public class DiagnosisTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public int DiagnosisTypeId { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
    }

    public class DiagnosisTypeGetByIds : IHasIdentifiers<Guid>
    {
        public DiagnosisTypeGetByIds() { }

        public DiagnosisTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class DiagnosisTypePost : EdFi.Ods.Api.Models.Resources.V2.DiagnosisType.DiagnosisType
    {
    }

    public class DiagnosisTypePut : EdFi.Ods.Api.Models.Resources.V2.DiagnosisType.DiagnosisType
    { 
    }

    public class DiagnosisTypeDelete : IHasIdentifier 
    {
        public DiagnosisTypeDelete() { }

        public DiagnosisTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.DiplomaLevelTypes
{ 
    public class DiplomaLevelTypeGetByKey
    {
        public int DiplomaLevelTypeId { get; set; }
    }

    public class DiplomaLevelTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public int DiplomaLevelTypeId { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
    }

    public class DiplomaLevelTypeGetByIds : IHasIdentifiers<Guid>
    {
        public DiplomaLevelTypeGetByIds() { }

        public DiplomaLevelTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class DiplomaLevelTypePost : EdFi.Ods.Api.Models.Resources.V2.DiplomaLevelType.DiplomaLevelType
    {
    }

    public class DiplomaLevelTypePut : EdFi.Ods.Api.Models.Resources.V2.DiplomaLevelType.DiplomaLevelType
    { 
    }

    public class DiplomaLevelTypeDelete : IHasIdentifier 
    {
        public DiplomaLevelTypeDelete() { }

        public DiplomaLevelTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.DiplomaTypes
{ 
    public class DiplomaTypeGetByKey
    {
        public int DiplomaTypeId { get; set; }
    }

    public class DiplomaTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public int DiplomaTypeId { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
    }

    public class DiplomaTypeGetByIds : IHasIdentifiers<Guid>
    {
        public DiplomaTypeGetByIds() { }

        public DiplomaTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class DiplomaTypePost : EdFi.Ods.Api.Models.Resources.V2.DiplomaType.DiplomaType
    {
    }

    public class DiplomaTypePut : EdFi.Ods.Api.Models.Resources.V2.DiplomaType.DiplomaType
    { 
    }

    public class DiplomaTypeDelete : IHasIdentifier 
    {
        public DiplomaTypeDelete() { }

        public DiplomaTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.DisabilityCategoryTypes
{ 
    public class DisabilityCategoryTypeGetByKey
    {
        public int DisabilityCategoryTypeId { get; set; }
    }

    public class DisabilityCategoryTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public int DisabilityCategoryTypeId { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
    }

    public class DisabilityCategoryTypeGetByIds : IHasIdentifiers<Guid>
    {
        public DisabilityCategoryTypeGetByIds() { }

        public DisabilityCategoryTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class DisabilityCategoryTypePost : EdFi.Ods.Api.Models.Resources.V2.DisabilityCategoryType.DisabilityCategoryType
    {
    }

    public class DisabilityCategoryTypePut : EdFi.Ods.Api.Models.Resources.V2.DisabilityCategoryType.DisabilityCategoryType
    { 
    }

    public class DisabilityCategoryTypeDelete : IHasIdentifier 
    {
        public DisabilityCategoryTypeDelete() { }

        public DisabilityCategoryTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.DisabilityDescriptors
{ 
    public class DisabilityDescriptorGetByKey
    {
        public int DisabilityDescriptorId { get; set; }
    }

    public class DisabilityDescriptorGetByExample
    {
        public string DisabilityCategoryType { get; set; }
        public int DisabilityDescriptorId { get; set; }
        public string DisabilityType { get; set; }
    }

    public class DisabilityDescriptorGetByIds : IHasIdentifiers<Guid>
    {
        public DisabilityDescriptorGetByIds() { }

        public DisabilityDescriptorGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class DisabilityDescriptorPost : EdFi.Ods.Api.Models.Resources.V2.DisabilityDescriptor.DisabilityDescriptor
    {
    }

    public class DisabilityDescriptorPut : EdFi.Ods.Api.Models.Resources.V2.DisabilityDescriptor.DisabilityDescriptor
    { 
    }

    public class DisabilityDescriptorDelete : IHasIdentifier 
    {
        public DisabilityDescriptorDelete() { }

        public DisabilityDescriptorDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.DisabilityDeterminationSourceTypes
{ 
    public class DisabilityDeterminationSourceTypeGetByKey
    {
        public int DisabilityDeterminationSourceTypeId { get; set; }
    }

    public class DisabilityDeterminationSourceTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public int DisabilityDeterminationSourceTypeId { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
    }

    public class DisabilityDeterminationSourceTypeGetByIds : IHasIdentifiers<Guid>
    {
        public DisabilityDeterminationSourceTypeGetByIds() { }

        public DisabilityDeterminationSourceTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class DisabilityDeterminationSourceTypePost : EdFi.Ods.Api.Models.Resources.V2.DisabilityDeterminationSourceType.DisabilityDeterminationSourceType
    {
    }

    public class DisabilityDeterminationSourceTypePut : EdFi.Ods.Api.Models.Resources.V2.DisabilityDeterminationSourceType.DisabilityDeterminationSourceType
    { 
    }

    public class DisabilityDeterminationSourceTypeDelete : IHasIdentifier 
    {
        public DisabilityDeterminationSourceTypeDelete() { }

        public DisabilityDeterminationSourceTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.DisabilityTypes
{ 
    public class DisabilityTypeGetByKey
    {
        public int DisabilityTypeId { get; set; }
    }

    public class DisabilityTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public int DisabilityTypeId { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
    }

    public class DisabilityTypeGetByIds : IHasIdentifiers<Guid>
    {
        public DisabilityTypeGetByIds() { }

        public DisabilityTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class DisabilityTypePost : EdFi.Ods.Api.Models.Resources.V2.DisabilityType.DisabilityType
    {
    }

    public class DisabilityTypePut : EdFi.Ods.Api.Models.Resources.V2.DisabilityType.DisabilityType
    { 
    }

    public class DisabilityTypeDelete : IHasIdentifier 
    {
        public DisabilityTypeDelete() { }

        public DisabilityTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.DisciplineActions
{ 
    public class DisciplineActionGetByKey
    {
        public string Identifier { get; set; }
        public DateTime DisciplineDate { get; set; }
        public string StudentUniqueId { get; set; }
    }

    public class DisciplineActionGetByExample
    {
        public int ActualDisciplineActionLength { get; set; }
        public int AssignmentSchoolId { get; set; }
        public string Identifier { get; set; }
        public int Length { get; set; }
        public string LengthDifferenceReasonType { get; set; }
        public DateTime DisciplineDate { get; set; }
        public Guid Id { get; set; }
        public bool RelatedToZeroTolerancePolicy { get; set; }
        public int ResponsibilitySchoolId { get; set; }
        public string StudentUniqueId { get; set; }
    }

    public class DisciplineActionGetByIds : IHasIdentifiers<Guid>
    {
        public DisciplineActionGetByIds() { }

        public DisciplineActionGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class DisciplineActionPost : EdFi.Ods.Api.Models.Resources.V2.DisciplineAction.DisciplineAction
    {
    }

    public class DisciplineActionPut : EdFi.Ods.Api.Models.Resources.V2.DisciplineAction.DisciplineAction
    { 
    }

    public class DisciplineActionDelete : IHasIdentifier 
    {
        public DisciplineActionDelete() { }

        public DisciplineActionDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.DisciplineActionLengthDifferenceReasonTypes
{ 
    public class DisciplineActionLengthDifferenceReasonTypeGetByKey
    {
        public int DisciplineActionLengthDifferenceReasonTypeId { get; set; }
    }

    public class DisciplineActionLengthDifferenceReasonTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public int DisciplineActionLengthDifferenceReasonTypeId { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
    }

    public class DisciplineActionLengthDifferenceReasonTypeGetByIds : IHasIdentifiers<Guid>
    {
        public DisciplineActionLengthDifferenceReasonTypeGetByIds() { }

        public DisciplineActionLengthDifferenceReasonTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class DisciplineActionLengthDifferenceReasonTypePost : EdFi.Ods.Api.Models.Resources.V2.DisciplineActionLengthDifferenceReasonType.DisciplineActionLengthDifferenceReasonType
    {
    }

    public class DisciplineActionLengthDifferenceReasonTypePut : EdFi.Ods.Api.Models.Resources.V2.DisciplineActionLengthDifferenceReasonType.DisciplineActionLengthDifferenceReasonType
    { 
    }

    public class DisciplineActionLengthDifferenceReasonTypeDelete : IHasIdentifier 
    {
        public DisciplineActionLengthDifferenceReasonTypeDelete() { }

        public DisciplineActionLengthDifferenceReasonTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.DisciplineDescriptors
{ 
    public class DisciplineDescriptorGetByKey
    {
        public int DisciplineDescriptorId { get; set; }
    }

    public class DisciplineDescriptorGetByExample
    {
        public int DisciplineDescriptorId { get; set; }
        public string DisciplineType { get; set; }
    }

    public class DisciplineDescriptorGetByIds : IHasIdentifiers<Guid>
    {
        public DisciplineDescriptorGetByIds() { }

        public DisciplineDescriptorGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class DisciplineDescriptorPost : EdFi.Ods.Api.Models.Resources.V2.DisciplineDescriptor.DisciplineDescriptor
    {
    }

    public class DisciplineDescriptorPut : EdFi.Ods.Api.Models.Resources.V2.DisciplineDescriptor.DisciplineDescriptor
    { 
    }

    public class DisciplineDescriptorDelete : IHasIdentifier 
    {
        public DisciplineDescriptorDelete() { }

        public DisciplineDescriptorDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.DisciplineIncidents
{ 
    public class DisciplineIncidentGetByKey
    {
        public string IncidentIdentifier { get; set; }
        public int SchoolId { get; set; }
    }

    public class DisciplineIncidentGetByExample
    {
        public string CaseNumber { get; set; }
        public Guid Id { get; set; }
        public decimal IncidentCost { get; set; }
        public DateTime IncidentDate { get; set; }
        public string IncidentDescription { get; set; }
        public string IncidentIdentifier { get; set; }
        public string IncidentLocationType { get; set; }
        public TimeSpan IncidentTime { get; set; }
        public bool ReportedToLawEnforcement { get; set; }
        public string ReporterDescriptionDescriptor { get; set; }
        public string ReporterName { get; set; }
        public int SchoolId { get; set; }
        public string StaffUniqueId { get; set; }
    }

    public class DisciplineIncidentGetByIds : IHasIdentifiers<Guid>
    {
        public DisciplineIncidentGetByIds() { }

        public DisciplineIncidentGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class DisciplineIncidentPost : EdFi.Ods.Api.Models.Resources.V2.DisciplineIncident.DisciplineIncident
    {
    }

    public class DisciplineIncidentPut : EdFi.Ods.Api.Models.Resources.V2.DisciplineIncident.DisciplineIncident
    { 
    }

    public class DisciplineIncidentDelete : IHasIdentifier 
    {
        public DisciplineIncidentDelete() { }

        public DisciplineIncidentDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.DisciplineTypes
{ 
    public class DisciplineTypeGetByKey
    {
        public int DisciplineTypeId { get; set; }
    }

    public class DisciplineTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public int DisciplineTypeId { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
    }

    public class DisciplineTypeGetByIds : IHasIdentifiers<Guid>
    {
        public DisciplineTypeGetByIds() { }

        public DisciplineTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class DisciplineTypePost : EdFi.Ods.Api.Models.Resources.V2.DisciplineType.DisciplineType
    {
    }

    public class DisciplineTypePut : EdFi.Ods.Api.Models.Resources.V2.DisciplineType.DisciplineType
    { 
    }

    public class DisciplineTypeDelete : IHasIdentifier 
    {
        public DisciplineTypeDelete() { }

        public DisciplineTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.EducationalEnvironmentTypes
{ 
    public class EducationalEnvironmentTypeGetByKey
    {
        public int EducationalEnvironmentTypeId { get; set; }
    }

    public class EducationalEnvironmentTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public int EducationalEnvironmentTypeId { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
    }

    public class EducationalEnvironmentTypeGetByIds : IHasIdentifiers<Guid>
    {
        public EducationalEnvironmentTypeGetByIds() { }

        public EducationalEnvironmentTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class EducationalEnvironmentTypePost : EdFi.Ods.Api.Models.Resources.V2.EducationalEnvironmentType.EducationalEnvironmentType
    {
    }

    public class EducationalEnvironmentTypePut : EdFi.Ods.Api.Models.Resources.V2.EducationalEnvironmentType.EducationalEnvironmentType
    { 
    }

    public class EducationalEnvironmentTypeDelete : IHasIdentifier 
    {
        public EducationalEnvironmentTypeDelete() { }

        public EducationalEnvironmentTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.EducationContents
{ 
    public class EducationContentGetByKey
    {
        public string ContentIdentifier { get; set; }
    }

    public class EducationContentGetByExample
    {
        public bool AdditionalAuthorsIndicator { get; set; }
        public string ContentClassType { get; set; }
        public string ContentIdentifier { get; set; }
        public decimal Cost { get; set; }
        public string CostRateType { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public string InteractivityStyleType { get; set; }
        public string LearningResourceMetadataURI { get; set; }
        public string LearningStandardId { get; set; }
        public string Namespace { get; set; }
        public DateTime PublicationDate { get; set; }
        public short PublicationYear { get; set; }
        public string Publisher { get; set; }
        public string ShortDescription { get; set; }
        public string TimeRequired { get; set; }
        public string UseRightsURL { get; set; }
        public string Version { get; set; }
    }

    public class EducationContentGetByIds : IHasIdentifiers<Guid>
    {
        public EducationContentGetByIds() { }

        public EducationContentGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class EducationContentPost : EdFi.Ods.Api.Models.Resources.V2.EducationContent.EducationContent
    {
    }

    public class EducationContentPut : EdFi.Ods.Api.Models.Resources.V2.EducationContent.EducationContent
    { 
    }

    public class EducationContentDelete : IHasIdentifier 
    {
        public EducationContentDelete() { }

        public EducationContentDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.EducationOrganizationCategoryTypes
{ 
    public class EducationOrganizationCategoryTypeGetByKey
    {
        public int EducationOrganizationCategoryTypeId { get; set; }
    }

    public class EducationOrganizationCategoryTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public int EducationOrganizationCategoryTypeId { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
    }

    public class EducationOrganizationCategoryTypeGetByIds : IHasIdentifiers<Guid>
    {
        public EducationOrganizationCategoryTypeGetByIds() { }

        public EducationOrganizationCategoryTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class EducationOrganizationCategoryTypePost : EdFi.Ods.Api.Models.Resources.V2.EducationOrganizationCategoryType.EducationOrganizationCategoryType
    {
    }

    public class EducationOrganizationCategoryTypePut : EdFi.Ods.Api.Models.Resources.V2.EducationOrganizationCategoryType.EducationOrganizationCategoryType
    { 
    }

    public class EducationOrganizationCategoryTypeDelete : IHasIdentifier 
    {
        public EducationOrganizationCategoryTypeDelete() { }

        public EducationOrganizationCategoryTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.EducationOrganizationIdentificationSystemDescriptors
{ 
    public class EducationOrganizationIdentificationSystemDescriptorGetByKey
    {
        public int EducationOrganizationIdentificationSystemDescriptorId { get; set; }
    }

    public class EducationOrganizationIdentificationSystemDescriptorGetByExample
    {
        public int EducationOrganizationIdentificationSystemDescriptorId { get; set; }
        public string EducationOrganizationIdentificationSystemType { get; set; }
    }

    public class EducationOrganizationIdentificationSystemDescriptorGetByIds : IHasIdentifiers<Guid>
    {
        public EducationOrganizationIdentificationSystemDescriptorGetByIds() { }

        public EducationOrganizationIdentificationSystemDescriptorGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class EducationOrganizationIdentificationSystemDescriptorPost : EdFi.Ods.Api.Models.Resources.V2.EducationOrganizationIdentificationSystemDescriptor.EducationOrganizationIdentificationSystemDescriptor
    {
    }

    public class EducationOrganizationIdentificationSystemDescriptorPut : EdFi.Ods.Api.Models.Resources.V2.EducationOrganizationIdentificationSystemDescriptor.EducationOrganizationIdentificationSystemDescriptor
    { 
    }

    public class EducationOrganizationIdentificationSystemDescriptorDelete : IHasIdentifier 
    {
        public EducationOrganizationIdentificationSystemDescriptorDelete() { }

        public EducationOrganizationIdentificationSystemDescriptorDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.EducationOrganizationIdentificationSystemTypes
{ 
    public class EducationOrganizationIdentificationSystemTypeGetByKey
    {
        public int EducationOrganizationIdentificationSystemTypeId { get; set; }
    }

    public class EducationOrganizationIdentificationSystemTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public int EducationOrganizationIdentificationSystemTypeId { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
    }

    public class EducationOrganizationIdentificationSystemTypeGetByIds : IHasIdentifiers<Guid>
    {
        public EducationOrganizationIdentificationSystemTypeGetByIds() { }

        public EducationOrganizationIdentificationSystemTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class EducationOrganizationIdentificationSystemTypePost : EdFi.Ods.Api.Models.Resources.V2.EducationOrganizationIdentificationSystemType.EducationOrganizationIdentificationSystemType
    {
    }

    public class EducationOrganizationIdentificationSystemTypePut : EdFi.Ods.Api.Models.Resources.V2.EducationOrganizationIdentificationSystemType.EducationOrganizationIdentificationSystemType
    { 
    }

    public class EducationOrganizationIdentificationSystemTypeDelete : IHasIdentifier 
    {
        public EducationOrganizationIdentificationSystemTypeDelete() { }

        public EducationOrganizationIdentificationSystemTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.EducationOrganizationInterventionPrescriptionAssociations
{ 
    public class EducationOrganizationInterventionPrescriptionAssociationGetByKey
    {
        public int EducationOrganizationId { get; set; }
        public int InterventionPrescriptionEducationOrganizationId { get; set; }
        public string InterventionPrescriptionIdentificationCode { get; set; }
    }

    public class EducationOrganizationInterventionPrescriptionAssociationGetByExample
    {
        public DateTime BeginDate { get; set; }
        public int EducationOrganizationId { get; set; }
        public DateTime EndDate { get; set; }
        public Guid Id { get; set; }
        public int InterventionPrescriptionEducationOrganizationId { get; set; }
        public string InterventionPrescriptionIdentificationCode { get; set; }
    }

    public class EducationOrganizationInterventionPrescriptionAssociationGetByIds : IHasIdentifiers<Guid>
    {
        public EducationOrganizationInterventionPrescriptionAssociationGetByIds() { }

        public EducationOrganizationInterventionPrescriptionAssociationGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class EducationOrganizationInterventionPrescriptionAssociationPost : EdFi.Ods.Api.Models.Resources.V2.EducationOrganizationInterventionPrescriptionAssociation.EducationOrganizationInterventionPrescriptionAssociation
    {
    }

    public class EducationOrganizationInterventionPrescriptionAssociationPut : EdFi.Ods.Api.Models.Resources.V2.EducationOrganizationInterventionPrescriptionAssociation.EducationOrganizationInterventionPrescriptionAssociation
    { 
    }

    public class EducationOrganizationInterventionPrescriptionAssociationDelete : IHasIdentifier 
    {
        public EducationOrganizationInterventionPrescriptionAssociationDelete() { }

        public EducationOrganizationInterventionPrescriptionAssociationDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.EducationOrganizationNetworks
{ 
    public class EducationOrganizationNetworkGetByKey
    {
        public int EducationOrganizationNetworkId { get; set; }
    }

    public class EducationOrganizationNetworkGetByExample
    {
        public int EducationOrganizationNetworkId { get; set; }
        public string NetworkPurposeType { get; set; }
    }

    public class EducationOrganizationNetworkGetByIds : IHasIdentifiers<Guid>
    {
        public EducationOrganizationNetworkGetByIds() { }

        public EducationOrganizationNetworkGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class EducationOrganizationNetworkPost : EdFi.Ods.Api.Models.Resources.V2.EducationOrganizationNetwork.EducationOrganizationNetwork
    {
    }

    public class EducationOrganizationNetworkPut : EdFi.Ods.Api.Models.Resources.V2.EducationOrganizationNetwork.EducationOrganizationNetwork
    { 
    }

    public class EducationOrganizationNetworkDelete : IHasIdentifier 
    {
        public EducationOrganizationNetworkDelete() { }

        public EducationOrganizationNetworkDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.EducationOrganizationNetworkAssociations
{ 
    public class EducationOrganizationNetworkAssociationGetByKey
    {
        public int EducationOrganizationNetworkId { get; set; }
        public int MemberEducationOrganizationId { get; set; }
    }

    public class EducationOrganizationNetworkAssociationGetByExample
    {
        public DateTime BeginDate { get; set; }
        public int EducationOrganizationNetworkId { get; set; }
        public DateTime EndDate { get; set; }
        public Guid Id { get; set; }
        public int MemberEducationOrganizationId { get; set; }
    }

    public class EducationOrganizationNetworkAssociationGetByIds : IHasIdentifiers<Guid>
    {
        public EducationOrganizationNetworkAssociationGetByIds() { }

        public EducationOrganizationNetworkAssociationGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class EducationOrganizationNetworkAssociationPost : EdFi.Ods.Api.Models.Resources.V2.EducationOrganizationNetworkAssociation.EducationOrganizationNetworkAssociation
    {
    }

    public class EducationOrganizationNetworkAssociationPut : EdFi.Ods.Api.Models.Resources.V2.EducationOrganizationNetworkAssociation.EducationOrganizationNetworkAssociation
    { 
    }

    public class EducationOrganizationNetworkAssociationDelete : IHasIdentifier 
    {
        public EducationOrganizationNetworkAssociationDelete() { }

        public EducationOrganizationNetworkAssociationDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.EducationOrganizationPeerAssociations
{ 
    public class EducationOrganizationPeerAssociationGetByKey
    {
        public int EducationOrganizationId { get; set; }
        public int PeerEducationOrganizationId { get; set; }
    }

    public class EducationOrganizationPeerAssociationGetByExample
    {
        public int EducationOrganizationId { get; set; }
        public Guid Id { get; set; }
        public int PeerEducationOrganizationId { get; set; }
    }

    public class EducationOrganizationPeerAssociationGetByIds : IHasIdentifiers<Guid>
    {
        public EducationOrganizationPeerAssociationGetByIds() { }

        public EducationOrganizationPeerAssociationGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class EducationOrganizationPeerAssociationPost : EdFi.Ods.Api.Models.Resources.V2.EducationOrganizationPeerAssociation.EducationOrganizationPeerAssociation
    {
    }

    public class EducationOrganizationPeerAssociationPut : EdFi.Ods.Api.Models.Resources.V2.EducationOrganizationPeerAssociation.EducationOrganizationPeerAssociation
    { 
    }

    public class EducationOrganizationPeerAssociationDelete : IHasIdentifier 
    {
        public EducationOrganizationPeerAssociationDelete() { }

        public EducationOrganizationPeerAssociationDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.EducationPlanTypes
{ 
    public class EducationPlanTypeGetByKey
    {
        public int EducationPlanTypeId { get; set; }
    }

    public class EducationPlanTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public int EducationPlanTypeId { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
    }

    public class EducationPlanTypeGetByIds : IHasIdentifiers<Guid>
    {
        public EducationPlanTypeGetByIds() { }

        public EducationPlanTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class EducationPlanTypePost : EdFi.Ods.Api.Models.Resources.V2.EducationPlanType.EducationPlanType
    {
    }

    public class EducationPlanTypePut : EdFi.Ods.Api.Models.Resources.V2.EducationPlanType.EducationPlanType
    { 
    }

    public class EducationPlanTypeDelete : IHasIdentifier 
    {
        public EducationPlanTypeDelete() { }

        public EducationPlanTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.EducationServiceCenters
{ 
    public class EducationServiceCenterGetByKey
    {
        public int EducationServiceCenterId { get; set; }
    }

    public class EducationServiceCenterGetByExample
    {
        public int EducationServiceCenterId { get; set; }
        public int StateEducationAgencyId { get; set; }
    }

    public class EducationServiceCenterGetByIds : IHasIdentifiers<Guid>
    {
        public EducationServiceCenterGetByIds() { }

        public EducationServiceCenterGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class EducationServiceCenterPost : EdFi.Ods.Api.Models.Resources.V2.EducationServiceCenter.EducationServiceCenter
    {
    }

    public class EducationServiceCenterPut : EdFi.Ods.Api.Models.Resources.V2.EducationServiceCenter.EducationServiceCenter
    { 
    }

    public class EducationServiceCenterDelete : IHasIdentifier 
    {
        public EducationServiceCenterDelete() { }

        public EducationServiceCenterDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.ElectronicMailTypes
{ 
    public class ElectronicMailTypeGetByKey
    {
        public int ElectronicMailTypeId { get; set; }
    }

    public class ElectronicMailTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public int ElectronicMailTypeId { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
    }

    public class ElectronicMailTypeGetByIds : IHasIdentifiers<Guid>
    {
        public ElectronicMailTypeGetByIds() { }

        public ElectronicMailTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class ElectronicMailTypePost : EdFi.Ods.Api.Models.Resources.V2.ElectronicMailType.ElectronicMailType
    {
    }

    public class ElectronicMailTypePut : EdFi.Ods.Api.Models.Resources.V2.ElectronicMailType.ElectronicMailType
    { 
    }

    public class ElectronicMailTypeDelete : IHasIdentifier 
    {
        public ElectronicMailTypeDelete() { }

        public ElectronicMailTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.EmploymentStatusDescriptors
{ 
    public class EmploymentStatusDescriptorGetByKey
    {
        public int EmploymentStatusDescriptorId { get; set; }
    }

    public class EmploymentStatusDescriptorGetByExample
    {
        public int EmploymentStatusDescriptorId { get; set; }
        public string EmploymentStatusType { get; set; }
    }

    public class EmploymentStatusDescriptorGetByIds : IHasIdentifiers<Guid>
    {
        public EmploymentStatusDescriptorGetByIds() { }

        public EmploymentStatusDescriptorGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class EmploymentStatusDescriptorPost : EdFi.Ods.Api.Models.Resources.V2.EmploymentStatusDescriptor.EmploymentStatusDescriptor
    {
    }

    public class EmploymentStatusDescriptorPut : EdFi.Ods.Api.Models.Resources.V2.EmploymentStatusDescriptor.EmploymentStatusDescriptor
    { 
    }

    public class EmploymentStatusDescriptorDelete : IHasIdentifier 
    {
        public EmploymentStatusDescriptorDelete() { }

        public EmploymentStatusDescriptorDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.EmploymentStatusTypes
{ 
    public class EmploymentStatusTypeGetByKey
    {
        public int EmploymentStatusTypeId { get; set; }
    }

    public class EmploymentStatusTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public int EmploymentStatusTypeId { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
    }

    public class EmploymentStatusTypeGetByIds : IHasIdentifiers<Guid>
    {
        public EmploymentStatusTypeGetByIds() { }

        public EmploymentStatusTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class EmploymentStatusTypePost : EdFi.Ods.Api.Models.Resources.V2.EmploymentStatusType.EmploymentStatusType
    {
    }

    public class EmploymentStatusTypePut : EdFi.Ods.Api.Models.Resources.V2.EmploymentStatusType.EmploymentStatusType
    { 
    }

    public class EmploymentStatusTypeDelete : IHasIdentifier 
    {
        public EmploymentStatusTypeDelete() { }

        public EmploymentStatusTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.EntryGradeLevelReasonTypes
{ 
    public class EntryGradeLevelReasonTypeGetByKey
    {
        public int EntryGradeLevelReasonTypeId { get; set; }
    }

    public class EntryGradeLevelReasonTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public int EntryGradeLevelReasonTypeId { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
    }

    public class EntryGradeLevelReasonTypeGetByIds : IHasIdentifiers<Guid>
    {
        public EntryGradeLevelReasonTypeGetByIds() { }

        public EntryGradeLevelReasonTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class EntryGradeLevelReasonTypePost : EdFi.Ods.Api.Models.Resources.V2.EntryGradeLevelReasonType.EntryGradeLevelReasonType
    {
    }

    public class EntryGradeLevelReasonTypePut : EdFi.Ods.Api.Models.Resources.V2.EntryGradeLevelReasonType.EntryGradeLevelReasonType
    { 
    }

    public class EntryGradeLevelReasonTypeDelete : IHasIdentifier 
    {
        public EntryGradeLevelReasonTypeDelete() { }

        public EntryGradeLevelReasonTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.EntryTypes
{ 
    public class EntryTypeGetByKey
    {
        public int EntryTypeId { get; set; }
    }

    public class EntryTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public int EntryTypeId { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
    }

    public class EntryTypeGetByIds : IHasIdentifiers<Guid>
    {
        public EntryTypeGetByIds() { }

        public EntryTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class EntryTypePost : EdFi.Ods.Api.Models.Resources.V2.EntryType.EntryType
    {
    }

    public class EntryTypePut : EdFi.Ods.Api.Models.Resources.V2.EntryType.EntryType
    { 
    }

    public class EntryTypeDelete : IHasIdentifier 
    {
        public EntryTypeDelete() { }

        public EntryTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.EntryTypeDescriptors
{ 
    public class EntryTypeDescriptorGetByKey
    {
        public int EntryTypeDescriptorId { get; set; }
    }

    public class EntryTypeDescriptorGetByExample
    {
        public string EntryType { get; set; }
        public int EntryTypeDescriptorId { get; set; }
    }

    public class EntryTypeDescriptorGetByIds : IHasIdentifiers<Guid>
    {
        public EntryTypeDescriptorGetByIds() { }

        public EntryTypeDescriptorGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class EntryTypeDescriptorPost : EdFi.Ods.Api.Models.Resources.V2.EntryTypeDescriptor.EntryTypeDescriptor
    {
    }

    public class EntryTypeDescriptorPut : EdFi.Ods.Api.Models.Resources.V2.EntryTypeDescriptor.EntryTypeDescriptor
    { 
    }

    public class EntryTypeDescriptorDelete : IHasIdentifier 
    {
        public EntryTypeDescriptorDelete() { }

        public EntryTypeDescriptorDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.EventCircumstanceTypes
{ 
    public class EventCircumstanceTypeGetByKey
    {
        public int EventCircumstanceTypeId { get; set; }
    }

    public class EventCircumstanceTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public int EventCircumstanceTypeId { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
    }

    public class EventCircumstanceTypeGetByIds : IHasIdentifiers<Guid>
    {
        public EventCircumstanceTypeGetByIds() { }

        public EventCircumstanceTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class EventCircumstanceTypePost : EdFi.Ods.Api.Models.Resources.V2.EventCircumstanceType.EventCircumstanceType
    {
    }

    public class EventCircumstanceTypePut : EdFi.Ods.Api.Models.Resources.V2.EventCircumstanceType.EventCircumstanceType
    { 
    }

    public class EventCircumstanceTypeDelete : IHasIdentifier 
    {
        public EventCircumstanceTypeDelete() { }

        public EventCircumstanceTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.ExitWithdrawTypes
{ 
    public class ExitWithdrawTypeGetByKey
    {
        public int ExitWithdrawTypeId { get; set; }
    }

    public class ExitWithdrawTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public int ExitWithdrawTypeId { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
    }

    public class ExitWithdrawTypeGetByIds : IHasIdentifiers<Guid>
    {
        public ExitWithdrawTypeGetByIds() { }

        public ExitWithdrawTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class ExitWithdrawTypePost : EdFi.Ods.Api.Models.Resources.V2.ExitWithdrawType.ExitWithdrawType
    {
    }

    public class ExitWithdrawTypePut : EdFi.Ods.Api.Models.Resources.V2.ExitWithdrawType.ExitWithdrawType
    { 
    }

    public class ExitWithdrawTypeDelete : IHasIdentifier 
    {
        public ExitWithdrawTypeDelete() { }

        public ExitWithdrawTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.ExitWithdrawTypeDescriptors
{ 
    public class ExitWithdrawTypeDescriptorGetByKey
    {
        public int ExitWithdrawTypeDescriptorId { get; set; }
    }

    public class ExitWithdrawTypeDescriptorGetByExample
    {
        public string ExitWithdrawType { get; set; }
        public int ExitWithdrawTypeDescriptorId { get; set; }
    }

    public class ExitWithdrawTypeDescriptorGetByIds : IHasIdentifiers<Guid>
    {
        public ExitWithdrawTypeDescriptorGetByIds() { }

        public ExitWithdrawTypeDescriptorGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class ExitWithdrawTypeDescriptorPost : EdFi.Ods.Api.Models.Resources.V2.ExitWithdrawTypeDescriptor.ExitWithdrawTypeDescriptor
    {
    }

    public class ExitWithdrawTypeDescriptorPut : EdFi.Ods.Api.Models.Resources.V2.ExitWithdrawTypeDescriptor.ExitWithdrawTypeDescriptor
    { 
    }

    public class ExitWithdrawTypeDescriptorDelete : IHasIdentifier 
    {
        public ExitWithdrawTypeDescriptorDelete() { }

        public ExitWithdrawTypeDescriptorDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.FeederSchoolAssociations
{ 
    public class FeederSchoolAssociationGetByKey
    {
        public DateTime BeginDate { get; set; }
        public int FeederSchoolId { get; set; }
        public int SchoolId { get; set; }
    }

    public class FeederSchoolAssociationGetByExample
    {
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public string FeederRelationshipDescription { get; set; }
        public int FeederSchoolId { get; set; }
        public Guid Id { get; set; }
        public int SchoolId { get; set; }
    }

    public class FeederSchoolAssociationGetByIds : IHasIdentifiers<Guid>
    {
        public FeederSchoolAssociationGetByIds() { }

        public FeederSchoolAssociationGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class FeederSchoolAssociationPost : EdFi.Ods.Api.Models.Resources.V2.FeederSchoolAssociation.FeederSchoolAssociation
    {
    }

    public class FeederSchoolAssociationPut : EdFi.Ods.Api.Models.Resources.V2.FeederSchoolAssociation.FeederSchoolAssociation
    { 
    }

    public class FeederSchoolAssociationDelete : IHasIdentifier 
    {
        public FeederSchoolAssociationDelete() { }

        public FeederSchoolAssociationDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.Grades
{ 
    public class GradeGetByKey
    {
        public DateTime BeginDate { get; set; }
        public string ClassPeriodName { get; set; }
        public string ClassroomIdentificationCode { get; set; }
        public string Type { get; set; }
        public DateTime GradingPeriodBeginDate { get; set; }
        public string GradingPeriodDescriptor { get; set; }
        public string LocalCourseCode { get; set; }
        public int SchoolId { get; set; }
        public short SchoolYear { get; set; }
        public int SequenceOfCourse { get; set; }
        public string StudentUniqueId { get; set; }
        public string TermDescriptor { get; set; }
        public string UniqueSectionCode { get; set; }
    }

    public class GradeGetByExample
    {
        public DateTime BeginDate { get; set; }
        public string ClassPeriodName { get; set; }
        public string ClassroomIdentificationCode { get; set; }
        public string DiagnosticStatement { get; set; }
        public string Type { get; set; }
        public DateTime GradingPeriodBeginDate { get; set; }
        public string GradingPeriodDescriptor { get; set; }
        public Guid Id { get; set; }
        public string LetterGradeEarned { get; set; }
        public string LocalCourseCode { get; set; }
        public decimal NumericGradeEarned { get; set; }
        public string PerformanceBaseConversionType { get; set; }
        public int SchoolId { get; set; }
        public short SchoolYear { get; set; }
        public int SequenceOfCourse { get; set; }
        public string StudentUniqueId { get; set; }
        public string TermDescriptor { get; set; }
        public string UniqueSectionCode { get; set; }
    }

    public class GradeGetByIds : IHasIdentifiers<Guid>
    {
        public GradeGetByIds() { }

        public GradeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class GradePost : EdFi.Ods.Api.Models.Resources.V2.Grade.Grade
    {
    }

    public class GradePut : EdFi.Ods.Api.Models.Resources.V2.Grade.Grade
    { 
    }

    public class GradeDelete : IHasIdentifier 
    {
        public GradeDelete() { }

        public GradeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.GradebookEntries
{ 
    public class GradebookEntryGetByKey
    {
        public string ClassPeriodName { get; set; }
        public string ClassroomIdentificationCode { get; set; }
        public DateTime DateAssigned { get; set; }
        public string Title { get; set; }
        public string LocalCourseCode { get; set; }
        public int SchoolId { get; set; }
        public short SchoolYear { get; set; }
        public int SequenceOfCourse { get; set; }
        public string TermDescriptor { get; set; }
        public string UniqueSectionCode { get; set; }
    }

    public class GradebookEntryGetByExample
    {
        public DateTime BeginDate { get; set; }
        public string ClassPeriodName { get; set; }
        public string ClassroomIdentificationCode { get; set; }
        public DateTime DateAssigned { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public string GradingPeriodDescriptor { get; set; }
        public Guid Id { get; set; }
        public string LocalCourseCode { get; set; }
        public int SchoolId { get; set; }
        public short SchoolYear { get; set; }
        public int SequenceOfCourse { get; set; }
        public string TermDescriptor { get; set; }
        public string UniqueSectionCode { get; set; }
    }

    public class GradebookEntryGetByIds : IHasIdentifiers<Guid>
    {
        public GradebookEntryGetByIds() { }

        public GradebookEntryGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class GradebookEntryPost : EdFi.Ods.Api.Models.Resources.V2.GradebookEntry.GradebookEntry
    {
    }

    public class GradebookEntryPut : EdFi.Ods.Api.Models.Resources.V2.GradebookEntry.GradebookEntry
    { 
    }

    public class GradebookEntryDelete : IHasIdentifier 
    {
        public GradebookEntryDelete() { }

        public GradebookEntryDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.GradebookEntryTypes
{ 
    public class GradebookEntryTypeGetByKey
    {
        public int GradebookEntryTypeId { get; set; }
    }

    public class GradebookEntryTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public int GradebookEntryTypeId { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
    }

    public class GradebookEntryTypeGetByIds : IHasIdentifiers<Guid>
    {
        public GradebookEntryTypeGetByIds() { }

        public GradebookEntryTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class GradebookEntryTypePost : EdFi.Ods.Api.Models.Resources.V2.GradebookEntryType.GradebookEntryType
    {
    }

    public class GradebookEntryTypePut : EdFi.Ods.Api.Models.Resources.V2.GradebookEntryType.GradebookEntryType
    { 
    }

    public class GradebookEntryTypeDelete : IHasIdentifier 
    {
        public GradebookEntryTypeDelete() { }

        public GradebookEntryTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.GradeLevelDescriptors
{ 
    public class GradeLevelDescriptorGetByKey
    {
        public int GradeLevelDescriptorId { get; set; }
    }

    public class GradeLevelDescriptorGetByExample
    {
        public int GradeLevelDescriptorId { get; set; }
        public string GradeLevelType { get; set; }
    }

    public class GradeLevelDescriptorGetByIds : IHasIdentifiers<Guid>
    {
        public GradeLevelDescriptorGetByIds() { }

        public GradeLevelDescriptorGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class GradeLevelDescriptorPost : EdFi.Ods.Api.Models.Resources.V2.GradeLevelDescriptor.GradeLevelDescriptor
    {
    }

    public class GradeLevelDescriptorPut : EdFi.Ods.Api.Models.Resources.V2.GradeLevelDescriptor.GradeLevelDescriptor
    { 
    }

    public class GradeLevelDescriptorDelete : IHasIdentifier 
    {
        public GradeLevelDescriptorDelete() { }

        public GradeLevelDescriptorDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.GradeLevelTypes
{ 
    public class GradeLevelTypeGetByKey
    {
        public int GradeLevelTypeId { get; set; }
    }

    public class GradeLevelTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public int GradeLevelTypeId { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
    }

    public class GradeLevelTypeGetByIds : IHasIdentifiers<Guid>
    {
        public GradeLevelTypeGetByIds() { }

        public GradeLevelTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class GradeLevelTypePost : EdFi.Ods.Api.Models.Resources.V2.GradeLevelType.GradeLevelType
    {
    }

    public class GradeLevelTypePut : EdFi.Ods.Api.Models.Resources.V2.GradeLevelType.GradeLevelType
    { 
    }

    public class GradeLevelTypeDelete : IHasIdentifier 
    {
        public GradeLevelTypeDelete() { }

        public GradeLevelTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.GradeTypes
{ 
    public class GradeTypeGetByKey
    {
        public int GradeTypeId { get; set; }
    }

    public class GradeTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public int GradeTypeId { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
    }

    public class GradeTypeGetByIds : IHasIdentifiers<Guid>
    {
        public GradeTypeGetByIds() { }

        public GradeTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class GradeTypePost : EdFi.Ods.Api.Models.Resources.V2.GradeType.GradeType
    {
    }

    public class GradeTypePut : EdFi.Ods.Api.Models.Resources.V2.GradeType.GradeType
    { 
    }

    public class GradeTypeDelete : IHasIdentifier 
    {
        public GradeTypeDelete() { }

        public GradeTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.GradingPeriods
{ 
    public class GradingPeriodGetByKey
    {
        public DateTime BeginDate { get; set; }
        public string Descriptor { get; set; }
        public int SchoolId { get; set; }
    }

    public class GradingPeriodGetByExample
    {
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Descriptor { get; set; }
        public Guid Id { get; set; }
        public int PeriodSequence { get; set; }
        public int SchoolId { get; set; }
        public int TotalInstructionalDays { get; set; }
    }

    public class GradingPeriodGetByIds : IHasIdentifiers<Guid>
    {
        public GradingPeriodGetByIds() { }

        public GradingPeriodGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class GradingPeriodPost : EdFi.Ods.Api.Models.Resources.V2.GradingPeriod.GradingPeriod
    {
    }

    public class GradingPeriodPut : EdFi.Ods.Api.Models.Resources.V2.GradingPeriod.GradingPeriod
    { 
    }

    public class GradingPeriodDelete : IHasIdentifier 
    {
        public GradingPeriodDelete() { }

        public GradingPeriodDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.GradingPeriodDescriptors
{ 
    public class GradingPeriodDescriptorGetByKey
    {
        public int GradingPeriodDescriptorId { get; set; }
    }

    public class GradingPeriodDescriptorGetByExample
    {
        public int GradingPeriodDescriptorId { get; set; }
        public string GradingPeriodType { get; set; }
    }

    public class GradingPeriodDescriptorGetByIds : IHasIdentifiers<Guid>
    {
        public GradingPeriodDescriptorGetByIds() { }

        public GradingPeriodDescriptorGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class GradingPeriodDescriptorPost : EdFi.Ods.Api.Models.Resources.V2.GradingPeriodDescriptor.GradingPeriodDescriptor
    {
    }

    public class GradingPeriodDescriptorPut : EdFi.Ods.Api.Models.Resources.V2.GradingPeriodDescriptor.GradingPeriodDescriptor
    { 
    }

    public class GradingPeriodDescriptorDelete : IHasIdentifier 
    {
        public GradingPeriodDescriptorDelete() { }

        public GradingPeriodDescriptorDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.GradingPeriodTypes
{ 
    public class GradingPeriodTypeGetByKey
    {
        public int GradingPeriodTypeId { get; set; }
    }

    public class GradingPeriodTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public int GradingPeriodTypeId { get; set; }
        public Guid Id { get; set; }
        public int PeriodSequence { get; set; }
        public string ShortDescription { get; set; }
    }

    public class GradingPeriodTypeGetByIds : IHasIdentifiers<Guid>
    {
        public GradingPeriodTypeGetByIds() { }

        public GradingPeriodTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class GradingPeriodTypePost : EdFi.Ods.Api.Models.Resources.V2.GradingPeriodType.GradingPeriodType
    {
    }

    public class GradingPeriodTypePut : EdFi.Ods.Api.Models.Resources.V2.GradingPeriodType.GradingPeriodType
    { 
    }

    public class GradingPeriodTypeDelete : IHasIdentifier 
    {
        public GradingPeriodTypeDelete() { }

        public GradingPeriodTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.GraduationPlans
{ 
    public class GraduationPlanGetByKey
    {
        public int EducationOrganizationId { get; set; }
        public string TypeDescriptor { get; set; }
        public short GraduationSchoolYear { get; set; }
    }

    public class GraduationPlanGetByExample
    {
        public int EducationOrganizationId { get; set; }
        public string TypeDescriptor { get; set; }
        public short GraduationSchoolYear { get; set; }
        public Guid Id { get; set; }
        public bool IndividualPlan { get; set; }
        public decimal TotalRequiredCreditConversion { get; set; }
        public decimal TotalRequiredCredits { get; set; }
        public string TotalRequiredCreditType { get; set; }
    }

    public class GraduationPlanGetByIds : IHasIdentifiers<Guid>
    {
        public GraduationPlanGetByIds() { }

        public GraduationPlanGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class GraduationPlanPost : EdFi.Ods.Api.Models.Resources.V2.GraduationPlan.GraduationPlan
    {
    }

    public class GraduationPlanPut : EdFi.Ods.Api.Models.Resources.V2.GraduationPlan.GraduationPlan
    { 
    }

    public class GraduationPlanDelete : IHasIdentifier 
    {
        public GraduationPlanDelete() { }

        public GraduationPlanDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.GraduationPlanTypes
{ 
    public class GraduationPlanTypeGetByKey
    {
        public int GraduationPlanTypeId { get; set; }
    }

    public class GraduationPlanTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public int GraduationPlanTypeId { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
    }

    public class GraduationPlanTypeGetByIds : IHasIdentifiers<Guid>
    {
        public GraduationPlanTypeGetByIds() { }

        public GraduationPlanTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class GraduationPlanTypePost : EdFi.Ods.Api.Models.Resources.V2.GraduationPlanType.GraduationPlanType
    {
    }

    public class GraduationPlanTypePut : EdFi.Ods.Api.Models.Resources.V2.GraduationPlanType.GraduationPlanType
    { 
    }

    public class GraduationPlanTypeDelete : IHasIdentifier 
    {
        public GraduationPlanTypeDelete() { }

        public GraduationPlanTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.GraduationPlanTypeDescriptors
{ 
    public class GraduationPlanTypeDescriptorGetByKey
    {
        public int GraduationPlanTypeDescriptorId { get; set; }
    }

    public class GraduationPlanTypeDescriptorGetByExample
    {
        public string GraduationPlanType { get; set; }
        public int GraduationPlanTypeDescriptorId { get; set; }
    }

    public class GraduationPlanTypeDescriptorGetByIds : IHasIdentifiers<Guid>
    {
        public GraduationPlanTypeDescriptorGetByIds() { }

        public GraduationPlanTypeDescriptorGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class GraduationPlanTypeDescriptorPost : EdFi.Ods.Api.Models.Resources.V2.GraduationPlanTypeDescriptor.GraduationPlanTypeDescriptor
    {
    }

    public class GraduationPlanTypeDescriptorPut : EdFi.Ods.Api.Models.Resources.V2.GraduationPlanTypeDescriptor.GraduationPlanTypeDescriptor
    { 
    }

    public class GraduationPlanTypeDescriptorDelete : IHasIdentifier 
    {
        public GraduationPlanTypeDescriptorDelete() { }

        public GraduationPlanTypeDescriptorDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.GunFreeSchoolsActReportingStatusTypes
{ 
    public class GunFreeSchoolsActReportingStatusTypeGetByKey
    {
        public int GunFreeSchoolsActReportingStatusTypeId { get; set; }
    }

    public class GunFreeSchoolsActReportingStatusTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public int GunFreeSchoolsActReportingStatusTypeId { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
    }

    public class GunFreeSchoolsActReportingStatusTypeGetByIds : IHasIdentifiers<Guid>
    {
        public GunFreeSchoolsActReportingStatusTypeGetByIds() { }

        public GunFreeSchoolsActReportingStatusTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class GunFreeSchoolsActReportingStatusTypePost : EdFi.Ods.Api.Models.Resources.V2.GunFreeSchoolsActReportingStatusType.GunFreeSchoolsActReportingStatusType
    {
    }

    public class GunFreeSchoolsActReportingStatusTypePut : EdFi.Ods.Api.Models.Resources.V2.GunFreeSchoolsActReportingStatusType.GunFreeSchoolsActReportingStatusType
    { 
    }

    public class GunFreeSchoolsActReportingStatusTypeDelete : IHasIdentifier 
    {
        public GunFreeSchoolsActReportingStatusTypeDelete() { }

        public GunFreeSchoolsActReportingStatusTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.IdentificationDocumentUseTypes
{ 
    public class IdentificationDocumentUseTypeGetByKey
    {
        public int IdentificationDocumentUseTypeId { get; set; }
    }

    public class IdentificationDocumentUseTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public int IdentificationDocumentUseTypeId { get; set; }
        public string ShortDescription { get; set; }
    }

    public class IdentificationDocumentUseTypeGetByIds : IHasIdentifiers<Guid>
    {
        public IdentificationDocumentUseTypeGetByIds() { }

        public IdentificationDocumentUseTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class IdentificationDocumentUseTypePost : EdFi.Ods.Api.Models.Resources.V2.IdentificationDocumentUseType.IdentificationDocumentUseType
    {
    }

    public class IdentificationDocumentUseTypePut : EdFi.Ods.Api.Models.Resources.V2.IdentificationDocumentUseType.IdentificationDocumentUseType
    { 
    }

    public class IdentificationDocumentUseTypeDelete : IHasIdentifier 
    {
        public IdentificationDocumentUseTypeDelete() { }

        public IdentificationDocumentUseTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.IncidentLocationTypes
{ 
    public class IncidentLocationTypeGetByKey
    {
        public int IncidentLocationTypeId { get; set; }
    }

    public class IncidentLocationTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public int IncidentLocationTypeId { get; set; }
        public string ShortDescription { get; set; }
    }

    public class IncidentLocationTypeGetByIds : IHasIdentifiers<Guid>
    {
        public IncidentLocationTypeGetByIds() { }

        public IncidentLocationTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class IncidentLocationTypePost : EdFi.Ods.Api.Models.Resources.V2.IncidentLocationType.IncidentLocationType
    {
    }

    public class IncidentLocationTypePut : EdFi.Ods.Api.Models.Resources.V2.IncidentLocationType.IncidentLocationType
    { 
    }

    public class IncidentLocationTypeDelete : IHasIdentifier 
    {
        public IncidentLocationTypeDelete() { }

        public IncidentLocationTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.InstitutionTelephoneNumberTypes
{ 
    public class InstitutionTelephoneNumberTypeGetByKey
    {
        public int InstitutionTelephoneNumberTypeId { get; set; }
    }

    public class InstitutionTelephoneNumberTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public int InstitutionTelephoneNumberTypeId { get; set; }
        public string ShortDescription { get; set; }
    }

    public class InstitutionTelephoneNumberTypeGetByIds : IHasIdentifiers<Guid>
    {
        public InstitutionTelephoneNumberTypeGetByIds() { }

        public InstitutionTelephoneNumberTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class InstitutionTelephoneNumberTypePost : EdFi.Ods.Api.Models.Resources.V2.InstitutionTelephoneNumberType.InstitutionTelephoneNumberType
    {
    }

    public class InstitutionTelephoneNumberTypePut : EdFi.Ods.Api.Models.Resources.V2.InstitutionTelephoneNumberType.InstitutionTelephoneNumberType
    { 
    }

    public class InstitutionTelephoneNumberTypeDelete : IHasIdentifier 
    {
        public InstitutionTelephoneNumberTypeDelete() { }

        public InstitutionTelephoneNumberTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.IntegratedTechnologyStatusTypes
{ 
    public class IntegratedTechnologyStatusTypeGetByKey
    {
        public int IntegratedTechnologyStatusTypeId { get; set; }
    }

    public class IntegratedTechnologyStatusTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public int IntegratedTechnologyStatusTypeId { get; set; }
        public string ShortDescription { get; set; }
    }

    public class IntegratedTechnologyStatusTypeGetByIds : IHasIdentifiers<Guid>
    {
        public IntegratedTechnologyStatusTypeGetByIds() { }

        public IntegratedTechnologyStatusTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class IntegratedTechnologyStatusTypePost : EdFi.Ods.Api.Models.Resources.V2.IntegratedTechnologyStatusType.IntegratedTechnologyStatusType
    {
    }

    public class IntegratedTechnologyStatusTypePut : EdFi.Ods.Api.Models.Resources.V2.IntegratedTechnologyStatusType.IntegratedTechnologyStatusType
    { 
    }

    public class IntegratedTechnologyStatusTypeDelete : IHasIdentifier 
    {
        public IntegratedTechnologyStatusTypeDelete() { }

        public IntegratedTechnologyStatusTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.InteractivityStyleTypes
{ 
    public class InteractivityStyleTypeGetByKey
    {
        public int InteractivityStyleTypeId { get; set; }
    }

    public class InteractivityStyleTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public int InteractivityStyleTypeId { get; set; }
        public string ShortDescription { get; set; }
    }

    public class InteractivityStyleTypeGetByIds : IHasIdentifiers<Guid>
    {
        public InteractivityStyleTypeGetByIds() { }

        public InteractivityStyleTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class InteractivityStyleTypePost : EdFi.Ods.Api.Models.Resources.V2.InteractivityStyleType.InteractivityStyleType
    {
    }

    public class InteractivityStyleTypePut : EdFi.Ods.Api.Models.Resources.V2.InteractivityStyleType.InteractivityStyleType
    { 
    }

    public class InteractivityStyleTypeDelete : IHasIdentifier 
    {
        public InteractivityStyleTypeDelete() { }

        public InteractivityStyleTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.InternetAccessTypes
{ 
    public class InternetAccessTypeGetByKey
    {
        public int InternetAccessTypeId { get; set; }
    }

    public class InternetAccessTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public int InternetAccessTypeId { get; set; }
        public string ShortDescription { get; set; }
    }

    public class InternetAccessTypeGetByIds : IHasIdentifiers<Guid>
    {
        public InternetAccessTypeGetByIds() { }

        public InternetAccessTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class InternetAccessTypePost : EdFi.Ods.Api.Models.Resources.V2.InternetAccessType.InternetAccessType
    {
    }

    public class InternetAccessTypePut : EdFi.Ods.Api.Models.Resources.V2.InternetAccessType.InternetAccessType
    { 
    }

    public class InternetAccessTypeDelete : IHasIdentifier 
    {
        public InternetAccessTypeDelete() { }

        public InternetAccessTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.Interventions
{ 
    public class InterventionGetByKey
    {
        public int EducationOrganizationId { get; set; }
        public string IdentificationCode { get; set; }
    }

    public class InterventionGetByExample
    {
        public DateTime BeginDate { get; set; }
        public string DeliveryMethodType { get; set; }
        public int EducationOrganizationId { get; set; }
        public DateTime EndDate { get; set; }
        public Guid Id { get; set; }
        public string ClassType { get; set; }
        public string IdentificationCode { get; set; }
    }

    public class InterventionGetByIds : IHasIdentifiers<Guid>
    {
        public InterventionGetByIds() { }

        public InterventionGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class InterventionPost : EdFi.Ods.Api.Models.Resources.V2.Intervention.Intervention
    {
    }

    public class InterventionPut : EdFi.Ods.Api.Models.Resources.V2.Intervention.Intervention
    { 
    }

    public class InterventionDelete : IHasIdentifier 
    {
        public InterventionDelete() { }

        public InterventionDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.InterventionClassTypes
{ 
    public class InterventionClassTypeGetByKey
    {
        public int InterventionClassTypeId { get; set; }
    }

    public class InterventionClassTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public int InterventionClassTypeId { get; set; }
        public string ShortDescription { get; set; }
    }

    public class InterventionClassTypeGetByIds : IHasIdentifiers<Guid>
    {
        public InterventionClassTypeGetByIds() { }

        public InterventionClassTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class InterventionClassTypePost : EdFi.Ods.Api.Models.Resources.V2.InterventionClassType.InterventionClassType
    {
    }

    public class InterventionClassTypePut : EdFi.Ods.Api.Models.Resources.V2.InterventionClassType.InterventionClassType
    { 
    }

    public class InterventionClassTypeDelete : IHasIdentifier 
    {
        public InterventionClassTypeDelete() { }

        public InterventionClassTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.InterventionEffectivenessRatingTypes
{ 
    public class InterventionEffectivenessRatingTypeGetByKey
    {
        public int InterventionEffectivenessRatingTypeId { get; set; }
    }

    public class InterventionEffectivenessRatingTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public int InterventionEffectivenessRatingTypeId { get; set; }
        public string ShortDescription { get; set; }
    }

    public class InterventionEffectivenessRatingTypeGetByIds : IHasIdentifiers<Guid>
    {
        public InterventionEffectivenessRatingTypeGetByIds() { }

        public InterventionEffectivenessRatingTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class InterventionEffectivenessRatingTypePost : EdFi.Ods.Api.Models.Resources.V2.InterventionEffectivenessRatingType.InterventionEffectivenessRatingType
    {
    }

    public class InterventionEffectivenessRatingTypePut : EdFi.Ods.Api.Models.Resources.V2.InterventionEffectivenessRatingType.InterventionEffectivenessRatingType
    { 
    }

    public class InterventionEffectivenessRatingTypeDelete : IHasIdentifier 
    {
        public InterventionEffectivenessRatingTypeDelete() { }

        public InterventionEffectivenessRatingTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.InterventionPrescriptions
{ 
    public class InterventionPrescriptionGetByKey
    {
        public int EducationOrganizationId { get; set; }
        public string IdentificationCode { get; set; }
    }

    public class InterventionPrescriptionGetByExample
    {
        public string DeliveryMethodType { get; set; }
        public int EducationOrganizationId { get; set; }
        public Guid Id { get; set; }
        public string InterventionClassType { get; set; }
        public string IdentificationCode { get; set; }
    }

    public class InterventionPrescriptionGetByIds : IHasIdentifiers<Guid>
    {
        public InterventionPrescriptionGetByIds() { }

        public InterventionPrescriptionGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class InterventionPrescriptionPost : EdFi.Ods.Api.Models.Resources.V2.InterventionPrescription.InterventionPrescription
    {
    }

    public class InterventionPrescriptionPut : EdFi.Ods.Api.Models.Resources.V2.InterventionPrescription.InterventionPrescription
    { 
    }

    public class InterventionPrescriptionDelete : IHasIdentifier 
    {
        public InterventionPrescriptionDelete() { }

        public InterventionPrescriptionDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.InterventionStudies
{ 
    public class InterventionStudyGetByKey
    {
        public int EducationOrganizationId { get; set; }
        public string IdentificationCode { get; set; }
    }

    public class InterventionStudyGetByExample
    {
        public string DeliveryMethodType { get; set; }
        public int EducationOrganizationId { get; set; }
        public Guid Id { get; set; }
        public string InterventionClassType { get; set; }
        public int InterventionPrescriptionEducationOrganizationId { get; set; }
        public string InterventionPrescriptionIdentificationCode { get; set; }
        public string IdentificationCode { get; set; }
        public int Participants { get; set; }
    }

    public class InterventionStudyGetByIds : IHasIdentifiers<Guid>
    {
        public InterventionStudyGetByIds() { }

        public InterventionStudyGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class InterventionStudyPost : EdFi.Ods.Api.Models.Resources.V2.InterventionStudy.InterventionStudy
    {
    }

    public class InterventionStudyPut : EdFi.Ods.Api.Models.Resources.V2.InterventionStudy.InterventionStudy
    { 
    }

    public class InterventionStudyDelete : IHasIdentifier 
    {
        public InterventionStudyDelete() { }

        public InterventionStudyDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.LanguageDescriptors
{ 
    public class LanguageDescriptorGetByKey
    {
        public int LanguageDescriptorId { get; set; }
    }

    public class LanguageDescriptorGetByExample
    {
        public int LanguageDescriptorId { get; set; }
        public string LanguageType { get; set; }
    }

    public class LanguageDescriptorGetByIds : IHasIdentifiers<Guid>
    {
        public LanguageDescriptorGetByIds() { }

        public LanguageDescriptorGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class LanguageDescriptorPost : EdFi.Ods.Api.Models.Resources.V2.LanguageDescriptor.LanguageDescriptor
    {
    }

    public class LanguageDescriptorPut : EdFi.Ods.Api.Models.Resources.V2.LanguageDescriptor.LanguageDescriptor
    { 
    }

    public class LanguageDescriptorDelete : IHasIdentifier 
    {
        public LanguageDescriptorDelete() { }

        public LanguageDescriptorDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.LanguageTypes
{ 
    public class LanguageTypeGetByKey
    {
        public int LanguageTypeId { get; set; }
    }

    public class LanguageTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public int LanguageTypeId { get; set; }
        public string ShortDescription { get; set; }
    }

    public class LanguageTypeGetByIds : IHasIdentifiers<Guid>
    {
        public LanguageTypeGetByIds() { }

        public LanguageTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class LanguageTypePost : EdFi.Ods.Api.Models.Resources.V2.LanguageType.LanguageType
    {
    }

    public class LanguageTypePut : EdFi.Ods.Api.Models.Resources.V2.LanguageType.LanguageType
    { 
    }

    public class LanguageTypeDelete : IHasIdentifier 
    {
        public LanguageTypeDelete() { }

        public LanguageTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.LanguageUseTypes
{ 
    public class LanguageUseTypeGetByKey
    {
        public int LanguageUseTypeId { get; set; }
    }

    public class LanguageUseTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public int LanguageUseTypeId { get; set; }
        public string ShortDescription { get; set; }
    }

    public class LanguageUseTypeGetByIds : IHasIdentifiers<Guid>
    {
        public LanguageUseTypeGetByIds() { }

        public LanguageUseTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class LanguageUseTypePost : EdFi.Ods.Api.Models.Resources.V2.LanguageUseType.LanguageUseType
    {
    }

    public class LanguageUseTypePut : EdFi.Ods.Api.Models.Resources.V2.LanguageUseType.LanguageUseType
    { 
    }

    public class LanguageUseTypeDelete : IHasIdentifier 
    {
        public LanguageUseTypeDelete() { }

        public LanguageUseTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.LearningObjectives
{ 
    public class LearningObjectiveGetByKey
    {
        public string LearningObjectiveId { get; set; }
        public string Namespace { get; set; }
    }

    public class LearningObjectiveGetByExample
    {
        public string Description { get; set; }
        public Guid Id { get; set; }
        public string LearningObjectiveId { get; set; }
        public string Namespace { get; set; }
        public string Nomenclature { get; set; }
        public string Objective { get; set; }
        public string ParentLearningObjectiveId { get; set; }
        public string ParentNamespace { get; set; }
        public string SuccessCriteria { get; set; }
    }

    public class LearningObjectiveGetByIds : IHasIdentifiers<Guid>
    {
        public LearningObjectiveGetByIds() { }

        public LearningObjectiveGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class LearningObjectivePost : EdFi.Ods.Api.Models.Resources.V2.LearningObjective.LearningObjective
    {
    }

    public class LearningObjectivePut : EdFi.Ods.Api.Models.Resources.V2.LearningObjective.LearningObjective
    { 
    }

    public class LearningObjectiveDelete : IHasIdentifier 
    {
        public LearningObjectiveDelete() { }

        public LearningObjectiveDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.LearningStandards
{ 
    public class LearningStandardGetByKey
    {
        public string LearningStandardId { get; set; }
    }

    public class LearningStandardGetByExample
    {
        public string AcademicSubjectDescriptor { get; set; }
        public string CourseTitle { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public string LearningStandardId { get; set; }
        public string ItemCode { get; set; }
        public string Namespace { get; set; }
        public string ParentLearningStandardId { get; set; }
        public string SuccessCriteria { get; set; }
        public string URI { get; set; }
    }

    public class LearningStandardGetByIds : IHasIdentifiers<Guid>
    {
        public LearningStandardGetByIds() { }

        public LearningStandardGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class LearningStandardPost : EdFi.Ods.Api.Models.Resources.V2.LearningStandard.LearningStandard
    {
    }

    public class LearningStandardPut : EdFi.Ods.Api.Models.Resources.V2.LearningStandard.LearningStandard
    { 
    }

    public class LearningStandardDelete : IHasIdentifier 
    {
        public LearningStandardDelete() { }

        public LearningStandardDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.LeaveEvents
{ 
    public class LeaveEventGetByKey
    {
        public DateTime EventDate { get; set; }
        public string CategoryType { get; set; }
        public string StaffUniqueId { get; set; }
    }

    public class LeaveEventGetByExample
    {
        public DateTime EventDate { get; set; }
        public decimal HoursOnLeave { get; set; }
        public Guid Id { get; set; }
        public string CategoryType { get; set; }
        public string Reason { get; set; }
        public string StaffUniqueId { get; set; }
        public bool SubstituteAssigned { get; set; }
    }

    public class LeaveEventGetByIds : IHasIdentifiers<Guid>
    {
        public LeaveEventGetByIds() { }

        public LeaveEventGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class LeaveEventPost : EdFi.Ods.Api.Models.Resources.V2.LeaveEvent.LeaveEvent
    {
    }

    public class LeaveEventPut : EdFi.Ods.Api.Models.Resources.V2.LeaveEvent.LeaveEvent
    { 
    }

    public class LeaveEventDelete : IHasIdentifier 
    {
        public LeaveEventDelete() { }

        public LeaveEventDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.LeaveEventCategoryTypes
{ 
    public class LeaveEventCategoryTypeGetByKey
    {
        public int LeaveEventCategoryTypeId { get; set; }
    }

    public class LeaveEventCategoryTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public int LeaveEventCategoryTypeId { get; set; }
        public string ShortDescription { get; set; }
    }

    public class LeaveEventCategoryTypeGetByIds : IHasIdentifiers<Guid>
    {
        public LeaveEventCategoryTypeGetByIds() { }

        public LeaveEventCategoryTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class LeaveEventCategoryTypePost : EdFi.Ods.Api.Models.Resources.V2.LeaveEventCategoryType.LeaveEventCategoryType
    {
    }

    public class LeaveEventCategoryTypePut : EdFi.Ods.Api.Models.Resources.V2.LeaveEventCategoryType.LeaveEventCategoryType
    { 
    }

    public class LeaveEventCategoryTypeDelete : IHasIdentifier 
    {
        public LeaveEventCategoryTypeDelete() { }

        public LeaveEventCategoryTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.LevelDescriptors
{ 
    public class LevelDescriptorGetByKey
    {
        public int LevelDescriptorId { get; set; }
    }

    public class LevelDescriptorGetByExample
    {
        public int LevelDescriptorId { get; set; }
    }

    public class LevelDescriptorGetByIds : IHasIdentifiers<Guid>
    {
        public LevelDescriptorGetByIds() { }

        public LevelDescriptorGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class LevelDescriptorPost : EdFi.Ods.Api.Models.Resources.V2.LevelDescriptor.LevelDescriptor
    {
    }

    public class LevelDescriptorPut : EdFi.Ods.Api.Models.Resources.V2.LevelDescriptor.LevelDescriptor
    { 
    }

    public class LevelDescriptorDelete : IHasIdentifier 
    {
        public LevelDescriptorDelete() { }

        public LevelDescriptorDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.LevelOfEducationDescriptors
{ 
    public class LevelOfEducationDescriptorGetByKey
    {
        public int LevelOfEducationDescriptorId { get; set; }
    }

    public class LevelOfEducationDescriptorGetByExample
    {
        public int LevelOfEducationDescriptorId { get; set; }
        public string LevelOfEducationType { get; set; }
    }

    public class LevelOfEducationDescriptorGetByIds : IHasIdentifiers<Guid>
    {
        public LevelOfEducationDescriptorGetByIds() { }

        public LevelOfEducationDescriptorGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class LevelOfEducationDescriptorPost : EdFi.Ods.Api.Models.Resources.V2.LevelOfEducationDescriptor.LevelOfEducationDescriptor
    {
    }

    public class LevelOfEducationDescriptorPut : EdFi.Ods.Api.Models.Resources.V2.LevelOfEducationDescriptor.LevelOfEducationDescriptor
    { 
    }

    public class LevelOfEducationDescriptorDelete : IHasIdentifier 
    {
        public LevelOfEducationDescriptorDelete() { }

        public LevelOfEducationDescriptorDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.LevelOfEducationTypes
{ 
    public class LevelOfEducationTypeGetByKey
    {
        public int LevelOfEducationTypeId { get; set; }
    }

    public class LevelOfEducationTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public int LevelOfEducationTypeId { get; set; }
        public string ShortDescription { get; set; }
    }

    public class LevelOfEducationTypeGetByIds : IHasIdentifiers<Guid>
    {
        public LevelOfEducationTypeGetByIds() { }

        public LevelOfEducationTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class LevelOfEducationTypePost : EdFi.Ods.Api.Models.Resources.V2.LevelOfEducationType.LevelOfEducationType
    {
    }

    public class LevelOfEducationTypePut : EdFi.Ods.Api.Models.Resources.V2.LevelOfEducationType.LevelOfEducationType
    { 
    }

    public class LevelOfEducationTypeDelete : IHasIdentifier 
    {
        public LevelOfEducationTypeDelete() { }

        public LevelOfEducationTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.LimitedEnglishProficiencyDescriptors
{ 
    public class LimitedEnglishProficiencyDescriptorGetByKey
    {
        public int LimitedEnglishProficiencyDescriptorId { get; set; }
    }

    public class LimitedEnglishProficiencyDescriptorGetByExample
    {
        public int LimitedEnglishProficiencyDescriptorId { get; set; }
        public string LimitedEnglishProficiencyType { get; set; }
    }

    public class LimitedEnglishProficiencyDescriptorGetByIds : IHasIdentifiers<Guid>
    {
        public LimitedEnglishProficiencyDescriptorGetByIds() { }

        public LimitedEnglishProficiencyDescriptorGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class LimitedEnglishProficiencyDescriptorPost : EdFi.Ods.Api.Models.Resources.V2.LimitedEnglishProficiencyDescriptor.LimitedEnglishProficiencyDescriptor
    {
    }

    public class LimitedEnglishProficiencyDescriptorPut : EdFi.Ods.Api.Models.Resources.V2.LimitedEnglishProficiencyDescriptor.LimitedEnglishProficiencyDescriptor
    { 
    }

    public class LimitedEnglishProficiencyDescriptorDelete : IHasIdentifier 
    {
        public LimitedEnglishProficiencyDescriptorDelete() { }

        public LimitedEnglishProficiencyDescriptorDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.LimitedEnglishProficiencyTypes
{ 
    public class LimitedEnglishProficiencyTypeGetByKey
    {
        public int LimitedEnglishProficiencyTypeId { get; set; }
    }

    public class LimitedEnglishProficiencyTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public int LimitedEnglishProficiencyTypeId { get; set; }
        public string ShortDescription { get; set; }
    }

    public class LimitedEnglishProficiencyTypeGetByIds : IHasIdentifiers<Guid>
    {
        public LimitedEnglishProficiencyTypeGetByIds() { }

        public LimitedEnglishProficiencyTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class LimitedEnglishProficiencyTypePost : EdFi.Ods.Api.Models.Resources.V2.LimitedEnglishProficiencyType.LimitedEnglishProficiencyType
    {
    }

    public class LimitedEnglishProficiencyTypePut : EdFi.Ods.Api.Models.Resources.V2.LimitedEnglishProficiencyType.LimitedEnglishProficiencyType
    { 
    }

    public class LimitedEnglishProficiencyTypeDelete : IHasIdentifier 
    {
        public LimitedEnglishProficiencyTypeDelete() { }

        public LimitedEnglishProficiencyTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.LocalEducationAgencies
{ 
    public class LocalEducationAgencyGetByKey
    {
        public int LocalEducationAgencyId { get; set; }
    }

    public class LocalEducationAgencyGetByExample
    {
        public string CharterStatusType { get; set; }
        public int EducationServiceCenterId { get; set; }
        public string CategoryType { get; set; }
        public int LocalEducationAgencyId { get; set; }
        public int ParentLocalEducationAgencyId { get; set; }
        public int StateEducationAgencyId { get; set; }
    }

    public class LocalEducationAgencyGetByIds : IHasIdentifiers<Guid>
    {
        public LocalEducationAgencyGetByIds() { }

        public LocalEducationAgencyGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class LocalEducationAgencyPost : EdFi.Ods.Api.Models.Resources.V2.LocalEducationAgency.LocalEducationAgency
    {
    }

    public class LocalEducationAgencyPut : EdFi.Ods.Api.Models.Resources.V2.LocalEducationAgency.LocalEducationAgency
    { 
    }

    public class LocalEducationAgencyDelete : IHasIdentifier 
    {
        public LocalEducationAgencyDelete() { }

        public LocalEducationAgencyDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.LocalEducationAgencyCategoryTypes
{ 
    public class LocalEducationAgencyCategoryTypeGetByKey
    {
        public int LocalEducationAgencyCategoryTypeId { get; set; }
    }

    public class LocalEducationAgencyCategoryTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public int LocalEducationAgencyCategoryTypeId { get; set; }
        public string ShortDescription { get; set; }
    }

    public class LocalEducationAgencyCategoryTypeGetByIds : IHasIdentifiers<Guid>
    {
        public LocalEducationAgencyCategoryTypeGetByIds() { }

        public LocalEducationAgencyCategoryTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class LocalEducationAgencyCategoryTypePost : EdFi.Ods.Api.Models.Resources.V2.LocalEducationAgencyCategoryType.LocalEducationAgencyCategoryType
    {
    }

    public class LocalEducationAgencyCategoryTypePut : EdFi.Ods.Api.Models.Resources.V2.LocalEducationAgencyCategoryType.LocalEducationAgencyCategoryType
    { 
    }

    public class LocalEducationAgencyCategoryTypeDelete : IHasIdentifier 
    {
        public LocalEducationAgencyCategoryTypeDelete() { }

        public LocalEducationAgencyCategoryTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.Locations
{ 
    public class LocationGetByKey
    {
        public string ClassroomIdentificationCode { get; set; }
        public int SchoolId { get; set; }
    }

    public class LocationGetByExample
    {
        public string ClassroomIdentificationCode { get; set; }
        public Guid Id { get; set; }
        public int MaximumNumberOfSeats { get; set; }
        public int OptimalNumberOfSeats { get; set; }
        public int SchoolId { get; set; }
    }

    public class LocationGetByIds : IHasIdentifiers<Guid>
    {
        public LocationGetByIds() { }

        public LocationGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class LocationPost : EdFi.Ods.Api.Models.Resources.V2.Location.Location
    {
    }

    public class LocationPut : EdFi.Ods.Api.Models.Resources.V2.Location.Location
    { 
    }

    public class LocationDelete : IHasIdentifier 
    {
        public LocationDelete() { }

        public LocationDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.MagnetSpecialProgramEmphasisSchoolTypes
{ 
    public class MagnetSpecialProgramEmphasisSchoolTypeGetByKey
    {
        public int MagnetSpecialProgramEmphasisSchoolTypeId { get; set; }
    }

    public class MagnetSpecialProgramEmphasisSchoolTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public int MagnetSpecialProgramEmphasisSchoolTypeId { get; set; }
        public string ShortDescription { get; set; }
    }

    public class MagnetSpecialProgramEmphasisSchoolTypeGetByIds : IHasIdentifiers<Guid>
    {
        public MagnetSpecialProgramEmphasisSchoolTypeGetByIds() { }

        public MagnetSpecialProgramEmphasisSchoolTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class MagnetSpecialProgramEmphasisSchoolTypePost : EdFi.Ods.Api.Models.Resources.V2.MagnetSpecialProgramEmphasisSchoolType.MagnetSpecialProgramEmphasisSchoolType
    {
    }

    public class MagnetSpecialProgramEmphasisSchoolTypePut : EdFi.Ods.Api.Models.Resources.V2.MagnetSpecialProgramEmphasisSchoolType.MagnetSpecialProgramEmphasisSchoolType
    { 
    }

    public class MagnetSpecialProgramEmphasisSchoolTypeDelete : IHasIdentifier 
    {
        public MagnetSpecialProgramEmphasisSchoolTypeDelete() { }

        public MagnetSpecialProgramEmphasisSchoolTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.MediumOfInstructionTypes
{ 
    public class MediumOfInstructionTypeGetByKey
    {
        public int MediumOfInstructionTypeId { get; set; }
    }

    public class MediumOfInstructionTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public int MediumOfInstructionTypeId { get; set; }
        public string ShortDescription { get; set; }
    }

    public class MediumOfInstructionTypeGetByIds : IHasIdentifiers<Guid>
    {
        public MediumOfInstructionTypeGetByIds() { }

        public MediumOfInstructionTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class MediumOfInstructionTypePost : EdFi.Ods.Api.Models.Resources.V2.MediumOfInstructionType.MediumOfInstructionType
    {
    }

    public class MediumOfInstructionTypePut : EdFi.Ods.Api.Models.Resources.V2.MediumOfInstructionType.MediumOfInstructionType
    { 
    }

    public class MediumOfInstructionTypeDelete : IHasIdentifier 
    {
        public MediumOfInstructionTypeDelete() { }

        public MediumOfInstructionTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.MeetingDayTypes
{ 
    public class MeetingDayTypeGetByKey
    {
        public int MeetingDayTypeId { get; set; }
    }

    public class MeetingDayTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public int MeetingDayTypeId { get; set; }
        public string ShortDescription { get; set; }
    }

    public class MeetingDayTypeGetByIds : IHasIdentifiers<Guid>
    {
        public MeetingDayTypeGetByIds() { }

        public MeetingDayTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class MeetingDayTypePost : EdFi.Ods.Api.Models.Resources.V2.MeetingDayType.MeetingDayType
    {
    }

    public class MeetingDayTypePut : EdFi.Ods.Api.Models.Resources.V2.MeetingDayType.MeetingDayType
    { 
    }

    public class MeetingDayTypeDelete : IHasIdentifier 
    {
        public MeetingDayTypeDelete() { }

        public MeetingDayTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.MethodCreditEarnedTypes
{ 
    public class MethodCreditEarnedTypeGetByKey
    {
        public int MethodCreditEarnedTypeId { get; set; }
    }

    public class MethodCreditEarnedTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public int MethodCreditEarnedTypeId { get; set; }
        public string ShortDescription { get; set; }
    }

    public class MethodCreditEarnedTypeGetByIds : IHasIdentifiers<Guid>
    {
        public MethodCreditEarnedTypeGetByIds() { }

        public MethodCreditEarnedTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class MethodCreditEarnedTypePost : EdFi.Ods.Api.Models.Resources.V2.MethodCreditEarnedType.MethodCreditEarnedType
    {
    }

    public class MethodCreditEarnedTypePut : EdFi.Ods.Api.Models.Resources.V2.MethodCreditEarnedType.MethodCreditEarnedType
    { 
    }

    public class MethodCreditEarnedTypeDelete : IHasIdentifier 
    {
        public MethodCreditEarnedTypeDelete() { }

        public MethodCreditEarnedTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.NetworkPurposeTypes
{ 
    public class NetworkPurposeTypeGetByKey
    {
        public int NetworkPurposeTypeId { get; set; }
    }

    public class NetworkPurposeTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public int NetworkPurposeTypeId { get; set; }
        public string ShortDescription { get; set; }
    }

    public class NetworkPurposeTypeGetByIds : IHasIdentifiers<Guid>
    {
        public NetworkPurposeTypeGetByIds() { }

        public NetworkPurposeTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class NetworkPurposeTypePost : EdFi.Ods.Api.Models.Resources.V2.NetworkPurposeType.NetworkPurposeType
    {
    }

    public class NetworkPurposeTypePut : EdFi.Ods.Api.Models.Resources.V2.NetworkPurposeType.NetworkPurposeType
    { 
    }

    public class NetworkPurposeTypeDelete : IHasIdentifier 
    {
        public NetworkPurposeTypeDelete() { }

        public NetworkPurposeTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.ObjectiveAssessments
{ 
    public class ObjectiveAssessmentGetByKey
    {
        public string AssessmentIdentifier { get; set; }
        public string IdentificationCode { get; set; }
        public string Namespace { get; set; }
    }

    public class ObjectiveAssessmentGetByExample
    {
        public string AssessmentIdentifier { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public string IdentificationCode { get; set; }
        public int MaxRawScore { get; set; }
        public string Namespace { get; set; }
        public string Nomenclature { get; set; }
        public string ParentIdentificationCode { get; set; }
        public decimal PercentOfAssessment { get; set; }
    }

    public class ObjectiveAssessmentGetByIds : IHasIdentifiers<Guid>
    {
        public ObjectiveAssessmentGetByIds() { }

        public ObjectiveAssessmentGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class ObjectiveAssessmentPost : EdFi.Ods.Api.Models.Resources.V2.ObjectiveAssessment.ObjectiveAssessment
    {
    }

    public class ObjectiveAssessmentPut : EdFi.Ods.Api.Models.Resources.V2.ObjectiveAssessment.ObjectiveAssessment
    { 
    }

    public class ObjectiveAssessmentDelete : IHasIdentifier 
    {
        public ObjectiveAssessmentDelete() { }

        public ObjectiveAssessmentDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.OldEthnicityTypes
{ 
    public class OldEthnicityTypeGetByKey
    {
        public int OldEthnicityTypeId { get; set; }
    }

    public class OldEthnicityTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public int OldEthnicityTypeId { get; set; }
        public string ShortDescription { get; set; }
    }

    public class OldEthnicityTypeGetByIds : IHasIdentifiers<Guid>
    {
        public OldEthnicityTypeGetByIds() { }

        public OldEthnicityTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class OldEthnicityTypePost : EdFi.Ods.Api.Models.Resources.V2.OldEthnicityType.OldEthnicityType
    {
    }

    public class OldEthnicityTypePut : EdFi.Ods.Api.Models.Resources.V2.OldEthnicityType.OldEthnicityType
    { 
    }

    public class OldEthnicityTypeDelete : IHasIdentifier 
    {
        public OldEthnicityTypeDelete() { }

        public OldEthnicityTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.OpenStaffPositions
{ 
    public class OpenStaffPositionGetByKey
    {
        public DateTime DatePosted { get; set; }
        public int EducationOrganizationId { get; set; }
        public string EmploymentStatusDescriptor { get; set; }
        public string RequisitionNumber { get; set; }
        public string StaffClassificationDescriptor { get; set; }
    }

    public class OpenStaffPositionGetByExample
    {
        public DateTime DatePosted { get; set; }
        public DateTime DatePostingRemoved { get; set; }
        public int EducationOrganizationId { get; set; }
        public string EmploymentStatusDescriptor { get; set; }
        public Guid Id { get; set; }
        public string PositionTitle { get; set; }
        public string PostingResultType { get; set; }
        public string ProgramAssignmentDescriptor { get; set; }
        public string RequisitionNumber { get; set; }
        public string StaffClassificationDescriptor { get; set; }
    }

    public class OpenStaffPositionGetByIds : IHasIdentifiers<Guid>
    {
        public OpenStaffPositionGetByIds() { }

        public OpenStaffPositionGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class OpenStaffPositionPost : EdFi.Ods.Api.Models.Resources.V2.OpenStaffPosition.OpenStaffPosition
    {
    }

    public class OpenStaffPositionPut : EdFi.Ods.Api.Models.Resources.V2.OpenStaffPosition.OpenStaffPosition
    { 
    }

    public class OpenStaffPositionDelete : IHasIdentifier 
    {
        public OpenStaffPositionDelete() { }

        public OpenStaffPositionDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.OperationalStatusTypes
{ 
    public class OperationalStatusTypeGetByKey
    {
        public int OperationalStatusTypeId { get; set; }
    }

    public class OperationalStatusTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public int OperationalStatusTypeId { get; set; }
        public string ShortDescription { get; set; }
    }

    public class OperationalStatusTypeGetByIds : IHasIdentifiers<Guid>
    {
        public OperationalStatusTypeGetByIds() { }

        public OperationalStatusTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class OperationalStatusTypePost : EdFi.Ods.Api.Models.Resources.V2.OperationalStatusType.OperationalStatusType
    {
    }

    public class OperationalStatusTypePut : EdFi.Ods.Api.Models.Resources.V2.OperationalStatusType.OperationalStatusType
    { 
    }

    public class OperationalStatusTypeDelete : IHasIdentifier 
    {
        public OperationalStatusTypeDelete() { }

        public OperationalStatusTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.OtherNameTypes
{ 
    public class OtherNameTypeGetByKey
    {
        public int OtherNameTypeId { get; set; }
    }

    public class OtherNameTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public int OtherNameTypeId { get; set; }
        public string ShortDescription { get; set; }
    }

    public class OtherNameTypeGetByIds : IHasIdentifiers<Guid>
    {
        public OtherNameTypeGetByIds() { }

        public OtherNameTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class OtherNameTypePost : EdFi.Ods.Api.Models.Resources.V2.OtherNameType.OtherNameType
    {
    }

    public class OtherNameTypePut : EdFi.Ods.Api.Models.Resources.V2.OtherNameType.OtherNameType
    { 
    }

    public class OtherNameTypeDelete : IHasIdentifier 
    {
        public OtherNameTypeDelete() { }

        public OtherNameTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.Parents
{ 
    public class ParentGetByKey
    {
        public string ParentUniqueId { get; set; }
    }

    public class ParentGetByExample
    {
        public string FirstName { get; set; }
        public string GenerationCodeSuffix { get; set; }
        public Guid Id { get; set; }
        public string LastSurname { get; set; }
        public string LoginId { get; set; }
        public string MaidenName { get; set; }
        public string MiddleName { get; set; }
        public string ParentUniqueId { get; set; }
        public string PersonalTitlePrefix { get; set; }
        public string SexType { get; set; }
    }

    public class ParentGetByIds : IHasIdentifiers<Guid>
    {
        public ParentGetByIds() { }

        public ParentGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class ParentPost : EdFi.Ods.Api.Models.Resources.V2.Parent.Parent
    {
    }

    public class ParentPut : EdFi.Ods.Api.Models.Resources.V2.Parent.Parent
    { 
    }

    public class ParentDelete : IHasIdentifier 
    {
        public ParentDelete() { }

        public ParentDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.Payrolls
{ 
    public class PayrollGetByKey
    {
        public string AccountNumber { get; set; }
        public DateTime AsOfDate { get; set; }
        public int EducationOrganizationId { get; set; }
        public int FiscalYear { get; set; }
        public string StaffUniqueId { get; set; }
    }

    public class PayrollGetByExample
    {
        public string AccountNumber { get; set; }
        public decimal AmountToDate { get; set; }
        public DateTime AsOfDate { get; set; }
        public int EducationOrganizationId { get; set; }
        public int FiscalYear { get; set; }
        public Guid Id { get; set; }
        public string StaffUniqueId { get; set; }
    }

    public class PayrollGetByIds : IHasIdentifiers<Guid>
    {
        public PayrollGetByIds() { }

        public PayrollGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class PayrollPost : EdFi.Ods.Api.Models.Resources.V2.Payroll.Payroll
    {
    }

    public class PayrollPut : EdFi.Ods.Api.Models.Resources.V2.Payroll.Payroll
    { 
    }

    public class PayrollDelete : IHasIdentifier 
    {
        public PayrollDelete() { }

        public PayrollDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.PerformanceBaseConversionTypes
{ 
    public class PerformanceBaseConversionTypeGetByKey
    {
        public int PerformanceBaseConversionTypeId { get; set; }
    }

    public class PerformanceBaseConversionTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public int PerformanceBaseConversionTypeId { get; set; }
        public string ShortDescription { get; set; }
    }

    public class PerformanceBaseConversionTypeGetByIds : IHasIdentifiers<Guid>
    {
        public PerformanceBaseConversionTypeGetByIds() { }

        public PerformanceBaseConversionTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class PerformanceBaseConversionTypePost : EdFi.Ods.Api.Models.Resources.V2.PerformanceBaseConversionType.PerformanceBaseConversionType
    {
    }

    public class PerformanceBaseConversionTypePut : EdFi.Ods.Api.Models.Resources.V2.PerformanceBaseConversionType.PerformanceBaseConversionType
    { 
    }

    public class PerformanceBaseConversionTypeDelete : IHasIdentifier 
    {
        public PerformanceBaseConversionTypeDelete() { }

        public PerformanceBaseConversionTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.PerformanceLevelDescriptors
{ 
    public class PerformanceLevelDescriptorGetByKey
    {
        public int PerformanceLevelDescriptorId { get; set; }
    }

    public class PerformanceLevelDescriptorGetByExample
    {
        public string PerformanceBaseConversionType { get; set; }
        public int PerformanceLevelDescriptorId { get; set; }
    }

    public class PerformanceLevelDescriptorGetByIds : IHasIdentifiers<Guid>
    {
        public PerformanceLevelDescriptorGetByIds() { }

        public PerformanceLevelDescriptorGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class PerformanceLevelDescriptorPost : EdFi.Ods.Api.Models.Resources.V2.PerformanceLevelDescriptor.PerformanceLevelDescriptor
    {
    }

    public class PerformanceLevelDescriptorPut : EdFi.Ods.Api.Models.Resources.V2.PerformanceLevelDescriptor.PerformanceLevelDescriptor
    { 
    }

    public class PerformanceLevelDescriptorDelete : IHasIdentifier 
    {
        public PerformanceLevelDescriptorDelete() { }

        public PerformanceLevelDescriptorDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.PersonalInformationVerificationTypes
{ 
    public class PersonalInformationVerificationTypeGetByKey
    {
        public int PersonalInformationVerificationTypeId { get; set; }
    }

    public class PersonalInformationVerificationTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public int PersonalInformationVerificationTypeId { get; set; }
        public string ShortDescription { get; set; }
    }

    public class PersonalInformationVerificationTypeGetByIds : IHasIdentifiers<Guid>
    {
        public PersonalInformationVerificationTypeGetByIds() { }

        public PersonalInformationVerificationTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class PersonalInformationVerificationTypePost : EdFi.Ods.Api.Models.Resources.V2.PersonalInformationVerificationType.PersonalInformationVerificationType
    {
    }

    public class PersonalInformationVerificationTypePut : EdFi.Ods.Api.Models.Resources.V2.PersonalInformationVerificationType.PersonalInformationVerificationType
    { 
    }

    public class PersonalInformationVerificationTypeDelete : IHasIdentifier 
    {
        public PersonalInformationVerificationTypeDelete() { }

        public PersonalInformationVerificationTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.PopulationServedTypes
{ 
    public class PopulationServedTypeGetByKey
    {
        public int PopulationServedTypeId { get; set; }
    }

    public class PopulationServedTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public int PopulationServedTypeId { get; set; }
        public string ShortDescription { get; set; }
    }

    public class PopulationServedTypeGetByIds : IHasIdentifiers<Guid>
    {
        public PopulationServedTypeGetByIds() { }

        public PopulationServedTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class PopulationServedTypePost : EdFi.Ods.Api.Models.Resources.V2.PopulationServedType.PopulationServedType
    {
    }

    public class PopulationServedTypePut : EdFi.Ods.Api.Models.Resources.V2.PopulationServedType.PopulationServedType
    { 
    }

    public class PopulationServedTypeDelete : IHasIdentifier 
    {
        public PopulationServedTypeDelete() { }

        public PopulationServedTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.PostingResultTypes
{ 
    public class PostingResultTypeGetByKey
    {
        public int PostingResultTypeId { get; set; }
    }

    public class PostingResultTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public int PostingResultTypeId { get; set; }
        public string ShortDescription { get; set; }
    }

    public class PostingResultTypeGetByIds : IHasIdentifiers<Guid>
    {
        public PostingResultTypeGetByIds() { }

        public PostingResultTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class PostingResultTypePost : EdFi.Ods.Api.Models.Resources.V2.PostingResultType.PostingResultType
    {
    }

    public class PostingResultTypePut : EdFi.Ods.Api.Models.Resources.V2.PostingResultType.PostingResultType
    { 
    }

    public class PostingResultTypeDelete : IHasIdentifier 
    {
        public PostingResultTypeDelete() { }

        public PostingResultTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.PostSecondaryEvents
{ 
    public class PostSecondaryEventGetByKey
    {
        public DateTime EventDate { get; set; }
        public string CategoryType { get; set; }
        public string StudentUniqueId { get; set; }
    }

    public class PostSecondaryEventGetByExample
    {
        public DateTime EventDate { get; set; }
        public Guid Id { get; set; }
        public string CategoryType { get; set; }
        public string StudentUniqueId { get; set; }
    }

    public class PostSecondaryEventGetByIds : IHasIdentifiers<Guid>
    {
        public PostSecondaryEventGetByIds() { }

        public PostSecondaryEventGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class PostSecondaryEventPost : EdFi.Ods.Api.Models.Resources.V2.PostSecondaryEvent.PostSecondaryEvent
    {
    }

    public class PostSecondaryEventPut : EdFi.Ods.Api.Models.Resources.V2.PostSecondaryEvent.PostSecondaryEvent
    { 
    }

    public class PostSecondaryEventDelete : IHasIdentifier 
    {
        public PostSecondaryEventDelete() { }

        public PostSecondaryEventDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.PostSecondaryEventCategoryTypes
{ 
    public class PostSecondaryEventCategoryTypeGetByKey
    {
        public int PostSecondaryEventCategoryTypeId { get; set; }
    }

    public class PostSecondaryEventCategoryTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public int PostSecondaryEventCategoryTypeId { get; set; }
        public string ShortDescription { get; set; }
    }

    public class PostSecondaryEventCategoryTypeGetByIds : IHasIdentifiers<Guid>
    {
        public PostSecondaryEventCategoryTypeGetByIds() { }

        public PostSecondaryEventCategoryTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class PostSecondaryEventCategoryTypePost : EdFi.Ods.Api.Models.Resources.V2.PostSecondaryEventCategoryType.PostSecondaryEventCategoryType
    {
    }

    public class PostSecondaryEventCategoryTypePut : EdFi.Ods.Api.Models.Resources.V2.PostSecondaryEventCategoryType.PostSecondaryEventCategoryType
    { 
    }

    public class PostSecondaryEventCategoryTypeDelete : IHasIdentifier 
    {
        public PostSecondaryEventCategoryTypeDelete() { }

        public PostSecondaryEventCategoryTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.PostSecondaryInstitutionLevelTypes
{ 
    public class PostSecondaryInstitutionLevelTypeGetByKey
    {
        public int PostSecondaryInstitutionLevelTypeId { get; set; }
    }

    public class PostSecondaryInstitutionLevelTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public int PostSecondaryInstitutionLevelTypeId { get; set; }
        public string ShortDescription { get; set; }
    }

    public class PostSecondaryInstitutionLevelTypeGetByIds : IHasIdentifiers<Guid>
    {
        public PostSecondaryInstitutionLevelTypeGetByIds() { }

        public PostSecondaryInstitutionLevelTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class PostSecondaryInstitutionLevelTypePost : EdFi.Ods.Api.Models.Resources.V2.PostSecondaryInstitutionLevelType.PostSecondaryInstitutionLevelType
    {
    }

    public class PostSecondaryInstitutionLevelTypePut : EdFi.Ods.Api.Models.Resources.V2.PostSecondaryInstitutionLevelType.PostSecondaryInstitutionLevelType
    { 
    }

    public class PostSecondaryInstitutionLevelTypeDelete : IHasIdentifier 
    {
        public PostSecondaryInstitutionLevelTypeDelete() { }

        public PostSecondaryInstitutionLevelTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.Programs
{ 
    public class ProgramGetByKey
    {
        public int EducationOrganizationId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
    }

    public class ProgramGetByExample
    {
        public int EducationOrganizationId { get; set; }
        public Guid Id { get; set; }
        public string ProgramId { get; set; }
        public string Name { get; set; }
        public string SponsorType { get; set; }
        public string Type { get; set; }
    }

    public class ProgramGetByIds : IHasIdentifiers<Guid>
    {
        public ProgramGetByIds() { }

        public ProgramGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class ProgramPost : EdFi.Ods.Api.Models.Resources.V2.Program.Program
    {
    }

    public class ProgramPut : EdFi.Ods.Api.Models.Resources.V2.Program.Program
    { 
    }

    public class ProgramDelete : IHasIdentifier 
    {
        public ProgramDelete() { }

        public ProgramDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.ProgramAssignmentDescriptors
{ 
    public class ProgramAssignmentDescriptorGetByKey
    {
        public int ProgramAssignmentDescriptorId { get; set; }
    }

    public class ProgramAssignmentDescriptorGetByExample
    {
        public int ProgramAssignmentDescriptorId { get; set; }
        public string ProgramAssignmentType { get; set; }
    }

    public class ProgramAssignmentDescriptorGetByIds : IHasIdentifiers<Guid>
    {
        public ProgramAssignmentDescriptorGetByIds() { }

        public ProgramAssignmentDescriptorGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class ProgramAssignmentDescriptorPost : EdFi.Ods.Api.Models.Resources.V2.ProgramAssignmentDescriptor.ProgramAssignmentDescriptor
    {
    }

    public class ProgramAssignmentDescriptorPut : EdFi.Ods.Api.Models.Resources.V2.ProgramAssignmentDescriptor.ProgramAssignmentDescriptor
    { 
    }

    public class ProgramAssignmentDescriptorDelete : IHasIdentifier 
    {
        public ProgramAssignmentDescriptorDelete() { }

        public ProgramAssignmentDescriptorDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.ProgramAssignmentTypes
{ 
    public class ProgramAssignmentTypeGetByKey
    {
        public int ProgramAssignmentTypeId { get; set; }
    }

    public class ProgramAssignmentTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public int ProgramAssignmentTypeId { get; set; }
        public string ShortDescription { get; set; }
    }

    public class ProgramAssignmentTypeGetByIds : IHasIdentifiers<Guid>
    {
        public ProgramAssignmentTypeGetByIds() { }

        public ProgramAssignmentTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class ProgramAssignmentTypePost : EdFi.Ods.Api.Models.Resources.V2.ProgramAssignmentType.ProgramAssignmentType
    {
    }

    public class ProgramAssignmentTypePut : EdFi.Ods.Api.Models.Resources.V2.ProgramAssignmentType.ProgramAssignmentType
    { 
    }

    public class ProgramAssignmentTypeDelete : IHasIdentifier 
    {
        public ProgramAssignmentTypeDelete() { }

        public ProgramAssignmentTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.ProgramCharacteristicDescriptors
{ 
    public class ProgramCharacteristicDescriptorGetByKey
    {
        public int ProgramCharacteristicDescriptorId { get; set; }
    }

    public class ProgramCharacteristicDescriptorGetByExample
    {
        public int ProgramCharacteristicDescriptorId { get; set; }
        public string ProgramCharacteristicType { get; set; }
    }

    public class ProgramCharacteristicDescriptorGetByIds : IHasIdentifiers<Guid>
    {
        public ProgramCharacteristicDescriptorGetByIds() { }

        public ProgramCharacteristicDescriptorGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class ProgramCharacteristicDescriptorPost : EdFi.Ods.Api.Models.Resources.V2.ProgramCharacteristicDescriptor.ProgramCharacteristicDescriptor
    {
    }

    public class ProgramCharacteristicDescriptorPut : EdFi.Ods.Api.Models.Resources.V2.ProgramCharacteristicDescriptor.ProgramCharacteristicDescriptor
    { 
    }

    public class ProgramCharacteristicDescriptorDelete : IHasIdentifier 
    {
        public ProgramCharacteristicDescriptorDelete() { }

        public ProgramCharacteristicDescriptorDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.ProgramCharacteristicTypes
{ 
    public class ProgramCharacteristicTypeGetByKey
    {
        public int ProgramCharacteristicTypeId { get; set; }
    }

    public class ProgramCharacteristicTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public int ProgramCharacteristicTypeId { get; set; }
        public string ShortDescription { get; set; }
    }

    public class ProgramCharacteristicTypeGetByIds : IHasIdentifiers<Guid>
    {
        public ProgramCharacteristicTypeGetByIds() { }

        public ProgramCharacteristicTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class ProgramCharacteristicTypePost : EdFi.Ods.Api.Models.Resources.V2.ProgramCharacteristicType.ProgramCharacteristicType
    {
    }

    public class ProgramCharacteristicTypePut : EdFi.Ods.Api.Models.Resources.V2.ProgramCharacteristicType.ProgramCharacteristicType
    { 
    }

    public class ProgramCharacteristicTypeDelete : IHasIdentifier 
    {
        public ProgramCharacteristicTypeDelete() { }

        public ProgramCharacteristicTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.ProgramSponsorTypes
{ 
    public class ProgramSponsorTypeGetByKey
    {
        public int ProgramSponsorTypeId { get; set; }
    }

    public class ProgramSponsorTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public int ProgramSponsorTypeId { get; set; }
        public string ShortDescription { get; set; }
    }

    public class ProgramSponsorTypeGetByIds : IHasIdentifiers<Guid>
    {
        public ProgramSponsorTypeGetByIds() { }

        public ProgramSponsorTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class ProgramSponsorTypePost : EdFi.Ods.Api.Models.Resources.V2.ProgramSponsorType.ProgramSponsorType
    {
    }

    public class ProgramSponsorTypePut : EdFi.Ods.Api.Models.Resources.V2.ProgramSponsorType.ProgramSponsorType
    { 
    }

    public class ProgramSponsorTypeDelete : IHasIdentifier 
    {
        public ProgramSponsorTypeDelete() { }

        public ProgramSponsorTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.ProgramTypes
{ 
    public class ProgramTypeGetByKey
    {
        public int ProgramTypeId { get; set; }
    }

    public class ProgramTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public int ProgramTypeId { get; set; }
        public string ShortDescription { get; set; }
    }

    public class ProgramTypeGetByIds : IHasIdentifiers<Guid>
    {
        public ProgramTypeGetByIds() { }

        public ProgramTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class ProgramTypePost : EdFi.Ods.Api.Models.Resources.V2.ProgramType.ProgramType
    {
    }

    public class ProgramTypePut : EdFi.Ods.Api.Models.Resources.V2.ProgramType.ProgramType
    { 
    }

    public class ProgramTypeDelete : IHasIdentifier 
    {
        public ProgramTypeDelete() { }

        public ProgramTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.PublicationStatusTypes
{ 
    public class PublicationStatusTypeGetByKey
    {
        public int PublicationStatusTypeId { get; set; }
    }

    public class PublicationStatusTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public int PublicationStatusTypeId { get; set; }
        public string ShortDescription { get; set; }
    }

    public class PublicationStatusTypeGetByIds : IHasIdentifiers<Guid>
    {
        public PublicationStatusTypeGetByIds() { }

        public PublicationStatusTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class PublicationStatusTypePost : EdFi.Ods.Api.Models.Resources.V2.PublicationStatusType.PublicationStatusType
    {
    }

    public class PublicationStatusTypePut : EdFi.Ods.Api.Models.Resources.V2.PublicationStatusType.PublicationStatusType
    { 
    }

    public class PublicationStatusTypeDelete : IHasIdentifier 
    {
        public PublicationStatusTypeDelete() { }

        public PublicationStatusTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.RaceTypes
{ 
    public class RaceTypeGetByKey
    {
        public int RaceTypeId { get; set; }
    }

    public class RaceTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public int RaceTypeId { get; set; }
        public string ShortDescription { get; set; }
    }

    public class RaceTypeGetByIds : IHasIdentifiers<Guid>
    {
        public RaceTypeGetByIds() { }

        public RaceTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class RaceTypePost : EdFi.Ods.Api.Models.Resources.V2.RaceType.RaceType
    {
    }

    public class RaceTypePut : EdFi.Ods.Api.Models.Resources.V2.RaceType.RaceType
    { 
    }

    public class RaceTypeDelete : IHasIdentifier 
    {
        public RaceTypeDelete() { }

        public RaceTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.ReasonExitedDescriptors
{ 
    public class ReasonExitedDescriptorGetByKey
    {
        public int ReasonExitedDescriptorId { get; set; }
    }

    public class ReasonExitedDescriptorGetByExample
    {
        public int ReasonExitedDescriptorId { get; set; }
        public string ReasonExitedType { get; set; }
    }

    public class ReasonExitedDescriptorGetByIds : IHasIdentifiers<Guid>
    {
        public ReasonExitedDescriptorGetByIds() { }

        public ReasonExitedDescriptorGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class ReasonExitedDescriptorPost : EdFi.Ods.Api.Models.Resources.V2.ReasonExitedDescriptor.ReasonExitedDescriptor
    {
    }

    public class ReasonExitedDescriptorPut : EdFi.Ods.Api.Models.Resources.V2.ReasonExitedDescriptor.ReasonExitedDescriptor
    { 
    }

    public class ReasonExitedDescriptorDelete : IHasIdentifier 
    {
        public ReasonExitedDescriptorDelete() { }

        public ReasonExitedDescriptorDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.ReasonExitedTypes
{ 
    public class ReasonExitedTypeGetByKey
    {
        public int ReasonExitedTypeId { get; set; }
    }

    public class ReasonExitedTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public int ReasonExitedTypeId { get; set; }
        public string ShortDescription { get; set; }
    }

    public class ReasonExitedTypeGetByIds : IHasIdentifiers<Guid>
    {
        public ReasonExitedTypeGetByIds() { }

        public ReasonExitedTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class ReasonExitedTypePost : EdFi.Ods.Api.Models.Resources.V2.ReasonExitedType.ReasonExitedType
    {
    }

    public class ReasonExitedTypePut : EdFi.Ods.Api.Models.Resources.V2.ReasonExitedType.ReasonExitedType
    { 
    }

    public class ReasonExitedTypeDelete : IHasIdentifier 
    {
        public ReasonExitedTypeDelete() { }

        public ReasonExitedTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.ReasonNotTestedTypes
{ 
    public class ReasonNotTestedTypeGetByKey
    {
        public int ReasonNotTestedTypeId { get; set; }
    }

    public class ReasonNotTestedTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public int ReasonNotTestedTypeId { get; set; }
        public string ShortDescription { get; set; }
    }

    public class ReasonNotTestedTypeGetByIds : IHasIdentifiers<Guid>
    {
        public ReasonNotTestedTypeGetByIds() { }

        public ReasonNotTestedTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class ReasonNotTestedTypePost : EdFi.Ods.Api.Models.Resources.V2.ReasonNotTestedType.ReasonNotTestedType
    {
    }

    public class ReasonNotTestedTypePut : EdFi.Ods.Api.Models.Resources.V2.ReasonNotTestedType.ReasonNotTestedType
    { 
    }

    public class ReasonNotTestedTypeDelete : IHasIdentifier 
    {
        public ReasonNotTestedTypeDelete() { }

        public ReasonNotTestedTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.RecognitionTypes
{ 
    public class RecognitionTypeGetByKey
    {
        public int RecognitionTypeId { get; set; }
    }

    public class RecognitionTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public int RecognitionTypeId { get; set; }
        public string ShortDescription { get; set; }
    }

    public class RecognitionTypeGetByIds : IHasIdentifiers<Guid>
    {
        public RecognitionTypeGetByIds() { }

        public RecognitionTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class RecognitionTypePost : EdFi.Ods.Api.Models.Resources.V2.RecognitionType.RecognitionType
    {
    }

    public class RecognitionTypePut : EdFi.Ods.Api.Models.Resources.V2.RecognitionType.RecognitionType
    { 
    }

    public class RecognitionTypeDelete : IHasIdentifier 
    {
        public RecognitionTypeDelete() { }

        public RecognitionTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.RelationTypes
{ 
    public class RelationTypeGetByKey
    {
        public int RelationTypeId { get; set; }
    }

    public class RelationTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public int RelationTypeId { get; set; }
        public string ShortDescription { get; set; }
    }

    public class RelationTypeGetByIds : IHasIdentifiers<Guid>
    {
        public RelationTypeGetByIds() { }

        public RelationTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class RelationTypePost : EdFi.Ods.Api.Models.Resources.V2.RelationType.RelationType
    {
    }

    public class RelationTypePut : EdFi.Ods.Api.Models.Resources.V2.RelationType.RelationType
    { 
    }

    public class RelationTypeDelete : IHasIdentifier 
    {
        public RelationTypeDelete() { }

        public RelationTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.RepeatIdentifierTypes
{ 
    public class RepeatIdentifierTypeGetByKey
    {
        public int RepeatIdentifierTypeId { get; set; }
    }

    public class RepeatIdentifierTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public int RepeatIdentifierTypeId { get; set; }
        public string ShortDescription { get; set; }
    }

    public class RepeatIdentifierTypeGetByIds : IHasIdentifiers<Guid>
    {
        public RepeatIdentifierTypeGetByIds() { }

        public RepeatIdentifierTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class RepeatIdentifierTypePost : EdFi.Ods.Api.Models.Resources.V2.RepeatIdentifierType.RepeatIdentifierType
    {
    }

    public class RepeatIdentifierTypePut : EdFi.Ods.Api.Models.Resources.V2.RepeatIdentifierType.RepeatIdentifierType
    { 
    }

    public class RepeatIdentifierTypeDelete : IHasIdentifier 
    {
        public RepeatIdentifierTypeDelete() { }

        public RepeatIdentifierTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.ReportCards
{ 
    public class ReportCardGetByKey
    {
        public int EducationOrganizationId { get; set; }
        public DateTime GradingPeriodBeginDate { get; set; }
        public string GradingPeriodDescriptor { get; set; }
        public int SchoolId { get; set; }
        public string StudentUniqueId { get; set; }
    }

    public class ReportCardGetByExample
    {
        public int EducationOrganizationId { get; set; }
        public decimal GPACumulative { get; set; }
        public decimal GPAGivenGradingPeriod { get; set; }
        public DateTime GradingPeriodBeginDate { get; set; }
        public string GradingPeriodDescriptor { get; set; }
        public Guid Id { get; set; }
        public decimal NumberOfDaysAbsent { get; set; }
        public decimal NumberOfDaysInAttendance { get; set; }
        public int NumberOfDaysTardy { get; set; }
        public int SchoolId { get; set; }
        public string StudentUniqueId { get; set; }
    }

    public class ReportCardGetByIds : IHasIdentifiers<Guid>
    {
        public ReportCardGetByIds() { }

        public ReportCardGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class ReportCardPost : EdFi.Ods.Api.Models.Resources.V2.ReportCard.ReportCard
    {
    }

    public class ReportCardPut : EdFi.Ods.Api.Models.Resources.V2.ReportCard.ReportCard
    { 
    }

    public class ReportCardDelete : IHasIdentifier 
    {
        public ReportCardDelete() { }

        public ReportCardDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.ReporterDescriptionDescriptors
{ 
    public class ReporterDescriptionDescriptorGetByKey
    {
        public int ReporterDescriptionDescriptorId { get; set; }
    }

    public class ReporterDescriptionDescriptorGetByExample
    {
        public int ReporterDescriptionDescriptorId { get; set; }
        public string ReporterDescriptionType { get; set; }
    }

    public class ReporterDescriptionDescriptorGetByIds : IHasIdentifiers<Guid>
    {
        public ReporterDescriptionDescriptorGetByIds() { }

        public ReporterDescriptionDescriptorGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class ReporterDescriptionDescriptorPost : EdFi.Ods.Api.Models.Resources.V2.ReporterDescriptionDescriptor.ReporterDescriptionDescriptor
    {
    }

    public class ReporterDescriptionDescriptorPut : EdFi.Ods.Api.Models.Resources.V2.ReporterDescriptionDescriptor.ReporterDescriptionDescriptor
    { 
    }

    public class ReporterDescriptionDescriptorDelete : IHasIdentifier 
    {
        public ReporterDescriptionDescriptorDelete() { }

        public ReporterDescriptionDescriptorDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.ReporterDescriptionTypes
{ 
    public class ReporterDescriptionTypeGetByKey
    {
        public int ReporterDescriptionTypeId { get; set; }
    }

    public class ReporterDescriptionTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public int ReporterDescriptionTypeId { get; set; }
        public string ShortDescription { get; set; }
    }

    public class ReporterDescriptionTypeGetByIds : IHasIdentifiers<Guid>
    {
        public ReporterDescriptionTypeGetByIds() { }

        public ReporterDescriptionTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class ReporterDescriptionTypePost : EdFi.Ods.Api.Models.Resources.V2.ReporterDescriptionType.ReporterDescriptionType
    {
    }

    public class ReporterDescriptionTypePut : EdFi.Ods.Api.Models.Resources.V2.ReporterDescriptionType.ReporterDescriptionType
    { 
    }

    public class ReporterDescriptionTypeDelete : IHasIdentifier 
    {
        public ReporterDescriptionTypeDelete() { }

        public ReporterDescriptionTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.ResidencyStatusDescriptors
{ 
    public class ResidencyStatusDescriptorGetByKey
    {
        public int ResidencyStatusDescriptorId { get; set; }
    }

    public class ResidencyStatusDescriptorGetByExample
    {
        public int ResidencyStatusDescriptorId { get; set; }
        public string ResidencyStatusType { get; set; }
    }

    public class ResidencyStatusDescriptorGetByIds : IHasIdentifiers<Guid>
    {
        public ResidencyStatusDescriptorGetByIds() { }

        public ResidencyStatusDescriptorGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class ResidencyStatusDescriptorPost : EdFi.Ods.Api.Models.Resources.V2.ResidencyStatusDescriptor.ResidencyStatusDescriptor
    {
    }

    public class ResidencyStatusDescriptorPut : EdFi.Ods.Api.Models.Resources.V2.ResidencyStatusDescriptor.ResidencyStatusDescriptor
    { 
    }

    public class ResidencyStatusDescriptorDelete : IHasIdentifier 
    {
        public ResidencyStatusDescriptorDelete() { }

        public ResidencyStatusDescriptorDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.ResidencyStatusTypes
{ 
    public class ResidencyStatusTypeGetByKey
    {
        public int ResidencyStatusTypeId { get; set; }
    }

    public class ResidencyStatusTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public int ResidencyStatusTypeId { get; set; }
        public string ShortDescription { get; set; }
    }

    public class ResidencyStatusTypeGetByIds : IHasIdentifiers<Guid>
    {
        public ResidencyStatusTypeGetByIds() { }

        public ResidencyStatusTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class ResidencyStatusTypePost : EdFi.Ods.Api.Models.Resources.V2.ResidencyStatusType.ResidencyStatusType
    {
    }

    public class ResidencyStatusTypePut : EdFi.Ods.Api.Models.Resources.V2.ResidencyStatusType.ResidencyStatusType
    { 
    }

    public class ResidencyStatusTypeDelete : IHasIdentifier 
    {
        public ResidencyStatusTypeDelete() { }

        public ResidencyStatusTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.ResponseIndicatorTypes
{ 
    public class ResponseIndicatorTypeGetByKey
    {
        public int ResponseIndicatorTypeId { get; set; }
    }

    public class ResponseIndicatorTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public int ResponseIndicatorTypeId { get; set; }
        public string ShortDescription { get; set; }
    }

    public class ResponseIndicatorTypeGetByIds : IHasIdentifiers<Guid>
    {
        public ResponseIndicatorTypeGetByIds() { }

        public ResponseIndicatorTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class ResponseIndicatorTypePost : EdFi.Ods.Api.Models.Resources.V2.ResponseIndicatorType.ResponseIndicatorType
    {
    }

    public class ResponseIndicatorTypePut : EdFi.Ods.Api.Models.Resources.V2.ResponseIndicatorType.ResponseIndicatorType
    { 
    }

    public class ResponseIndicatorTypeDelete : IHasIdentifier 
    {
        public ResponseIndicatorTypeDelete() { }

        public ResponseIndicatorTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.ResponsibilityDescriptors
{ 
    public class ResponsibilityDescriptorGetByKey
    {
        public int ResponsibilityDescriptorId { get; set; }
    }

    public class ResponsibilityDescriptorGetByExample
    {
        public int ResponsibilityDescriptorId { get; set; }
        public string ResponsibilityType { get; set; }
    }

    public class ResponsibilityDescriptorGetByIds : IHasIdentifiers<Guid>
    {
        public ResponsibilityDescriptorGetByIds() { }

        public ResponsibilityDescriptorGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class ResponsibilityDescriptorPost : EdFi.Ods.Api.Models.Resources.V2.ResponsibilityDescriptor.ResponsibilityDescriptor
    {
    }

    public class ResponsibilityDescriptorPut : EdFi.Ods.Api.Models.Resources.V2.ResponsibilityDescriptor.ResponsibilityDescriptor
    { 
    }

    public class ResponsibilityDescriptorDelete : IHasIdentifier 
    {
        public ResponsibilityDescriptorDelete() { }

        public ResponsibilityDescriptorDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.ResponsibilityTypes
{ 
    public class ResponsibilityTypeGetByKey
    {
        public int ResponsibilityTypeId { get; set; }
    }

    public class ResponsibilityTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public int ResponsibilityTypeId { get; set; }
        public string ShortDescription { get; set; }
    }

    public class ResponsibilityTypeGetByIds : IHasIdentifiers<Guid>
    {
        public ResponsibilityTypeGetByIds() { }

        public ResponsibilityTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class ResponsibilityTypePost : EdFi.Ods.Api.Models.Resources.V2.ResponsibilityType.ResponsibilityType
    {
    }

    public class ResponsibilityTypePut : EdFi.Ods.Api.Models.Resources.V2.ResponsibilityType.ResponsibilityType
    { 
    }

    public class ResponsibilityTypeDelete : IHasIdentifier 
    {
        public ResponsibilityTypeDelete() { }

        public ResponsibilityTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.RestraintEvents
{ 
    public class RestraintEventGetByKey
    {
        public DateTime EventDate { get; set; }
        public string Identifier { get; set; }
        public int SchoolId { get; set; }
        public string StudentUniqueId { get; set; }
    }

    public class RestraintEventGetByExample
    {
        public string EducationalEnvironmentType { get; set; }
        public DateTime EventDate { get; set; }
        public Guid Id { get; set; }
        public string Identifier { get; set; }
        public int SchoolId { get; set; }
        public string StudentUniqueId { get; set; }
    }

    public class RestraintEventGetByIds : IHasIdentifiers<Guid>
    {
        public RestraintEventGetByIds() { }

        public RestraintEventGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class RestraintEventPost : EdFi.Ods.Api.Models.Resources.V2.RestraintEvent.RestraintEvent
    {
    }

    public class RestraintEventPut : EdFi.Ods.Api.Models.Resources.V2.RestraintEvent.RestraintEvent
    { 
    }

    public class RestraintEventDelete : IHasIdentifier 
    {
        public RestraintEventDelete() { }

        public RestraintEventDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.RestraintEventReasonTypes
{ 
    public class RestraintEventReasonTypeGetByKey
    {
        public int RestraintEventReasonTypeId { get; set; }
    }

    public class RestraintEventReasonTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public int RestraintEventReasonTypeId { get; set; }
        public string ShortDescription { get; set; }
    }

    public class RestraintEventReasonTypeGetByIds : IHasIdentifiers<Guid>
    {
        public RestraintEventReasonTypeGetByIds() { }

        public RestraintEventReasonTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class RestraintEventReasonTypePost : EdFi.Ods.Api.Models.Resources.V2.RestraintEventReasonType.RestraintEventReasonType
    {
    }

    public class RestraintEventReasonTypePut : EdFi.Ods.Api.Models.Resources.V2.RestraintEventReasonType.RestraintEventReasonType
    { 
    }

    public class RestraintEventReasonTypeDelete : IHasIdentifier 
    {
        public RestraintEventReasonTypeDelete() { }

        public RestraintEventReasonTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.ResultDatatypeTypes
{ 
    public class ResultDatatypeTypeGetByKey
    {
        public int ResultDatatypeTypeId { get; set; }
    }

    public class ResultDatatypeTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public int ResultDatatypeTypeId { get; set; }
        public string ShortDescription { get; set; }
    }

    public class ResultDatatypeTypeGetByIds : IHasIdentifiers<Guid>
    {
        public ResultDatatypeTypeGetByIds() { }

        public ResultDatatypeTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class ResultDatatypeTypePost : EdFi.Ods.Api.Models.Resources.V2.ResultDatatypeType.ResultDatatypeType
    {
    }

    public class ResultDatatypeTypePut : EdFi.Ods.Api.Models.Resources.V2.ResultDatatypeType.ResultDatatypeType
    { 
    }

    public class ResultDatatypeTypeDelete : IHasIdentifier 
    {
        public ResultDatatypeTypeDelete() { }

        public ResultDatatypeTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.RetestIndicatorTypes
{ 
    public class RetestIndicatorTypeGetByKey
    {
        public int RetestIndicatorTypeId { get; set; }
    }

    public class RetestIndicatorTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public int RetestIndicatorTypeId { get; set; }
        public string ShortDescription { get; set; }
    }

    public class RetestIndicatorTypeGetByIds : IHasIdentifiers<Guid>
    {
        public RetestIndicatorTypeGetByIds() { }

        public RetestIndicatorTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class RetestIndicatorTypePost : EdFi.Ods.Api.Models.Resources.V2.RetestIndicatorType.RetestIndicatorType
    {
    }

    public class RetestIndicatorTypePut : EdFi.Ods.Api.Models.Resources.V2.RetestIndicatorType.RetestIndicatorType
    { 
    }

    public class RetestIndicatorTypeDelete : IHasIdentifier 
    {
        public RetestIndicatorTypeDelete() { }

        public RetestIndicatorTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.Schools
{ 
    public class SchoolGetByKey
    {
        public int SchoolId { get; set; }
    }

    public class SchoolGetByExample
    {
        public string AdministrativeFundingControlDescriptor { get; set; }
        public string CharterApprovalAgencyType { get; set; }
        public short CharterApprovalSchoolYear { get; set; }
        public string CharterStatusType { get; set; }
        public string InternetAccessType { get; set; }
        public int LocalEducationAgencyId { get; set; }
        public string MagnetSpecialProgramEmphasisSchoolType { get; set; }
        public int SchoolId { get; set; }
        public string Type { get; set; }
        public string TitleIPartASchoolDesignationType { get; set; }
    }

    public class SchoolGetByIds : IHasIdentifiers<Guid>
    {
        public SchoolGetByIds() { }

        public SchoolGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class SchoolPost : EdFi.Ods.Api.Models.Resources.V2.School.School
    {
    }

    public class SchoolPut : EdFi.Ods.Api.Models.Resources.V2.School.School
    { 
    }

    public class SchoolDelete : IHasIdentifier 
    {
        public SchoolDelete() { }

        public SchoolDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.SchoolCategoryTypes
{ 
    public class SchoolCategoryTypeGetByKey
    {
        public int SchoolCategoryTypeId { get; set; }
    }

    public class SchoolCategoryTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public int SchoolCategoryTypeId { get; set; }
        public string ShortDescription { get; set; }
    }

    public class SchoolCategoryTypeGetByIds : IHasIdentifiers<Guid>
    {
        public SchoolCategoryTypeGetByIds() { }

        public SchoolCategoryTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class SchoolCategoryTypePost : EdFi.Ods.Api.Models.Resources.V2.SchoolCategoryType.SchoolCategoryType
    {
    }

    public class SchoolCategoryTypePut : EdFi.Ods.Api.Models.Resources.V2.SchoolCategoryType.SchoolCategoryType
    { 
    }

    public class SchoolCategoryTypeDelete : IHasIdentifier 
    {
        public SchoolCategoryTypeDelete() { }

        public SchoolCategoryTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.SchoolChoiceImplementStatusTypes
{ 
    public class SchoolChoiceImplementStatusTypeGetByKey
    {
        public int SchoolChoiceImplementStatusTypeId { get; set; }
    }

    public class SchoolChoiceImplementStatusTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public int SchoolChoiceImplementStatusTypeId { get; set; }
        public string ShortDescription { get; set; }
    }

    public class SchoolChoiceImplementStatusTypeGetByIds : IHasIdentifiers<Guid>
    {
        public SchoolChoiceImplementStatusTypeGetByIds() { }

        public SchoolChoiceImplementStatusTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class SchoolChoiceImplementStatusTypePost : EdFi.Ods.Api.Models.Resources.V2.SchoolChoiceImplementStatusType.SchoolChoiceImplementStatusType
    {
    }

    public class SchoolChoiceImplementStatusTypePut : EdFi.Ods.Api.Models.Resources.V2.SchoolChoiceImplementStatusType.SchoolChoiceImplementStatusType
    { 
    }

    public class SchoolChoiceImplementStatusTypeDelete : IHasIdentifier 
    {
        public SchoolChoiceImplementStatusTypeDelete() { }

        public SchoolChoiceImplementStatusTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.SchoolFoodServicesEligibilityDescriptors
{ 
    public class SchoolFoodServicesEligibilityDescriptorGetByKey
    {
        public int SchoolFoodServicesEligibilityDescriptorId { get; set; }
    }

    public class SchoolFoodServicesEligibilityDescriptorGetByExample
    {
        public int SchoolFoodServicesEligibilityDescriptorId { get; set; }
        public string SchoolFoodServicesEligibilityType { get; set; }
    }

    public class SchoolFoodServicesEligibilityDescriptorGetByIds : IHasIdentifiers<Guid>
    {
        public SchoolFoodServicesEligibilityDescriptorGetByIds() { }

        public SchoolFoodServicesEligibilityDescriptorGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class SchoolFoodServicesEligibilityDescriptorPost : EdFi.Ods.Api.Models.Resources.V2.SchoolFoodServicesEligibilityDescriptor.SchoolFoodServicesEligibilityDescriptor
    {
    }

    public class SchoolFoodServicesEligibilityDescriptorPut : EdFi.Ods.Api.Models.Resources.V2.SchoolFoodServicesEligibilityDescriptor.SchoolFoodServicesEligibilityDescriptor
    { 
    }

    public class SchoolFoodServicesEligibilityDescriptorDelete : IHasIdentifier 
    {
        public SchoolFoodServicesEligibilityDescriptorDelete() { }

        public SchoolFoodServicesEligibilityDescriptorDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.SchoolFoodServicesEligibilityTypes
{ 
    public class SchoolFoodServicesEligibilityTypeGetByKey
    {
        public int SchoolFoodServicesEligibilityTypeId { get; set; }
    }

    public class SchoolFoodServicesEligibilityTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public int SchoolFoodServicesEligibilityTypeId { get; set; }
        public string ShortDescription { get; set; }
    }

    public class SchoolFoodServicesEligibilityTypeGetByIds : IHasIdentifiers<Guid>
    {
        public SchoolFoodServicesEligibilityTypeGetByIds() { }

        public SchoolFoodServicesEligibilityTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class SchoolFoodServicesEligibilityTypePost : EdFi.Ods.Api.Models.Resources.V2.SchoolFoodServicesEligibilityType.SchoolFoodServicesEligibilityType
    {
    }

    public class SchoolFoodServicesEligibilityTypePut : EdFi.Ods.Api.Models.Resources.V2.SchoolFoodServicesEligibilityType.SchoolFoodServicesEligibilityType
    { 
    }

    public class SchoolFoodServicesEligibilityTypeDelete : IHasIdentifier 
    {
        public SchoolFoodServicesEligibilityTypeDelete() { }

        public SchoolFoodServicesEligibilityTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.SchoolTypes
{ 
    public class SchoolTypeGetByKey
    {
        public int SchoolTypeId { get; set; }
    }

    public class SchoolTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public int SchoolTypeId { get; set; }
        public string ShortDescription { get; set; }
    }

    public class SchoolTypeGetByIds : IHasIdentifiers<Guid>
    {
        public SchoolTypeGetByIds() { }

        public SchoolTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class SchoolTypePost : EdFi.Ods.Api.Models.Resources.V2.SchoolType.SchoolType
    {
    }

    public class SchoolTypePut : EdFi.Ods.Api.Models.Resources.V2.SchoolType.SchoolType
    { 
    }

    public class SchoolTypeDelete : IHasIdentifier 
    {
        public SchoolTypeDelete() { }

        public SchoolTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.SchoolYearTypes
{ 
    public class SchoolYearTypeGetByKey
    {
        public short SchoolYear { get; set; }
    }

    public class SchoolYearTypeGetByExample
    {
        public bool CurrentSchoolYear { get; set; }
        public Guid Id { get; set; }
        public short SchoolYear { get; set; }
        public string SchoolYearDescription { get; set; }
    }

    public class SchoolYearTypeGetByIds : IHasIdentifiers<Guid>
    {
        public SchoolYearTypeGetByIds() { }

        public SchoolYearTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class SchoolYearTypePost : EdFi.Ods.Api.Models.Resources.V2.SchoolYearType.SchoolYearType
    {
    }

    public class SchoolYearTypePut : EdFi.Ods.Api.Models.Resources.V2.SchoolYearType.SchoolYearType
    { 
    }

    public class SchoolYearTypeDelete : IHasIdentifier 
    {
        public SchoolYearTypeDelete() { }

        public SchoolYearTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.Sections
{ 
    public class SectionGetByKey
    {
        public string ClassPeriodName { get; set; }
        public string ClassroomIdentificationCode { get; set; }
        public string LocalCourseCode { get; set; }
        public int SchoolId { get; set; }
        public short SchoolYear { get; set; }
        public int SequenceOfCourse { get; set; }
        public string TermDescriptor { get; set; }
        public string UniqueSectionCode { get; set; }
    }

    public class SectionGetByExample
    {
        public decimal AvailableCreditConversion { get; set; }
        public decimal AvailableCredits { get; set; }
        public string AvailableCreditType { get; set; }
        public string ClassPeriodName { get; set; }
        public string ClassroomIdentificationCode { get; set; }
        public string EducationalEnvironmentType { get; set; }
        public Guid Id { get; set; }
        public string InstructionLanguageDescriptor { get; set; }
        public string LocalCourseCode { get; set; }
        public string MediumOfInstructionType { get; set; }
        public string PopulationServedType { get; set; }
        public int SchoolId { get; set; }
        public short SchoolYear { get; set; }
        public int SequenceOfCourse { get; set; }
        public string TermDescriptor { get; set; }
        public string UniqueSectionCode { get; set; }
    }

    public class SectionGetByIds : IHasIdentifiers<Guid>
    {
        public SectionGetByIds() { }

        public SectionGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class SectionPost : EdFi.Ods.Api.Models.Resources.V2.Section.Section
    {
    }

    public class SectionPut : EdFi.Ods.Api.Models.Resources.V2.Section.Section
    { 
    }

    public class SectionDelete : IHasIdentifier 
    {
        public SectionDelete() { }

        public SectionDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.SectionAttendanceTakenEvents
{ 
    public class SectionAttendanceTakenEventGetByKey
    {
        public string ClassPeriodName { get; set; }
        public string ClassroomIdentificationCode { get; set; }
        public DateTime Date { get; set; }
        public string LocalCourseCode { get; set; }
        public int SchoolId { get; set; }
        public short SchoolYear { get; set; }
        public int SequenceOfCourse { get; set; }
        public string TermDescriptor { get; set; }
        public string UniqueSectionCode { get; set; }
    }

    public class SectionAttendanceTakenEventGetByExample
    {
        public string ClassPeriodName { get; set; }
        public string ClassroomIdentificationCode { get; set; }
        public DateTime Date { get; set; }
        public DateTime EventDate { get; set; }
        public Guid Id { get; set; }
        public string LocalCourseCode { get; set; }
        public int SchoolId { get; set; }
        public short SchoolYear { get; set; }
        public int SequenceOfCourse { get; set; }
        public string StaffUniqueId { get; set; }
        public string TermDescriptor { get; set; }
        public string UniqueSectionCode { get; set; }
    }

    public class SectionAttendanceTakenEventGetByIds : IHasIdentifiers<Guid>
    {
        public SectionAttendanceTakenEventGetByIds() { }

        public SectionAttendanceTakenEventGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class SectionAttendanceTakenEventPost : EdFi.Ods.Api.Models.Resources.V2.SectionAttendanceTakenEvent.SectionAttendanceTakenEvent
    {
    }

    public class SectionAttendanceTakenEventPut : EdFi.Ods.Api.Models.Resources.V2.SectionAttendanceTakenEvent.SectionAttendanceTakenEvent
    { 
    }

    public class SectionAttendanceTakenEventDelete : IHasIdentifier 
    {
        public SectionAttendanceTakenEventDelete() { }

        public SectionAttendanceTakenEventDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.SectionCharacteristicDescriptors
{ 
    public class SectionCharacteristicDescriptorGetByKey
    {
        public int SectionCharacteristicDescriptorId { get; set; }
    }

    public class SectionCharacteristicDescriptorGetByExample
    {
        public int SectionCharacteristicDescriptorId { get; set; }
        public string SectionCharacteristicType { get; set; }
    }

    public class SectionCharacteristicDescriptorGetByIds : IHasIdentifiers<Guid>
    {
        public SectionCharacteristicDescriptorGetByIds() { }

        public SectionCharacteristicDescriptorGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class SectionCharacteristicDescriptorPost : EdFi.Ods.Api.Models.Resources.V2.SectionCharacteristicDescriptor.SectionCharacteristicDescriptor
    {
    }

    public class SectionCharacteristicDescriptorPut : EdFi.Ods.Api.Models.Resources.V2.SectionCharacteristicDescriptor.SectionCharacteristicDescriptor
    { 
    }

    public class SectionCharacteristicDescriptorDelete : IHasIdentifier 
    {
        public SectionCharacteristicDescriptorDelete() { }

        public SectionCharacteristicDescriptorDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.SectionCharacteristicTypes
{ 
    public class SectionCharacteristicTypeGetByKey
    {
        public int SectionCharacteristicTypeId { get; set; }
    }

    public class SectionCharacteristicTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public int SectionCharacteristicTypeId { get; set; }
        public string ShortDescription { get; set; }
    }

    public class SectionCharacteristicTypeGetByIds : IHasIdentifiers<Guid>
    {
        public SectionCharacteristicTypeGetByIds() { }

        public SectionCharacteristicTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class SectionCharacteristicTypePost : EdFi.Ods.Api.Models.Resources.V2.SectionCharacteristicType.SectionCharacteristicType
    {
    }

    public class SectionCharacteristicTypePut : EdFi.Ods.Api.Models.Resources.V2.SectionCharacteristicType.SectionCharacteristicType
    { 
    }

    public class SectionCharacteristicTypeDelete : IHasIdentifier 
    {
        public SectionCharacteristicTypeDelete() { }

        public SectionCharacteristicTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.SeparationReasonDescriptors
{ 
    public class SeparationReasonDescriptorGetByKey
    {
        public int SeparationReasonDescriptorId { get; set; }
    }

    public class SeparationReasonDescriptorGetByExample
    {
        public int SeparationReasonDescriptorId { get; set; }
        public string SeparationReasonType { get; set; }
    }

    public class SeparationReasonDescriptorGetByIds : IHasIdentifiers<Guid>
    {
        public SeparationReasonDescriptorGetByIds() { }

        public SeparationReasonDescriptorGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class SeparationReasonDescriptorPost : EdFi.Ods.Api.Models.Resources.V2.SeparationReasonDescriptor.SeparationReasonDescriptor
    {
    }

    public class SeparationReasonDescriptorPut : EdFi.Ods.Api.Models.Resources.V2.SeparationReasonDescriptor.SeparationReasonDescriptor
    { 
    }

    public class SeparationReasonDescriptorDelete : IHasIdentifier 
    {
        public SeparationReasonDescriptorDelete() { }

        public SeparationReasonDescriptorDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.SeparationReasonTypes
{ 
    public class SeparationReasonTypeGetByKey
    {
        public int SeparationReasonTypeId { get; set; }
    }

    public class SeparationReasonTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public int SeparationReasonTypeId { get; set; }
        public string ShortDescription { get; set; }
    }

    public class SeparationReasonTypeGetByIds : IHasIdentifiers<Guid>
    {
        public SeparationReasonTypeGetByIds() { }

        public SeparationReasonTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class SeparationReasonTypePost : EdFi.Ods.Api.Models.Resources.V2.SeparationReasonType.SeparationReasonType
    {
    }

    public class SeparationReasonTypePut : EdFi.Ods.Api.Models.Resources.V2.SeparationReasonType.SeparationReasonType
    { 
    }

    public class SeparationReasonTypeDelete : IHasIdentifier 
    {
        public SeparationReasonTypeDelete() { }

        public SeparationReasonTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.SeparationTypes
{ 
    public class SeparationTypeGetByKey
    {
        public int SeparationTypeId { get; set; }
    }

    public class SeparationTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public int SeparationTypeId { get; set; }
        public string ShortDescription { get; set; }
    }

    public class SeparationTypeGetByIds : IHasIdentifiers<Guid>
    {
        public SeparationTypeGetByIds() { }

        public SeparationTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class SeparationTypePost : EdFi.Ods.Api.Models.Resources.V2.SeparationType.SeparationType
    {
    }

    public class SeparationTypePut : EdFi.Ods.Api.Models.Resources.V2.SeparationType.SeparationType
    { 
    }

    public class SeparationTypeDelete : IHasIdentifier 
    {
        public SeparationTypeDelete() { }

        public SeparationTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.ServiceDescriptors
{ 
    public class ServiceDescriptorGetByKey
    {
        public int ServiceDescriptorId { get; set; }
    }

    public class ServiceDescriptorGetByExample
    {
        public string ServiceCategory { get; set; }
        public int ServiceDescriptorId { get; set; }
    }

    public class ServiceDescriptorGetByIds : IHasIdentifiers<Guid>
    {
        public ServiceDescriptorGetByIds() { }

        public ServiceDescriptorGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class ServiceDescriptorPost : EdFi.Ods.Api.Models.Resources.V2.ServiceDescriptor.ServiceDescriptor
    {
    }

    public class ServiceDescriptorPut : EdFi.Ods.Api.Models.Resources.V2.ServiceDescriptor.ServiceDescriptor
    { 
    }

    public class ServiceDescriptorDelete : IHasIdentifier 
    {
        public ServiceDescriptorDelete() { }

        public ServiceDescriptorDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.Sessions
{ 
    public class SessionGetByKey
    {
        public int SchoolId { get; set; }
        public short SchoolYear { get; set; }
        public string TermDescriptor { get; set; }
    }

    public class SessionGetByExample
    {
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid Id { get; set; }
        public int SchoolId { get; set; }
        public short SchoolYear { get; set; }
        public string Name { get; set; }
        public string TermDescriptor { get; set; }
        public int TotalInstructionalDays { get; set; }
    }

    public class SessionGetByIds : IHasIdentifiers<Guid>
    {
        public SessionGetByIds() { }

        public SessionGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class SessionPost : EdFi.Ods.Api.Models.Resources.V2.Session.Session
    {
    }

    public class SessionPut : EdFi.Ods.Api.Models.Resources.V2.Session.Session
    { 
    }

    public class SessionDelete : IHasIdentifier 
    {
        public SessionDelete() { }

        public SessionDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.SexTypes
{ 
    public class SexTypeGetByKey
    {
        public int SexTypeId { get; set; }
    }

    public class SexTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public int SexTypeId { get; set; }
        public string ShortDescription { get; set; }
    }

    public class SexTypeGetByIds : IHasIdentifiers<Guid>
    {
        public SexTypeGetByIds() { }

        public SexTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class SexTypePost : EdFi.Ods.Api.Models.Resources.V2.SexType.SexType
    {
    }

    public class SexTypePut : EdFi.Ods.Api.Models.Resources.V2.SexType.SexType
    { 
    }

    public class SexTypeDelete : IHasIdentifier 
    {
        public SexTypeDelete() { }

        public SexTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.SpecialEducationSettingDescriptors
{ 
    public class SpecialEducationSettingDescriptorGetByKey
    {
        public int SpecialEducationSettingDescriptorId { get; set; }
    }

    public class SpecialEducationSettingDescriptorGetByExample
    {
        public int SpecialEducationSettingDescriptorId { get; set; }
        public string SpecialEducationSettingType { get; set; }
    }

    public class SpecialEducationSettingDescriptorGetByIds : IHasIdentifiers<Guid>
    {
        public SpecialEducationSettingDescriptorGetByIds() { }

        public SpecialEducationSettingDescriptorGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class SpecialEducationSettingDescriptorPost : EdFi.Ods.Api.Models.Resources.V2.SpecialEducationSettingDescriptor.SpecialEducationSettingDescriptor
    {
    }

    public class SpecialEducationSettingDescriptorPut : EdFi.Ods.Api.Models.Resources.V2.SpecialEducationSettingDescriptor.SpecialEducationSettingDescriptor
    { 
    }

    public class SpecialEducationSettingDescriptorDelete : IHasIdentifier 
    {
        public SpecialEducationSettingDescriptorDelete() { }

        public SpecialEducationSettingDescriptorDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.SpecialEducationSettingTypes
{ 
    public class SpecialEducationSettingTypeGetByKey
    {
        public int SpecialEducationSettingTypeId { get; set; }
    }

    public class SpecialEducationSettingTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
        public int SpecialEducationSettingTypeId { get; set; }
    }

    public class SpecialEducationSettingTypeGetByIds : IHasIdentifiers<Guid>
    {
        public SpecialEducationSettingTypeGetByIds() { }

        public SpecialEducationSettingTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class SpecialEducationSettingTypePost : EdFi.Ods.Api.Models.Resources.V2.SpecialEducationSettingType.SpecialEducationSettingType
    {
    }

    public class SpecialEducationSettingTypePut : EdFi.Ods.Api.Models.Resources.V2.SpecialEducationSettingType.SpecialEducationSettingType
    { 
    }

    public class SpecialEducationSettingTypeDelete : IHasIdentifier 
    {
        public SpecialEducationSettingTypeDelete() { }

        public SpecialEducationSettingTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.Staffs
{ 
    public class StaffGetByKey
    {
        public string StaffUniqueId { get; set; }
    }

    public class StaffGetByExample
    {
        public DateTime BirthDate { get; set; }
        public string CitizenshipStatusType { get; set; }
        public string FirstName { get; set; }
        public string GenerationCodeSuffix { get; set; }
        public string HighestCompletedLevelOfEducationDescriptor { get; set; }
        public bool HighlyQualifiedTeacher { get; set; }
        public bool HispanicLatinoEthnicity { get; set; }
        public Guid Id { get; set; }
        public string LastSurname { get; set; }
        public string LoginId { get; set; }
        public string MaidenName { get; set; }
        public string MiddleName { get; set; }
        public string OldEthnicityType { get; set; }
        public string PersonalTitlePrefix { get; set; }
        public string SexType { get; set; }
        public string StaffUniqueId { get; set; }
        public decimal YearsOfPriorProfessionalExperience { get; set; }
        public decimal YearsOfPriorTeachingExperience { get; set; }
    }

    public class StaffGetByIds : IHasIdentifiers<Guid>
    {
        public StaffGetByIds() { }

        public StaffGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class StaffPost : EdFi.Ods.Api.Models.Resources.V2.Staff.Staff
    {
    }

    public class StaffPut : EdFi.Ods.Api.Models.Resources.V2.Staff.Staff
    { 
    }

    public class StaffDelete : IHasIdentifier 
    {
        public StaffDelete() { }

        public StaffDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.StaffClassificationDescriptors
{ 
    public class StaffClassificationDescriptorGetByKey
    {
        public int StaffClassificationDescriptorId { get; set; }
    }

    public class StaffClassificationDescriptorGetByExample
    {
        public int StaffClassificationDescriptorId { get; set; }
        public string StaffClassificationType { get; set; }
    }

    public class StaffClassificationDescriptorGetByIds : IHasIdentifiers<Guid>
    {
        public StaffClassificationDescriptorGetByIds() { }

        public StaffClassificationDescriptorGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class StaffClassificationDescriptorPost : EdFi.Ods.Api.Models.Resources.V2.StaffClassificationDescriptor.StaffClassificationDescriptor
    {
    }

    public class StaffClassificationDescriptorPut : EdFi.Ods.Api.Models.Resources.V2.StaffClassificationDescriptor.StaffClassificationDescriptor
    { 
    }

    public class StaffClassificationDescriptorDelete : IHasIdentifier 
    {
        public StaffClassificationDescriptorDelete() { }

        public StaffClassificationDescriptorDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.StaffClassificationTypes
{ 
    public class StaffClassificationTypeGetByKey
    {
        public int StaffClassificationTypeId { get; set; }
    }

    public class StaffClassificationTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
        public int StaffClassificationTypeId { get; set; }
    }

    public class StaffClassificationTypeGetByIds : IHasIdentifiers<Guid>
    {
        public StaffClassificationTypeGetByIds() { }

        public StaffClassificationTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class StaffClassificationTypePost : EdFi.Ods.Api.Models.Resources.V2.StaffClassificationType.StaffClassificationType
    {
    }

    public class StaffClassificationTypePut : EdFi.Ods.Api.Models.Resources.V2.StaffClassificationType.StaffClassificationType
    { 
    }

    public class StaffClassificationTypeDelete : IHasIdentifier 
    {
        public StaffClassificationTypeDelete() { }

        public StaffClassificationTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.StaffCohortAssociations
{ 
    public class StaffCohortAssociationGetByKey
    {
        public DateTime BeginDate { get; set; }
        public string CohortIdentifier { get; set; }
        public int EducationOrganizationId { get; set; }
        public string StaffUniqueId { get; set; }
    }

    public class StaffCohortAssociationGetByExample
    {
        public DateTime BeginDate { get; set; }
        public string CohortIdentifier { get; set; }
        public int EducationOrganizationId { get; set; }
        public DateTime EndDate { get; set; }
        public Guid Id { get; set; }
        public string StaffUniqueId { get; set; }
        public bool StudentRecordAccess { get; set; }
    }

    public class StaffCohortAssociationGetByIds : IHasIdentifiers<Guid>
    {
        public StaffCohortAssociationGetByIds() { }

        public StaffCohortAssociationGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class StaffCohortAssociationPost : EdFi.Ods.Api.Models.Resources.V2.StaffCohortAssociation.StaffCohortAssociation
    {
    }

    public class StaffCohortAssociationPut : EdFi.Ods.Api.Models.Resources.V2.StaffCohortAssociation.StaffCohortAssociation
    { 
    }

    public class StaffCohortAssociationDelete : IHasIdentifier 
    {
        public StaffCohortAssociationDelete() { }

        public StaffCohortAssociationDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.StaffEducationOrganizationAssignmentAssociations
{ 
    public class StaffEducationOrganizationAssignmentAssociationGetByKey
    {
        public DateTime BeginDate { get; set; }
        public int EducationOrganizationId { get; set; }
        public string StaffClassificationDescriptor { get; set; }
        public string StaffUniqueId { get; set; }
    }

    public class StaffEducationOrganizationAssignmentAssociationGetByExample
    {
        public DateTime BeginDate { get; set; }
        public int EducationOrganizationId { get; set; }
        public int EmploymentEducationOrganizationId { get; set; }
        public DateTime EmploymentHireDate { get; set; }
        public string EmploymentStatusDescriptor { get; set; }
        public DateTime EndDate { get; set; }
        public Guid Id { get; set; }
        public int OrderOfAssignment { get; set; }
        public string PositionTitle { get; set; }
        public string StaffClassificationDescriptor { get; set; }
        public string StaffUniqueId { get; set; }
    }

    public class StaffEducationOrganizationAssignmentAssociationGetByIds : IHasIdentifiers<Guid>
    {
        public StaffEducationOrganizationAssignmentAssociationGetByIds() { }

        public StaffEducationOrganizationAssignmentAssociationGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class StaffEducationOrganizationAssignmentAssociationPost : EdFi.Ods.Api.Models.Resources.V2.StaffEducationOrganizationAssignmentAssociation.StaffEducationOrganizationAssignmentAssociation
    {
    }

    public class StaffEducationOrganizationAssignmentAssociationPut : EdFi.Ods.Api.Models.Resources.V2.StaffEducationOrganizationAssignmentAssociation.StaffEducationOrganizationAssignmentAssociation
    { 
    }

    public class StaffEducationOrganizationAssignmentAssociationDelete : IHasIdentifier 
    {
        public StaffEducationOrganizationAssignmentAssociationDelete() { }

        public StaffEducationOrganizationAssignmentAssociationDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.StaffEducationOrganizationEmploymentAssociations
{ 
    public class StaffEducationOrganizationEmploymentAssociationGetByKey
    {
        public int EducationOrganizationId { get; set; }
        public string EmploymentStatusDescriptor { get; set; }
        public DateTime HireDate { get; set; }
        public string StaffUniqueId { get; set; }
    }

    public class StaffEducationOrganizationEmploymentAssociationGetByExample
    {
        public string Department { get; set; }
        public int EducationOrganizationId { get; set; }
        public string EmploymentStatusDescriptor { get; set; }
        public DateTime EndDate { get; set; }
        public decimal FullTimeEquivalency { get; set; }
        public DateTime HireDate { get; set; }
        public decimal HourlyWage { get; set; }
        public Guid Id { get; set; }
        public DateTime OfferDate { get; set; }
        public string SeparationReasonDescriptor { get; set; }
        public string SeparationType { get; set; }
        public string StaffUniqueId { get; set; }
    }

    public class StaffEducationOrganizationEmploymentAssociationGetByIds : IHasIdentifiers<Guid>
    {
        public StaffEducationOrganizationEmploymentAssociationGetByIds() { }

        public StaffEducationOrganizationEmploymentAssociationGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class StaffEducationOrganizationEmploymentAssociationPost : EdFi.Ods.Api.Models.Resources.V2.StaffEducationOrganizationEmploymentAssociation.StaffEducationOrganizationEmploymentAssociation
    {
    }

    public class StaffEducationOrganizationEmploymentAssociationPut : EdFi.Ods.Api.Models.Resources.V2.StaffEducationOrganizationEmploymentAssociation.StaffEducationOrganizationEmploymentAssociation
    { 
    }

    public class StaffEducationOrganizationEmploymentAssociationDelete : IHasIdentifier 
    {
        public StaffEducationOrganizationEmploymentAssociationDelete() { }

        public StaffEducationOrganizationEmploymentAssociationDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.StaffIdentificationSystemDescriptors
{ 
    public class StaffIdentificationSystemDescriptorGetByKey
    {
        public int StaffIdentificationSystemDescriptorId { get; set; }
    }

    public class StaffIdentificationSystemDescriptorGetByExample
    {
        public int StaffIdentificationSystemDescriptorId { get; set; }
        public string StaffIdentificationSystemType { get; set; }
    }

    public class StaffIdentificationSystemDescriptorGetByIds : IHasIdentifiers<Guid>
    {
        public StaffIdentificationSystemDescriptorGetByIds() { }

        public StaffIdentificationSystemDescriptorGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class StaffIdentificationSystemDescriptorPost : EdFi.Ods.Api.Models.Resources.V2.StaffIdentificationSystemDescriptor.StaffIdentificationSystemDescriptor
    {
    }

    public class StaffIdentificationSystemDescriptorPut : EdFi.Ods.Api.Models.Resources.V2.StaffIdentificationSystemDescriptor.StaffIdentificationSystemDescriptor
    { 
    }

    public class StaffIdentificationSystemDescriptorDelete : IHasIdentifier 
    {
        public StaffIdentificationSystemDescriptorDelete() { }

        public StaffIdentificationSystemDescriptorDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.StaffIdentificationSystemTypes
{ 
    public class StaffIdentificationSystemTypeGetByKey
    {
        public int StaffIdentificationSystemTypeId { get; set; }
    }

    public class StaffIdentificationSystemTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
        public int StaffIdentificationSystemTypeId { get; set; }
    }

    public class StaffIdentificationSystemTypeGetByIds : IHasIdentifiers<Guid>
    {
        public StaffIdentificationSystemTypeGetByIds() { }

        public StaffIdentificationSystemTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class StaffIdentificationSystemTypePost : EdFi.Ods.Api.Models.Resources.V2.StaffIdentificationSystemType.StaffIdentificationSystemType
    {
    }

    public class StaffIdentificationSystemTypePut : EdFi.Ods.Api.Models.Resources.V2.StaffIdentificationSystemType.StaffIdentificationSystemType
    { 
    }

    public class StaffIdentificationSystemTypeDelete : IHasIdentifier 
    {
        public StaffIdentificationSystemTypeDelete() { }

        public StaffIdentificationSystemTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.StaffProgramAssociations
{ 
    public class StaffProgramAssociationGetByKey
    {
        public DateTime BeginDate { get; set; }
        public int ProgramEducationOrganizationId { get; set; }
        public string ProgramName { get; set; }
        public string ProgramType { get; set; }
        public string StaffUniqueId { get; set; }
    }

    public class StaffProgramAssociationGetByExample
    {
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid Id { get; set; }
        public int ProgramEducationOrganizationId { get; set; }
        public string ProgramName { get; set; }
        public string ProgramType { get; set; }
        public string StaffUniqueId { get; set; }
        public bool StudentRecordAccess { get; set; }
    }

    public class StaffProgramAssociationGetByIds : IHasIdentifiers<Guid>
    {
        public StaffProgramAssociationGetByIds() { }

        public StaffProgramAssociationGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class StaffProgramAssociationPost : EdFi.Ods.Api.Models.Resources.V2.StaffProgramAssociation.StaffProgramAssociation
    {
    }

    public class StaffProgramAssociationPut : EdFi.Ods.Api.Models.Resources.V2.StaffProgramAssociation.StaffProgramAssociation
    { 
    }

    public class StaffProgramAssociationDelete : IHasIdentifier 
    {
        public StaffProgramAssociationDelete() { }

        public StaffProgramAssociationDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.StaffSchoolAssociations
{ 
    public class StaffSchoolAssociationGetByKey
    {
        public string ProgramAssignmentDescriptor { get; set; }
        public int SchoolId { get; set; }
        public string StaffUniqueId { get; set; }
    }

    public class StaffSchoolAssociationGetByExample
    {
        public Guid Id { get; set; }
        public string ProgramAssignmentDescriptor { get; set; }
        public int SchoolId { get; set; }
        public short SchoolYear { get; set; }
        public string StaffUniqueId { get; set; }
    }

    public class StaffSchoolAssociationGetByIds : IHasIdentifiers<Guid>
    {
        public StaffSchoolAssociationGetByIds() { }

        public StaffSchoolAssociationGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class StaffSchoolAssociationPost : EdFi.Ods.Api.Models.Resources.V2.StaffSchoolAssociation.StaffSchoolAssociation
    {
    }

    public class StaffSchoolAssociationPut : EdFi.Ods.Api.Models.Resources.V2.StaffSchoolAssociation.StaffSchoolAssociation
    { 
    }

    public class StaffSchoolAssociationDelete : IHasIdentifier 
    {
        public StaffSchoolAssociationDelete() { }

        public StaffSchoolAssociationDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.StaffSectionAssociations
{ 
    public class StaffSectionAssociationGetByKey
    {
        public string ClassPeriodName { get; set; }
        public string ClassroomIdentificationCode { get; set; }
        public string LocalCourseCode { get; set; }
        public int SchoolId { get; set; }
        public short SchoolYear { get; set; }
        public int SequenceOfCourse { get; set; }
        public string StaffUniqueId { get; set; }
        public string TermDescriptor { get; set; }
        public string UniqueSectionCode { get; set; }
    }

    public class StaffSectionAssociationGetByExample
    {
        public DateTime BeginDate { get; set; }
        public string ClassPeriodName { get; set; }
        public string ClassroomIdentificationCode { get; set; }
        public string ClassroomPositionDescriptor { get; set; }
        public DateTime EndDate { get; set; }
        public bool HighlyQualifiedTeacher { get; set; }
        public Guid Id { get; set; }
        public string LocalCourseCode { get; set; }
        public decimal PercentageContribution { get; set; }
        public int SchoolId { get; set; }
        public short SchoolYear { get; set; }
        public int SequenceOfCourse { get; set; }
        public string StaffUniqueId { get; set; }
        public bool TeacherStudentDataLinkExclusion { get; set; }
        public string TermDescriptor { get; set; }
        public string UniqueSectionCode { get; set; }
    }

    public class StaffSectionAssociationGetByIds : IHasIdentifiers<Guid>
    {
        public StaffSectionAssociationGetByIds() { }

        public StaffSectionAssociationGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class StaffSectionAssociationPost : EdFi.Ods.Api.Models.Resources.V2.StaffSectionAssociation.StaffSectionAssociation
    {
    }

    public class StaffSectionAssociationPut : EdFi.Ods.Api.Models.Resources.V2.StaffSectionAssociation.StaffSectionAssociation
    { 
    }

    public class StaffSectionAssociationDelete : IHasIdentifier 
    {
        public StaffSectionAssociationDelete() { }

        public StaffSectionAssociationDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.StateAbbreviationTypes
{ 
    public class StateAbbreviationTypeGetByKey
    {
        public int StateAbbreviationTypeId { get; set; }
    }

    public class StateAbbreviationTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
        public int StateAbbreviationTypeId { get; set; }
    }

    public class StateAbbreviationTypeGetByIds : IHasIdentifiers<Guid>
    {
        public StateAbbreviationTypeGetByIds() { }

        public StateAbbreviationTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class StateAbbreviationTypePost : EdFi.Ods.Api.Models.Resources.V2.StateAbbreviationType.StateAbbreviationType
    {
    }

    public class StateAbbreviationTypePut : EdFi.Ods.Api.Models.Resources.V2.StateAbbreviationType.StateAbbreviationType
    { 
    }

    public class StateAbbreviationTypeDelete : IHasIdentifier 
    {
        public StateAbbreviationTypeDelete() { }

        public StateAbbreviationTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.StateEducationAgencies
{ 
    public class StateEducationAgencyGetByKey
    {
        public int StateEducationAgencyId { get; set; }
    }

    public class StateEducationAgencyGetByExample
    {
        public int StateEducationAgencyId { get; set; }
    }

    public class StateEducationAgencyGetByIds : IHasIdentifiers<Guid>
    {
        public StateEducationAgencyGetByIds() { }

        public StateEducationAgencyGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class StateEducationAgencyPost : EdFi.Ods.Api.Models.Resources.V2.StateEducationAgency.StateEducationAgency
    {
    }

    public class StateEducationAgencyPut : EdFi.Ods.Api.Models.Resources.V2.StateEducationAgency.StateEducationAgency
    { 
    }

    public class StateEducationAgencyDelete : IHasIdentifier 
    {
        public StateEducationAgencyDelete() { }

        public StateEducationAgencyDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.Students
{ 
    public class StudentGetByKey
    {
        public string StudentUniqueId { get; set; }
    }

    public class StudentGetByExample
    {
        public string BirthCity { get; set; }
        public string BirthCountryDescriptor { get; set; }
        public DateTime BirthDate { get; set; }
        public string BirthInternationalProvince { get; set; }
        public string BirthStateAbbreviationType { get; set; }
        public string CitizenshipStatusType { get; set; }
        public DateTime DateEnteredUS { get; set; }
        public string DisplacementStatus { get; set; }
        public bool EconomicDisadvantaged { get; set; }
        public string FirstName { get; set; }
        public string GenerationCodeSuffix { get; set; }
        public bool HispanicLatinoEthnicity { get; set; }
        public Guid Id { get; set; }
        public string LastSurname { get; set; }
        public string LimitedEnglishProficiencyDescriptor { get; set; }
        public string LoginId { get; set; }
        public string MaidenName { get; set; }
        public string MiddleName { get; set; }
        public bool MultipleBirthStatus { get; set; }
        public string OldEthnicityType { get; set; }
        public string PersonalTitlePrefix { get; set; }
        public string ProfileThumbnail { get; set; }
        public string SchoolFoodServicesEligibilityDescriptor { get; set; }
        public string SexType { get; set; }
        public string StudentUniqueId { get; set; }
    }

    public class StudentGetByIds : IHasIdentifiers<Guid>
    {
        public StudentGetByIds() { }

        public StudentGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class StudentPost : EdFi.Ods.Api.Models.Resources.V2.Student.Student
    {
    }

    public class StudentPut : EdFi.Ods.Api.Models.Resources.V2.Student.Student
    { 
    }

    public class StudentDelete : IHasIdentifier 
    {
        public StudentDelete() { }

        public StudentDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.StudentAcademicRecords
{ 
    public class StudentAcademicRecordGetByKey
    {
        public int EducationOrganizationId { get; set; }
        public short SchoolYear { get; set; }
        public string StudentUniqueId { get; set; }
        public string TermDescriptor { get; set; }
    }

    public class StudentAcademicRecordGetByExample
    {
        public decimal CumulativeAttemptedCreditConversion { get; set; }
        public decimal CumulativeAttemptedCredits { get; set; }
        public string CumulativeAttemptedCreditType { get; set; }
        public decimal CumulativeEarnedCreditConversion { get; set; }
        public decimal CumulativeEarnedCredits { get; set; }
        public string CumulativeEarnedCreditType { get; set; }
        public decimal CumulativeGradePointAverage { get; set; }
        public decimal CumulativeGradePointsEarned { get; set; }
        public int EducationOrganizationId { get; set; }
        public string GradeValueQualifier { get; set; }
        public Guid Id { get; set; }
        public DateTime ProjectedGraduationDate { get; set; }
        public short SchoolYear { get; set; }
        public decimal SessionAttemptedCreditConversion { get; set; }
        public decimal SessionAttemptedCredits { get; set; }
        public string SessionAttemptedCreditType { get; set; }
        public decimal SessionEarnedCreditConversion { get; set; }
        public decimal SessionEarnedCredits { get; set; }
        public string SessionEarnedCreditType { get; set; }
        public decimal SessionGradePointAverage { get; set; }
        public decimal SessionGradePointsEarned { get; set; }
        public string StudentUniqueId { get; set; }
        public string TermDescriptor { get; set; }
    }

    public class StudentAcademicRecordGetByIds : IHasIdentifiers<Guid>
    {
        public StudentAcademicRecordGetByIds() { }

        public StudentAcademicRecordGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class StudentAcademicRecordPost : EdFi.Ods.Api.Models.Resources.V2.StudentAcademicRecord.StudentAcademicRecord
    {
    }

    public class StudentAcademicRecordPut : EdFi.Ods.Api.Models.Resources.V2.StudentAcademicRecord.StudentAcademicRecord
    { 
    }

    public class StudentAcademicRecordDelete : IHasIdentifier 
    {
        public StudentAcademicRecordDelete() { }

        public StudentAcademicRecordDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.StudentAssessments
{ 
    public class StudentAssessmentGetByKey
    {
        public string AssessmentIdentifier { get; set; }
        public string Namespace { get; set; }
        public string Identifier { get; set; }
        public string StudentUniqueId { get; set; }
    }

    public class StudentAssessmentGetByExample
    {
        public DateTime AdministrationDate { get; set; }
        public DateTime AdministrationEndDate { get; set; }
        public string AdministrationEnvironmentType { get; set; }
        public string AdministrationLanguageDescriptor { get; set; }
        public string AssessmentIdentifier { get; set; }
        public string EventCircumstanceType { get; set; }
        public string EventDescription { get; set; }
        public Guid Id { get; set; }
        public string Namespace { get; set; }
        public string ReasonNotTestedType { get; set; }
        public string RetestIndicatorType { get; set; }
        public string SerialNumber { get; set; }
        public string Identifier { get; set; }
        public string StudentUniqueId { get; set; }
        public string WhenAssessedGradeLevelDescriptor { get; set; }
    }

    public class StudentAssessmentGetByIds : IHasIdentifiers<Guid>
    {
        public StudentAssessmentGetByIds() { }

        public StudentAssessmentGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class StudentAssessmentPost : EdFi.Ods.Api.Models.Resources.V2.StudentAssessment.StudentAssessment
    {
    }

    public class StudentAssessmentPut : EdFi.Ods.Api.Models.Resources.V2.StudentAssessment.StudentAssessment
    { 
    }

    public class StudentAssessmentDelete : IHasIdentifier 
    {
        public StudentAssessmentDelete() { }

        public StudentAssessmentDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.StudentCharacteristicDescriptors
{ 
    public class StudentCharacteristicDescriptorGetByKey
    {
        public int StudentCharacteristicDescriptorId { get; set; }
    }

    public class StudentCharacteristicDescriptorGetByExample
    {
        public int StudentCharacteristicDescriptorId { get; set; }
        public string StudentCharacteristicType { get; set; }
    }

    public class StudentCharacteristicDescriptorGetByIds : IHasIdentifiers<Guid>
    {
        public StudentCharacteristicDescriptorGetByIds() { }

        public StudentCharacteristicDescriptorGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class StudentCharacteristicDescriptorPost : EdFi.Ods.Api.Models.Resources.V2.StudentCharacteristicDescriptor.StudentCharacteristicDescriptor
    {
    }

    public class StudentCharacteristicDescriptorPut : EdFi.Ods.Api.Models.Resources.V2.StudentCharacteristicDescriptor.StudentCharacteristicDescriptor
    { 
    }

    public class StudentCharacteristicDescriptorDelete : IHasIdentifier 
    {
        public StudentCharacteristicDescriptorDelete() { }

        public StudentCharacteristicDescriptorDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.StudentCharacteristicTypes
{ 
    public class StudentCharacteristicTypeGetByKey
    {
        public int StudentCharacteristicTypeId { get; set; }
    }

    public class StudentCharacteristicTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
        public int StudentCharacteristicTypeId { get; set; }
    }

    public class StudentCharacteristicTypeGetByIds : IHasIdentifiers<Guid>
    {
        public StudentCharacteristicTypeGetByIds() { }

        public StudentCharacteristicTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class StudentCharacteristicTypePost : EdFi.Ods.Api.Models.Resources.V2.StudentCharacteristicType.StudentCharacteristicType
    {
    }

    public class StudentCharacteristicTypePut : EdFi.Ods.Api.Models.Resources.V2.StudentCharacteristicType.StudentCharacteristicType
    { 
    }

    public class StudentCharacteristicTypeDelete : IHasIdentifier 
    {
        public StudentCharacteristicTypeDelete() { }

        public StudentCharacteristicTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.StudentCohortAssociations
{ 
    public class StudentCohortAssociationGetByKey
    {
        public DateTime BeginDate { get; set; }
        public string CohortIdentifier { get; set; }
        public int EducationOrganizationId { get; set; }
        public string StudentUniqueId { get; set; }
    }

    public class StudentCohortAssociationGetByExample
    {
        public DateTime BeginDate { get; set; }
        public string CohortIdentifier { get; set; }
        public int EducationOrganizationId { get; set; }
        public DateTime EndDate { get; set; }
        public Guid Id { get; set; }
        public string StudentUniqueId { get; set; }
    }

    public class StudentCohortAssociationGetByIds : IHasIdentifiers<Guid>
    {
        public StudentCohortAssociationGetByIds() { }

        public StudentCohortAssociationGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class StudentCohortAssociationPost : EdFi.Ods.Api.Models.Resources.V2.StudentCohortAssociation.StudentCohortAssociation
    {
    }

    public class StudentCohortAssociationPut : EdFi.Ods.Api.Models.Resources.V2.StudentCohortAssociation.StudentCohortAssociation
    { 
    }

    public class StudentCohortAssociationDelete : IHasIdentifier 
    {
        public StudentCohortAssociationDelete() { }

        public StudentCohortAssociationDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.StudentCompetencyObjectives
{ 
    public class StudentCompetencyObjectiveGetByKey
    {
        public DateTime GradingPeriodBeginDate { get; set; }
        public string GradingPeriodDescriptor { get; set; }
        public string Objective { get; set; }
        public int ObjectiveEducationOrganizationId { get; set; }
        public string ObjectiveGradeLevelDescriptor { get; set; }
        public int SchoolId { get; set; }
        public string StudentUniqueId { get; set; }
    }

    public class StudentCompetencyObjectiveGetByExample
    {
        public DateTime BeginDate { get; set; }
        public string ClassPeriodName { get; set; }
        public string ClassroomIdentificationCode { get; set; }
        public string CompetencyLevelDescriptor { get; set; }
        public string DiagnosticStatement { get; set; }
        public int EducationOrganizationId { get; set; }
        public DateTime GradingPeriodBeginDate { get; set; }
        public string GradingPeriodDescriptor { get; set; }
        public Guid Id { get; set; }
        public string LocalCourseCode { get; set; }
        public string Objective { get; set; }
        public int ObjectiveEducationOrganizationId { get; set; }
        public string ObjectiveGradeLevelDescriptor { get; set; }
        public int ProgramEducationOrganizationId { get; set; }
        public string ProgramName { get; set; }
        public string ProgramType { get; set; }
        public int SchoolId { get; set; }
        public short SchoolYear { get; set; }
        public int SequenceOfCourse { get; set; }
        public string StudentUniqueId { get; set; }
        public string TermDescriptor { get; set; }
        public string UniqueSectionCode { get; set; }
    }

    public class StudentCompetencyObjectiveGetByIds : IHasIdentifiers<Guid>
    {
        public StudentCompetencyObjectiveGetByIds() { }

        public StudentCompetencyObjectiveGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class StudentCompetencyObjectivePost : EdFi.Ods.Api.Models.Resources.V2.StudentCompetencyObjective.StudentCompetencyObjective
    {
    }

    public class StudentCompetencyObjectivePut : EdFi.Ods.Api.Models.Resources.V2.StudentCompetencyObjective.StudentCompetencyObjective
    { 
    }

    public class StudentCompetencyObjectiveDelete : IHasIdentifier 
    {
        public StudentCompetencyObjectiveDelete() { }

        public StudentCompetencyObjectiveDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.StudentCTEProgramAssociations
{ 
    public class StudentCTEProgramAssociationGetByKey
    {
        public DateTime BeginDate { get; set; }
        public int EducationOrganizationId { get; set; }
        public int ProgramEducationOrganizationId { get; set; }
        public string ProgramName { get; set; }
        public string ProgramType { get; set; }
        public string StudentUniqueId { get; set; }
    }

    public class StudentCTEProgramAssociationGetByExample
    {
        public DateTime BeginDate { get; set; }
        public int EducationOrganizationId { get; set; }
        public int ProgramEducationOrganizationId { get; set; }
        public string ProgramName { get; set; }
        public string ProgramType { get; set; }
        public string StudentUniqueId { get; set; }
    }

    public class StudentCTEProgramAssociationGetByIds : IHasIdentifiers<Guid>
    {
        public StudentCTEProgramAssociationGetByIds() { }

        public StudentCTEProgramAssociationGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class StudentCTEProgramAssociationPost : EdFi.Ods.Api.Models.Resources.V2.StudentCTEProgramAssociation.StudentCTEProgramAssociation
    {
    }

    public class StudentCTEProgramAssociationPut : EdFi.Ods.Api.Models.Resources.V2.StudentCTEProgramAssociation.StudentCTEProgramAssociation
    { 
    }

    public class StudentCTEProgramAssociationDelete : IHasIdentifier 
    {
        public StudentCTEProgramAssociationDelete() { }

        public StudentCTEProgramAssociationDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.StudentDisciplineIncidentAssociations
{ 
    public class StudentDisciplineIncidentAssociationGetByKey
    {
        public string IncidentIdentifier { get; set; }
        public int SchoolId { get; set; }
        public string StudentUniqueId { get; set; }
    }

    public class StudentDisciplineIncidentAssociationGetByExample
    {
        public Guid Id { get; set; }
        public string IncidentIdentifier { get; set; }
        public int SchoolId { get; set; }
        public string StudentParticipationCodeType { get; set; }
        public string StudentUniqueId { get; set; }
    }

    public class StudentDisciplineIncidentAssociationGetByIds : IHasIdentifiers<Guid>
    {
        public StudentDisciplineIncidentAssociationGetByIds() { }

        public StudentDisciplineIncidentAssociationGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class StudentDisciplineIncidentAssociationPost : EdFi.Ods.Api.Models.Resources.V2.StudentDisciplineIncidentAssociation.StudentDisciplineIncidentAssociation
    {
    }

    public class StudentDisciplineIncidentAssociationPut : EdFi.Ods.Api.Models.Resources.V2.StudentDisciplineIncidentAssociation.StudentDisciplineIncidentAssociation
    { 
    }

    public class StudentDisciplineIncidentAssociationDelete : IHasIdentifier 
    {
        public StudentDisciplineIncidentAssociationDelete() { }

        public StudentDisciplineIncidentAssociationDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.StudentEducationOrganizationAssociations
{ 
    public class StudentEducationOrganizationAssociationGetByKey
    {
        public int EducationOrganizationId { get; set; }
        public string ResponsibilityDescriptor { get; set; }
        public string StudentUniqueId { get; set; }
    }

    public class StudentEducationOrganizationAssociationGetByExample
    {
        public int EducationOrganizationId { get; set; }
        public Guid Id { get; set; }
        public string ResponsibilityDescriptor { get; set; }
        public string StudentUniqueId { get; set; }
    }

    public class StudentEducationOrganizationAssociationGetByIds : IHasIdentifiers<Guid>
    {
        public StudentEducationOrganizationAssociationGetByIds() { }

        public StudentEducationOrganizationAssociationGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class StudentEducationOrganizationAssociationPost : EdFi.Ods.Api.Models.Resources.V2.StudentEducationOrganizationAssociation.StudentEducationOrganizationAssociation
    {
    }

    public class StudentEducationOrganizationAssociationPut : EdFi.Ods.Api.Models.Resources.V2.StudentEducationOrganizationAssociation.StudentEducationOrganizationAssociation
    { 
    }

    public class StudentEducationOrganizationAssociationDelete : IHasIdentifier 
    {
        public StudentEducationOrganizationAssociationDelete() { }

        public StudentEducationOrganizationAssociationDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.StudentGradebookEntries
{ 
    public class StudentGradebookEntryGetByKey
    {
        public DateTime BeginDate { get; set; }
        public string ClassPeriodName { get; set; }
        public string ClassroomIdentificationCode { get; set; }
        public DateTime DateAssigned { get; set; }
        public string GradebookEntryTitle { get; set; }
        public string LocalCourseCode { get; set; }
        public int SchoolId { get; set; }
        public short SchoolYear { get; set; }
        public int SequenceOfCourse { get; set; }
        public string StudentUniqueId { get; set; }
        public string TermDescriptor { get; set; }
        public string UniqueSectionCode { get; set; }
    }

    public class StudentGradebookEntryGetByExample
    {
        public DateTime BeginDate { get; set; }
        public string ClassPeriodName { get; set; }
        public string ClassroomIdentificationCode { get; set; }
        public string CompetencyLevelDescriptor { get; set; }
        public DateTime DateAssigned { get; set; }
        public DateTime DateFulfilled { get; set; }
        public string DiagnosticStatement { get; set; }
        public string GradebookEntryTitle { get; set; }
        public Guid Id { get; set; }
        public string LetterGradeEarned { get; set; }
        public string LocalCourseCode { get; set; }
        public decimal NumericGradeEarned { get; set; }
        public int SchoolId { get; set; }
        public short SchoolYear { get; set; }
        public int SequenceOfCourse { get; set; }
        public string StudentUniqueId { get; set; }
        public string TermDescriptor { get; set; }
        public string UniqueSectionCode { get; set; }
    }

    public class StudentGradebookEntryGetByIds : IHasIdentifiers<Guid>
    {
        public StudentGradebookEntryGetByIds() { }

        public StudentGradebookEntryGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class StudentGradebookEntryPost : EdFi.Ods.Api.Models.Resources.V2.StudentGradebookEntry.StudentGradebookEntry
    {
    }

    public class StudentGradebookEntryPut : EdFi.Ods.Api.Models.Resources.V2.StudentGradebookEntry.StudentGradebookEntry
    { 
    }

    public class StudentGradebookEntryDelete : IHasIdentifier 
    {
        public StudentGradebookEntryDelete() { }

        public StudentGradebookEntryDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.StudentIdentificationSystemDescriptors
{ 
    public class StudentIdentificationSystemDescriptorGetByKey
    {
        public int StudentIdentificationSystemDescriptorId { get; set; }
    }

    public class StudentIdentificationSystemDescriptorGetByExample
    {
        public int StudentIdentificationSystemDescriptorId { get; set; }
        public string StudentIdentificationSystemType { get; set; }
    }

    public class StudentIdentificationSystemDescriptorGetByIds : IHasIdentifiers<Guid>
    {
        public StudentIdentificationSystemDescriptorGetByIds() { }

        public StudentIdentificationSystemDescriptorGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class StudentIdentificationSystemDescriptorPost : EdFi.Ods.Api.Models.Resources.V2.StudentIdentificationSystemDescriptor.StudentIdentificationSystemDescriptor
    {
    }

    public class StudentIdentificationSystemDescriptorPut : EdFi.Ods.Api.Models.Resources.V2.StudentIdentificationSystemDescriptor.StudentIdentificationSystemDescriptor
    { 
    }

    public class StudentIdentificationSystemDescriptorDelete : IHasIdentifier 
    {
        public StudentIdentificationSystemDescriptorDelete() { }

        public StudentIdentificationSystemDescriptorDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.StudentIdentificationSystemTypes
{ 
    public class StudentIdentificationSystemTypeGetByKey
    {
        public int StudentIdentificationSystemTypeId { get; set; }
    }

    public class StudentIdentificationSystemTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
        public int StudentIdentificationSystemTypeId { get; set; }
    }

    public class StudentIdentificationSystemTypeGetByIds : IHasIdentifiers<Guid>
    {
        public StudentIdentificationSystemTypeGetByIds() { }

        public StudentIdentificationSystemTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class StudentIdentificationSystemTypePost : EdFi.Ods.Api.Models.Resources.V2.StudentIdentificationSystemType.StudentIdentificationSystemType
    {
    }

    public class StudentIdentificationSystemTypePut : EdFi.Ods.Api.Models.Resources.V2.StudentIdentificationSystemType.StudentIdentificationSystemType
    { 
    }

    public class StudentIdentificationSystemTypeDelete : IHasIdentifier 
    {
        public StudentIdentificationSystemTypeDelete() { }

        public StudentIdentificationSystemTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.StudentInterventionAssociations
{ 
    public class StudentInterventionAssociationGetByKey
    {
        public int EducationOrganizationId { get; set; }
        public string InterventionIdentificationCode { get; set; }
        public string StudentUniqueId { get; set; }
    }

    public class StudentInterventionAssociationGetByExample
    {
        public int CohortEducationOrganizationId { get; set; }
        public string CohortIdentifier { get; set; }
        public string DiagnosticStatement { get; set; }
        public int EducationOrganizationId { get; set; }
        public Guid Id { get; set; }
        public string InterventionIdentificationCode { get; set; }
        public string StudentUniqueId { get; set; }
    }

    public class StudentInterventionAssociationGetByIds : IHasIdentifiers<Guid>
    {
        public StudentInterventionAssociationGetByIds() { }

        public StudentInterventionAssociationGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class StudentInterventionAssociationPost : EdFi.Ods.Api.Models.Resources.V2.StudentInterventionAssociation.StudentInterventionAssociation
    {
    }

    public class StudentInterventionAssociationPut : EdFi.Ods.Api.Models.Resources.V2.StudentInterventionAssociation.StudentInterventionAssociation
    { 
    }

    public class StudentInterventionAssociationDelete : IHasIdentifier 
    {
        public StudentInterventionAssociationDelete() { }

        public StudentInterventionAssociationDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.StudentInterventionAttendanceEvents
{ 
    public class StudentInterventionAttendanceEventGetByKey
    {
        public string AttendanceEventCategoryDescriptor { get; set; }
        public int EducationOrganizationId { get; set; }
        public DateTime EventDate { get; set; }
        public string InterventionIdentificationCode { get; set; }
        public string StudentUniqueId { get; set; }
    }

    public class StudentInterventionAttendanceEventGetByExample
    {
        public string AttendanceEventCategoryDescriptor { get; set; }
        public string AttendanceEventReason { get; set; }
        public string EducationalEnvironmentType { get; set; }
        public int EducationOrganizationId { get; set; }
        public DateTime EventDate { get; set; }
        public Guid Id { get; set; }
        public string InterventionIdentificationCode { get; set; }
        public string StudentUniqueId { get; set; }
    }

    public class StudentInterventionAttendanceEventGetByIds : IHasIdentifiers<Guid>
    {
        public StudentInterventionAttendanceEventGetByIds() { }

        public StudentInterventionAttendanceEventGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class StudentInterventionAttendanceEventPost : EdFi.Ods.Api.Models.Resources.V2.StudentInterventionAttendanceEvent.StudentInterventionAttendanceEvent
    {
    }

    public class StudentInterventionAttendanceEventPut : EdFi.Ods.Api.Models.Resources.V2.StudentInterventionAttendanceEvent.StudentInterventionAttendanceEvent
    { 
    }

    public class StudentInterventionAttendanceEventDelete : IHasIdentifier 
    {
        public StudentInterventionAttendanceEventDelete() { }

        public StudentInterventionAttendanceEventDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.StudentLearningObjectives
{ 
    public class StudentLearningObjectiveGetByKey
    {
        public DateTime GradingPeriodBeginDate { get; set; }
        public string GradingPeriodDescriptor { get; set; }
        public string LearningObjectiveId { get; set; }
        public string Namespace { get; set; }
        public int SchoolId { get; set; }
        public string StudentUniqueId { get; set; }
    }

    public class StudentLearningObjectiveGetByExample
    {
        public DateTime BeginDate { get; set; }
        public string ClassPeriodName { get; set; }
        public string ClassroomIdentificationCode { get; set; }
        public string CompetencyLevelDescriptor { get; set; }
        public string DiagnosticStatement { get; set; }
        public int EducationOrganizationId { get; set; }
        public DateTime GradingPeriodBeginDate { get; set; }
        public string GradingPeriodDescriptor { get; set; }
        public Guid Id { get; set; }
        public string LearningObjectiveId { get; set; }
        public string LocalCourseCode { get; set; }
        public string Namespace { get; set; }
        public int ProgramEducationOrganizationId { get; set; }
        public string ProgramName { get; set; }
        public string ProgramType { get; set; }
        public int SchoolId { get; set; }
        public short SchoolYear { get; set; }
        public int SequenceOfCourse { get; set; }
        public DateTime StudentSectionAssociationBeginDate { get; set; }
        public string StudentUniqueId { get; set; }
        public string TermDescriptor { get; set; }
        public string UniqueSectionCode { get; set; }
    }

    public class StudentLearningObjectiveGetByIds : IHasIdentifiers<Guid>
    {
        public StudentLearningObjectiveGetByIds() { }

        public StudentLearningObjectiveGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class StudentLearningObjectivePost : EdFi.Ods.Api.Models.Resources.V2.StudentLearningObjective.StudentLearningObjective
    {
    }

    public class StudentLearningObjectivePut : EdFi.Ods.Api.Models.Resources.V2.StudentLearningObjective.StudentLearningObjective
    { 
    }

    public class StudentLearningObjectiveDelete : IHasIdentifier 
    {
        public StudentLearningObjectiveDelete() { }

        public StudentLearningObjectiveDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.StudentMigrantEducationProgramAssociations
{ 
    public class StudentMigrantEducationProgramAssociationGetByKey
    {
        public DateTime BeginDate { get; set; }
        public int EducationOrganizationId { get; set; }
        public int ProgramEducationOrganizationId { get; set; }
        public string ProgramName { get; set; }
        public string ProgramType { get; set; }
        public string StudentUniqueId { get; set; }
    }

    public class StudentMigrantEducationProgramAssociationGetByExample
    {
        public DateTime BeginDate { get; set; }
        public string ContinuationOfServicesReasonDescriptor { get; set; }
        public int EducationOrganizationId { get; set; }
        public DateTime LastQualifyingMove { get; set; }
        public bool PriorityForServices { get; set; }
        public int ProgramEducationOrganizationId { get; set; }
        public string ProgramName { get; set; }
        public string ProgramType { get; set; }
        public string StudentUniqueId { get; set; }
        public DateTime USInitialEntry { get; set; }
        public DateTime USInitialSchoolEntry { get; set; }
        public DateTime USMostRecentEntry { get; set; }
    }

    public class StudentMigrantEducationProgramAssociationGetByIds : IHasIdentifiers<Guid>
    {
        public StudentMigrantEducationProgramAssociationGetByIds() { }

        public StudentMigrantEducationProgramAssociationGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class StudentMigrantEducationProgramAssociationPost : EdFi.Ods.Api.Models.Resources.V2.StudentMigrantEducationProgramAssociation.StudentMigrantEducationProgramAssociation
    {
    }

    public class StudentMigrantEducationProgramAssociationPut : EdFi.Ods.Api.Models.Resources.V2.StudentMigrantEducationProgramAssociation.StudentMigrantEducationProgramAssociation
    { 
    }

    public class StudentMigrantEducationProgramAssociationDelete : IHasIdentifier 
    {
        public StudentMigrantEducationProgramAssociationDelete() { }

        public StudentMigrantEducationProgramAssociationDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.StudentParentAssociations
{ 
    public class StudentParentAssociationGetByKey
    {
        public string ParentUniqueId { get; set; }
        public string StudentUniqueId { get; set; }
    }

    public class StudentParentAssociationGetByExample
    {
        public int ContactPriority { get; set; }
        public string ContactRestrictions { get; set; }
        public bool EmergencyContactStatus { get; set; }
        public Guid Id { get; set; }
        public bool LivesWith { get; set; }
        public string ParentUniqueId { get; set; }
        public bool PrimaryContactStatus { get; set; }
        public string RelationType { get; set; }
        public string StudentUniqueId { get; set; }
    }

    public class StudentParentAssociationGetByIds : IHasIdentifiers<Guid>
    {
        public StudentParentAssociationGetByIds() { }

        public StudentParentAssociationGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class StudentParentAssociationPost : EdFi.Ods.Api.Models.Resources.V2.StudentParentAssociation.StudentParentAssociation
    {
    }

    public class StudentParentAssociationPut : EdFi.Ods.Api.Models.Resources.V2.StudentParentAssociation.StudentParentAssociation
    { 
    }

    public class StudentParentAssociationDelete : IHasIdentifier 
    {
        public StudentParentAssociationDelete() { }

        public StudentParentAssociationDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.StudentParticipationCodeTypes
{ 
    public class StudentParticipationCodeTypeGetByKey
    {
        public int StudentParticipationCodeTypeId { get; set; }
    }

    public class StudentParticipationCodeTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
        public int StudentParticipationCodeTypeId { get; set; }
    }

    public class StudentParticipationCodeTypeGetByIds : IHasIdentifiers<Guid>
    {
        public StudentParticipationCodeTypeGetByIds() { }

        public StudentParticipationCodeTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class StudentParticipationCodeTypePost : EdFi.Ods.Api.Models.Resources.V2.StudentParticipationCodeType.StudentParticipationCodeType
    {
    }

    public class StudentParticipationCodeTypePut : EdFi.Ods.Api.Models.Resources.V2.StudentParticipationCodeType.StudentParticipationCodeType
    { 
    }

    public class StudentParticipationCodeTypeDelete : IHasIdentifier 
    {
        public StudentParticipationCodeTypeDelete() { }

        public StudentParticipationCodeTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.StudentProgramAssociations
{ 
    public class StudentProgramAssociationGetByKey
    {
        public DateTime BeginDate { get; set; }
        public int EducationOrganizationId { get; set; }
        public int ProgramEducationOrganizationId { get; set; }
        public string ProgramName { get; set; }
        public string ProgramType { get; set; }
        public string StudentUniqueId { get; set; }
    }

    public class StudentProgramAssociationGetByExample
    {
        public DateTime BeginDate { get; set; }
        public int EducationOrganizationId { get; set; }
        public DateTime EndDate { get; set; }
        public Guid Id { get; set; }
        public int ProgramEducationOrganizationId { get; set; }
        public string ProgramName { get; set; }
        public string ProgramType { get; set; }
        public string ReasonExitedDescriptor { get; set; }
        public bool ServedOutsideOfRegularSession { get; set; }
        public string StudentUniqueId { get; set; }
    }

    public class StudentProgramAssociationGetByIds : IHasIdentifiers<Guid>
    {
        public StudentProgramAssociationGetByIds() { }

        public StudentProgramAssociationGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class StudentProgramAssociationPost : EdFi.Ods.Api.Models.Resources.V2.StudentProgramAssociation.StudentProgramAssociation
    {
    }

    public class StudentProgramAssociationPut : EdFi.Ods.Api.Models.Resources.V2.StudentProgramAssociation.StudentProgramAssociation
    { 
    }

    public class StudentProgramAssociationDelete : IHasIdentifier 
    {
        public StudentProgramAssociationDelete() { }

        public StudentProgramAssociationDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.StudentProgramAttendanceEvents
{ 
    public class StudentProgramAttendanceEventGetByKey
    {
        public string AttendanceEventCategoryDescriptor { get; set; }
        public int EducationOrganizationId { get; set; }
        public DateTime EventDate { get; set; }
        public int ProgramEducationOrganizationId { get; set; }
        public string ProgramName { get; set; }
        public string ProgramType { get; set; }
        public string StudentUniqueId { get; set; }
    }

    public class StudentProgramAttendanceEventGetByExample
    {
        public string AttendanceEventCategoryDescriptor { get; set; }
        public string AttendanceEventReason { get; set; }
        public string EducationalEnvironmentType { get; set; }
        public int EducationOrganizationId { get; set; }
        public DateTime EventDate { get; set; }
        public Guid Id { get; set; }
        public int ProgramEducationOrganizationId { get; set; }
        public string ProgramName { get; set; }
        public string ProgramType { get; set; }
        public string StudentUniqueId { get; set; }
    }

    public class StudentProgramAttendanceEventGetByIds : IHasIdentifiers<Guid>
    {
        public StudentProgramAttendanceEventGetByIds() { }

        public StudentProgramAttendanceEventGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class StudentProgramAttendanceEventPost : EdFi.Ods.Api.Models.Resources.V2.StudentProgramAttendanceEvent.StudentProgramAttendanceEvent
    {
    }

    public class StudentProgramAttendanceEventPut : EdFi.Ods.Api.Models.Resources.V2.StudentProgramAttendanceEvent.StudentProgramAttendanceEvent
    { 
    }

    public class StudentProgramAttendanceEventDelete : IHasIdentifier 
    {
        public StudentProgramAttendanceEventDelete() { }

        public StudentProgramAttendanceEventDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.StudentSchoolAssociations
{ 
    public class StudentSchoolAssociationGetByKey
    {
        public DateTime EntryDate { get; set; }
        public int SchoolId { get; set; }
        public string StudentUniqueId { get; set; }
    }

    public class StudentSchoolAssociationGetByExample
    {
        public short ClassOfSchoolYear { get; set; }
        public int EducationOrganizationId { get; set; }
        public bool EmployedWhileEnrolled { get; set; }
        public DateTime EntryDate { get; set; }
        public string EntryGradeLevelDescriptor { get; set; }
        public string EntryGradeLevelReasonType { get; set; }
        public string EntryTypeDescriptor { get; set; }
        public DateTime ExitWithdrawDate { get; set; }
        public string ExitWithdrawTypeDescriptor { get; set; }
        public string GraduationPlanTypeDescriptor { get; set; }
        public short GraduationSchoolYear { get; set; }
        public Guid Id { get; set; }
        public bool PrimarySchool { get; set; }
        public bool RepeatGradeIndicator { get; set; }
        public string ResidencyStatusDescriptor { get; set; }
        public bool SchoolChoiceTransfer { get; set; }
        public int SchoolId { get; set; }
        public short SchoolYear { get; set; }
        public string StudentUniqueId { get; set; }
    }

    public class StudentSchoolAssociationGetByIds : IHasIdentifiers<Guid>
    {
        public StudentSchoolAssociationGetByIds() { }

        public StudentSchoolAssociationGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class StudentSchoolAssociationPost : EdFi.Ods.Api.Models.Resources.V2.StudentSchoolAssociation.StudentSchoolAssociation
    {
    }

    public class StudentSchoolAssociationPut : EdFi.Ods.Api.Models.Resources.V2.StudentSchoolAssociation.StudentSchoolAssociation
    { 
    }

    public class StudentSchoolAssociationDelete : IHasIdentifier 
    {
        public StudentSchoolAssociationDelete() { }

        public StudentSchoolAssociationDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.StudentSchoolAttendanceEvents
{ 
    public class StudentSchoolAttendanceEventGetByKey
    {
        public string AttendanceEventCategoryDescriptor { get; set; }
        public DateTime EventDate { get; set; }
        public int SchoolId { get; set; }
        public short SchoolYear { get; set; }
        public string StudentUniqueId { get; set; }
        public string TermDescriptor { get; set; }
    }

    public class StudentSchoolAttendanceEventGetByExample
    {
        public string AttendanceEventCategoryDescriptor { get; set; }
        public string AttendanceEventReason { get; set; }
        public string EducationalEnvironmentType { get; set; }
        public DateTime EventDate { get; set; }
        public Guid Id { get; set; }
        public int SchoolId { get; set; }
        public short SchoolYear { get; set; }
        public string StudentUniqueId { get; set; }
        public string TermDescriptor { get; set; }
    }

    public class StudentSchoolAttendanceEventGetByIds : IHasIdentifiers<Guid>
    {
        public StudentSchoolAttendanceEventGetByIds() { }

        public StudentSchoolAttendanceEventGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class StudentSchoolAttendanceEventPost : EdFi.Ods.Api.Models.Resources.V2.StudentSchoolAttendanceEvent.StudentSchoolAttendanceEvent
    {
    }

    public class StudentSchoolAttendanceEventPut : EdFi.Ods.Api.Models.Resources.V2.StudentSchoolAttendanceEvent.StudentSchoolAttendanceEvent
    { 
    }

    public class StudentSchoolAttendanceEventDelete : IHasIdentifier 
    {
        public StudentSchoolAttendanceEventDelete() { }

        public StudentSchoolAttendanceEventDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.StudentSectionAssociations
{ 
    public class StudentSectionAssociationGetByKey
    {
        public DateTime BeginDate { get; set; }
        public string ClassPeriodName { get; set; }
        public string ClassroomIdentificationCode { get; set; }
        public string LocalCourseCode { get; set; }
        public int SchoolId { get; set; }
        public short SchoolYear { get; set; }
        public int SequenceOfCourse { get; set; }
        public string StudentUniqueId { get; set; }
        public string TermDescriptor { get; set; }
        public string UniqueSectionCode { get; set; }
    }

    public class StudentSectionAssociationGetByExample
    {
        public DateTime BeginDate { get; set; }
        public string ClassPeriodName { get; set; }
        public string ClassroomIdentificationCode { get; set; }
        public DateTime EndDate { get; set; }
        public bool HomeroomIndicator { get; set; }
        public Guid Id { get; set; }
        public string LocalCourseCode { get; set; }
        public string RepeatIdentifierType { get; set; }
        public int SchoolId { get; set; }
        public short SchoolYear { get; set; }
        public int SequenceOfCourse { get; set; }
        public string StudentUniqueId { get; set; }
        public bool TeacherStudentDataLinkExclusion { get; set; }
        public string TermDescriptor { get; set; }
        public string UniqueSectionCode { get; set; }
    }

    public class StudentSectionAssociationGetByIds : IHasIdentifiers<Guid>
    {
        public StudentSectionAssociationGetByIds() { }

        public StudentSectionAssociationGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class StudentSectionAssociationPost : EdFi.Ods.Api.Models.Resources.V2.StudentSectionAssociation.StudentSectionAssociation
    {
    }

    public class StudentSectionAssociationPut : EdFi.Ods.Api.Models.Resources.V2.StudentSectionAssociation.StudentSectionAssociation
    { 
    }

    public class StudentSectionAssociationDelete : IHasIdentifier 
    {
        public StudentSectionAssociationDelete() { }

        public StudentSectionAssociationDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.StudentSectionAttendanceEvents
{ 
    public class StudentSectionAttendanceEventGetByKey
    {
        public string AttendanceEventCategoryDescriptor { get; set; }
        public string ClassPeriodName { get; set; }
        public string ClassroomIdentificationCode { get; set; }
        public DateTime EventDate { get; set; }
        public string LocalCourseCode { get; set; }
        public int SchoolId { get; set; }
        public short SchoolYear { get; set; }
        public int SequenceOfCourse { get; set; }
        public string StudentUniqueId { get; set; }
        public string TermDescriptor { get; set; }
        public string UniqueSectionCode { get; set; }
    }

    public class StudentSectionAttendanceEventGetByExample
    {
        public string AttendanceEventCategoryDescriptor { get; set; }
        public string AttendanceEventReason { get; set; }
        public string ClassPeriodName { get; set; }
        public string ClassroomIdentificationCode { get; set; }
        public string EducationalEnvironmentType { get; set; }
        public DateTime EventDate { get; set; }
        public Guid Id { get; set; }
        public string LocalCourseCode { get; set; }
        public int SchoolId { get; set; }
        public short SchoolYear { get; set; }
        public int SequenceOfCourse { get; set; }
        public string StudentUniqueId { get; set; }
        public string TermDescriptor { get; set; }
        public string UniqueSectionCode { get; set; }
    }

    public class StudentSectionAttendanceEventGetByIds : IHasIdentifiers<Guid>
    {
        public StudentSectionAttendanceEventGetByIds() { }

        public StudentSectionAttendanceEventGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class StudentSectionAttendanceEventPost : EdFi.Ods.Api.Models.Resources.V2.StudentSectionAttendanceEvent.StudentSectionAttendanceEvent
    {
    }

    public class StudentSectionAttendanceEventPut : EdFi.Ods.Api.Models.Resources.V2.StudentSectionAttendanceEvent.StudentSectionAttendanceEvent
    { 
    }

    public class StudentSectionAttendanceEventDelete : IHasIdentifier 
    {
        public StudentSectionAttendanceEventDelete() { }

        public StudentSectionAttendanceEventDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.StudentSpecialEducationProgramAssociations
{ 
    public class StudentSpecialEducationProgramAssociationGetByKey
    {
        public DateTime BeginDate { get; set; }
        public int EducationOrganizationId { get; set; }
        public int ProgramEducationOrganizationId { get; set; }
        public string ProgramName { get; set; }
        public string ProgramType { get; set; }
        public string StudentUniqueId { get; set; }
    }

    public class StudentSpecialEducationProgramAssociationGetByExample
    {
        public DateTime BeginDate { get; set; }
        public int EducationOrganizationId { get; set; }
        public bool IdeaEligibility { get; set; }
        public DateTime IEPBeginDate { get; set; }
        public DateTime IEPEndDate { get; set; }
        public DateTime IEPReviewDate { get; set; }
        public DateTime LastEvaluationDate { get; set; }
        public bool MedicallyFragile { get; set; }
        public bool MultiplyDisabled { get; set; }
        public int ProgramEducationOrganizationId { get; set; }
        public string ProgramName { get; set; }
        public string ProgramType { get; set; }
        public decimal SchoolHoursPerWeek { get; set; }
        public decimal SpecialEducationHoursPerWeek { get; set; }
        public string SpecialEducationSettingDescriptor { get; set; }
        public string StudentUniqueId { get; set; }
    }

    public class StudentSpecialEducationProgramAssociationGetByIds : IHasIdentifiers<Guid>
    {
        public StudentSpecialEducationProgramAssociationGetByIds() { }

        public StudentSpecialEducationProgramAssociationGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class StudentSpecialEducationProgramAssociationPost : EdFi.Ods.Api.Models.Resources.V2.StudentSpecialEducationProgramAssociation.StudentSpecialEducationProgramAssociation
    {
    }

    public class StudentSpecialEducationProgramAssociationPut : EdFi.Ods.Api.Models.Resources.V2.StudentSpecialEducationProgramAssociation.StudentSpecialEducationProgramAssociation
    { 
    }

    public class StudentSpecialEducationProgramAssociationDelete : IHasIdentifier 
    {
        public StudentSpecialEducationProgramAssociationDelete() { }

        public StudentSpecialEducationProgramAssociationDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.StudentTitleIPartAProgramAssociations
{ 
    public class StudentTitleIPartAProgramAssociationGetByKey
    {
        public DateTime BeginDate { get; set; }
        public int EducationOrganizationId { get; set; }
        public int ProgramEducationOrganizationId { get; set; }
        public string ProgramName { get; set; }
        public string ProgramType { get; set; }
        public string StudentUniqueId { get; set; }
    }

    public class StudentTitleIPartAProgramAssociationGetByExample
    {
        public DateTime BeginDate { get; set; }
        public int EducationOrganizationId { get; set; }
        public int ProgramEducationOrganizationId { get; set; }
        public string ProgramName { get; set; }
        public string ProgramType { get; set; }
        public string StudentUniqueId { get; set; }
        public string TitleIPartAParticipantType { get; set; }
    }

    public class StudentTitleIPartAProgramAssociationGetByIds : IHasIdentifiers<Guid>
    {
        public StudentTitleIPartAProgramAssociationGetByIds() { }

        public StudentTitleIPartAProgramAssociationGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class StudentTitleIPartAProgramAssociationPost : EdFi.Ods.Api.Models.Resources.V2.StudentTitleIPartAProgramAssociation.StudentTitleIPartAProgramAssociation
    {
    }

    public class StudentTitleIPartAProgramAssociationPut : EdFi.Ods.Api.Models.Resources.V2.StudentTitleIPartAProgramAssociation.StudentTitleIPartAProgramAssociation
    { 
    }

    public class StudentTitleIPartAProgramAssociationDelete : IHasIdentifier 
    {
        public StudentTitleIPartAProgramAssociationDelete() { }

        public StudentTitleIPartAProgramAssociationDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.TeachingCredentialBasisTypes
{ 
    public class TeachingCredentialBasisTypeGetByKey
    {
        public int TeachingCredentialBasisTypeId { get; set; }
    }

    public class TeachingCredentialBasisTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
        public int TeachingCredentialBasisTypeId { get; set; }
    }

    public class TeachingCredentialBasisTypeGetByIds : IHasIdentifiers<Guid>
    {
        public TeachingCredentialBasisTypeGetByIds() { }

        public TeachingCredentialBasisTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class TeachingCredentialBasisTypePost : EdFi.Ods.Api.Models.Resources.V2.TeachingCredentialBasisType.TeachingCredentialBasisType
    {
    }

    public class TeachingCredentialBasisTypePut : EdFi.Ods.Api.Models.Resources.V2.TeachingCredentialBasisType.TeachingCredentialBasisType
    { 
    }

    public class TeachingCredentialBasisTypeDelete : IHasIdentifier 
    {
        public TeachingCredentialBasisTypeDelete() { }

        public TeachingCredentialBasisTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.TeachingCredentialDescriptors
{ 
    public class TeachingCredentialDescriptorGetByKey
    {
        public int TeachingCredentialDescriptorId { get; set; }
    }

    public class TeachingCredentialDescriptorGetByExample
    {
        public int TeachingCredentialDescriptorId { get; set; }
        public string TeachingCredentialType { get; set; }
    }

    public class TeachingCredentialDescriptorGetByIds : IHasIdentifiers<Guid>
    {
        public TeachingCredentialDescriptorGetByIds() { }

        public TeachingCredentialDescriptorGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class TeachingCredentialDescriptorPost : EdFi.Ods.Api.Models.Resources.V2.TeachingCredentialDescriptor.TeachingCredentialDescriptor
    {
    }

    public class TeachingCredentialDescriptorPut : EdFi.Ods.Api.Models.Resources.V2.TeachingCredentialDescriptor.TeachingCredentialDescriptor
    { 
    }

    public class TeachingCredentialDescriptorDelete : IHasIdentifier 
    {
        public TeachingCredentialDescriptorDelete() { }

        public TeachingCredentialDescriptorDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.TeachingCredentialTypes
{ 
    public class TeachingCredentialTypeGetByKey
    {
        public int TeachingCredentialTypeId { get; set; }
    }

    public class TeachingCredentialTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
        public int TeachingCredentialTypeId { get; set; }
    }

    public class TeachingCredentialTypeGetByIds : IHasIdentifiers<Guid>
    {
        public TeachingCredentialTypeGetByIds() { }

        public TeachingCredentialTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class TeachingCredentialTypePost : EdFi.Ods.Api.Models.Resources.V2.TeachingCredentialType.TeachingCredentialType
    {
    }

    public class TeachingCredentialTypePut : EdFi.Ods.Api.Models.Resources.V2.TeachingCredentialType.TeachingCredentialType
    { 
    }

    public class TeachingCredentialTypeDelete : IHasIdentifier 
    {
        public TeachingCredentialTypeDelete() { }

        public TeachingCredentialTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.TelephoneNumberTypes
{ 
    public class TelephoneNumberTypeGetByKey
    {
        public int TelephoneNumberTypeId { get; set; }
    }

    public class TelephoneNumberTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
        public int TelephoneNumberTypeId { get; set; }
    }

    public class TelephoneNumberTypeGetByIds : IHasIdentifiers<Guid>
    {
        public TelephoneNumberTypeGetByIds() { }

        public TelephoneNumberTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class TelephoneNumberTypePost : EdFi.Ods.Api.Models.Resources.V2.TelephoneNumberType.TelephoneNumberType
    {
    }

    public class TelephoneNumberTypePut : EdFi.Ods.Api.Models.Resources.V2.TelephoneNumberType.TelephoneNumberType
    { 
    }

    public class TelephoneNumberTypeDelete : IHasIdentifier 
    {
        public TelephoneNumberTypeDelete() { }

        public TelephoneNumberTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.TermDescriptors
{ 
    public class TermDescriptorGetByKey
    {
        public int TermDescriptorId { get; set; }
    }

    public class TermDescriptorGetByExample
    {
        public int TermDescriptorId { get; set; }
        public string TermType { get; set; }
    }

    public class TermDescriptorGetByIds : IHasIdentifiers<Guid>
    {
        public TermDescriptorGetByIds() { }

        public TermDescriptorGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class TermDescriptorPost : EdFi.Ods.Api.Models.Resources.V2.TermDescriptor.TermDescriptor
    {
    }

    public class TermDescriptorPut : EdFi.Ods.Api.Models.Resources.V2.TermDescriptor.TermDescriptor
    { 
    }

    public class TermDescriptorDelete : IHasIdentifier 
    {
        public TermDescriptorDelete() { }

        public TermDescriptorDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.TermTypes
{ 
    public class TermTypeGetByKey
    {
        public int TermTypeId { get; set; }
    }

    public class TermTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
        public int TermTypeId { get; set; }
    }

    public class TermTypeGetByIds : IHasIdentifiers<Guid>
    {
        public TermTypeGetByIds() { }

        public TermTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class TermTypePost : EdFi.Ods.Api.Models.Resources.V2.TermType.TermType
    {
    }

    public class TermTypePut : EdFi.Ods.Api.Models.Resources.V2.TermType.TermType
    { 
    }

    public class TermTypeDelete : IHasIdentifier 
    {
        public TermTypeDelete() { }

        public TermTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.TitleIPartAParticipantTypes
{ 
    public class TitleIPartAParticipantTypeGetByKey
    {
        public int TitleIPartAParticipantTypeId { get; set; }
    }

    public class TitleIPartAParticipantTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
        public int TitleIPartAParticipantTypeId { get; set; }
    }

    public class TitleIPartAParticipantTypeGetByIds : IHasIdentifiers<Guid>
    {
        public TitleIPartAParticipantTypeGetByIds() { }

        public TitleIPartAParticipantTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class TitleIPartAParticipantTypePost : EdFi.Ods.Api.Models.Resources.V2.TitleIPartAParticipantType.TitleIPartAParticipantType
    {
    }

    public class TitleIPartAParticipantTypePut : EdFi.Ods.Api.Models.Resources.V2.TitleIPartAParticipantType.TitleIPartAParticipantType
    { 
    }

    public class TitleIPartAParticipantTypeDelete : IHasIdentifier 
    {
        public TitleIPartAParticipantTypeDelete() { }

        public TitleIPartAParticipantTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.TitleIPartASchoolDesignationTypes
{ 
    public class TitleIPartASchoolDesignationTypeGetByKey
    {
        public int TitleIPartASchoolDesignationTypeId { get; set; }
    }

    public class TitleIPartASchoolDesignationTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
        public int TitleIPartASchoolDesignationTypeId { get; set; }
    }

    public class TitleIPartASchoolDesignationTypeGetByIds : IHasIdentifiers<Guid>
    {
        public TitleIPartASchoolDesignationTypeGetByIds() { }

        public TitleIPartASchoolDesignationTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class TitleIPartASchoolDesignationTypePost : EdFi.Ods.Api.Models.Resources.V2.TitleIPartASchoolDesignationType.TitleIPartASchoolDesignationType
    {
    }

    public class TitleIPartASchoolDesignationTypePut : EdFi.Ods.Api.Models.Resources.V2.TitleIPartASchoolDesignationType.TitleIPartASchoolDesignationType
    { 
    }

    public class TitleIPartASchoolDesignationTypeDelete : IHasIdentifier 
    {
        public TitleIPartASchoolDesignationTypeDelete() { }

        public TitleIPartASchoolDesignationTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.VisaTypes
{ 
    public class VisaTypeGetByKey
    {
        public int VisaTypeId { get; set; }
    }

    public class VisaTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
        public int VisaTypeId { get; set; }
    }

    public class VisaTypeGetByIds : IHasIdentifiers<Guid>
    {
        public VisaTypeGetByIds() { }

        public VisaTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class VisaTypePost : EdFi.Ods.Api.Models.Resources.V2.VisaType.VisaType
    {
    }

    public class VisaTypePut : EdFi.Ods.Api.Models.Resources.V2.VisaType.VisaType
    { 
    }

    public class VisaTypeDelete : IHasIdentifier 
    {
        public VisaTypeDelete() { }

        public VisaTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.WeaponDescriptors
{ 
    public class WeaponDescriptorGetByKey
    {
        public int WeaponDescriptorId { get; set; }
    }

    public class WeaponDescriptorGetByExample
    {
        public int WeaponDescriptorId { get; set; }
        public string WeaponType { get; set; }
    }

    public class WeaponDescriptorGetByIds : IHasIdentifiers<Guid>
    {
        public WeaponDescriptorGetByIds() { }

        public WeaponDescriptorGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class WeaponDescriptorPost : EdFi.Ods.Api.Models.Resources.V2.WeaponDescriptor.WeaponDescriptor
    {
    }

    public class WeaponDescriptorPut : EdFi.Ods.Api.Models.Resources.V2.WeaponDescriptor.WeaponDescriptor
    { 
    }

    public class WeaponDescriptorDelete : IHasIdentifier 
    {
        public WeaponDescriptorDelete() { }

        public WeaponDescriptorDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

namespace EdFi.Ods.Api.Models.Requests.v2.WeaponTypes
{ 
    public class WeaponTypeGetByKey
    {
        public int WeaponTypeId { get; set; }
    }

    public class WeaponTypeGetByExample
    {
        public string CodeValue { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public string ShortDescription { get; set; }
        public int WeaponTypeId { get; set; }
    }

    public class WeaponTypeGetByIds : IHasIdentifiers<Guid>
    {
        public WeaponTypeGetByIds() { }

        public WeaponTypeGetByIds(params Guid[] ids)
        {
            Ids = new List<Guid>(ids);
        }

        public List<Guid> Ids { get; set; }
    }

    public class WeaponTypePost : EdFi.Ods.Api.Models.Resources.V2.WeaponType.WeaponType
    {
    }

    public class WeaponTypePut : EdFi.Ods.Api.Models.Resources.V2.WeaponType.WeaponType
    { 
    }

    public class WeaponTypeDelete : IHasIdentifier 
    {
        public WeaponTypeDelete() { }

        public WeaponTypeDelete(Guid id) 
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}

