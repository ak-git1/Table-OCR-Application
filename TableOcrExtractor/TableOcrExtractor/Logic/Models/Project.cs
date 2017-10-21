using System;
using System.IO;
using System.Xml.Serialization;
using TableOcrExtractor.Logic.Helpers;

namespace TableOcrExtractor.Logic.Models
{
    /// <summary>
    /// Recoginition project
    /// </summary>
    [Serializable]
    internal class Project
    {
        #region Variables and constants

        /// <summary>
        /// The data folder prefix
        /// </summary>
        private const string DataFolderPrefix = "data";

        /// <summary>
        /// The project file extensions filter
        /// </summary>
        public const string ProjectFileExtensionsFilter = "*.rproj|*.rproj";

        #endregion

        #region Properties

        /// <summary>
        /// Project name
        /// </summary>
        [XmlElement]
        public string Name { get; set; }

        /// <summary>
        /// Path to ptoject file
        /// </summary>
        [XmlElement]
        public string ProjectPath { get; private set; }

        /// <summary>
        /// Path to the data folder
        /// </summary>
        [XmlElement]
        public string ProjectDataFolderPath { get; set; }

        /// <summary>
        /// Gallery
        /// </summary>
        [XmlElement]
        public Gallery Gallery { get; set; }

        #endregion

        #region Public methods

        /// <summary>
        /// Project creation
        /// </summary>
        /// <returns></returns>
        public static Project Create(string projectPath, string name)
        {
            Project project = new Project
            {
                ProjectPath = projectPath,
                Name = name,
                ProjectDataFolderPath = Path.Combine(Path.GetDirectoryName(projectPath), $@"{DataFolderPrefix}")
            };
            project.Gallery = new Gallery(project.ProjectDataFolderPath);
            project.Save();
            return project;
        }

        /// <summary>
        /// Loads project from the specified project path.
        /// </summary>
        /// <param name="projectPath">The project path.</param>
        /// <returns></returns>
        public static Project Load(string projectPath)
        {
            Project project = SerializationHelper.DeserializeFromXml<Project>(File.ReadAllText(projectPath));
            project.UpdateProjectPathes(projectPath);
            return project;
        }

        /// <summary>
        /// Saves project
        /// </summary>
        public void Save()
        {
            Directory.CreateDirectory(ProjectDataFolderPath);
            File.WriteAllText(ProjectPath, SerializationHelper.SerializeToXml(this));
        }

        /// <summary>
        /// Saves project to new location
        /// </summary>
        public void SaveAs()
        {
            // TODO
        }

        #endregion

        #region Private methods

        /// <summary>
        /// Updates project pathes.
        /// </summary>
        /// <param name="projectPath">The project path.</param>
        private void UpdateProjectPathes(string projectPath)
        {
            ProjectPath = projectPath;
            ProjectDataFolderPath = Path.Combine(Path.GetDirectoryName(projectPath), Path.GetDirectoryName(ProjectDataFolderPath + @"\"));
            Gallery.UpdateGalleryPathes(ProjectDataFolderPath);
        }

        /// <summary>
        /// Validates saving possibility
        /// </summary>
        private void Validate()
        {
            // TODO
        }

        #endregion
    }
}
