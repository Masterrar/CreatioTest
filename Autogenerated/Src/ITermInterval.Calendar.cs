namespace Terrasoft.Configuration
{
	using System;

	#region Class: TimeTerm

	/// <summary>
	/// Class container for the time interval
	/// </summary>
	public class TimeTerm
	{
		#region Fields: Public

		public Terrasoft.Configuration.Calendars.TimeUnit Type {
			get;
			set;
		}
		public int Value {
			get;
			set;
		}
		public Guid CalendarId {
			get;
			set;
		}

		#endregion
	}

	#endregion

	#region : Interface: ITermInterval

	/// <summary>
	/// Interface of term interval class.
	/// </summary>
	public interface ITermInterval<T>
	{
			/// <summary>
			/// Method that returns term flags.
			/// </summary>
			/// <returns>Term flags.</returns>
			T GetMask();
	}
	#endregion

}
