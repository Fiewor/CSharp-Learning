public partial class Program
{
    //public int DFS(List<int> nums)
    //{
    //    long[][] table;
    //    int mod = 1000000007;
    //    int n = nums.Count;
    //    if (n <= 2) return 1;

    //    List<int> less = new List<int>();
    //    List<int> greater = new List<int>();

    //    for (int i = 0; i < n; i++)
    //    {
    //        if (nums[i] < nums[0])
    //        {
    //            less.Add(nums[i]);
    //        }
    //        else
    //        {
    //            greater.Add(nums[i]);
    //        }
    //    }

    //    return (int)(table[n - 1][less.Count] * ((DFS(less) % mod) % mod) * DFS(greater) % mod);
    //}

    //public static int NumWays(int[] nums)
    //{
    //    FormPascalTriangle(nums.Length);
    //    return (int)DFS(nums.ToList()) - 1;
    //}

    //public static void FormPascalTriangle(int size)
    //{
    //    var mod = 1000000007;
    //    var table = new long[size, size];
    //    for (int i = 0; i < size; i++)
    //    {
    //        table[i, 0] = i;
    //        table[i, i] = i;
    //    }

    //    for (int i = 2; i < size; i++)
    //    {
    //        for (int j = 0; j < i; j++)
    //        {
    //            table[i, j] = (table[i - 1, j] + table[i - 1, j - 1]) % mod;
    //        }
    //    }
    //}

    public class MessageService
    {
        // subscriber that's responsible for sending a text message
        //public void OnVideoEncoded(object source, EventArgs args)
        public void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("MessageService: Sending a text message..." + args.Video.Title);
        }
    }
}