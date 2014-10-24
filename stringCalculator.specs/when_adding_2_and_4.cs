using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Machine.Specifications;

namespace stringCalculator.specs
{
    public class when_adding_2_and_4
    {
        Establish context =
            () =>
                {
                    _stringCalculator = new StringCalculator();
                    _expectedResult = 6;
                };

        Because of =
            () => _result = _stringCalculator.Calculate(_parameter);

        It should_return_6 =
            () => _result.ShouldEqual(_expectedResult);

        static StringCalculator _stringCalculator;
        static string _parameter = "2+4";
        static int _result;
        static int _expectedResult;
    }
}
