// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.
 
using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using EdFi.Ods.Api.Models.Resources.V2.AssessmentFamily;
using EdFi.Ods.Api.Models.Resources.V3.Assessment.EdFi;
using EdFi.Ods.AssessmentBridge.WebApi.Mapping;
using EdFi.Ods.Entities.Common;
using Newtonsoft.Json.Linq;

#region Explictly Versioned Model Type Aliases
// -----------------
//    Assessment
// -----------------
using V3AssessmentReference = EdFi.Ods.Api.Models.Resources.V3.Assessment.EdFi.AssessmentReference;
using V2AssessmentReference = EdFi.Ods.Api.Models.Resources.V2.Assessment.AssessmentReference;

using V3Assessment = EdFi.Ods.Api.Models.Resources.V3.Assessment.EdFi.Assessment;
using V2Assessment = EdFi.Ods.Api.Models.Resources.V2.Assessment.Assessment;

// TODO: Map
using V3AssessmentAcademicSubject = EdFi.Ods.Api.Models.Resources.V3.Assessment.EdFi.AssessmentAcademicSubject;
using V2AssessmentAcademicSubject = EdFi.Ods.Api.Models.Resources.V2.Assessment.AssessmentAcademicSubject;

using V3AssessmentAssessedGradeLevel = EdFi.Ods.Api.Models.Resources.V3.Assessment.EdFi.AssessmentAssessedGradeLevel;
using V2AssessmentAssessedGradeLevel = EdFi.Ods.Api.Models.Resources.V2.Assessment.AssessmentAssessedGradeLevel;

using V3AssessmentContentStandard = EdFi.Ods.Api.Models.Resources.V3.Assessment.EdFi.AssessmentContentStandard;
using V2AssessmentContentStandard = EdFi.Ods.Api.Models.Resources.V2.Assessment.AssessmentContentStandard;

using V3AssessmentContentStandardAuthor = EdFi.Ods.Api.Models.Resources.V3.Assessment.EdFi.AssessmentContentStandardAuthor;
using V2AssessmentContentStandardAuthor = EdFi.Ods.Api.Models.Resources.V2.Assessment.AssessmentContentStandardAuthor;

using V3AssessmentIdentificationCode = EdFi.Ods.Api.Models.Resources.V3.Assessment.EdFi.AssessmentIdentificationCode;
using V2AssessmentIdentificationCode = EdFi.Ods.Api.Models.Resources.V2.Assessment.AssessmentIdentificationCode;

using V3AssessmentLanguage = EdFi.Ods.Api.Models.Resources.V3.Assessment.EdFi.AssessmentLanguage;
using V2AssessmentLanguage = EdFi.Ods.Api.Models.Resources.V2.Assessment.AssessmentLanguage;

using V3AssessmentPerformanceLevel = EdFi.Ods.Api.Models.Resources.V3.Assessment.EdFi.AssessmentPerformanceLevel;
using V2AssessmentPerformanceLevel = EdFi.Ods.Api.Models.Resources.V2.Assessment.AssessmentPerformanceLevel;

// Not present in v2.5
using V3AssessmentPeriod = EdFi.Ods.Api.Models.Resources.V3.Assessment.EdFi.AssessmentPeriod;
//using V2AssessmentPeriod = EdFi.Ods.Api.Models.Resources.V2.Assessment.AssessmentPeriod; 

using V3ProgramReference = EdFi.Ods.Api.Models.Resources.V3.Program.EdFi.ProgramReference;
using V2ProgramReference = EdFi.Ods.Api.Models.Resources.V2.Program.ProgramReference;

using V3AssessmentProgram = EdFi.Ods.Api.Models.Resources.V3.Assessment.EdFi.AssessmentProgram;
using V2AssessmentProgram = EdFi.Ods.Api.Models.Resources.V2.Assessment.AssessmentProgram;

using V3AssessmentScore = EdFi.Ods.Api.Models.Resources.V3.Assessment.EdFi.AssessmentScore;
using V2AssessmentScore = EdFi.Ods.Api.Models.Resources.V2.Assessment.AssessmentScore;

using V3SectionReference = EdFi.Ods.Api.Models.Resources.V3.Section.EdFi.SectionReference;
using V2SectionReference = EdFi.Ods.Api.Models.Resources.V2.Section.SectionReference;

using V3AssessmentSection = EdFi.Ods.Api.Models.Resources.V3.Assessment.EdFi.AssessmentSection;
using V2AssessmentSection = EdFi.Ods.Api.Models.Resources.V2.Assessment.AssessmentSection;

// ------------------
//   AssessmentItem 
// ------------------
using V3AssessmentItemReference = EdFi.Ods.Api.Models.Resources.V3.AssessmentItem.EdFi.AssessmentItemReference;
using V2AssessmentItemReference = EdFi.Ods.Api.Models.Resources.V2.AssessmentItem.AssessmentItemReference;

using V3AssessmentItem = EdFi.Ods.Api.Models.Resources.V3.AssessmentItem.EdFi.AssessmentItem;
using V2AssessmentItem = EdFi.Ods.Api.Models.Resources.V2.AssessmentItem.AssessmentItem;

using V3AssessmentItemLearningStandard = EdFi.Ods.Api.Models.Resources.V3.AssessmentItem.EdFi.AssessmentItemLearningStandard;
using V2AssessmentItemLearningStandard = EdFi.Ods.Api.Models.Resources.V2.AssessmentItem.AssessmentItemLearningStandard;

// ---------------------
//   LearningObjective 
// ---------------------
using V3LearningObjectiveReference = EdFi.Ods.Api.Models.Resources.V3.LearningObjective.EdFi.LearningObjectiveReference;
using V2LearningObjectiveReference = EdFi.Ods.Api.Models.Resources.V2.LearningObjective.LearningObjectiveReference;

using V3LearningObjective = EdFi.Ods.Api.Models.Resources.V3.LearningObjective.EdFi.LearningObjective;
using V2LearningObjective = EdFi.Ods.Api.Models.Resources.V2.LearningObjective.LearningObjective;

using V3LearningObjectiveAcademicSubject = EdFi.Ods.Api.Models.Resources.V3.LearningObjective.EdFi.LearningObjectiveAcademicSubject;
using V2LearningObjectiveAcademicSubject = EdFi.Ods.Api.Models.Resources.V2.LearningObjective.LearningObjectiveAcademicSubject;

using V3LearningObjectiveContentStandard = EdFi.Ods.Api.Models.Resources.V3.LearningObjective.EdFi.LearningObjectiveContentStandard;
using V2LearningObjectiveContentStandard= EdFi.Ods.Api.Models.Resources.V2.LearningObjective.LearningObjectiveContentStandard;

using V3LearningObjectiveContentStandardAuthor = EdFi.Ods.Api.Models.Resources.V3.LearningObjective.EdFi.LearningObjectiveContentStandardAuthor;
using V2LearningObjectiveContentStandardAuthor = EdFi.Ods.Api.Models.Resources.V2.LearningObjective.LearningObjectiveContentStandardAuthor;

using V3LearningObjectiveGradeLevel = EdFi.Ods.Api.Models.Resources.V3.LearningObjective.EdFi.LearningObjectiveGradeLevel;
using V2LearningObjectiveGradeLevel = EdFi.Ods.Api.Models.Resources.V2.LearningObjective.LearningObjectiveGradeLevel;

using V3LearningObjectiveLearningStandard = EdFi.Ods.Api.Models.Resources.V3.LearningObjective.EdFi.LearningObjectiveLearningStandard;
using V2LearningObjectiveLearningStandard = EdFi.Ods.Api.Models.Resources.V2.LearningObjective.LearningObjectiveLearningStandard;

// ---------------------
//   LearningStandard
// ---------------------
using V3LearningStandard = EdFi.Ods.Api.Models.Resources.V3.LearningStandard.EdFi.LearningStandard;
using V2LearningStandard = EdFi.Ods.Api.Models.Resources.V2.LearningStandard.LearningStandard;

// Not present in v2.5
using V3LearningStandardAcademicSubject = EdFi.Ods.Api.Models.Resources.V3.LearningStandard.EdFi.LearningStandardAcademicSubject;
// using V2LearningStandardAcademicSubject = EdFi.Ods.Api.Models.Resources.V2.LearningStandard.LearningStandardAcademicSubject;

using V3LearningStandardContentStandard = EdFi.Ods.Api.Models.Resources.V3.LearningStandard.EdFi.LearningStandardContentStandard;
using V2LearningStandardContentStandard = EdFi.Ods.Api.Models.Resources.V2.LearningStandard.LearningStandardContentStandard;

using V3LearningStandardContentStandardAuthor = EdFi.Ods.Api.Models.Resources.V3.LearningStandard.EdFi.LearningStandardContentStandardAuthor;
using V2LearningStandardContentStandardAuthor = EdFi.Ods.Api.Models.Resources.V2.LearningStandard.LearningStandardContentStandardAuthor;

using V3LearningStandardGradeLevel = EdFi.Ods.Api.Models.Resources.V3.LearningStandard.EdFi.LearningStandardGradeLevel;
using V2LearningStandardGradeLevel = EdFi.Ods.Api.Models.Resources.V2.LearningStandard.LearningStandardGradeLevel;

using V3LearningStandardIdentificationCode = EdFi.Ods.Api.Models.Resources.V3.LearningStandard.EdFi.LearningStandardIdentificationCode;
using V2LearningStandardIdentificationCode = EdFi.Ods.Api.Models.Resources.V2.LearningStandard.LearningStandardIdentificationCode;

using V3LearningStandardPrerequisiteLearningStandard = EdFi.Ods.Api.Models.Resources.V3.LearningStandard.EdFi.LearningStandardPrerequisiteLearningStandard;
using V2LearningStandardPrerequisiteLearningStandard = EdFi.Ods.Api.Models.Resources.V2.LearningStandard.LearningStandardPrerequisiteLearningStandard;

// -----------------------
//   ObjectiveAssessment
// -----------------------
using V3ObjectiveAssessmentReference = EdFi.Ods.Api.Models.Resources.V3.ObjectiveAssessment.EdFi.ObjectiveAssessmentReference;
using V2ObjectiveAssessmentReference = EdFi.Ods.Api.Models.Resources.V2.ObjectiveAssessment.ObjectiveAssessmentReference;

using V3ObjectiveAssessment = EdFi.Ods.Api.Models.Resources.V3.ObjectiveAssessment.EdFi.ObjectiveAssessment;
using V2ObjectiveAssessment = EdFi.Ods.Api.Models.Resources.V2.ObjectiveAssessment.ObjectiveAssessment;

using V3ObjectiveAssessmentAssessmentItem = EdFi.Ods.Api.Models.Resources.V3.ObjectiveAssessment.EdFi.ObjectiveAssessmentAssessmentItem;
using V2ObjectiveAssessmentAssessmentItem = EdFi.Ods.Api.Models.Resources.V2.ObjectiveAssessment.ObjectiveAssessmentAssessmentItem;

using V3ObjectiveAssessmentLearningObjective = EdFi.Ods.Api.Models.Resources.V3.ObjectiveAssessment.EdFi.ObjectiveAssessmentLearningObjective;
using V2ObjectiveAssessmentLearningObjective = EdFi.Ods.Api.Models.Resources.V2.ObjectiveAssessment.ObjectiveAssessmentLearningObjective;

using V3ObjectiveAssessmentLearningStandard = EdFi.Ods.Api.Models.Resources.V3.ObjectiveAssessment.EdFi.ObjectiveAssessmentLearningStandard;
using V2ObjectiveAssessmentLearningStandard = EdFi.Ods.Api.Models.Resources.V2.ObjectiveAssessment.ObjectiveAssessmentLearningStandard;

using V3ObjectiveAssessmentPerformanceLevel = EdFi.Ods.Api.Models.Resources.V3.ObjectiveAssessment.EdFi.ObjectiveAssessmentPerformanceLevel;
using V2ObjectiveAssessmentPerformanceLevel = EdFi.Ods.Api.Models.Resources.V2.ObjectiveAssessment.ObjectiveAssessmentPerformanceLevel;

using V3ObjectiveAssessmentScore = EdFi.Ods.Api.Models.Resources.V3.ObjectiveAssessment.EdFi.ObjectiveAssessmentScore;
using V2ObjectiveAssessmentScore = EdFi.Ods.Api.Models.Resources.V2.ObjectiveAssessment.ObjectiveAssessmentScore;

// -----------------------
//   StudentAssessment
// -----------------------
using V3StudentAssessmentReference = EdFi.Ods.Api.Models.Resources.V3.StudentAssessment.EdFi.StudentAssessmentReference;
using V2StudentAssessmentReference = EdFi.Ods.Api.Models.Resources.V2.StudentAssessment.StudentAssessmentReference;

using V3StudentAssessment = EdFi.Ods.Api.Models.Resources.V3.StudentAssessment.EdFi.StudentAssessment;
using V2StudentAssessment = EdFi.Ods.Api.Models.Resources.V2.StudentAssessment.StudentAssessment;

using V3StudentAssessmentAccommodation = EdFi.Ods.Api.Models.Resources.V3.StudentAssessment.EdFi.StudentAssessmentAccommodation;
using V2StudentAssessmentAccommodation = EdFi.Ods.Api.Models.Resources.V2.StudentAssessment.StudentAssessmentAccommodation;

using V3StudentAssessmentItem = EdFi.Ods.Api.Models.Resources.V3.StudentAssessment.EdFi.StudentAssessmentItem;
using V2StudentAssessmentItem = EdFi.Ods.Api.Models.Resources.V2.StudentAssessment.StudentAssessmentItem;

using V3StudentAssessmentPerformanceLevel = EdFi.Ods.Api.Models.Resources.V3.StudentAssessment.EdFi.StudentAssessmentPerformanceLevel;
using V2StudentAssessmentPerformanceLevel = EdFi.Ods.Api.Models.Resources.V2.StudentAssessment.StudentAssessmentPerformanceLevel;

using V3StudentAssessmentScoreResult = EdFi.Ods.Api.Models.Resources.V3.StudentAssessment.EdFi.StudentAssessmentScoreResult;
using V2StudentAssessmentScoreResult = EdFi.Ods.Api.Models.Resources.V2.StudentAssessment.StudentAssessmentScoreResult;

using V3StudentAssessmentStudentObjectiveAssessment = EdFi.Ods.Api.Models.Resources.V3.StudentAssessment.EdFi.StudentAssessmentStudentObjectiveAssessment;
using V2StudentAssessmentStudentObjectiveAssessment = EdFi.Ods.Api.Models.Resources.V2.StudentAssessment.StudentAssessmentStudentObjectiveAssessment;

using V3StudentAssessmentStudentObjectiveAssessmentPerformanceLevel = EdFi.Ods.Api.Models.Resources.V3.StudentAssessment.EdFi.StudentAssessmentStudentObjectiveAssessmentPerformanceLevel;
using V2StudentAssessmentStudentObjectiveAssessmentPerformanceLevel = EdFi.Ods.Api.Models.Resources.V2.StudentAssessment.StudentAssessmentStudentObjectiveAssessmentPerformanceLevel;

using V3StudentAssessmentStudentObjectiveAssessmentScoreResult = EdFi.Ods.Api.Models.Resources.V3.StudentAssessment.EdFi.StudentAssessmentStudentObjectiveAssessmentScoreResult;
using V2StudentAssessmentStudentObjectiveAssessmentScoreResult = EdFi.Ods.Api.Models.Resources.V2.StudentAssessment.StudentAssessmentStudentObjectiveAssessmentScoreResult;

// ---------------------------
//    Types and Descriptors
// ---------------------------

using V2AcademicSubjectDescriptor = EdFi.Ods.Api.Models.Resources.V2.AcademicSubjectDescriptor.AcademicSubjectDescriptor;
using V3AcademicSubjectDescriptor = EdFi.Ods.Api.Models.Resources.V3.AcademicSubjectDescriptor.EdFi.AcademicSubjectDescriptor;

using V2AccommodationDescriptor = EdFi.Ods.Api.Models.Resources.V2.AccommodationDescriptor.AccommodationDescriptor;
using V3AccommodationDescriptor = EdFi.Ods.Api.Models.Resources.V3.AccommodationDescriptor.EdFi.AccommodationDescriptor;

using V2AdministrationEnvironmentType = EdFi.Ods.Api.Models.Resources.V2.AdministrationEnvironmentType.AdministrationEnvironmentType;
using V3AdministrationEnvironmentDescriptor = EdFi.Ods.Api.Models.Resources.V3.AdministrationEnvironmentDescriptor.EdFi.AdministrationEnvironmentDescriptor;

using V2AssessmentCategoryDescriptor = EdFi.Ods.Api.Models.Resources.V2.AssessmentCategoryDescriptor.AssessmentCategoryDescriptor;
using V3AssessmentCategoryDescriptor = EdFi.Ods.Api.Models.Resources.V3.AssessmentCategoryDescriptor.EdFi.AssessmentCategoryDescriptor;

using V2AssessmentIdentificationSystemDescriptor = EdFi.Ods.Api.Models.Resources.V2.AssessmentIdentificationSystemDescriptor.AssessmentIdentificationSystemDescriptor;
using V3AssessmentIdentificationSystemDescriptor = EdFi.Ods.Api.Models.Resources.V3.AssessmentIdentificationSystemDescriptor.EdFi.AssessmentIdentificationSystemDescriptor;

using V2AssessmentItemCategoryType = EdFi.Ods.Api.Models.Resources.V2.AssessmentItemCategoryType.AssessmentItemCategoryType;
using V3AssessmentItemCategoryDescriptor = EdFi.Ods.Api.Models.Resources.V3.AssessmentItemCategoryDescriptor.EdFi.AssessmentItemCategoryDescriptor;

using V2AssessmentItemResultType = EdFi.Ods.Api.Models.Resources.V2.AssessmentItemResultType.AssessmentItemResultType;
using V3AssessmentItemResultDescriptor = EdFi.Ods.Api.Models.Resources.V3.AssessmentItemResultDescriptor.EdFi.AssessmentItemResultDescriptor;

using V2AssessmentPeriodDescriptor = EdFi.Ods.Api.Models.Resources.V2.AssessmentPeriodDescriptor.AssessmentPeriodDescriptor;
using V3AssessmentPeriodDescriptor = EdFi.Ods.Api.Models.Resources.V3.AssessmentPeriodDescriptor.EdFi.AssessmentPeriodDescriptor;

using V2AssessmentReportingMethodType = EdFi.Ods.Api.Models.Resources.V2.AssessmentReportingMethodType.AssessmentReportingMethodType;
using V3AssessmentReportingMethodDescriptor = EdFi.Ods.Api.Models.Resources.V3.AssessmentReportingMethodDescriptor.EdFi.AssessmentReportingMethodDescriptor;

using V2EventCircumstanceType = EdFi.Ods.Api.Models.Resources.V2.EventCircumstanceType.EventCircumstanceType;
using V3EventCircumstanceDescriptor = EdFi.Ods.Api.Models.Resources.V3.EventCircumstanceDescriptor.EdFi.EventCircumstanceDescriptor;

using V2GradeLevelDescriptor = EdFi.Ods.Api.Models.Resources.V2.GradeLevelDescriptor.GradeLevelDescriptor;
using V3GradeLevelDescriptor = EdFi.Ods.Api.Models.Resources.V3.GradeLevelDescriptor.EdFi.GradeLevelDescriptor;

using V2LanguageDescriptor = EdFi.Ods.Api.Models.Resources.V2.LanguageDescriptor.LanguageDescriptor;
using V3LanguageDescriptor = EdFi.Ods.Api.Models.Resources.V3.LanguageDescriptor.EdFi.LanguageDescriptor;

using V2PerformanceLevelDescriptor = EdFi.Ods.Api.Models.Resources.V2.PerformanceLevelDescriptor.PerformanceLevelDescriptor;
using V3PerformanceLevelDescriptor = EdFi.Ods.Api.Models.Resources.V3.PerformanceLevelDescriptor.EdFi.PerformanceLevelDescriptor;

using V2PublicationStatusType = EdFi.Ods.Api.Models.Resources.V2.PublicationStatusType.PublicationStatusType;
using V3PublicationStatusDescriptor = EdFi.Ods.Api.Models.Resources.V3.PublicationStatusDescriptor.EdFi.PublicationStatusDescriptor;

using V2ProgramType = EdFi.Ods.Api.Models.Resources.V2.ProgramType.ProgramType;
using V3ProgramTypeDescriptor = EdFi.Ods.Api.Models.Resources.V3.ProgramTypeDescriptor.EdFi.ProgramTypeDescriptor;

using V2ReasonNotTestedType = EdFi.Ods.Api.Models.Resources.V2.ReasonNotTestedType.ReasonNotTestedType;
using V3ReasonNotTestedDescriptor = EdFi.Ods.Api.Models.Resources.V3.ReasonNotTestedDescriptor.EdFi.ReasonNotTestedDescriptor;

using V2ResponseIndicatorType = EdFi.Ods.Api.Models.Resources.V2.ResponseIndicatorType.ResponseIndicatorType;
using V3ResponseIndicatorDescriptor = EdFi.Ods.Api.Models.Resources.V3.ResponseIndicatorDescriptor.EdFi.ResponseIndicatorDescriptor;

using V2ResultDatatypeType = EdFi.Ods.Api.Models.Resources.V2.ResultDatatypeType.ResultDatatypeType;
using V3ResultDatatypeTypeDescriptor = EdFi.Ods.Api.Models.Resources.V3.ResultDatatypeTypeDescriptor.EdFi.ResultDatatypeTypeDescriptor;

using V2RetestIndicatorType = EdFi.Ods.Api.Models.Resources.V2.RetestIndicatorType.RetestIndicatorType;
using V3RetestIndicatorDescriptor = EdFi.Ods.Api.Models.Resources.V3.RetestIndicatorDescriptor.EdFi.RetestIndicatorDescriptor;

using V2TermDescriptor = EdFi.Ods.Api.Models.Resources.V2.TermDescriptor.TermDescriptor;
using V3TermDescriptor = EdFi.Ods.Api.Models.Resources.V3.TermDescriptor.EdFi.TermDescriptor;

// ---------------------
//  Session
// ---------------------
using V3Session = EdFi.Ods.Api.Models.Resources.V3.Session.EdFi.Session;
using V2Session = EdFi.Ods.Api.Models.Resources.V2.Session.Session;

using V3SessionAcademicWeek = EdFi.Ods.Api.Models.Resources.V3.Session.EdFi.SessionAcademicWeek;
using V2SessionAcademicWeek = EdFi.Ods.Api.Models.Resources.V2.Session.SessionAcademicWeek;

using V3SessionGradingPeriod = EdFi.Ods.Api.Models.Resources.V3.Session.EdFi.SessionGradingPeriod;
using V2SessionGradingPeriod = EdFi.Ods.Api.Models.Resources.V2.Session.SessionGradingPeriod;

using V3SessionGradingPeriodToGradingPeriodReference = EdFi.Ods.Api.Models.Resources.V3.Session.EdFi.SessionGradingPeriodToGradingPeriodReference;
using V2SessionGradingPeriodToGradingPeriodReference = EdFi.Ods.Api.Models.Resources.V2.Session.SessionGradingPeriodToGradingPeriodReference;

#region Unsupported referenced resources

//// ---------------------
////  Section
//// ---------------------
//using V3Section = EdFi.Ods.Api.Models.Resources.V3.Section.EdFi.Section;
//using V2Section = EdFi.Ods.Api.Models.Resources.V2.Section.Section;

//using V3SectionCharacteristic = EdFi.Ods.Api.Models.Resources.V3.Section.EdFi.SectionCharacteristic;
//using V2SectionCharacteristic = EdFi.Ods.Api.Models.Resources.V2.Section.SectionCharacteristic;

//using V3SectionClassPeriod = EdFi.Ods.Api.Models.Resources.V3.Section.EdFi.SectionClassPeriod;
////using V2SectionClassPeriod = EdFi.Ods.Api.Models.Resources.V2.Section.SectionClassPeriod;

//using V3SectionCourseLevelCharacteristic = EdFi.Ods.Api.Models.Resources.V3.Section.EdFi.SectionCourseLevelCharacteristic;
////using V2SectionCourseLevelCharacteristic = EdFi.Ods.Api.Models.Resources.V2.Section.SectionCourseLevelCharacteristic;

//using V3SectionOfferedGradeLevel = EdFi.Ods.Api.Models.Resources.V3.Section.EdFi.SectionOfferedGradeLevel;
////using V2SectionOfferedGradeLevel = EdFi.Ods.Api.Models.Resources.V2.Section.SectionOfferedGradeLevel;

//using V3SectionProgram = EdFi.Ods.Api.Models.Resources.V3.Section.EdFi.SectionProgram;
//using V2SectionProgram = EdFi.Ods.Api.Models.Resources.V2.Section.SectionProgram;

//// ----------------------------
////  Programs
//// ----------------------------
//using V3Program = EdFi.Ods.Api.Models.Resources.V3.Program.EdFi.Program;
//using V2Program = EdFi.Ods.Api.Models.Resources.V2.Program.Program;

//using V3ProgramCharacteristic = EdFi.Ods.Api.Models.Resources.V3.Program.EdFi.ProgramCharacteristic;
//using V2ProgramCharacteristic = EdFi.Ods.Api.Models.Resources.V2.Program.ProgramCharacteristic;

//using V3ProgramLearningObjective = EdFi.Ods.Api.Models.Resources.V3.Program.EdFi.ProgramLearningObjective;
//using V2ProgramLearningObjective = EdFi.Ods.Api.Models.Resources.V2.Program.ProgramLearningObjective;

//using V3ProgramLearningStandard = EdFi.Ods.Api.Models.Resources.V3.Program.EdFi.ProgramLearningStandard;
//using V2ProgramLearningStandard = EdFi.Ods.Api.Models.Resources.V2.Program.ProgramLearningStandard;

//using V3ProgramService = EdFi.Ods.Api.Models.Resources.V3.Program.EdFi.ProgramService;
//using V2ProgramService = EdFi.Ods.Api.Models.Resources.V2.Program.ProgramService;

//using V3ProgramSponsor = EdFi.Ods.Api.Models.Resources.V3.Program.EdFi.ProgramSponsor;
////using V2ProgramSponsor = EdFi.Ods.Api.Models.Resources.V2.Program.ProgramSponsor;

//// ----------------------
//// EducationOrganization
//// ----------------------
//using V3EducationOrganizationAddress = EdFi.Ods.Api.Models.Resources.V3.EducationOrganization.EdFi.EducationOrganizationAddress;
//using V2EducationOrganizationAddress = EdFi.Ods.Api.Models.Resources.V2.EducationOrganization.EducationOrganizationAddress;

//using V3EducationOrganizationAddressPeriod = EdFi.Ods.Api.Models.Resources.V3.EducationOrganization.EdFi.EducationOrganizationAddressPeriod;
////using V2EducationOrganizationAddressPeriod = EdFi.Ods.Api.Models.Resources.V2.EducationOrganization.EducationOrganizationAddressPeriod;

//using V3EducationOrganizationCategory = EdFi.Ods.Api.Models.Resources.V3.EducationOrganization.EdFi.EducationOrganizationCategory;
//using V2EducationOrganizationCategory = EdFi.Ods.Api.Models.Resources.V2.EducationOrganization.EducationOrganizationCategory;

//using V3EducationOrganizationIdentificationCode = EdFi.Ods.Api.Models.Resources.V3.EducationOrganization.EdFi.EducationOrganizationIdentificationCode;
//using V2EducationOrganizationIdentificationCode = EdFi.Ods.Api.Models.Resources.V2.EducationOrganization.EducationOrganizationIdentificationCode;

//using V3EducationOrganizationInstitutionTelephone = EdFi.Ods.Api.Models.Resources.V3.EducationOrganization.EdFi.EducationOrganizationInstitutionTelephone;
//using V2EducationOrganizationInstitutionTelephone = EdFi.Ods.Api.Models.Resources.V2.EducationOrganization.EducationOrganizationInstitutionTelephone;

//using V3EducationOrganizationInternationalAddress = EdFi.Ods.Api.Models.Resources.V3.EducationOrganization.EdFi.EducationOrganizationInternationalAddress;
//using V2EducationOrganizationInternationalAddress = EdFi.Ods.Api.Models.Resources.V2.EducationOrganization.EducationOrganizationInternationalAddress;

//// ---------------
//// School
//// ---------------
//using V3School = EdFi.Ods.Api.Models.Resources.V3.School.EdFi.School;
//using V2School = EdFi.Ods.Api.Models.Resources.V2.School.School;

//using V3SchoolCategory = EdFi.Ods.Api.Models.Resources.V3.School.EdFi.SchoolCategory;
//using V2SchoolCategory = EdFi.Ods.Api.Models.Resources.V2.School.SchoolCategory;

//using V3SchoolGradeLevel = EdFi.Ods.Api.Models.Resources.V3.School.EdFi.SchoolGradeLevel;
//using V2SchoolGradeLevel = EdFi.Ods.Api.Models.Resources.V2.School.SchoolGradeLevel;

//// ---------------------
//// LocalEducationAgency
//// ---------------------
//using V3LocalEducationAgency = EdFi.Ods.Api.Models.Resources.V3.LocalEducationAgency.EdFi.LocalEducationAgency;
//using V2LocalEducationAgency = EdFi.Ods.Api.Models.Resources.V2.LocalEducationAgency.LocalEducationAgency;

//using V3LocalEducationAgencyAccountability = EdFi.Ods.Api.Models.Resources.V3.LocalEducationAgency.EdFi.LocalEducationAgencyAccountability;
//using V2LocalEducationAgencyAccountability = EdFi.Ods.Api.Models.Resources.V2.LocalEducationAgency.LocalEducationAgencyAccountability;

////using V3LocalEducationAgencyFederalFunds = EdFi.Ods.Api.Models.Resources.V3.LocalEducationAgency.EdFi.LocalEducationAgencyFederalFunds;
////using V2LocalEducationAgencyFederalFunds = EdFi.Ods.Api.Models.Resources.V2.LocalEducationAgency.LocalEducationAgencyFederalFunds;

#endregion

#endregion

namespace EdFi.Ods.AssessmentBridge.WebApi.Mapping
{
    public class MappingFactory
    {
        public static IMapper CreateMapper()
        {
            // Validate mappings
            try
            {
                ValidateMappings(
                    CreateAssessmentMap,
                    CreateAssessmentItemMap,
                    CreateLearningObjectiveMap,
                    CreateLearningStandardMap,
                    CreateObjectiveAssessmentMap,
                    CreateStudentAssessmentMap,
                    CreateDescriptorMaps,
                    CreateTypeMaps,
                    CreateSessionMaps

                    // Possible future mappings to be supported
                    //CreateSectionMaps,
                    //CreateProgramMaps,
                    //CreateEducationOrganizationMaps,
                    //CreateSchoolMaps,
                    //CreateLocalEducationAgencyMaps
                );
            }
            catch (AggregateException ex)
            {
                var validationMessages = 
                    string.Join(
                        Environment.NewLine, 
                        ex.Flatten().InnerExceptions.Select(x => x.Message));

                Console.WriteLine(validationMessages);

                throw new Exception($"Validation of mappings between v2.5 and v3.4 failed:{Environment.NewLine}{validationMessages}");
            }

            var typedConfig = new MapperConfiguration(cfg =>
            {
                // NOTE: This logic allows AutoMapper to match types to descriptors, and vice-versa, but it does not appear to factor
                // this in to the mapping validation, which is why it has been removed -- and these types have been mapped explicitly
                // to ensure correct conversion.
                //cfg.AddMemberConfiguration()
                //    .AddMember<NameSplitMember>()
                //    .AddName<PrePostfixName>(name => name
                //        .AddStrings(p => p.Postfixes, "Descriptor", "Type")
                //        .AddStrings(p => p.DestinationPostfixes, "Type", "Descriptor"));

                // Don't map Extensions
                //cfg.ShouldMapProperty = p =>
                //    p.GetMethod?.IsPublic == true
                //    && p.Name != "Extensions";

                CreateAssessmentMap(cfg);
                CreateAssessmentItemMap(cfg);
                CreateLearningObjectiveMap(cfg);
                CreateLearningStandardMap(cfg);
                CreateObjectiveAssessmentMap(cfg);
                CreateStudentAssessmentMap(cfg);
                CreateDescriptorMaps(cfg);
                CreateTypeMaps(cfg);
                CreateSessionMaps(cfg);

                // Possible future mappings to be supported
                //CreateSectionMaps(cfg);
                //CreateProgramMaps(cfg);
                //CreateEducationOrganizationMaps(cfg);
                //CreateSchoolMaps(cfg);
                //CreateLocalEducationAgencyMaps(cfg);
            });

            return typedConfig.CreateMapper();
        }

        private static void ValidateMappings(params Action<IMapperConfigurationExpression, MemberList>[] mappings)
        {
            var allExceptions = mappings.SelectMany(mapping =>
            {
                var exceptions = new List<Exception>();

                //foreach (var memberList in new [] {MemberList.Destination, MemberList.Source})
                foreach (var memberList in new[] { MemberList.Destination })
                {
                    var typedConfig = new MapperConfiguration(cfg => { mapping(cfg, memberList); });

                    try
                    {
                        typedConfig.AssertConfigurationIsValid();
                    }
                    catch (Exception ex)
                    {
                        exceptions.Add(ex);
                    }
                }

                return exceptions;
            });

            if (allExceptions.Any())
                throw new AggregateException(allExceptions);
        }

        private static void CreateAssessmentMap(IMapperConfigurationExpression cfg, MemberList memberListForValidation = MemberList.Destination)
        {
            // =============================
            // Mapping: AssessmentReference 
            // =============================
            cfg.CreateMap<V2AssessmentReference, V3AssessmentReference>(memberListForValidation)
                // ================
                // V2 to v3 mapping
                // ================
                // Convert non-descriptor Namespace property to idiomatic V3 namespace URI
                .ForMember(v3 => v3.Namespace, o => o.MapFrom(v2 => VersionConverter.ResourceNamespacePropertyV2ToV3(v2.Namespace)))

                // ---------------
                // Ignored members
                // ---------------

                // ----------------------------
                // V2 Types to V3 Descriptors
                // ----------------------------

                // --------------------------------
                // V2 Descriptors to V3 Descriptors
                // --------------------------------

                ;

            cfg.CreateMap<V3AssessmentReference, V2AssessmentReference>(memberListForValidation)
                // ================
                // V3 to V2 mapping
                // ================
                // Convert non-descriptor Namespace property to idiomatic V2 namespace URI
                .ForMember(v2 => v2.Namespace, o => o.MapFrom(v3 => VersionConverter.ResourceNamespacePropertyV3ToV2(v3.Namespace)))

                // ---------------
                // Ignored members
                // ---------------
                
                // --------------------------
                // V3 Descriptors to V2 Types
                // --------------------------

                // --------------------------------
                // V3 Descriptors to V2 Descriptors
                // --------------------------------
                ;

            // =============================
            // Mapping: Assessment
            // =============================
            cfg.CreateMap<V2Assessment, V3Assessment>(memberListForValidation)
                // ================
                // V2 to v3 mapping
                // ================
                // AssessmentFamily entity removed in V3, replaced with optional AssessmentFamily column (nvarchar) which we can obtain from reference (if present)
                .ForMember(v3 => v3.AssessmentFamily, o => o.MapFrom((v2, v3) => v2.AssessmentFamilyReference?.AssessmentFamilyTitle))

                // Renamed Version in V2 to AssessmentVersion in V3
                .ForMember(v3 => v3.AssessmentVersion, o => o.MapFrom(v2 => v2.Version))

                // Converted v2.5 AssessmentPeriodDescriptor into a one-to-one AssessmentPeriod entity in v3.1 (with nullable Begin/End dates)
                .ForMember(v3 => v3.AssessmentPeriod, o => o.MapFrom(v2 => GetV3AssessmentPeriod(v2)))

                // Convert non-descriptor Namespace property to idiomatic V3 namespace URI
                .ForMember(v3 => v3.Namespace, o => o.MapFrom(v2 => VersionConverter.ResourceNamespacePropertyV2ToV3(v2.Namespace)))
                // ---------------
                // Ignored members
                // ---------------
                .ForMember(v3 => v3.Extensions, o => o.Ignore())
                .ForMember(v3 => v3.AssessmentPlatformTypes, o => o.Ignore())

                // ----------------------------
                // V2 Types to V3 Descriptors
                // ----------------------------

                // --------------------------------
                // V2 Descriptors to V3 Descriptors
                // --------------------------------
                .ForMember(
                    v3 => v3.AssessmentCategoryDescriptor,
                    o => o.MapFrom(v2 => VersionConverter.DescriptorV2ToV3("AssessmentCategoryDescriptor", v2.AssessmentCategoryDescriptor)))
                ;

            cfg.CreateMap<V3Assessment, V2Assessment>(memberListForValidation)
                // ================
                // V3 to V2 mapping
                // ================

                // AssessmentFamily entity/reference removed in V3 -- Replaced with optional AssessmentFamily (nvarchar) on Assessment
                // NOTE: This is a bit of a dubious mapping - essentially it supports a v2.5 AssessmentFamilyReference to an unsupported entity in v3.1
                .ForMember(
                    v2 => v2.AssessmentFamilyReference, 
                    o => o.MapFrom(v3 => 
                        v3.AssessmentFamily == null 
                            ? null 
                            : new AssessmentFamilyReference { AssessmentFamilyTitle = v3.AssessmentFamily }))

                // Renamed from Version in v2.5 to AssessmentVersion in v3.1
                .ForMember(v2 => v2.Version, o => o.MapFrom(v3 => v3.AssessmentVersion))

                // Converted v2.5 AssessmentPeriodDescriptor into a one-to-one AssessmentPeriod entity in v3.1 (with nullable Begin/End dates)
                .ForMember(v2 => v2.AssessmentPeriodDescriptor, o => o.MapFrom(v3 => GetV2AssessmentPeriodDescriptor(v3)))

                // Convert non-descriptor Namespace property to idiomatic V2 namespace URI
                .ForMember(v2 => v2.Namespace, o => o.MapFrom(v3 => VersionConverter.ResourceNamespacePropertyV3ToV2(v3.Namespace)))

                // ---------------
                // Ignored members
                // ---------------

                // --------------------------
                // V3 Descriptors to V2 Types
                // --------------------------

                // --------------------------------
                // V3 Descriptors to V2 Descriptors
                // --------------------------------
                .ForMember(
                    v2 => v2.AssessmentCategoryDescriptor,
                    o => o.MapFrom(v3 => VersionConverter.DescriptorV3ToV2("AssessmentCategoryDescriptor", v3.AssessmentCategoryDescriptor)))
                ;

            // ==========================================
            // Mapping: AssessmentAcademicSubject
            // ==========================================
            cfg.CreateMap<V2AssessmentAcademicSubject, V3AssessmentAcademicSubject>(memberListForValidation)
                // ================
                // V2 to v3 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------
                .ForMember(x => x.Extensions, o => o.Ignore())

                // ----------------------------
                // V2 Types to V3 Descriptors
                // ----------------------------

                // --------------------------------
                // V2 Descriptors to V3 Descriptors
                // --------------------------------
                .ForMember(
                    v3 => v3.AcademicSubjectDescriptor,
                    o => o.MapFrom(v2 => VersionConverter.DescriptorV2ToV3("AcademicSubjectDescriptor", v2.AcademicSubjectDescriptor)))
                ;

            cfg.CreateMap<V3AssessmentAcademicSubject, V2AssessmentAcademicSubject>(memberListForValidation)
                // ================
                // V3 to V2 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------

                // --------------------------
                // V3 Descriptors to V2 Types
                // --------------------------

                // --------------------------------
                // V3 Descriptors to V2 Descriptors
                // --------------------------------
                .ForMember(
                    v2 => v2.AcademicSubjectDescriptor,
                    o => o.MapFrom(v3 => VersionConverter.DescriptorV3ToV2("AcademicSubjectDescriptor", v3.AcademicSubjectDescriptor)))
                ;

            // ==========================================
            // Mapping: AssessmentAssessedGradeLevel
            // ==========================================
            cfg.CreateMap<V2AssessmentAssessedGradeLevel, V3AssessmentAssessedGradeLevel>(memberListForValidation)
                // ================
                // V2 to v3 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------
                .ForMember(x => x.Extensions, o => o.Ignore())

                // ----------------------------
                // V2 Types to V3 Descriptors
                // ----------------------------

                // --------------------------------
                // V2 Descriptors to V3 Descriptors
                // --------------------------------
                .ForMember(
                    v3 => v3.GradeLevelDescriptor,
                    o => o.MapFrom(v2 => VersionConverter.DescriptorV2ToV3("GradeLevelDescriptor", v2.GradeLevelDescriptor)))
                ;

            cfg.CreateMap<V3AssessmentAssessedGradeLevel, V2AssessmentAssessedGradeLevel>(memberListForValidation)
                // ================
                // V3 to V2 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------

                // --------------------------
                // V3 Descriptors to V2 Types
                // --------------------------

                // --------------------------------
                // V3 Descriptors to V2 Descriptors
                // --------------------------------
                .ForMember(
                    v2 => v2.GradeLevelDescriptor,
                    o => o.MapFrom(v3 => VersionConverter.DescriptorV3ToV2("GradeLevelDescriptor", v3.GradeLevelDescriptor)))
                ;

            // ====================================
            // Mapping: AssessmentContentStandard
            // ====================================
            cfg.CreateMap<V2AssessmentContentStandard, V3AssessmentContentStandard>(memberListForValidation)
                // ================
                // V2 to v3 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------
                .ForMember(x => x.Extensions, o => o.Ignore())

                // ----------------------------
                // V2 Types to V3 Descriptors
                // ----------------------------
                .ForMember(
                    v3 => v3.PublicationStatusDescriptor,
                    o => o.MapFrom(v2 => VersionConverter.TypeToDescriptor(v2.PublicationStatusType, "PublicationStatusDescriptor")))

                // --------------------------------
                // V2 Descriptors to V3 Descriptors
                // --------------------------------
                ;

            cfg.CreateMap<V3AssessmentContentStandard, V2AssessmentContentStandard>(memberListForValidation)
                // ================
                // V3 to V2 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------

                // --------------------------
                // V3 Descriptors to V2 Types
                // --------------------------
                .ForMember(
                    v2 => v2.PublicationStatusType, 
                    o => o.MapFrom(v3 => VersionConverter.DescriptorToType(v3.PublicationStatusDescriptor)))

                // --------------------------------
                // V3 Descriptors to V2 Descriptors
                // --------------------------------
                ;

            // ==========================================
            // Mapping: AssessmentContentStandardAuthor
            // ==========================================
            cfg.CreateMap<V2AssessmentContentStandardAuthor, V3AssessmentContentStandardAuthor>(memberListForValidation)
                // ================
                // V2 to v3 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------
                .ForMember(x => x.Extensions, o => o.Ignore())

                // ----------------------------
                // V2 Types to V3 Descriptors
                // ----------------------------

                // --------------------------------
                // V2 Descriptors to V3 Descriptors
                // --------------------------------
                ;

            cfg.CreateMap<V3AssessmentContentStandardAuthor, V2AssessmentContentStandardAuthor>(memberListForValidation)
                // ================
                // V3 to V2 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------

                // --------------------------
                // V3 Descriptors to V2 Types
                // --------------------------

                // --------------------------------
                // V3 Descriptors to V2 Descriptors
                // --------------------------------
                ;

            // ==========================================
            // Mapping: AssessmentIdentificationCode
            // ==========================================
            cfg.CreateMap<V2AssessmentIdentificationCode, V3AssessmentIdentificationCode>(memberListForValidation)
                // ================
                // V2 to v3 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------
                .ForMember(x => x.Extensions, o => o.Ignore())

                // ----------------------------
                // V2 Types to V3 Descriptors
                // ----------------------------

                // --------------------------------
                // V2 Descriptors to V3 Descriptors
                // --------------------------------
                .ForMember(
                    v3 => v3.AssessmentIdentificationSystemDescriptor,
                    o => o.MapFrom(v2 => VersionConverter.DescriptorV2ToV3("AssessmentIdentificationSystemDescriptor", v2.AssessmentIdentificationSystemDescriptor)))
                ;

            cfg.CreateMap<V3AssessmentIdentificationCode, V2AssessmentIdentificationCode>(memberListForValidation)
                // ================
                // V3 to V2 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------

                // --------------------------
                // V3 Descriptors to V2 Types
                // --------------------------

                // --------------------------------
                // V3 Descriptors to V2 Descriptors
                // --------------------------------
                .ForMember(
                    v2 => v2.AssessmentIdentificationSystemDescriptor,
                    o => o.MapFrom(v3 => VersionConverter.DescriptorV3ToV2("AssessmentIdentificationSystemDescriptor", v3.AssessmentIdentificationSystemDescriptor)))
                ;

            // ==========================================
            // Mapping: AssessmentLanguage
            // ==========================================
            cfg.CreateMap<V2AssessmentLanguage, V3AssessmentLanguage>(memberListForValidation)
                // ================
                // V2 to v3 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------
                .ForMember(x => x.Extensions, o => o.Ignore())

                // --------------------------------
                // V2 Descriptors to V3 Descriptors
                // --------------------------------
                .ForMember(
                    v3 => v3.LanguageDescriptor,
                    o => o.MapFrom(v2 => VersionConverter.DescriptorV2ToV3("LanguageDescriptor", v2.LanguageDescriptor)))
                ;

            cfg.CreateMap<V3AssessmentLanguage, V2AssessmentLanguage>(memberListForValidation)
                // ================
                // V3 to V2 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------

                // --------------------------
                // V3 Descriptors to V2 Types
                // --------------------------

                // --------------------------------
                // V3 Descriptors to V2 Descriptors
                // --------------------------------
                .ForMember(
                    v2 => v2.LanguageDescriptor,
                    o => o.MapFrom(v3 => VersionConverter.DescriptorV3ToV2("LanguageDescriptor", v3.LanguageDescriptor)))
                ;

            // ==========================================
            // Mapping: AssessmentPerformanceLevel
            // ==========================================
            cfg.CreateMap<V2AssessmentPerformanceLevel, V3AssessmentPerformanceLevel>(memberListForValidation)
                // ================
                // V2 to v3 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------
                .ForMember(x => x.Extensions, o => o.Ignore())

                // ----------------------------
                // V2 Types to V3 Descriptors
                // ----------------------------
                .ForMember(
                    v3 => v3.ResultDatatypeTypeDescriptor,
                    o => o.MapFrom(v2 => VersionConverter.TypeToDescriptor(v2.ResultDatatypeType, "ResultDatatypeTypeDescriptor")))

                .ForMember(
                    v3 => v3.AssessmentReportingMethodDescriptor,
                    o => o.MapFrom(v2 => VersionConverter.TypeToDescriptor(v2.AssessmentReportingMethodType, "AssessmentReportingMethodDescriptor")))

                // --------------------------------
                // V2 Descriptors to V3 Descriptors
                // --------------------------------
                .ForMember(
                    v3 => v3.PerformanceLevelDescriptor,
                    o => o.MapFrom(v2 => VersionConverter.DescriptorV2ToV3("PerformanceLevelDescriptor", v2.PerformanceLevelDescriptor)))
                ;

            cfg.CreateMap<V3AssessmentPerformanceLevel, V2AssessmentPerformanceLevel>(memberListForValidation)
                // ================
                // V3 to V2 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------

                // --------------------------
                // V3 Descriptors to V2 Types
                // --------------------------
                .ForMember(
                    v2 => v2.ResultDatatypeType,
                    o => o.MapFrom(v3 => VersionConverter.DescriptorToType(v3.ResultDatatypeTypeDescriptor)))

                .ForMember(
                    v2 => v2.AssessmentReportingMethodType,
                    o => o.MapFrom(v3 => VersionConverter.DescriptorToType(v3.AssessmentReportingMethodDescriptor)))

                // --------------------------------
                // V3 Descriptors to V2 Descriptors
                // --------------------------------
                .ForMember(
                    v2 => v2.PerformanceLevelDescriptor,
                    o => o.MapFrom(v3 => VersionConverter.DescriptorV3ToV2("PerformanceLevelDescriptor", v3.PerformanceLevelDescriptor)))
                ;

            // ======================================================
            // Mapping: ProgramReference (used by AssessmentProgram)
            // ======================================================
            cfg.CreateMap<V2ProgramReference, V3ProgramReference>(memberListForValidation)
                // ================
                // V2 to v3 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------
                .ForMember(x => x.ProgramTypeDescriptor, o => o.Ignore())

                // ----------------------------
                // V2 Types to V3 Descriptors
                // ----------------------------
                .ForMember(
                    v3 => v3.ProgramTypeDescriptor,
                    o => o.MapFrom(v2 => VersionConverter.TypeToDescriptor(v2.ProgramType, "ProgramTypeDescriptor")))

                // --------------------------------
                // V2 Descriptors to V3 Descriptors
                // --------------------------------
                ;

            cfg.CreateMap<V3ProgramReference, V2ProgramReference>(memberListForValidation)
                // ================
                // V3 to V2 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------

                // --------------------------
                // V3 Descriptors to V2 Types
                // --------------------------
                .ForMember(
                    v2 => v2.ProgramType,
                    o => o.MapFrom(v3 => VersionConverter.DescriptorToType(v3.ProgramTypeDescriptor)))

                // --------------------------------
                // V3 Descriptors to V2 Descriptors
                // --------------------------------
                ;

            // ==========================================
            // Mapping: AssessmentProgram
            // ==========================================
            cfg.CreateMap<V2AssessmentProgram, V3AssessmentProgram>(memberListForValidation)
                // ================
                // V2 to v3 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------
                .ForMember(x => x.Extensions, o => o.Ignore())

                // ----------------------------
                // V2 Types to V3 Descriptors
                // ----------------------------

                // --------------------------------
                // V2 Descriptors to V3 Descriptors
                // --------------------------------
                ;

            cfg.CreateMap<V3AssessmentProgram, V2AssessmentProgram>(memberListForValidation)
                // ================
                // V3 to V2 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------

                // --------------------------
                // V3 Descriptors to V2 Types
                // --------------------------

                // --------------------------------
                // V3 Descriptors to V2 Descriptors
                // --------------------------------
                ;

            // ==========================================
            // Mapping: AssessmentScore
            // ==========================================
            cfg.CreateMap<V2AssessmentScore, V3AssessmentScore>(memberListForValidation)
                // ================
                // V2 to v3 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------
                .ForMember(x => x.Extensions, o => o.Ignore())

                // ----------------------------
                // V2 Types to V3 Descriptors
                // ----------------------------
                .ForMember(
                    v3 => v3.ResultDatatypeTypeDescriptor,
                    o => o.MapFrom(v2 => VersionConverter.TypeToDescriptor(v2.ResultDatatypeType, "ResultDatatypeTypeDescriptor")))

                .ForMember(
                    v3 => v3.AssessmentReportingMethodDescriptor,
                    o => o.MapFrom(v2 => VersionConverter.TypeToDescriptor(v2.AssessmentReportingMethodType, "AssessmentReportingMethodDescriptor")))

                // --------------------------------
                // V2 Descriptors to V3 Descriptors
                // --------------------------------
                ;

            cfg.CreateMap<V3AssessmentScore, V2AssessmentScore>(memberListForValidation)
                // ================
                // V3 to V2 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------

                // --------------------------
                // V3 Descriptors to V2 Types
                // --------------------------
                .ForMember(
                    v2 => v2.ResultDatatypeType,
                    o => o.MapFrom(v3 => VersionConverter.DescriptorToType(v3.ResultDatatypeTypeDescriptor)))

                .ForMember(
                    v2 => v2.AssessmentReportingMethodType,
                    o => o.MapFrom(v3 => VersionConverter.DescriptorToType(v3.AssessmentReportingMethodDescriptor)))

                // --------------------------------
                // V3 Descriptors to V2 Descriptors
                // --------------------------------
                ;

            // ======================================================
            // Mapping: SectionReference (used by AssessmentSection)
            // ======================================================
            cfg.CreateMap<V2SectionReference, V3SectionReference>(memberListForValidation)
                // ================
                // V2 to v3 mapping
                // ================

                // V2 Source: Hash(ClassPeriodName, ClassroomIdentificationCode, UniqueSectionCode)
                // or UniqueSectionCode
                .ForMember(v3 => v3.SectionIdentifier, o => o.MapFrom(v2 => v2.UniqueSectionCode))

                // V2 Source: Session.SessionName
                .ForMember(v3 => v3.SessionName, o => o.MapFrom<V3SessionNameResolver>())

                // ---------------
                // Ignored members
                // ---------------

                // ----------------------------
                // V2 Types to V3 Descriptors
                // ----------------------------

                // --------------------------------
                // V2 Descriptors to V3 Descriptors
                // --------------------------------
                ;

            // V3 to V2 mapping
            cfg.CreateMap<V3SectionReference, V2SectionReference>(memberListForValidation)
                .ConvertUsing<V3ToV2SectionReferenceConverter>();

            // ==========================================
            // Mapping: AssessmentSection
            // ==========================================
            cfg.CreateMap<V2AssessmentSection, V3AssessmentSection>(memberListForValidation)
                // ================
                // V2 to v3 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------
                .ForMember(x => x.Extensions, o => o.Ignore())

                // ----------------------------
                // V2 Types to V3 Descriptors
                // ----------------------------

                // --------------------------------
                // V2 Descriptors to V3 Descriptors
                // --------------------------------
                ;

            cfg.CreateMap<V3AssessmentSection, V2AssessmentSection>(memberListForValidation)
                // ================
                // V3 to V2 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------

                // --------------------------
                // V3 Descriptors to V2 Types
                // --------------------------

                // --------------------------------
                // V3 Descriptors to V2 Descriptors
                // --------------------------------
                ;
        }

        private static AssessmentPeriod GetV3AssessmentPeriod(V2Assessment v2)
        {
            if (v2.AssessmentPeriodDescriptor == null)
                return null;

            return new AssessmentPeriod
            {
                AssessmentPeriodDescriptor = VersionConverter.DescriptorV2ToV3("AssessmentPeriodDescriptor", v2.AssessmentPeriodDescriptor)
            };
        }

        private static string GetV2AssessmentPeriodDescriptor(Assessment v3)
        {
            return VersionConverter.DescriptorV3ToV2("AssessmentPeriodDescriptor", v3.AssessmentPeriod?.AssessmentPeriodDescriptor);
        }

        private static void CreateAssessmentItemMap(IMapperConfigurationExpression cfg, MemberList memberListForValidation = MemberList.Destination)
        {
            // =============================
            // Mapping: AssessmentItemReference 
            // =============================
            cfg.CreateMap<V2AssessmentItemReference, V3AssessmentItemReference>(memberListForValidation)
                // ================
                // V2 to v3 mapping
                // ================
                // Convert non-descriptor Namespace property to idiomatic V3 namespace URI
                .ForMember(v3 => v3.Namespace, o => o.MapFrom(v2 => VersionConverter.ResourceNamespacePropertyV2ToV3(v2.Namespace)))

                // ---------------
                // Ignored members
                // ---------------

                // ----------------------------
                // V2 Types to V3 Descriptors
                // ----------------------------

                // --------------------------------
                // V2 Descriptors to V3 Descriptors
                // --------------------------------

                ;

            cfg.CreateMap<V3AssessmentItemReference, V2AssessmentItemReference>(memberListForValidation)
                // ================
                // V3 to V2 mapping
                // ================
                // Convert non-descriptor Namespace property to idiomatic V2 namespace URI
                .ForMember(v2 => v2.Namespace, o => o.MapFrom(v3 => VersionConverter.ResourceNamespacePropertyV3ToV2(v3.Namespace)))

                // ---------------
                // Ignored members
                // ---------------
                
                // --------------------------
                // V3 Descriptors to V2 Types
                // --------------------------

                // --------------------------------
                // V3 Descriptors to V2 Descriptors
                // --------------------------------
                ;
            
            // ==========================================
            // Mapping: AssessmentItem
            // ==========================================
            cfg.CreateMap<V2AssessmentItem, V3AssessmentItem>(memberListForValidation)
                // ================
                // V2 to v3 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------
                // NOTE: URI added in v3.1, there is no source
                .ForMember(x => x.AssessmentItemURI, o => o.Ignore())
                .ForMember(x => x.Extensions, o => o.Ignore())
                .ForMember(x => x.ItemText, o => o.Ignore())
                .ForMember(x => x.AssessmentItemPossibleResponses, o => o.Ignore())

                // ----------------------------
                // V2 Types to V3 Descriptors
                // ----------------------------
                .ForMember(
                    v3 => v3.AssessmentItemCategoryDescriptor,
                    o => o.MapFrom(v2 => VersionConverter.TypeToDescriptor(v2.AssessmentItemCategoryType, "AssessmentItemCategoryDescriptor")))

                // --------------------------------------
                // V2 Descriptors to V3 Descriptors
                // ---------------------------------------
                ;

            cfg.CreateMap<V3AssessmentItem, V2AssessmentItem>(memberListForValidation)
                // ================
                // V3 to V2 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------

                // --------------------------
                // V3 Descriptors to V2 Types
                // --------------------------
                .ForMember(
                    v2 => v2.AssessmentItemCategoryType,
                    o => o.MapFrom(v3 => VersionConverter.DescriptorToType(v3.AssessmentItemCategoryDescriptor)))

                // --------------------------------
                // V3 Descriptors to V2 Descriptors
                // --------------------------------
                ;

            // ==========================================
            // Mapping: AssessmentItemLearningStandard
            // ==========================================
            cfg.CreateMap<V2AssessmentItemLearningStandard, V3AssessmentItemLearningStandard>(memberListForValidation)
                // ================
                // V2 to v3 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------
                .ForMember(x => x.Extensions, o => o.Ignore())

                // ----------------------------
                // V2 Types to V3 Descriptors
                // ----------------------------

                // --------------------------------
                // V2 Descriptors to V3 Descriptors
                // --------------------------------
                ;

            cfg.CreateMap<V3AssessmentItemLearningStandard, V2AssessmentItemLearningStandard>(memberListForValidation)
                // ================
                // V3 to V2 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------

                // --------------------------
                // V3 Descriptors to V2 Types
                // --------------------------

                // --------------------------------
                // V3 Descriptors to V2 Descriptors
                // --------------------------------
                ;
        }

        private static void CreateLearningObjectiveMap(IMapperConfigurationExpression cfg, MemberList memberListForValidation = MemberList.Destination)
        {
            // ======================================================
            // Mapping: LearningObjectiveReference
            // ======================================================
            cfg.CreateMap<V2LearningObjectiveReference, V3LearningObjectiveReference>(memberListForValidation)
                // ================
                // V2 to v3 mapping
                // ================
                // Convert non-descriptor Namespace property to idiomatic V3 namespace URI
                .ForMember(v3 => v3.Namespace, o => o.MapFrom(v2 => VersionConverter.ResourceNamespacePropertyV2ToV3(v2.Namespace)))

                // ---------------
                // Ignored members
                // ---------------

                // --------------------------------
                // V2 Types to V3 Descriptors
                // --------------------------------

                // --------------------------------
                // V2 Descriptors to V3 Descriptors
                // --------------------------------
                ;

            cfg.CreateMap<V3LearningObjectiveReference, V2LearningObjectiveReference>(memberListForValidation)
                // ================
                // V3 to V2 mapping
                // ================
                // Convert non-descriptor Namespace property to idiomatic V2 namespace URI
                .ForMember(v2 => v2.Namespace, o => o.MapFrom(v3 => VersionConverter.ResourceNamespacePropertyV3ToV2(v3.Namespace)))

                // ---------------
                // Ignored members
                // ---------------

                // --------------------------
                // V3 Descriptors to V2 Types
                // --------------------------
                
                // --------------------------------
                // V3 Descriptors to V2 Descriptors
                // --------------------------------
            ;

            // ==========================================
            // Mapping: LearningObjective
            // ==========================================
            cfg.CreateMap<V2LearningObjective, V3LearningObjective>(memberListForValidation)
                // ================
                // V2 to v3 mapping
                // ================
                // Convert non-descriptor Namespace property to idiomatic V3 namespace URI
                .ForMember(v3 => v3.Namespace, o => o.MapFrom(v2 => VersionConverter.ResourceNamespacePropertyV2ToV3(v2.Namespace)))

                // ---------------
                // Ignored members
                // ---------------
                .ForMember(x => x.Extensions, o => o.Ignore())

                // ----------------------------
                // V2 Types to V3 Descriptors
                // ----------------------------

                // --------------------------------
                // V2 Descriptors to V3 Descriptors
                // --------------------------------
                ;

            cfg.CreateMap<V3LearningObjective, V2LearningObjective>(memberListForValidation)
                // ================
                // V3 to V2 mapping
                // ================
                // Convert non-descriptor Namespace property to idiomatic V2 namespace URI
                .ForMember(v2 => v2.Namespace, o => o.MapFrom(v3 => VersionConverter.ResourceNamespacePropertyV3ToV2(v3.Namespace)))

                // ---------------
                // Ignored members
                // ---------------

                // --------------------------
                // V3 Descriptors to V2 Types
                // --------------------------

                // --------------------------------
                // V3 Descriptors to V2 Descriptors
                // --------------------------------
                ;

            // ==========================================
            // Mapping: LearningObjectiveAcademicSubject
            // ==========================================
            cfg.CreateMap<V2LearningObjectiveAcademicSubject, V3LearningObjectiveAcademicSubject>(memberListForValidation)
                // ================
                // V2 to v3 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------
                .ForMember(x => x.Extensions, o => o.Ignore())

                // ---------------------------
                // V2 Types to V3 Descriptors
                // ---------------------------

                // --------------------------------
                // V2 Descriptors to V3 Descriptors
                // --------------------------------
                .ForMember(
                    v3 => v3.AcademicSubjectDescriptor,
                    o => o.MapFrom(v2 => VersionConverter.DescriptorV2ToV3("AcademicSubjectDescriptor", v2.AcademicSubjectDescriptor)))
                ;

            cfg.CreateMap<V3LearningObjectiveAcademicSubject, V2LearningObjectiveAcademicSubject>(memberListForValidation)
                // ================
                // V3 to V2 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------

                // ---------------------------
                // V3 Descriptors to V2 Types
                // ---------------------------

                // --------------------------------
                // V3 Descriptors to V2 Descriptors
                // --------------------------------
                .ForMember(
                    v2 => v2.AcademicSubjectDescriptor,
                    o => o.MapFrom(v3 => VersionConverter.DescriptorV3ToV2("AcademicSubjectDescriptor", v3.AcademicSubjectDescriptor)))
                ;

            // ==========================================
            // Mapping: LearningObjectiveContentStandard
            // ==========================================
            cfg.CreateMap<V2LearningObjectiveContentStandard, V3LearningObjectiveContentStandard>(memberListForValidation)
                // ================
                // V2 to v3 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------
                .ForMember(x => x.Extensions, o => o.Ignore())

                // ---------------------------
                // V2 Types to V3 Descriptors
                // ---------------------------
                .ForMember(
                    v3 => v3.PublicationStatusDescriptor,
                    o => o.MapFrom(v2 => VersionConverter.TypeToDescriptor(v2.PublicationStatusType, "PublicationStatusDescriptor")))

                // --------------------------------
                // V2 Descriptors to V3 Descriptors
                // --------------------------------
                ;

            cfg.CreateMap<V3LearningObjectiveContentStandard, V2LearningObjectiveContentStandard>(memberListForValidation)
                // ================
                // V3 to V2 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------

                // ---------------------------
                // V3 Descriptors to V2 Types
                // ---------------------------
                .ForMember(
                    v2 => v2.PublicationStatusType,
                    o => o.MapFrom(v3 => VersionConverter.DescriptorToType(v3.PublicationStatusDescriptor)))

                // --------------------------------
                // V3 Descriptors to V2 Descriptors
                // --------------------------------
                ;

            // ================================================
            // Mapping: LearningObjectiveContentStandardAuthor
            // ================================================
            cfg.CreateMap<V2LearningObjectiveContentStandardAuthor, V3LearningObjectiveContentStandardAuthor>(memberListForValidation)
                // ================
                // V2 to v3 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------
                .ForMember(x => x.Extensions, o => o.Ignore())

                // ----------------------------
                // V2 Types to V3 Descriptors
                // ----------------------------

                // --------------------------------
                // V2 Descriptors to V3 Descriptors
                // --------------------------------
            ;

            cfg.CreateMap<V3LearningObjectiveContentStandardAuthor, V2LearningObjectiveContentStandardAuthor>(memberListForValidation)
                // ================
                // V3 to V2 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------

                // --------------------------
                // V3 Descriptors to V2 Types
                // --------------------------

                // --------------------------------
                // V3 Descriptors to V2 Descriptors
                // --------------------------------
                ;

            // ==========================================
            // Mapping: LearningObjectiveGradeLevel
            // ==========================================
            cfg.CreateMap<V2LearningObjectiveGradeLevel, V3LearningObjectiveGradeLevel>(memberListForValidation)
                // ================
                // V2 to v3 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------
                .ForMember(x => x.Extensions, o => o.Ignore())

                // ----------------------------
                // V2 Types to V3 Descriptors
                // ----------------------------

                // --------------------------------
                // V2 Descriptors to V3 Descriptors
                // --------------------------------
                .ForMember(
                    v3 => v3.GradeLevelDescriptor,
                    o => o.MapFrom(v2 => VersionConverter.DescriptorV2ToV3("GradeLevelDescriptor", v2.GradeLevelDescriptor)))
                ;

            cfg.CreateMap<V3LearningObjectiveGradeLevel, V2LearningObjectiveGradeLevel>(memberListForValidation)
                // ================
                // V3 to V2 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------

                // --------------------------
                // V3 Descriptors to V2 Types
                // --------------------------

                // --------------------------------
                // V3 Descriptors to V2 Descriptors
                // --------------------------------
                .ForMember(
                    v2 => v2.GradeLevelDescriptor,
                    o => o.MapFrom(v3 => VersionConverter.DescriptorV3ToV2("GradeLevelDescriptor", v3.GradeLevelDescriptor)))
                ;

            // ==========================================
            // Mapping: LearningObjectiveLearningStandard
            // ==========================================
            cfg.CreateMap<V2LearningObjectiveLearningStandard, V3LearningObjectiveLearningStandard>(memberListForValidation)
                // ================
                // V2 to v3 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------
                .ForMember(x => x.Extensions, o => o.Ignore())

                // ----------------------------
                // V2 Types to V3 Descriptors
                // ----------------------------

                // --------------------------------
                // V2 Descriptors to V3 Descriptors
                // --------------------------------
                ;

            cfg.CreateMap<V3LearningObjectiveLearningStandard, V2LearningObjectiveLearningStandard>(memberListForValidation)
                // ================
                // V3 to V2 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------

                // --------------------------
                // V3 Descriptors to V2 Types
                // --------------------------

                // --------------------------------
                // V3 Descriptors to V2 Descriptors
                // --------------------------------
                ;
        }

        private static void CreateLearningStandardMap(IMapperConfigurationExpression cfg, MemberList memberListForValidation = MemberList.Destination)
        {
            // ==========================================
            // Mapping: LearningStandard
            // ==========================================
            cfg.CreateMap<V2LearningStandard, V3LearningStandard>(memberListForValidation)
                // ================
                // V2 to v3 mapping
                // ================
                // Convert non-descriptor Namespace property to idiomatic V3 namespace URI
                .ForMember(v3 => v3.Namespace, o => o.MapFrom(v2 => VersionConverter.ResourceNamespacePropertyV2ToV3(v2.Namespace)))

                // ---------------
                // Ignored members
                // ---------------
                // Optional column added in V3
                .ForMember(v3 => v3.LearningStandardCategoryDescriptor, o => o.Ignore())
                .ForMember(v3 => v3.Extensions, o => o.Ignore())
                .ForMember(v3 => v3.LearningStandardScopeDescriptor, o => o.Ignore())

                // --------------------------------
                // V2 Descriptors to V3 Descriptors
                // --------------------------------
                // AcademicSubjectDescriptor converted into a collection in v3.1
                .ForMember(
                    v3 => v3.LearningStandardAcademicSubjects,
                    o => o.MapFrom(v2 =>
                        v2.AcademicSubjectDescriptor == null
                            ? new List<V3LearningStandardAcademicSubject>()
                            : new List<V3LearningStandardAcademicSubject>
                            {
                                new V3LearningStandardAcademicSubject
                                {
                                    AcademicSubjectDescriptor = VersionConverter.DescriptorV2ToV3("AcademicSubjectDescriptor", v2.AcademicSubjectDescriptor)
                                }
                            }))
                ;

            cfg.CreateMap<V3LearningStandard, V2LearningStandard>(memberListForValidation)
                // ================
                // V3 to V2 mapping
                // ================
                .ForMember(
                    x => x.AcademicSubjectDescriptor,
                    o => o.MapFrom((v3, v2) => VersionConverter.DescriptorV3ToV2(
                            "AcademicSubjectDescriptor",
                            v3.LearningStandardAcademicSubjects.FirstOrDefault()?.AcademicSubjectDescriptor)))

                // Convert non-descriptor Namespace property to idiomatic V2 namespace URI
                .ForMember(v2 => v2.Namespace, o => o.MapFrom(v3 => VersionConverter.ResourceNamespacePropertyV3ToV2(v3.Namespace)))

                // ---------------
                // Ignored members
                // ---------------

                // --------------------------
                // V3 Descriptors to V2 Types
                // --------------------------

                // --------------------------------
                // V3 Descriptors to V2 Descriptors
                // --------------------------------
                ;

            // ==========================================
            // Mapping: LearningStandardContentStandard
            // ==========================================
            cfg.CreateMap<V2LearningStandardContentStandard, V3LearningStandardContentStandard>(memberListForValidation)
                // ================
                // V2 to v3 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------
                .ForMember(x => x.Extensions, o => o.Ignore())

                // ---------------------------------------
                // V2 Types to V3 Descriptors
                // ---------------------------------------
                .ForMember(
                    v3 => v3.PublicationStatusDescriptor,
                    o => o.MapFrom(v2 => VersionConverter.TypeToDescriptor(v2.PublicationStatusType, "PublicationStatusDescriptor")))

                // ---------------------------------------
                // V2 Descriptors to V3 Descriptors
                // ---------------------------------------
                ;

            cfg.CreateMap<V3LearningStandardContentStandard, V2LearningStandardContentStandard>(memberListForValidation)
                // ================
                // V3 to V2 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------

                // --------------------------
                // V3 Descriptors to V2 Types
                // --------------------------
                .ForMember(
                    v2 => v2.PublicationStatusType,
                    o => o.MapFrom(v3 => VersionConverter.DescriptorToType(v3.PublicationStatusDescriptor)))

                // --------------------------------
                // V3 Descriptors to V2 Descriptors
                // --------------------------------
                ;

            // ==========================================
            // Mapping: LearningStandardContentStandardAuthor
            // ==========================================
            cfg.CreateMap<V2LearningStandardContentStandardAuthor, V3LearningStandardContentStandardAuthor>(memberListForValidation)
                // ================
                // V2 to v3 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------
                .ForMember(x => x.Extensions, o => o.Ignore())

                // ----------------------------
                // V2 Types to V3 Descriptors
                // ----------------------------

                // --------------------------------
                // V2 Descriptors to V3 Descriptors
                // --------------------------------
                ;

            cfg.CreateMap<V3LearningStandardContentStandardAuthor, V2LearningStandardContentStandardAuthor>(memberListForValidation)
                // ================
                // V3 to V2 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------

                // --------------------------
                // V3 Descriptors to V2 Types
                // --------------------------

                // --------------------------------
                // V3 Descriptors to V2 Descriptors
                // --------------------------------
                ;

            // ==========================================
            // Mapping: LearningStandardGradeLevel
            // ==========================================
            cfg.CreateMap<V2LearningStandardGradeLevel, V3LearningStandardGradeLevel>(memberListForValidation)
                // ================
                // V2 to v3 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------
                .ForMember(x => x.Extensions, o => o.Ignore())

                // ----------------------------
                // V2 Types to V3 Descriptors
                // ----------------------------

                // --------------------------------
                // V2 Descriptors to V3 Descriptors
                // --------------------------------
                .ForMember(
                    v3 => v3.GradeLevelDescriptor,
                    o => o.MapFrom(v2 => VersionConverter.DescriptorV2ToV3("GradeLevelDescriptor", v2.GradeLevelDescriptor)))
                ;

            cfg.CreateMap<V3LearningStandardGradeLevel, V2LearningStandardGradeLevel>(memberListForValidation)
                // ================
                // V3 to V2 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------

                // --------------------------
                // V3 Descriptors to V2 Types
                // --------------------------

                // --------------------------------
                // V3 Descriptors to V2 Descriptors
                // --------------------------------
                .ForMember(
                    v2 => v2.GradeLevelDescriptor,
                    o => o.MapFrom(v3 => VersionConverter.DescriptorV3ToV2("GradeLevelDescriptor", v3.GradeLevelDescriptor)))
                ;

            // ==========================================
            // Mapping: LearningStandardIdentificationCode
            // ==========================================
            cfg.CreateMap<V2LearningStandardIdentificationCode, V3LearningStandardIdentificationCode>(memberListForValidation)
                // ================
                // V2 to v3 mapping
                // ================
                
                // ---------------
                // Ignored members
                // ---------------
                .ForMember(x => x.Extensions, o => o.Ignore())

                // ----------------------------
                // V2 Types to V3 Descriptors
                // ----------------------------

                // --------------------------------
                // V2 Descriptors to V3 Descriptors
                // --------------------------------
                ;
            
            cfg.CreateMap<V3LearningStandardIdentificationCode, V2LearningStandardIdentificationCode>(memberListForValidation)
                // ================
                // V3 to V2 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------

                // --------------------------
                // V3 Descriptors to V2 Types
                // --------------------------

                // --------------------------------
                // V3 Descriptors to V2 Descriptors
                // --------------------------------
                ;

            // ==========================================
            // Mapping: LearningStandardPrerequisiteLearningStandard
            // ==========================================
            cfg.CreateMap<V2LearningStandardPrerequisiteLearningStandard, V3LearningStandardPrerequisiteLearningStandard>(memberListForValidation)
                // ================
                // V2 to v3 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------
                .ForMember(x => x.Extensions, o => o.Ignore())

                // ----------------------------
                // V2 Types to V3 Descriptors
                // ----------------------------

                // --------------------------------
                // V2 Descriptors to V3 Descriptors
                // --------------------------------
                ;

            cfg.CreateMap<V3LearningStandardPrerequisiteLearningStandard, V2LearningStandardPrerequisiteLearningStandard>(memberListForValidation)
                // ================
                // V3 to V2 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------

                // --------------------------
                // V3 Descriptors to V2 Types
                // --------------------------

                // --------------------------------
                // V3 Descriptors to V2 Descriptors
                // --------------------------------
                ;
        }

        private static void CreateObjectiveAssessmentMap(IMapperConfigurationExpression cfg, MemberList memberListForValidation = MemberList.Destination)
        {
            // ======================================================
            // Mapping: ObjectiveAssessmentReference
            // ======================================================
            cfg.CreateMap<V2ObjectiveAssessmentReference, V3ObjectiveAssessmentReference>(memberListForValidation)
                // ================
                // V2 to v3 mapping
                // ================
                // Convert non-descriptor Namespace property to idiomatic V3 namespace URI
                .ForMember(v3 => v3.Namespace, o => o.MapFrom(v2 => VersionConverter.ResourceNamespacePropertyV2ToV3(v2.Namespace)))

                // ---------------
                // Ignored members
                // ---------------

                // --------------------------------
                // V2 Types to V3 Descriptors
                // --------------------------------

                // --------------------------------
                // V2 Descriptors to V3 Descriptors
                // --------------------------------
                ;

            cfg.CreateMap<V3ObjectiveAssessmentReference, V2ObjectiveAssessmentReference>(memberListForValidation)
                // ================
                // V3 to V2 mapping
                // ================
                // Convert non-descriptor Namespace property to idiomatic V2 namespace URI
                .ForMember(v2 => v2.Namespace, o => o.MapFrom(v3 => VersionConverter.ResourceNamespacePropertyV3ToV2(v3.Namespace)))

                // ---------------
                // Ignored members
                // ---------------

                // --------------------------
                // V3 Descriptors to V2 Types
                // --------------------------
                
                // --------------------------------
                // V3 Descriptors to V2 Descriptors
                // --------------------------------
                ;
            
            // ==========================================
            // Mapping: ObjectiveAssessment
            // ==========================================
            cfg.CreateMap<V2ObjectiveAssessment, V3ObjectiveAssessment>(memberListForValidation)
                // ================
                // V2 to v3 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------
                .ForMember(x => x.Extensions, o => o.Ignore())
                .ForMember(x => x.AcademicSubjectDescriptor, o => o.Ignore())

                // ----------------------------
                // V2 Types to V3 Descriptors
                // ----------------------------

                // --------------------------------
                // V2 Descriptors to V3 Descriptors
                // --------------------------------
                ;

            cfg.CreateMap<V3ObjectiveAssessment, V2ObjectiveAssessment>(memberListForValidation)
                // ================
                // V3 to V2 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------

                // --------------------------
                // V3 Descriptors to V2 Types
                // --------------------------

                // --------------------------------
                // V3 Descriptors to V2 Descriptors
                // --------------------------------
                ;

            // ==========================================
            // Mapping: ObjectiveAssessmentAssessmentItem
            // ==========================================
            cfg.CreateMap<V2ObjectiveAssessmentAssessmentItem, V3ObjectiveAssessmentAssessmentItem>(memberListForValidation)
                // ================
                // V2 to v3 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------
                .ForMember(x => x.Extensions, o => o.Ignore())

                // ----------------------------
                // V2 Types to V3 Descriptors
                // ----------------------------

                // --------------------------------
                // V2 Descriptors to V3 Descriptors
                // --------------------------------
                ;

            cfg.CreateMap<V3ObjectiveAssessmentAssessmentItem, V2ObjectiveAssessmentAssessmentItem>(memberListForValidation)
                // ================
                // V3 to V2 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------

                // --------------------------
                // V3 Descriptors to V2 Types
                // --------------------------

                // --------------------------------
                // V3 Descriptors to V2 Descriptors
                // --------------------------------
                ;

            // ==========================================
            // Mapping: ObjectiveAssessmentLearningObjective
            // ==========================================
            cfg.CreateMap<V2ObjectiveAssessmentLearningObjective, V3ObjectiveAssessmentLearningObjective>(memberListForValidation)
                // ================
                // V2 to v3 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------
                .ForMember(x => x.Extensions, o => o.Ignore())

                // ----------------------------
                // V2 Types to V3 Descriptors
                // ----------------------------

                // --------------------------------
                // V2 Descriptors to V3 Descriptors
                // --------------------------------
                ;

            cfg.CreateMap<V3ObjectiveAssessmentLearningObjective, V2ObjectiveAssessmentLearningObjective>(memberListForValidation)
                // ================
                // V3 to V2 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------

                // --------------------------
                // V3 Descriptors to V2 Types
                // --------------------------

                // --------------------------------
                // V3 Descriptors to V2 Descriptors
                // --------------------------------
                ;

            // ==========================================
            // Mapping: ObjectiveAssessmentLearningStandard
            // ==========================================
            cfg.CreateMap<V2ObjectiveAssessmentLearningStandard, V3ObjectiveAssessmentLearningStandard>(memberListForValidation)
                // ================
                // V2 to v3 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------
                .ForMember(x => x.Extensions, o => o.Ignore())

                // ----------------------------
                // V2 Types to V3 Descriptors
                // ----------------------------

                // --------------------------------
                // V2 Descriptors to V3 Descriptors
                // --------------------------------
                ;

            cfg.CreateMap<V3ObjectiveAssessmentLearningStandard, V2ObjectiveAssessmentLearningStandard>(memberListForValidation)
                // ================
                // V3 to V2 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------

                // --------------------------
                // V3 Descriptors to V2 Types
                // --------------------------

                // --------------------------------
                // V3 Descriptors to V2 Descriptors
                // --------------------------------
                ;

            // ==========================================
            // Mapping: ObjectiveAssessmentPerformanceLevel
            // ==========================================
            cfg.CreateMap<V2ObjectiveAssessmentPerformanceLevel, V3ObjectiveAssessmentPerformanceLevel>(memberListForValidation)
                // ================
                // V2 to v3 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------
                .ForMember(x => x.Extensions, o => o.Ignore())

                // ----------------------------
                // V2 Types to V3 Descriptors
                // ----------------------------
                .ForMember(
                    v3 => v3.ResultDatatypeTypeDescriptor,
                    o => o.MapFrom(v2 => VersionConverter.TypeToDescriptor(v2.ResultDatatypeType, "ResultDatatypeTypeDescriptor")))

                .ForMember(
                    v3 => v3.AssessmentReportingMethodDescriptor,
                    o => o.MapFrom(v2 => VersionConverter.TypeToDescriptor(v2.AssessmentReportingMethodType, "AssessmentReportingMethodDescriptor")))

                // --------------------------------
                // V2 Descriptors to V3 Descriptors
                // --------------------------------
                .ForMember(
                    v3 => v3.PerformanceLevelDescriptor,
                    o => o.MapFrom(v2 => VersionConverter.DescriptorV2ToV3("PerformanceLevelDescriptor", v2.PerformanceLevelDescriptor)))
                ;

            cfg.CreateMap<V3ObjectiveAssessmentPerformanceLevel, V2ObjectiveAssessmentPerformanceLevel>(memberListForValidation)
                // ================
                // V3 to V2 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------

                // --------------------------
                // V3 Descriptors to V2 Types
                // --------------------------
                .ForMember(
                    v2 => v2.ResultDatatypeType,
                    o => o.MapFrom(v3 => VersionConverter.DescriptorToType(v3.ResultDatatypeTypeDescriptor)))

                .ForMember(
                    v2 => v2.AssessmentReportingMethodType,
                    o => o.MapFrom(v3 => VersionConverter.DescriptorToType(v3.AssessmentReportingMethodDescriptor)))

                // --------------------------------
                // V3 Descriptors to V2 Descriptors
                // --------------------------------
                .ForMember(
                    v2 => v2.PerformanceLevelDescriptor,
                    o => o.MapFrom(v3 => VersionConverter.DescriptorV3ToV2("PerformanceLevelDescriptor", v3.PerformanceLevelDescriptor)))
                ;

            // ==========================================
            // Mapping: ObjectiveAssessmentScore
            // ==========================================
            cfg.CreateMap<V2ObjectiveAssessmentScore, V3ObjectiveAssessmentScore>(memberListForValidation)
                // ================
                // V2 to v3 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------
                .ForMember(x => x.Extensions, o => o.Ignore())

                // --------------------------------
                // V2 Types to V3 Descriptors
                // --------------------------------
                .ForMember(
                    v3 => v3.ResultDatatypeTypeDescriptor,
                    o => o.MapFrom(v2 => VersionConverter.TypeToDescriptor(v2.ResultDatatypeType, "ResultDatatypeTypeDescriptor")))

                .ForMember(
                    v3 => v3.AssessmentReportingMethodDescriptor,
                    o => o.MapFrom(v2 => VersionConverter.TypeToDescriptor(v2.AssessmentReportingMethodType, "AssessmentReportingMethodDescriptor")))

                // ---------------------------------------
                // V2 Descriptors to V3 Descriptors
                // ---------------------------------------
                ;

            cfg.CreateMap<V3ObjectiveAssessmentScore, V2ObjectiveAssessmentScore>(memberListForValidation)
                // ================
                // V3 to V2 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------

                // --------------------------
                // V3 Descriptors to V2 Types
                // --------------------------
                .ForMember(
                    v2 => v2.AssessmentReportingMethodType,
                    o => o.MapFrom(v3 => VersionConverter.DescriptorToType(v3.AssessmentReportingMethodDescriptor)))

                .ForMember(
                    v2 => v2.ResultDatatypeType,
                    o => o.MapFrom(v3 => VersionConverter.DescriptorToType(v3.ResultDatatypeTypeDescriptor)))

                // --------------------------------
                // V3 Descriptors to V2 Descriptors
                // --------------------------------
                ;
        }

        private static void CreateStudentAssessmentMap(IMapperConfigurationExpression cfg, MemberList memberListForValidation = MemberList.Destination)
        {
            // =============================
            // Mapping: StudentAssessmentReference 
            // =============================
            cfg.CreateMap<V2StudentAssessmentReference, V3StudentAssessmentReference>(memberListForValidation)
                // ================
                // V2 to v3 mapping
                // ================
                // Convert non-descriptor Namespace property to idiomatic V3 namespace URI
                .ForMember(v3 => v3.Namespace, o => o.MapFrom(v2 => VersionConverter.ResourceNamespacePropertyV2ToV3(v2.Namespace)))

                // ---------------
                // Ignored members
                // ---------------

                // ----------------------------
                // V2 Types to V3 Descriptors
                // ----------------------------

                // --------------------------------
                // V2 Descriptors to V3 Descriptors
                // --------------------------------

                ;

            cfg.CreateMap<V3StudentAssessmentReference, V2StudentAssessmentReference>(memberListForValidation)
                // ================
                // V3 to V2 mapping
                // ================
                // Convert non-descriptor Namespace property to idiomatic V2 namespace URI
                .ForMember(v2 => v2.Namespace, o => o.MapFrom(v3 => VersionConverter.ResourceNamespacePropertyV3ToV2(v3.Namespace)))

                // ---------------
                // Ignored members
                // ---------------
                
                // --------------------------
                // V3 Descriptors to V2 Types
                // --------------------------

                // --------------------------------
                // V3 Descriptors to V2 Descriptors
                // --------------------------------
                ;

            // ==========================================
            // Mapping: StudentAssessment
            // ==========================================
            cfg.CreateMap<V2StudentAssessment, V3StudentAssessment>(memberListForValidation)
                // ================
                // V2 to v3 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------
                // Added in V3
                .ForMember(v3 => v3.SchoolYearTypeReference, o => o.Ignore())
                .ForMember(v3 => v3.Extensions, o => o.Ignore())
                .ForMember(v3 => v3.PlatformTypeDescriptor, o => o.Ignore())

                // --------------------------------
                // V2 Types to V3 Descriptors
                // --------------------------------
                .ForMember(
                    v3 => v3.AdministrationEnvironmentDescriptor,
                    o => o.MapFrom(v2 => VersionConverter.TypeToDescriptor(v2.AdministrationEnvironmentType, "AdministrationEnvironmentDescriptor")))

                .ForMember(
                    v3 => v3.EventCircumstanceDescriptor,
                    o => o.MapFrom(v2 => VersionConverter.TypeToDescriptor(v2.EventCircumstanceType, "EventCircumstanceDescriptor")))

                .ForMember(
                    v3 => v3.ReasonNotTestedDescriptor,
                    o => o.MapFrom(v2 => VersionConverter.TypeToDescriptor(v2.ReasonNotTestedType, "ReasonNotTestedDescriptor")))

                .ForMember(
                    v3 => v3.RetestIndicatorDescriptor,
                    o => o.MapFrom(v2 => VersionConverter.TypeToDescriptor(v2.RetestIndicatorType, "RetestIndicatorDescriptor")))

                // --------------------------------
                // V2 Descriptors to V3 Descriptors
                // --------------------------------
                .ForMember(
                    v3 => v3.AdministrationLanguageDescriptor,
                    o => o.MapFrom(v2 => VersionConverter.DescriptorV2ToV3("LanguageDescriptor", v2.AdministrationLanguageDescriptor)))

                .ForMember(
                    v3 => v3.WhenAssessedGradeLevelDescriptor,
                    o => o.MapFrom(v2 => VersionConverter.DescriptorV2ToV3("GradeLevelDescriptor", v2.WhenAssessedGradeLevelDescriptor)))
                ;

            cfg.CreateMap<V3StudentAssessment, V2StudentAssessment>(memberListForValidation)
                // ================
                // V3 to V2 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------

                // --------------------------
                // V3 Descriptors to V2 Types
                // --------------------------
                .ForMember(
                    v2 => v2.AdministrationEnvironmentType,
                    o => o.MapFrom(v3 => VersionConverter.DescriptorToType(v3.AdministrationEnvironmentDescriptor)))

                .ForMember(
                    v2 => v2.EventCircumstanceType, 
                    o => o.MapFrom(v3 => VersionConverter.DescriptorToType(v3.EventCircumstanceDescriptor)))

                .ForMember(
                    v2 => v2.ReasonNotTestedType, 
                    o => o.MapFrom(v3 => VersionConverter.DescriptorToType(v3.ReasonNotTestedDescriptor)))
                
                .ForMember(
                    v2 => v2.RetestIndicatorType, 
                    o => o.MapFrom(v3 => VersionConverter.DescriptorToType(v3.RetestIndicatorDescriptor)))

                // --------------------------------
                // V3 Descriptors to V2 Descriptors
                // --------------------------------
                .ForMember(
                    v2 => v2.AdministrationLanguageDescriptor,
                    o => o.AddTransform(v3 => VersionConverter.DescriptorV3ToV2("LanguageDescriptor", v3)))

                .ForMember(
                    v2 => v2.WhenAssessedGradeLevelDescriptor,
                    o => o.AddTransform(v3 => VersionConverter.DescriptorV3ToV2("GradeLevelDescriptor", v3)))
                ;

            // ==========================================
            // Mapping: StudentAssessmentAccommodation
            // ==========================================
            cfg.CreateMap<V2StudentAssessmentAccommodation, V3StudentAssessmentAccommodation>(memberListForValidation)
                // ================
                // V2 to v3 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------
                .ForMember(x => x.Extensions, o => o.Ignore())

                // ----------------------------
                // V2 Types to V3 Descriptors
                // ----------------------------

                // --------------------------------
                // V2 Descriptors to V3 Descriptors
                // --------------------------------
                .ForMember(
                    v3 => v3.AccommodationDescriptor,
                    o => o.MapFrom(v2 => VersionConverter.DescriptorV2ToV3("AccommodationDescriptor", v2.AccommodationDescriptor)))
                ;

            cfg.CreateMap<V3StudentAssessmentAccommodation, V2StudentAssessmentAccommodation>(memberListForValidation)
                // ================
                // V3 to V2 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------

                // --------------------------
                // V3 Descriptors to V2 Types
                // --------------------------

                // --------------------------------
                // V3 Descriptors to V2 Descriptors
                // --------------------------------
                .ForMember(
                    v2 => v2.AccommodationDescriptor,
                    o => o.MapFrom(v3 => VersionConverter.DescriptorV3ToV2("AccommodationDescriptor", v3.AccommodationDescriptor)))
                ;

            // ==========================================
            // Mapping: StudentAssessmentItem
            // ==========================================
            cfg.CreateMap<V2StudentAssessmentItem, V3StudentAssessmentItem>(memberListForValidation)
                // ================
                // V2 to v3 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------
                .ForMember(x => x.Extensions, o => o.Ignore())

                // --------------------------------
                // V2 Types to V3 Descriptors
                // --------------------------------
                .ForMember(
                    v3 => v3.AssessmentItemResultDescriptor,
                    o => o.MapFrom(v2 => VersionConverter.TypeToDescriptor(v2.AssessmentItemResultType, "AssessmentItemResultDescriptor")))

                .ForMember(
                    v3 => v3.ResponseIndicatorDescriptor,
                    o => o.MapFrom(v2 => VersionConverter.TypeToDescriptor(v2.ResponseIndicatorType, "ResponseIndicatorDescriptor")))

                // --------------------------------
                // V2 Descriptors to V3 Descriptors
                // --------------------------------
                ;

            cfg.CreateMap<V3StudentAssessmentItem, V2StudentAssessmentItem>(memberListForValidation)
                // ================
                // V3 to V2 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------

                // --------------------------
                // V3 Descriptors to V2 Types
                // --------------------------
                .ForMember(
                    v2 => v2.AssessmentItemResultType,
                    o => o.MapFrom(v3 => VersionConverter.DescriptorToType(v3.AssessmentItemResultDescriptor)))

                .ForMember(
                    v2 => v2.ResponseIndicatorType,
                    o => o.MapFrom(v3 => VersionConverter.DescriptorToType(v3.ResponseIndicatorDescriptor)))

                // --------------------------------
                // V3 Descriptors to V2 Descriptors
                // --------------------------------
                ;

            // ==========================================
            // Mapping: StudentAssessmentPerformanceLevel
            // ==========================================
            cfg.CreateMap<V2StudentAssessmentPerformanceLevel, V3StudentAssessmentPerformanceLevel>(memberListForValidation)
                // ================
                // V2 to v3 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------
                .ForMember(x => x.Extensions, o => o.Ignore())

                // --------------------------------
                // V2 Types to V3 Descriptors
                // --------------------------------
                .ForMember(
                    v3 => v3.AssessmentReportingMethodDescriptor,
                    o => o.MapFrom(v2 => VersionConverter.TypeToDescriptor(v2.AssessmentReportingMethodType, "AssessmentReportingMethodDescriptor")))

                // --------------------------------
                // V2 Descriptors to V3 Descriptors
                // --------------------------------
                .ForMember(
                    v3 => v3.PerformanceLevelDescriptor,
                    o => o.MapFrom(v2 => VersionConverter.DescriptorV2ToV3("PerformanceLevelDescriptor", v2.PerformanceLevelDescriptor)))
                ;

            cfg.CreateMap<V3StudentAssessmentPerformanceLevel, V2StudentAssessmentPerformanceLevel>(memberListForValidation)
                // ================
                // V3 to V2 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------

                // --------------------------
                // V3 Descriptors to V2 Types
                // --------------------------
                .ForMember(
                    v2 => v2.AssessmentReportingMethodType,
                    o => o.MapFrom(v3 => VersionConverter.DescriptorToType(v3.AssessmentReportingMethodDescriptor)))

                // --------------------------------
                // V3 Descriptors to V2 Descriptors
                // --------------------------------
                .ForMember(
                    v2 => v2.PerformanceLevelDescriptor,
                    o => o.MapFrom(v3 => VersionConverter.DescriptorV3ToV2("PerformanceLevelDescriptor", v3.PerformanceLevelDescriptor)))
                ;

            // ==========================================
            // Mapping: StudentAssessmentScoreResult
            // ==========================================
            cfg.CreateMap<V2StudentAssessmentScoreResult, V3StudentAssessmentScoreResult>(memberListForValidation)
                // ================
                // V2 to v3 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------
                .ForMember(x => x.Extensions, o => o.Ignore())

                // --------------------------------
                // V2 Types to V3 Descriptors
                // --------------------------------
                .ForMember(
                    v3 => v3.ResultDatatypeTypeDescriptor,
                    o => o.MapFrom(v2 => VersionConverter.TypeToDescriptor(v2.ResultDatatypeType, "ResultDatatypeTypeDescriptor")))

                .ForMember(
                    v3 => v3.AssessmentReportingMethodDescriptor,
                    o => o.MapFrom(v2 => VersionConverter.TypeToDescriptor(v2.AssessmentReportingMethodType, "AssessmentReportingMethodDescriptor")))

                // --------------------------------
                // V2 Descriptors to V3 Descriptors
                // --------------------------------
                ;

            cfg.CreateMap<V3StudentAssessmentScoreResult, V2StudentAssessmentScoreResult>(memberListForValidation)
                // ================
                // V3 to V2 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------

                // --------------------------
                // V3 Descriptors to V2 Types
                // --------------------------
                .ForMember(
                    v2 => v2.AssessmentReportingMethodType,
                    o => o.MapFrom(v3 => VersionConverter.DescriptorToType(v3.AssessmentReportingMethodDescriptor)))

                .ForMember(
                    v2 => v2.ResultDatatypeType,
                    o => o.MapFrom(v3 => VersionConverter.DescriptorToType(v3.ResultDatatypeTypeDescriptor)))

                // --------------------------------
                // V3 Descriptors to V2 Descriptors
                // --------------------------------
                ;

            // =====================================================
            // Mapping: StudentAssessmentStudentObjectiveAssessment
            // =====================================================
            cfg.CreateMap<V2StudentAssessmentStudentObjectiveAssessment, V3StudentAssessmentStudentObjectiveAssessment>(memberListForValidation)
                // ================
                // V2 to v3 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------
                .ForMember(x => x.Extensions, o => o.Ignore())

                // ----------------------------
                // V2 Types to V3 Descriptors
                // ----------------------------

                // --------------------------------
                // V2 Descriptors to V3 Descriptors
                // --------------------------------
                ;

            cfg.CreateMap<V3StudentAssessmentStudentObjectiveAssessment, V2StudentAssessmentStudentObjectiveAssessment>(memberListForValidation)
                // ================
                // V3 to V2 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------

                // --------------------------
                // V3 Descriptors to V2 Types
                // --------------------------

                // --------------------------------
                // V3 Descriptors to V2 Descriptors
                // --------------------------------
                ;

            // =====================================================================
            // Mapping: StudentAssessmentStudentObjectiveAssessmentPerformanceLevel
            // =====================================================================
            cfg.CreateMap<V2StudentAssessmentStudentObjectiveAssessmentPerformanceLevel, V3StudentAssessmentStudentObjectiveAssessmentPerformanceLevel>(memberListForValidation)
                // ================
                // V2 to v3 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------
                .ForMember(x => x.Extensions, o => o.Ignore())

                // --------------------------------
                // V2 Types to V3 Descriptors
                // --------------------------------
                .ForMember(
                    v3 => v3.AssessmentReportingMethodDescriptor,
                    o => o.MapFrom(v2 => VersionConverter.TypeToDescriptor(v2.AssessmentReportingMethodType, "AssessmentReportingMethodDescriptor")))

                // --------------------------------
                // V2 Descriptors to V3 Descriptors
                // --------------------------------
                .ForMember(
                    v3 => v3.PerformanceLevelDescriptor,
                    o => o.MapFrom(v2 => VersionConverter.DescriptorV2ToV3("PerformanceLevelDescriptor", v2.PerformanceLevelDescriptor)))
                ;

            cfg.CreateMap<V3StudentAssessmentStudentObjectiveAssessmentPerformanceLevel, V2StudentAssessmentStudentObjectiveAssessmentPerformanceLevel>(memberListForValidation)
                // ================
                // V3 to V2 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------

                // --------------------------
                // V3 Descriptors to V2 Types
                // --------------------------
                .ForMember(
                    v2 => v2.AssessmentReportingMethodType,
                    o => o.MapFrom(v3 => VersionConverter.DescriptorToType(v3.AssessmentReportingMethodDescriptor)))

                // --------------------------------
                // V3 Descriptors to V2 Descriptors
                // --------------------------------
                .ForMember(
                    v2 => v2.PerformanceLevelDescriptor,
                    o => o.MapFrom(v3 => VersionConverter.DescriptorV3ToV2("PerformanceLevelDescriptor", v3.PerformanceLevelDescriptor)))
                ;

            // ================================================================
            // Mapping: StudentAssessmentStudentObjectiveAssessmentScoreResult
            // ================================================================
            cfg.CreateMap<V2StudentAssessmentStudentObjectiveAssessmentScoreResult, V3StudentAssessmentStudentObjectiveAssessmentScoreResult>()
                // ================
                // V2 to v3 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------
                .ForMember(x => x.Extensions, o => o.Ignore())
            
                // --------------------------------
                // V2 Types to V3 Descriptors
                // --------------------------------
                .ForMember(
                    v3 => v3.AssessmentReportingMethodDescriptor,
                    o => o.MapFrom(v2 => VersionConverter.TypeToDescriptor(v2.AssessmentReportingMethodType, "AssessmentReportingMethodDescriptor")))

                .ForMember(
                    v3 => v3.ResultDatatypeTypeDescriptor,
                    o => o.MapFrom(v2 => VersionConverter.TypeToDescriptor(v2.ResultDatatypeType, "ResultDatatypeTypeDescriptor")))

                // --------------------------------
                // V2 Descriptors to V3 Descriptors
                // --------------------------------
                ;

            cfg.CreateMap<V3StudentAssessmentStudentObjectiveAssessmentScoreResult, V2StudentAssessmentStudentObjectiveAssessmentScoreResult>()
                // ================
                // V3 to V2 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------

                // --------------------------
                // V3 Descriptors to V2 Types
                // --------------------------
                .ForMember(
                    v2 => v2.AssessmentReportingMethodType,
                    o => o.MapFrom(v3 => VersionConverter.DescriptorToType(v3.AssessmentReportingMethodDescriptor)))

                .ForMember(
                    v2 => v2.ResultDatatypeType,
                    o => o.MapFrom(v3 => VersionConverter.DescriptorToType(v3.ResultDatatypeTypeDescriptor)))

                // --------------------------------
                // V3 Descriptors to V2 Descriptors
                // --------------------------------
                ;
        }

        private static void CreateTypeMaps(
            IMapperConfigurationExpression cfg,
            MemberList memberListForValidation = MemberList.Destination)
        {
            // ----------------------------------------------------------------------------
            // AdministrationEnvironmentDescriptor - AdministrationEnvironmentType
            // ----------------------------------------------------------------------------
            cfg.CreateMap<V3AdministrationEnvironmentDescriptor, V2AdministrationEnvironmentType>(memberListForValidation)
                .ForMember(v2 => v2.AdministrationEnvironmentTypeId, o => o.MapFrom(v3 => v3.AdministrationEnvironmentDescriptorId));

            cfg.CreateMap<V2AdministrationEnvironmentType, V3AdministrationEnvironmentDescriptor>(memberListForValidation)
                .ForMember(v3 => v3.Extensions, o => o.Ignore())
                .ForMember(v3 => v3.EffectiveBeginDate, o => o.Ignore())
                .ForMember(v3 => v3.EffectiveEndDate, o => o.Ignore())
                .ForMember(v3 => v3.PriorDescriptorId, o => o.Ignore())
                .ForMember(v3 => v3.Namespace, o => o.MapFrom(v2 => VersionConverter.TypeToDescriptor(v2.CodeValue, "AdministrationEnvironmentDescriptor")))
                .ForMember(v3 => v3.AdministrationEnvironmentDescriptorId, o => o.MapFrom(v2 => v2.AdministrationEnvironmentTypeId));


            // ----------------------------------------------------------------------------
            // AssessmentItemCategoryDescriptor - AssessmentItemCategoryType
            // ----------------------------------------------------------------------------
            cfg.CreateMap<V3AssessmentItemCategoryDescriptor, V2AssessmentItemCategoryType>(memberListForValidation)
                .ForMember(v2 => v2.AssessmentItemCategoryTypeId, o => o.MapFrom(v3 => v3.AssessmentItemCategoryDescriptorId));

            cfg.CreateMap<V2AssessmentItemCategoryType, V3AssessmentItemCategoryDescriptor>(memberListForValidation)
                .ForMember(v3 => v3.Extensions, o => o.Ignore())
                .ForMember(v3 => v3.EffectiveBeginDate, o => o.Ignore())
                .ForMember(v3 => v3.EffectiveEndDate, o => o.Ignore())
                .ForMember(v3 => v3.PriorDescriptorId, o => o.Ignore())
                .ForMember(v3 => v3.Namespace, o => o.MapFrom(v2 => VersionConverter.TypeToDescriptor(v2.CodeValue, "AssessmentItemCategoryDescriptor")))
                .ForMember(v3 => v3.AssessmentItemCategoryDescriptorId, o => o.MapFrom(v2 => v2.AssessmentItemCategoryTypeId));

            // ----------------------------------------------------------------------------
            // AssessmentItemResultDescriptor - AssessmentItemResultType
            // ----------------------------------------------------------------------------
            cfg.CreateMap<V3AssessmentItemResultDescriptor, V2AssessmentItemResultType>(memberListForValidation)
                .ForMember(v2 => v2.AssessmentItemResultTypeId, o => o.MapFrom(v3 => v3.AssessmentItemResultDescriptorId));

            cfg.CreateMap<V2AssessmentItemResultType, V3AssessmentItemResultDescriptor>(memberListForValidation)
                .ForMember(v3 => v3.Extensions, o => o.Ignore())
                .ForMember(v3 => v3.EffectiveBeginDate, o => o.Ignore())
                .ForMember(v3 => v3.EffectiveEndDate, o => o.Ignore())
                .ForMember(v3 => v3.PriorDescriptorId, o => o.Ignore())
                .ForMember(v3 => v3.Namespace, o => o.MapFrom(v2 => VersionConverter.TypeToDescriptor(v2.CodeValue, "AssessmentItemResultDescriptor")))
                .ForMember(v3 => v3.AssessmentItemResultDescriptorId, o => o.MapFrom(v2 => v2.AssessmentItemResultTypeId));

            // ----------------------------------------------------------------------------
            // AssessmentReportingMethodDescriptor - AssessmentReportingMethodType
            // ----------------------------------------------------------------------------
            cfg.CreateMap<V3AssessmentReportingMethodDescriptor, V2AssessmentReportingMethodType>(memberListForValidation)
                .ForMember(v2 => v2.AssessmentReportingMethodTypeId, o => o.MapFrom(v3 => v3.AssessmentReportingMethodDescriptorId));

            cfg.CreateMap<V2AssessmentReportingMethodType, V3AssessmentReportingMethodDescriptor>(memberListForValidation)
                .ForMember(v3 => v3.Extensions, o => o.Ignore())
                .ForMember(v3 => v3.EffectiveBeginDate, o => o.Ignore())
                .ForMember(v3 => v3.EffectiveEndDate, o => o.Ignore())
                .ForMember(v3 => v3.PriorDescriptorId, o => o.Ignore())
                .ForMember(v3 => v3.Namespace, o => o.MapFrom(v2 => VersionConverter.TypeToDescriptor(v2.CodeValue, "AssessmentReportingMethodDescriptor")))
                .ForMember(v3 => v3.AssessmentReportingMethodDescriptorId, o => o.MapFrom(v2 => v2.AssessmentReportingMethodTypeId));


            // ----------------------------------------------------------------------------
            // EventCircumstanceDescriptor - EventCircumstanceType
            // ----------------------------------------------------------------------------
            cfg.CreateMap<V3EventCircumstanceDescriptor, V2EventCircumstanceType>(memberListForValidation)
                .ForMember(v2 => v2.EventCircumstanceTypeId, o => o.MapFrom(v3 => v3.EventCircumstanceDescriptorId));

            cfg.CreateMap<V2EventCircumstanceType, V3EventCircumstanceDescriptor>(memberListForValidation)
                .ForMember(v3 => v3.Extensions, o => o.Ignore())
                .ForMember(v3 => v3.EffectiveBeginDate, o => o.Ignore())
                .ForMember(v3 => v3.EffectiveEndDate, o => o.Ignore())
                .ForMember(v3 => v3.PriorDescriptorId, o => o.Ignore())
                .ForMember(v3 => v3.Namespace, o => o.MapFrom(v2 => VersionConverter.TypeToDescriptor(v2.CodeValue, "EventCircumstanceDescriptor")))
                .ForMember(v3 => v3.EventCircumstanceDescriptorId, o => o.MapFrom(v2 => v2.EventCircumstanceTypeId));

            // ----------------------------------------------------------------------------
            // PublicationStatusDescriptor - PublicationStatusType
            // ----------------------------------------------------------------------------
            cfg.CreateMap<V3PublicationStatusDescriptor, V2PublicationStatusType>(memberListForValidation)
                .ForMember(v2 => v2.PublicationStatusTypeId, o => o.MapFrom(v3 => v3.PublicationStatusDescriptorId));

            cfg.CreateMap<V2PublicationStatusType, V3PublicationStatusDescriptor>(memberListForValidation)
                .ForMember(v3 => v3.Extensions, o => o.Ignore())
                .ForMember(v3 => v3.EffectiveBeginDate, o => o.Ignore())
                .ForMember(v3 => v3.EffectiveEndDate, o => o.Ignore())
                .ForMember(v3 => v3.PriorDescriptorId, o => o.Ignore())
                .ForMember(v3 => v3.Namespace, o => o.MapFrom(v2 => VersionConverter.TypeToDescriptor(v2.CodeValue, "PublicationStatusDescriptor")))
                .ForMember(v3 => v3.PublicationStatusDescriptorId, o => o.MapFrom(v2 => v2.PublicationStatusTypeId));

            // ----------------------------------------------------------------------------
            // ReasonNotTestedDescriptor - ReasonNotTestedType
            // ----------------------------------------------------------------------------
            cfg.CreateMap<V3ReasonNotTestedDescriptor, V2ReasonNotTestedType>(memberListForValidation)
                .ForMember(v2 => v2.ReasonNotTestedTypeId, o => o.MapFrom(v3 => v3.ReasonNotTestedDescriptorId));

            cfg.CreateMap<V2ReasonNotTestedType, V3ReasonNotTestedDescriptor>(memberListForValidation)
                .ForMember(v3 => v3.Extensions, o => o.Ignore())
                .ForMember(v3 => v3.EffectiveBeginDate, o => o.Ignore())
                .ForMember(v3 => v3.EffectiveEndDate, o => o.Ignore())
                .ForMember(v3 => v3.PriorDescriptorId, o => o.Ignore())
                .ForMember(v3 => v3.Namespace, o => o.MapFrom(v2 => VersionConverter.TypeToDescriptor(v2.CodeValue, "ReasonNotTestedDescriptor")))
                .ForMember(v3 => v3.ReasonNotTestedDescriptorId, o => o.MapFrom(v2 => v2.ReasonNotTestedTypeId));

            // ----------------------------------------------------------------------------
            // ResponseIndicatorDescriptor - ResponseIndicatorType
            // ----------------------------------------------------------------------------
            cfg.CreateMap<V3ResponseIndicatorDescriptor, V2ResponseIndicatorType>(memberListForValidation)
                .ForMember(v2 => v2.ResponseIndicatorTypeId, o => o.MapFrom(v3 => v3.ResponseIndicatorDescriptorId));

            cfg.CreateMap<V2ResponseIndicatorType, V3ResponseIndicatorDescriptor>(memberListForValidation)
                .ForMember(v3 => v3.Extensions, o => o.Ignore())
                .ForMember(v3 => v3.EffectiveBeginDate, o => o.Ignore())
                .ForMember(v3 => v3.EffectiveEndDate, o => o.Ignore())
                .ForMember(v3 => v3.PriorDescriptorId, o => o.Ignore())
                .ForMember(v3 => v3.Namespace, o => o.MapFrom(v2 => VersionConverter.TypeToDescriptor(v2.CodeValue, "ResponseIndicatorDescriptor")))
                .ForMember(v3 => v3.ResponseIndicatorDescriptorId, o => o.MapFrom(v2 => v2.ResponseIndicatorTypeId));

            // ----------------------------------------------------------------------------
            // ResultDatatypeTypeDescriptor - ResultDatatypeType
            // ----------------------------------------------------------------------------
            cfg.CreateMap<V3ResultDatatypeTypeDescriptor, V2ResultDatatypeType>(memberListForValidation)
                .ForMember(v2 => v2.ResultDatatypeTypeId, o => o.MapFrom(v3 => v3.ResultDatatypeTypeDescriptorId));

            cfg.CreateMap<V2ResultDatatypeType, V3ResultDatatypeTypeDescriptor>(memberListForValidation)
                .ForMember(v3 => v3.Extensions, o => o.Ignore())
                .ForMember(v3 => v3.EffectiveBeginDate, o => o.Ignore())
                .ForMember(v3 => v3.EffectiveEndDate, o => o.Ignore())
                .ForMember(v3 => v3.PriorDescriptorId, o => o.Ignore())
                .ForMember(v3 => v3.Namespace, o => o.MapFrom(v2 => VersionConverter.TypeToDescriptor(v2.CodeValue, "ResultDatatypeTypeDescriptor")))
                .ForMember(v3 => v3.ResultDatatypeTypeDescriptorId, o => o.MapFrom(v2 => v2.ResultDatatypeTypeId));

            // ----------------------------------------------------------------------------
            // RetestIndicatorDescriptor - RetestIndicatorType
            // ----------------------------------------------------------------------------
            cfg.CreateMap<V3RetestIndicatorDescriptor, V2RetestIndicatorType>(memberListForValidation)
                .ForMember(v2 => v2.RetestIndicatorTypeId, o => o.MapFrom(v3 => v3.RetestIndicatorDescriptorId));

            cfg.CreateMap<V2RetestIndicatorType, V3RetestIndicatorDescriptor>(memberListForValidation)
                .ForMember(v3 => v3.Extensions, o => o.Ignore())
                .ForMember(v3 => v3.EffectiveBeginDate, o => o.Ignore())
                .ForMember(v3 => v3.EffectiveEndDate, o => o.Ignore())
                .ForMember(v3 => v3.PriorDescriptorId, o => o.Ignore())
                .ForMember(v3 => v3.Namespace, o => o.MapFrom(v2 => VersionConverter.TypeToDescriptor(v2.CodeValue, "RetestIndicatorDescriptor")))
                .ForMember(v3 => v3.RetestIndicatorDescriptorId, o => o.MapFrom(v2 => v2.RetestIndicatorTypeId));

            // ----------------------------------------------------------------------------
            // ProgramTypeDescriptor - ProgramType
            // ----------------------------------------------------------------------------
            cfg.CreateMap<V3ProgramTypeDescriptor, V2ProgramType>(memberListForValidation)
                .ForMember(v2 => v2.ProgramTypeId, o => o.MapFrom(v3 => v3.ProgramTypeDescriptorId));

            cfg.CreateMap<V2ProgramType, V3ProgramTypeDescriptor>(memberListForValidation)
                .ForMember(v3 => v3.Extensions, o => o.Ignore())
                .ForMember(v3 => v3.EffectiveBeginDate, o => o.Ignore())
                .ForMember(v3 => v3.EffectiveEndDate, o => o.Ignore())
                .ForMember(v3 => v3.PriorDescriptorId, o => o.Ignore())
                .ForMember(v3 => v3.Namespace, o => o.MapFrom(v2 => VersionConverter.TypeToDescriptor(v2.CodeValue, "ProgramTypeDescriptor")))
                .ForMember(v3 => v3.ProgramTypeDescriptorId, o => o.MapFrom(v2 => v2.ProgramTypeId));
        }

        private static void CreateDescriptorMaps(IMapperConfigurationExpression cfg, MemberList memberListForValidation = MemberList.Destination)
        {
            // --------------------------------------
            // AcademicSubjectDescriptor
            // --------------------------------------
            cfg.CreateMap<V3AcademicSubjectDescriptor, V2AcademicSubjectDescriptor>(memberListForValidation)
                .ForMember(v2 => v2.AcademicSubjectType, o => o.MapFrom(v3 => v3.CodeValue))
                .ForMember(v2 => v2.Namespace, o => o.MapFrom(v3 => VersionConverter.DescriptorNamespaceV3ToV2(v3.Namespace)));

            cfg.CreateMap<V2AcademicSubjectDescriptor, V3AcademicSubjectDescriptor>(memberListForValidation)
                .ForMember(v3 => v3.Extensions, o => o.Ignore())
                .ForMember(v3 => v3.Namespace, o => o.MapFrom(v2 => VersionConverter.DescriptorNamespaceV2ToV3(v2.Namespace, "AcademicSubjectDescriptor")));

            // --------------------------------------
            // AccommodationDescriptor
            // --------------------------------------
            cfg.CreateMap<V3AccommodationDescriptor, V2AccommodationDescriptor>(memberListForValidation)
                .ForMember(v2 => v2.AccommodationType, o => o.MapFrom(v3 => v3.CodeValue))
                .ForMember(v2 => v2.Namespace, o => o.MapFrom(v3 => VersionConverter.DescriptorNamespaceV3ToV2(v3.Namespace)));

            cfg.CreateMap<V2AccommodationDescriptor, V3AccommodationDescriptor>(memberListForValidation)
                .ForMember(v3 => v3.Extensions, o => o.Ignore())
                .ForMember(v3 => v3.Namespace, o => o.MapFrom(v2 => VersionConverter.DescriptorNamespaceV2ToV3(v2.Namespace, "AccommodationDescriptor")));

            // --------------------------------------
            // AssessmentCategoryDescriptor
            // --------------------------------------
            cfg.CreateMap<V3AssessmentCategoryDescriptor, V2AssessmentCategoryDescriptor>(memberListForValidation)
                .ForMember(v2 => v2.AssessmentCategoryType, o => o.MapFrom(v3 => v3.CodeValue))
                .ForMember(v2 => v2.Namespace, o => o.MapFrom(v3 => VersionConverter.DescriptorNamespaceV3ToV2(v3.Namespace)));

            cfg.CreateMap<V2AssessmentCategoryDescriptor, V3AssessmentCategoryDescriptor>(memberListForValidation)
                .ForMember(v3 => v3.Extensions, o => o.Ignore())
                .ForMember(v3 => v3.Namespace, o => o.MapFrom(v2 => VersionConverter.DescriptorNamespaceV2ToV3(v2.Namespace, "AssessmentCategoryDescriptor")));

            // --------------------------------------
            // AssessmentIdentificationSystemDescriptor
            // --------------------------------------
            cfg.CreateMap<V3AssessmentIdentificationSystemDescriptor, V2AssessmentIdentificationSystemDescriptor>(memberListForValidation)
                .ForMember(v2 => v2.AssessmentIdentificationSystemType, o => o.MapFrom(v3 => v3.CodeValue))
                .ForMember(v2 => v2.Namespace, o => o.MapFrom(v3 => VersionConverter.DescriptorNamespaceV3ToV2(v3.Namespace)));

            cfg.CreateMap<V2AssessmentIdentificationSystemDescriptor, V3AssessmentIdentificationSystemDescriptor>(memberListForValidation)
                .ForMember(v3 => v3.Extensions, o => o.Ignore())
                .ForMember(v3 => v3.Namespace, o => o.MapFrom(v2 => VersionConverter.DescriptorNamespaceV2ToV3(v2.Namespace, "AssessmentIdentificationSystemDescriptor")));

            // --------------------------------------
            // AssessmentPeriodDescriptor
            // --------------------------------------
            cfg.CreateMap<V3AssessmentPeriodDescriptor, V2AssessmentPeriodDescriptor>(memberListForValidation)
                // These dates are no longer part of descriptors in V3.
                .ForMember(v3 => v3.BeginDate, o => o.Ignore())
                .ForMember(v3 => v3.EndDate, o => o.Ignore())
                .ForMember(v2 => v2.Namespace, o => o.MapFrom(v3 => VersionConverter.DescriptorNamespaceV3ToV2(v3.Namespace)));

            cfg.CreateMap<V2AssessmentPeriodDescriptor, V3AssessmentPeriodDescriptor>(memberListForValidation)
                .ForMember(v3 => v3.Extensions, o => o.Ignore())
                .ForMember(v3 => v3.Namespace, o => o.MapFrom(v2 => VersionConverter.DescriptorNamespaceV2ToV3(v2.Namespace, "AssessmentPeriodDescriptor")));

            // --------------------------------------
            // GradeLevelDescriptor
            // --------------------------------------
            cfg.CreateMap<V3GradeLevelDescriptor, V2GradeLevelDescriptor>(memberListForValidation)
                .ForMember(v2 => v2.GradeLevelType, o => o.MapFrom(v3 => v3.CodeValue))
                .ForMember(v2 => v2.Namespace, o => o.MapFrom(v3 => VersionConverter.DescriptorNamespaceV3ToV2(v3.Namespace)));

            cfg.CreateMap<V2GradeLevelDescriptor, V3GradeLevelDescriptor>(memberListForValidation)
                .ForMember(v3 => v3.Extensions, o => o.Ignore())
                .ForMember(v3 => v3.Namespace, o => o.MapFrom(v2 => VersionConverter.DescriptorNamespaceV2ToV3(v2.Namespace, "GradeLevelDescriptor")));

            // --------------------------------------
            // LanguageDescriptor
            // --------------------------------------
            cfg.CreateMap<V3LanguageDescriptor, V2LanguageDescriptor>(memberListForValidation)
                .ForMember(v2 => v2.LanguageType, o => o.MapFrom(v3 => v3.CodeValue))
                .ForMember(v2 => v2.Namespace, o => o.MapFrom(v3 => VersionConverter.DescriptorNamespaceV3ToV2(v3.Namespace)));

            cfg.CreateMap<V2LanguageDescriptor, V3LanguageDescriptor>(memberListForValidation)
                .ForMember(v3 => v3.Extensions, o => o.Ignore())
                .ForMember(v3 => v3.Namespace, o => o.MapFrom(v2 => VersionConverter.DescriptorNamespaceV2ToV3(v2.Namespace, "LanguageDescriptor")));

            // --------------------------------------
            // PerformanceLevelDescriptor
            // --------------------------------------
            cfg.CreateMap<V3PerformanceLevelDescriptor, V2PerformanceLevelDescriptor>(memberListForValidation)
                .ForMember(v2 => v2.PerformanceBaseConversionType, o => o.Ignore())
                .ForMember(v2 => v2.Namespace, o => o.MapFrom(v3 => VersionConverter.DescriptorNamespaceV3ToV2(v3.Namespace)));

            cfg.CreateMap<V2PerformanceLevelDescriptor, V3PerformanceLevelDescriptor>(memberListForValidation)
                .ForMember(v3 => v3.Extensions, o => o.Ignore())
                .ForMember(v3 => v3.Namespace, o => o.MapFrom(v2 => VersionConverter.DescriptorNamespaceV2ToV3(v2.Namespace, "PerformanceLevelDescriptor")));

            // --------------------------------------
            // TermDescriptor
            // --------------------------------------
            cfg.CreateMap<V3TermDescriptor, V2TermDescriptor>(memberListForValidation)
                .ForMember(v2 => v2.TermType, o => o.MapFrom(v3 => v3.CodeValue))
                .ForMember(v2 => v2.Namespace, o => o.MapFrom(v3 => VersionConverter.DescriptorNamespaceV3ToV2(v3.Namespace)));

            cfg.CreateMap<V2TermDescriptor, V3TermDescriptor>(memberListForValidation)
                .ForMember(v3 => v3.Extensions, o => o.Ignore())
                .ForMember(v3 => v3.Namespace, o => o.MapFrom(v2 => VersionConverter.DescriptorNamespaceV2ToV3(v2.Namespace, "TermDescriptor")));
        }

        private static void CreateSessionMaps(
            IMapperConfigurationExpression cfg,
            MemberList memberListForValidation = MemberList.Destination)
        {
            // ==========================================
            // Mapping: Session
            // ==========================================
            cfg.CreateMap<V2Session, V3Session>()
                // ================
                // V2 to v3 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------
                .ForMember(x => x.Extensions, o => o.Ignore())
                
                // --------------------------------
                // V2 Types to V3 Descriptors
                // --------------------------------
                .ForMember(
                    v3 => v3.TermDescriptor,
                    o => o.MapFrom(v2 => VersionConverter.DescriptorV2ToV3("TermDescriptor", v2.TermDescriptor)))

                // --------------------------------
                // V2 Descriptors to V3 Descriptors
                // --------------------------------
                ;

            cfg.CreateMap<V3Session, V2Session>()
                // ================
                // V3 to V2 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------

                // --------------------------
                // V3 Descriptors to V2 Types
                // --------------------------

                // --------------------------------
                // V3 Descriptors to V2 Descriptors
                // --------------------------------
                .ForMember(
                    v2 => v2.TermDescriptor,
                    o => o.MapFrom(v3 => VersionConverter.DescriptorV3ToV2("TermDescriptor", v3.TermDescriptor)))
                ;

            // ==========================================
            // Mapping: SessionAcademicWeek
            // ==========================================
            cfg.CreateMap<V2SessionAcademicWeek, V3SessionAcademicWeek>(memberListForValidation)
                // ================
                // V2 to v3 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------
                .ForMember(x => x.Extensions, o => o.Ignore())
                
                // --------------------------------
                // V2 Types to V3 Descriptors
                // --------------------------------

                // --------------------------------
                // V2 Descriptors to V3 Descriptors
                // --------------------------------
                ;

            cfg.CreateMap<V3SessionAcademicWeek, V2SessionAcademicWeek>(memberListForValidation)
                // ================
                // V3 to V2 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------

                // --------------------------
                // V3 Descriptors to V2 Types
                // --------------------------

                // --------------------------------
                // V3 Descriptors to V2 Descriptors
                // --------------------------------
            ;

            // ==========================================
            // Mapping: SessionGradingPeriod
            // ==========================================
            cfg.CreateMap<V2SessionGradingPeriod, V3SessionGradingPeriod>(memberListForValidation)
                // ================
                // V2 to v3 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------
                .ForMember(x => x.Extensions, o => o.Ignore())
                .ForMember(x => x.GradingPeriodReference, o => o.Ignore())

                // --------------------------------
                // V2 Types to V3 Descriptors
                // --------------------------------

                // --------------------------------
                // V2 Descriptors to V3 Descriptors
                // --------------------------------
                ;

            cfg.CreateMap<V3SessionGradingPeriod, V2SessionGradingPeriod>(memberListForValidation)
                // ================
                // V3 to V2 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------

                // --------------------------
                // V3 Descriptors to V2 Types
                // --------------------------

                // --------------------------------
                // V3 Descriptors to V2 Descriptors
                // --------------------------------
            ;
            
            // ======================================================
            // Mapping: SessionGradingPeriodToGradingPeriodReference
            // ======================================================
            cfg.CreateMap<V2SessionGradingPeriodToGradingPeriodReference, V3SessionGradingPeriodToGradingPeriodReference>(memberListForValidation)
                // ================
                // V2 to v3 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------
                // V2 does not have a period sequence
                .ForMember(x => x.PeriodSequence, o => o.Ignore())

                // --------------------------------
                // V2 Types to V3 Descriptors
                // --------------------------------

                // --------------------------------
                // V2 Descriptors to V3 Descriptors
                // --------------------------------
                .ForMember(
                    v3 => v3.GradingPeriodDescriptor,
                    o => o.MapFrom(v2 => VersionConverter.DescriptorV2ToV3("GradingPeriodDescriptor", v2.GradingPeriodDescriptor)))
                ;

            cfg.CreateMap<V3SessionGradingPeriodToGradingPeriodReference, V2SessionGradingPeriodToGradingPeriodReference>(memberListForValidation)
                // ================
                // V3 to V2 mapping
                // ================

                // ---------------
                // Ignored members
                // ---------------
                // V3 does not have a begin date
                .ForMember(x => x.BeginDate, o => o.Ignore())

                // --------------------------
                // V3 Descriptors to V2 Types
                // --------------------------
                
                // --------------------------------
                // V3 Descriptors to V2 Descriptors
                // --------------------------------
                .ForMember(
                    v2 => v2.GradingPeriodDescriptor,
                    o => o.MapFrom(v3 => VersionConverter.DescriptorV3ToV2("GradingPeriodDescriptor", v3.GradingPeriodDescriptor)))
            ;
        }

        #region Possible future mappings to be supported
        //private static void CreateSectionMaps(
        //    IMapperConfigurationExpression cfg,
        //    MemberList memberListForValidation = MemberList.Destination)
        //{
        //    cfg.CreateMap<V2Section, V3Section>(memberListForValidation)
        //        .ForMember(v3 => v3.Extensions, o => o.Ignore());

        //    cfg.CreateMap<V3Section, V2Section>(memberListForValidation);

        //    cfg.CreateMap<V2SectionCharacteristic, V3SectionCharacteristic>(memberListForValidation)
        //        .ForMember(v3 => v3.Extensions, o => o.Ignore());

        //    cfg.CreateMap<V3SectionCharacteristic, V2SectionCharacteristic>(memberListForValidation);

        //    //cfg.CreateMap<V2SectionClassPeriod, V3SectionClassPeriod>(memberListForValidation)
        //    //    .ForMember(v3 => v3.Extensions, o => o.Ignore());

        //    //cfg.CreateMap<V3SectionClassPeriod, V2SectionClassPeriod>(memberListForValidation);

        //    //cfg.CreateMap<V2SectionCourseLevelCharacteristic, V3SectionCourseLevelCharacteristic>(memberListForValidation)
        //    //    .ForMember(v3 => v3.Extensions, o => o.Ignore());

        //    //cfg.CreateMap<V3SectionCourseLevelCharacteristic, V2SectionCourseLevelCharacteristic>(memberListForValidation);

        //    //cfg.CreateMap<V2SectionOfferedGradeLevel, V3SectionOfferedGradeLevel>(memberListForValidation)
        //    //    .ForMember(v3 => v3.Extensions, o => o.Ignore());

        //    //cfg.CreateMap<V3SectionOfferedGradeLevel, V2SectionOfferedGradeLevel>(memberListForValidation);

        //    cfg.CreateMap<V2SectionProgram, V3SectionProgram>(memberListForValidation)
        //        .ForMember(v3 => v3.Extensions, o => o.Ignore());

        //    cfg.CreateMap<V3SectionProgram, V2SectionProgram>(memberListForValidation);
        //}

        //private static void CreateProgramMaps(
        //    IMapperConfigurationExpression cfg,
        //    MemberList memberListForValidation = MemberList.Destination)
        //{
        //    cfg.CreateMap<V2Program, V3Program>(memberListForValidation)
        //        .ForMember(v3 => v3.Extensions, o => o.Ignore())
        //        // V2.5 does not define sponsor details
        //        .ForMember(v3 => v3.ProgramSponsors, o => o.Ignore())
        //        .ForMember(
        //            v3 => v3.ProgramTypeDescriptor,
        //            o => o.MapFrom(v2 => VersionConverter.TypeToDescriptor(v2.ProgramType, "ProgramTypeDescriptor")));

        //    cfg.CreateMap<V3Program, V2Program>(memberListForValidation)
        //        .ForMember(
        //            v2 => v2.ProgramType,
        //            o => o.MapFrom(v3 => VersionConverter.DescriptorToType(v3.ProgramTypeDescriptor)));


        //    cfg.CreateMap<V2ProgramCharacteristic, V3ProgramCharacteristic>(memberListForValidation)
        //        .ForMember(v3 => v3.Extensions, o => o.Ignore())
        //        .ForMember(
        //            v3 => v3.ProgramCharacteristicDescriptor,
        //            o => o.MapFrom(v2
        //                => VersionConverter.DescriptorV2ToV3("ProgramCharacteristicDescriptor",
        //                    v2.ProgramCharacteristicDescriptor)));

        //    cfg.CreateMap<V3ProgramCharacteristic, V2ProgramCharacteristic>(memberListForValidation)
        //        .ForMember(
        //            v2 => v2.ProgramCharacteristicDescriptor,
        //            o => o.MapFrom(v3
        //                => VersionConverter.DescriptorV3ToV2("ProgramCharacteristicDescriptor",
        //                    v3.ProgramCharacteristicDescriptor)));


        //    cfg.CreateMap<V2ProgramLearningObjective, V3ProgramLearningObjective>(memberListForValidation)
        //        .ForMember(v3 => v3.Extensions, o => o.Ignore());

        //    cfg.CreateMap<V3ProgramLearningObjective, V2ProgramLearningObjective>(memberListForValidation);

        //    cfg.CreateMap<V2ProgramLearningStandard, V3ProgramLearningStandard>(memberListForValidation)
        //        .ForMember(v3 => v3.Extensions, o => o.Ignore());

        //    cfg.CreateMap<V3ProgramLearningStandard, V2ProgramLearningStandard>(memberListForValidation);

        //    cfg.CreateMap<V2ProgramService, V3ProgramService>(memberListForValidation)
        //        .ForMember(v3 => v3.Extensions, o => o.Ignore());

        //    cfg.CreateMap<V3ProgramService, V2ProgramService>(memberListForValidation);

        //    //cfg.CreateMap<V2ProgramSponsor, V3ProgramSponsor>(memberListForValidation)
        //    //    .ForMember(v3 => v3.Extensions, o => o.Ignore());

        //    //cfg.CreateMap<V3ProgramSponsor, V2ProgramSponsor>(memberListForValidation);
        //}

        //private static void CreateEducationOrganizationMaps(
        //    IMapperConfigurationExpression cfg,
        //    MemberList memberListForValidation = MemberList.Destination)
        //{
        //    cfg.CreateMap<V2EducationOrganizationAddress, V3EducationOrganizationAddress>(memberListForValidation)
        //        .ForMember(v3 => v3.Extensions, o => o.Ignore());

        //    cfg.CreateMap<V3EducationOrganizationAddress, V2EducationOrganizationAddress>(memberListForValidation);

        //    //cfg.CreateMap<V2EducationOrganizationAddressPeriod, V3EducationOrganizationAddressPeriod>(memberListForValidation)
        //    //    .ForMember(v3 => v3.Extensions, o => o.Ignore());

        //    //cfg.CreateMap<V3EducationOrganizationAddressPeriod, V2EducationOrganizationAddressPeriod>(memberListForValidation);

        //    cfg.CreateMap<V2EducationOrganizationCategory, V3EducationOrganizationCategory>(memberListForValidation)
        //        .ForMember(v3 => v3.Extensions, o => o.Ignore());

        //    cfg.CreateMap<V3EducationOrganizationCategory, V2EducationOrganizationCategory>(memberListForValidation);

        //    cfg.CreateMap<V2EducationOrganizationIdentificationCode, V3EducationOrganizationIdentificationCode>(memberListForValidation)
        //        .ForMember(v3 => v3.Extensions, o => o.Ignore());

        //    cfg.CreateMap<V3EducationOrganizationIdentificationCode, V2EducationOrganizationIdentificationCode>(memberListForValidation);

        //    cfg.CreateMap<V2EducationOrganizationInstitutionTelephone, V3EducationOrganizationInstitutionTelephone>(memberListForValidation)
        //        .ForMember(v3 => v3.Extensions, o => o.Ignore());

        //    cfg.CreateMap<V3EducationOrganizationInstitutionTelephone, V2EducationOrganizationInstitutionTelephone>(memberListForValidation);

        //    cfg.CreateMap<V2EducationOrganizationInternationalAddress, V3EducationOrganizationInternationalAddress>(memberListForValidation)
        //        .ForMember(v3 => v3.Extensions, o => o.Ignore());

        //    cfg.CreateMap<V3EducationOrganizationInternationalAddress, V2EducationOrganizationInternationalAddress>(memberListForValidation);
        //}

        //private static void CreateSchoolMaps(
        //    IMapperConfigurationExpression cfg,
        //    MemberList memberListForValidation = MemberList.Destination)
        //{
        //    cfg.CreateMap<V2School, V3School>(memberListForValidation)
        //        .ForMember(v3 => v3.Extensions, o => o.Ignore());

        //    cfg.CreateMap<V3School, V2School>(memberListForValidation);

        //    cfg.CreateMap<V2SchoolCategory, V3SchoolCategory>(memberListForValidation)
        //        .ForMember(v3 => v3.Extensions, o => o.Ignore());

        //    cfg.CreateMap<V3SchoolCategory, V2SchoolCategory>(memberListForValidation);

        //    cfg.CreateMap<V2SchoolGradeLevel, V3SchoolGradeLevel>(memberListForValidation)
        //        .ForMember(v3 => v3.Extensions, o => o.Ignore());

        //    cfg.CreateMap<V3SchoolGradeLevel, V2SchoolGradeLevel>(memberListForValidation);
        //}

        //private static void CreateLocalEducationAgencyMaps(
        //    IMapperConfigurationExpression cfg,
        //    MemberList memberListForValidation = MemberList.Destination)
        //{
        //    cfg.CreateMap<V2LocalEducationAgency, V3LocalEducationAgency>(memberListForValidation)
        //        .ForMember(v3 => v3.Extensions, o => o.Ignore());

        //    cfg.CreateMap<V3LocalEducationAgency, V2LocalEducationAgency>(memberListForValidation);

        //    cfg.CreateMap<V2LocalEducationAgencyAccountability, V3LocalEducationAgencyAccountability>(memberListForValidation)
        //        .ForMember(v3 => v3.Extensions, o => o.Ignore());

        //    cfg.CreateMap<V3LocalEducationAgencyAccountability, V2LocalEducationAgencyAccountability>(memberListForValidation);

        //    //cfg.CreateMap<V2LocalEducationAgencyFederalFunds, V3LocalEducationAgencyFederalFunds>(memberListForValidation)
        //    //    .ForMember(v3 => v3.Extensions, o => o.Ignore());

        //    //cfg.CreateMap<V3LocalEducationAgencyFederalFunds, V2LocalEducationAgencyFederalFunds>(memberListForValidation);
        //}
        #endregion
    }
}