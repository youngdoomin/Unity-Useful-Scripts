using System;

	public static class ArrayExtensions
	{
		public static void ForEach<T>(this T[] array, Action<T> action)
		{
			Array.ForEach<T>(array, action);
		}
		public static bool Contain<T>(this T[] array, T value)
		{
			return Array.IndexOf(array, value) != -1;
		}
	}
