namespace CqrsExample.Commands;

internal interface ICommandHandler<TModel> where TModel : ICommand
{
    void Handle(TModel command);
}