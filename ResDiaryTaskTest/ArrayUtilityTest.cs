using ResDiaryTask;
namespace ResDiaryTaskTest;

[TestFixture]
public class ArrayUtilityTest
{

    private ArrayUtility groupArray;
    private static IEnumerable<TestCaseData> intdata
    {
        get
        {
            yield return new TestCaseData(new int[] { 1, 2, 3, 4, 5 }, 3, new int[][]
            {
                new int[]{1,2},
                new int[]{3,4},
                new int[]{5}
            });
            yield return new TestCaseData(new int[] { 1, 2, 3, 4, 5, 6 }, 2, new int[][]
            {
                new int[]{1,2},
                new int[]{3,4},
                new int[]{5,6}
            });
        }
    }
    private static IEnumerable<TestCaseData> stringData
    {
        get
        {
            yield return new TestCaseData(new string[] { "Arslan", "Scott", "Owain", "Ben", "Einstein" }, 3, new string[][]
            {
                new string[]{"Arslan", "Scott"},
                new string[]{"Owain","Ben"},
                new string[]{ "Einstein" }
            });
            yield return new TestCaseData(new string[] { "Arslan", "Scott", "Owain", "Ben", "Einstein", "Newton" }, 2, new string[][]
            {
                new string[]{"Arslan", "Scott"},
                new string[]{"Owain","Ben"},
                new string[]{"Einstein", "Newton" }
            });
            yield return new TestCaseData(new string[] { "Arslan", "Scott", "Owain", "Ben", "Einstein", "Newton" }, 3, new string[][]
            {
                new string[]{"Arslan", "Scott","Owain" },
                new string[]{ "Ben", "Einstein", "Newton" }
            });
        }
    }


    [SetUp]
    public void Setup()
    {
        groupArray = new ArrayUtility();

    }
    [Test]
    [TestCaseSource(nameof(intdata))]
    public void intDataTest(int[] input, int shape, int[][] output)
    {
        Assert.That(groupArray.groupArrayElements(input, shape), Is.EqualTo(output));
    }
    [Test]
    [TestCaseSource(nameof(stringData))]
    public void stringDataTest(string[] input, int shape, string[][] output)
    {
        Assert.That(groupArray.groupArrayElements(input, shape), Is.EqualTo(output));
    }

}
