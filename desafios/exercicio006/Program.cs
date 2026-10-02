int [] nums = {3,2,4};
int target = 6;

for (int i = 0; i < nums.Length; i++)
{
    for (int j = i + 1; j < nums.Length; j++)
    {
        if(nums[i] + nums[j] == target)
        {
            System.Console.WriteLine($"{j} e {i}");
            
        }
    
    }
}