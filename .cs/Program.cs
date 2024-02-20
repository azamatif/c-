Console.WriteLine("Hello, World!");
#region
int[] nums = { 123, 456, 7890, 1234, 56789, 12345, 678901 };
int total1 = nums[0] + nums[1];
int total2 = total1+(nums[2] * nums[3]);
int x = (total2 * 10) + 7;
int total3 = (nums[4] + nums[5]) + x;
int y = (nums[0] * nums[1]) * 10 + 1;
int total4 = total3 - y;
int total5 = total4 = nums[6];
int total6 = total5 - (nums[0] = nums[1] + nums[2] + nums[3]);
int total7 = (total6 * 18) / 100;
int total8 = (total7 * 3) / 100;
int total9 = (total8 * 1) / 100;
int total10 = total9 + nums[4] + nums[5];
Console.WriteLine(total10);//result=69170
#endregion
