using NUnit.Framework;

namespace ToDo.Specs
{
    public class When_adding_two_numbers : ContextSpecification
    {
        protected override void EstablishContext()
        {
            x = 1;
            y = 1;
        }

        protected override void Because()
        {
            result = x + y;
        }

        [Test]
        public void should_set_result_to_sum()
        {
            result.ShouldEqual(x + y);
        }

        private int x;
        private int y;
        private int result; 
    }
}