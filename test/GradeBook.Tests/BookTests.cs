using System;
using Xunit;

namespace GradeBook.Tests;

public class BookTests
{
    Book book;
    double expected_sum;
    double expected_min;
    double expected_max;
    int expected_cnt;
    double expected_avg;
    double[] grades;
    public BookTests()
    {
        this.book = new Book("Cloud College");
        grades = new double[] { 89.1, 90.5, 77.3 };
        this.expected_min = double.MaxValue;
        this.expected_max = double.MinValue;
        this.expected_cnt = 0;
        foreach (double grade in grades)
        {
            this.book.AddGrade(grade);
            this.expected_sum += grade;
            this.expected_cnt++;
            if (grade < this.expected_min)
            {
                this.expected_min = grade;
            }
            if (grade > this.expected_max)
            {
                this.expected_max = grade;
            }
        }
        this.expected_avg = this.expected_sum / this.expected_cnt;
    }

    [Fact]
    public void TestMinimum()
    {
        double calc_min = book.MinGrade();
        Assert.Equal(this.expected_min, calc_min, 1);
    }

    [Fact]
    public void TestMaximum()
    {
        double calc_max = book.MaxGrade();
        Assert.Equal(this.expected_max, calc_max, 1);
    }

    [Fact]
    public void TestSum()
    {
        double calc_sum = book.SumGrades();
        Assert.Equal(this.expected_sum, calc_sum, 1);
    }

    [Fact]
    public void TestCount()
    {
        int calc_cnt = book.CountGrades();
        Assert.Equal(this.expected_cnt, calc_cnt);
    }

    [Fact]
    public void TestAvg()
    {
        double calc_avg = book.CalculateAverage();
        Assert.Equal(this.expected_avg, calc_avg, 1);
    }
}