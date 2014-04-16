/* Copyright 2014 Rick Hansen Institute
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 * http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
*/
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhi.Isncsci;

namespace GettingStarted
{
    [TestClass]
    public class AlgorithmTests
    {
        [TestMethod]
        public void GetTotalsForNeurologyForm()
        {
            // Arrange
            var neurologyForm = new NeurologyForm()
            {
                AnalContraction = BinaryObservation.No,
                AnalSensation = BinaryObservation.Yes
            };

            neurologyForm.UpdateLevelAt("C2", "2", "2", "2", "2", "0", "0");
            neurologyForm.UpdateLevelAt("C3", "2", "2", "2", "2", "0", "0");
            neurologyForm.UpdateLevelAt("C4", "2", "2", "2", "2", "0", "0");
            neurologyForm.UpdateLevelAt("C5", "2", "2", "2", "2", "5", "5");
            neurologyForm.UpdateLevelAt("C6", "1", "1", "1", "0", "1", "1");
            neurologyForm.UpdateLevelAt("C7", "1", "0", "1", "0", "0", "0");
            neurologyForm.UpdateLevelAt("C8", "1", "0", "1", "0", "0", "0");
            neurologyForm.UpdateLevelAt("T1", "1", "0", "1", "0", "0", "0");
            neurologyForm.UpdateLevelAt("T2", "NT", "NT", "NT", "NT", "0", "0");
            neurologyForm.UpdateLevelAt("T3", "NT", "NT", "NT", "NT", "0", "0");
            neurologyForm.UpdateLevelAt("T4", "NT", "NT", "NT", "NT", "0", "0");
            neurologyForm.UpdateLevelAt("T5", "NT", "NT", "NT", "NT", "0", "0");
            neurologyForm.UpdateLevelAt("T6", "NT", "NT", "NT", "NT", "0", "0");
            neurologyForm.UpdateLevelAt("T7", "NT", "NT", "NT", "NT", "0", "0");
            neurologyForm.UpdateLevelAt("T8", "NT", "NT", "NT", "NT", "0", "0");
            neurologyForm.UpdateLevelAt("T9", "NT", "NT", "NT", "NT", "0", "0");
            neurologyForm.UpdateLevelAt("T10", "NT", "NT", "NT", "NT", "0", "0");
            neurologyForm.UpdateLevelAt("T11", "NT", "NT", "NT", "NT", "0", "0");
            neurologyForm.UpdateLevelAt("T12", "NT", "NT", "NT", "NT", "0", "0");
            neurologyForm.UpdateLevelAt("L1", "NT", "NT", "NT", "NT", "0", "0");
            neurologyForm.UpdateLevelAt("L2", "NT", "NT", "NT", "NT", "NT", "NT");
            neurologyForm.UpdateLevelAt("L3", "NT", "NT", "NT", "NT", "NT", "NT");
            neurologyForm.UpdateLevelAt("L4", "NT", "NT", "NT", "NT", "NT", "NT");
            neurologyForm.UpdateLevelAt("L5", "NT", "NT", "NT", "NT", "NT", "NT");
            neurologyForm.UpdateLevelAt("S1", "NT", "NT", "NT", "NT", "NT", "NT");
            neurologyForm.UpdateLevelAt("S2", "NT", "NT", "NT", "NT", "0", "0");
            neurologyForm.UpdateLevelAt("S3", "NT", "NT", "NT", "NT", "0", "0");
            neurologyForm.UpdateLevelAt("S4_5", "NT", "NT", "NT", "NT", "0", "0");

            // Act 
            var summary = Algorithm.GetTotalsSummaryFor(neurologyForm);

            // Assert
            Assert.AreEqual("B,C,D", summary.AsiaImpairmentScale);
            Assert.AreEqual("I", summary.Completeness);
            Assert.AreEqual("UTD", summary.LeftLowerMotorTotal);
            Assert.AreEqual("C5", summary.LeftMotor);
            Assert.AreEqual("UTD", summary.LeftMotorTotal);
            Assert.AreEqual("NA", summary.LeftMotorZpp);
            Assert.AreEqual("UTD", summary.LeftPrickTotal);
            Assert.AreEqual("C5", summary.LeftSensory);
            Assert.AreEqual("NA", summary.LeftSensoryZpp);
            Assert.AreEqual("UTD", summary.LeftTouchTotal);
            Assert.AreEqual("6", summary.LeftUpperMotorTotal);
            Assert.AreEqual("UTD", summary.LowerMotorTotal);
            Assert.AreEqual("C5", summary.NeurologicalLevelOfInjury);
            Assert.AreEqual("UTD", summary.PrickTotal);
            Assert.AreEqual("UTD", summary.RightLowerMotorTotal);
            Assert.AreEqual("C5", summary.RightMotor);
            Assert.AreEqual("UTD", summary.RightMotorTotal);
            Assert.AreEqual("NA", summary.RightMotorZpp);
            Assert.AreEqual("UTD", summary.RightPrickTotal);
            Assert.AreEqual("C5", summary.RightSensory);
            Assert.AreEqual("NA", summary.RightSensoryZpp);
            Assert.AreEqual("UTD", summary.RightTouchTotal);
            Assert.AreEqual("6", summary.RightUpperMotorTotal);
            Assert.AreEqual("UTD", summary.TouchTotal);
            Assert.AreEqual("12", summary.UpperMotorTotal);
        }
    }
}