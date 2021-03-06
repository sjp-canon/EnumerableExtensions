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
        /// Returns all elements in a sequence, excluding the last.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sequence"></param>
        /// <returns></returns>
        public static IEnumerable<T> ButLast<T>(this IEnumerable<T> sequence)
        {
            if (sequence == null) throw new ArgumentNullException(nameof(sequence));

	        return ButLastImpl<T>(sequence);
        }

	    private static IEnumerable<T> ButLastImpl<T>(IEnumerable<T> sequence)
	    {
			using (var iterator = sequence.GetEnumerator())
			{
				if (!iterator.MoveNext()) yield break;
				var previous = iterator.Current;
				while (iterator.MoveNext())
				{
					yield return previous;
					previous = iterator.Current;
				}
			}
		}
	}
}
