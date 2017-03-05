using System;

using FluentAssertions;
using Machine.Specifications;

namespace AppVeyorProject {

  [Subject("Math are fun")]
  public class When_making_a_sum {

    static int operandOne = 9;
    static int operandTwo = 5;
    static int sum = 0;

    Establish context = () => {
      operandOne = 9;
      operandTwo = 5;
    };

    Because of = 
      () => sum = Mathy.Sum(operandOne, operandTwo);

    It should_be_true_that_operandOne_must_be_sum_minus_operandTwo =
      () => operandOne.Should().Be(sum - operandTwo);

    It should_be_true_that_operandTwo_must_be_sum_minus_operandOne =
      () => operandTwo.Should().Be(sum - operandOne);
  }


  //[Subject("Math are fun 2")]
  //public class When_making_a_sum2 {

  //  public void TestSum() {
  //    int operandOne = 9;
  //    int operandTwo = 5;

  //    int sum = Mathy.Sum(operandOne, operandTwo);

  //    Assert.Equals(sum, operandOne + operandTwo, "Sum must be operand one plus operand two.");

  //    Assert.Equals(operandOne, sum - operandTwo, "Sum must be operand one plus operand two.");

  //    Assert.Equals(operandTwo, sum - operandOne, "Sum must be operand one plus operand two.");

  //  }

  //  }

}
