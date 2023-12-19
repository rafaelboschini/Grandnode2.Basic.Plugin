# 🛒 Basic Plugin Structure for Grandnode 2

This document provides a basic structure for creating a plugin for Grandnode 2.

## Introduction

This plugin serves as an extension to the Grandnode 2 platform, allowing users to add custom functionalities or features.

## Getting Started

Follow these steps to integrate the plugin with your Grandnode 2 project:

### Prerequisites

- Grandnode 2 project set up and running.
- Visual Studio or any other preferred C# development environment installed.
- Basic knowledge of C# and Grandnode 2 plugin structure.

### Installation Steps

1. **Create a New Class Library Project:**

    - Open Visual Studio.
    - Choose "File" > "New" > "Project..."
    - Select "Class Library (.NET Core)".
    - Name the project appropriately, e.g., `Grandnode2CustomPlugin`.
    - Ensure the target framework matches the Grandnode 2 requirements.

2. **Add References:**

    - Add references to the necessary Grandnode 2 assemblies.
    - Navigate to the Grandnode 2 documentation for specific assemblies and versions required.

3. **Implement Plugin Functionalities:**

    - Create classes and methods to implement the desired functionalities for the plugin.
    - Follow the Grandnode 2 plugin development guidelines and utilize provided interfaces or methods for integration.

4. **Build the Project:**

    - Build the project to generate the necessary DLL file.

5. **Plugin Integration:**

    - Locate the Grandnode 2 plugin directory within your project.
    - Copy the generated DLL file from the build and paste it into the plugins directory.

6. **Activate the Plugin:**

    - Access the Grandnode 2 admin panel.
    - Navigate to the plugins section and locate the newly added plugin.
    - Enable the plugin to activate its functionalities within the platform.

## Additional Notes

- Ensure compatibility of the plugin with the Grandnode 2 version you are using.
- Refer to the official [Grandnode 2 Documentation](https://www.grandnode.com/) for detailed information and specific guidelines.
- Special thanks to the Grandnode team for their incredible platform and support! 🙌

## Resources

- [Grandnode 2 Website](https://www.grandnode.com/) - Official website for Grandnode 2.
- [Example Plugin Repository](link-to-example-repository) - Example repository showcasing a basic Grandnode 2 plugin structure.

## Author

👨‍💻 **Rafael Boschini**
- 📧 Email: rafaelboschini@gmail.com
- [LinkedIn](https://www.linkedin.com/in/rafael-boschini-5747311/)