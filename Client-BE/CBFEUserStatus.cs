// struct for monitoring FE 
public struct CBFEUserStatus
{
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
    char[] feName;
    int num;

}