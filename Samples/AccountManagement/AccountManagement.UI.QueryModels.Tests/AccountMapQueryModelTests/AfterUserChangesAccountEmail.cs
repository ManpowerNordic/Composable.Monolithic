﻿using AccountManagement.TestHelpers.Scenarios;
using Castle.MicroKernel.Lifestyle;
using FluentAssertions;
using NUnit.Framework;

namespace AccountManagement.UI.QueryModels.Tests.AccountMapQueryModelTests
{
    [TestFixture]
    public class AfterUserChangesAccountEmail : RegistersAccountDuringSetupTestBase
    {
        private ChangeAccountEmailScenario _scenario;

        [SetUp]
        public void ChangeAccountEmail()
        {
            _scenario = new ChangeAccountEmailScenario(Container, RegisteredAccount);
            _scenario.Execute();
            ReplaceContainerScope();
        }

        [Test]
        public void EmailIsTheOneFromTheEvent()
        {
            GetAccountQueryModel().Email.Should().Be(_scenario.NewEmail);
        }
    }
}
