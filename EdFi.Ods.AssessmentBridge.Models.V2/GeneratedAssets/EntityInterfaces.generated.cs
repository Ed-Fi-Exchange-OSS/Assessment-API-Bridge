
using System;
using System.Collections.Generic;
using EdFi.Ods.Api.Models;
using EdFi.Ods.Common;
#pragma warning disable 108,114

namespace EdFi.Ods.Entities.Common
{ 

    /// <summary>
    /// Interface for the edfi.AcademicHonorCategoryType table of the AcademicHonorCategoryType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IAcademicHonorCategoryType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int AcademicHonorCategoryTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.AcademicSubjectDescriptor table of the AcademicSubjectDescriptor aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IAcademicSubjectDescriptor : IDescriptor, ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int AcademicSubjectDescriptorId { get; set; }

        // Inherited non-PK properties
        //string CodeValue { get; set; }
        //string Description { get; set; }
        //DateTime? EffectiveBeginDate { get; set; }
        //DateTime? EffectiveEndDate { get; set; }
        //string Namespace { get; set; }
        //int? PriorDescriptorId { get; set; }
        //string ShortDescription { get; set; }

        // Non-PK properties
        string AcademicSubjectType { get; set; }

        // Inherited lists

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.AcademicSubjectType table of the AcademicSubjectType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IAcademicSubjectType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int AcademicSubjectTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.AcademicWeek table of the AcademicWeek aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IAcademicWeek : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        int SchoolId { get; set; }
        [NaturalKeyMember]
        string WeekIdentifier { get; set; }

        // Non-PK properties
        DateTime BeginDate { get; set; }
        DateTime EndDate { get; set; }
        int TotalInstructionalDays { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.AccommodationDescriptor table of the AccommodationDescriptor aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IAccommodationDescriptor : IDescriptor, ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int AccommodationDescriptorId { get; set; }

        // Inherited non-PK properties
        //string CodeValue { get; set; }
        //string Description { get; set; }
        //DateTime? EffectiveBeginDate { get; set; }
        //DateTime? EffectiveEndDate { get; set; }
        //string Namespace { get; set; }
        //int? PriorDescriptorId { get; set; }
        //string ShortDescription { get; set; }

        // Non-PK properties
        string AccommodationType { get; set; }

        // Inherited lists

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.AccommodationType table of the AccommodationType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IAccommodationType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int AccommodationTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.Account table of the Account aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IAccount : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        string AccountNumber { get; set; }
        [NaturalKeyMember]
        int EducationOrganizationId { get; set; }
        [NaturalKeyMember]
        int FiscalYear { get; set; }

        // Non-PK properties

        // Lists
        IList<IAccountCode> AccountCodes { get; set; }
    } 

    /// <summary>
    /// Interface for the edfi.AccountabilityRating table of the AccountabilityRating aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IAccountabilityRating : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        int EducationOrganizationId { get; set; }
        [NaturalKeyMember]
        string RatingTitle { get; set; }
        [NaturalKeyMember]
        short SchoolYear { get; set; }

        // Non-PK properties
        string Rating { get; set; }
        DateTime? RatingDate { get; set; }
        string RatingOrganization { get; set; }
        string RatingProgram { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.AccountCode table of the Account aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IAccountCode : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IAccount Account { get; set; }
        [NaturalKeyMember]
        string AccountCodeDescriptor { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.AccountCodeDescriptor table of the AccountCodeDescriptor aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IAccountCodeDescriptor : IDescriptor, ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int AccountCodeDescriptorId { get; set; }

        // Inherited non-PK properties
        //string CodeValue { get; set; }
        //string Description { get; set; }
        //DateTime? EffectiveBeginDate { get; set; }
        //DateTime? EffectiveEndDate { get; set; }
        //string Namespace { get; set; }
        //int? PriorDescriptorId { get; set; }
        //string ShortDescription { get; set; }

        // Non-PK properties
        string AccountCodeCategory { get; set; }
        DateTime? BeginDate { get; set; }
        DateTime? EndDate { get; set; }

        // Inherited lists

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.AchievementCategoryDescriptor table of the AchievementCategoryDescriptor aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IAchievementCategoryDescriptor : IDescriptor, ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int AchievementCategoryDescriptorId { get; set; }

        // Inherited non-PK properties
        //string CodeValue { get; set; }
        //string Description { get; set; }
        //DateTime? EffectiveBeginDate { get; set; }
        //DateTime? EffectiveEndDate { get; set; }
        //string Namespace { get; set; }
        //int? PriorDescriptorId { get; set; }
        //string ShortDescription { get; set; }

        // Non-PK properties
        string AchievementCategoryType { get; set; }

        // Inherited lists

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.AchievementCategoryType table of the AchievementCategoryType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IAchievementCategoryType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int AchievementCategoryTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.Actual table of the Actual aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IActual : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        string AccountNumber { get; set; }
        [NaturalKeyMember]
        DateTime AsOfDate { get; set; }
        [NaturalKeyMember]
        int EducationOrganizationId { get; set; }
        [NaturalKeyMember]
        int FiscalYear { get; set; }

        // Non-PK properties
        decimal AmountToDate { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.AdditionalCreditType table of the AdditionalCreditType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IAdditionalCreditType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int AdditionalCreditTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.AddressType table of the AddressType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IAddressType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int AddressTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.AdministrationEnvironmentType table of the AdministrationEnvironmentType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IAdministrationEnvironmentType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int AdministrationEnvironmentTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.AdministrativeFundingControlDescriptor table of the AdministrativeFundingControlDescriptor aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IAdministrativeFundingControlDescriptor : IDescriptor, ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int AdministrativeFundingControlDescriptorId { get; set; }

        // Inherited non-PK properties
        //string CodeValue { get; set; }
        //string Description { get; set; }
        //DateTime? EffectiveBeginDate { get; set; }
        //DateTime? EffectiveEndDate { get; set; }
        //string Namespace { get; set; }
        //int? PriorDescriptorId { get; set; }
        //string ShortDescription { get; set; }

        // Non-PK properties
        string AdministrativeFundingControlType { get; set; }

        // Inherited lists

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.AdministrativeFundingControlType table of the AdministrativeFundingControlType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IAdministrativeFundingControlType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int AdministrativeFundingControlTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.Assessment table of the Assessment aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IAssessment : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        string AssessmentIdentifier { get; set; }
        [NaturalKeyMember]
        string Namespace { get; set; }

        // Non-PK properties
        bool? AdaptiveAssessment { get; set; }
        string AssessmentCategoryDescriptor { get; set; }
        string AssessmentFamilyTitle { get; set; }
        string AssessmentForm { get; set; }
        string AssessmentPeriodDescriptor { get; set; }
        string AssessmentTitle { get; set; }
        int? EducationOrganizationId { get; set; }
        int? MaxRawScore { get; set; }
        string Nomenclature { get; set; }
        DateTime? RevisionDate { get; set; }
        int? Version { get; set; }

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        IAssessmentContentStandard AssessmentContentStandard { get; set; }

        // -------------------------------------------------------------

        // Lists
        IList<IAssessmentAcademicSubject> AssessmentAcademicSubjects { get; set; }
        IList<IAssessmentAssessedGradeLevel> AssessmentAssessedGradeLevels { get; set; }
        IList<IAssessmentIdentificationCode> AssessmentIdentificationCodes { get; set; }
        IList<IAssessmentLanguage> AssessmentLanguages { get; set; }
        IList<IAssessmentPerformanceLevel> AssessmentPerformanceLevels { get; set; }
        IList<IAssessmentProgram> AssessmentPrograms { get; set; }
        IList<IAssessmentScore> AssessmentScores { get; set; }
        IList<IAssessmentSection> AssessmentSections { get; set; }
    } 

    /// <summary>
    /// Interface for the edfi.AssessmentAcademicSubject table of the Assessment aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IAssessmentAcademicSubject : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IAssessment Assessment { get; set; }
        [NaturalKeyMember]
        string AcademicSubjectDescriptor { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.AssessmentAssessedGradeLevel table of the Assessment aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IAssessmentAssessedGradeLevel : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IAssessment Assessment { get; set; }
        [NaturalKeyMember]
        string GradeLevelDescriptor { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.AssessmentCategoryDescriptor table of the AssessmentCategoryDescriptor aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IAssessmentCategoryDescriptor : IDescriptor, ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int AssessmentCategoryDescriptorId { get; set; }

        // Inherited non-PK properties
        //string CodeValue { get; set; }
        //string Description { get; set; }
        //DateTime? EffectiveBeginDate { get; set; }
        //DateTime? EffectiveEndDate { get; set; }
        //string Namespace { get; set; }
        //int? PriorDescriptorId { get; set; }
        //string ShortDescription { get; set; }

        // Non-PK properties
        string AssessmentCategoryType { get; set; }

        // Inherited lists

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.AssessmentCategoryType table of the AssessmentCategoryType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IAssessmentCategoryType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int AssessmentCategoryTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.AssessmentContentStandard table of the Assessment aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IAssessmentContentStandard : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IAssessment Assessment { get; set; }

        // Non-PK properties
        DateTime? BeginDate { get; set; }
        DateTime? EndDate { get; set; }
        int? MandatingEducationOrganizationId { get; set; }
        DateTime? PublicationDate { get; set; }
        string PublicationStatusType { get; set; }
        short? PublicationYear { get; set; }
        string Title { get; set; }
        string URI { get; set; }
        string Version { get; set; }

        // Lists
        IList<IAssessmentContentStandardAuthor> AssessmentContentStandardAuthors { get; set; }
    } 

    /// <summary>
    /// Interface for the edfi.AssessmentContentStandardAuthor table of the Assessment aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IAssessmentContentStandardAuthor : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IAssessmentContentStandard AssessmentContentStandard { get; set; }
        [NaturalKeyMember]
        string Author { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.AssessmentFamily table of the AssessmentFamily aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IAssessmentFamily : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        string AssessmentFamilyTitle { get; set; }

        // Non-PK properties
        string AcademicSubjectDescriptor { get; set; }
        string AssessedGradeLevelDescriptor { get; set; }
        string AssessmentCategoryDescriptor { get; set; }
        string LowestAssessedGradeLevelDescriptor { get; set; }
        string Namespace { get; set; }
        string Nomenclature { get; set; }
        string ParentAssessmentFamilyTitle { get; set; }
        DateTime? RevisionDate { get; set; }
        int? Version { get; set; }

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        IAssessmentFamilyContentStandard AssessmentFamilyContentStandard { get; set; }

        // -------------------------------------------------------------

        // Lists
        IList<IAssessmentFamilyAssessmentPeriod> AssessmentFamilyAssessmentPeriods { get; set; }
        IList<IAssessmentFamilyIdentificationCode> AssessmentFamilyIdentificationCodes { get; set; }
        IList<IAssessmentFamilyLanguage> AssessmentFamilyLanguages { get; set; }
    } 

    /// <summary>
    /// Interface for the edfi.AssessmentFamilyAssessmentPeriod table of the AssessmentFamily aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IAssessmentFamilyAssessmentPeriod : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IAssessmentFamily AssessmentFamily { get; set; }
        [NaturalKeyMember]
        string AssessmentPeriodDescriptor { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.AssessmentFamilyContentStandard table of the AssessmentFamily aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IAssessmentFamilyContentStandard : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IAssessmentFamily AssessmentFamily { get; set; }

        // Non-PK properties
        DateTime? BeginDate { get; set; }
        DateTime? EndDate { get; set; }
        int? MandatingEducationOrganizationId { get; set; }
        DateTime? PublicationDate { get; set; }
        string PublicationStatusType { get; set; }
        short? PublicationYear { get; set; }
        string Title { get; set; }
        string URI { get; set; }
        string Version { get; set; }

        // Lists
        IList<IAssessmentFamilyContentStandardAuthor> AssessmentFamilyContentStandardAuthors { get; set; }
    } 

    /// <summary>
    /// Interface for the edfi.AssessmentFamilyContentStandardAuthor table of the AssessmentFamily aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IAssessmentFamilyContentStandardAuthor : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IAssessmentFamilyContentStandard AssessmentFamilyContentStandard { get; set; }
        [NaturalKeyMember]
        string Author { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.AssessmentFamilyIdentificationCode table of the AssessmentFamily aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IAssessmentFamilyIdentificationCode : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IAssessmentFamily AssessmentFamily { get; set; }
        [NaturalKeyMember]
        string AssessmentIdentificationSystemDescriptor { get; set; }

        // Non-PK properties
        string AssigningOrganizationIdentificationCode { get; set; }
        string IdentificationCode { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.AssessmentFamilyLanguage table of the AssessmentFamily aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IAssessmentFamilyLanguage : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IAssessmentFamily AssessmentFamily { get; set; }
        [NaturalKeyMember]
        string LanguageDescriptor { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.AssessmentIdentificationCode table of the Assessment aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IAssessmentIdentificationCode : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IAssessment Assessment { get; set; }
        [NaturalKeyMember]
        string AssessmentIdentificationSystemDescriptor { get; set; }

        // Non-PK properties
        string AssigningOrganizationIdentificationCode { get; set; }
        string IdentificationCode { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.AssessmentIdentificationSystemDescriptor table of the AssessmentIdentificationSystemDescriptor aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IAssessmentIdentificationSystemDescriptor : IDescriptor, ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int AssessmentIdentificationSystemDescriptorId { get; set; }

        // Inherited non-PK properties
        //string CodeValue { get; set; }
        //string Description { get; set; }
        //DateTime? EffectiveBeginDate { get; set; }
        //DateTime? EffectiveEndDate { get; set; }
        //string Namespace { get; set; }
        //int? PriorDescriptorId { get; set; }
        //string ShortDescription { get; set; }

        // Non-PK properties
        string AssessmentIdentificationSystemType { get; set; }

        // Inherited lists

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.AssessmentIdentificationSystemType table of the AssessmentIdentificationSystemType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IAssessmentIdentificationSystemType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int AssessmentIdentificationSystemTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.AssessmentItem table of the AssessmentItem aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IAssessmentItem : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        string AssessmentIdentifier { get; set; }
        [NaturalKeyMember]
        string IdentificationCode { get; set; }
        [NaturalKeyMember]
        string Namespace { get; set; }

        // Non-PK properties
        string AssessmentItemCategoryType { get; set; }
        string CorrectResponse { get; set; }
        string ExpectedTimeAssessed { get; set; }
        int? MaxRawScore { get; set; }
        string Nomenclature { get; set; }

        // Lists
        IList<IAssessmentItemLearningStandard> AssessmentItemLearningStandards { get; set; }
    } 

    /// <summary>
    /// Interface for the edfi.AssessmentItemCategoryType table of the AssessmentItemCategoryType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IAssessmentItemCategoryType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int AssessmentItemCategoryTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.AssessmentItemLearningStandard table of the AssessmentItem aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IAssessmentItemLearningStandard : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IAssessmentItem AssessmentItem { get; set; }
        [NaturalKeyMember]
        string LearningStandardId { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.AssessmentItemResultType table of the AssessmentItemResultType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IAssessmentItemResultType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int AssessmentItemResultTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.AssessmentLanguage table of the Assessment aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IAssessmentLanguage : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IAssessment Assessment { get; set; }
        [NaturalKeyMember]
        string LanguageDescriptor { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.AssessmentPerformanceLevel table of the Assessment aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IAssessmentPerformanceLevel : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IAssessment Assessment { get; set; }
        [NaturalKeyMember]
        string AssessmentReportingMethodType { get; set; }
        [NaturalKeyMember]
        string PerformanceLevelDescriptor { get; set; }

        // Non-PK properties
        string MaximumScore { get; set; }
        string MinimumScore { get; set; }
        string ResultDatatypeType { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.AssessmentPeriodDescriptor table of the AssessmentPeriodDescriptor aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IAssessmentPeriodDescriptor : IDescriptor, ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int AssessmentPeriodDescriptorId { get; set; }

        // Inherited non-PK properties
        //string CodeValue { get; set; }
        //string Description { get; set; }
        //DateTime? EffectiveBeginDate { get; set; }
        //DateTime? EffectiveEndDate { get; set; }
        //string Namespace { get; set; }
        //int? PriorDescriptorId { get; set; }
        //string ShortDescription { get; set; }

        // Non-PK properties
        DateTime? BeginDate { get; set; }
        DateTime? EndDate { get; set; }

        // Inherited lists

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.AssessmentProgram table of the Assessment aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IAssessmentProgram : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IAssessment Assessment { get; set; }
        [NaturalKeyMember]
        int EducationOrganizationId { get; set; }
        [NaturalKeyMember]
        string ProgramName { get; set; }
        [NaturalKeyMember]
        string ProgramType { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.AssessmentReportingMethodType table of the AssessmentReportingMethodType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IAssessmentReportingMethodType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int AssessmentReportingMethodTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.AssessmentScore table of the Assessment aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IAssessmentScore : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IAssessment Assessment { get; set; }
        [NaturalKeyMember]
        string AssessmentReportingMethodType { get; set; }

        // Non-PK properties
        string MaximumScore { get; set; }
        string MinimumScore { get; set; }
        string ResultDatatypeType { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.AssessmentSection table of the Assessment aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IAssessmentSection : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IAssessment Assessment { get; set; }
        [NaturalKeyMember]
        string ClassPeriodName { get; set; }
        [NaturalKeyMember]
        string ClassroomIdentificationCode { get; set; }
        [NaturalKeyMember]
        string LocalCourseCode { get; set; }
        [NaturalKeyMember]
        int SchoolId { get; set; }
        [NaturalKeyMember]
        short SchoolYear { get; set; }
        [NaturalKeyMember]
        int SequenceOfCourse { get; set; }
        [NaturalKeyMember]
        string TermDescriptor { get; set; }
        [NaturalKeyMember]
        string UniqueSectionCode { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.AttendanceEventCategoryDescriptor table of the AttendanceEventCategoryDescriptor aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IAttendanceEventCategoryDescriptor : IDescriptor, ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int AttendanceEventCategoryDescriptorId { get; set; }

        // Inherited non-PK properties
        //string CodeValue { get; set; }
        //string Description { get; set; }
        //DateTime? EffectiveBeginDate { get; set; }
        //DateTime? EffectiveEndDate { get; set; }
        //string Namespace { get; set; }
        //int? PriorDescriptorId { get; set; }
        //string ShortDescription { get; set; }

        // Non-PK properties
        string AttendanceEventCategoryType { get; set; }

        // Inherited lists

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.AttendanceEventCategoryType table of the AttendanceEventCategoryType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IAttendanceEventCategoryType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int AttendanceEventCategoryTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.BehaviorDescriptor table of the BehaviorDescriptor aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IBehaviorDescriptor : IDescriptor, ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int BehaviorDescriptorId { get; set; }

        // Inherited non-PK properties
        //string CodeValue { get; set; }
        //string Description { get; set; }
        //DateTime? EffectiveBeginDate { get; set; }
        //DateTime? EffectiveEndDate { get; set; }
        //string Namespace { get; set; }
        //int? PriorDescriptorId { get; set; }
        //string ShortDescription { get; set; }

        // Non-PK properties
        string BehaviorType { get; set; }

        // Inherited lists

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.BehaviorType table of the BehaviorType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IBehaviorType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int BehaviorTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.BellSchedule table of the BellSchedule aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IBellSchedule : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        string BellScheduleName { get; set; }
        [NaturalKeyMember]
        DateTime Date { get; set; }
        [NaturalKeyMember]
        string GradeLevelDescriptor { get; set; }
        [NaturalKeyMember]
        int SchoolId { get; set; }

        // Non-PK properties

        // Lists
        IList<IBellScheduleMeetingTime> BellScheduleMeetingTimes { get; set; }
    } 

    /// <summary>
    /// Interface for the edfi.BellScheduleMeetingTime table of the BellSchedule aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IBellScheduleMeetingTime : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IBellSchedule BellSchedule { get; set; }
        [NaturalKeyMember]
        string ClassPeriodName { get; set; }
        [NaturalKeyMember]
        TimeSpan StartTime { get; set; }

        // Non-PK properties
        string AlternateDayName { get; set; }
        TimeSpan EndTime { get; set; }
        bool? OfficialAttendancePeriod { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.Budget table of the Budget aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IBudget : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        string AccountNumber { get; set; }
        [NaturalKeyMember]
        DateTime AsOfDate { get; set; }
        [NaturalKeyMember]
        int EducationOrganizationId { get; set; }
        [NaturalKeyMember]
        int FiscalYear { get; set; }

        // Non-PK properties
        decimal Amount { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.CalendarDate table of the CalendarDate aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ICalendarDate : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        DateTime Date { get; set; }
        [NaturalKeyMember]
        int SchoolId { get; set; }

        // Non-PK properties

        // Lists
        IList<ICalendarDateCalendarEvent> CalendarDateCalendarEvents { get; set; }
    } 

    /// <summary>
    /// Interface for the edfi.CalendarDateCalendarEvent table of the CalendarDate aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ICalendarDateCalendarEvent : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        ICalendarDate CalendarDate { get; set; }
        [NaturalKeyMember]
        string CalendarEventDescriptor { get; set; }

        // Non-PK properties
        decimal EventDuration { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.CalendarEventDescriptor table of the CalendarEventDescriptor aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ICalendarEventDescriptor : IDescriptor, ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int CalendarEventDescriptorId { get; set; }

        // Inherited non-PK properties
        //string CodeValue { get; set; }
        //string Description { get; set; }
        //DateTime? EffectiveBeginDate { get; set; }
        //DateTime? EffectiveEndDate { get; set; }
        //string Namespace { get; set; }
        //int? PriorDescriptorId { get; set; }
        //string ShortDescription { get; set; }

        // Non-PK properties
        string CalendarEventType { get; set; }

        // Inherited lists

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.CalendarEventType table of the CalendarEventType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ICalendarEventType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int CalendarEventTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.CareerPathwayType table of the CareerPathwayType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ICareerPathwayType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int CareerPathwayTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.CharterApprovalAgencyType table of the CharterApprovalAgencyType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ICharterApprovalAgencyType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int CharterApprovalAgencyTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.CharterStatusType table of the CharterStatusType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ICharterStatusType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int CharterStatusTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.CitizenshipStatusType table of the CitizenshipStatusType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ICitizenshipStatusType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int CitizenshipStatusTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.ClassPeriod table of the ClassPeriod aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IClassPeriod : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        string ClassPeriodName { get; set; }
        [NaturalKeyMember]
        int SchoolId { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.ClassroomPositionDescriptor table of the ClassroomPositionDescriptor aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IClassroomPositionDescriptor : IDescriptor, ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int ClassroomPositionDescriptorId { get; set; }

        // Inherited non-PK properties
        //string CodeValue { get; set; }
        //string Description { get; set; }
        //DateTime? EffectiveBeginDate { get; set; }
        //DateTime? EffectiveEndDate { get; set; }
        //string Namespace { get; set; }
        //int? PriorDescriptorId { get; set; }
        //string ShortDescription { get; set; }

        // Non-PK properties
        string ClassroomPositionType { get; set; }

        // Inherited lists

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.ClassroomPositionType table of the ClassroomPositionType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IClassroomPositionType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int ClassroomPositionTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.Cohort table of the Cohort aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ICohort : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        string CohortIdentifier { get; set; }
        [NaturalKeyMember]
        int EducationOrganizationId { get; set; }

        // Non-PK properties
        string AcademicSubjectDescriptor { get; set; }
        string CohortDescription { get; set; }
        string CohortScopeType { get; set; }
        string CohortType { get; set; }

        // Lists
        IList<ICohortProgram> CohortPrograms { get; set; }
    } 

    /// <summary>
    /// Interface for the edfi.CohortProgram table of the Cohort aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ICohortProgram : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        ICohort Cohort { get; set; }
        [NaturalKeyMember]
        int ProgramEducationOrganizationId { get; set; }
        [NaturalKeyMember]
        string ProgramName { get; set; }
        [NaturalKeyMember]
        string ProgramType { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.CohortScopeType table of the CohortScopeType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ICohortScopeType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int CohortScopeTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.CohortType table of the CohortType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ICohortType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int CohortTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.CohortYearType table of the CohortYearType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ICohortYearType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int CohortYearTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.CompetencyLevelDescriptor table of the CompetencyLevelDescriptor aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ICompetencyLevelDescriptor : IDescriptor, ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int CompetencyLevelDescriptorId { get; set; }

        // Inherited non-PK properties
        //string CodeValue { get; set; }
        //string Description { get; set; }
        //DateTime? EffectiveBeginDate { get; set; }
        //DateTime? EffectiveEndDate { get; set; }
        //string Namespace { get; set; }
        //int? PriorDescriptorId { get; set; }
        //string ShortDescription { get; set; }

        // Non-PK properties
        string PerformanceBaseConversionType { get; set; }

        // Inherited lists

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.CompetencyObjective table of the CompetencyObjective aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ICompetencyObjective : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        int EducationOrganizationId { get; set; }
        [NaturalKeyMember]
        string Objective { get; set; }
        [NaturalKeyMember]
        string ObjectiveGradeLevelDescriptor { get; set; }

        // Non-PK properties
        string CompetencyObjectiveId { get; set; }
        string Description { get; set; }
        string SuccessCriteria { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.ContentClassType table of the ContentClassType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IContentClassType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int ContentClassTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.ContinuationOfServicesReasonDescriptor table of the ContinuationOfServicesReasonDescriptor aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IContinuationOfServicesReasonDescriptor : IDescriptor, ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int ContinuationOfServicesReasonDescriptorId { get; set; }

        // Inherited non-PK properties
        //string CodeValue { get; set; }
        //string Description { get; set; }
        //DateTime? EffectiveBeginDate { get; set; }
        //DateTime? EffectiveEndDate { get; set; }
        //string Namespace { get; set; }
        //int? PriorDescriptorId { get; set; }
        //string ShortDescription { get; set; }

        // Non-PK properties
        string ContinuationOfServicesReasonType { get; set; }

        // Inherited lists

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.ContinuationOfServicesReasonType table of the ContinuationOfServicesReasonType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IContinuationOfServicesReasonType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int ContinuationOfServicesReasonTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.ContractedStaff table of the ContractedStaff aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IContractedStaff : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        string AccountNumber { get; set; }
        [NaturalKeyMember]
        DateTime AsOfDate { get; set; }
        [NaturalKeyMember]
        int EducationOrganizationId { get; set; }
        [NaturalKeyMember]
        int FiscalYear { get; set; }
        [NaturalKeyMember]
        string StaffUniqueId { get; set; }

        // Non-PK properties
        decimal AmountToDate { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.CostRateType table of the CostRateType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ICostRateType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int CostRateTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.CountryDescriptor table of the CountryDescriptor aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ICountryDescriptor : IDescriptor, ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int CountryDescriptorId { get; set; }

        // Inherited non-PK properties
        //string CodeValue { get; set; }
        //string Description { get; set; }
        //DateTime? EffectiveBeginDate { get; set; }
        //DateTime? EffectiveEndDate { get; set; }
        //string Namespace { get; set; }
        //int? PriorDescriptorId { get; set; }
        //string ShortDescription { get; set; }

        // Non-PK properties

        // Inherited lists

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.Course table of the Course aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ICourse : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        string CourseCode { get; set; }
        [NaturalKeyMember]
        int EducationOrganizationId { get; set; }

        // Non-PK properties
        string AcademicSubjectDescriptor { get; set; }
        string CareerPathwayType { get; set; }
        string CourseDefinedByType { get; set; }
        string CourseDescription { get; set; }
        string CourseGPAApplicabilityType { get; set; }
        string CourseTitle { get; set; }
        DateTime? DateCourseAdopted { get; set; }
        bool? HighSchoolCourseRequirement { get; set; }
        decimal? MaximumAvailableCreditConversion { get; set; }
        decimal? MaximumAvailableCredits { get; set; }
        string MaximumAvailableCreditType { get; set; }
        decimal? MinimumAvailableCreditConversion { get; set; }
        decimal? MinimumAvailableCredits { get; set; }
        string MinimumAvailableCreditType { get; set; }
        int NumberOfParts { get; set; }
        int? TimeRequiredForCompletion { get; set; }

        // Lists
        IList<ICourseCompetencyLevel> CourseCompetencyLevels { get; set; }
        IList<ICourseIdentificationCode> CourseIdentificationCodes { get; set; }
        IList<ICourseLearningObjective> CourseLearningObjectives { get; set; }
        IList<ICourseLearningStandard> CourseLearningStandards { get; set; }
        IList<ICourseLevelCharacteristic> CourseLevelCharacteristics { get; set; }
        IList<ICourseOfferedGradeLevel> CourseOfferedGradeLevels { get; set; }
    } 

    /// <summary>
    /// Interface for the edfi.CourseAttemptResultType table of the CourseAttemptResultType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ICourseAttemptResultType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int CourseAttemptResultTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.CourseCompetencyLevel table of the Course aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ICourseCompetencyLevel : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        ICourse Course { get; set; }
        [NaturalKeyMember]
        string CompetencyLevelDescriptor { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.CourseDefinedByType table of the CourseDefinedByType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ICourseDefinedByType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int CourseDefinedByTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.CourseGPAApplicabilityType table of the CourseGPAApplicabilityType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ICourseGPAApplicabilityType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int CourseGPAApplicabilityTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.CourseIdentificationCode table of the Course aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ICourseIdentificationCode : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        ICourse Course { get; set; }
        [NaturalKeyMember]
        string CourseIdentificationSystemDescriptor { get; set; }

        // Non-PK properties
        string AssigningOrganizationIdentificationCode { get; set; }
        string IdentificationCode { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.CourseIdentificationSystemDescriptor table of the CourseIdentificationSystemDescriptor aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ICourseIdentificationSystemDescriptor : IDescriptor, ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int CourseIdentificationSystemDescriptorId { get; set; }

        // Inherited non-PK properties
        //string CodeValue { get; set; }
        //string Description { get; set; }
        //DateTime? EffectiveBeginDate { get; set; }
        //DateTime? EffectiveEndDate { get; set; }
        //string Namespace { get; set; }
        //int? PriorDescriptorId { get; set; }
        //string ShortDescription { get; set; }

        // Non-PK properties
        string CourseIdentificationSystemType { get; set; }

        // Inherited lists

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.CourseIdentificationSystemType table of the CourseIdentificationSystemType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ICourseIdentificationSystemType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int CourseIdentificationSystemTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.CourseLearningObjective table of the Course aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ICourseLearningObjective : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        ICourse Course { get; set; }
        [NaturalKeyMember]
        string LearningObjectiveId { get; set; }
        [NaturalKeyMember]
        string Namespace { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.CourseLearningStandard table of the Course aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ICourseLearningStandard : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        ICourse Course { get; set; }
        [NaturalKeyMember]
        string LearningStandardId { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.CourseLevelCharacteristic table of the Course aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ICourseLevelCharacteristic : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        ICourse Course { get; set; }
        [NaturalKeyMember]
        string CourseLevelCharacteristicType { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.CourseLevelCharacteristicType table of the CourseLevelCharacteristicType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ICourseLevelCharacteristicType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int CourseLevelCharacteristicTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.CourseOfferedGradeLevel table of the Course aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ICourseOfferedGradeLevel : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        ICourse Course { get; set; }
        [NaturalKeyMember]
        string GradeLevelDescriptor { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.CourseOffering table of the CourseOffering aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ICourseOffering : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        string LocalCourseCode { get; set; }
        [NaturalKeyMember]
        int SchoolId { get; set; }
        [NaturalKeyMember]
        short SchoolYear { get; set; }
        [NaturalKeyMember]
        string TermDescriptor { get; set; }

        // Non-PK properties
        string CourseCode { get; set; }
        int EducationOrganizationId { get; set; }
        int? InstructionalTimePlanned { get; set; }
        string LocalCourseTitle { get; set; }

        // Lists
        IList<ICourseOfferingCurriculumUsed> CourseOfferingCurriculumUseds { get; set; }
    } 

    /// <summary>
    /// Interface for the edfi.CourseOfferingCurriculumUsed table of the CourseOffering aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ICourseOfferingCurriculumUsed : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        ICourseOffering CourseOffering { get; set; }
        [NaturalKeyMember]
        string CurriculumUsedType { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.CourseRepeatCodeType table of the CourseRepeatCodeType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ICourseRepeatCodeType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int CourseRepeatCodeTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.CourseTranscript table of the CourseTranscript aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ICourseTranscript : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        string CourseAttemptResultType { get; set; }
        [NaturalKeyMember]
        string CourseCode { get; set; }
        [NaturalKeyMember]
        int CourseEducationOrganizationId { get; set; }
        [NaturalKeyMember]
        int EducationOrganizationId { get; set; }
        [NaturalKeyMember]
        short SchoolYear { get; set; }
        [NaturalKeyMember]
        string StudentUniqueId { get; set; }
        [NaturalKeyMember]
        string TermDescriptor { get; set; }

        // Non-PK properties
        string AlternativeCourseCode { get; set; }
        string AlternativeCourseTitle { get; set; }
        decimal? AttemptedCreditConversion { get; set; }
        decimal? AttemptedCredits { get; set; }
        string AttemptedCreditType { get; set; }
        string CourseRepeatCodeType { get; set; }
        string CourseTitle { get; set; }
        decimal? EarnedCreditConversion { get; set; }
        decimal EarnedCredits { get; set; }
        string EarnedCreditType { get; set; }
        string FinalLetterGradeEarned { get; set; }
        decimal? FinalNumericGradeEarned { get; set; }
        string MethodCreditEarnedType { get; set; }
        int? SchoolId { get; set; }
        string WhenTakenGradeLevelDescriptor { get; set; }

        // Lists
        IList<ICourseTranscriptEarnedAdditionalCredits> CourseTranscriptEarnedAdditionalCredits { get; set; }
    } 

    /// <summary>
    /// Interface for the edfi.CourseTranscriptEarnedAdditionalCredits table of the CourseTranscript aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ICourseTranscriptEarnedAdditionalCredits : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        ICourseTranscript CourseTranscript { get; set; }
        [NaturalKeyMember]
        string AdditionalCreditType { get; set; }

        // Non-PK properties
        decimal Credits { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.CredentialFieldDescriptor table of the CredentialFieldDescriptor aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ICredentialFieldDescriptor : IDescriptor, ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int CredentialFieldDescriptorId { get; set; }

        // Inherited non-PK properties
        //string CodeValue { get; set; }
        //string Description { get; set; }
        //DateTime? EffectiveBeginDate { get; set; }
        //DateTime? EffectiveEndDate { get; set; }
        //string Namespace { get; set; }
        //int? PriorDescriptorId { get; set; }
        //string ShortDescription { get; set; }

        // Non-PK properties
        string AcademicSubjectDescriptor { get; set; }

        // Inherited lists

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.CredentialType table of the CredentialType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ICredentialType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int CredentialTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.CreditType table of the CreditType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ICreditType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int CreditTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.CurriculumUsedType table of the CurriculumUsedType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ICurriculumUsedType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int CurriculumUsedTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.DeliveryMethodType table of the DeliveryMethodType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IDeliveryMethodType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int DeliveryMethodTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.Descriptor table of the Descriptor aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IDescriptor : IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int DescriptorId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        DateTime? EffectiveBeginDate { get; set; }
        DateTime? EffectiveEndDate { get; set; }
        string Namespace { get; set; }
        int? PriorDescriptorId { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.DiagnosisDescriptor table of the DiagnosisDescriptor aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IDiagnosisDescriptor : IDescriptor, ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int DiagnosisDescriptorId { get; set; }

        // Inherited non-PK properties
        //string CodeValue { get; set; }
        //string Description { get; set; }
        //DateTime? EffectiveBeginDate { get; set; }
        //DateTime? EffectiveEndDate { get; set; }
        //string Namespace { get; set; }
        //int? PriorDescriptorId { get; set; }
        //string ShortDescription { get; set; }

        // Non-PK properties
        string DiagnosisType { get; set; }

        // Inherited lists

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.DiagnosisType table of the DiagnosisType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IDiagnosisType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int DiagnosisTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.DiplomaLevelType table of the DiplomaLevelType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IDiplomaLevelType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int DiplomaLevelTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.DiplomaType table of the DiplomaType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IDiplomaType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int DiplomaTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.DisabilityCategoryType table of the DisabilityCategoryType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IDisabilityCategoryType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int DisabilityCategoryTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.DisabilityDescriptor table of the DisabilityDescriptor aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IDisabilityDescriptor : IDescriptor, ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int DisabilityDescriptorId { get; set; }

        // Inherited non-PK properties
        //string CodeValue { get; set; }
        //string Description { get; set; }
        //DateTime? EffectiveBeginDate { get; set; }
        //DateTime? EffectiveEndDate { get; set; }
        //string Namespace { get; set; }
        //int? PriorDescriptorId { get; set; }
        //string ShortDescription { get; set; }

        // Non-PK properties
        string DisabilityCategoryType { get; set; }
        string DisabilityType { get; set; }

        // Inherited lists

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.DisabilityDeterminationSourceType table of the DisabilityDeterminationSourceType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IDisabilityDeterminationSourceType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int DisabilityDeterminationSourceTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.DisabilityType table of the DisabilityType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IDisabilityType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int DisabilityTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.DisciplineAction table of the DisciplineAction aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IDisciplineAction : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        string DisciplineActionIdentifier { get; set; }
        [NaturalKeyMember]
        DateTime DisciplineDate { get; set; }
        [NaturalKeyMember]
        string StudentUniqueId { get; set; }

        // Non-PK properties
        int? ActualDisciplineActionLength { get; set; }
        int? AssignmentSchoolId { get; set; }
        int? DisciplineActionLength { get; set; }
        string DisciplineActionLengthDifferenceReasonType { get; set; }
        bool? RelatedToZeroTolerancePolicy { get; set; }
        int ResponsibilitySchoolId { get; set; }

        // Lists
        IList<IDisciplineActionDisciplineIncident> DisciplineActionDisciplineIncidents { get; set; }
        IList<IDisciplineActionDiscipline> DisciplineActionDisciplines { get; set; }
        IList<IDisciplineActionStaff> DisciplineActionStaffs { get; set; }
    } 

    /// <summary>
    /// Interface for the edfi.DisciplineActionDiscipline table of the DisciplineAction aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IDisciplineActionDiscipline : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IDisciplineAction DisciplineAction { get; set; }
        [NaturalKeyMember]
        string DisciplineDescriptor { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.DisciplineActionDisciplineIncident table of the DisciplineAction aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IDisciplineActionDisciplineIncident : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IDisciplineAction DisciplineAction { get; set; }
        [NaturalKeyMember]
        string IncidentIdentifier { get; set; }
        [NaturalKeyMember]
        int SchoolId { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.DisciplineActionLengthDifferenceReasonType table of the DisciplineActionLengthDifferenceReasonType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IDisciplineActionLengthDifferenceReasonType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int DisciplineActionLengthDifferenceReasonTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.DisciplineActionStaff table of the DisciplineAction aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IDisciplineActionStaff : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IDisciplineAction DisciplineAction { get; set; }
        [NaturalKeyMember]
        string StaffUniqueId { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.DisciplineDescriptor table of the DisciplineDescriptor aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IDisciplineDescriptor : IDescriptor, ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int DisciplineDescriptorId { get; set; }

        // Inherited non-PK properties
        //string CodeValue { get; set; }
        //string Description { get; set; }
        //DateTime? EffectiveBeginDate { get; set; }
        //DateTime? EffectiveEndDate { get; set; }
        //string Namespace { get; set; }
        //int? PriorDescriptorId { get; set; }
        //string ShortDescription { get; set; }

        // Non-PK properties
        string DisciplineType { get; set; }

        // Inherited lists

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.DisciplineIncident table of the DisciplineIncident aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IDisciplineIncident : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        string IncidentIdentifier { get; set; }
        [NaturalKeyMember]
        int SchoolId { get; set; }

        // Non-PK properties
        string CaseNumber { get; set; }
        decimal? IncidentCost { get; set; }
        DateTime IncidentDate { get; set; }
        string IncidentDescription { get; set; }
        string IncidentLocationType { get; set; }
        TimeSpan? IncidentTime { get; set; }
        bool? ReportedToLawEnforcement { get; set; }
        string ReporterDescriptionDescriptor { get; set; }
        string ReporterName { get; set; }
        string StaffUniqueId { get; set; }

        // Lists
        IList<IDisciplineIncidentBehavior> DisciplineIncidentBehaviors { get; set; }
        IList<IDisciplineIncidentWeapon> DisciplineIncidentWeapons { get; set; }
    } 

    /// <summary>
    /// Interface for the edfi.DisciplineIncidentBehavior table of the DisciplineIncident aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IDisciplineIncidentBehavior : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IDisciplineIncident DisciplineIncident { get; set; }
        [NaturalKeyMember]
        string BehaviorDescriptor { get; set; }

        // Non-PK properties
        string BehaviorDetailedDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.DisciplineIncidentWeapon table of the DisciplineIncident aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IDisciplineIncidentWeapon : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IDisciplineIncident DisciplineIncident { get; set; }
        [NaturalKeyMember]
        string WeaponDescriptor { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.DisciplineType table of the DisciplineType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IDisciplineType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int DisciplineTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.EducationalEnvironmentType table of the EducationalEnvironmentType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IEducationalEnvironmentType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int EducationalEnvironmentTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.EducationContent table of the EducationContent aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IEducationContent : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        string ContentIdentifier { get; set; }

        // Non-PK properties
        bool? AdditionalAuthorsIndicator { get; set; }
        string ContentClassType { get; set; }
        decimal? Cost { get; set; }
        string CostRateType { get; set; }
        string Description { get; set; }
        string InteractivityStyleType { get; set; }
        string LearningResourceMetadataURI { get; set; }
        string LearningStandardId { get; set; }
        string Namespace { get; set; }
        DateTime? PublicationDate { get; set; }
        short? PublicationYear { get; set; }
        string Publisher { get; set; }
        string ShortDescription { get; set; }
        string TimeRequired { get; set; }
        string UseRightsURL { get; set; }
        string Version { get; set; }

        // Lists
        IList<IEducationContentAppropriateGradeLevel> EducationContentAppropriateGradeLevels { get; set; }
        IList<IEducationContentAppropriateSex> EducationContentAppropriateSexes { get; set; }
        IList<IEducationContentAuthor> EducationContentAuthors { get; set; }
        IList<IEducationContentDerivativeSourceEducationContent> EducationContentDerivativeSourceEducationContents { get; set; }
        IList<IEducationContentDerivativeSourceLearningResourceMetadataURI> EducationContentDerivativeSourceLearningResourceMetadataURIs { get; set; }
        IList<IEducationContentDerivativeSourceURI> EducationContentDerivativeSourceURIs { get; set; }
        IList<IEducationContentLanguage> EducationContentLanguages { get; set; }
    } 

    /// <summary>
    /// Interface for the edfi.EducationContentAppropriateGradeLevel table of the EducationContent aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IEducationContentAppropriateGradeLevel : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IEducationContent EducationContent { get; set; }
        [NaturalKeyMember]
        string GradeLevelDescriptor { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.EducationContentAppropriateSex table of the EducationContent aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IEducationContentAppropriateSex : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IEducationContent EducationContent { get; set; }
        [NaturalKeyMember]
        string SexType { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.EducationContentAuthor table of the EducationContent aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IEducationContentAuthor : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IEducationContent EducationContent { get; set; }
        [NaturalKeyMember]
        string Author { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.EducationContentDerivativeSourceEducationContent table of the EducationContent aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IEducationContentDerivativeSourceEducationContent : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IEducationContent EducationContent { get; set; }
        [NaturalKeyMember]
        string DerivativeSourceContentIdentifier { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.EducationContentDerivativeSourceLearningResourceMetadataURI table of the EducationContent aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IEducationContentDerivativeSourceLearningResourceMetadataURI : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IEducationContent EducationContent { get; set; }
        [NaturalKeyMember]
        string LearningResourceMetadataURI { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.EducationContentDerivativeSourceURI table of the EducationContent aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IEducationContentDerivativeSourceURI : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IEducationContent EducationContent { get; set; }
        [NaturalKeyMember]
        string URI { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.EducationContentLanguage table of the EducationContent aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IEducationContentLanguage : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IEducationContent EducationContent { get; set; }
        [NaturalKeyMember]
        string LanguageDescriptor { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.EducationOrganization table of the EducationOrganization aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IEducationOrganization : IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        int EducationOrganizationId { get; set; }

        // Non-PK properties
        string NameOfInstitution { get; set; }
        string OperationalStatusType { get; set; }
        string ShortNameOfInstitution { get; set; }
        string StateOrganizationId { get; set; }
        string WebSite { get; set; }

        // Lists
        IList<IEducationOrganizationAddress> EducationOrganizationAddresses { get; set; }
        IList<IEducationOrganizationCategory> EducationOrganizationCategories { get; set; }
        IList<IEducationOrganizationIdentificationCode> EducationOrganizationIdentificationCodes { get; set; }
        IList<IEducationOrganizationInstitutionTelephone> EducationOrganizationInstitutionTelephones { get; set; }
        IList<IEducationOrganizationInternationalAddress> EducationOrganizationInternationalAddresses { get; set; }
    } 

    /// <summary>
    /// Interface for the edfi.EducationOrganizationAddress table of the EducationOrganization aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IEducationOrganizationAddress : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IEducationOrganization EducationOrganization { get; set; }
        [NaturalKeyMember]
        string AddressType { get; set; }

        // Non-PK properties
        string ApartmentRoomSuiteNumber { get; set; }
        DateTime? BeginDate { get; set; }
        string BuildingSiteNumber { get; set; }
        string City { get; set; }
        string CountyFIPSCode { get; set; }
        DateTime? EndDate { get; set; }
        string Latitude { get; set; }
        string Longitude { get; set; }
        string NameOfCounty { get; set; }
        string PostalCode { get; set; }
        string StateAbbreviationType { get; set; }
        string StreetNumberName { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.EducationOrganizationCategory table of the EducationOrganization aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IEducationOrganizationCategory : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IEducationOrganization EducationOrganization { get; set; }
        [NaturalKeyMember]
        string EducationOrganizationCategoryType { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.EducationOrganizationCategoryType table of the EducationOrganizationCategoryType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IEducationOrganizationCategoryType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int EducationOrganizationCategoryTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.EducationOrganizationIdentificationCode table of the EducationOrganization aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IEducationOrganizationIdentificationCode : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IEducationOrganization EducationOrganization { get; set; }
        [NaturalKeyMember]
        string EducationOrganizationIdentificationSystemDescriptor { get; set; }

        // Non-PK properties
        string IdentificationCode { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.EducationOrganizationIdentificationSystemDescriptor table of the EducationOrganizationIdentificationSystemDescriptor aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IEducationOrganizationIdentificationSystemDescriptor : IDescriptor, ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int EducationOrganizationIdentificationSystemDescriptorId { get; set; }

        // Inherited non-PK properties
        //string CodeValue { get; set; }
        //string Description { get; set; }
        //DateTime? EffectiveBeginDate { get; set; }
        //DateTime? EffectiveEndDate { get; set; }
        //string Namespace { get; set; }
        //int? PriorDescriptorId { get; set; }
        //string ShortDescription { get; set; }

        // Non-PK properties
        string EducationOrganizationIdentificationSystemType { get; set; }

        // Inherited lists

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.EducationOrganizationIdentificationSystemType table of the EducationOrganizationIdentificationSystemType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IEducationOrganizationIdentificationSystemType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int EducationOrganizationIdentificationSystemTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.EducationOrganizationInstitutionTelephone table of the EducationOrganization aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IEducationOrganizationInstitutionTelephone : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IEducationOrganization EducationOrganization { get; set; }
        [NaturalKeyMember]
        string InstitutionTelephoneNumberType { get; set; }

        // Non-PK properties
        string TelephoneNumber { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.EducationOrganizationInternationalAddress table of the EducationOrganization aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IEducationOrganizationInternationalAddress : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IEducationOrganization EducationOrganization { get; set; }
        [NaturalKeyMember]
        string AddressType { get; set; }

        // Non-PK properties
        string AddressLine1 { get; set; }
        string AddressLine2 { get; set; }
        string AddressLine3 { get; set; }
        string AddressLine4 { get; set; }
        DateTime? BeginDate { get; set; }
        string CountryDescriptor { get; set; }
        DateTime? EndDate { get; set; }
        string Latitude { get; set; }
        string Longitude { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.EducationOrganizationInterventionPrescriptionAssociation table of the EducationOrganizationInterventionPrescriptionAssociation aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IEducationOrganizationInterventionPrescriptionAssociation : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        int EducationOrganizationId { get; set; }
        [NaturalKeyMember]
        int InterventionPrescriptionEducationOrganizationId { get; set; }
        [NaturalKeyMember]
        string InterventionPrescriptionIdentificationCode { get; set; }

        // Non-PK properties
        DateTime? BeginDate { get; set; }
        DateTime? EndDate { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.EducationOrganizationNetwork table of the EducationOrganizationNetwork aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IEducationOrganizationNetwork : IEducationOrganization, ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        int EducationOrganizationNetworkId { get; set; }

        // Inherited non-PK properties
        //string NameOfInstitution { get; set; }
        //string OperationalStatusType { get; set; }
        //string ShortNameOfInstitution { get; set; }
        //string StateOrganizationId { get; set; }
        //string WebSite { get; set; }

        // Non-PK properties
        string NetworkPurposeType { get; set; }

        // Inherited lists
        //IList<IEducationOrganizationAddress> EducationOrganizationAddresses { get; set; }
        //IList<IEducationOrganizationCategory> EducationOrganizationCategories { get; set; }
        //IList<IEducationOrganizationIdentificationCode> EducationOrganizationIdentificationCodes { get; set; }
        //IList<IEducationOrganizationInstitutionTelephone> EducationOrganizationInstitutionTelephones { get; set; }
        //IList<IEducationOrganizationInternationalAddress> EducationOrganizationInternationalAddresses { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.EducationOrganizationNetworkAssociation table of the EducationOrganizationNetworkAssociation aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IEducationOrganizationNetworkAssociation : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        int EducationOrganizationNetworkId { get; set; }
        [NaturalKeyMember]
        int MemberEducationOrganizationId { get; set; }

        // Non-PK properties
        DateTime? BeginDate { get; set; }
        DateTime? EndDate { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.EducationOrganizationPeerAssociation table of the EducationOrganizationPeerAssociation aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IEducationOrganizationPeerAssociation : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        int EducationOrganizationId { get; set; }
        [NaturalKeyMember]
        int PeerEducationOrganizationId { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.EducationPlanType table of the EducationPlanType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IEducationPlanType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int EducationPlanTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.EducationServiceCenter table of the EducationServiceCenter aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IEducationServiceCenter : IEducationOrganization, ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        int EducationServiceCenterId { get; set; }

        // Inherited non-PK properties
        //string NameOfInstitution { get; set; }
        //string OperationalStatusType { get; set; }
        //string ShortNameOfInstitution { get; set; }
        //string StateOrganizationId { get; set; }
        //string WebSite { get; set; }

        // Non-PK properties
        int? StateEducationAgencyId { get; set; }

        // Inherited lists
        //IList<IEducationOrganizationAddress> EducationOrganizationAddresses { get; set; }
        //IList<IEducationOrganizationCategory> EducationOrganizationCategories { get; set; }
        //IList<IEducationOrganizationIdentificationCode> EducationOrganizationIdentificationCodes { get; set; }
        //IList<IEducationOrganizationInstitutionTelephone> EducationOrganizationInstitutionTelephones { get; set; }
        //IList<IEducationOrganizationInternationalAddress> EducationOrganizationInternationalAddresses { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.ElectronicMailType table of the ElectronicMailType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IElectronicMailType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int ElectronicMailTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.EmploymentStatusDescriptor table of the EmploymentStatusDescriptor aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IEmploymentStatusDescriptor : IDescriptor, ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int EmploymentStatusDescriptorId { get; set; }

        // Inherited non-PK properties
        //string CodeValue { get; set; }
        //string Description { get; set; }
        //DateTime? EffectiveBeginDate { get; set; }
        //DateTime? EffectiveEndDate { get; set; }
        //string Namespace { get; set; }
        //int? PriorDescriptorId { get; set; }
        //string ShortDescription { get; set; }

        // Non-PK properties
        string EmploymentStatusType { get; set; }

        // Inherited lists

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.EmploymentStatusType table of the EmploymentStatusType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IEmploymentStatusType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int EmploymentStatusTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.EntryGradeLevelReasonType table of the EntryGradeLevelReasonType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IEntryGradeLevelReasonType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int EntryGradeLevelReasonTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.EntryType table of the EntryType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IEntryType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int EntryTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.EntryTypeDescriptor table of the EntryTypeDescriptor aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IEntryTypeDescriptor : IDescriptor, ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int EntryTypeDescriptorId { get; set; }

        // Inherited non-PK properties
        //string CodeValue { get; set; }
        //string Description { get; set; }
        //DateTime? EffectiveBeginDate { get; set; }
        //DateTime? EffectiveEndDate { get; set; }
        //string Namespace { get; set; }
        //int? PriorDescriptorId { get; set; }
        //string ShortDescription { get; set; }

        // Non-PK properties
        string EntryType { get; set; }

        // Inherited lists

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.EventCircumstanceType table of the EventCircumstanceType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IEventCircumstanceType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int EventCircumstanceTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.ExitWithdrawType table of the ExitWithdrawType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IExitWithdrawType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int ExitWithdrawTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.ExitWithdrawTypeDescriptor table of the ExitWithdrawTypeDescriptor aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IExitWithdrawTypeDescriptor : IDescriptor, ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int ExitWithdrawTypeDescriptorId { get; set; }

        // Inherited non-PK properties
        //string CodeValue { get; set; }
        //string Description { get; set; }
        //DateTime? EffectiveBeginDate { get; set; }
        //DateTime? EffectiveEndDate { get; set; }
        //string Namespace { get; set; }
        //int? PriorDescriptorId { get; set; }
        //string ShortDescription { get; set; }

        // Non-PK properties
        string ExitWithdrawType { get; set; }

        // Inherited lists

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.FeederSchoolAssociation table of the FeederSchoolAssociation aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IFeederSchoolAssociation : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        DateTime BeginDate { get; set; }
        [NaturalKeyMember]
        int FeederSchoolId { get; set; }
        [NaturalKeyMember]
        int SchoolId { get; set; }

        // Non-PK properties
        DateTime? EndDate { get; set; }
        string FeederRelationshipDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.Grade table of the Grade aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IGrade : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        DateTime BeginDate { get; set; }
        [NaturalKeyMember]
        string ClassPeriodName { get; set; }
        [NaturalKeyMember]
        string ClassroomIdentificationCode { get; set; }
        [NaturalKeyMember]
        string GradeType { get; set; }
        [NaturalKeyMember]
        DateTime GradingPeriodBeginDate { get; set; }
        [NaturalKeyMember]
        string GradingPeriodDescriptor { get; set; }
        [NaturalKeyMember]
        string LocalCourseCode { get; set; }
        [NaturalKeyMember]
        int SchoolId { get; set; }
        [NaturalKeyMember]
        short SchoolYear { get; set; }
        [NaturalKeyMember]
        int SequenceOfCourse { get; set; }
        [NaturalKeyMember]
        string StudentUniqueId { get; set; }
        [NaturalKeyMember]
        string TermDescriptor { get; set; }
        [NaturalKeyMember]
        string UniqueSectionCode { get; set; }

        // Non-PK properties
        string DiagnosticStatement { get; set; }
        string LetterGradeEarned { get; set; }
        decimal? NumericGradeEarned { get; set; }
        string PerformanceBaseConversionType { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.GradebookEntry table of the GradebookEntry aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IGradebookEntry : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        string ClassPeriodName { get; set; }
        [NaturalKeyMember]
        string ClassroomIdentificationCode { get; set; }
        [NaturalKeyMember]
        DateTime DateAssigned { get; set; }
        [NaturalKeyMember]
        string GradebookEntryTitle { get; set; }
        [NaturalKeyMember]
        string LocalCourseCode { get; set; }
        [NaturalKeyMember]
        int SchoolId { get; set; }
        [NaturalKeyMember]
        short SchoolYear { get; set; }
        [NaturalKeyMember]
        int SequenceOfCourse { get; set; }
        [NaturalKeyMember]
        string TermDescriptor { get; set; }
        [NaturalKeyMember]
        string UniqueSectionCode { get; set; }

        // Non-PK properties
        DateTime? BeginDate { get; set; }
        string Description { get; set; }
        string GradebookEntryType { get; set; }
        string GradingPeriodDescriptor { get; set; }

        // Lists
        IList<IGradebookEntryLearningObjective> GradebookEntryLearningObjectives { get; set; }
        IList<IGradebookEntryLearningStandard> GradebookEntryLearningStandards { get; set; }
    } 

    /// <summary>
    /// Interface for the edfi.GradebookEntryLearningObjective table of the GradebookEntry aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IGradebookEntryLearningObjective : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IGradebookEntry GradebookEntry { get; set; }
        [NaturalKeyMember]
        string LearningObjectiveId { get; set; }
        [NaturalKeyMember]
        string Namespace { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.GradebookEntryLearningStandard table of the GradebookEntry aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IGradebookEntryLearningStandard : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IGradebookEntry GradebookEntry { get; set; }
        [NaturalKeyMember]
        string LearningStandardId { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.GradebookEntryType table of the GradebookEntryType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IGradebookEntryType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int GradebookEntryTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.GradeLevelDescriptor table of the GradeLevelDescriptor aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IGradeLevelDescriptor : IDescriptor, ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int GradeLevelDescriptorId { get; set; }

        // Inherited non-PK properties
        //string CodeValue { get; set; }
        //string Description { get; set; }
        //DateTime? EffectiveBeginDate { get; set; }
        //DateTime? EffectiveEndDate { get; set; }
        //string Namespace { get; set; }
        //int? PriorDescriptorId { get; set; }
        //string ShortDescription { get; set; }

        // Non-PK properties
        string GradeLevelType { get; set; }

        // Inherited lists

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.GradeLevelType table of the GradeLevelType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IGradeLevelType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int GradeLevelTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.GradeType table of the GradeType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IGradeType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int GradeTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.GradingPeriod table of the GradingPeriod aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IGradingPeriod : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        DateTime BeginDate { get; set; }
        [NaturalKeyMember]
        string GradingPeriodDescriptor { get; set; }
        [NaturalKeyMember]
        int SchoolId { get; set; }

        // Non-PK properties
        DateTime EndDate { get; set; }
        int? PeriodSequence { get; set; }
        int TotalInstructionalDays { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.GradingPeriodDescriptor table of the GradingPeriodDescriptor aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IGradingPeriodDescriptor : IDescriptor, ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int GradingPeriodDescriptorId { get; set; }

        // Inherited non-PK properties
        //string CodeValue { get; set; }
        //string Description { get; set; }
        //DateTime? EffectiveBeginDate { get; set; }
        //DateTime? EffectiveEndDate { get; set; }
        //string Namespace { get; set; }
        //int? PriorDescriptorId { get; set; }
        //string ShortDescription { get; set; }

        // Non-PK properties
        string GradingPeriodType { get; set; }

        // Inherited lists

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.GradingPeriodType table of the GradingPeriodType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IGradingPeriodType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int GradingPeriodTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        int? PeriodSequence { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.GraduationPlan table of the GraduationPlan aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IGraduationPlan : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        int EducationOrganizationId { get; set; }
        [NaturalKeyMember]
        string GraduationPlanTypeDescriptor { get; set; }
        [NaturalKeyMember]
        short GraduationSchoolYear { get; set; }

        // Non-PK properties
        bool? IndividualPlan { get; set; }
        decimal? TotalRequiredCreditConversion { get; set; }
        decimal TotalRequiredCredits { get; set; }
        string TotalRequiredCreditType { get; set; }

        // Lists
        IList<IGraduationPlanCreditsByCourse> GraduationPlanCreditsByCourses { get; set; }
        IList<IGraduationPlanCreditsBySubject> GraduationPlanCreditsBySubjects { get; set; }
        IList<IGraduationPlanRequiredAssessment> GraduationPlanRequiredAssessments { get; set; }
    } 

    /// <summary>
    /// Interface for the edfi.GraduationPlanCreditsByCourse table of the GraduationPlan aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IGraduationPlanCreditsByCourse : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IGraduationPlan GraduationPlan { get; set; }
        [NaturalKeyMember]
        string CourseSetName { get; set; }

        // Non-PK properties
        decimal? CreditConversion { get; set; }
        decimal Credits { get; set; }
        string CreditType { get; set; }
        string WhenTakenGradeLevelDescriptor { get; set; }

        // Lists
        IList<IGraduationPlanCreditsByCourseCourse> GraduationPlanCreditsByCourseCourses { get; set; }
    } 

    /// <summary>
    /// Interface for the edfi.GraduationPlanCreditsByCourseCourse table of the GraduationPlan aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IGraduationPlanCreditsByCourseCourse : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IGraduationPlanCreditsByCourse GraduationPlanCreditsByCourse { get; set; }
        [NaturalKeyMember]
        string CourseCode { get; set; }
        [NaturalKeyMember]
        int CourseEducationOrganizationId { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.GraduationPlanCreditsBySubject table of the GraduationPlan aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IGraduationPlanCreditsBySubject : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IGraduationPlan GraduationPlan { get; set; }
        [NaturalKeyMember]
        string AcademicSubjectDescriptor { get; set; }

        // Non-PK properties
        decimal? CreditConversion { get; set; }
        decimal Credits { get; set; }
        string CreditType { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.GraduationPlanRequiredAssessment table of the GraduationPlan aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IGraduationPlanRequiredAssessment : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IGraduationPlan GraduationPlan { get; set; }
        [NaturalKeyMember]
        string AssessmentIdentifier { get; set; }
        [NaturalKeyMember]
        string Namespace { get; set; }

        // Non-PK properties

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        IGraduationPlanRequiredAssessmentAssessmentPerformanceLevel GraduationPlanRequiredAssessmentAssessmentPerformanceLevel { get; set; }

        // -------------------------------------------------------------

        // Lists
        IList<IGraduationPlanRequiredAssessmentScore> GraduationPlanRequiredAssessmentScores { get; set; }
    } 

    /// <summary>
    /// Interface for the edfi.GraduationPlanRequiredAssessmentAssessmentPerformanceLevel table of the GraduationPlan aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IGraduationPlanRequiredAssessmentAssessmentPerformanceLevel : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IGraduationPlanRequiredAssessment GraduationPlanRequiredAssessment { get; set; }

        // Non-PK properties
        string AssessmentReportingMethodType { get; set; }
        string MaximumScore { get; set; }
        string MinimumScore { get; set; }
        string PerformanceLevelDescriptor { get; set; }
        string ResultDatatypeType { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.GraduationPlanRequiredAssessmentScore table of the GraduationPlan aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IGraduationPlanRequiredAssessmentScore : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IGraduationPlanRequiredAssessment GraduationPlanRequiredAssessment { get; set; }
        [NaturalKeyMember]
        string AssessmentReportingMethodType { get; set; }

        // Non-PK properties
        string MaximumScore { get; set; }
        string MinimumScore { get; set; }
        string ResultDatatypeType { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.GraduationPlanType table of the GraduationPlanType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IGraduationPlanType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int GraduationPlanTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.GraduationPlanTypeDescriptor table of the GraduationPlanTypeDescriptor aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IGraduationPlanTypeDescriptor : IDescriptor, ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int GraduationPlanTypeDescriptorId { get; set; }

        // Inherited non-PK properties
        //string CodeValue { get; set; }
        //string Description { get; set; }
        //DateTime? EffectiveBeginDate { get; set; }
        //DateTime? EffectiveEndDate { get; set; }
        //string Namespace { get; set; }
        //int? PriorDescriptorId { get; set; }
        //string ShortDescription { get; set; }

        // Non-PK properties
        string GraduationPlanType { get; set; }

        // Inherited lists

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.GunFreeSchoolsActReportingStatusType table of the GunFreeSchoolsActReportingStatusType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IGunFreeSchoolsActReportingStatusType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int GunFreeSchoolsActReportingStatusTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.IdentificationDocumentUseType table of the IdentificationDocumentUseType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IIdentificationDocumentUseType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int IdentificationDocumentUseTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.IncidentLocationType table of the IncidentLocationType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IIncidentLocationType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int IncidentLocationTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.InstitutionTelephoneNumberType table of the InstitutionTelephoneNumberType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IInstitutionTelephoneNumberType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int InstitutionTelephoneNumberTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.IntegratedTechnologyStatusType table of the IntegratedTechnologyStatusType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IIntegratedTechnologyStatusType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int IntegratedTechnologyStatusTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.InteractivityStyleType table of the InteractivityStyleType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IInteractivityStyleType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int InteractivityStyleTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.InternetAccessType table of the InternetAccessType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IInternetAccessType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int InternetAccessTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.Intervention table of the Intervention aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IIntervention : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        int EducationOrganizationId { get; set; }
        [NaturalKeyMember]
        string InterventionIdentificationCode { get; set; }

        // Non-PK properties
        DateTime BeginDate { get; set; }
        string DeliveryMethodType { get; set; }
        DateTime? EndDate { get; set; }
        string InterventionClassType { get; set; }

        // Lists
        IList<IInterventionAppropriateGradeLevel> InterventionAppropriateGradeLevels { get; set; }
        IList<IInterventionAppropriateSex> InterventionAppropriateSexes { get; set; }
        IList<IInterventionDiagnosis> InterventionDiagnoses { get; set; }
        IList<IInterventionEducationContent> InterventionEducationContents { get; set; }
        IList<IInterventionInterventionPrescription> InterventionInterventionPrescriptions { get; set; }
        IList<IInterventionLearningResourceMetadataURI> InterventionLearningResourceMetadataURIs { get; set; }
        IList<IInterventionMeetingTime> InterventionMeetingTimes { get; set; }
        IList<IInterventionPopulationServed> InterventionPopulationServeds { get; set; }
        IList<IInterventionStaff> InterventionStaffs { get; set; }
        IList<IInterventionURI> InterventionURIs { get; set; }
    } 

    /// <summary>
    /// Interface for the edfi.InterventionAppropriateGradeLevel table of the Intervention aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IInterventionAppropriateGradeLevel : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IIntervention Intervention { get; set; }
        [NaturalKeyMember]
        string GradeLevelDescriptor { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.InterventionAppropriateSex table of the Intervention aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IInterventionAppropriateSex : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IIntervention Intervention { get; set; }
        [NaturalKeyMember]
        string SexType { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.InterventionClassType table of the InterventionClassType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IInterventionClassType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int InterventionClassTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.InterventionDiagnosis table of the Intervention aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IInterventionDiagnosis : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IIntervention Intervention { get; set; }
        [NaturalKeyMember]
        string DiagnosisDescriptor { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.InterventionEducationContent table of the Intervention aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IInterventionEducationContent : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IIntervention Intervention { get; set; }
        [NaturalKeyMember]
        string ContentIdentifier { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.InterventionEffectivenessRatingType table of the InterventionEffectivenessRatingType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IInterventionEffectivenessRatingType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int InterventionEffectivenessRatingTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.InterventionInterventionPrescription table of the Intervention aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IInterventionInterventionPrescription : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IIntervention Intervention { get; set; }
        [NaturalKeyMember]
        int InterventionPrescriptionEducationOrganizationId { get; set; }
        [NaturalKeyMember]
        string InterventionPrescriptionIdentificationCode { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.InterventionLearningResourceMetadataURI table of the Intervention aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IInterventionLearningResourceMetadataURI : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IIntervention Intervention { get; set; }
        [NaturalKeyMember]
        string LearningResourceMetadataURI { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.InterventionMeetingTime table of the Intervention aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IInterventionMeetingTime : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IIntervention Intervention { get; set; }
        [NaturalKeyMember]
        string ClassPeriodName { get; set; }
        [NaturalKeyMember]
        int SchoolId { get; set; }

        // Non-PK properties
        string AlternateDayName { get; set; }
        TimeSpan EndTime { get; set; }
        bool? OfficialAttendancePeriod { get; set; }
        TimeSpan StartTime { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.InterventionPopulationServed table of the Intervention aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IInterventionPopulationServed : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IIntervention Intervention { get; set; }
        [NaturalKeyMember]
        string PopulationServedType { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.InterventionPrescription table of the InterventionPrescription aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IInterventionPrescription : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        int EducationOrganizationId { get; set; }
        [NaturalKeyMember]
        string InterventionPrescriptionIdentificationCode { get; set; }

        // Non-PK properties
        string DeliveryMethodType { get; set; }
        string InterventionClassType { get; set; }

        // Lists
        IList<IInterventionPrescriptionAppropriateGradeLevel> InterventionPrescriptionAppropriateGradeLevels { get; set; }
        IList<IInterventionPrescriptionAppropriateSex> InterventionPrescriptionAppropriateSexes { get; set; }
        IList<IInterventionPrescriptionDiagnosis> InterventionPrescriptionDiagnoses { get; set; }
        IList<IInterventionPrescriptionEducationContent> InterventionPrescriptionEducationContents { get; set; }
        IList<IInterventionPrescriptionLearningResourceMetadataURI> InterventionPrescriptionLearningResourceMetadataURIs { get; set; }
        IList<IInterventionPrescriptionPopulationServed> InterventionPrescriptionPopulationServeds { get; set; }
        IList<IInterventionPrescriptionURI> InterventionPrescriptionURIs { get; set; }
    } 

    /// <summary>
    /// Interface for the edfi.InterventionPrescriptionAppropriateGradeLevel table of the InterventionPrescription aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IInterventionPrescriptionAppropriateGradeLevel : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IInterventionPrescription InterventionPrescription { get; set; }
        [NaturalKeyMember]
        string GradeLevelDescriptor { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.InterventionPrescriptionAppropriateSex table of the InterventionPrescription aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IInterventionPrescriptionAppropriateSex : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IInterventionPrescription InterventionPrescription { get; set; }
        [NaturalKeyMember]
        string SexType { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.InterventionPrescriptionDiagnosis table of the InterventionPrescription aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IInterventionPrescriptionDiagnosis : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IInterventionPrescription InterventionPrescription { get; set; }
        [NaturalKeyMember]
        string DiagnosisDescriptor { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.InterventionPrescriptionEducationContent table of the InterventionPrescription aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IInterventionPrescriptionEducationContent : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IInterventionPrescription InterventionPrescription { get; set; }
        [NaturalKeyMember]
        string ContentIdentifier { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.InterventionPrescriptionLearningResourceMetadataURI table of the InterventionPrescription aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IInterventionPrescriptionLearningResourceMetadataURI : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IInterventionPrescription InterventionPrescription { get; set; }
        [NaturalKeyMember]
        string LearningResourceMetadataURI { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.InterventionPrescriptionPopulationServed table of the InterventionPrescription aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IInterventionPrescriptionPopulationServed : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IInterventionPrescription InterventionPrescription { get; set; }
        [NaturalKeyMember]
        string PopulationServedType { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.InterventionPrescriptionURI table of the InterventionPrescription aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IInterventionPrescriptionURI : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IInterventionPrescription InterventionPrescription { get; set; }
        [NaturalKeyMember]
        string URI { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.InterventionStaff table of the Intervention aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IInterventionStaff : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IIntervention Intervention { get; set; }
        [NaturalKeyMember]
        string StaffUniqueId { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.InterventionStudy table of the InterventionStudy aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IInterventionStudy : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        int EducationOrganizationId { get; set; }
        [NaturalKeyMember]
        string InterventionStudyIdentificationCode { get; set; }

        // Non-PK properties
        string DeliveryMethodType { get; set; }
        string InterventionClassType { get; set; }
        int InterventionPrescriptionEducationOrganizationId { get; set; }
        string InterventionPrescriptionIdentificationCode { get; set; }
        int Participants { get; set; }

        // Lists
        IList<IInterventionStudyAppropriateGradeLevel> InterventionStudyAppropriateGradeLevels { get; set; }
        IList<IInterventionStudyAppropriateSex> InterventionStudyAppropriateSexes { get; set; }
        IList<IInterventionStudyEducationContent> InterventionStudyEducationContents { get; set; }
        IList<IInterventionStudyInterventionEffectiveness> InterventionStudyInterventionEffectivenesses { get; set; }
        IList<IInterventionStudyLearningResourceMetadataURI> InterventionStudyLearningResourceMetadataURIs { get; set; }
        IList<IInterventionStudyPopulationServed> InterventionStudyPopulationServeds { get; set; }
        IList<IInterventionStudyStateAbbreviation> InterventionStudyStateAbbreviations { get; set; }
        IList<IInterventionStudyURI> InterventionStudyURIs { get; set; }
    } 

    /// <summary>
    /// Interface for the edfi.InterventionStudyAppropriateGradeLevel table of the InterventionStudy aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IInterventionStudyAppropriateGradeLevel : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IInterventionStudy InterventionStudy { get; set; }
        [NaturalKeyMember]
        string GradeLevelDescriptor { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.InterventionStudyAppropriateSex table of the InterventionStudy aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IInterventionStudyAppropriateSex : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IInterventionStudy InterventionStudy { get; set; }
        [NaturalKeyMember]
        string SexType { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.InterventionStudyEducationContent table of the InterventionStudy aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IInterventionStudyEducationContent : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IInterventionStudy InterventionStudy { get; set; }
        [NaturalKeyMember]
        string ContentIdentifier { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.InterventionStudyInterventionEffectiveness table of the InterventionStudy aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IInterventionStudyInterventionEffectiveness : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IInterventionStudy InterventionStudy { get; set; }
        [NaturalKeyMember]
        string DiagnosisDescriptor { get; set; }
        [NaturalKeyMember]
        string GradeLevelDescriptor { get; set; }
        [NaturalKeyMember]
        string PopulationServedType { get; set; }

        // Non-PK properties
        int? ImprovementIndex { get; set; }
        string InterventionEffectivenessRatingType { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.InterventionStudyLearningResourceMetadataURI table of the InterventionStudy aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IInterventionStudyLearningResourceMetadataURI : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IInterventionStudy InterventionStudy { get; set; }
        [NaturalKeyMember]
        string LearningResourceMetadataURI { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.InterventionStudyPopulationServed table of the InterventionStudy aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IInterventionStudyPopulationServed : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IInterventionStudy InterventionStudy { get; set; }
        [NaturalKeyMember]
        string PopulationServedType { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.InterventionStudyStateAbbreviation table of the InterventionStudy aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IInterventionStudyStateAbbreviation : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IInterventionStudy InterventionStudy { get; set; }
        [NaturalKeyMember]
        string StateAbbreviationType { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.InterventionStudyURI table of the InterventionStudy aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IInterventionStudyURI : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IInterventionStudy InterventionStudy { get; set; }
        [NaturalKeyMember]
        string URI { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.InterventionURI table of the Intervention aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IInterventionURI : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IIntervention Intervention { get; set; }
        [NaturalKeyMember]
        string URI { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.LanguageDescriptor table of the LanguageDescriptor aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ILanguageDescriptor : IDescriptor, ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int LanguageDescriptorId { get; set; }

        // Inherited non-PK properties
        //string CodeValue { get; set; }
        //string Description { get; set; }
        //DateTime? EffectiveBeginDate { get; set; }
        //DateTime? EffectiveEndDate { get; set; }
        //string Namespace { get; set; }
        //int? PriorDescriptorId { get; set; }
        //string ShortDescription { get; set; }

        // Non-PK properties
        string LanguageType { get; set; }

        // Inherited lists

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.LanguageType table of the LanguageType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ILanguageType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int LanguageTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.LanguageUseType table of the LanguageUseType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ILanguageUseType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int LanguageUseTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.LearningObjective table of the LearningObjective aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ILearningObjective : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        string LearningObjectiveId { get; set; }
        [NaturalKeyMember]
        string Namespace { get; set; }

        // Non-PK properties
        string Description { get; set; }
        string Nomenclature { get; set; }
        string Objective { get; set; }
        string ParentLearningObjectiveId { get; set; }
        string ParentNamespace { get; set; }
        string SuccessCriteria { get; set; }

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        ILearningObjectiveContentStandard LearningObjectiveContentStandard { get; set; }

        // -------------------------------------------------------------

        // Lists
        IList<ILearningObjectiveAcademicSubject> LearningObjectiveAcademicSubjects { get; set; }
        IList<ILearningObjectiveGradeLevel> LearningObjectiveGradeLevels { get; set; }
        IList<ILearningObjectiveLearningStandard> LearningObjectiveLearningStandards { get; set; }
    } 

    /// <summary>
    /// Interface for the edfi.LearningObjectiveAcademicSubject table of the LearningObjective aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ILearningObjectiveAcademicSubject : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        ILearningObjective LearningObjective { get; set; }
        [NaturalKeyMember]
        string AcademicSubjectDescriptor { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.LearningObjectiveContentStandard table of the LearningObjective aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ILearningObjectiveContentStandard : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        ILearningObjective LearningObjective { get; set; }

        // Non-PK properties
        DateTime? BeginDate { get; set; }
        DateTime? EndDate { get; set; }
        int? MandatingEducationOrganizationId { get; set; }
        DateTime? PublicationDate { get; set; }
        string PublicationStatusType { get; set; }
        short? PublicationYear { get; set; }
        string Title { get; set; }
        string URI { get; set; }
        string Version { get; set; }

        // Lists
        IList<ILearningObjectiveContentStandardAuthor> LearningObjectiveContentStandardAuthors { get; set; }
    } 

    /// <summary>
    /// Interface for the edfi.LearningObjectiveContentStandardAuthor table of the LearningObjective aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ILearningObjectiveContentStandardAuthor : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        ILearningObjectiveContentStandard LearningObjectiveContentStandard { get; set; }
        [NaturalKeyMember]
        string Author { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.LearningObjectiveGradeLevel table of the LearningObjective aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ILearningObjectiveGradeLevel : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        ILearningObjective LearningObjective { get; set; }
        [NaturalKeyMember]
        string GradeLevelDescriptor { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.LearningObjectiveLearningStandard table of the LearningObjective aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ILearningObjectiveLearningStandard : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        ILearningObjective LearningObjective { get; set; }
        [NaturalKeyMember]
        string LearningStandardId { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.LearningStandard table of the LearningStandard aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ILearningStandard : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        string LearningStandardId { get; set; }

        // Non-PK properties
        string AcademicSubjectDescriptor { get; set; }
        string CourseTitle { get; set; }
        string Description { get; set; }
        string LearningStandardItemCode { get; set; }
        string Namespace { get; set; }
        string ParentLearningStandardId { get; set; }
        string SuccessCriteria { get; set; }
        string URI { get; set; }

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        ILearningStandardContentStandard LearningStandardContentStandard { get; set; }

        // -------------------------------------------------------------

        // Lists
        IList<ILearningStandardGradeLevel> LearningStandardGradeLevels { get; set; }
        IList<ILearningStandardIdentificationCode> LearningStandardIdentificationCodes { get; set; }
        IList<ILearningStandardPrerequisiteLearningStandard> LearningStandardPrerequisiteLearningStandards { get; set; }
    } 

    /// <summary>
    /// Interface for the edfi.LearningStandardContentStandard table of the LearningStandard aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ILearningStandardContentStandard : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        ILearningStandard LearningStandard { get; set; }

        // Non-PK properties
        DateTime? BeginDate { get; set; }
        DateTime? EndDate { get; set; }
        int? MandatingEducationOrganizationId { get; set; }
        DateTime? PublicationDate { get; set; }
        string PublicationStatusType { get; set; }
        short? PublicationYear { get; set; }
        string Title { get; set; }
        string URI { get; set; }
        string Version { get; set; }

        // Lists
        IList<ILearningStandardContentStandardAuthor> LearningStandardContentStandardAuthors { get; set; }
    } 

    /// <summary>
    /// Interface for the edfi.LearningStandardContentStandardAuthor table of the LearningStandard aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ILearningStandardContentStandardAuthor : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        ILearningStandardContentStandard LearningStandardContentStandard { get; set; }
        [NaturalKeyMember]
        string Author { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.LearningStandardGradeLevel table of the LearningStandard aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ILearningStandardGradeLevel : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        ILearningStandard LearningStandard { get; set; }
        [NaturalKeyMember]
        string GradeLevelDescriptor { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.LearningStandardIdentificationCode table of the LearningStandard aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ILearningStandardIdentificationCode : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        ILearningStandard LearningStandard { get; set; }
        [NaturalKeyMember]
        string ContentStandardName { get; set; }
        [NaturalKeyMember]
        string IdentificationCode { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.LearningStandardPrerequisiteLearningStandard table of the LearningStandard aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ILearningStandardPrerequisiteLearningStandard : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        ILearningStandard LearningStandard { get; set; }
        [NaturalKeyMember]
        string PrerequisiteLearningStandardId { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.LeaveEvent table of the LeaveEvent aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ILeaveEvent : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        DateTime EventDate { get; set; }
        [NaturalKeyMember]
        string LeaveEventCategoryType { get; set; }
        [NaturalKeyMember]
        string StaffUniqueId { get; set; }

        // Non-PK properties
        decimal? HoursOnLeave { get; set; }
        string LeaveEventReason { get; set; }
        bool? SubstituteAssigned { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.LeaveEventCategoryType table of the LeaveEventCategoryType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ILeaveEventCategoryType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int LeaveEventCategoryTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.LevelDescriptor table of the LevelDescriptor aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ILevelDescriptor : IDescriptor, ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int LevelDescriptorId { get; set; }

        // Inherited non-PK properties
        //string CodeValue { get; set; }
        //string Description { get; set; }
        //DateTime? EffectiveBeginDate { get; set; }
        //DateTime? EffectiveEndDate { get; set; }
        //string Namespace { get; set; }
        //int? PriorDescriptorId { get; set; }
        //string ShortDescription { get; set; }

        // Non-PK properties

        // Inherited lists

        // Lists
        IList<ILevelDescriptorGradeLevel> LevelDescriptorGradeLevels { get; set; }
    } 

    /// <summary>
    /// Interface for the edfi.LevelDescriptorGradeLevel table of the LevelDescriptor aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ILevelDescriptorGradeLevel : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        ILevelDescriptor LevelDescriptor { get; set; }
        [NaturalKeyMember]
        string GradeLevelDescriptor { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.LevelOfEducationDescriptor table of the LevelOfEducationDescriptor aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ILevelOfEducationDescriptor : IDescriptor, ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int LevelOfEducationDescriptorId { get; set; }

        // Inherited non-PK properties
        //string CodeValue { get; set; }
        //string Description { get; set; }
        //DateTime? EffectiveBeginDate { get; set; }
        //DateTime? EffectiveEndDate { get; set; }
        //string Namespace { get; set; }
        //int? PriorDescriptorId { get; set; }
        //string ShortDescription { get; set; }

        // Non-PK properties
        string LevelOfEducationType { get; set; }

        // Inherited lists

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.LevelOfEducationType table of the LevelOfEducationType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ILevelOfEducationType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int LevelOfEducationTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.LimitedEnglishProficiencyDescriptor table of the LimitedEnglishProficiencyDescriptor aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ILimitedEnglishProficiencyDescriptor : IDescriptor, ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int LimitedEnglishProficiencyDescriptorId { get; set; }

        // Inherited non-PK properties
        //string CodeValue { get; set; }
        //string Description { get; set; }
        //DateTime? EffectiveBeginDate { get; set; }
        //DateTime? EffectiveEndDate { get; set; }
        //string Namespace { get; set; }
        //int? PriorDescriptorId { get; set; }
        //string ShortDescription { get; set; }

        // Non-PK properties
        string LimitedEnglishProficiencyType { get; set; }

        // Inherited lists

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.LimitedEnglishProficiencyType table of the LimitedEnglishProficiencyType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ILimitedEnglishProficiencyType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int LimitedEnglishProficiencyTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.LocalEducationAgency table of the LocalEducationAgency aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ILocalEducationAgency : IEducationOrganization, ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        int LocalEducationAgencyId { get; set; }

        // Inherited non-PK properties
        //string NameOfInstitution { get; set; }
        //string OperationalStatusType { get; set; }
        //string ShortNameOfInstitution { get; set; }
        //string StateOrganizationId { get; set; }
        //string WebSite { get; set; }

        // Non-PK properties
        string CharterStatusType { get; set; }
        int? EducationServiceCenterId { get; set; }
        string LocalEducationAgencyCategoryType { get; set; }
        int? ParentLocalEducationAgencyId { get; set; }
        int? StateEducationAgencyId { get; set; }

        // Inherited lists
        //IList<IEducationOrganizationAddress> EducationOrganizationAddresses { get; set; }
        //IList<IEducationOrganizationCategory> EducationOrganizationCategories { get; set; }
        //IList<IEducationOrganizationIdentificationCode> EducationOrganizationIdentificationCodes { get; set; }
        //IList<IEducationOrganizationInstitutionTelephone> EducationOrganizationInstitutionTelephones { get; set; }
        //IList<IEducationOrganizationInternationalAddress> EducationOrganizationInternationalAddresses { get; set; }

        // Lists
        IList<ILocalEducationAgencyAccountability> LocalEducationAgencyAccountabilities { get; set; }
    } 

    /// <summary>
    /// Interface for the edfi.LocalEducationAgencyAccountability table of the LocalEducationAgency aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ILocalEducationAgencyAccountability : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        ILocalEducationAgency LocalEducationAgency { get; set; }
        [NaturalKeyMember]
        short SchoolYear { get; set; }

        // Non-PK properties
        string GunFreeSchoolsActReportingStatusType { get; set; }
        string SchoolChoiceImplementStatusType { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.LocalEducationAgencyCategoryType table of the LocalEducationAgencyCategoryType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ILocalEducationAgencyCategoryType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int LocalEducationAgencyCategoryTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.Location table of the Location aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ILocation : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        string ClassroomIdentificationCode { get; set; }
        [NaturalKeyMember]
        int SchoolId { get; set; }

        // Non-PK properties
        int? MaximumNumberOfSeats { get; set; }
        int? OptimalNumberOfSeats { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.MagnetSpecialProgramEmphasisSchoolType table of the MagnetSpecialProgramEmphasisSchoolType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IMagnetSpecialProgramEmphasisSchoolType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int MagnetSpecialProgramEmphasisSchoolTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.MediumOfInstructionType table of the MediumOfInstructionType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IMediumOfInstructionType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int MediumOfInstructionTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.MeetingDayType table of the MeetingDayType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IMeetingDayType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int MeetingDayTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.MethodCreditEarnedType table of the MethodCreditEarnedType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IMethodCreditEarnedType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int MethodCreditEarnedTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.NetworkPurposeType table of the NetworkPurposeType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface INetworkPurposeType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int NetworkPurposeTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.ObjectiveAssessment table of the ObjectiveAssessment aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IObjectiveAssessment : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        string AssessmentIdentifier { get; set; }
        [NaturalKeyMember]
        string IdentificationCode { get; set; }
        [NaturalKeyMember]
        string Namespace { get; set; }

        // Non-PK properties
        string Description { get; set; }
        int? MaxRawScore { get; set; }
        string Nomenclature { get; set; }
        string ParentIdentificationCode { get; set; }
        decimal? PercentOfAssessment { get; set; }

        // Lists
        IList<IObjectiveAssessmentAssessmentItem> ObjectiveAssessmentAssessmentItems { get; set; }
        IList<IObjectiveAssessmentLearningObjective> ObjectiveAssessmentLearningObjectives { get; set; }
        IList<IObjectiveAssessmentLearningStandard> ObjectiveAssessmentLearningStandards { get; set; }
        IList<IObjectiveAssessmentPerformanceLevel> ObjectiveAssessmentPerformanceLevels { get; set; }
        IList<IObjectiveAssessmentScore> ObjectiveAssessmentScores { get; set; }
    } 

    /// <summary>
    /// Interface for the edfi.ObjectiveAssessmentAssessmentItem table of the ObjectiveAssessment aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IObjectiveAssessmentAssessmentItem : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IObjectiveAssessment ObjectiveAssessment { get; set; }
        [NaturalKeyMember]
        string AssessmentItemIdentificationCode { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.ObjectiveAssessmentLearningObjective table of the ObjectiveAssessment aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IObjectiveAssessmentLearningObjective : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IObjectiveAssessment ObjectiveAssessment { get; set; }
        [NaturalKeyMember]
        string LearningObjectiveId { get; set; }
        [NaturalKeyMember]
        string LearningObjectiveNamespace { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.ObjectiveAssessmentLearningStandard table of the ObjectiveAssessment aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IObjectiveAssessmentLearningStandard : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IObjectiveAssessment ObjectiveAssessment { get; set; }
        [NaturalKeyMember]
        string LearningStandardId { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.ObjectiveAssessmentPerformanceLevel table of the ObjectiveAssessment aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IObjectiveAssessmentPerformanceLevel : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IObjectiveAssessment ObjectiveAssessment { get; set; }
        [NaturalKeyMember]
        string AssessmentReportingMethodType { get; set; }
        [NaturalKeyMember]
        string PerformanceLevelDescriptor { get; set; }

        // Non-PK properties
        string MaximumScore { get; set; }
        string MinimumScore { get; set; }
        string ResultDatatypeType { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.ObjectiveAssessmentScore table of the ObjectiveAssessment aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IObjectiveAssessmentScore : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IObjectiveAssessment ObjectiveAssessment { get; set; }
        [NaturalKeyMember]
        string AssessmentReportingMethodType { get; set; }

        // Non-PK properties
        string MaximumScore { get; set; }
        string MinimumScore { get; set; }
        string ResultDatatypeType { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.OldEthnicityType table of the OldEthnicityType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IOldEthnicityType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int OldEthnicityTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.OpenStaffPosition table of the OpenStaffPosition aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IOpenStaffPosition : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        DateTime DatePosted { get; set; }
        [NaturalKeyMember]
        int EducationOrganizationId { get; set; }
        [NaturalKeyMember]
        string EmploymentStatusDescriptor { get; set; }
        [NaturalKeyMember]
        string RequisitionNumber { get; set; }
        [NaturalKeyMember]
        string StaffClassificationDescriptor { get; set; }

        // Non-PK properties
        DateTime? DatePostingRemoved { get; set; }
        string PositionTitle { get; set; }
        string PostingResultType { get; set; }
        string ProgramAssignmentDescriptor { get; set; }

        // Lists
        IList<IOpenStaffPositionAcademicSubject> OpenStaffPositionAcademicSubjects { get; set; }
        IList<IOpenStaffPositionInstructionalGradeLevel> OpenStaffPositionInstructionalGradeLevels { get; set; }
    } 

    /// <summary>
    /// Interface for the edfi.OpenStaffPositionAcademicSubject table of the OpenStaffPosition aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IOpenStaffPositionAcademicSubject : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IOpenStaffPosition OpenStaffPosition { get; set; }
        [NaturalKeyMember]
        string AcademicSubjectDescriptor { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.OpenStaffPositionInstructionalGradeLevel table of the OpenStaffPosition aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IOpenStaffPositionInstructionalGradeLevel : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IOpenStaffPosition OpenStaffPosition { get; set; }
        [NaturalKeyMember]
        string GradeLevelDescriptor { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.OperationalStatusType table of the OperationalStatusType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IOperationalStatusType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int OperationalStatusTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.OtherNameType table of the OtherNameType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IOtherNameType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int OtherNameTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.Parent table of the Parent aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IParent : ISynchronizable, IMappable, IHasIdentifier, IIdentifiablePerson, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][UniqueId]
        string ParentUniqueId { get; set; }

        // Non-PK properties
        string FirstName { get; set; }
        string GenerationCodeSuffix { get; set; }
        string LastSurname { get; set; }
        string LoginId { get; set; }
        string MaidenName { get; set; }
        string MiddleName { get; set; }
        string PersonalTitlePrefix { get; set; }
        string SexType { get; set; }

        // Lists
        IList<IParentAddress> ParentAddresses { get; set; }
        IList<IParentElectronicMail> ParentElectronicMails { get; set; }
        IList<IParentIdentificationDocument> ParentIdentificationDocuments { get; set; }
        IList<IParentInternationalAddress> ParentInternationalAddresses { get; set; }
        IList<IParentOtherName> ParentOtherNames { get; set; }
        IList<IParentTelephone> ParentTelephones { get; set; }
    } 

    /// <summary>
    /// Interface for the edfi.ParentAddress table of the Parent aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IParentAddress : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IParent Parent { get; set; }
        [NaturalKeyMember]
        string AddressType { get; set; }

        // Non-PK properties
        string ApartmentRoomSuiteNumber { get; set; }
        DateTime? BeginDate { get; set; }
        string BuildingSiteNumber { get; set; }
        string City { get; set; }
        string CountyFIPSCode { get; set; }
        DateTime? EndDate { get; set; }
        string Latitude { get; set; }
        string Longitude { get; set; }
        string NameOfCounty { get; set; }
        string PostalCode { get; set; }
        string StateAbbreviationType { get; set; }
        string StreetNumberName { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.ParentElectronicMail table of the Parent aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IParentElectronicMail : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IParent Parent { get; set; }
        [NaturalKeyMember]
        string ElectronicMailType { get; set; }

        // Non-PK properties
        string ElectronicMailAddress { get; set; }
        bool? PrimaryEmailAddressIndicator { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.ParentIdentificationDocument table of the Parent aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IParentIdentificationDocument : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IParent Parent { get; set; }
        [NaturalKeyMember]
        string IdentificationDocumentUseType { get; set; }
        [NaturalKeyMember]
        string PersonalInformationVerificationType { get; set; }

        // Non-PK properties
        DateTime? DocumentExpirationDate { get; set; }
        string DocumentTitle { get; set; }
        string IssuerCountryDescriptor { get; set; }
        string IssuerDocumentIdentificationCode { get; set; }
        string IssuerName { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.ParentInternationalAddress table of the Parent aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IParentInternationalAddress : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IParent Parent { get; set; }
        [NaturalKeyMember]
        string AddressType { get; set; }

        // Non-PK properties
        string AddressLine1 { get; set; }
        string AddressLine2 { get; set; }
        string AddressLine3 { get; set; }
        string AddressLine4 { get; set; }
        DateTime? BeginDate { get; set; }
        string CountryDescriptor { get; set; }
        DateTime? EndDate { get; set; }
        string Latitude { get; set; }
        string Longitude { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.ParentOtherName table of the Parent aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IParentOtherName : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IParent Parent { get; set; }
        [NaturalKeyMember]
        string OtherNameType { get; set; }

        // Non-PK properties
        string FirstName { get; set; }
        string GenerationCodeSuffix { get; set; }
        string LastSurname { get; set; }
        string MiddleName { get; set; }
        string PersonalTitlePrefix { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.ParentTelephone table of the Parent aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IParentTelephone : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IParent Parent { get; set; }
        [NaturalKeyMember]
        string TelephoneNumberType { get; set; }

        // Non-PK properties
        int? OrderOfPriority { get; set; }
        string TelephoneNumber { get; set; }
        bool? TextMessageCapabilityIndicator { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.Payroll table of the Payroll aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IPayroll : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        string AccountNumber { get; set; }
        [NaturalKeyMember]
        DateTime AsOfDate { get; set; }
        [NaturalKeyMember]
        int EducationOrganizationId { get; set; }
        [NaturalKeyMember]
        int FiscalYear { get; set; }
        [NaturalKeyMember]
        string StaffUniqueId { get; set; }

        // Non-PK properties
        decimal AmountToDate { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.PerformanceBaseConversionType table of the PerformanceBaseConversionType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IPerformanceBaseConversionType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int PerformanceBaseConversionTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.PerformanceLevelDescriptor table of the PerformanceLevelDescriptor aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IPerformanceLevelDescriptor : IDescriptor, ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int PerformanceLevelDescriptorId { get; set; }

        // Inherited non-PK properties
        //string CodeValue { get; set; }
        //string Description { get; set; }
        //DateTime? EffectiveBeginDate { get; set; }
        //DateTime? EffectiveEndDate { get; set; }
        //string Namespace { get; set; }
        //int? PriorDescriptorId { get; set; }
        //string ShortDescription { get; set; }

        // Non-PK properties
        string PerformanceBaseConversionType { get; set; }

        // Inherited lists

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.PersonalInformationVerificationType table of the PersonalInformationVerificationType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IPersonalInformationVerificationType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int PersonalInformationVerificationTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.PopulationServedType table of the PopulationServedType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IPopulationServedType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int PopulationServedTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.PostingResultType table of the PostingResultType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IPostingResultType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int PostingResultTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.PostSecondaryEvent table of the PostSecondaryEvent aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IPostSecondaryEvent : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        DateTime EventDate { get; set; }
        [NaturalKeyMember]
        string PostSecondaryEventCategoryType { get; set; }
        [NaturalKeyMember]
        string StudentUniqueId { get; set; }

        // Non-PK properties

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        IPostSecondaryEventPostSecondaryInstitution PostSecondaryEventPostSecondaryInstitution { get; set; }

        // -------------------------------------------------------------

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.PostSecondaryEventCategoryType table of the PostSecondaryEventCategoryType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IPostSecondaryEventCategoryType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int PostSecondaryEventCategoryTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.PostSecondaryEventPostSecondaryInstitution table of the PostSecondaryEvent aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IPostSecondaryEventPostSecondaryInstitution : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IPostSecondaryEvent PostSecondaryEvent { get; set; }

        // Non-PK properties
        string AdministrativeFundingControlDescriptor { get; set; }
        string NameOfInstitution { get; set; }
        string PostSecondaryInstitutionId { get; set; }
        string PostSecondaryInstitutionLevelType { get; set; }

        // Lists
        IList<IPostSecondaryEventPostSecondaryInstitutionIdentificationCode> PostSecondaryEventPostSecondaryInstitutionIdentificationCodes { get; set; }
        IList<IPostSecondaryEventPostSecondaryInstitutionMediumOfInstruction> PostSecondaryEventPostSecondaryInstitutionMediumOfInstructions { get; set; }
    } 

    /// <summary>
    /// Interface for the edfi.PostSecondaryEventPostSecondaryInstitutionIdentificationCode table of the PostSecondaryEvent aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IPostSecondaryEventPostSecondaryInstitutionIdentificationCode : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IPostSecondaryEventPostSecondaryInstitution PostSecondaryEventPostSecondaryInstitution { get; set; }
        [NaturalKeyMember]
        string EducationOrganizationIdentificationSystemDescriptor { get; set; }

        // Non-PK properties
        string IdentificationCode { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.PostSecondaryEventPostSecondaryInstitutionMediumOfInstruction table of the PostSecondaryEvent aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IPostSecondaryEventPostSecondaryInstitutionMediumOfInstruction : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IPostSecondaryEventPostSecondaryInstitution PostSecondaryEventPostSecondaryInstitution { get; set; }
        [NaturalKeyMember]
        string MediumOfInstructionType { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.PostSecondaryInstitutionLevelType table of the PostSecondaryInstitutionLevelType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IPostSecondaryInstitutionLevelType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int PostSecondaryInstitutionLevelTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.Program table of the Program aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IProgram : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        int EducationOrganizationId { get; set; }
        [NaturalKeyMember]
        string ProgramName { get; set; }
        [NaturalKeyMember]
        string ProgramType { get; set; }

        // Non-PK properties
        string ProgramId { get; set; }
        string ProgramSponsorType { get; set; }

        // Lists
        IList<IProgramCharacteristic> ProgramCharacteristics { get; set; }
        IList<IProgramLearningObjective> ProgramLearningObjectives { get; set; }
        IList<IProgramLearningStandard> ProgramLearningStandards { get; set; }
        IList<IProgramService> ProgramServices { get; set; }
    } 

    /// <summary>
    /// Interface for the edfi.ProgramAssignmentDescriptor table of the ProgramAssignmentDescriptor aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IProgramAssignmentDescriptor : IDescriptor, ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int ProgramAssignmentDescriptorId { get; set; }

        // Inherited non-PK properties
        //string CodeValue { get; set; }
        //string Description { get; set; }
        //DateTime? EffectiveBeginDate { get; set; }
        //DateTime? EffectiveEndDate { get; set; }
        //string Namespace { get; set; }
        //int? PriorDescriptorId { get; set; }
        //string ShortDescription { get; set; }

        // Non-PK properties
        string ProgramAssignmentType { get; set; }

        // Inherited lists

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.ProgramAssignmentType table of the ProgramAssignmentType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IProgramAssignmentType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int ProgramAssignmentTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.ProgramCharacteristic table of the Program aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IProgramCharacteristic : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IProgram Program { get; set; }
        [NaturalKeyMember]
        string ProgramCharacteristicDescriptor { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.ProgramCharacteristicDescriptor table of the ProgramCharacteristicDescriptor aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IProgramCharacteristicDescriptor : IDescriptor, ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int ProgramCharacteristicDescriptorId { get; set; }

        // Inherited non-PK properties
        //string CodeValue { get; set; }
        //string Description { get; set; }
        //DateTime? EffectiveBeginDate { get; set; }
        //DateTime? EffectiveEndDate { get; set; }
        //string Namespace { get; set; }
        //int? PriorDescriptorId { get; set; }
        //string ShortDescription { get; set; }

        // Non-PK properties
        string ProgramCharacteristicType { get; set; }

        // Inherited lists

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.ProgramCharacteristicType table of the ProgramCharacteristicType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IProgramCharacteristicType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int ProgramCharacteristicTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.ProgramLearningObjective table of the Program aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IProgramLearningObjective : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IProgram Program { get; set; }
        [NaturalKeyMember]
        string LearningObjectiveId { get; set; }
        [NaturalKeyMember]
        string Namespace { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.ProgramLearningStandard table of the Program aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IProgramLearningStandard : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IProgram Program { get; set; }
        [NaturalKeyMember]
        string LearningStandardId { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.ProgramService table of the Program aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IProgramService : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IProgram Program { get; set; }
        [NaturalKeyMember]
        string ServiceDescriptor { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.ProgramSponsorType table of the ProgramSponsorType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IProgramSponsorType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int ProgramSponsorTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.ProgramType table of the ProgramType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IProgramType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int ProgramTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.PublicationStatusType table of the PublicationStatusType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IPublicationStatusType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int PublicationStatusTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.RaceType table of the RaceType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IRaceType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int RaceTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.ReasonExitedDescriptor table of the ReasonExitedDescriptor aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IReasonExitedDescriptor : IDescriptor, ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int ReasonExitedDescriptorId { get; set; }

        // Inherited non-PK properties
        //string CodeValue { get; set; }
        //string Description { get; set; }
        //DateTime? EffectiveBeginDate { get; set; }
        //DateTime? EffectiveEndDate { get; set; }
        //string Namespace { get; set; }
        //int? PriorDescriptorId { get; set; }
        //string ShortDescription { get; set; }

        // Non-PK properties
        string ReasonExitedType { get; set; }

        // Inherited lists

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.ReasonExitedType table of the ReasonExitedType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IReasonExitedType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int ReasonExitedTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.ReasonNotTestedType table of the ReasonNotTestedType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IReasonNotTestedType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int ReasonNotTestedTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.RecognitionType table of the RecognitionType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IRecognitionType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int RecognitionTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.RelationType table of the RelationType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IRelationType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int RelationTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.RepeatIdentifierType table of the RepeatIdentifierType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IRepeatIdentifierType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int RepeatIdentifierTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.ReportCard table of the ReportCard aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IReportCard : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        int EducationOrganizationId { get; set; }
        [NaturalKeyMember]
        DateTime GradingPeriodBeginDate { get; set; }
        [NaturalKeyMember]
        string GradingPeriodDescriptor { get; set; }
        [NaturalKeyMember]
        int SchoolId { get; set; }
        [NaturalKeyMember]
        string StudentUniqueId { get; set; }

        // Non-PK properties
        decimal? GPACumulative { get; set; }
        decimal? GPAGivenGradingPeriod { get; set; }
        decimal? NumberOfDaysAbsent { get; set; }
        decimal? NumberOfDaysInAttendance { get; set; }
        int? NumberOfDaysTardy { get; set; }

        // Lists
        IList<IReportCardGrade> ReportCardGrades { get; set; }
        IList<IReportCardStudentCompetencyObjective> ReportCardStudentCompetencyObjectives { get; set; }
        IList<IReportCardStudentLearningObjective> ReportCardStudentLearningObjectives { get; set; }
    } 

    /// <summary>
    /// Interface for the edfi.ReportCardGrade table of the ReportCard aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IReportCardGrade : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IReportCard ReportCard { get; set; }
        [NaturalKeyMember]
        DateTime BeginDate { get; set; }
        [NaturalKeyMember]
        string ClassPeriodName { get; set; }
        [NaturalKeyMember]
        string ClassroomIdentificationCode { get; set; }
        [NaturalKeyMember]
        string GradeType { get; set; }
        [NaturalKeyMember]
        string LocalCourseCode { get; set; }
        [NaturalKeyMember]
        short SchoolYear { get; set; }
        [NaturalKeyMember]
        int SequenceOfCourse { get; set; }
        [NaturalKeyMember]
        string TermDescriptor { get; set; }
        [NaturalKeyMember]
        string UniqueSectionCode { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.ReportCardStudentCompetencyObjective table of the ReportCard aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IReportCardStudentCompetencyObjective : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IReportCard ReportCard { get; set; }
        [NaturalKeyMember]
        string Objective { get; set; }
        [NaturalKeyMember]
        int ObjectiveEducationOrganizationId { get; set; }
        [NaturalKeyMember]
        string ObjectiveGradeLevelDescriptor { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.ReportCardStudentLearningObjective table of the ReportCard aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IReportCardStudentLearningObjective : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IReportCard ReportCard { get; set; }
        [NaturalKeyMember]
        string LearningObjectiveId { get; set; }
        [NaturalKeyMember]
        string Namespace { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.ReporterDescriptionDescriptor table of the ReporterDescriptionDescriptor aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IReporterDescriptionDescriptor : IDescriptor, ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int ReporterDescriptionDescriptorId { get; set; }

        // Inherited non-PK properties
        //string CodeValue { get; set; }
        //string Description { get; set; }
        //DateTime? EffectiveBeginDate { get; set; }
        //DateTime? EffectiveEndDate { get; set; }
        //string Namespace { get; set; }
        //int? PriorDescriptorId { get; set; }
        //string ShortDescription { get; set; }

        // Non-PK properties
        string ReporterDescriptionType { get; set; }

        // Inherited lists

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.ReporterDescriptionType table of the ReporterDescriptionType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IReporterDescriptionType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int ReporterDescriptionTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.ResidencyStatusDescriptor table of the ResidencyStatusDescriptor aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IResidencyStatusDescriptor : IDescriptor, ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int ResidencyStatusDescriptorId { get; set; }

        // Inherited non-PK properties
        //string CodeValue { get; set; }
        //string Description { get; set; }
        //DateTime? EffectiveBeginDate { get; set; }
        //DateTime? EffectiveEndDate { get; set; }
        //string Namespace { get; set; }
        //int? PriorDescriptorId { get; set; }
        //string ShortDescription { get; set; }

        // Non-PK properties
        string ResidencyStatusType { get; set; }

        // Inherited lists

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.ResidencyStatusType table of the ResidencyStatusType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IResidencyStatusType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int ResidencyStatusTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.ResponseIndicatorType table of the ResponseIndicatorType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IResponseIndicatorType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int ResponseIndicatorTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.ResponsibilityDescriptor table of the ResponsibilityDescriptor aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IResponsibilityDescriptor : IDescriptor, ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int ResponsibilityDescriptorId { get; set; }

        // Inherited non-PK properties
        //string CodeValue { get; set; }
        //string Description { get; set; }
        //DateTime? EffectiveBeginDate { get; set; }
        //DateTime? EffectiveEndDate { get; set; }
        //string Namespace { get; set; }
        //int? PriorDescriptorId { get; set; }
        //string ShortDescription { get; set; }

        // Non-PK properties
        string ResponsibilityType { get; set; }

        // Inherited lists

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.ResponsibilityType table of the ResponsibilityType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IResponsibilityType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int ResponsibilityTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.RestraintEvent table of the RestraintEvent aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IRestraintEvent : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        DateTime EventDate { get; set; }
        [NaturalKeyMember]
        string RestraintEventIdentifier { get; set; }
        [NaturalKeyMember]
        int SchoolId { get; set; }
        [NaturalKeyMember]
        string StudentUniqueId { get; set; }

        // Non-PK properties
        string EducationalEnvironmentType { get; set; }

        // Lists
        IList<IRestraintEventProgram> RestraintEventPrograms { get; set; }
        IList<IRestraintEventReason> RestraintEventReasons { get; set; }
    } 

    /// <summary>
    /// Interface for the edfi.RestraintEventProgram table of the RestraintEvent aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IRestraintEventProgram : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IRestraintEvent RestraintEvent { get; set; }
        [NaturalKeyMember]
        int EducationOrganizationId { get; set; }
        [NaturalKeyMember]
        string ProgramName { get; set; }
        [NaturalKeyMember]
        string ProgramType { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.RestraintEventReason table of the RestraintEvent aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IRestraintEventReason : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IRestraintEvent RestraintEvent { get; set; }
        [NaturalKeyMember]
        string RestraintEventReasonType { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.RestraintEventReasonType table of the RestraintEventReasonType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IRestraintEventReasonType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int RestraintEventReasonTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.ResultDatatypeType table of the ResultDatatypeType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IResultDatatypeType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int ResultDatatypeTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.RetestIndicatorType table of the RetestIndicatorType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IRetestIndicatorType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int RetestIndicatorTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.School table of the School aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ISchool : IEducationOrganization, ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        int SchoolId { get; set; }

        // Inherited non-PK properties
        //string NameOfInstitution { get; set; }
        //string OperationalStatusType { get; set; }
        //string ShortNameOfInstitution { get; set; }
        //string StateOrganizationId { get; set; }
        //string WebSite { get; set; }

        // Non-PK properties
        string AdministrativeFundingControlDescriptor { get; set; }
        string CharterApprovalAgencyType { get; set; }
        short? CharterApprovalSchoolYear { get; set; }
        string CharterStatusType { get; set; }
        string InternetAccessType { get; set; }
        int? LocalEducationAgencyId { get; set; }
        string MagnetSpecialProgramEmphasisSchoolType { get; set; }
        string SchoolType { get; set; }
        string TitleIPartASchoolDesignationType { get; set; }

        // Inherited lists
        //IList<IEducationOrganizationAddress> EducationOrganizationAddresses { get; set; }
        //IList<IEducationOrganizationCategory> EducationOrganizationCategories { get; set; }
        //IList<IEducationOrganizationIdentificationCode> EducationOrganizationIdentificationCodes { get; set; }
        //IList<IEducationOrganizationInstitutionTelephone> EducationOrganizationInstitutionTelephones { get; set; }
        //IList<IEducationOrganizationInternationalAddress> EducationOrganizationInternationalAddresses { get; set; }

        // Lists
        IList<ISchoolCategory> SchoolCategories { get; set; }
        IList<ISchoolGradeLevel> SchoolGradeLevels { get; set; }
    } 

    /// <summary>
    /// Interface for the edfi.SchoolCategory table of the School aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ISchoolCategory : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        ISchool School { get; set; }
        [NaturalKeyMember]
        string SchoolCategoryType { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.SchoolCategoryType table of the SchoolCategoryType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ISchoolCategoryType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int SchoolCategoryTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.SchoolChoiceImplementStatusType table of the SchoolChoiceImplementStatusType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ISchoolChoiceImplementStatusType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int SchoolChoiceImplementStatusTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.SchoolFoodServicesEligibilityDescriptor table of the SchoolFoodServicesEligibilityDescriptor aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ISchoolFoodServicesEligibilityDescriptor : IDescriptor, ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int SchoolFoodServicesEligibilityDescriptorId { get; set; }

        // Inherited non-PK properties
        //string CodeValue { get; set; }
        //string Description { get; set; }
        //DateTime? EffectiveBeginDate { get; set; }
        //DateTime? EffectiveEndDate { get; set; }
        //string Namespace { get; set; }
        //int? PriorDescriptorId { get; set; }
        //string ShortDescription { get; set; }

        // Non-PK properties
        string SchoolFoodServicesEligibilityType { get; set; }

        // Inherited lists

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.SchoolFoodServicesEligibilityType table of the SchoolFoodServicesEligibilityType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ISchoolFoodServicesEligibilityType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int SchoolFoodServicesEligibilityTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.SchoolGradeLevel table of the School aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ISchoolGradeLevel : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        ISchool School { get; set; }
        [NaturalKeyMember]
        string GradeLevelDescriptor { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.SchoolType table of the SchoolType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ISchoolType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int SchoolTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.SchoolYearType table of the SchoolYearType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ISchoolYearType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        short SchoolYear { get; set; }

        // Non-PK properties
        bool CurrentSchoolYear { get; set; }
        string SchoolYearDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.Section table of the Section aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ISection : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        string ClassPeriodName { get; set; }
        [NaturalKeyMember]
        string ClassroomIdentificationCode { get; set; }
        [NaturalKeyMember]
        string LocalCourseCode { get; set; }
        [NaturalKeyMember]
        int SchoolId { get; set; }
        [NaturalKeyMember]
        short SchoolYear { get; set; }
        [NaturalKeyMember]
        int SequenceOfCourse { get; set; }
        [NaturalKeyMember]
        string TermDescriptor { get; set; }
        [NaturalKeyMember]
        string UniqueSectionCode { get; set; }

        // Non-PK properties
        decimal? AvailableCreditConversion { get; set; }
        decimal? AvailableCredits { get; set; }
        string AvailableCreditType { get; set; }
        string EducationalEnvironmentType { get; set; }
        string InstructionLanguageDescriptor { get; set; }
        string MediumOfInstructionType { get; set; }
        string PopulationServedType { get; set; }

        // Lists
        IList<ISectionCharacteristic> SectionCharacteristics { get; set; }
        IList<ISectionProgram> SectionPrograms { get; set; }
    } 

    /// <summary>
    /// Interface for the edfi.SectionAttendanceTakenEvent table of the SectionAttendanceTakenEvent aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ISectionAttendanceTakenEvent : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        string ClassPeriodName { get; set; }
        [NaturalKeyMember]
        string ClassroomIdentificationCode { get; set; }
        [NaturalKeyMember]
        DateTime Date { get; set; }
        [NaturalKeyMember]
        string LocalCourseCode { get; set; }
        [NaturalKeyMember]
        int SchoolId { get; set; }
        [NaturalKeyMember]
        short SchoolYear { get; set; }
        [NaturalKeyMember]
        int SequenceOfCourse { get; set; }
        [NaturalKeyMember]
        string TermDescriptor { get; set; }
        [NaturalKeyMember]
        string UniqueSectionCode { get; set; }

        // Non-PK properties
        DateTime EventDate { get; set; }
        string StaffUniqueId { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.SectionCharacteristic table of the Section aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ISectionCharacteristic : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        ISection Section { get; set; }
        [NaturalKeyMember]
        string SectionCharacteristicDescriptor { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.SectionCharacteristicDescriptor table of the SectionCharacteristicDescriptor aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ISectionCharacteristicDescriptor : IDescriptor, ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int SectionCharacteristicDescriptorId { get; set; }

        // Inherited non-PK properties
        //string CodeValue { get; set; }
        //string Description { get; set; }
        //DateTime? EffectiveBeginDate { get; set; }
        //DateTime? EffectiveEndDate { get; set; }
        //string Namespace { get; set; }
        //int? PriorDescriptorId { get; set; }
        //string ShortDescription { get; set; }

        // Non-PK properties
        string SectionCharacteristicType { get; set; }

        // Inherited lists

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.SectionCharacteristicType table of the SectionCharacteristicType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ISectionCharacteristicType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int SectionCharacteristicTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.SectionProgram table of the Section aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ISectionProgram : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        ISection Section { get; set; }
        [NaturalKeyMember]
        int EducationOrganizationId { get; set; }
        [NaturalKeyMember]
        string ProgramName { get; set; }
        [NaturalKeyMember]
        string ProgramType { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.SeparationReasonDescriptor table of the SeparationReasonDescriptor aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ISeparationReasonDescriptor : IDescriptor, ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int SeparationReasonDescriptorId { get; set; }

        // Inherited non-PK properties
        //string CodeValue { get; set; }
        //string Description { get; set; }
        //DateTime? EffectiveBeginDate { get; set; }
        //DateTime? EffectiveEndDate { get; set; }
        //string Namespace { get; set; }
        //int? PriorDescriptorId { get; set; }
        //string ShortDescription { get; set; }

        // Non-PK properties
        string SeparationReasonType { get; set; }

        // Inherited lists

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.SeparationReasonType table of the SeparationReasonType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ISeparationReasonType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int SeparationReasonTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.SeparationType table of the SeparationType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ISeparationType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int SeparationTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.ServiceDescriptor table of the ServiceDescriptor aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IServiceDescriptor : IDescriptor, ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int ServiceDescriptorId { get; set; }

        // Inherited non-PK properties
        //string CodeValue { get; set; }
        //string Description { get; set; }
        //DateTime? EffectiveBeginDate { get; set; }
        //DateTime? EffectiveEndDate { get; set; }
        //string Namespace { get; set; }
        //int? PriorDescriptorId { get; set; }
        //string ShortDescription { get; set; }

        // Non-PK properties
        string ServiceCategory { get; set; }

        // Inherited lists

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.Session table of the Session aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ISession : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        int SchoolId { get; set; }
        [NaturalKeyMember]
        short SchoolYear { get; set; }
        [NaturalKeyMember]
        string TermDescriptor { get; set; }

        // Non-PK properties
        DateTime BeginDate { get; set; }
        DateTime EndDate { get; set; }
        string SessionName { get; set; }
        int TotalInstructionalDays { get; set; }

        // Lists
        IList<ISessionAcademicWeek> SessionAcademicWeeks { get; set; }
        IList<ISessionGradingPeriod> SessionGradingPeriods { get; set; }
    } 

    /// <summary>
    /// Interface for the edfi.SessionAcademicWeek table of the Session aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ISessionAcademicWeek : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        ISession Session { get; set; }
        [NaturalKeyMember]
        string WeekIdentifier { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.SessionGradingPeriod table of the Session aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ISessionGradingPeriod : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        ISession Session { get; set; }
        [NaturalKeyMember]
        DateTime BeginDate { get; set; }
        [NaturalKeyMember]
        string GradingPeriodDescriptor { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.SexType table of the SexType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ISexType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int SexTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.SpecialEducationSettingDescriptor table of the SpecialEducationSettingDescriptor aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ISpecialEducationSettingDescriptor : IDescriptor, ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int SpecialEducationSettingDescriptorId { get; set; }

        // Inherited non-PK properties
        //string CodeValue { get; set; }
        //string Description { get; set; }
        //DateTime? EffectiveBeginDate { get; set; }
        //DateTime? EffectiveEndDate { get; set; }
        //string Namespace { get; set; }
        //int? PriorDescriptorId { get; set; }
        //string ShortDescription { get; set; }

        // Non-PK properties
        string SpecialEducationSettingType { get; set; }

        // Inherited lists

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.SpecialEducationSettingType table of the SpecialEducationSettingType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ISpecialEducationSettingType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int SpecialEducationSettingTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.Staff table of the Staff aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStaff : ISynchronizable, IMappable, IHasIdentifier, IIdentifiablePerson, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][UniqueId]
        string StaffUniqueId { get; set; }

        // Non-PK properties
        DateTime? BirthDate { get; set; }
        string CitizenshipStatusType { get; set; }
        string FirstName { get; set; }
        string GenerationCodeSuffix { get; set; }
        string HighestCompletedLevelOfEducationDescriptor { get; set; }
        bool? HighlyQualifiedTeacher { get; set; }
        bool HispanicLatinoEthnicity { get; set; }
        string LastSurname { get; set; }
        string LoginId { get; set; }
        string MaidenName { get; set; }
        string MiddleName { get; set; }
        string OldEthnicityType { get; set; }
        string PersonalTitlePrefix { get; set; }
        string SexType { get; set; }
        decimal? YearsOfPriorProfessionalExperience { get; set; }
        decimal? YearsOfPriorTeachingExperience { get; set; }

        // Lists
        IList<IStaffAddress> StaffAddresses { get; set; }
        IList<IStaffCredential> StaffCredentials { get; set; }
        IList<IStaffElectronicMail> StaffElectronicMails { get; set; }
        IList<IStaffIdentificationCode> StaffIdentificationCodes { get; set; }
        IList<IStaffIdentificationDocument> StaffIdentificationDocuments { get; set; }
        IList<IStaffInternationalAddress> StaffInternationalAddresses { get; set; }
        IList<IStaffLanguage> StaffLanguages { get; set; }
        IList<IStaffOtherName> StaffOtherNames { get; set; }
        IList<IStaffRace> StaffRaces { get; set; }
        IList<IStaffTelephone> StaffTelephones { get; set; }
        IList<IStaffVisa> StaffVisas { get; set; }
    } 

    /// <summary>
    /// Interface for the edfi.StaffAddress table of the Staff aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStaffAddress : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IStaff Staff { get; set; }
        [NaturalKeyMember]
        string AddressType { get; set; }

        // Non-PK properties
        string ApartmentRoomSuiteNumber { get; set; }
        DateTime? BeginDate { get; set; }
        string BuildingSiteNumber { get; set; }
        string City { get; set; }
        string CountyFIPSCode { get; set; }
        DateTime? EndDate { get; set; }
        string Latitude { get; set; }
        string Longitude { get; set; }
        string NameOfCounty { get; set; }
        string PostalCode { get; set; }
        string StateAbbreviationType { get; set; }
        string StreetNumberName { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StaffClassificationDescriptor table of the StaffClassificationDescriptor aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStaffClassificationDescriptor : IDescriptor, ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int StaffClassificationDescriptorId { get; set; }

        // Inherited non-PK properties
        //string CodeValue { get; set; }
        //string Description { get; set; }
        //DateTime? EffectiveBeginDate { get; set; }
        //DateTime? EffectiveEndDate { get; set; }
        //string Namespace { get; set; }
        //int? PriorDescriptorId { get; set; }
        //string ShortDescription { get; set; }

        // Non-PK properties
        string StaffClassificationType { get; set; }

        // Inherited lists

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StaffClassificationType table of the StaffClassificationType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStaffClassificationType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int StaffClassificationTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StaffCohortAssociation table of the StaffCohortAssociation aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStaffCohortAssociation : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        DateTime BeginDate { get; set; }
        [NaturalKeyMember]
        string CohortIdentifier { get; set; }
        [NaturalKeyMember]
        int EducationOrganizationId { get; set; }
        [NaturalKeyMember]
        string StaffUniqueId { get; set; }

        // Non-PK properties
        DateTime? EndDate { get; set; }
        bool? StudentRecordAccess { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StaffCredential table of the Staff aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStaffCredential : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IStaff Staff { get; set; }
        [NaturalKeyMember]
        string CredentialFieldDescriptor { get; set; }
        [NaturalKeyMember]
        DateTime CredentialIssuanceDate { get; set; }
        [NaturalKeyMember]
        string CredentialType { get; set; }
        [NaturalKeyMember]
        string LevelDescriptor { get; set; }
        [NaturalKeyMember]
        string TeachingCredentialDescriptor { get; set; }

        // Non-PK properties
        DateTime? CredentialExpirationDate { get; set; }
        string StateOfIssueStateAbbreviationType { get; set; }
        string TeachingCredentialBasisType { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StaffEducationOrganizationAssignmentAssociation table of the StaffEducationOrganizationAssignmentAssociation aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStaffEducationOrganizationAssignmentAssociation : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        DateTime BeginDate { get; set; }
        [NaturalKeyMember]
        int EducationOrganizationId { get; set; }
        [NaturalKeyMember]
        string StaffClassificationDescriptor { get; set; }
        [NaturalKeyMember]
        string StaffUniqueId { get; set; }

        // Non-PK properties
        int? EmploymentEducationOrganizationId { get; set; }
        DateTime? EmploymentHireDate { get; set; }
        string EmploymentStatusDescriptor { get; set; }
        DateTime? EndDate { get; set; }
        int? OrderOfAssignment { get; set; }
        string PositionTitle { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StaffEducationOrganizationEmploymentAssociation table of the StaffEducationOrganizationEmploymentAssociation aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStaffEducationOrganizationEmploymentAssociation : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        int EducationOrganizationId { get; set; }
        [NaturalKeyMember]
        string EmploymentStatusDescriptor { get; set; }
        [NaturalKeyMember]
        DateTime HireDate { get; set; }
        [NaturalKeyMember]
        string StaffUniqueId { get; set; }

        // Non-PK properties
        string Department { get; set; }
        DateTime? EndDate { get; set; }
        decimal? FullTimeEquivalency { get; set; }
        decimal? HourlyWage { get; set; }
        DateTime? OfferDate { get; set; }
        string SeparationReasonDescriptor { get; set; }
        string SeparationType { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StaffElectronicMail table of the Staff aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStaffElectronicMail : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IStaff Staff { get; set; }
        [NaturalKeyMember]
        string ElectronicMailType { get; set; }

        // Non-PK properties
        string ElectronicMailAddress { get; set; }
        bool? PrimaryEmailAddressIndicator { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StaffIdentificationCode table of the Staff aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStaffIdentificationCode : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IStaff Staff { get; set; }
        [NaturalKeyMember]
        string StaffIdentificationSystemDescriptor { get; set; }

        // Non-PK properties
        string AssigningOrganizationIdentificationCode { get; set; }
        string IdentificationCode { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StaffIdentificationDocument table of the Staff aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStaffIdentificationDocument : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IStaff Staff { get; set; }
        [NaturalKeyMember]
        string IdentificationDocumentUseType { get; set; }
        [NaturalKeyMember]
        string PersonalInformationVerificationType { get; set; }

        // Non-PK properties
        DateTime? DocumentExpirationDate { get; set; }
        string DocumentTitle { get; set; }
        string IssuerCountryDescriptor { get; set; }
        string IssuerDocumentIdentificationCode { get; set; }
        string IssuerName { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StaffIdentificationSystemDescriptor table of the StaffIdentificationSystemDescriptor aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStaffIdentificationSystemDescriptor : IDescriptor, ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int StaffIdentificationSystemDescriptorId { get; set; }

        // Inherited non-PK properties
        //string CodeValue { get; set; }
        //string Description { get; set; }
        //DateTime? EffectiveBeginDate { get; set; }
        //DateTime? EffectiveEndDate { get; set; }
        //string Namespace { get; set; }
        //int? PriorDescriptorId { get; set; }
        //string ShortDescription { get; set; }

        // Non-PK properties
        string StaffIdentificationSystemType { get; set; }

        // Inherited lists

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StaffIdentificationSystemType table of the StaffIdentificationSystemType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStaffIdentificationSystemType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int StaffIdentificationSystemTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StaffInternationalAddress table of the Staff aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStaffInternationalAddress : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IStaff Staff { get; set; }
        [NaturalKeyMember]
        string AddressType { get; set; }

        // Non-PK properties
        string AddressLine1 { get; set; }
        string AddressLine2 { get; set; }
        string AddressLine3 { get; set; }
        string AddressLine4 { get; set; }
        DateTime? BeginDate { get; set; }
        string CountryDescriptor { get; set; }
        DateTime? EndDate { get; set; }
        string Latitude { get; set; }
        string Longitude { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StaffLanguage table of the Staff aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStaffLanguage : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IStaff Staff { get; set; }
        [NaturalKeyMember]
        string LanguageDescriptor { get; set; }

        // Non-PK properties

        // Lists
        IList<IStaffLanguageUse> StaffLanguageUses { get; set; }
    } 

    /// <summary>
    /// Interface for the edfi.StaffLanguageUse table of the Staff aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStaffLanguageUse : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IStaffLanguage StaffLanguage { get; set; }
        [NaturalKeyMember]
        string LanguageUseType { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StaffOtherName table of the Staff aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStaffOtherName : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IStaff Staff { get; set; }
        [NaturalKeyMember]
        string OtherNameType { get; set; }

        // Non-PK properties
        string FirstName { get; set; }
        string GenerationCodeSuffix { get; set; }
        string LastSurname { get; set; }
        string MiddleName { get; set; }
        string PersonalTitlePrefix { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StaffProgramAssociation table of the StaffProgramAssociation aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStaffProgramAssociation : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        DateTime BeginDate { get; set; }
        [NaturalKeyMember]
        int ProgramEducationOrganizationId { get; set; }
        [NaturalKeyMember]
        string ProgramName { get; set; }
        [NaturalKeyMember]
        string ProgramType { get; set; }
        [NaturalKeyMember]
        string StaffUniqueId { get; set; }

        // Non-PK properties
        DateTime? EndDate { get; set; }
        bool? StudentRecordAccess { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StaffRace table of the Staff aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStaffRace : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IStaff Staff { get; set; }
        [NaturalKeyMember]
        string RaceType { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StaffSchoolAssociation table of the StaffSchoolAssociation aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStaffSchoolAssociation : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        string ProgramAssignmentDescriptor { get; set; }
        [NaturalKeyMember]
        int SchoolId { get; set; }
        [NaturalKeyMember]
        string StaffUniqueId { get; set; }

        // Non-PK properties
        short? SchoolYear { get; set; }

        // Lists
        IList<IStaffSchoolAssociationAcademicSubject> StaffSchoolAssociationAcademicSubjects { get; set; }
        IList<IStaffSchoolAssociationGradeLevel> StaffSchoolAssociationGradeLevels { get; set; }
    } 

    /// <summary>
    /// Interface for the edfi.StaffSchoolAssociationAcademicSubject table of the StaffSchoolAssociation aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStaffSchoolAssociationAcademicSubject : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IStaffSchoolAssociation StaffSchoolAssociation { get; set; }
        [NaturalKeyMember]
        string AcademicSubjectDescriptor { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StaffSchoolAssociationGradeLevel table of the StaffSchoolAssociation aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStaffSchoolAssociationGradeLevel : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IStaffSchoolAssociation StaffSchoolAssociation { get; set; }
        [NaturalKeyMember]
        string GradeLevelDescriptor { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StaffSectionAssociation table of the StaffSectionAssociation aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStaffSectionAssociation : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        string ClassPeriodName { get; set; }
        [NaturalKeyMember]
        string ClassroomIdentificationCode { get; set; }
        [NaturalKeyMember]
        string LocalCourseCode { get; set; }
        [NaturalKeyMember]
        int SchoolId { get; set; }
        [NaturalKeyMember]
        short SchoolYear { get; set; }
        [NaturalKeyMember]
        int SequenceOfCourse { get; set; }
        [NaturalKeyMember]
        string StaffUniqueId { get; set; }
        [NaturalKeyMember]
        string TermDescriptor { get; set; }
        [NaturalKeyMember]
        string UniqueSectionCode { get; set; }

        // Non-PK properties
        DateTime? BeginDate { get; set; }
        string ClassroomPositionDescriptor { get; set; }
        DateTime? EndDate { get; set; }
        bool? HighlyQualifiedTeacher { get; set; }
        decimal? PercentageContribution { get; set; }
        bool? TeacherStudentDataLinkExclusion { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StaffTelephone table of the Staff aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStaffTelephone : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IStaff Staff { get; set; }
        [NaturalKeyMember]
        string TelephoneNumberType { get; set; }

        // Non-PK properties
        int? OrderOfPriority { get; set; }
        string TelephoneNumber { get; set; }
        bool? TextMessageCapabilityIndicator { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StaffVisa table of the Staff aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStaffVisa : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IStaff Staff { get; set; }
        [NaturalKeyMember]
        string VisaType { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StateAbbreviationType table of the StateAbbreviationType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStateAbbreviationType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int StateAbbreviationTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StateEducationAgency table of the StateEducationAgency aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStateEducationAgency : IEducationOrganization, ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        int StateEducationAgencyId { get; set; }

        // Inherited non-PK properties
        //string NameOfInstitution { get; set; }
        //string OperationalStatusType { get; set; }
        //string ShortNameOfInstitution { get; set; }
        //string StateOrganizationId { get; set; }
        //string WebSite { get; set; }

        // Non-PK properties

        // Inherited lists
        //IList<IEducationOrganizationAddress> EducationOrganizationAddresses { get; set; }
        //IList<IEducationOrganizationCategory> EducationOrganizationCategories { get; set; }
        //IList<IEducationOrganizationIdentificationCode> EducationOrganizationIdentificationCodes { get; set; }
        //IList<IEducationOrganizationInstitutionTelephone> EducationOrganizationInstitutionTelephones { get; set; }
        //IList<IEducationOrganizationInternationalAddress> EducationOrganizationInternationalAddresses { get; set; }

        // Lists
        IList<IStateEducationAgencyAccountability> StateEducationAgencyAccountabilities { get; set; }
    } 

    /// <summary>
    /// Interface for the edfi.StateEducationAgencyAccountability table of the StateEducationAgency aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStateEducationAgencyAccountability : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IStateEducationAgency StateEducationAgency { get; set; }
        [NaturalKeyMember]
        short SchoolYear { get; set; }

        // Non-PK properties
        bool? CTEGraduationRateInclusion { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.Student table of the Student aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStudent : ISynchronizable, IMappable, IHasIdentifier, IIdentifiablePerson, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][UniqueId]
        string StudentUniqueId { get; set; }

        // Non-PK properties
        string BirthCity { get; set; }
        string BirthCountryDescriptor { get; set; }
        DateTime BirthDate { get; set; }
        string BirthInternationalProvince { get; set; }
        string BirthStateAbbreviationType { get; set; }
        string CitizenshipStatusType { get; set; }
        DateTime? DateEnteredUS { get; set; }
        string DisplacementStatus { get; set; }
        bool? EconomicDisadvantaged { get; set; }
        string FirstName { get; set; }
        string GenerationCodeSuffix { get; set; }
        bool HispanicLatinoEthnicity { get; set; }
        string LastSurname { get; set; }
        string LimitedEnglishProficiencyDescriptor { get; set; }
        string LoginId { get; set; }
        string MaidenName { get; set; }
        string MiddleName { get; set; }
        bool? MultipleBirthStatus { get; set; }
        string OldEthnicityType { get; set; }
        string PersonalTitlePrefix { get; set; }
        string ProfileThumbnail { get; set; }
        string SchoolFoodServicesEligibilityDescriptor { get; set; }
        string SexType { get; set; }

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        IStudentLearningStyle StudentLearningStyle { get; set; }

        // -------------------------------------------------------------

        // Lists
        IList<IStudentAddress> StudentAddresses { get; set; }
        IList<IStudentCharacteristic> StudentCharacteristics { get; set; }
        IList<IStudentCohortYear> StudentCohortYears { get; set; }
        IList<IStudentDisability> StudentDisabilities { get; set; }
        IList<IStudentElectronicMail> StudentElectronicMails { get; set; }
        IList<IStudentIdentificationCode> StudentIdentificationCodes { get; set; }
        IList<IStudentIdentificationDocument> StudentIdentificationDocuments { get; set; }
        IList<IStudentIndicator> StudentIndicators { get; set; }
        IList<IStudentInternationalAddress> StudentInternationalAddresses { get; set; }
        IList<IStudentLanguage> StudentLanguages { get; set; }
        IList<IStudentOtherName> StudentOtherNames { get; set; }
        IList<IStudentProgramParticipation> StudentProgramParticipations { get; set; }
        IList<IStudentRace> StudentRaces { get; set; }
        IList<IStudentTelephone> StudentTelephones { get; set; }
        IList<IStudentVisa> StudentVisas { get; set; }
    } 

    /// <summary>
    /// Interface for the edfi.StudentAcademicRecord table of the StudentAcademicRecord aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStudentAcademicRecord : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        int EducationOrganizationId { get; set; }
        [NaturalKeyMember]
        short SchoolYear { get; set; }
        [NaturalKeyMember]
        string StudentUniqueId { get; set; }
        [NaturalKeyMember]
        string TermDescriptor { get; set; }

        // Non-PK properties
        decimal? CumulativeAttemptedCreditConversion { get; set; }
        decimal? CumulativeAttemptedCredits { get; set; }
        string CumulativeAttemptedCreditType { get; set; }
        decimal? CumulativeEarnedCreditConversion { get; set; }
        decimal? CumulativeEarnedCredits { get; set; }
        string CumulativeEarnedCreditType { get; set; }
        decimal? CumulativeGradePointAverage { get; set; }
        decimal? CumulativeGradePointsEarned { get; set; }
        string GradeValueQualifier { get; set; }
        DateTime? ProjectedGraduationDate { get; set; }
        decimal? SessionAttemptedCreditConversion { get; set; }
        decimal? SessionAttemptedCredits { get; set; }
        string SessionAttemptedCreditType { get; set; }
        decimal? SessionEarnedCreditConversion { get; set; }
        decimal? SessionEarnedCredits { get; set; }
        string SessionEarnedCreditType { get; set; }
        decimal? SessionGradePointAverage { get; set; }
        decimal? SessionGradePointsEarned { get; set; }

        // =============================================================
        //                     One-to-one relationships
        // -------------------------------------------------------------
        IStudentAcademicRecordClassRanking StudentAcademicRecordClassRanking { get; set; }

        // -------------------------------------------------------------

        // Lists
        IList<IStudentAcademicRecordAcademicHonor> StudentAcademicRecordAcademicHonors { get; set; }
        IList<IStudentAcademicRecordDiploma> StudentAcademicRecordDiplomas { get; set; }
        IList<IStudentAcademicRecordRecognition> StudentAcademicRecordRecognitions { get; set; }
        IList<IStudentAcademicRecordReportCard> StudentAcademicRecordReportCards { get; set; }
    } 

    /// <summary>
    /// Interface for the edfi.StudentAcademicRecordAcademicHonor table of the StudentAcademicRecord aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStudentAcademicRecordAcademicHonor : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IStudentAcademicRecord StudentAcademicRecord { get; set; }
        [NaturalKeyMember]
        string AcademicHonorCategoryType { get; set; }

        // Non-PK properties
        string AchievementCategoryDescriptor { get; set; }
        string AchievementCategorySystem { get; set; }
        string AchievementTitle { get; set; }
        string Criteria { get; set; }
        string CriteriaURL { get; set; }
        string EvidenceStatement { get; set; }
        DateTime? HonorAwardDate { get; set; }
        DateTime? HonorAwardExpiresDate { get; set; }
        string HonorDescription { get; set; }
        string ImageURL { get; set; }
        string IssuerName { get; set; }
        string IssuerOriginURL { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StudentAcademicRecordClassRanking table of the StudentAcademicRecord aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStudentAcademicRecordClassRanking : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IStudentAcademicRecord StudentAcademicRecord { get; set; }

        // Non-PK properties
        int ClassRank { get; set; }
        DateTime? ClassRankingDate { get; set; }
        int? PercentageRanking { get; set; }
        int TotalNumberInClass { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StudentAcademicRecordDiploma table of the StudentAcademicRecord aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStudentAcademicRecordDiploma : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IStudentAcademicRecord StudentAcademicRecord { get; set; }
        [NaturalKeyMember]
        DateTime DiplomaAwardDate { get; set; }
        [NaturalKeyMember]
        string DiplomaType { get; set; }

        // Non-PK properties
        string AchievementCategoryDescriptor { get; set; }
        string AchievementCategorySystem { get; set; }
        string AchievementTitle { get; set; }
        string Criteria { get; set; }
        string CriteriaURL { get; set; }
        bool? CTECompleter { get; set; }
        DateTime? DiplomaAwardExpiresDate { get; set; }
        string DiplomaDescription { get; set; }
        string DiplomaLevelType { get; set; }
        string EvidenceStatement { get; set; }
        string ImageURL { get; set; }
        string IssuerName { get; set; }
        string IssuerOriginURL { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StudentAcademicRecordRecognition table of the StudentAcademicRecord aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStudentAcademicRecordRecognition : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IStudentAcademicRecord StudentAcademicRecord { get; set; }
        [NaturalKeyMember]
        string RecognitionType { get; set; }

        // Non-PK properties
        string AchievementCategoryDescriptor { get; set; }
        string AchievementCategorySystem { get; set; }
        string AchievementTitle { get; set; }
        string Criteria { get; set; }
        string CriteriaURL { get; set; }
        string EvidenceStatement { get; set; }
        string ImageURL { get; set; }
        string IssuerName { get; set; }
        string IssuerOriginURL { get; set; }
        DateTime? RecognitionAwardDate { get; set; }
        DateTime? RecognitionAwardExpiresDate { get; set; }
        string RecognitionDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StudentAcademicRecordReportCard table of the StudentAcademicRecord aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStudentAcademicRecordReportCard : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IStudentAcademicRecord StudentAcademicRecord { get; set; }
        [NaturalKeyMember]
        DateTime GradingPeriodBeginDate { get; set; }
        [NaturalKeyMember]
        string GradingPeriodDescriptor { get; set; }
        [NaturalKeyMember]
        int SchoolId { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StudentAddress table of the Student aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStudentAddress : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IStudent Student { get; set; }
        [NaturalKeyMember]
        string AddressType { get; set; }

        // Non-PK properties
        string ApartmentRoomSuiteNumber { get; set; }
        DateTime? BeginDate { get; set; }
        string BuildingSiteNumber { get; set; }
        string City { get; set; }
        string CountyFIPSCode { get; set; }
        DateTime? EndDate { get; set; }
        string Latitude { get; set; }
        string Longitude { get; set; }
        string NameOfCounty { get; set; }
        string PostalCode { get; set; }
        string StateAbbreviationType { get; set; }
        string StreetNumberName { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StudentAssessment table of the StudentAssessment aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStudentAssessment : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        string AssessmentIdentifier { get; set; }
        [NaturalKeyMember]
        string Namespace { get; set; }
        [NaturalKeyMember]
        string StudentAssessmentIdentifier { get; set; }
        [NaturalKeyMember]
        string StudentUniqueId { get; set; }

        // Non-PK properties
        DateTime AdministrationDate { get; set; }
        DateTime? AdministrationEndDate { get; set; }
        string AdministrationEnvironmentType { get; set; }
        string AdministrationLanguageDescriptor { get; set; }
        string EventCircumstanceType { get; set; }
        string EventDescription { get; set; }
        string ReasonNotTestedType { get; set; }
        string RetestIndicatorType { get; set; }
        string SerialNumber { get; set; }
        string WhenAssessedGradeLevelDescriptor { get; set; }

        // Lists
        IList<IStudentAssessmentAccommodation> StudentAssessmentAccommodations { get; set; }
        IList<IStudentAssessmentItem> StudentAssessmentItems { get; set; }
        IList<IStudentAssessmentPerformanceLevel> StudentAssessmentPerformanceLevels { get; set; }
        IList<IStudentAssessmentScoreResult> StudentAssessmentScoreResults { get; set; }
        IList<IStudentAssessmentStudentObjectiveAssessment> StudentAssessmentStudentObjectiveAssessments { get; set; }
    } 

    /// <summary>
    /// Interface for the edfi.StudentAssessmentAccommodation table of the StudentAssessment aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStudentAssessmentAccommodation : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IStudentAssessment StudentAssessment { get; set; }
        [NaturalKeyMember]
        string AccommodationDescriptor { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StudentAssessmentItem table of the StudentAssessment aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStudentAssessmentItem : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IStudentAssessment StudentAssessment { get; set; }
        [NaturalKeyMember]
        string IdentificationCode { get; set; }

        // Non-PK properties
        string AssessmentItemResultType { get; set; }
        string AssessmentResponse { get; set; }
        string DescriptiveFeedback { get; set; }
        int? RawScoreResult { get; set; }
        string ResponseIndicatorType { get; set; }
        string TimeAssessed { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StudentAssessmentPerformanceLevel table of the StudentAssessment aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStudentAssessmentPerformanceLevel : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IStudentAssessment StudentAssessment { get; set; }
        [NaturalKeyMember]
        string AssessmentReportingMethodType { get; set; }
        [NaturalKeyMember]
        string PerformanceLevelDescriptor { get; set; }

        // Non-PK properties
        bool PerformanceLevelMet { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StudentAssessmentScoreResult table of the StudentAssessment aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStudentAssessmentScoreResult : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IStudentAssessment StudentAssessment { get; set; }
        [NaturalKeyMember]
        string AssessmentReportingMethodType { get; set; }

        // Non-PK properties
        string Result { get; set; }
        string ResultDatatypeType { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StudentAssessmentStudentObjectiveAssessment table of the StudentAssessment aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStudentAssessmentStudentObjectiveAssessment : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IStudentAssessment StudentAssessment { get; set; }
        [NaturalKeyMember]
        string IdentificationCode { get; set; }

        // Non-PK properties

        // Lists
        IList<IStudentAssessmentStudentObjectiveAssessmentPerformanceLevel> StudentAssessmentStudentObjectiveAssessmentPerformanceLevels { get; set; }
        IList<IStudentAssessmentStudentObjectiveAssessmentScoreResult> StudentAssessmentStudentObjectiveAssessmentScoreResults { get; set; }
    } 

    /// <summary>
    /// Interface for the edfi.StudentAssessmentStudentObjectiveAssessmentPerformanceLevel table of the StudentAssessment aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStudentAssessmentStudentObjectiveAssessmentPerformanceLevel : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IStudentAssessmentStudentObjectiveAssessment StudentAssessmentStudentObjectiveAssessment { get; set; }
        [NaturalKeyMember]
        string AssessmentReportingMethodType { get; set; }
        [NaturalKeyMember]
        string PerformanceLevelDescriptor { get; set; }

        // Non-PK properties
        bool PerformanceLevelMet { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StudentAssessmentStudentObjectiveAssessmentScoreResult table of the StudentAssessment aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStudentAssessmentStudentObjectiveAssessmentScoreResult : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IStudentAssessmentStudentObjectiveAssessment StudentAssessmentStudentObjectiveAssessment { get; set; }
        [NaturalKeyMember]
        string AssessmentReportingMethodType { get; set; }

        // Non-PK properties
        string Result { get; set; }
        string ResultDatatypeType { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StudentCharacteristic table of the Student aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStudentCharacteristic : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IStudent Student { get; set; }
        [NaturalKeyMember]
        string StudentCharacteristicDescriptor { get; set; }

        // Non-PK properties
        DateTime? BeginDate { get; set; }
        string DesignatedBy { get; set; }
        DateTime? EndDate { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StudentCharacteristicDescriptor table of the StudentCharacteristicDescriptor aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStudentCharacteristicDescriptor : IDescriptor, ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int StudentCharacteristicDescriptorId { get; set; }

        // Inherited non-PK properties
        //string CodeValue { get; set; }
        //string Description { get; set; }
        //DateTime? EffectiveBeginDate { get; set; }
        //DateTime? EffectiveEndDate { get; set; }
        //string Namespace { get; set; }
        //int? PriorDescriptorId { get; set; }
        //string ShortDescription { get; set; }

        // Non-PK properties
        string StudentCharacteristicType { get; set; }

        // Inherited lists

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StudentCharacteristicType table of the StudentCharacteristicType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStudentCharacteristicType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int StudentCharacteristicTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StudentCohortAssociation table of the StudentCohortAssociation aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStudentCohortAssociation : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        DateTime BeginDate { get; set; }
        [NaturalKeyMember]
        string CohortIdentifier { get; set; }
        [NaturalKeyMember]
        int EducationOrganizationId { get; set; }
        [NaturalKeyMember]
        string StudentUniqueId { get; set; }

        // Non-PK properties
        DateTime? EndDate { get; set; }

        // Lists
        IList<IStudentCohortAssociationSection> StudentCohortAssociationSections { get; set; }
    } 

    /// <summary>
    /// Interface for the edfi.StudentCohortAssociationSection table of the StudentCohortAssociation aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStudentCohortAssociationSection : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IStudentCohortAssociation StudentCohortAssociation { get; set; }
        [NaturalKeyMember]
        string ClassPeriodName { get; set; }
        [NaturalKeyMember]
        string ClassroomIdentificationCode { get; set; }
        [NaturalKeyMember]
        string LocalCourseCode { get; set; }
        [NaturalKeyMember]
        int SchoolId { get; set; }
        [NaturalKeyMember]
        short SchoolYear { get; set; }
        [NaturalKeyMember]
        int SequenceOfCourse { get; set; }
        [NaturalKeyMember]
        string TermDescriptor { get; set; }
        [NaturalKeyMember]
        string UniqueSectionCode { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StudentCohortYear table of the Student aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStudentCohortYear : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IStudent Student { get; set; }
        [NaturalKeyMember]
        string CohortYearType { get; set; }
        [NaturalKeyMember]
        short SchoolYear { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StudentCompetencyObjective table of the StudentCompetencyObjective aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStudentCompetencyObjective : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        DateTime GradingPeriodBeginDate { get; set; }
        [NaturalKeyMember]
        string GradingPeriodDescriptor { get; set; }
        [NaturalKeyMember]
        string Objective { get; set; }
        [NaturalKeyMember]
        int ObjectiveEducationOrganizationId { get; set; }
        [NaturalKeyMember]
        string ObjectiveGradeLevelDescriptor { get; set; }
        [NaturalKeyMember]
        int SchoolId { get; set; }
        [NaturalKeyMember]
        string StudentUniqueId { get; set; }

        // Non-PK properties
        DateTime? BeginDate { get; set; }
        string ClassPeriodName { get; set; }
        string ClassroomIdentificationCode { get; set; }
        string CompetencyLevelDescriptor { get; set; }
        string DiagnosticStatement { get; set; }
        int? EducationOrganizationId { get; set; }
        string LocalCourseCode { get; set; }
        int? ProgramEducationOrganizationId { get; set; }
        string ProgramName { get; set; }
        string ProgramType { get; set; }
        short? SchoolYear { get; set; }
        int? SequenceOfCourse { get; set; }
        string TermDescriptor { get; set; }
        string UniqueSectionCode { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StudentCTEProgramAssociation table of the StudentCTEProgramAssociation aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStudentCTEProgramAssociation : IStudentProgramAssociation, ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties

        // Inherited non-PK properties
        //DateTime? EndDate { get; set; }
        //string ReasonExitedDescriptor { get; set; }
        //bool? ServedOutsideOfRegularSession { get; set; }

        // Non-PK properties

        // Inherited lists
        //IList<IStudentProgramAssociationService> StudentProgramAssociationServices { get; set; }

        // Lists
        IList<IStudentCTEProgramAssociationCTEProgram> StudentCTEProgramAssociationCTEPrograms { get; set; }
    } 

    /// <summary>
    /// Interface for the edfi.StudentCTEProgramAssociationCTEProgram table of the StudentCTEProgramAssociation aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStudentCTEProgramAssociationCTEProgram : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IStudentCTEProgramAssociation StudentCTEProgramAssociation { get; set; }
        [NaturalKeyMember]
        string CareerPathwayType { get; set; }

        // Non-PK properties
        string CIPCode { get; set; }
        bool? CTEProgramCompletionIndicator { get; set; }
        bool? PrimaryCTEProgramIndicator { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StudentDisability table of the Student aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStudentDisability : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IStudent Student { get; set; }
        [NaturalKeyMember]
        string DisabilityDescriptor { get; set; }

        // Non-PK properties
        string DisabilityDeterminationSourceType { get; set; }
        string DisabilityDiagnosis { get; set; }
        int? OrderOfDisability { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StudentDisciplineIncidentAssociation table of the StudentDisciplineIncidentAssociation aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStudentDisciplineIncidentAssociation : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        string IncidentIdentifier { get; set; }
        [NaturalKeyMember]
        int SchoolId { get; set; }
        [NaturalKeyMember]
        string StudentUniqueId { get; set; }

        // Non-PK properties
        string StudentParticipationCodeType { get; set; }

        // Lists
        IList<IStudentDisciplineIncidentAssociationBehavior> StudentDisciplineIncidentAssociationBehaviors { get; set; }
    } 

    /// <summary>
    /// Interface for the edfi.StudentDisciplineIncidentAssociationBehavior table of the StudentDisciplineIncidentAssociation aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStudentDisciplineIncidentAssociationBehavior : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IStudentDisciplineIncidentAssociation StudentDisciplineIncidentAssociation { get; set; }
        [NaturalKeyMember]
        string BehaviorDescriptor { get; set; }

        // Non-PK properties
        string BehaviorDetailedDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StudentEducationOrganizationAssociation table of the StudentEducationOrganizationAssociation aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStudentEducationOrganizationAssociation : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        int EducationOrganizationId { get; set; }
        [NaturalKeyMember]
        string ResponsibilityDescriptor { get; set; }
        [NaturalKeyMember]
        string StudentUniqueId { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StudentElectronicMail table of the Student aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStudentElectronicMail : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IStudent Student { get; set; }
        [NaturalKeyMember]
        string ElectronicMailType { get; set; }

        // Non-PK properties
        string ElectronicMailAddress { get; set; }
        bool? PrimaryEmailAddressIndicator { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StudentGradebookEntry table of the StudentGradebookEntry aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStudentGradebookEntry : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        DateTime BeginDate { get; set; }
        [NaturalKeyMember]
        string ClassPeriodName { get; set; }
        [NaturalKeyMember]
        string ClassroomIdentificationCode { get; set; }
        [NaturalKeyMember]
        DateTime DateAssigned { get; set; }
        [NaturalKeyMember]
        string GradebookEntryTitle { get; set; }
        [NaturalKeyMember]
        string LocalCourseCode { get; set; }
        [NaturalKeyMember]
        int SchoolId { get; set; }
        [NaturalKeyMember]
        short SchoolYear { get; set; }
        [NaturalKeyMember]
        int SequenceOfCourse { get; set; }
        [NaturalKeyMember]
        string StudentUniqueId { get; set; }
        [NaturalKeyMember]
        string TermDescriptor { get; set; }
        [NaturalKeyMember]
        string UniqueSectionCode { get; set; }

        // Non-PK properties
        string CompetencyLevelDescriptor { get; set; }
        DateTime? DateFulfilled { get; set; }
        string DiagnosticStatement { get; set; }
        string LetterGradeEarned { get; set; }
        decimal? NumericGradeEarned { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StudentIdentificationCode table of the Student aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStudentIdentificationCode : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IStudent Student { get; set; }
        [NaturalKeyMember]
        string AssigningOrganizationIdentificationCode { get; set; }
        [NaturalKeyMember]
        string StudentIdentificationSystemDescriptor { get; set; }

        // Non-PK properties
        string IdentificationCode { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StudentIdentificationDocument table of the Student aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStudentIdentificationDocument : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IStudent Student { get; set; }
        [NaturalKeyMember]
        string IdentificationDocumentUseType { get; set; }
        [NaturalKeyMember]
        string PersonalInformationVerificationType { get; set; }

        // Non-PK properties
        DateTime? DocumentExpirationDate { get; set; }
        string DocumentTitle { get; set; }
        string IssuerCountryDescriptor { get; set; }
        string IssuerDocumentIdentificationCode { get; set; }
        string IssuerName { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StudentIdentificationSystemDescriptor table of the StudentIdentificationSystemDescriptor aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStudentIdentificationSystemDescriptor : IDescriptor, ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int StudentIdentificationSystemDescriptorId { get; set; }

        // Inherited non-PK properties
        //string CodeValue { get; set; }
        //string Description { get; set; }
        //DateTime? EffectiveBeginDate { get; set; }
        //DateTime? EffectiveEndDate { get; set; }
        //string Namespace { get; set; }
        //int? PriorDescriptorId { get; set; }
        //string ShortDescription { get; set; }

        // Non-PK properties
        string StudentIdentificationSystemType { get; set; }

        // Inherited lists

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StudentIdentificationSystemType table of the StudentIdentificationSystemType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStudentIdentificationSystemType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int StudentIdentificationSystemTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StudentIndicator table of the Student aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStudentIndicator : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IStudent Student { get; set; }
        [NaturalKeyMember]
        string IndicatorName { get; set; }

        // Non-PK properties
        DateTime? BeginDate { get; set; }
        string DesignatedBy { get; set; }
        DateTime? EndDate { get; set; }
        string Indicator { get; set; }
        string IndicatorGroup { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StudentInternationalAddress table of the Student aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStudentInternationalAddress : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IStudent Student { get; set; }
        [NaturalKeyMember]
        string AddressType { get; set; }

        // Non-PK properties
        string AddressLine1 { get; set; }
        string AddressLine2 { get; set; }
        string AddressLine3 { get; set; }
        string AddressLine4 { get; set; }
        DateTime? BeginDate { get; set; }
        string CountryDescriptor { get; set; }
        DateTime? EndDate { get; set; }
        string Latitude { get; set; }
        string Longitude { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StudentInterventionAssociation table of the StudentInterventionAssociation aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStudentInterventionAssociation : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        int EducationOrganizationId { get; set; }
        [NaturalKeyMember]
        string InterventionIdentificationCode { get; set; }
        [NaturalKeyMember]
        string StudentUniqueId { get; set; }

        // Non-PK properties
        int? CohortEducationOrganizationId { get; set; }
        string CohortIdentifier { get; set; }
        string DiagnosticStatement { get; set; }

        // Lists
        IList<IStudentInterventionAssociationInterventionEffectiveness> StudentInterventionAssociationInterventionEffectivenesses { get; set; }
    } 

    /// <summary>
    /// Interface for the edfi.StudentInterventionAssociationInterventionEffectiveness table of the StudentInterventionAssociation aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStudentInterventionAssociationInterventionEffectiveness : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IStudentInterventionAssociation StudentInterventionAssociation { get; set; }
        [NaturalKeyMember]
        string DiagnosisDescriptor { get; set; }
        [NaturalKeyMember]
        string GradeLevelDescriptor { get; set; }
        [NaturalKeyMember]
        string PopulationServedType { get; set; }

        // Non-PK properties
        int? ImprovementIndex { get; set; }
        string InterventionEffectivenessRatingType { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StudentInterventionAttendanceEvent table of the StudentInterventionAttendanceEvent aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStudentInterventionAttendanceEvent : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        string AttendanceEventCategoryDescriptor { get; set; }
        [NaturalKeyMember]
        int EducationOrganizationId { get; set; }
        [NaturalKeyMember]
        DateTime EventDate { get; set; }
        [NaturalKeyMember]
        string InterventionIdentificationCode { get; set; }
        [NaturalKeyMember]
        string StudentUniqueId { get; set; }

        // Non-PK properties
        string AttendanceEventReason { get; set; }
        string EducationalEnvironmentType { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StudentLanguage table of the Student aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStudentLanguage : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IStudent Student { get; set; }
        [NaturalKeyMember]
        string LanguageDescriptor { get; set; }

        // Non-PK properties

        // Lists
        IList<IStudentLanguageUse> StudentLanguageUses { get; set; }
    } 

    /// <summary>
    /// Interface for the edfi.StudentLanguageUse table of the Student aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStudentLanguageUse : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IStudentLanguage StudentLanguage { get; set; }
        [NaturalKeyMember]
        string LanguageUseType { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StudentLearningObjective table of the StudentLearningObjective aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStudentLearningObjective : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        DateTime GradingPeriodBeginDate { get; set; }
        [NaturalKeyMember]
        string GradingPeriodDescriptor { get; set; }
        [NaturalKeyMember]
        string LearningObjectiveId { get; set; }
        [NaturalKeyMember]
        string Namespace { get; set; }
        [NaturalKeyMember]
        int SchoolId { get; set; }
        [NaturalKeyMember]
        string StudentUniqueId { get; set; }

        // Non-PK properties
        DateTime? BeginDate { get; set; }
        string ClassPeriodName { get; set; }
        string ClassroomIdentificationCode { get; set; }
        string CompetencyLevelDescriptor { get; set; }
        string DiagnosticStatement { get; set; }
        int? EducationOrganizationId { get; set; }
        string LocalCourseCode { get; set; }
        int? ProgramEducationOrganizationId { get; set; }
        string ProgramName { get; set; }
        string ProgramType { get; set; }
        short? SchoolYear { get; set; }
        int? SequenceOfCourse { get; set; }
        DateTime? StudentSectionAssociationBeginDate { get; set; }
        string TermDescriptor { get; set; }
        string UniqueSectionCode { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StudentLearningStyle table of the Student aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStudentLearningStyle : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IStudent Student { get; set; }

        // Non-PK properties
        decimal AuditoryLearning { get; set; }
        decimal TactileLearning { get; set; }
        decimal VisualLearning { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StudentMigrantEducationProgramAssociation table of the StudentMigrantEducationProgramAssociation aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStudentMigrantEducationProgramAssociation : IStudentProgramAssociation, ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties

        // Inherited non-PK properties
        //DateTime? EndDate { get; set; }
        //string ReasonExitedDescriptor { get; set; }
        //bool? ServedOutsideOfRegularSession { get; set; }

        // Non-PK properties
        string ContinuationOfServicesReasonDescriptor { get; set; }
        DateTime LastQualifyingMove { get; set; }
        bool PriorityForServices { get; set; }
        DateTime? USInitialEntry { get; set; }
        DateTime? USInitialSchoolEntry { get; set; }
        DateTime? USMostRecentEntry { get; set; }

        // Inherited lists
        //IList<IStudentProgramAssociationService> StudentProgramAssociationServices { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StudentOtherName table of the Student aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStudentOtherName : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IStudent Student { get; set; }
        [NaturalKeyMember]
        string OtherNameType { get; set; }

        // Non-PK properties
        string FirstName { get; set; }
        string GenerationCodeSuffix { get; set; }
        string LastSurname { get; set; }
        string MiddleName { get; set; }
        string PersonalTitlePrefix { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StudentParentAssociation table of the StudentParentAssociation aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStudentParentAssociation : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        string ParentUniqueId { get; set; }
        [NaturalKeyMember]
        string StudentUniqueId { get; set; }

        // Non-PK properties
        int? ContactPriority { get; set; }
        string ContactRestrictions { get; set; }
        bool? EmergencyContactStatus { get; set; }
        bool? LivesWith { get; set; }
        bool? PrimaryContactStatus { get; set; }
        string RelationType { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StudentParticipationCodeType table of the StudentParticipationCodeType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStudentParticipationCodeType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int StudentParticipationCodeTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StudentProgramAssociation table of the StudentProgramAssociation aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStudentProgramAssociation : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        DateTime BeginDate { get; set; }
        [NaturalKeyMember]
        int EducationOrganizationId { get; set; }
        [NaturalKeyMember]
        int ProgramEducationOrganizationId { get; set; }
        [NaturalKeyMember]
        string ProgramName { get; set; }
        [NaturalKeyMember]
        string ProgramType { get; set; }
        [NaturalKeyMember]
        string StudentUniqueId { get; set; }

        // Non-PK properties
        DateTime? EndDate { get; set; }
        string ReasonExitedDescriptor { get; set; }
        bool? ServedOutsideOfRegularSession { get; set; }

        // Lists
        IList<IStudentProgramAssociationService> StudentProgramAssociationServices { get; set; }
    } 

    /// <summary>
    /// Interface for the edfi.StudentProgramAssociationService table of the StudentProgramAssociation aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStudentProgramAssociationService : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IStudentProgramAssociation StudentProgramAssociation { get; set; }
        [NaturalKeyMember]
        string ServiceDescriptor { get; set; }

        // Non-PK properties
        bool? PrimaryIndicator { get; set; }
        DateTime? ServiceBeginDate { get; set; }
        DateTime? ServiceEndDate { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StudentProgramAttendanceEvent table of the StudentProgramAttendanceEvent aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStudentProgramAttendanceEvent : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        string AttendanceEventCategoryDescriptor { get; set; }
        [NaturalKeyMember]
        int EducationOrganizationId { get; set; }
        [NaturalKeyMember]
        DateTime EventDate { get; set; }
        [NaturalKeyMember]
        int ProgramEducationOrganizationId { get; set; }
        [NaturalKeyMember]
        string ProgramName { get; set; }
        [NaturalKeyMember]
        string ProgramType { get; set; }
        [NaturalKeyMember]
        string StudentUniqueId { get; set; }

        // Non-PK properties
        string AttendanceEventReason { get; set; }
        string EducationalEnvironmentType { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StudentProgramParticipation table of the Student aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStudentProgramParticipation : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IStudent Student { get; set; }
        [NaturalKeyMember]
        string ProgramType { get; set; }

        // Non-PK properties
        DateTime? BeginDate { get; set; }
        string DesignatedBy { get; set; }
        DateTime? EndDate { get; set; }

        // Lists
        IList<IStudentProgramParticipationProgramCharacteristic> StudentProgramParticipationProgramCharacteristics { get; set; }
    } 

    /// <summary>
    /// Interface for the edfi.StudentProgramParticipationProgramCharacteristic table of the Student aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStudentProgramParticipationProgramCharacteristic : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IStudentProgramParticipation StudentProgramParticipation { get; set; }
        [NaturalKeyMember]
        string ProgramCharacteristicDescriptor { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StudentRace table of the Student aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStudentRace : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IStudent Student { get; set; }
        [NaturalKeyMember]
        string RaceType { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StudentSchoolAssociation table of the StudentSchoolAssociation aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStudentSchoolAssociation : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        DateTime EntryDate { get; set; }
        [NaturalKeyMember]
        int SchoolId { get; set; }
        [NaturalKeyMember]
        string StudentUniqueId { get; set; }

        // Non-PK properties
        short? ClassOfSchoolYear { get; set; }
        int? EducationOrganizationId { get; set; }
        bool? EmployedWhileEnrolled { get; set; }
        string EntryGradeLevelDescriptor { get; set; }
        string EntryGradeLevelReasonType { get; set; }
        string EntryTypeDescriptor { get; set; }
        DateTime? ExitWithdrawDate { get; set; }
        string ExitWithdrawTypeDescriptor { get; set; }
        string GraduationPlanTypeDescriptor { get; set; }
        short? GraduationSchoolYear { get; set; }
        bool? PrimarySchool { get; set; }
        bool? RepeatGradeIndicator { get; set; }
        string ResidencyStatusDescriptor { get; set; }
        bool? SchoolChoiceTransfer { get; set; }
        short? SchoolYear { get; set; }

        // Lists
        IList<IStudentSchoolAssociationEducationPlan> StudentSchoolAssociationEducationPlans { get; set; }
    } 

    /// <summary>
    /// Interface for the edfi.StudentSchoolAssociationEducationPlan table of the StudentSchoolAssociation aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStudentSchoolAssociationEducationPlan : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IStudentSchoolAssociation StudentSchoolAssociation { get; set; }
        [NaturalKeyMember]
        string EducationPlanType { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StudentSchoolAttendanceEvent table of the StudentSchoolAttendanceEvent aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStudentSchoolAttendanceEvent : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        string AttendanceEventCategoryDescriptor { get; set; }
        [NaturalKeyMember]
        DateTime EventDate { get; set; }
        [NaturalKeyMember]
        int SchoolId { get; set; }
        [NaturalKeyMember]
        short SchoolYear { get; set; }
        [NaturalKeyMember]
        string StudentUniqueId { get; set; }
        [NaturalKeyMember]
        string TermDescriptor { get; set; }

        // Non-PK properties
        string AttendanceEventReason { get; set; }
        string EducationalEnvironmentType { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StudentSectionAssociation table of the StudentSectionAssociation aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStudentSectionAssociation : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        DateTime BeginDate { get; set; }
        [NaturalKeyMember]
        string ClassPeriodName { get; set; }
        [NaturalKeyMember]
        string ClassroomIdentificationCode { get; set; }
        [NaturalKeyMember]
        string LocalCourseCode { get; set; }
        [NaturalKeyMember]
        int SchoolId { get; set; }
        [NaturalKeyMember]
        short SchoolYear { get; set; }
        [NaturalKeyMember]
        int SequenceOfCourse { get; set; }
        [NaturalKeyMember]
        string StudentUniqueId { get; set; }
        [NaturalKeyMember]
        string TermDescriptor { get; set; }
        [NaturalKeyMember]
        string UniqueSectionCode { get; set; }

        // Non-PK properties
        DateTime? EndDate { get; set; }
        bool? HomeroomIndicator { get; set; }
        string RepeatIdentifierType { get; set; }
        bool? TeacherStudentDataLinkExclusion { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StudentSectionAttendanceEvent table of the StudentSectionAttendanceEvent aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStudentSectionAttendanceEvent : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        string AttendanceEventCategoryDescriptor { get; set; }
        [NaturalKeyMember]
        string ClassPeriodName { get; set; }
        [NaturalKeyMember]
        string ClassroomIdentificationCode { get; set; }
        [NaturalKeyMember]
        DateTime EventDate { get; set; }
        [NaturalKeyMember]
        string LocalCourseCode { get; set; }
        [NaturalKeyMember]
        int SchoolId { get; set; }
        [NaturalKeyMember]
        short SchoolYear { get; set; }
        [NaturalKeyMember]
        int SequenceOfCourse { get; set; }
        [NaturalKeyMember]
        string StudentUniqueId { get; set; }
        [NaturalKeyMember]
        string TermDescriptor { get; set; }
        [NaturalKeyMember]
        string UniqueSectionCode { get; set; }

        // Non-PK properties
        string AttendanceEventReason { get; set; }
        string EducationalEnvironmentType { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StudentSpecialEducationProgramAssociation table of the StudentSpecialEducationProgramAssociation aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStudentSpecialEducationProgramAssociation : IStudentProgramAssociation, ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties

        // Inherited non-PK properties
        //DateTime? EndDate { get; set; }
        //string ReasonExitedDescriptor { get; set; }
        //bool? ServedOutsideOfRegularSession { get; set; }

        // Non-PK properties
        bool? IdeaEligibility { get; set; }
        DateTime? IEPBeginDate { get; set; }
        DateTime? IEPEndDate { get; set; }
        DateTime? IEPReviewDate { get; set; }
        DateTime? LastEvaluationDate { get; set; }
        bool? MedicallyFragile { get; set; }
        bool? MultiplyDisabled { get; set; }
        decimal? SchoolHoursPerWeek { get; set; }
        decimal? SpecialEducationHoursPerWeek { get; set; }
        string SpecialEducationSettingDescriptor { get; set; }

        // Inherited lists
        //IList<IStudentProgramAssociationService> StudentProgramAssociationServices { get; set; }

        // Lists
        IList<IStudentSpecialEducationProgramAssociationServiceProvider> StudentSpecialEducationProgramAssociationServiceProviders { get; set; }
    } 

    /// <summary>
    /// Interface for the edfi.StudentSpecialEducationProgramAssociationServiceProvider table of the StudentSpecialEducationProgramAssociation aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStudentSpecialEducationProgramAssociationServiceProvider : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IStudentSpecialEducationProgramAssociation StudentSpecialEducationProgramAssociation { get; set; }
        [NaturalKeyMember]
        string StaffUniqueId { get; set; }

        // Non-PK properties
        bool? PrimaryProvider { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StudentTelephone table of the Student aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStudentTelephone : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IStudent Student { get; set; }
        [NaturalKeyMember]
        string TelephoneNumberType { get; set; }

        // Non-PK properties
        int? OrderOfPriority { get; set; }
        string TelephoneNumber { get; set; }
        bool? TextMessageCapabilityIndicator { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StudentTitleIPartAProgramAssociation table of the StudentTitleIPartAProgramAssociation aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStudentTitleIPartAProgramAssociation : IStudentProgramAssociation, ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties

        // Inherited non-PK properties
        //DateTime? EndDate { get; set; }
        //string ReasonExitedDescriptor { get; set; }
        //bool? ServedOutsideOfRegularSession { get; set; }

        // Non-PK properties
        string TitleIPartAParticipantType { get; set; }

        // Inherited lists
        //IList<IStudentProgramAssociationService> StudentProgramAssociationServices { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.StudentVisa table of the Student aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IStudentVisa : ISynchronizable, IMappable, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember]
        IStudent Student { get; set; }
        [NaturalKeyMember]
        string VisaType { get; set; }

        // Non-PK properties

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.TeachingCredentialBasisType table of the TeachingCredentialBasisType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ITeachingCredentialBasisType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int TeachingCredentialBasisTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.TeachingCredentialDescriptor table of the TeachingCredentialDescriptor aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ITeachingCredentialDescriptor : IDescriptor, ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int TeachingCredentialDescriptorId { get; set; }

        // Inherited non-PK properties
        //string CodeValue { get; set; }
        //string Description { get; set; }
        //DateTime? EffectiveBeginDate { get; set; }
        //DateTime? EffectiveEndDate { get; set; }
        //string Namespace { get; set; }
        //int? PriorDescriptorId { get; set; }
        //string ShortDescription { get; set; }

        // Non-PK properties
        string TeachingCredentialType { get; set; }

        // Inherited lists

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.TeachingCredentialType table of the TeachingCredentialType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ITeachingCredentialType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int TeachingCredentialTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.TelephoneNumberType table of the TelephoneNumberType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ITelephoneNumberType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int TelephoneNumberTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.TermDescriptor table of the TermDescriptor aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ITermDescriptor : IDescriptor, ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int TermDescriptorId { get; set; }

        // Inherited non-PK properties
        //string CodeValue { get; set; }
        //string Description { get; set; }
        //DateTime? EffectiveBeginDate { get; set; }
        //DateTime? EffectiveEndDate { get; set; }
        //string Namespace { get; set; }
        //int? PriorDescriptorId { get; set; }
        //string ShortDescription { get; set; }

        // Non-PK properties
        string TermType { get; set; }

        // Inherited lists

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.TermType table of the TermType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ITermType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int TermTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.TitleIPartAParticipantType table of the TitleIPartAParticipantType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ITitleIPartAParticipantType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int TitleIPartAParticipantTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.TitleIPartASchoolDesignationType table of the TitleIPartASchoolDesignationType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface ITitleIPartASchoolDesignationType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int TitleIPartASchoolDesignationTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.VisaType table of the VisaType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IVisaType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int VisaTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.WeaponDescriptor table of the WeaponDescriptor aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IWeaponDescriptor : IDescriptor, ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int WeaponDescriptorId { get; set; }

        // Inherited non-PK properties
        //string CodeValue { get; set; }
        //string Description { get; set; }
        //DateTime? EffectiveBeginDate { get; set; }
        //DateTime? EffectiveEndDate { get; set; }
        //string Namespace { get; set; }
        //int? PriorDescriptorId { get; set; }
        //string ShortDescription { get; set; }

        // Non-PK properties
        string WeaponType { get; set; }

        // Inherited lists

        // Lists
    } 

    /// <summary>
    /// Interface for the edfi.WeaponType table of the WeaponType aggregate in the EdFi_Ods Database.
    /// </summary>
    public interface IWeaponType : ISynchronizable, IMappable, IHasIdentifier, IGetByExample
    {
        // Primary Key properties
        [NaturalKeyMember][AutoIncrement]
        int WeaponTypeId { get; set; }

        // Non-PK properties
        string CodeValue { get; set; }
        string Description { get; set; }
        string ShortDescription { get; set; }

        // Lists
    } 
}