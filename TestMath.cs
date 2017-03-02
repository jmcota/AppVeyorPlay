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
  }

}
