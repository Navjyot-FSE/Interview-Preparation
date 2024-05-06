namespace OperatorOverloading_MethodExtention
{
	public class SubjectMarks
	{
		public string subject { get; private set;}
		public int marks { get; private set;}
		
		public SubjectMarks(string _subject, int _marks)
		{
			this.subject = _subject;
			this.marks = _marks;
		}
		
		public static SubjectMarks operator +(SubjectMarks sub1, SubjectMarks sub2)
		{
			return new SubjectMarks("Total", sub1.marks + sub2.marks);
		}
		
		public override string ToString()
		{
			return $"{this.subject} : {this.marks}";
		}
	}
}