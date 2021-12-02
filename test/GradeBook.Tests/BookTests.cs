using System;
using Xunit;

namespace GradeBook.Tests;

public class BookTests
{
    [Fact]
    public void StatsTest()
    {
        //arrange - set vars
        Book book = new Book("Cloud College");
        book.AddGrade(89.1);
        book.AddGrade(90.5);
        book.AddGrade(77.3);

        //act - perform computations
        double calc_min = book.MinGrade();
        double calc_max = book.MaxGrade();
        double calc_sum = book.SumGrades();
        int calc_cnt = book.CountGrades();
        double calc_avg = book.CalculateAverage();

        double expect_min = 77.3;
        double expect_max = 90.5;
        double expect_sum = 90.5 + 89.1 + 77.3;
        int expect_cnt = 3;
        double expect_avg = expect_sum / expect_cnt;

        //assert - assert results
        Assert.Equals(expect_min, calc_min);
        Assert.Equals(expect_max, calc_max);
        Assert.Equals(expect_sum, calc_sum);
        Assert.Equals(expect_cnt, calc_cnt);
        Assert.Equals(expect_avg, calc_avg);
    }
}