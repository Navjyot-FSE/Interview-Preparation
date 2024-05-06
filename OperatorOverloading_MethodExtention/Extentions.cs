namespace OperatorOverloading_MethodExtention
{
	public static class Extentions
	{
		public static string GetMarks(this string str, SubjectMarks sub)
		{
			return sub.marks.ToString();
		}
	}
}