namespace ResDiaryTask;

public class ArrayUtility
{
    /*Requirement 
     Example pseudo-code:
        groupArrayElements([1, 2, 3, 4, 5], 3);
        output: [ [ 1, 2 ], [ 3, 4 ], [ 5 ] ]
    */
    public T[][] groupArrayElements<T>(T[] inputArray, int outputShape)
    {
        #region Requirement 1 statement about output shape
        /*
         * Given an array of length >= 0, and a positive integer N, 
           return the contents of the array divided into N equally sized arrays
         * Where the size of the original array cannot be divided equally by N, 
           the final part should have a length equal to the remainder.
        */
        #endregion
        var size = (inputArray.Length % outputShape == 0) ? outputShape : inputArray.Length % outputShape;
        List<T[]> groupArrays = new List<T[]>();
        var condition = inputArray.Length % size == 0 ? inputArray.Length / size : inputArray.Length / size + 1;
        for (int i = 0; i < condition; i++)
        {
            var temparr = (i == condition - 1) ? new T[inputArray.Length - (i * size)] : new T[size];
            #region Uncomment this for manual implementation

            //for (int j = 0; j < temparr.Length; j++)
            //{
            //    temparr[j] = inputArray[i * size + j];
            //}
            //groupArrays.Add(temparr);
            #endregion
            #region using skip and take
            groupArrays.Add(inputArray.Skip(i * size).Take(size).ToArray());
            #endregion
        }
        return groupArrays.ToArray();
    }
}


