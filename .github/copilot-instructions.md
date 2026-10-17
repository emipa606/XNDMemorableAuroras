# GitHub Copilot Instructions for [XND] Memorable Auroras (Continued)

## Mod Overview and Purpose

**[XND] Memorable Auroras (Continued)** is an update of the original mod by XeoNovaDan. This modification enhances the experience of auroras in RimWorld by providing colonists with a sustained mood boost after witnessing an aurora. Instead of the temporary +14 moodlet that disappears as soon as a character steps indoors, this mod introduces a lasting +5 moodlet that captures the awe and beauty of the aurora, similar to the effects of a very impressive dining experience. The mod leverages the Harmony Patch Library for seamless integration and modification without compatibility issues.

## Key Features and Systems

- **Lasting Mood Boost**: Provides a long-lasting +5 mood bonus for colonists after observing an aurora, modifying the vanilla gameplay experience to be more immersive.
- **Compatability**: Designed to be safely addable and removable from existing savegames without causing issues.
- **Localization Support**: Includes translations for multiple languages such as French, German (Deutsch), and Russian (русский).
- **Integration with Harmony**: Utilizes the Harmony Patch Library for clean and efficient patching of the game's mechanics.

## Coding Patterns and Conventions

- **C# Naming Conventions**: Follows standard C# naming conventions, such as PascalCase for class names and CamelCase for method names.
- **File Organization**: Structure includes a clear separation of Harmony patches and thought definitions. Harmony patches are located in the `HarmonyPatches` directory, while XML definitions are stored in the `Patches` or `TranslationTemplate` directories.
- **Consistent Documentation**: Ensure each method and class is documented to explain its purpose and how it contributes to the overall mod functionality.

## XML Integration

- **ThoughtDefs**: The XML files define custom thoughts that affect colonists' mood. These can be found in `ThoughtDefs` and `Thoughts_Memory_Special.xml`.
- **Localization**: Translations are supported through XML configurations, allowing the mod to cater to a broader audience with multilingual support.

## Harmony Patching

- **Patch Implementation**: The mod uses Harmony to patch the `GameCondition_Aurora` class, specifically the `GameConditionTick` method, by implementing a `Postfix` method. This method applies the moodlet effects after the game's typical aurora conditions are processed.
- **Non-Destructive Changes**: Ensures that the original game functionality remains intact while appending additional behavior specific to the mod.

## Suggestions for Copilot

- **Localization Enhancements**: Copilot can assist in generating additional translations or verifying existing strings across the +5 moodlet implementation.
- **Extend Functionality**: Support for additional customizable mood parameters that advance according to user preferences could be explored.
- **Code Refactoring**: Copilot can offer suggestions for code optimization, ensuring that the mod runs efficiently without unnecessary overheads.
- **Error Handling**: Suggest improved error handling techniques for better resilience, particularly when integrating into large mod packs.

By adhering to these instructions and suggestions, developers can maintain a high-quality, engaging experience for players using the [XND] Memorable Auroras (Continued) mod.

## Project Solution Guidelines
- Relevant mod XML files are included as Solution Items under the solution folder named XML, these can be read and modified from within the solution.
- Use these in-solution XML files as the primary files for reference and modification.
- The `.github/copilot-instructions.md` file is included in the solution under the `.github` solution folder, so it should be read/modified from within the solution instead of using paths outside the solution. Update this file once only, as it and the parent-path solution reference point to the same file in this workspace.
- When making functional changes in this mod, ensure the documented features stay in sync with implementation; use the in-solution `.github` copy as the primary file.
- In the solution is also a project called Assembly-CSharp, containing a read-only version of the decompiled game source, for reference and debugging purposes.
- For any new documentation, update this copilot-instructions.md file rather than creating separate documentation files.


## Hard rules (must follow)
- Do NOT run commands that modify the repo (no git commit, git apply, dotnet format) unless explicitly asked.
- Prefer minimal reads: read only the smallest code region needed (around the suspicious lines).
- When mentioning SonarQube issues, automatically use the SonarQube MCP service to fetch and address issues instead of making inferred fixes without querying SonarQube first.
- When mentioning the rimworld log, automatically use the Rimworld MCP service to fetch the log.

