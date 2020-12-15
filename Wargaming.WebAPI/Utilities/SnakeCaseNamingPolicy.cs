﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Wargaming.WebAPI.Utilities
{
	public class SnakeCaseNamingPolicy : JsonNamingPolicy
	{
		public static SnakeCaseNamingPolicy Instance { get; } = new SnakeCaseNamingPolicy();

		public override string ConvertName(string name) => name.ToSnakeCase();
	}
}
