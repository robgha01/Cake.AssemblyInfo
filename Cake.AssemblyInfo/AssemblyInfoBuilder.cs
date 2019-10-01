namespace Cake.AssemblyInfo
{
    public class AssemblyInfoBuilder : IAssemblyInfoBuilder
    {
        public AssemblyInfoSettingsModel AssemblyInfoSettings { get; private set; }

        public AssemblyInfoBuilder()
        {
            AssemblyInfoSettings = new AssemblyInfoSettingsModel();
        }


        public IAssemblyInfoBuilder SetTitle(string title)
        {
            AssemblyInfoSettings.Title = title;
            return this;
        }

        public IAssemblyInfoBuilder SetDescription(string description)
        {
            AssemblyInfoSettings.Description = description;
            return this;
        }

        public IAssemblyInfoBuilder SetGuid(string guid)
        {
            AssemblyInfoSettings.Guid = guid;
            return this;
        }

        public IAssemblyInfoBuilder SetProduct(string product)
        {
            AssemblyInfoSettings.Product = product;
            return this;
        }

        public IAssemblyInfoBuilder SetCopyright(string copyright)
        {
            AssemblyInfoSettings.Copyright = copyright;
            return this;
        }

        public IAssemblyInfoBuilder SetTrademark(string trademark)
        {
            AssemblyInfoSettings.Trademark = trademark;
            return this;
        }

        public IAssemblyInfoBuilder SetVersion(string version)
        {
            AssemblyInfoSettings.Version = version;
            return this;
        }

        public IAssemblyInfoBuilder SetFileVersion(string fileVersion)
        {
            AssemblyInfoSettings.FileVersion = fileVersion;
            return this;
        }

        public IAssemblyInfoBuilder SetInformationalVersion(string informationalVersion)
        {
            AssemblyInfoSettings.InformationalVersion = informationalVersion;
            return this;
        }

        public IAssemblyInfoBuilder SetComVisible(bool comVisible)
        {
            AssemblyInfoSettings.ComVisible = comVisible;
            return this;
        }

        public IAssemblyInfoBuilder SetCLSCompliant(bool clsCompliant)
        {
            AssemblyInfoSettings.CLSCompliant = clsCompliant;
            return this;
        }

        public IAssemblyInfoBuilder SetCompany(string company)
        {
            AssemblyInfoSettings.Company = company;
            return this;
        }
    }

    public interface IAssemblyInfoBuilder
    {
        IAssemblyInfoBuilder SetTitle(string title);
        IAssemblyInfoBuilder SetDescription(string description);
        IAssemblyInfoBuilder SetGuid(string guid);
        IAssemblyInfoBuilder SetProduct(string product);
        IAssemblyInfoBuilder SetCopyright(string copyright);
        IAssemblyInfoBuilder SetTrademark(string trademark);
        IAssemblyInfoBuilder SetVersion(string version);
        IAssemblyInfoBuilder SetFileVersion(string fileVersion);
        IAssemblyInfoBuilder SetInformationalVersion(string informationalVersion);
        IAssemblyInfoBuilder SetComVisible(bool comVisible);
        IAssemblyInfoBuilder SetCLSCompliant(bool clsCompliant);
        IAssemblyInfoBuilder SetCompany(string company);
    }
}
