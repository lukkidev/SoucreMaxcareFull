public class GClass39
{
	private E525248F e525248F_0;

	private GClass44 gclass44_0;

	private GClass43 DFA6CE27;

	private GClass22 gclass22_0;

	public static readonly GClass39 DB0787B0;

	public E525248F E525248F_0
	{
		get
		{
			return (E525248F)new GClass34().method_46(new object[1] { this }, 35147);
		}
		private set
		{
			new GClass34().method_46(new object[2] { this, value }, 35643);
		}
	}

	public GClass22 GClass22_0
	{
		get
		{
			return (GClass22)new GClass34().method_46(new object[1] { this }, 34675);
		}
		private set
		{
			new GClass34().method_46(new object[2] { this, value }, 24679);
		}
	}

	public GClass43 GClass43_0
	{
		get
		{
			return (GClass43)new GClass34().method_46(new object[1] { this }, 30096);
		}
		private set
		{
			new GClass34().method_46(new object[2] { this, value }, 38091);
		}
	}

	public GClass44 GClass44_0
	{
		get
		{
			return (GClass44)new GClass34().method_46(new object[1] { this }, 41751);
		}
		private set
		{
			new GClass34().method_46(new object[2] { this, value }, 66409);
		}
	}

	public static void B839773C(string string_0)
	{
		new GClass34().method_46(new object[1] { string_0 }, 19951);
	}

	public static string smethod_0(uint uint_0)
	{
		return (string)new GClass34().method_46(new object[1] { uint_0 }, 53312);
	}

	public static bool D1949C37(ref string string_0)
	{
		object[] array = new object[1] { string_0 };
		try
		{
			return (bool)new GClass34().method_46(array, 63622);
		}
		finally
		{
			string_0 = (string)array[0];
		}
	}

	public static bool smethod_1()
	{
		return (bool)new GClass34().method_46(null, 37110);
	}

	public GClass39()
	{
		new GClass34().method_46(new object[1] { this }, 30972);
	}

	private static void BE88CE29()
	{
		new GClass34().method_46(null, 51286);
	}

	public static bool smethod_2()
	{
		return (bool)new GClass34().method_46(null, 22934);
	}

	internal static bool F299DCA4(byte[] byte_0)
	{
		int num = 0;
		while (true)
		{
			if (num < byte_0.Length)
			{
				if (num + 3 >= byte_0.Length || byte_0[num] != 81 || byte_0[num + 1] != 69 || byte_0[num + 2] != 77 || byte_0[num + 3] != 85)
				{
					if (num + 8 >= byte_0.Length || byte_0[num] != 77 || byte_0[num + 1] != 105 || byte_0[num + 2] != 99 || byte_0[num + 3] != 114 || byte_0[num + 4] != 111 || byte_0[num + 5] != 115 || byte_0[num + 6] != 111 || byte_0[num + 7] != 102 || byte_0[num + 8] != 116)
					{
						if (num + 6 >= byte_0.Length || byte_0[num] != 105 || byte_0[num + 1] != 110 || byte_0[num + 2] != 110 || byte_0[num + 3] != 111 || byte_0[num + 4] != 116 || byte_0[num + 5] != 101 || byte_0[num + 6] != 107)
						{
							if (num + 9 >= byte_0.Length || byte_0[num] != 86 || byte_0[num + 1] != 105 || byte_0[num + 2] != 114 || byte_0[num + 3] != 116 || byte_0[num + 4] != 117 || byte_0[num + 5] != 97 || byte_0[num + 6] != 108 || byte_0[num + 7] != 66 || byte_0[num + 8] != 111 || byte_0[num + 9] != 120)
							{
								if (num + 5 >= byte_0.Length || byte_0[num] != 86 || byte_0[num + 1] != 77 || byte_0[num + 2] != 119 || byte_0[num + 3] != 97 || byte_0[num + 4] != 114 || byte_0[num + 5] != 101)
								{
									if (num + 8 < byte_0.Length && byte_0[num] == 80 && byte_0[num + 1] == 97 && byte_0[num + 2] == 114 && byte_0[num + 3] == 97 && byte_0[num + 4] == 108 && byte_0[num + 5] == 108 && byte_0[num + 6] == 101 && byte_0[num + 7] == 108 && byte_0[num + 8] == 115)
									{
										break;
									}
									num++;
									continue;
								}
								return true;
							}
							return true;
						}
						return true;
					}
					return true;
				}
				return true;
			}
			return false;
		}
		return true;
	}

	static GClass39()
	{
		new GClass34().method_46(null, 47351);
	}

	public static bool smethod_3(bool bool_0)
	{
		return (bool)new GClass34().method_46(new object[1] { bool_0 }, 51623);
	}
}
