using FBEECSEE.Library.util.functional;
using Moq;
using NUnit.Framework;

namespace FBEECSEE.Library.Tests.util.functional
{
    [TestFixture]
    public class FunctionalIfTeeExtensionTests
    {
        private Action a = () => { };
        private Func<bool> con = () => true;
        private bool co = true;

        [SetUp]
        public void Setup()
        {
        }

        [TestCase]
        public void Syntax_ShouldNotThrow()
        {
            If.Tee().If(con, a).Run();
            If.Tee().If(con, a).ElseIf(con, a).Run();
            If.Tee().If(con, a).Else(a).Run();
            If.Tee().If(con, a).ElseIf(con, a).Else(a).Run();

            If.Tee().IfRun(con, a);
            If.Tee().If(con, a).ElseIfRun(con, a);
            If.Tee().If(con, a).ElseRun(a);
            If.Tee().If(con, a).ElseIf(con, a).ElseRun(a);

            If.Tee().If(co, a).Run();
            If.Tee().If(co, a).ElseIf(co, a).Run();
            If.Tee().If(co, a).Else(a).Run();
            If.Tee().If(co, a).ElseIf(co, a).Else(a).Run();

            If.Tee().IfRun(co, a);
            If.Tee().If(co, a).ElseIfRun(co, a);
            If.Tee().If(co, a).ElseRun(a);
            If.Tee().If(co, a).ElseIf(co, a).ElseRun(a);
        }

        [TestCase]
        public void BadSyntax_ElseIfBeforeIf_ShouldThrow()
        {
            Assert.Throws<ArgumentException>(() => { If.Tee().ElseIf(con, a).If(con, a); });
        }

        [TestCase]
        public void BadSyntax_ElseBeforeIf_ShouldThrow()
        {
            Assert.Throws<ArgumentException>(() => { If.Tee().Else(a).If(con, a); });
        }

        [TestCase]
        public void BadSyntax_ElseBeforeElseIf_ShouldThrow()
        {
            Assert.Throws<ArgumentException>(() => { If.Tee().If(con, a).Else(a).ElseIf(con, a); });
        }

        [TestCase]
        public void If_TrueSingleIf_ShouldRun()
        {
            var method = new Mock<Action>();

            If.Tee().IfRun(true, method.Object);

            method.Verify(a => a.Invoke(), Times.Once);
        }

        [TestCase]
        public void If_FalseSingleIf_ShouldNotRun()
        {
            var method = new Mock<Action>();

            If.Tee().IfRun(false, method.Object);

            method.Verify(a => a.Invoke(), Times.Never);
        }

        [TestCase]
        public void If_IfTrue_ElseIfElseShouldNotRun()
        {
            var ifMethod = new Mock<Action>();
            var elseIfMethod = new Mock<Action>();
            var elseMethod = new Mock<Action>();

            If.Tee().If(true, ifMethod.Object).ElseIf(true, elseIfMethod.Object).ElseRun(elseMethod.Object);

            ifMethod.Verify(a => a.Invoke(), Times.Once);
            elseIfMethod.Verify(a => a.Invoke(), Times.Never);
            elseMethod.Verify(a => a.Invoke(), Times.Never);
        }

        [TestCase]
        public void If_ElseIfTrue_IfAndElseShouldNotRun()
        {
            var ifMethod = new Mock<Action>();
            var elseIfMethod = new Mock<Action>();
            var elseMethod = new Mock<Action>();

            If.Tee().If(false, ifMethod.Object).ElseIf(true, elseIfMethod.Object).ElseRun(elseMethod.Object);

            ifMethod.Verify(a => a.Invoke(), Times.Never);
            elseIfMethod.Verify(a => a.Invoke(), Times.Once);
            elseMethod.Verify(a => a.Invoke(), Times.Never);
        }

        [TestCase]
        public void If_False_IfAndElseIfShouldNotRun()
        {
            var ifMethod = new Mock<Action>();
            var elseIfMethod = new Mock<Action>();
            var elseMethod = new Mock<Action>();

            If.Tee().If(false, ifMethod.Object).ElseIf(false, elseIfMethod.Object).ElseRun(elseMethod.Object);

            ifMethod.Verify(a => a.Invoke(), Times.Never);
            elseIfMethod.Verify(a => a.Invoke(), Times.Never);
            elseMethod.Verify(a => a.Invoke(), Times.Once);
        }

        [TestCase]
        public void If_TwoElseIfTrueFalse_FirstShouldRun()
        {
            var ifMethod = new Mock<Action>();
            var elseIfMethod1 = new Mock<Action>();
            var elseIfMethod2 = new Mock<Action>();

            If.Tee().If(false, ifMethod.Object)
                .ElseIf(true, elseIfMethod1.Object)
                .ElseIfRun(true, elseIfMethod2.Object);

            ifMethod.Verify(a => a.Invoke(), Times.Never);
            elseIfMethod1.Verify(a => a.Invoke(), Times.Once);
            elseIfMethod2.Verify(a => a.Invoke(), Times.Never);
        }

        [TestCase]
        public void If_TwoElseIf_SecondShouldRun()
        {
            var ifMethod = new Mock<Action>();
            var elseIfMethod1 = new Mock<Action>();
            var elseIfMethod2 = new Mock<Action>();

            If.Tee().If(false, ifMethod.Object)
                .ElseIf(false, elseIfMethod1.Object)
                .ElseIfRun(true, elseIfMethod2.Object);

            ifMethod.Verify(a => a.Invoke(), Times.Never);
            elseIfMethod1.Verify(a => a.Invoke(), Times.Never);
            elseIfMethod2.Verify(a => a.Invoke(), Times.Once);
        }

        [TestCase]
        public void If_IfBuilderCreatesTwo_ShouldRunSeparately()
        {
            var ifMethod = new Mock<Action>();
            var elseIfMethod = new Mock<Action>();
            var elseMethod = new Mock<Action>();

            var b = If.Tee().If(false, ifMethod.Object).ElseIf(false, elseIfMethod.Object).Else(elseMethod.Object);

            b.Run();
            b.Run();

            ifMethod.Verify(a => a.Invoke(), Times.Never);
            elseIfMethod.Verify(a => a.Invoke(), Times.Never);
            elseMethod.Verify(a => a.Invoke(), Times.Exactly(2));
        }

        [TestCase]
        public void If_RunIfTwice_DoesNotThrows()
        {
            var ifMethod = new Mock<Action>();
            var elseMethod = new Mock<Action>();

            var i = If.Tee().If(false, ifMethod.Object).Else(elseMethod.Object);

            i.Run();
            Assert.DoesNotThrow(() => i.Run());

            ifMethod.Verify(a => a.Invoke(), Times.Never);
            elseMethod.Verify(a => a.Invoke(), Times.Exactly(2));
        }
    }
}