﻿/*
 * EnumerableExtensions
 * Copyright (C) 2014-2015  Theodoros Chatzigiannakis
 * 
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnumerableExtensions
{
    public static partial class EnumerableExtensions
    {
		/// <summary>
		/// Checks whether the sequence contains exactly one element.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="sequence"></param>
		/// <returns></returns>
		public static bool OnlyOne<T>(this IEnumerable<T> sequence)
		{
			if (sequence == null) throw new ArgumentNullException(nameof(sequence));

			using (var iterator = sequence.GetEnumerator())
			{
				return iterator.MoveNext() && !iterator.MoveNext();
			}
		}
	}
}
