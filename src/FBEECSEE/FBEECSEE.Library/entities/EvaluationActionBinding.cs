namespace FBEECSEE.Library.entities;

/// <summary>Entity for connecting together a function of evaluation to a specific action.</summary>
internal record EvaluationActionBinding<T>(Func<T, bool> eval, Action<T> result);