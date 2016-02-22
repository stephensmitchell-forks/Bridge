﻿namespace System.Text.RegularExpressions.CoreFx
{
    /// <summary>
    /// Represents the method that is called each time a regular expression match is found during a Replace method operation.
    /// </summary>
    /// <param name="match"></param>
    /// <returns></returns>
    public delegate string MatchEvaluator(Match match);
}