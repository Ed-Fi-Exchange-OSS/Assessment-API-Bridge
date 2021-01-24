using EdFi.Ods.AssessmentBridge.WebApi.Mapping;
using NUnit.Framework;
using Shouldly;

using V2Assessment = EdFi.Ods.Api.Models.Resources.V2.Assessment.Assessment;
using V3Assessment = EdFi.Ods.Api.Models.Resources.V3.Assessment.EdFi.Assessment;

using V2AssessmentReference = EdFi.Ods.Api.Models.Resources.V2.Assessment.AssessmentReference;
using V3AssessmentReference = EdFi.Ods.Api.Models.Resources.V3.Assessment.EdFi.AssessmentReference;

using V2AssessmentItemReference = EdFi.Ods.Api.Models.Resources.V2.AssessmentItem.AssessmentItemReference;
using V3AssessmentItemReference = EdFi.Ods.Api.Models.Resources.V3.AssessmentItem.EdFi.AssessmentItemReference;

using V2LearningObjective = EdFi.Ods.Api.Models.Resources.V2.LearningObjective.LearningObjective;
using V3LearningObjective = EdFi.Ods.Api.Models.Resources.V3.LearningObjective.EdFi.LearningObjective;

using V2LearningObjectiveReference = EdFi.Ods.Api.Models.Resources.V2.LearningObjective.LearningObjectiveReference;
using V3LearningObjectiveReference = EdFi.Ods.Api.Models.Resources.V3.LearningObjective.EdFi.LearningObjectiveReference;

using V2LearningStandard = EdFi.Ods.Api.Models.Resources.V2.LearningStandard.LearningStandard;
using V3LearningStandard = EdFi.Ods.Api.Models.Resources.V3.LearningStandard.EdFi.LearningStandard;

using V2ObjectiveAssessmentReference = EdFi.Ods.Api.Models.Resources.V2.ObjectiveAssessment.ObjectiveAssessmentReference;
using V3ObjectiveAssessmentReference = EdFi.Ods.Api.Models.Resources.V3.ObjectiveAssessment.EdFi.ObjectiveAssessmentReference;

using V2StudentAssessmentReference = EdFi.Ods.Api.Models.Resources.V2.StudentAssessment.StudentAssessmentReference;
using V3StudentAssessmentReference = EdFi.Ods.Api.Models.Resources.V3.StudentAssessment.EdFi.StudentAssessmentReference;

namespace EdFi.Ods.AssessmentBridge.Tests
{
    [TestFixture]
    public class NamespacePropertyTests
    {
        [TestFixture]
        public class When_mapping_Assessment_domain_Namespace_property_values_from_V2_to_V3
            : TestFixtureBase
        {
            private V3Assessment _actualV3Assessment;
            private V3AssessmentReference _actualV3AssessmentReference;
            private V3AssessmentItemReference _actualV3AssessmentItemReference;
            private V3LearningObjective _actualV3LearningObjective;
            private V3LearningStandard _actualV3LearningStandard;
            private V3LearningObjectiveReference _actualV3LearningObjectiveReference;
            private V3ObjectiveAssessmentReference _actualV3ObjectiveAssessmentReference;
            private V3StudentAssessmentReference _actualV3StudentAssessmentReference;

            protected override void Act()
            {
                var mapper = MappingFactory.CreateMapper();
                
                _actualV3Assessment = mapper.Map<V3Assessment>(
                        new V2Assessment { Namespace = "abc://something.org/something/" });

                _actualV3AssessmentReference = mapper.Map<V3AssessmentReference>(
                    new V2AssessmentReference { Namespace = "abc://something.org/something/" });

                _actualV3AssessmentItemReference = mapper.Map<V3AssessmentItemReference>(
                    new V2AssessmentItemReference { Namespace = "abc://something.org/something/" });

                _actualV3LearningObjective = mapper.Map<V3LearningObjective>(
                    new V2LearningObjective { Namespace = "abc://something.org/something/" });

                _actualV3LearningObjectiveReference = mapper.Map<V3LearningObjectiveReference>(
                    new V2LearningObjectiveReference { Namespace = "abc://something.org/something/" });

                _actualV3LearningStandard = mapper.Map<V3LearningStandard>(
                    new V2LearningStandard { Namespace = "abc://something.org/something/" });

                _actualV3ObjectiveAssessmentReference = mapper.Map<V3ObjectiveAssessmentReference>(
                    new V2ObjectiveAssessmentReference { Namespace = "abc://something.org/something/" });

                _actualV3StudentAssessmentReference = mapper.Map<V3StudentAssessmentReference>(
                    new V2StudentAssessmentReference { Namespace = "abc://something.org/something/" });
            }

            [Test]
            public void Should_convert_Assessment_Namespace_to_use_idiomatic_V3_uri_scheme()
            {
                _actualV3Assessment.Namespace.ShouldBe("uri://something.org/something/");
            }
            
            [Test]
            public void Should_convert_AssessmentReference_Namespace_to_use_idiomatic_V3_uri_scheme()
            {
                _actualV3AssessmentReference.Namespace.ShouldBe("uri://something.org/something/");
            }

            [Test]
            public void Should_convert_AssessmentItemReference_Namespace_to_use_idiomatic_V3_uri_scheme()
            {
                _actualV3AssessmentItemReference.Namespace.ShouldBe("uri://something.org/something/");
            }

            [Test]
            public void Should_convert_LearningObjective_Namespace_to_use_idiomatic_V3_uri_scheme()
            {
                _actualV3LearningObjective.Namespace.ShouldBe("uri://something.org/something/");
            }

            [Test]
            public void Should_convert_LearningObjectiveReference_Namespace_to_use_idiomatic_V3_uri_scheme()
            {
                _actualV3LearningObjectiveReference.Namespace.ShouldBe("uri://something.org/something/");
            }

            [Test]
            public void Should_convert_LearningStandard_Namespace_to_use_idiomatic_V3_uri_scheme()
            {
                _actualV3LearningStandard.Namespace.ShouldBe("uri://something.org/something/");
            }
            
            [Test]
            public void Should_convert_ObjectiveAssessmentReference_Namespace_to_use_idiomatic_V3_uri_scheme()
            {
                _actualV3ObjectiveAssessmentReference.Namespace.ShouldBe("uri://something.org/something/");
            }

            [Test]
            public void Should_convert_StudentAssessmentReference_Namespace_to_use_idiomatic_V3_uri_scheme()
            {
                _actualV3StudentAssessmentReference.Namespace.ShouldBe("uri://something.org/something/");
            }
        }

        [TestFixture]
        public class When_mapping_Assessment_domain_Namespace_property_values_from_V3_to_V2
            : TestFixtureBase
        {
            private V2Assessment _actualV2Assessment;
            private V2AssessmentReference _actualV2AssessmentReference;
            private V2AssessmentItemReference _actualV2AssessmentItemReference;
            private V2LearningObjective _actualV2LearningObjective;
            private V2LearningStandard _actualV2LearningStandard;
            private V2LearningObjectiveReference _actualV2LearningObjectiveReference;
            private V2ObjectiveAssessmentReference _actualV2ObjectiveAssessmentReference;
            private V2StudentAssessmentReference _actualV2StudentAssessmentReference;

            protected override void Act()
            {
                var mapper = MappingFactory.CreateMapper();
                
                _actualV2Assessment = mapper.Map<V2Assessment>(
                        new V3Assessment { Namespace = "abc://something.org/something/" });

                // TODO: AssessmentReference, LearningObjectiveReference, ObjectiveAssessmentReference, StudentAssessmentReference
                // Out of Scope: StudentLearningObjectiveReference
                
                _actualV2AssessmentReference = mapper.Map<V2AssessmentReference>(
                    new V3AssessmentReference { Namespace = "abc://something.org/something/" });

                _actualV2AssessmentItemReference = mapper.Map<V2AssessmentItemReference>(
                    new V3AssessmentItemReference { Namespace = "abc://something.org/something/" });

                _actualV2LearningObjective = mapper.Map<V2LearningObjective>(
                    new V3LearningObjective { Namespace = "abc://something.org/something/" });

                _actualV2LearningObjectiveReference = mapper.Map<V2LearningObjectiveReference>(
                    new V3LearningObjectiveReference { Namespace = "abc://something.org/something/" });

                _actualV2LearningStandard = mapper.Map<V2LearningStandard>(
                    new V3LearningStandard { Namespace = "abc://something.org/something/" });

                _actualV2ObjectiveAssessmentReference = mapper.Map<V2ObjectiveAssessmentReference>(
                    new V3ObjectiveAssessmentReference { Namespace = "abc://something.org/something/" });

                _actualV2StudentAssessmentReference = mapper.Map<V2StudentAssessmentReference>(
                    new V3StudentAssessmentReference { Namespace = "abc://something.org/something/" });
            }

            [Test]
            public void Should_convert_Assessment_Namespace_to_use_idiomatic_V2_uri_scheme()
            {
                _actualV2Assessment.Namespace.ShouldBe("http://something.org/something/");
            }
            
            [Test]
            public void Should_convert_AssessmentReference_Namespace_to_use_idiomatic_V2_uri_scheme()
            {
                _actualV2AssessmentReference.Namespace.ShouldBe("http://something.org/something/");
            }

            [Test]
            public void Should_convert_AssessmentItemReference_Namespace_to_use_idiomatic_V2_uri_scheme()
            {
                _actualV2AssessmentItemReference.Namespace.ShouldBe("http://something.org/something/");
            }

            [Test]
            public void Should_convert_LearningObjective_Namespace_to_use_idiomatic_V2_uri_scheme()
            {
                _actualV2LearningObjective.Namespace.ShouldBe("http://something.org/something/");
            }

            [Test]
            public void Should_convert_LearningObjectiveReference_Namespace_to_use_idiomatic_V2_uri_scheme()
            {
                _actualV2LearningObjectiveReference.Namespace.ShouldBe("http://something.org/something/");
            }

            [Test]
            public void Should_convert_LearningStandard_Namespace_to_use_idiomatic_V2_uri_scheme()
            {
                _actualV2LearningStandard.Namespace.ShouldBe("http://something.org/something/");
            }
            
            [Test]
            public void Should_convert_ObjectiveAssessmentReference_Namespace_to_use_idiomatic_V2_uri_scheme()
            {
                _actualV2ObjectiveAssessmentReference.Namespace.ShouldBe("http://something.org/something/");
            }

            [Test]
            public void Should_convert_StudentAssessmentReference_Namespace_to_use_idiomatic_V2_uri_scheme()
            {
                _actualV2StudentAssessmentReference.Namespace.ShouldBe("http://something.org/something/");
            }
        }
    }
}