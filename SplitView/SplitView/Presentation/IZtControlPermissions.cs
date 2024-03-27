namespace ZtFramework
{
    public interface IZtControlPermissions
    {
        ZtPermissions? ControlPermissions { get; set; }
    }

    public interface IZtControlPermissionsGridColumn : IZtControlPermissions
    {
        string ColumnName { get; set; }
    }

    public interface IZtHasPermissions
    {
        bool HasPermissions { get; set; }
    }
}