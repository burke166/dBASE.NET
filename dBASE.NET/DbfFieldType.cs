using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dBASE.NET
{
	/// <summary>
	/// Not all types are currently implemented.
	/// </summary>
	public enum DbfFieldType
	{
		///<summary>
		///Character type. Maps to string.
		//</summary>
		Character = 'C',
		///<summary>
		///Currency type. Maps to double.
		///</summary>
		Currency = 'Y',
		///<summary>
		///Numeric type. Maps to double.
		///</summary>
		Numeric = 'N',
		///<summary>
		///Float type. Maps to float.
		///</summary>
		Float = 'F',
		///<summary>
		///Date type. Date is stored as YYYYDDMM string. Maps to DateTime.
		///</summary>
		Date = 'D',
		///<summary>
		///DateTime type. DateTime is stored as binary. Maps to DateTime.
		///</summary>
		DateTime = 'T',
		///<summary>
		///Double type. Maps to double.
		///</summary>
		Double = 'B',
		///<summary>
		///Integer type. Maps to int.
		///</summary>
		Integer = 'I',
		///<summary>
		///Logical type. Maps to bool.
		///</summary>
		Logical = 'L',
		///<summary>
		///Memo type. Memos stored in external file. Maps to string.
		///</summary>
		Memo = 'M',
		General = 'G',
		Picture = 'P',
		NullFlags = '0'
	}
}
