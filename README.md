# ResDiaryTask
## Problem Statement
The goal of this exercise is to write some executable code.
We hope that you will not find this particularly difficult and it should not take more than one hour. However, please treat
this task as though you were writing production-ready code that will be maintained by others, who may or may not
have been familiar with the original requirement.
We do not require a user-facing interface of any kind. You should implement a function or class that can be called on to
provide the following behaviour:
Given an array of length >= 0, and a positive integer N, return the contents of the array divided into N equally sized
arrays.
Where the size of the original array cannot be divided equally by N, the final part should have a length equal to the
remainder.
Please do not import and use a library that specifically handles this requirement. While you may do this in practice, we
would like to see how you handle the solution through your logic and code implementation.
Example pseudo-code:
groupArrayElements([1, 2, 3, 4, 5], 3);
// [ [ 1, 2 ], [ 3, 4 ], [ 5 ] ]

## Solution 
Clone this project and open in Visual Studio
Test of this class is in ResDiaryTaskTest folder with the file name ArrayUtilityTest.cs 
The test are written using the NUnit testing framework. If you run the test from debug-> run test option you will find all 5 tests are passing
