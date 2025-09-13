
# Структура проекта

```
├── Engine
│   ├── UI
│   │   ├── ButtonObject.cs
│   │   └── TextObject.cs
│   ├── AudioManager.cs
│   ├── Core.cs
│   ├── SceneManager.cs
│   ├── TextureManager.cs
│   └── Timedelta.cs
├── EngineAssets
│   └── icon.ico
├── Objects
│   └── SpriteObject.cs
├── Scenes
│   └── Examples
│       ├── MainMenuScene.cs
│       ├── PlatformerGameScene.cs
│       └── TopDownScene.cs
├── obj
│   ├── Debug
│   │   └── net8.0
│   │       ├── ref
│   │       │   ├── KnifeEngine.dll
│   │       │   ├── KnightEngine.dll
│   │       │   └── ZypEngine.dll
│   │       ├── refint
│   │       │   ├── KnifeEngine.dll
│   │       │   ├── KnightEngine.dll
│   │       │   └── ZypEngine.dll
│   │       ├── .NETCoreApp,Version=v8.0.AssemblyAttributes.cs
│   │       ├── KnifeEngine.AssemblyInfo.cs
│   │       ├── KnifeEngine.GeneratedMSBuildEditorConfig.editorconfig
│   │       ├── KnifeEngine.GlobalUsings.g.cs
│   │       ├── KnifeEngine.csproj.BuildWithSkipAnalyzers
│   │       ├── KnifeEngine.csproj.FileListAbsolute.txt
│   │       ├── KnifeEngine.dll
│   │       ├── KnifeEngine.pdb
│   │       ├── KnifeEngine.sourcelink.json
│   │       ├── KnightEngine.AssemblyInfo.cs
│   │       ├── KnightEngine.GeneratedMSBuildEditorConfig.editorconfig
│   │       ├── KnightEngine.GlobalUsings.g.cs
│   │       ├── KnightEngine.csproj.BuildWithSkipAnalyzers
│   │       ├── KnightEngine.csproj.FileListAbsolute.txt
│   │       ├── KnightEngine.dll
│   │       ├── KnightEngine.pdb
│   │       ├── ZypEngine.AssemblyInfo.cs
│   │       ├── ZypEngine.GeneratedMSBuildEditorConfig.editorconfig
│   │       ├── ZypEngine.GlobalUsings.g.cs
│   │       ├── ZypEngine.csproj.BuildWithSkipAnalyzers
│   │       ├── ZypEngine.csproj.FileListAbsolute.txt
│   │       ├── ZypEngine.csproj.Up2Date
│   │       ├── ZypEngine.dll
│   │       ├── ZypEngine.pdb
│   │       └── apphost.exe
│   ├── KnifeEngine.csproj.nuget.dgspec.json
│   ├── KnifeEngine.csproj.nuget.g.props
│   ├── KnifeEngine.csproj.nuget.g.targets
│   ├── KnightEngine.csproj.nuget.dgspec.json
│   ├── KnightEngine.csproj.nuget.g.props
│   ├── KnightEngine.csproj.nuget.g.targets
│   ├── ZypEngine.csproj.nuget.dgspec.json
│   ├── ZypEngine.csproj.nuget.g.props
│   ├── ZypEngine.csproj.nuget.g.targets
│   └── project.assets.json
├── AllKeyCodes.txt
├── KnifeEngine.csproj
├── Program.cs
└── tree.py
```


## Корневая директория

### Файл: AllKeyCodes.txt
```txt
[LOGGER] | KeyCode: LControl
[LOGGER] | KeyCode: LSystem
[LOGGER] | KeyCode: LAlt
[LOGGER] | KeyCode: Space
[LOGGER] | KeyCode: RAlt
[LOGGER] | KeyCode: RSystem
[LOGGER] | KeyCode: RControl
[LOGGER] | KeyCode: Left
[LOGGER] | KeyCode: Up
[LOGGER] | KeyCode: Down
[LOGGER] | KeyCode: Right
[LOGGER] | KeyCode: Delete
[LOGGER] | KeyCode: End
[LOGGER] | KeyCode: PageDown
[LOGGER] | KeyCode: PageUp
[LOGGER] | KeyCode: Home
[LOGGER] | KeyCode: Insert
[LOGGER] | KeyCode: Tilde
[LOGGER] | KeyCode: Num1
[LOGGER] | KeyCode: Num2
[LOGGER] | KeyCode: Num3
[LOGGER] | KeyCode: Num4
[LOGGER] | KeyCode: Num5
[LOGGER] | KeyCode: Num6
[LOGGER] | KeyCode: Num7
[LOGGER] | KeyCode: Num8
[LOGGER] | KeyCode: Num9
[LOGGER] | KeyCode: Num0
[LOGGER] | KeyCode: Hyphen
[LOGGER] | KeyCode: Equal
[LOGGER] | KeyCode: BackSpace
[LOGGER] | KeyCode: Tab
[LOGGER] | KeyCode: Q
[LOGGER] | KeyCode: W
[LOGGER] | KeyCode: E
[LOGGER] | KeyCode: R
[LOGGER] | KeyCode: T
[LOGGER] | KeyCode: Y
[LOGGER] | KeyCode: U
[LOGGER] | KeyCode: I
[LOGGER] | KeyCode: O
[LOGGER] | KeyCode: P
[LOGGER] | KeyCode: LBracket
[LOGGER] | KeyCode: RBracket
[LOGGER] | KeyCode: BackSlash
[LOGGER] | KeyCode: Unknown
[LOGGER] | KeyCode: A
[LOGGER] | KeyCode: S
[LOGGER] | KeyCode: D
[LOGGER] | KeyCode: F
[LOGGER] | KeyCode: G
[LOGGER] | KeyCode: H
[LOGGER] | KeyCode: J
[LOGGER] | KeyCode: K
[LOGGER] | KeyCode: L
[LOGGER] | KeyCode: Semicolon
[LOGGER] | KeyCode: Quote
[LOGGER] | KeyCode: Enter
[LOGGER] | KeyCode: Unknown
[LOGGER] | KeyCode: LShift
[LOGGER] | KeyCode: Z
[LOGGER] | KeyCode: X
[LOGGER] | KeyCode: C
[LOGGER] | KeyCode: V
[LOGGER] | KeyCode: B
[LOGGER] | KeyCode: N
[LOGGER] | KeyCode: M
[LOGGER] | KeyCode: Comma
[LOGGER] | KeyCode: Period
[LOGGER] | KeyCode: Slash
[LOGGER] | KeyCode: RShift
```

### Файл: KnifeEngine.csproj *(бинарный файл)*

### Файл: Program.cs *(бинарный файл)*

### Файл: tree.py
```py
import os
import fnmatch

def get_files_tree_md(directory_path, output_var_name="files_content", exclude_list=None):
    """
    Получает дерево файлов в директории и записывает содержимое в формате Markdown
    
    Args:
        directory_path (str): Путь к директории
        output_var_name (str): Имя переменной для вывода
        exclude_list (list): Список файлов и директорий для исключения
    
    Returns:
        str: Строка с содержимым файлов в формате Markdown
    """
    
    # Стандартный список исключений
    default_exclude = [
        '.git', '.github', '.vscode', '__pycache__', '.idea',
        '.DS_Store', 'Thumbs.db', '.gitignore', '.env',
        'node_modules', 'venv', 'env', '.venv',
        '*.pyc', '*.pyo', '*.pyd', '__pycache__',
        '.svn', '.hg', '.bzr',
        'build', 'dist', '*.egg-info',
        '.pytest_cache', '.coverage', 'htmlcov',
        '.tox', '.eggs', 'bin'
    ]
    
    # Объединяем стандартные исключения с пользовательскими
    if exclude_list is None:
        exclude_list = default_exclude
    else:
        exclude_list = default_exclude + exclude_list
    
    def should_exclude(path, is_dir=False):
        """Проверяет, нужно ли исключить файл или директорию"""
        path_name = os.path.basename(path)
        
        # Проверяем по списку исключений
        for exclude_item in exclude_list:
            # Если это паттерн с *, проверяем совпадение
            if '*' in exclude_item:
                if fnmatch.fnmatch(path_name, exclude_item):
                    return True
            # Если точное совпадение имени
            elif path_name == exclude_item:
                return True
            # Проверяем полный путь
            elif exclude_item in path:
                return True
        return False
    
    def is_text_file(file_path):
        """Проверяет, является ли файл текстовым"""
        text_extensions = {'.txt', '.py', '.js', '.html', '.css', '.md', '.json', 
                          '.xml', '.csv', '.yaml', '.yml', '.ini', '.cfg', '.log',
                          '.sql', '.sh', '.bat', '.ps1', '.rst', '.toml', '.cfg'}
        _, ext = os.path.splitext(file_path)
        return ext.lower() in text_extensions
    
    def read_file_content(file_path):
        """Читает содержимое файла с обработкой ошибок кодировки"""
        try:
            # Пробуем разные кодировки
            for encoding in ['utf-8', 'cp1251', 'koi8-r']:
                try:
                    with open(file_path, 'r', encoding=encoding) as f:
                        return f.read()
                except UnicodeDecodeError:
                    continue
            return "[Ошибка чтения файла - неизвестная кодировка]"
        except Exception as e:
            return f"[Ошибка чтения файла: {str(e)}]"
    
    def generate_tree_structure(dir_path, prefix="", is_last=True):
        """Генерирует текстовое представление дерева файлов"""
        tree_lines = []
        
        # Получаем список файлов и директорий
        try:
            items = os.listdir(dir_path)
            # Фильтруем исключения
            items = [item for item in items if not should_exclude(os.path.join(dir_path, item))]
            items.sort()
        except PermissionError:
            return [f"{prefix}├── [Нет доступа]"]
        
        # Разделяем файлы и директории
        dirs = []
        files = []
        
        for item in items:
            item_path = os.path.join(dir_path, item)
            if os.path.isdir(item_path):
                dirs.append(item)
            else:
                files.append(item)
        
        # Сначала директории, потом файлы
        all_items = dirs + files
        total_items = len(all_items)
        
        for i, item in enumerate(all_items):
            is_last_item = (i == total_items - 1)
            item_path = os.path.join(dir_path, item)
            
            if is_last_item:
                tree_lines.append(f"{prefix}└── {item}")
                new_prefix = f"{prefix}    "
            else:
                tree_lines.append(f"{prefix}├── {item}")
                new_prefix = f"{prefix}│   "
            
            # Если это директория, рекурсивно добавляем её содержимое
            if os.path.isdir(item_path) and not should_exclude(item_path, is_dir=True):
                sub_tree = generate_tree_structure(item_path, new_prefix, is_last_item)
                tree_lines.extend(sub_tree)
        
        return tree_lines
    
    # Начинаем формировать результат
    result = f"{output_var_name} = '''\n"
    
    # Добавляем дерево файлов в самом верху
    result += "# Структура проекта\n\n"
    result += "```\n"
    tree_lines = generate_tree_structure(directory_path)
    result += "\n".join(tree_lines)
    result += "\n```\n\n"
    
    # Проходим по всем файлам и папкам
    for root, dirs, files in os.walk(directory_path):
        # Проверяем, не нужно ли исключить текущую директорию
        if should_exclude(root, is_dir=True):
            continue
            
        # Фильтруем список директорий для обхода
        dirs[:] = [d for d in dirs if not should_exclude(os.path.join(root, d), is_dir=True)]
        
        # Получаем относительный путь от начальной директории
        rel_path = os.path.relpath(root, directory_path)
        if rel_path == '.':
            rel_path = ''
        
        # Добавляем заголовок для директории
        if rel_path:
            result += f"\n## Директория: {rel_path}\n\n"
        else:
            result += f"\n## Корневая директория\n\n"
        
        # Обрабатываем файлы
        for file in files:
            file_path = os.path.join(root, file)
            
            # Проверяем, не нужно ли исключить файл
            if should_exclude(file_path):
                continue
                
            rel_file_path = os.path.relpath(file_path, directory_path)
            
            # Проверяем, является ли файл текстовым
            if is_text_file(file_path):
                result += f"### Файл: {rel_file_path}\n"
                result += f"```{os.path.splitext(file_path)[1][1:]}\n"
                content = read_file_content(file_path)
                result += content
                result += "\n```\n\n"
            else:
                # Для бинарных файлов просто указываем путь
                result += f"### Файл: {rel_file_path} *(бинарный файл)*\n\n"
    
    result += "'''"
    return result

# Альтернативная версия с более компактным форматом
def get_files_tree_md_compact(directory_path, output_var_name="files_content", exclude_list=None):
    """
    Компактная версия - только содержимое файлов без структуры директорий
    """
    
    # Стандартный список исключений
    default_exclude = [
        '.git', '.github', '.vscode', '__pycache__', '.idea',
        '.DS_Store', 'Thumbs.db', '.gitignore', '.env',
        'node_modules', 'venv', 'env', '.venv',
        '*.pyc', '*.pyo', '*.pyd', '__pycache__',
        '.svn', '.hg', '.bzr',
        'build', 'dist', '*.egg-info',
        '.pytest_cache', '.coverage', 'htmlcov',
        '.tox', '.eggs'
    ]
    
    # Объединяем стандартные исключения с пользовательскими
    if exclude_list is None:
        exclude_list = default_exclude
    else:
        exclude_list = default_exclude + exclude_list
    
    def should_exclude(path, is_dir=False):
        """Проверяет, нужно ли исключить файл или директорию"""
        path_name = os.path.basename(path)
        
        # Проверяем по списку исключений
        for exclude_item in exclude_list:
            # Если это паттерн с *, проверяем совпадение
            if '*' in exclude_item:
                if fnmatch.fnmatch(path_name, exclude_item):
                    return True
            # Если точное совпадение имени
            elif path_name == exclude_item:
                return True
            # Проверяем полный путь
            elif exclude_item in path:
                return True
        return False
    
    def is_text_file(file_path):
        text_extensions = {'.txt', '.py', '.js', '.html', '.css', '.md', '.json', 
                          '.xml', '.csv', '.yaml', '.yml', '.ini', '.cfg', '.log', '.lua',
                          '.sql', '.sh', '.bat', '.ps1', '.rst', '.toml', '.ts', '.tsx', '.jsx', '.manifest'}
        _, ext = os.path.splitext(file_path)
        return ext.lower() in text_extensions
    
    def read_file_content(file_path):
        try:
            for encoding in ['utf-8', 'cp1251', 'koi8-r']:
                try:
                    with open(file_path, 'r', encoding=encoding) as f:
                        return f.read()
                except UnicodeDecodeError:
                    continue
            return "[Ошибка чтения файла]"
        except Exception as e:
            return f"[Ошибка: {str(e)}]"
    
    def generate_tree_structure(dir_path, prefix="", is_last=True):
        """Генерирует текстовое представление дерева файлов"""
        tree_lines = []
        
        # Получаем список файлов и директорий
        try:
            items = os.listdir(dir_path)
            # Фильтруем исключения
            items = [item for item in items if not should_exclude(os.path.join(dir_path, item))]
            items.sort()
        except PermissionError:
            return [f"{prefix}├── [Нет доступа]"]
        
        # Разделяем файлы и директории
        dirs = []
        files = []
        
        for item in items:
            item_path = os.path.join(dir_path, item)
            if os.path.isdir(item_path):
                dirs.append(item)
            else:
                files.append(item)
        
        # Сначала директории, потом файлы
        all_items = dirs + files
        total_items = len(all_items)
        
        for i, item in enumerate(all_items):
            is_last_item = (i == total_items - 1)
            item_path = os.path.join(dir_path, item)
            
            if is_last_item:
                tree_lines.append(f"{prefix}└── {item}")
                new_prefix = f"{prefix}    "
            else:
                tree_lines.append(f"{prefix}├── {item}")
                new_prefix = f"{prefix}│   "
            
            # Если это директория, рекурсивно добавляем её содержимое
            if os.path.isdir(item_path) and not should_exclude(item_path, is_dir=True):
                sub_tree = generate_tree_structure(item_path, new_prefix, is_last_item)
                tree_lines.extend(sub_tree)
        
        return tree_lines
    
    result = f"{output_var_name} = '''\n"
    
    # Добавляем дерево файлов в самом верху
    result += "# Структура проекта\n\n"
    result += "```\n"
    tree_lines = generate_tree_structure(directory_path)
    result += "\n".join(tree_lines)
    result += "\n```\n\n"
    
    for root, dirs, files in os.walk(directory_path):
        # Проверяем, не нужно ли исключить текущую директорию
        if should_exclude(root, is_dir=True):
            continue
            
        # Фильтруем список директорий для обхода
        dirs[:] = [d for d in dirs if not should_exclude(os.path.join(root, d), is_dir=True)]
        
        for file in files:
            file_path = os.path.join(root, file)
            
            # Проверяем, не нужно ли исключить файл
            if should_exclude(file_path):
                continue
                
            rel_file_path = os.path.relpath(file_path, directory_path)
            
            if is_text_file(file_path):
                # Используем путь как расширение для подсветки синтаксиса
                ext = os.path.splitext(file_path)[1][1:]
                result += f"## {rel_file_path}\n"
                result += f"```{ext}\n"
                content = read_file_content(file_path)
                result += content
                result += "\n```\n\n"
    
    result += "'''"
    return result

# Пример использования:
if __name__ == "__main__":
    # Дополнительные исключения
    exclude_list = ['temp', 'cache', '*.log', '.env', 'venv', '__pycache__', 'node_modules', '.git', 'files_tree.md']
    exclude_list += ['.git', '.github', '.vscode', '__pycache__', '.idea',
        '.DS_Store', 'Thumbs.db', '.gitignore', '.env',
        'node_modules', 'venv', 'env', '.venv',
        '*.pyc', '*.pyo', '*.pyd', '__pycache__',
        '.svn', '.hg', '.bzr',
        'build', 'dist', '*.egg-info',
        '.pytest_cache', '.coverage', 'htmlcov',
        '.tox', '.eggs', 'bin']    

    # Получить дерево файлов с исключениями
    path_to_scan = './'
    md_content = get_files_tree_md(path_to_scan, exclude_list=exclude_list)
    
    # Сохранить в файл
    start = md_content.find("'''") + 3
    end = md_content.rfind("'''")
    content = md_content[start:end]
    
    with open("files_tree.md", "w", encoding="utf-8") as f:
        f.write(content)
    
    print("Файл сохранен как files_tree.md")

```


## Директория: Engine

### Файл: Engine\AudioManager.cs *(бинарный файл)*

### Файл: Engine\Core.cs *(бинарный файл)*

### Файл: Engine\SceneManager.cs *(бинарный файл)*

### Файл: Engine\TextureManager.cs *(бинарный файл)*

### Файл: Engine\Timedelta.cs *(бинарный файл)*


## Директория: Engine\UI

### Файл: Engine\UI\ButtonObject.cs *(бинарный файл)*

### Файл: Engine\UI\TextObject.cs *(бинарный файл)*


## Директория: EngineAssets

### Файл: EngineAssets\icon.ico *(бинарный файл)*


## Директория: obj

### Файл: obj\KnifeEngine.csproj.nuget.dgspec.json
```json
{
  "format": 1,
  "restore": {
    "C:\\Users\\avirt\\source\\repos\\CosmoEngine\\KnifeEngine\\KnifeEngine\\KnifeEngine.csproj": {}
  },
  "projects": {
    "C:\\Users\\avirt\\source\\repos\\CosmoEngine\\KnifeEngine\\KnifeEngine\\KnifeEngine.csproj": {
      "version": "1.0.0",
      "restore": {
        "projectUniqueName": "C:\\Users\\avirt\\source\\repos\\CosmoEngine\\KnifeEngine\\KnifeEngine\\KnifeEngine.csproj",
        "projectName": "KnifeEngine",
        "projectPath": "C:\\Users\\avirt\\source\\repos\\CosmoEngine\\KnifeEngine\\KnifeEngine\\KnifeEngine.csproj",
        "packagesPath": "C:\\Users\\avirt\\.nuget\\packages\\",
        "outputPath": "C:\\Users\\avirt\\source\\repos\\CosmoEngine\\KnifeEngine\\KnifeEngine\\obj\\",
        "projectStyle": "PackageReference",
        "fallbackFolders": [
          "C:\\Program Files (x86)\\Microsoft Visual Studio\\Shared\\NuGetPackages"
        ],
        "configFilePaths": [
          "C:\\Users\\avirt\\AppData\\Roaming\\NuGet\\NuGet.Config",
          "C:\\Program Files (x86)\\NuGet\\Config\\Microsoft.VisualStudio.FallbackLocation.config",
          "C:\\Program Files (x86)\\NuGet\\Config\\Microsoft.VisualStudio.Offline.config"
        ],
        "originalTargetFrameworks": [
          "net8.0"
        ],
        "sources": {
          "C:\\Program Files (x86)\\Microsoft SDKs\\NuGetPackages\\": {},
          "C:\\Program Files\\dotnet\\library-packs": {},
          "C:\\Users\\avirt\\AppData\\Roaming\\Cosmos User Kit\\packages\\": {},
          "https://api.nuget.org/v3/index.json": {}
        },
        "frameworks": {
          "net8.0": {
            "targetAlias": "net8.0",
            "projectReferences": {}
          }
        },
        "warningProperties": {
          "warnAsError": [
            "NU1605"
          ]
        },
        "restoreAuditProperties": {
          "enableAudit": "true",
          "auditLevel": "low",
          "auditMode": "direct"
        },
        "SdkAnalysisLevel": "9.0.300"
      },
      "frameworks": {
        "net8.0": {
          "targetAlias": "net8.0",
          "dependencies": {
            "SFML.Net": {
              "target": "Package",
              "version": "[2.6.1, )"
            }
          },
          "imports": [
            "net461",
            "net462",
            "net47",
            "net471",
            "net472",
            "net48",
            "net481"
          ],
          "assetTargetFallback": true,
          "warn": true,
          "frameworkReferences": {
            "Microsoft.NETCore.App": {
              "privateAssets": "all"
            }
          },
          "runtimeIdentifierGraphPath": "C:\\Program Files\\dotnet\\sdk\\9.0.301/PortableRuntimeIdentifierGraph.json"
        }
      }
    }
  }
}
```

### Файл: obj\KnifeEngine.csproj.nuget.g.props *(бинарный файл)*

### Файл: obj\KnifeEngine.csproj.nuget.g.targets *(бинарный файл)*

### Файл: obj\KnightEngine.csproj.nuget.dgspec.json
```json
{
  "format": 1,
  "restore": {
    "C:\\Users\\avirt\\source\\repos\\CosmoEngine\\KnightEngine\\KnightEngine\\KnightEngine.csproj": {}
  },
  "projects": {
    "C:\\Users\\avirt\\source\\repos\\CosmoEngine\\KnightEngine\\KnightEngine\\KnightEngine.csproj": {
      "version": "1.0.0",
      "restore": {
        "projectUniqueName": "C:\\Users\\avirt\\source\\repos\\CosmoEngine\\KnightEngine\\KnightEngine\\KnightEngine.csproj",
        "projectName": "KnightEngine",
        "projectPath": "C:\\Users\\avirt\\source\\repos\\CosmoEngine\\KnightEngine\\KnightEngine\\KnightEngine.csproj",
        "packagesPath": "C:\\Users\\avirt\\.nuget\\packages\\",
        "outputPath": "C:\\Users\\avirt\\source\\repos\\CosmoEngine\\KnightEngine\\KnightEngine\\obj\\",
        "projectStyle": "PackageReference",
        "fallbackFolders": [
          "C:\\Program Files (x86)\\Microsoft Visual Studio\\Shared\\NuGetPackages"
        ],
        "configFilePaths": [
          "C:\\Users\\avirt\\AppData\\Roaming\\NuGet\\NuGet.Config",
          "C:\\Program Files (x86)\\NuGet\\Config\\Microsoft.VisualStudio.FallbackLocation.config",
          "C:\\Program Files (x86)\\NuGet\\Config\\Microsoft.VisualStudio.Offline.config"
        ],
        "originalTargetFrameworks": [
          "net8.0"
        ],
        "sources": {
          "C:\\Program Files (x86)\\Microsoft SDKs\\NuGetPackages\\": {},
          "C:\\Program Files\\dotnet\\library-packs": {},
          "C:\\Users\\avirt\\AppData\\Roaming\\Cosmos User Kit\\packages\\": {},
          "https://api.nuget.org/v3/index.json": {}
        },
        "frameworks": {
          "net8.0": {
            "targetAlias": "net8.0",
            "projectReferences": {}
          }
        },
        "warningProperties": {
          "warnAsError": [
            "NU1605"
          ]
        },
        "restoreAuditProperties": {
          "enableAudit": "true",
          "auditLevel": "low",
          "auditMode": "direct"
        },
        "SdkAnalysisLevel": "9.0.300"
      },
      "frameworks": {
        "net8.0": {
          "targetAlias": "net8.0",
          "dependencies": {
            "SFML.Net": {
              "target": "Package",
              "version": "[2.6.1, )"
            }
          },
          "imports": [
            "net461",
            "net462",
            "net47",
            "net471",
            "net472",
            "net48",
            "net481"
          ],
          "assetTargetFallback": true,
          "warn": true,
          "frameworkReferences": {
            "Microsoft.NETCore.App": {
              "privateAssets": "all"
            }
          },
          "runtimeIdentifierGraphPath": "C:\\Program Files\\dotnet\\sdk\\9.0.301/PortableRuntimeIdentifierGraph.json"
        }
      }
    }
  }
}
```

### Файл: obj\KnightEngine.csproj.nuget.g.props *(бинарный файл)*

### Файл: obj\KnightEngine.csproj.nuget.g.targets *(бинарный файл)*

### Файл: obj\project.assets.json
```json
{
  "version": 3,
  "targets": {
    "net8.0": {
      "CSFML/2.6.1": {
        "type": "package",
        "build": {
          "build/netstandard2.0/_._": {}
        },
        "runtimeTargets": {
          "runtimes/fedora-x64/native/libcsfml-audio.so": {
            "assetType": "native",
            "rid": "fedora-x64"
          },
          "runtimes/fedora-x64/native/libcsfml-audio.so.2.6": {
            "assetType": "native",
            "rid": "fedora-x64"
          },
          "runtimes/fedora-x64/native/libcsfml-graphics.so": {
            "assetType": "native",
            "rid": "fedora-x64"
          },
          "runtimes/fedora-x64/native/libcsfml-graphics.so.2.6": {
            "assetType": "native",
            "rid": "fedora-x64"
          },
          "runtimes/fedora-x64/native/libcsfml-system.so": {
            "assetType": "native",
            "rid": "fedora-x64"
          },
          "runtimes/fedora-x64/native/libcsfml-system.so.2.6": {
            "assetType": "native",
            "rid": "fedora-x64"
          },
          "runtimes/fedora-x64/native/libcsfml-window.so": {
            "assetType": "native",
            "rid": "fedora-x64"
          },
          "runtimes/fedora-x64/native/libcsfml-window.so.2.6": {
            "assetType": "native",
            "rid": "fedora-x64"
          },
          "runtimes/fedora-x64/native/libsfml-audio.so.2.6": {
            "assetType": "native",
            "rid": "fedora-x64"
          },
          "runtimes/fedora-x64/native/libsfml-graphics.so.2.6": {
            "assetType": "native",
            "rid": "fedora-x64"
          },
          "runtimes/fedora-x64/native/libsfml-system.so.2.6": {
            "assetType": "native",
            "rid": "fedora-x64"
          },
          "runtimes/fedora-x64/native/libsfml-window.so.2.6": {
            "assetType": "native",
            "rid": "fedora-x64"
          },
          "runtimes/linux-arm/native/libcsfml-audio.so": {
            "assetType": "native",
            "rid": "linux-arm"
          },
          "runtimes/linux-arm/native/libcsfml-audio.so.2.6": {
            "assetType": "native",
            "rid": "linux-arm"
          },
          "runtimes/linux-arm/native/libcsfml-graphics.so": {
            "assetType": "native",
            "rid": "linux-arm"
          },
          "runtimes/linux-arm/native/libcsfml-graphics.so.2.6": {
            "assetType": "native",
            "rid": "linux-arm"
          },
          "runtimes/linux-arm/native/libcsfml-system.so": {
            "assetType": "native",
            "rid": "linux-arm"
          },
          "runtimes/linux-arm/native/libcsfml-system.so.2.6": {
            "assetType": "native",
            "rid": "linux-arm"
          },
          "runtimes/linux-arm/native/libcsfml-window.so": {
            "assetType": "native",
            "rid": "linux-arm"
          },
          "runtimes/linux-arm/native/libcsfml-window.so.2.6": {
            "assetType": "native",
            "rid": "linux-arm"
          },
          "runtimes/linux-arm/native/libsfml-audio.so.2.6": {
            "assetType": "native",
            "rid": "linux-arm"
          },
          "runtimes/linux-arm/native/libsfml-graphics.so.2.6": {
            "assetType": "native",
            "rid": "linux-arm"
          },
          "runtimes/linux-arm/native/libsfml-system.so.2.6": {
            "assetType": "native",
            "rid": "linux-arm"
          },
          "runtimes/linux-arm/native/libsfml-window.so.2.6": {
            "assetType": "native",
            "rid": "linux-arm"
          },
          "runtimes/linux-arm64/native/libcsfml-audio.so": {
            "assetType": "native",
            "rid": "linux-arm64"
          },
          "runtimes/linux-arm64/native/libcsfml-audio.so.2.6": {
            "assetType": "native",
            "rid": "linux-arm64"
          },
          "runtimes/linux-arm64/native/libcsfml-graphics.so": {
            "assetType": "native",
            "rid": "linux-arm64"
          },
          "runtimes/linux-arm64/native/libcsfml-graphics.so.2.6": {
            "assetType": "native",
            "rid": "linux-arm64"
          },
          "runtimes/linux-arm64/native/libcsfml-system.so": {
            "assetType": "native",
            "rid": "linux-arm64"
          },
          "runtimes/linux-arm64/native/libcsfml-system.so.2.6": {
            "assetType": "native",
            "rid": "linux-arm64"
          },
          "runtimes/linux-arm64/native/libcsfml-window.so": {
            "assetType": "native",
            "rid": "linux-arm64"
          },
          "runtimes/linux-arm64/native/libcsfml-window.so.2.6": {
            "assetType": "native",
            "rid": "linux-arm64"
          },
          "runtimes/linux-arm64/native/libsfml-audio.so.2.6": {
            "assetType": "native",
            "rid": "linux-arm64"
          },
          "runtimes/linux-arm64/native/libsfml-graphics.so.2.6": {
            "assetType": "native",
            "rid": "linux-arm64"
          },
          "runtimes/linux-arm64/native/libsfml-system.so.2.6": {
            "assetType": "native",
            "rid": "linux-arm64"
          },
          "runtimes/linux-arm64/native/libsfml-window.so.2.6": {
            "assetType": "native",
            "rid": "linux-arm64"
          },
          "runtimes/linux-musl-x64/native/libcsfml-audio.so": {
            "assetType": "native",
            "rid": "linux-musl-x64"
          },
          "runtimes/linux-musl-x64/native/libcsfml-audio.so.2.6": {
            "assetType": "native",
            "rid": "linux-musl-x64"
          },
          "runtimes/linux-musl-x64/native/libcsfml-graphics.so": {
            "assetType": "native",
            "rid": "linux-musl-x64"
          },
          "runtimes/linux-musl-x64/native/libcsfml-graphics.so.2.6": {
            "assetType": "native",
            "rid": "linux-musl-x64"
          },
          "runtimes/linux-musl-x64/native/libcsfml-system.so": {
            "assetType": "native",
            "rid": "linux-musl-x64"
          },
          "runtimes/linux-musl-x64/native/libcsfml-system.so.2.6": {
            "assetType": "native",
            "rid": "linux-musl-x64"
          },
          "runtimes/linux-musl-x64/native/libcsfml-window.so": {
            "assetType": "native",
            "rid": "linux-musl-x64"
          },
          "runtimes/linux-musl-x64/native/libcsfml-window.so.2.6": {
            "assetType": "native",
            "rid": "linux-musl-x64"
          },
          "runtimes/linux-musl-x64/native/libsfml-audio.so.2.6": {
            "assetType": "native",
            "rid": "linux-musl-x64"
          },
          "runtimes/linux-musl-x64/native/libsfml-graphics.so.2.6": {
            "assetType": "native",
            "rid": "linux-musl-x64"
          },
          "runtimes/linux-musl-x64/native/libsfml-system.so.2.6": {
            "assetType": "native",
            "rid": "linux-musl-x64"
          },
          "runtimes/linux-musl-x64/native/libsfml-window.so.2.6": {
            "assetType": "native",
            "rid": "linux-musl-x64"
          },
          "runtimes/linux-x64/native/libcsfml-audio.so": {
            "assetType": "native",
            "rid": "linux-x64"
          },
          "runtimes/linux-x64/native/libcsfml-audio.so.2.6": {
            "assetType": "native",
            "rid": "linux-x64"
          },
          "runtimes/linux-x64/native/libcsfml-graphics.so": {
            "assetType": "native",
            "rid": "linux-x64"
          },
          "runtimes/linux-x64/native/libcsfml-graphics.so.2.6": {
            "assetType": "native",
            "rid": "linux-x64"
          },
          "runtimes/linux-x64/native/libcsfml-system.so": {
            "assetType": "native",
            "rid": "linux-x64"
          },
          "runtimes/linux-x64/native/libcsfml-system.so.2.6": {
            "assetType": "native",
            "rid": "linux-x64"
          },
          "runtimes/linux-x64/native/libcsfml-window.so": {
            "assetType": "native",
            "rid": "linux-x64"
          },
          "runtimes/linux-x64/native/libcsfml-window.so.2.6": {
            "assetType": "native",
            "rid": "linux-x64"
          },
          "runtimes/linux-x64/native/libsfml-audio.so.2.6": {
            "assetType": "native",
            "rid": "linux-x64"
          },
          "runtimes/linux-x64/native/libsfml-graphics.so.2.6": {
            "assetType": "native",
            "rid": "linux-x64"
          },
          "runtimes/linux-x64/native/libsfml-system.so.2.6": {
            "assetType": "native",
            "rid": "linux-x64"
          },
          "runtimes/linux-x64/native/libsfml-window.so.2.6": {
            "assetType": "native",
            "rid": "linux-x64"
          },
          "runtimes/osx-arm64/native/FLAC.framework/FLAC": {
            "assetType": "native",
            "rid": "osx-arm64"
          },
          "runtimes/osx-arm64/native/FLAC.framework/Resources/Info.plist": {
            "assetType": "native",
            "rid": "osx-arm64"
          },
          "runtimes/osx-arm64/native/FLAC.framework/Versions/A/FLAC": {
            "assetType": "native",
            "rid": "osx-arm64"
          },
          "runtimes/osx-arm64/native/FLAC.framework/Versions/A/Resources/Info.plist": {
            "assetType": "native",
            "rid": "osx-arm64"
          },
          "runtimes/osx-arm64/native/FLAC.framework/Versions/Current/FLAC": {
            "assetType": "native",
            "rid": "osx-arm64"
          },
          "runtimes/osx-arm64/native/FLAC.framework/Versions/Current/Resources/Info.plist": {
            "assetType": "native",
            "rid": "osx-arm64"
          },
          "runtimes/osx-arm64/native/OpenAL.framework/OpenAL": {
            "assetType": "native",
            "rid": "osx-arm64"
          },
          "runtimes/osx-arm64/native/OpenAL.framework/Resources/Info.plist": {
            "assetType": "native",
            "rid": "osx-arm64"
          },
          "runtimes/osx-arm64/native/OpenAL.framework/Versions/A/OpenAL": {
            "assetType": "native",
            "rid": "osx-arm64"
          },
          "runtimes/osx-arm64/native/OpenAL.framework/Versions/A/Resources/Info.plist": {
            "assetType": "native",
            "rid": "osx-arm64"
          },
          "runtimes/osx-arm64/native/OpenAL.framework/Versions/Current/OpenAL": {
            "assetType": "native",
            "rid": "osx-arm64"
          },
          "runtimes/osx-arm64/native/OpenAL.framework/Versions/Current/Resources/Info.plist": {
            "assetType": "native",
            "rid": "osx-arm64"
          },
          "runtimes/osx-arm64/native/freetype.framework/Resources/Info.plist": {
            "assetType": "native",
            "rid": "osx-arm64"
          },
          "runtimes/osx-arm64/native/freetype.framework/Versions/A/Resources/Info.plist": {
            "assetType": "native",
            "rid": "osx-arm64"
          },
          "runtimes/osx-arm64/native/freetype.framework/Versions/A/freetype": {
            "assetType": "native",
            "rid": "osx-arm64"
          },
          "runtimes/osx-arm64/native/freetype.framework/Versions/Current/Resources/Info.plist": {
            "assetType": "native",
            "rid": "osx-arm64"
          },
          "runtimes/osx-arm64/native/freetype.framework/Versions/Current/freetype": {
            "assetType": "native",
            "rid": "osx-arm64"
          },
          "runtimes/osx-arm64/native/freetype.framework/freetype": {
            "assetType": "native",
            "rid": "osx-arm64"
          },
          "runtimes/osx-arm64/native/libcsfml-audio.2.6.dylib": {
            "assetType": "native",
            "rid": "osx-arm64"
          },
          "runtimes/osx-arm64/native/libcsfml-audio.dylib": {
            "assetType": "native",
            "rid": "osx-arm64"
          },
          "runtimes/osx-arm64/native/libcsfml-graphics.2.6.dylib": {
            "assetType": "native",
            "rid": "osx-arm64"
          },
          "runtimes/osx-arm64/native/libcsfml-graphics.dylib": {
            "assetType": "native",
            "rid": "osx-arm64"
          },
          "runtimes/osx-arm64/native/libcsfml-system.2.6.dylib": {
            "assetType": "native",
            "rid": "osx-arm64"
          },
          "runtimes/osx-arm64/native/libcsfml-system.dylib": {
            "assetType": "native",
            "rid": "osx-arm64"
          },
          "runtimes/osx-arm64/native/libcsfml-window.2.6.dylib": {
            "assetType": "native",
            "rid": "osx-arm64"
          },
          "runtimes/osx-arm64/native/libcsfml-window.dylib": {
            "assetType": "native",
            "rid": "osx-arm64"
          },
          "runtimes/osx-arm64/native/libsfml-audio.2.6.dylib": {
            "assetType": "native",
            "rid": "osx-arm64"
          },
          "runtimes/osx-arm64/native/libsfml-graphics.2.6.dylib": {
            "assetType": "native",
            "rid": "osx-arm64"
          },
          "runtimes/osx-arm64/native/libsfml-system.2.6.dylib": {
            "assetType": "native",
            "rid": "osx-arm64"
          },
          "runtimes/osx-arm64/native/libsfml-window.2.6.dylib": {
            "assetType": "native",
            "rid": "osx-arm64"
          },
          "runtimes/osx-arm64/native/ogg.framework/Resources/Info.plist": {
            "assetType": "native",
            "rid": "osx-arm64"
          },
          "runtimes/osx-arm64/native/ogg.framework/Versions/A/Resources/Info.plist": {
            "assetType": "native",
            "rid": "osx-arm64"
          },
          "runtimes/osx-arm64/native/ogg.framework/Versions/A/ogg": {
            "assetType": "native",
            "rid": "osx-arm64"
          },
          "runtimes/osx-arm64/native/ogg.framework/Versions/Current/Resources/Info.plist": {
            "assetType": "native",
            "rid": "osx-arm64"
          },
          "runtimes/osx-arm64/native/ogg.framework/Versions/Current/ogg": {
            "assetType": "native",
            "rid": "osx-arm64"
          },
          "runtimes/osx-arm64/native/ogg.framework/ogg": {
            "assetType": "native",
            "rid": "osx-arm64"
          },
          "runtimes/osx-arm64/native/vorbis.framework/Resources/Info.plist": {
            "assetType": "native",
            "rid": "osx-arm64"
          },
          "runtimes/osx-arm64/native/vorbis.framework/Versions/A/Resources/Info.plist": {
            "assetType": "native",
            "rid": "osx-arm64"
          },
          "runtimes/osx-arm64/native/vorbis.framework/Versions/A/vorbis": {
            "assetType": "native",
            "rid": "osx-arm64"
          },
          "runtimes/osx-arm64/native/vorbis.framework/Versions/Current/Resources/Info.plist": {
            "assetType": "native",
            "rid": "osx-arm64"
          },
          "runtimes/osx-arm64/native/vorbis.framework/Versions/Current/vorbis": {
            "assetType": "native",
            "rid": "osx-arm64"
          },
          "runtimes/osx-arm64/native/vorbis.framework/vorbis": {
            "assetType": "native",
            "rid": "osx-arm64"
          },
          "runtimes/osx-arm64/native/vorbisenc.framework/Resources/Info.plist": {
            "assetType": "native",
            "rid": "osx-arm64"
          },
          "runtimes/osx-arm64/native/vorbisenc.framework/Versions/A/Resources/Info.plist": {
            "assetType": "native",
            "rid": "osx-arm64"
          },
          "runtimes/osx-arm64/native/vorbisenc.framework/Versions/A/vorbisenc": {
            "assetType": "native",
            "rid": "osx-arm64"
          },
          "runtimes/osx-arm64/native/vorbisenc.framework/Versions/Current/Resources/Info.plist": {
            "assetType": "native",
            "rid": "osx-arm64"
          },
          "runtimes/osx-arm64/native/vorbisenc.framework/Versions/Current/vorbisenc": {
            "assetType": "native",
            "rid": "osx-arm64"
          },
          "runtimes/osx-arm64/native/vorbisenc.framework/vorbisenc": {
            "assetType": "native",
            "rid": "osx-arm64"
          },
          "runtimes/osx-arm64/native/vorbisfile.framework/Resources/Info.plist": {
            "assetType": "native",
            "rid": "osx-arm64"
          },
          "runtimes/osx-arm64/native/vorbisfile.framework/Versions/A/Resources/Info.plist": {
            "assetType": "native",
            "rid": "osx-arm64"
          },
          "runtimes/osx-arm64/native/vorbisfile.framework/Versions/A/vorbisfile": {
            "assetType": "native",
            "rid": "osx-arm64"
          },
          "runtimes/osx-arm64/native/vorbisfile.framework/Versions/Current/Resources/Info.plist": {
            "assetType": "native",
            "rid": "osx-arm64"
          },
          "runtimes/osx-arm64/native/vorbisfile.framework/Versions/Current/vorbisfile": {
            "assetType": "native",
            "rid": "osx-arm64"
          },
          "runtimes/osx-arm64/native/vorbisfile.framework/vorbisfile": {
            "assetType": "native",
            "rid": "osx-arm64"
          },
          "runtimes/osx-x64/native/FLAC.framework/FLAC": {
            "assetType": "native",
            "rid": "osx-x64"
          },
          "runtimes/osx-x64/native/FLAC.framework/Resources/Info.plist": {
            "assetType": "native",
            "rid": "osx-x64"
          },
          "runtimes/osx-x64/native/FLAC.framework/Versions/A/FLAC": {
            "assetType": "native",
            "rid": "osx-x64"
          },
          "runtimes/osx-x64/native/FLAC.framework/Versions/A/Resources/Info.plist": {
            "assetType": "native",
            "rid": "osx-x64"
          },
          "runtimes/osx-x64/native/FLAC.framework/Versions/Current/FLAC": {
            "assetType": "native",
            "rid": "osx-x64"
          },
          "runtimes/osx-x64/native/FLAC.framework/Versions/Current/Resources/Info.plist": {
            "assetType": "native",
            "rid": "osx-x64"
          },
          "runtimes/osx-x64/native/OpenAL.framework/OpenAL": {
            "assetType": "native",
            "rid": "osx-x64"
          },
          "runtimes/osx-x64/native/OpenAL.framework/Resources/Info.plist": {
            "assetType": "native",
            "rid": "osx-x64"
          },
          "runtimes/osx-x64/native/OpenAL.framework/Versions/A/OpenAL": {
            "assetType": "native",
            "rid": "osx-x64"
          },
          "runtimes/osx-x64/native/OpenAL.framework/Versions/A/Resources/Info.plist": {
            "assetType": "native",
            "rid": "osx-x64"
          },
          "runtimes/osx-x64/native/OpenAL.framework/Versions/Current/OpenAL": {
            "assetType": "native",
            "rid": "osx-x64"
          },
          "runtimes/osx-x64/native/OpenAL.framework/Versions/Current/Resources/Info.plist": {
            "assetType": "native",
            "rid": "osx-x64"
          },
          "runtimes/osx-x64/native/freetype.framework/Resources/Info.plist": {
            "assetType": "native",
            "rid": "osx-x64"
          },
          "runtimes/osx-x64/native/freetype.framework/Versions/A/Resources/Info.plist": {
            "assetType": "native",
            "rid": "osx-x64"
          },
          "runtimes/osx-x64/native/freetype.framework/Versions/A/freetype": {
            "assetType": "native",
            "rid": "osx-x64"
          },
          "runtimes/osx-x64/native/freetype.framework/Versions/Current/Resources/Info.plist": {
            "assetType": "native",
            "rid": "osx-x64"
          },
          "runtimes/osx-x64/native/freetype.framework/Versions/Current/freetype": {
            "assetType": "native",
            "rid": "osx-x64"
          },
          "runtimes/osx-x64/native/freetype.framework/freetype": {
            "assetType": "native",
            "rid": "osx-x64"
          },
          "runtimes/osx-x64/native/libcsfml-audio.2.6.dylib": {
            "assetType": "native",
            "rid": "osx-x64"
          },
          "runtimes/osx-x64/native/libcsfml-audio.dylib": {
            "assetType": "native",
            "rid": "osx-x64"
          },
          "runtimes/osx-x64/native/libcsfml-graphics.2.6.dylib": {
            "assetType": "native",
            "rid": "osx-x64"
          },
          "runtimes/osx-x64/native/libcsfml-graphics.dylib": {
            "assetType": "native",
            "rid": "osx-x64"
          },
          "runtimes/osx-x64/native/libcsfml-system.2.6.dylib": {
            "assetType": "native",
            "rid": "osx-x64"
          },
          "runtimes/osx-x64/native/libcsfml-system.dylib": {
            "assetType": "native",
            "rid": "osx-x64"
          },
          "runtimes/osx-x64/native/libcsfml-window.2.6.dylib": {
            "assetType": "native",
            "rid": "osx-x64"
          },
          "runtimes/osx-x64/native/libcsfml-window.dylib": {
            "assetType": "native",
            "rid": "osx-x64"
          },
          "runtimes/osx-x64/native/libsfml-audio.2.6.dylib": {
            "assetType": "native",
            "rid": "osx-x64"
          },
          "runtimes/osx-x64/native/libsfml-graphics.2.6.dylib": {
            "assetType": "native",
            "rid": "osx-x64"
          },
          "runtimes/osx-x64/native/libsfml-system.2.6.dylib": {
            "assetType": "native",
            "rid": "osx-x64"
          },
          "runtimes/osx-x64/native/libsfml-window.2.6.dylib": {
            "assetType": "native",
            "rid": "osx-x64"
          },
          "runtimes/osx-x64/native/ogg.framework/Resources/Info.plist": {
            "assetType": "native",
            "rid": "osx-x64"
          },
          "runtimes/osx-x64/native/ogg.framework/Versions/A/Resources/Info.plist": {
            "assetType": "native",
            "rid": "osx-x64"
          },
          "runtimes/osx-x64/native/ogg.framework/Versions/A/ogg": {
            "assetType": "native",
            "rid": "osx-x64"
          },
          "runtimes/osx-x64/native/ogg.framework/Versions/Current/Resources/Info.plist": {
            "assetType": "native",
            "rid": "osx-x64"
          },
          "runtimes/osx-x64/native/ogg.framework/Versions/Current/ogg": {
            "assetType": "native",
            "rid": "osx-x64"
          },
          "runtimes/osx-x64/native/ogg.framework/ogg": {
            "assetType": "native",
            "rid": "osx-x64"
          },
          "runtimes/osx-x64/native/vorbis.framework/Resources/Info.plist": {
            "assetType": "native",
            "rid": "osx-x64"
          },
          "runtimes/osx-x64/native/vorbis.framework/Versions/A/Resources/Info.plist": {
            "assetType": "native",
            "rid": "osx-x64"
          },
          "runtimes/osx-x64/native/vorbis.framework/Versions/A/vorbis": {
            "assetType": "native",
            "rid": "osx-x64"
          },
          "runtimes/osx-x64/native/vorbis.framework/Versions/Current/Resources/Info.plist": {
            "assetType": "native",
            "rid": "osx-x64"
          },
          "runtimes/osx-x64/native/vorbis.framework/Versions/Current/vorbis": {
            "assetType": "native",
            "rid": "osx-x64"
          },
          "runtimes/osx-x64/native/vorbis.framework/vorbis": {
            "assetType": "native",
            "rid": "osx-x64"
          },
          "runtimes/osx-x64/native/vorbisenc.framework/Resources/Info.plist": {
            "assetType": "native",
            "rid": "osx-x64"
          },
          "runtimes/osx-x64/native/vorbisenc.framework/Versions/A/Resources/Info.plist": {
            "assetType": "native",
            "rid": "osx-x64"
          },
          "runtimes/osx-x64/native/vorbisenc.framework/Versions/A/vorbisenc": {
            "assetType": "native",
            "rid": "osx-x64"
          },
          "runtimes/osx-x64/native/vorbisenc.framework/Versions/Current/Resources/Info.plist": {
            "assetType": "native",
            "rid": "osx-x64"
          },
          "runtimes/osx-x64/native/vorbisenc.framework/Versions/Current/vorbisenc": {
            "assetType": "native",
            "rid": "osx-x64"
          },
          "runtimes/osx-x64/native/vorbisenc.framework/vorbisenc": {
            "assetType": "native",
            "rid": "osx-x64"
          },
          "runtimes/osx-x64/native/vorbisfile.framework/Resources/Info.plist": {
            "assetType": "native",
            "rid": "osx-x64"
          },
          "runtimes/osx-x64/native/vorbisfile.framework/Versions/A/Resources/Info.plist": {
            "assetType": "native",
            "rid": "osx-x64"
          },
          "runtimes/osx-x64/native/vorbisfile.framework/Versions/A/vorbisfile": {
            "assetType": "native",
            "rid": "osx-x64"
          },
          "runtimes/osx-x64/native/vorbisfile.framework/Versions/Current/Resources/Info.plist": {
            "assetType": "native",
            "rid": "osx-x64"
          },
          "runtimes/osx-x64/native/vorbisfile.framework/Versions/Current/vorbisfile": {
            "assetType": "native",
            "rid": "osx-x64"
          },
          "runtimes/osx-x64/native/vorbisfile.framework/vorbisfile": {
            "assetType": "native",
            "rid": "osx-x64"
          },
          "runtimes/win-x64/native/csfml-audio.dll": {
            "assetType": "native",
            "rid": "win-x64"
          },
          "runtimes/win-x64/native/csfml-graphics.dll": {
            "assetType": "native",
            "rid": "win-x64"
          },
          "runtimes/win-x64/native/csfml-system.dll": {
            "assetType": "native",
            "rid": "win-x64"
          },
          "runtimes/win-x64/native/csfml-window.dll": {
            "assetType": "native",
            "rid": "win-x64"
          },
          "runtimes/win-x64/native/openal32.dll": {
            "assetType": "native",
            "rid": "win-x64"
          },
          "runtimes/win-x86/native/csfml-audio.dll": {
            "assetType": "native",
            "rid": "win-x86"
          },
          "runtimes/win-x86/native/csfml-graphics.dll": {
            "assetType": "native",
            "rid": "win-x86"
          },
          "runtimes/win-x86/native/csfml-system.dll": {
            "assetType": "native",
            "rid": "win-x86"
          },
          "runtimes/win-x86/native/csfml-window.dll": {
            "assetType": "native",
            "rid": "win-x86"
          },
          "runtimes/win-x86/native/openal32.dll": {
            "assetType": "native",
            "rid": "win-x86"
          }
        }
      },
      "SFML.Audio/2.6.1": {
        "type": "package",
        "dependencies": {
          "CSFML": "[2.6.1, 2.7.0)",
          "SFML.System": "2.6.1"
        },
        "compile": {
          "lib/netstandard2.0/SFML.Audio.dll": {
            "related": ".xml"
          }
        },
        "runtime": {
          "lib/netstandard2.0/SFML.Audio.dll": {
            "related": ".xml"
          }
        }
      },
      "SFML.Graphics/2.6.1": {
        "type": "package",
        "dependencies": {
          "CSFML": "[2.6.1, 2.7.0)",
          "SFML.System": "2.6.1",
          "SFML.Window": "2.6.1"
        },
        "compile": {
          "lib/netstandard2.0/SFML.Graphics.dll": {
            "related": ".xml"
          }
        },
        "runtime": {
          "lib/netstandard2.0/SFML.Graphics.dll": {
            "related": ".xml"
          }
        }
      },
      "SFML.Net/2.6.1": {
        "type": "package",
        "dependencies": {
          "SFML.Audio": "2.6.1",
          "SFML.Graphics": "2.6.1",
          "SFML.System": "2.6.1",
          "SFML.Window": "2.6.1"
        }
      },
      "SFML.System/2.6.1": {
        "type": "package",
        "dependencies": {
          "CSFML": "[2.6.1, 2.7.0)"
        },
        "compile": {
          "lib/netstandard2.0/SFML.System.dll": {
            "related": ".xml"
          }
        },
        "runtime": {
          "lib/netstandard2.0/SFML.System.dll": {
            "related": ".xml"
          }
        }
      },
      "SFML.Window/2.6.1": {
        "type": "package",
        "dependencies": {
          "CSFML": "[2.6.1, 2.7.0)",
          "SFML.System": "2.6.1"
        },
        "compile": {
          "lib/netstandard2.0/SFML.Window.dll": {
            "related": ".xml"
          }
        },
        "runtime": {
          "lib/netstandard2.0/SFML.Window.dll": {
            "related": ".xml"
          }
        }
      }
    }
  },
  "libraries": {
    "CSFML/2.6.1": {
      "sha512": "GLSL1ffzsEVunOwCOXeFNsKgx10sLpU8WIuwnzNgD+uSgsodJQ9S4F9g8dOudjj7icjAJjJbOdZ33bv/lWiy4w==",
      "type": "package",
      "path": "csfml/2.6.1",
      "files": [
        ".nupkg.metadata",
        ".signature.p7s",
        "build/netframework/CSFML.props",
        "build/netframework/CSFML.targets",
        "build/netstandard2.0/CSFML.props",
        "csfml.2.6.1.nupkg.sha512",
        "csfml.nuspec",
        "runtimes/fedora-x64/native/libcsfml-audio.so",
        "runtimes/fedora-x64/native/libcsfml-audio.so.2.6",
        "runtimes/fedora-x64/native/libcsfml-graphics.so",
        "runtimes/fedora-x64/native/libcsfml-graphics.so.2.6",
        "runtimes/fedora-x64/native/libcsfml-system.so",
        "runtimes/fedora-x64/native/libcsfml-system.so.2.6",
        "runtimes/fedora-x64/native/libcsfml-window.so",
        "runtimes/fedora-x64/native/libcsfml-window.so.2.6",
        "runtimes/fedora-x64/native/libsfml-audio.so.2.6",
        "runtimes/fedora-x64/native/libsfml-graphics.so.2.6",
        "runtimes/fedora-x64/native/libsfml-system.so.2.6",
        "runtimes/fedora-x64/native/libsfml-window.so.2.6",
        "runtimes/linux-arm/native/libcsfml-audio.so",
        "runtimes/linux-arm/native/libcsfml-audio.so.2.6",
        "runtimes/linux-arm/native/libcsfml-graphics.so",
        "runtimes/linux-arm/native/libcsfml-graphics.so.2.6",
        "runtimes/linux-arm/native/libcsfml-system.so",
        "runtimes/linux-arm/native/libcsfml-system.so.2.6",
        "runtimes/linux-arm/native/libcsfml-window.so",
        "runtimes/linux-arm/native/libcsfml-window.so.2.6",
        "runtimes/linux-arm/native/libsfml-audio.so.2.6",
        "runtimes/linux-arm/native/libsfml-graphics.so.2.6",
        "runtimes/linux-arm/native/libsfml-system.so.2.6",
        "runtimes/linux-arm/native/libsfml-window.so.2.6",
        "runtimes/linux-arm64/native/libcsfml-audio.so",
        "runtimes/linux-arm64/native/libcsfml-audio.so.2.6",
        "runtimes/linux-arm64/native/libcsfml-graphics.so",
        "runtimes/linux-arm64/native/libcsfml-graphics.so.2.6",
        "runtimes/linux-arm64/native/libcsfml-system.so",
        "runtimes/linux-arm64/native/libcsfml-system.so.2.6",
        "runtimes/linux-arm64/native/libcsfml-window.so",
        "runtimes/linux-arm64/native/libcsfml-window.so.2.6",
        "runtimes/linux-arm64/native/libsfml-audio.so.2.6",
        "runtimes/linux-arm64/native/libsfml-graphics.so.2.6",
        "runtimes/linux-arm64/native/libsfml-system.so.2.6",
        "runtimes/linux-arm64/native/libsfml-window.so.2.6",
        "runtimes/linux-musl-x64/native/libcsfml-audio.so",
        "runtimes/linux-musl-x64/native/libcsfml-audio.so.2.6",
        "runtimes/linux-musl-x64/native/libcsfml-graphics.so",
        "runtimes/linux-musl-x64/native/libcsfml-graphics.so.2.6",
        "runtimes/linux-musl-x64/native/libcsfml-system.so",
        "runtimes/linux-musl-x64/native/libcsfml-system.so.2.6",
        "runtimes/linux-musl-x64/native/libcsfml-window.so",
        "runtimes/linux-musl-x64/native/libcsfml-window.so.2.6",
        "runtimes/linux-musl-x64/native/libsfml-audio.so.2.6",
        "runtimes/linux-musl-x64/native/libsfml-graphics.so.2.6",
        "runtimes/linux-musl-x64/native/libsfml-system.so.2.6",
        "runtimes/linux-musl-x64/native/libsfml-window.so.2.6",
        "runtimes/linux-x64/native/libcsfml-audio.so",
        "runtimes/linux-x64/native/libcsfml-audio.so.2.6",
        "runtimes/linux-x64/native/libcsfml-graphics.so",
        "runtimes/linux-x64/native/libcsfml-graphics.so.2.6",
        "runtimes/linux-x64/native/libcsfml-system.so",
        "runtimes/linux-x64/native/libcsfml-system.so.2.6",
        "runtimes/linux-x64/native/libcsfml-window.so",
        "runtimes/linux-x64/native/libcsfml-window.so.2.6",
        "runtimes/linux-x64/native/libsfml-audio.so.2.6",
        "runtimes/linux-x64/native/libsfml-graphics.so.2.6",
        "runtimes/linux-x64/native/libsfml-system.so.2.6",
        "runtimes/linux-x64/native/libsfml-window.so.2.6",
        "runtimes/osx-arm64/native/FLAC.framework/FLAC",
        "runtimes/osx-arm64/native/FLAC.framework/Resources/Info.plist",
        "runtimes/osx-arm64/native/FLAC.framework/Versions/A/FLAC",
        "runtimes/osx-arm64/native/FLAC.framework/Versions/A/Resources/Info.plist",
        "runtimes/osx-arm64/native/FLAC.framework/Versions/Current/FLAC",
        "runtimes/osx-arm64/native/FLAC.framework/Versions/Current/Resources/Info.plist",
        "runtimes/osx-arm64/native/OpenAL.framework/OpenAL",
        "runtimes/osx-arm64/native/OpenAL.framework/Resources/Info.plist",
        "runtimes/osx-arm64/native/OpenAL.framework/Versions/A/OpenAL",
        "runtimes/osx-arm64/native/OpenAL.framework/Versions/A/Resources/Info.plist",
        "runtimes/osx-arm64/native/OpenAL.framework/Versions/Current/OpenAL",
        "runtimes/osx-arm64/native/OpenAL.framework/Versions/Current/Resources/Info.plist",
        "runtimes/osx-arm64/native/freetype.framework/Resources/Info.plist",
        "runtimes/osx-arm64/native/freetype.framework/Versions/A/Resources/Info.plist",
        "runtimes/osx-arm64/native/freetype.framework/Versions/A/freetype",
        "runtimes/osx-arm64/native/freetype.framework/Versions/Current/Resources/Info.plist",
        "runtimes/osx-arm64/native/freetype.framework/Versions/Current/freetype",
        "runtimes/osx-arm64/native/freetype.framework/freetype",
        "runtimes/osx-arm64/native/libcsfml-audio.2.6.dylib",
        "runtimes/osx-arm64/native/libcsfml-audio.dylib",
        "runtimes/osx-arm64/native/libcsfml-graphics.2.6.dylib",
        "runtimes/osx-arm64/native/libcsfml-graphics.dylib",
        "runtimes/osx-arm64/native/libcsfml-system.2.6.dylib",
        "runtimes/osx-arm64/native/libcsfml-system.dylib",
        "runtimes/osx-arm64/native/libcsfml-window.2.6.dylib",
        "runtimes/osx-arm64/native/libcsfml-window.dylib",
        "runtimes/osx-arm64/native/libsfml-audio.2.6.dylib",
        "runtimes/osx-arm64/native/libsfml-graphics.2.6.dylib",
        "runtimes/osx-arm64/native/libsfml-system.2.6.dylib",
        "runtimes/osx-arm64/native/libsfml-window.2.6.dylib",
        "runtimes/osx-arm64/native/ogg.framework/Resources/Info.plist",
        "runtimes/osx-arm64/native/ogg.framework/Versions/A/Resources/Info.plist",
        "runtimes/osx-arm64/native/ogg.framework/Versions/A/ogg",
        "runtimes/osx-arm64/native/ogg.framework/Versions/Current/Resources/Info.plist",
        "runtimes/osx-arm64/native/ogg.framework/Versions/Current/ogg",
        "runtimes/osx-arm64/native/ogg.framework/ogg",
        "runtimes/osx-arm64/native/vorbis.framework/Resources/Info.plist",
        "runtimes/osx-arm64/native/vorbis.framework/Versions/A/Resources/Info.plist",
        "runtimes/osx-arm64/native/vorbis.framework/Versions/A/vorbis",
        "runtimes/osx-arm64/native/vorbis.framework/Versions/Current/Resources/Info.plist",
        "runtimes/osx-arm64/native/vorbis.framework/Versions/Current/vorbis",
        "runtimes/osx-arm64/native/vorbis.framework/vorbis",
        "runtimes/osx-arm64/native/vorbisenc.framework/Resources/Info.plist",
        "runtimes/osx-arm64/native/vorbisenc.framework/Versions/A/Resources/Info.plist",
        "runtimes/osx-arm64/native/vorbisenc.framework/Versions/A/vorbisenc",
        "runtimes/osx-arm64/native/vorbisenc.framework/Versions/Current/Resources/Info.plist",
        "runtimes/osx-arm64/native/vorbisenc.framework/Versions/Current/vorbisenc",
        "runtimes/osx-arm64/native/vorbisenc.framework/vorbisenc",
        "runtimes/osx-arm64/native/vorbisfile.framework/Resources/Info.plist",
        "runtimes/osx-arm64/native/vorbisfile.framework/Versions/A/Resources/Info.plist",
        "runtimes/osx-arm64/native/vorbisfile.framework/Versions/A/vorbisfile",
        "runtimes/osx-arm64/native/vorbisfile.framework/Versions/Current/Resources/Info.plist",
        "runtimes/osx-arm64/native/vorbisfile.framework/Versions/Current/vorbisfile",
        "runtimes/osx-arm64/native/vorbisfile.framework/vorbisfile",
        "runtimes/osx-x64/native/FLAC.framework/FLAC",
        "runtimes/osx-x64/native/FLAC.framework/Resources/Info.plist",
        "runtimes/osx-x64/native/FLAC.framework/Versions/A/FLAC",
        "runtimes/osx-x64/native/FLAC.framework/Versions/A/Resources/Info.plist",
        "runtimes/osx-x64/native/FLAC.framework/Versions/Current/FLAC",
        "runtimes/osx-x64/native/FLAC.framework/Versions/Current/Resources/Info.plist",
        "runtimes/osx-x64/native/OpenAL.framework/OpenAL",
        "runtimes/osx-x64/native/OpenAL.framework/Resources/Info.plist",
        "runtimes/osx-x64/native/OpenAL.framework/Versions/A/OpenAL",
        "runtimes/osx-x64/native/OpenAL.framework/Versions/A/Resources/Info.plist",
        "runtimes/osx-x64/native/OpenAL.framework/Versions/Current/OpenAL",
        "runtimes/osx-x64/native/OpenAL.framework/Versions/Current/Resources/Info.plist",
        "runtimes/osx-x64/native/freetype.framework/Resources/Info.plist",
        "runtimes/osx-x64/native/freetype.framework/Versions/A/Resources/Info.plist",
        "runtimes/osx-x64/native/freetype.framework/Versions/A/freetype",
        "runtimes/osx-x64/native/freetype.framework/Versions/Current/Resources/Info.plist",
        "runtimes/osx-x64/native/freetype.framework/Versions/Current/freetype",
        "runtimes/osx-x64/native/freetype.framework/freetype",
        "runtimes/osx-x64/native/libcsfml-audio.2.6.dylib",
        "runtimes/osx-x64/native/libcsfml-audio.dylib",
        "runtimes/osx-x64/native/libcsfml-graphics.2.6.dylib",
        "runtimes/osx-x64/native/libcsfml-graphics.dylib",
        "runtimes/osx-x64/native/libcsfml-system.2.6.dylib",
        "runtimes/osx-x64/native/libcsfml-system.dylib",
        "runtimes/osx-x64/native/libcsfml-window.2.6.dylib",
        "runtimes/osx-x64/native/libcsfml-window.dylib",
        "runtimes/osx-x64/native/libsfml-audio.2.6.dylib",
        "runtimes/osx-x64/native/libsfml-graphics.2.6.dylib",
        "runtimes/osx-x64/native/libsfml-system.2.6.dylib",
        "runtimes/osx-x64/native/libsfml-window.2.6.dylib",
        "runtimes/osx-x64/native/ogg.framework/Resources/Info.plist",
        "runtimes/osx-x64/native/ogg.framework/Versions/A/Resources/Info.plist",
        "runtimes/osx-x64/native/ogg.framework/Versions/A/ogg",
        "runtimes/osx-x64/native/ogg.framework/Versions/Current/Resources/Info.plist",
        "runtimes/osx-x64/native/ogg.framework/Versions/Current/ogg",
        "runtimes/osx-x64/native/ogg.framework/ogg",
        "runtimes/osx-x64/native/vorbis.framework/Resources/Info.plist",
        "runtimes/osx-x64/native/vorbis.framework/Versions/A/Resources/Info.plist",
        "runtimes/osx-x64/native/vorbis.framework/Versions/A/vorbis",
        "runtimes/osx-x64/native/vorbis.framework/Versions/Current/Resources/Info.plist",
        "runtimes/osx-x64/native/vorbis.framework/Versions/Current/vorbis",
        "runtimes/osx-x64/native/vorbis.framework/vorbis",
        "runtimes/osx-x64/native/vorbisenc.framework/Resources/Info.plist",
        "runtimes/osx-x64/native/vorbisenc.framework/Versions/A/Resources/Info.plist",
        "runtimes/osx-x64/native/vorbisenc.framework/Versions/A/vorbisenc",
        "runtimes/osx-x64/native/vorbisenc.framework/Versions/Current/Resources/Info.plist",
        "runtimes/osx-x64/native/vorbisenc.framework/Versions/Current/vorbisenc",
        "runtimes/osx-x64/native/vorbisenc.framework/vorbisenc",
        "runtimes/osx-x64/native/vorbisfile.framework/Resources/Info.plist",
        "runtimes/osx-x64/native/vorbisfile.framework/Versions/A/Resources/Info.plist",
        "runtimes/osx-x64/native/vorbisfile.framework/Versions/A/vorbisfile",
        "runtimes/osx-x64/native/vorbisfile.framework/Versions/Current/Resources/Info.plist",
        "runtimes/osx-x64/native/vorbisfile.framework/Versions/Current/vorbisfile",
        "runtimes/osx-x64/native/vorbisfile.framework/vorbisfile",
        "runtimes/win-x64/native/csfml-audio.dll",
        "runtimes/win-x64/native/csfml-graphics.dll",
        "runtimes/win-x64/native/csfml-system.dll",
        "runtimes/win-x64/native/csfml-window.dll",
        "runtimes/win-x64/native/openal32.dll",
        "runtimes/win-x86/native/csfml-audio.dll",
        "runtimes/win-x86/native/csfml-graphics.dll",
        "runtimes/win-x86/native/csfml-system.dll",
        "runtimes/win-x86/native/csfml-window.dll",
        "runtimes/win-x86/native/openal32.dll",
        "sfml-icon.png"
      ]
    },
    "SFML.Audio/2.6.1": {
      "sha512": "MsIlMTEeG623UYw3/Sb2qVw94xEHOxamUENuxbjSz4QiTsfCNQNEADpfTbXKI/FS5u7y/FsNmk+4II2iEf8MMw==",
      "type": "package",
      "path": "sfml.audio/2.6.1",
      "files": [
        ".nupkg.metadata",
        ".signature.p7s",
        "README.md",
        "lib/netstandard2.0/SFML.Audio.dll",
        "lib/netstandard2.0/SFML.Audio.xml",
        "sfml-icon.png",
        "sfml.audio.2.6.1.nupkg.sha512",
        "sfml.audio.nuspec"
      ]
    },
    "SFML.Graphics/2.6.1": {
      "sha512": "pOtL7ss6r3m7P3MbZ4Oytjzug2mWJ5OHblZHlISIhb6IezmsFmBxqLsIq0YoyWGcAL4cgSXqDmflJivKpXgdtg==",
      "type": "package",
      "path": "sfml.graphics/2.6.1",
      "files": [
        ".nupkg.metadata",
        ".signature.p7s",
        "README.md",
        "lib/netstandard2.0/SFML.Graphics.dll",
        "lib/netstandard2.0/SFML.Graphics.xml",
        "sfml-icon.png",
        "sfml.graphics.2.6.1.nupkg.sha512",
        "sfml.graphics.nuspec"
      ]
    },
    "SFML.Net/2.6.1": {
      "sha512": "OWjTdbVi86gTYHjlSB3Y77ZWDy01iIVMXfb5ApX3L5yp455VDmF828wBIc2+bfPxJDFSHgJ82LpZM5jFNUS/QA==",
      "type": "package",
      "path": "sfml.net/2.6.1",
      "files": [
        ".nupkg.metadata",
        ".signature.p7s",
        "README.md",
        "sfml-icon.png",
        "sfml.net.2.6.1.nupkg.sha512",
        "sfml.net.nuspec"
      ]
    },
    "SFML.System/2.6.1": {
      "sha512": "/3EV59uiMWxADWWSiqAOS+8FK4Da2r6RoZEujG14kLGYtQzNj4rV4pjjycyH30WWDONSedxmLT9chf8XN70+BQ==",
      "type": "package",
      "path": "sfml.system/2.6.1",
      "files": [
        ".nupkg.metadata",
        ".signature.p7s",
        "README.md",
        "lib/netstandard2.0/SFML.System.dll",
        "lib/netstandard2.0/SFML.System.xml",
        "sfml-icon.png",
        "sfml.system.2.6.1.nupkg.sha512",
        "sfml.system.nuspec"
      ]
    },
    "SFML.Window/2.6.1": {
      "sha512": "lzt42WWZiYvoMrDwvc4lpl6t/GH6AhvHI+inw/Aoh1v6xAO8GDnzzLVsaKi+RfPqdL2mHsih1qUZucuvAmoGdg==",
      "type": "package",
      "path": "sfml.window/2.6.1",
      "files": [
        ".nupkg.metadata",
        ".signature.p7s",
        "README.md",
        "lib/netstandard2.0/SFML.Window.dll",
        "lib/netstandard2.0/SFML.Window.xml",
        "sfml-icon.png",
        "sfml.window.2.6.1.nupkg.sha512",
        "sfml.window.nuspec"
      ]
    }
  },
  "projectFileDependencyGroups": {
    "net8.0": [
      "SFML.Net >= 2.6.1"
    ]
  },
  "packageFolders": {
    "C:\\Users\\avirt\\.nuget\\packages\\": {},
    "C:\\Program Files (x86)\\Microsoft Visual Studio\\Shared\\NuGetPackages": {}
  },
  "project": {
    "version": "1.0.0",
    "restore": {
      "projectUniqueName": "C:\\Users\\avirt\\source\\repos\\CosmoEngine\\KnifeEngine\\KnifeEngine\\KnifeEngine.csproj",
      "projectName": "KnifeEngine",
      "projectPath": "C:\\Users\\avirt\\source\\repos\\CosmoEngine\\KnifeEngine\\KnifeEngine\\KnifeEngine.csproj",
      "packagesPath": "C:\\Users\\avirt\\.nuget\\packages\\",
      "outputPath": "C:\\Users\\avirt\\source\\repos\\CosmoEngine\\KnifeEngine\\KnifeEngine\\obj\\",
      "projectStyle": "PackageReference",
      "fallbackFolders": [
        "C:\\Program Files (x86)\\Microsoft Visual Studio\\Shared\\NuGetPackages"
      ],
      "configFilePaths": [
        "C:\\Users\\avirt\\AppData\\Roaming\\NuGet\\NuGet.Config",
        "C:\\Program Files (x86)\\NuGet\\Config\\Microsoft.VisualStudio.FallbackLocation.config",
        "C:\\Program Files (x86)\\NuGet\\Config\\Microsoft.VisualStudio.Offline.config"
      ],
      "originalTargetFrameworks": [
        "net8.0"
      ],
      "sources": {
        "C:\\Program Files (x86)\\Microsoft SDKs\\NuGetPackages\\": {},
        "C:\\Program Files\\dotnet\\library-packs": {},
        "C:\\Users\\avirt\\AppData\\Roaming\\Cosmos User Kit\\packages\\": {},
        "https://api.nuget.org/v3/index.json": {}
      },
      "frameworks": {
        "net8.0": {
          "targetAlias": "net8.0",
          "projectReferences": {}
        }
      },
      "warningProperties": {
        "warnAsError": [
          "NU1605"
        ]
      },
      "restoreAuditProperties": {
        "enableAudit": "true",
        "auditLevel": "low",
        "auditMode": "direct"
      },
      "SdkAnalysisLevel": "9.0.300"
    },
    "frameworks": {
      "net8.0": {
        "targetAlias": "net8.0",
        "dependencies": {
          "SFML.Net": {
            "target": "Package",
            "version": "[2.6.1, )"
          }
        },
        "imports": [
          "net461",
          "net462",
          "net47",
          "net471",
          "net472",
          "net48",
          "net481"
        ],
        "assetTargetFallback": true,
        "warn": true,
        "frameworkReferences": {
          "Microsoft.NETCore.App": {
            "privateAssets": "all"
          }
        },
        "runtimeIdentifierGraphPath": "C:\\Program Files\\dotnet\\sdk\\9.0.301/PortableRuntimeIdentifierGraph.json"
      }
    }
  }
}
```

### Файл: obj\ZypEngine.csproj.nuget.dgspec.json
```json
{
  "format": 1,
  "restore": {
    "C:\\Users\\avirt\\source\\repos\\CosmoEngine\\ZypEngine\\ZypEngine\\ZypEngine.csproj": {}
  },
  "projects": {
    "C:\\Users\\avirt\\source\\repos\\CosmoEngine\\ZypEngine\\ZypEngine\\ZypEngine.csproj": {
      "version": "1.0.0",
      "restore": {
        "projectUniqueName": "C:\\Users\\avirt\\source\\repos\\CosmoEngine\\ZypEngine\\ZypEngine\\ZypEngine.csproj",
        "projectName": "ZypEngine",
        "projectPath": "C:\\Users\\avirt\\source\\repos\\CosmoEngine\\ZypEngine\\ZypEngine\\ZypEngine.csproj",
        "packagesPath": "C:\\Users\\avirt\\.nuget\\packages\\",
        "outputPath": "C:\\Users\\avirt\\source\\repos\\CosmoEngine\\ZypEngine\\ZypEngine\\obj\\",
        "projectStyle": "PackageReference",
        "fallbackFolders": [
          "C:\\Program Files (x86)\\Microsoft Visual Studio\\Shared\\NuGetPackages"
        ],
        "configFilePaths": [
          "C:\\Users\\avirt\\AppData\\Roaming\\NuGet\\NuGet.Config",
          "C:\\Program Files (x86)\\NuGet\\Config\\Microsoft.VisualStudio.FallbackLocation.config",
          "C:\\Program Files (x86)\\NuGet\\Config\\Microsoft.VisualStudio.Offline.config"
        ],
        "originalTargetFrameworks": [
          "net8.0"
        ],
        "sources": {
          "C:\\Program Files (x86)\\Microsoft SDKs\\NuGetPackages\\": {},
          "C:\\Program Files\\dotnet\\library-packs": {},
          "C:\\Users\\avirt\\AppData\\Roaming\\Cosmos User Kit\\packages\\": {},
          "https://api.nuget.org/v3/index.json": {}
        },
        "frameworks": {
          "net8.0": {
            "targetAlias": "net8.0",
            "projectReferences": {}
          }
        },
        "warningProperties": {
          "warnAsError": [
            "NU1605"
          ]
        },
        "restoreAuditProperties": {
          "enableAudit": "true",
          "auditLevel": "low",
          "auditMode": "direct"
        },
        "SdkAnalysisLevel": "9.0.300"
      },
      "frameworks": {
        "net8.0": {
          "targetAlias": "net8.0",
          "dependencies": {
            "SFML.Net": {
              "target": "Package",
              "version": "[2.6.1, )"
            }
          },
          "imports": [
            "net461",
            "net462",
            "net47",
            "net471",
            "net472",
            "net48",
            "net481"
          ],
          "assetTargetFallback": true,
          "warn": true,
          "frameworkReferences": {
            "Microsoft.NETCore.App": {
              "privateAssets": "all"
            }
          },
          "runtimeIdentifierGraphPath": "C:\\Program Files\\dotnet\\sdk\\9.0.301/PortableRuntimeIdentifierGraph.json"
        }
      }
    }
  }
}
```

### Файл: obj\ZypEngine.csproj.nuget.g.props *(бинарный файл)*

### Файл: obj\ZypEngine.csproj.nuget.g.targets *(бинарный файл)*


## Директория: obj\Debug


## Директория: obj\Debug\net8.0

### Файл: obj\Debug\net8.0\.NETCoreApp,Version=v8.0.AssemblyAttributes.cs *(бинарный файл)*

### Файл: obj\Debug\net8.0\apphost.exe *(бинарный файл)*

### Файл: obj\Debug\net8.0\KnifeEngine.AssemblyInfo.cs *(бинарный файл)*

### Файл: obj\Debug\net8.0\KnifeEngine.csproj.BuildWithSkipAnalyzers *(бинарный файл)*

### Файл: obj\Debug\net8.0\KnifeEngine.csproj.FileListAbsolute.txt
```txt
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\obj\Debug\net8.0\KnifeEngine.csproj.AssemblyReference.cache
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\obj\Debug\net8.0\KnifeEngine.GeneratedMSBuildEditorConfig.editorconfig
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\obj\Debug\net8.0\KnifeEngine.AssemblyInfoInputs.cache
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\obj\Debug\net8.0\KnifeEngine.AssemblyInfo.cs
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\obj\Debug\net8.0\KnifeEngine.csproj.CoreCompileInputs.cache
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\KnifeEngine.exe
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\KnifeEngine.deps.json
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\KnifeEngine.runtimeconfig.json
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\KnifeEngine.dll
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\KnifeEngine.pdb
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\SFML.Audio.dll
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\SFML.Graphics.dll
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\SFML.System.dll
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\SFML.Window.dll
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\fedora-x64\native\libcsfml-audio.so
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\fedora-x64\native\libcsfml-audio.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\fedora-x64\native\libcsfml-graphics.so
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\fedora-x64\native\libcsfml-graphics.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\fedora-x64\native\libcsfml-system.so
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\fedora-x64\native\libcsfml-system.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\fedora-x64\native\libcsfml-window.so
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\fedora-x64\native\libcsfml-window.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\fedora-x64\native\libsfml-audio.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\fedora-x64\native\libsfml-graphics.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\fedora-x64\native\libsfml-system.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\fedora-x64\native\libsfml-window.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\linux-arm\native\libcsfml-audio.so
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\linux-arm\native\libcsfml-audio.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\linux-arm\native\libcsfml-graphics.so
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\linux-arm\native\libcsfml-graphics.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\linux-arm\native\libcsfml-system.so
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\linux-arm\native\libcsfml-system.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\linux-arm\native\libcsfml-window.so
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\linux-arm\native\libcsfml-window.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\linux-arm\native\libsfml-audio.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\linux-arm\native\libsfml-graphics.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\linux-arm\native\libsfml-system.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\linux-arm\native\libsfml-window.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\linux-arm64\native\libcsfml-audio.so
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\linux-arm64\native\libcsfml-audio.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\linux-arm64\native\libcsfml-graphics.so
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\linux-arm64\native\libcsfml-graphics.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\linux-arm64\native\libcsfml-system.so
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\linux-arm64\native\libcsfml-system.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\linux-arm64\native\libcsfml-window.so
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\linux-arm64\native\libcsfml-window.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\linux-arm64\native\libsfml-audio.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\linux-arm64\native\libsfml-graphics.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\linux-arm64\native\libsfml-system.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\linux-arm64\native\libsfml-window.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\linux-musl-x64\native\libcsfml-audio.so
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\linux-musl-x64\native\libcsfml-audio.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\linux-musl-x64\native\libcsfml-graphics.so
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\linux-musl-x64\native\libcsfml-graphics.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\linux-musl-x64\native\libcsfml-system.so
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\linux-musl-x64\native\libcsfml-system.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\linux-musl-x64\native\libcsfml-window.so
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\linux-musl-x64\native\libcsfml-window.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\linux-musl-x64\native\libsfml-audio.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\linux-musl-x64\native\libsfml-graphics.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\linux-musl-x64\native\libsfml-system.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\linux-musl-x64\native\libsfml-window.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\linux-x64\native\libcsfml-audio.so
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\linux-x64\native\libcsfml-audio.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\linux-x64\native\libcsfml-graphics.so
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\linux-x64\native\libcsfml-graphics.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\linux-x64\native\libcsfml-system.so
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\linux-x64\native\libcsfml-system.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\linux-x64\native\libcsfml-window.so
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\linux-x64\native\libcsfml-window.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\linux-x64\native\libsfml-audio.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\linux-x64\native\libsfml-graphics.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\linux-x64\native\libsfml-system.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\linux-x64\native\libsfml-window.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\FLAC.framework\FLAC
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\FLAC.framework\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\FLAC.framework\Versions\A\FLAC
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\FLAC.framework\Versions\A\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\FLAC.framework\Versions\Current\FLAC
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\FLAC.framework\Versions\Current\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\OpenAL.framework\OpenAL
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\OpenAL.framework\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\OpenAL.framework\Versions\A\OpenAL
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\OpenAL.framework\Versions\A\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\OpenAL.framework\Versions\Current\OpenAL
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\OpenAL.framework\Versions\Current\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\freetype.framework\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\freetype.framework\Versions\A\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\freetype.framework\Versions\A\freetype
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\freetype.framework\Versions\Current\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\freetype.framework\Versions\Current\freetype
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\freetype.framework\freetype
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\libcsfml-audio.2.6.dylib
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\libcsfml-audio.dylib
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\libcsfml-graphics.2.6.dylib
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\libcsfml-graphics.dylib
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\libcsfml-system.2.6.dylib
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\libcsfml-system.dylib
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\libcsfml-window.2.6.dylib
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\libcsfml-window.dylib
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\libsfml-audio.2.6.dylib
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\libsfml-graphics.2.6.dylib
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\libsfml-system.2.6.dylib
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\libsfml-window.2.6.dylib
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\ogg.framework\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\ogg.framework\Versions\A\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\ogg.framework\Versions\A\ogg
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\ogg.framework\Versions\Current\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\ogg.framework\Versions\Current\ogg
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\ogg.framework\ogg
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\vorbis.framework\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\vorbis.framework\Versions\A\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\vorbis.framework\Versions\A\vorbis
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\vorbis.framework\Versions\Current\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\vorbis.framework\Versions\Current\vorbis
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\vorbis.framework\vorbis
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\vorbisenc.framework\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\vorbisenc.framework\Versions\A\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\vorbisenc.framework\Versions\A\vorbisenc
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\vorbisenc.framework\Versions\Current\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\vorbisenc.framework\Versions\Current\vorbisenc
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\vorbisenc.framework\vorbisenc
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\vorbisfile.framework\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\vorbisfile.framework\Versions\A\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\vorbisfile.framework\Versions\A\vorbisfile
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\vorbisfile.framework\Versions\Current\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\vorbisfile.framework\Versions\Current\vorbisfile
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\vorbisfile.framework\vorbisfile
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-x64\native\FLAC.framework\FLAC
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-x64\native\FLAC.framework\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-x64\native\FLAC.framework\Versions\A\FLAC
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-x64\native\FLAC.framework\Versions\A\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-x64\native\FLAC.framework\Versions\Current\FLAC
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-x64\native\FLAC.framework\Versions\Current\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-x64\native\OpenAL.framework\OpenAL
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-x64\native\OpenAL.framework\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-x64\native\OpenAL.framework\Versions\A\OpenAL
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-x64\native\OpenAL.framework\Versions\A\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-x64\native\OpenAL.framework\Versions\Current\OpenAL
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-x64\native\OpenAL.framework\Versions\Current\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-x64\native\freetype.framework\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-x64\native\freetype.framework\Versions\A\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-x64\native\freetype.framework\Versions\A\freetype
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-x64\native\freetype.framework\Versions\Current\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-x64\native\freetype.framework\Versions\Current\freetype
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-x64\native\freetype.framework\freetype
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-x64\native\libcsfml-audio.2.6.dylib
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-x64\native\libcsfml-audio.dylib
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-x64\native\libcsfml-graphics.2.6.dylib
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-x64\native\libcsfml-graphics.dylib
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-x64\native\libcsfml-system.2.6.dylib
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-x64\native\libcsfml-system.dylib
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-x64\native\libcsfml-window.2.6.dylib
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-x64\native\libcsfml-window.dylib
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-x64\native\libsfml-audio.2.6.dylib
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-x64\native\libsfml-graphics.2.6.dylib
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-x64\native\libsfml-system.2.6.dylib
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-x64\native\libsfml-window.2.6.dylib
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-x64\native\ogg.framework\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-x64\native\ogg.framework\Versions\A\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-x64\native\ogg.framework\Versions\A\ogg
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-x64\native\ogg.framework\Versions\Current\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-x64\native\ogg.framework\Versions\Current\ogg
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-x64\native\ogg.framework\ogg
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-x64\native\vorbis.framework\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-x64\native\vorbis.framework\Versions\A\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-x64\native\vorbis.framework\Versions\A\vorbis
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-x64\native\vorbis.framework\Versions\Current\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-x64\native\vorbis.framework\Versions\Current\vorbis
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-x64\native\vorbis.framework\vorbis
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-x64\native\vorbisenc.framework\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-x64\native\vorbisenc.framework\Versions\A\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-x64\native\vorbisenc.framework\Versions\A\vorbisenc
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-x64\native\vorbisenc.framework\Versions\Current\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-x64\native\vorbisenc.framework\Versions\Current\vorbisenc
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-x64\native\vorbisenc.framework\vorbisenc
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-x64\native\vorbisfile.framework\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-x64\native\vorbisfile.framework\Versions\A\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-x64\native\vorbisfile.framework\Versions\A\vorbisfile
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-x64\native\vorbisfile.framework\Versions\Current\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-x64\native\vorbisfile.framework\Versions\Current\vorbisfile
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\osx-x64\native\vorbisfile.framework\vorbisfile
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\win-x64\native\csfml-audio.dll
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\win-x64\native\csfml-graphics.dll
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\win-x64\native\csfml-system.dll
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\win-x64\native\csfml-window.dll
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\win-x64\native\openal32.dll
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\win-x86\native\csfml-audio.dll
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\win-x86\native\csfml-graphics.dll
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\win-x86\native\csfml-system.dll
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\win-x86\native\csfml-window.dll
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\bin\Debug\net8.0\runtimes\win-x86\native\openal32.dll
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\obj\Debug\net8.0\KnifeEng.59207B80.Up2Date
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\obj\Debug\net8.0\KnifeEngine.dll
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\obj\Debug\net8.0\refint\KnifeEngine.dll
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\obj\Debug\net8.0\KnifeEngine.pdb
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\obj\Debug\net8.0\KnifeEngine.genruntimeconfig.cache
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\obj\Debug\net8.0\ref\KnifeEngine.dll
C:\Users\avirt\source\repos\CosmoEngine\KnifeEngine\KnifeEngine\obj\Debug\net8.0\KnifeEngine.sourcelink.json

```

### Файл: obj\Debug\net8.0\KnifeEngine.dll *(бинарный файл)*

### Файл: obj\Debug\net8.0\KnifeEngine.GeneratedMSBuildEditorConfig.editorconfig *(бинарный файл)*

### Файл: obj\Debug\net8.0\KnifeEngine.GlobalUsings.g.cs *(бинарный файл)*

### Файл: obj\Debug\net8.0\KnifeEngine.pdb *(бинарный файл)*

### Файл: obj\Debug\net8.0\KnifeEngine.sourcelink.json
```json
{"documents":{"C:\\Users\\avirt\\source\\repos\\CosmoEngine\\KnifeEngine\\*":"https://raw.githubusercontent.com/UndefinedClear/KnifeEngine/6bb544e1c6995f035ef714f6db5e92533e3326c5/*"}}
```

### Файл: obj\Debug\net8.0\KnightEngine.AssemblyInfo.cs *(бинарный файл)*

### Файл: obj\Debug\net8.0\KnightEngine.csproj.BuildWithSkipAnalyzers *(бинарный файл)*

### Файл: obj\Debug\net8.0\KnightEngine.csproj.FileListAbsolute.txt
```txt
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\KnightEngine.exe
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\KnightEngine.deps.json
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\KnightEngine.runtimeconfig.json
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\KnightEngine.dll
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\KnightEngine.pdb
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\SFML.Audio.dll
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\SFML.Graphics.dll
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\SFML.System.dll
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\SFML.Window.dll
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\fedora-x64\native\libcsfml-audio.so
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\fedora-x64\native\libcsfml-audio.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\fedora-x64\native\libcsfml-graphics.so
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\fedora-x64\native\libcsfml-graphics.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\fedora-x64\native\libcsfml-system.so
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\fedora-x64\native\libcsfml-system.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\fedora-x64\native\libcsfml-window.so
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\fedora-x64\native\libcsfml-window.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\fedora-x64\native\libsfml-audio.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\fedora-x64\native\libsfml-graphics.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\fedora-x64\native\libsfml-system.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\fedora-x64\native\libsfml-window.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\linux-arm\native\libcsfml-audio.so
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\linux-arm\native\libcsfml-audio.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\linux-arm\native\libcsfml-graphics.so
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\linux-arm\native\libcsfml-graphics.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\linux-arm\native\libcsfml-system.so
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\linux-arm\native\libcsfml-system.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\linux-arm\native\libcsfml-window.so
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\linux-arm\native\libcsfml-window.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\linux-arm\native\libsfml-audio.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\linux-arm\native\libsfml-graphics.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\linux-arm\native\libsfml-system.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\linux-arm\native\libsfml-window.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\linux-arm64\native\libcsfml-audio.so
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\linux-arm64\native\libcsfml-audio.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\linux-arm64\native\libcsfml-graphics.so
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\linux-arm64\native\libcsfml-graphics.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\linux-arm64\native\libcsfml-system.so
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\linux-arm64\native\libcsfml-system.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\linux-arm64\native\libcsfml-window.so
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\linux-arm64\native\libcsfml-window.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\linux-arm64\native\libsfml-audio.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\linux-arm64\native\libsfml-graphics.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\linux-arm64\native\libsfml-system.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\linux-arm64\native\libsfml-window.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\linux-musl-x64\native\libcsfml-audio.so
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\linux-musl-x64\native\libcsfml-audio.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\linux-musl-x64\native\libcsfml-graphics.so
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\linux-musl-x64\native\libcsfml-graphics.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\linux-musl-x64\native\libcsfml-system.so
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\linux-musl-x64\native\libcsfml-system.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\linux-musl-x64\native\libcsfml-window.so
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\linux-musl-x64\native\libcsfml-window.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\linux-musl-x64\native\libsfml-audio.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\linux-musl-x64\native\libsfml-graphics.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\linux-musl-x64\native\libsfml-system.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\linux-musl-x64\native\libsfml-window.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\linux-x64\native\libcsfml-audio.so
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\linux-x64\native\libcsfml-audio.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\linux-x64\native\libcsfml-graphics.so
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\linux-x64\native\libcsfml-graphics.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\linux-x64\native\libcsfml-system.so
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\linux-x64\native\libcsfml-system.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\linux-x64\native\libcsfml-window.so
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\linux-x64\native\libcsfml-window.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\linux-x64\native\libsfml-audio.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\linux-x64\native\libsfml-graphics.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\linux-x64\native\libsfml-system.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\linux-x64\native\libsfml-window.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\FLAC.framework\FLAC
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\FLAC.framework\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\FLAC.framework\Versions\A\FLAC
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\FLAC.framework\Versions\A\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\FLAC.framework\Versions\Current\FLAC
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\FLAC.framework\Versions\Current\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\OpenAL.framework\OpenAL
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\OpenAL.framework\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\OpenAL.framework\Versions\A\OpenAL
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\OpenAL.framework\Versions\A\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\OpenAL.framework\Versions\Current\OpenAL
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\OpenAL.framework\Versions\Current\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\freetype.framework\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\freetype.framework\Versions\A\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\freetype.framework\Versions\A\freetype
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\freetype.framework\Versions\Current\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\freetype.framework\Versions\Current\freetype
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\freetype.framework\freetype
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\libcsfml-audio.2.6.dylib
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\libcsfml-audio.dylib
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\libcsfml-graphics.2.6.dylib
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\libcsfml-graphics.dylib
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\libcsfml-system.2.6.dylib
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\libcsfml-system.dylib
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\libcsfml-window.2.6.dylib
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\libcsfml-window.dylib
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\libsfml-audio.2.6.dylib
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\libsfml-graphics.2.6.dylib
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\libsfml-system.2.6.dylib
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\libsfml-window.2.6.dylib
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\ogg.framework\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\ogg.framework\Versions\A\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\ogg.framework\Versions\A\ogg
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\ogg.framework\Versions\Current\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\ogg.framework\Versions\Current\ogg
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\ogg.framework\ogg
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\vorbis.framework\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\vorbis.framework\Versions\A\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\vorbis.framework\Versions\A\vorbis
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\vorbis.framework\Versions\Current\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\vorbis.framework\Versions\Current\vorbis
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\vorbis.framework\vorbis
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\vorbisenc.framework\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\vorbisenc.framework\Versions\A\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\vorbisenc.framework\Versions\A\vorbisenc
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\vorbisenc.framework\Versions\Current\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\vorbisenc.framework\Versions\Current\vorbisenc
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\vorbisenc.framework\vorbisenc
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\vorbisfile.framework\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\vorbisfile.framework\Versions\A\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\vorbisfile.framework\Versions\A\vorbisfile
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\vorbisfile.framework\Versions\Current\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\vorbisfile.framework\Versions\Current\vorbisfile
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\vorbisfile.framework\vorbisfile
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-x64\native\FLAC.framework\FLAC
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-x64\native\FLAC.framework\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-x64\native\FLAC.framework\Versions\A\FLAC
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-x64\native\FLAC.framework\Versions\A\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-x64\native\FLAC.framework\Versions\Current\FLAC
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-x64\native\FLAC.framework\Versions\Current\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-x64\native\OpenAL.framework\OpenAL
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-x64\native\OpenAL.framework\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-x64\native\OpenAL.framework\Versions\A\OpenAL
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-x64\native\OpenAL.framework\Versions\A\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-x64\native\OpenAL.framework\Versions\Current\OpenAL
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-x64\native\OpenAL.framework\Versions\Current\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-x64\native\freetype.framework\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-x64\native\freetype.framework\Versions\A\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-x64\native\freetype.framework\Versions\A\freetype
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-x64\native\freetype.framework\Versions\Current\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-x64\native\freetype.framework\Versions\Current\freetype
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-x64\native\freetype.framework\freetype
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-x64\native\libcsfml-audio.2.6.dylib
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-x64\native\libcsfml-audio.dylib
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-x64\native\libcsfml-graphics.2.6.dylib
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-x64\native\libcsfml-graphics.dylib
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-x64\native\libcsfml-system.2.6.dylib
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-x64\native\libcsfml-system.dylib
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-x64\native\libcsfml-window.2.6.dylib
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-x64\native\libcsfml-window.dylib
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-x64\native\libsfml-audio.2.6.dylib
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-x64\native\libsfml-graphics.2.6.dylib
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-x64\native\libsfml-system.2.6.dylib
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-x64\native\libsfml-window.2.6.dylib
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-x64\native\ogg.framework\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-x64\native\ogg.framework\Versions\A\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-x64\native\ogg.framework\Versions\A\ogg
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-x64\native\ogg.framework\Versions\Current\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-x64\native\ogg.framework\Versions\Current\ogg
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-x64\native\ogg.framework\ogg
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-x64\native\vorbis.framework\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-x64\native\vorbis.framework\Versions\A\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-x64\native\vorbis.framework\Versions\A\vorbis
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-x64\native\vorbis.framework\Versions\Current\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-x64\native\vorbis.framework\Versions\Current\vorbis
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-x64\native\vorbis.framework\vorbis
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-x64\native\vorbisenc.framework\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-x64\native\vorbisenc.framework\Versions\A\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-x64\native\vorbisenc.framework\Versions\A\vorbisenc
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-x64\native\vorbisenc.framework\Versions\Current\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-x64\native\vorbisenc.framework\Versions\Current\vorbisenc
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-x64\native\vorbisenc.framework\vorbisenc
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-x64\native\vorbisfile.framework\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-x64\native\vorbisfile.framework\Versions\A\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-x64\native\vorbisfile.framework\Versions\A\vorbisfile
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-x64\native\vorbisfile.framework\Versions\Current\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-x64\native\vorbisfile.framework\Versions\Current\vorbisfile
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\osx-x64\native\vorbisfile.framework\vorbisfile
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\win-x64\native\csfml-audio.dll
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\win-x64\native\csfml-graphics.dll
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\win-x64\native\csfml-system.dll
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\win-x64\native\csfml-window.dll
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\win-x64\native\openal32.dll
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\win-x86\native\csfml-audio.dll
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\win-x86\native\csfml-graphics.dll
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\win-x86\native\csfml-system.dll
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\win-x86\native\csfml-window.dll
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\bin\Debug\net8.0\runtimes\win-x86\native\openal32.dll
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\obj\Debug\net8.0\KnightEngine.csproj.AssemblyReference.cache
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\obj\Debug\net8.0\KnightEngine.GeneratedMSBuildEditorConfig.editorconfig
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\obj\Debug\net8.0\KnightEngine.AssemblyInfoInputs.cache
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\obj\Debug\net8.0\KnightEngine.AssemblyInfo.cs
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\obj\Debug\net8.0\KnightEngine.csproj.CoreCompileInputs.cache
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\obj\Debug\net8.0\KnightEn.CD0879AB.Up2Date
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\obj\Debug\net8.0\KnightEngine.dll
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\obj\Debug\net8.0\refint\KnightEngine.dll
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\obj\Debug\net8.0\KnightEngine.pdb
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\obj\Debug\net8.0\KnightEngine.genruntimeconfig.cache
C:\Users\avirt\source\repos\CosmoEngine\KnightEngine\KnightEngine\obj\Debug\net8.0\ref\KnightEngine.dll

```

### Файл: obj\Debug\net8.0\KnightEngine.dll *(бинарный файл)*

### Файл: obj\Debug\net8.0\KnightEngine.GeneratedMSBuildEditorConfig.editorconfig *(бинарный файл)*

### Файл: obj\Debug\net8.0\KnightEngine.GlobalUsings.g.cs *(бинарный файл)*

### Файл: obj\Debug\net8.0\KnightEngine.pdb *(бинарный файл)*

### Файл: obj\Debug\net8.0\ZypEngine.AssemblyInfo.cs *(бинарный файл)*

### Файл: obj\Debug\net8.0\ZypEngine.csproj.BuildWithSkipAnalyzers *(бинарный файл)*

### Файл: obj\Debug\net8.0\ZypEngine.csproj.FileListAbsolute.txt
```txt
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\ZypEngine.exe
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\ZypEngine.deps.json
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\ZypEngine.runtimeconfig.json
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\ZypEngine.dll
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\ZypEngine.pdb
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\SFML.Audio.dll
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\SFML.Graphics.dll
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\SFML.System.dll
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\SFML.Window.dll
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\fedora-x64\native\libcsfml-audio.so
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\fedora-x64\native\libcsfml-audio.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\fedora-x64\native\libcsfml-graphics.so
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\fedora-x64\native\libcsfml-graphics.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\fedora-x64\native\libcsfml-system.so
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\fedora-x64\native\libcsfml-system.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\fedora-x64\native\libcsfml-window.so
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\fedora-x64\native\libcsfml-window.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\fedora-x64\native\libsfml-audio.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\fedora-x64\native\libsfml-graphics.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\fedora-x64\native\libsfml-system.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\fedora-x64\native\libsfml-window.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\linux-arm\native\libcsfml-audio.so
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\linux-arm\native\libcsfml-audio.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\linux-arm\native\libcsfml-graphics.so
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\linux-arm\native\libcsfml-graphics.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\linux-arm\native\libcsfml-system.so
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\linux-arm\native\libcsfml-system.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\linux-arm\native\libcsfml-window.so
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\linux-arm\native\libcsfml-window.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\linux-arm\native\libsfml-audio.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\linux-arm\native\libsfml-graphics.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\linux-arm\native\libsfml-system.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\linux-arm\native\libsfml-window.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\linux-arm64\native\libcsfml-audio.so
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\linux-arm64\native\libcsfml-audio.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\linux-arm64\native\libcsfml-graphics.so
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\linux-arm64\native\libcsfml-graphics.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\linux-arm64\native\libcsfml-system.so
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\linux-arm64\native\libcsfml-system.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\linux-arm64\native\libcsfml-window.so
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\linux-arm64\native\libcsfml-window.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\linux-arm64\native\libsfml-audio.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\linux-arm64\native\libsfml-graphics.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\linux-arm64\native\libsfml-system.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\linux-arm64\native\libsfml-window.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\linux-musl-x64\native\libcsfml-audio.so
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\linux-musl-x64\native\libcsfml-audio.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\linux-musl-x64\native\libcsfml-graphics.so
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\linux-musl-x64\native\libcsfml-graphics.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\linux-musl-x64\native\libcsfml-system.so
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\linux-musl-x64\native\libcsfml-system.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\linux-musl-x64\native\libcsfml-window.so
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\linux-musl-x64\native\libcsfml-window.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\linux-musl-x64\native\libsfml-audio.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\linux-musl-x64\native\libsfml-graphics.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\linux-musl-x64\native\libsfml-system.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\linux-musl-x64\native\libsfml-window.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\linux-x64\native\libcsfml-audio.so
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\linux-x64\native\libcsfml-audio.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\linux-x64\native\libcsfml-graphics.so
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\linux-x64\native\libcsfml-graphics.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\linux-x64\native\libcsfml-system.so
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\linux-x64\native\libcsfml-system.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\linux-x64\native\libcsfml-window.so
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\linux-x64\native\libcsfml-window.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\linux-x64\native\libsfml-audio.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\linux-x64\native\libsfml-graphics.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\linux-x64\native\libsfml-system.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\linux-x64\native\libsfml-window.so.2.6
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\FLAC.framework\FLAC
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\FLAC.framework\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\FLAC.framework\Versions\A\FLAC
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\FLAC.framework\Versions\A\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\FLAC.framework\Versions\Current\FLAC
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\FLAC.framework\Versions\Current\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\OpenAL.framework\OpenAL
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\OpenAL.framework\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\OpenAL.framework\Versions\A\OpenAL
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\OpenAL.framework\Versions\A\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\OpenAL.framework\Versions\Current\OpenAL
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\OpenAL.framework\Versions\Current\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\freetype.framework\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\freetype.framework\Versions\A\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\freetype.framework\Versions\A\freetype
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\freetype.framework\Versions\Current\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\freetype.framework\Versions\Current\freetype
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\freetype.framework\freetype
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\libcsfml-audio.2.6.dylib
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\libcsfml-audio.dylib
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\libcsfml-graphics.2.6.dylib
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\libcsfml-graphics.dylib
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\libcsfml-system.2.6.dylib
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\libcsfml-system.dylib
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\libcsfml-window.2.6.dylib
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\libcsfml-window.dylib
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\libsfml-audio.2.6.dylib
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\libsfml-graphics.2.6.dylib
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\libsfml-system.2.6.dylib
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\libsfml-window.2.6.dylib
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\ogg.framework\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\ogg.framework\Versions\A\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\ogg.framework\Versions\A\ogg
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\ogg.framework\Versions\Current\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\ogg.framework\Versions\Current\ogg
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\ogg.framework\ogg
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\vorbis.framework\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\vorbis.framework\Versions\A\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\vorbis.framework\Versions\A\vorbis
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\vorbis.framework\Versions\Current\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\vorbis.framework\Versions\Current\vorbis
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\vorbis.framework\vorbis
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\vorbisenc.framework\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\vorbisenc.framework\Versions\A\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\vorbisenc.framework\Versions\A\vorbisenc
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\vorbisenc.framework\Versions\Current\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\vorbisenc.framework\Versions\Current\vorbisenc
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\vorbisenc.framework\vorbisenc
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\vorbisfile.framework\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\vorbisfile.framework\Versions\A\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\vorbisfile.framework\Versions\A\vorbisfile
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\vorbisfile.framework\Versions\Current\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\vorbisfile.framework\Versions\Current\vorbisfile
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-arm64\native\vorbisfile.framework\vorbisfile
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-x64\native\FLAC.framework\FLAC
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-x64\native\FLAC.framework\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-x64\native\FLAC.framework\Versions\A\FLAC
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-x64\native\FLAC.framework\Versions\A\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-x64\native\FLAC.framework\Versions\Current\FLAC
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-x64\native\FLAC.framework\Versions\Current\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-x64\native\OpenAL.framework\OpenAL
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-x64\native\OpenAL.framework\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-x64\native\OpenAL.framework\Versions\A\OpenAL
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-x64\native\OpenAL.framework\Versions\A\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-x64\native\OpenAL.framework\Versions\Current\OpenAL
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-x64\native\OpenAL.framework\Versions\Current\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-x64\native\freetype.framework\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-x64\native\freetype.framework\Versions\A\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-x64\native\freetype.framework\Versions\A\freetype
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-x64\native\freetype.framework\Versions\Current\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-x64\native\freetype.framework\Versions\Current\freetype
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-x64\native\freetype.framework\freetype
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-x64\native\libcsfml-audio.2.6.dylib
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-x64\native\libcsfml-audio.dylib
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-x64\native\libcsfml-graphics.2.6.dylib
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-x64\native\libcsfml-graphics.dylib
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-x64\native\libcsfml-system.2.6.dylib
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-x64\native\libcsfml-system.dylib
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-x64\native\libcsfml-window.2.6.dylib
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-x64\native\libcsfml-window.dylib
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-x64\native\libsfml-audio.2.6.dylib
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-x64\native\libsfml-graphics.2.6.dylib
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-x64\native\libsfml-system.2.6.dylib
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-x64\native\libsfml-window.2.6.dylib
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-x64\native\ogg.framework\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-x64\native\ogg.framework\Versions\A\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-x64\native\ogg.framework\Versions\A\ogg
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-x64\native\ogg.framework\Versions\Current\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-x64\native\ogg.framework\Versions\Current\ogg
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-x64\native\ogg.framework\ogg
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-x64\native\vorbis.framework\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-x64\native\vorbis.framework\Versions\A\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-x64\native\vorbis.framework\Versions\A\vorbis
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-x64\native\vorbis.framework\Versions\Current\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-x64\native\vorbis.framework\Versions\Current\vorbis
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-x64\native\vorbis.framework\vorbis
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-x64\native\vorbisenc.framework\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-x64\native\vorbisenc.framework\Versions\A\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-x64\native\vorbisenc.framework\Versions\A\vorbisenc
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-x64\native\vorbisenc.framework\Versions\Current\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-x64\native\vorbisenc.framework\Versions\Current\vorbisenc
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-x64\native\vorbisenc.framework\vorbisenc
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-x64\native\vorbisfile.framework\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-x64\native\vorbisfile.framework\Versions\A\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-x64\native\vorbisfile.framework\Versions\A\vorbisfile
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-x64\native\vorbisfile.framework\Versions\Current\Resources\Info.plist
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-x64\native\vorbisfile.framework\Versions\Current\vorbisfile
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\osx-x64\native\vorbisfile.framework\vorbisfile
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\win-x64\native\csfml-audio.dll
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\win-x64\native\csfml-graphics.dll
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\win-x64\native\csfml-system.dll
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\win-x64\native\csfml-window.dll
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\win-x64\native\openal32.dll
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\win-x86\native\csfml-audio.dll
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\win-x86\native\csfml-graphics.dll
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\win-x86\native\csfml-system.dll
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\win-x86\native\csfml-window.dll
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\bin\Debug\net8.0\runtimes\win-x86\native\openal32.dll
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\obj\Debug\net8.0\ZypEngine.csproj.AssemblyReference.cache
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\obj\Debug\net8.0\ZypEngine.GeneratedMSBuildEditorConfig.editorconfig
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\obj\Debug\net8.0\ZypEngine.AssemblyInfoInputs.cache
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\obj\Debug\net8.0\ZypEngine.AssemblyInfo.cs
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\obj\Debug\net8.0\ZypEngine.csproj.CoreCompileInputs.cache
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\obj\Debug\net8.0\ZypEngine.csproj.Up2Date
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\obj\Debug\net8.0\ZypEngine.dll
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\obj\Debug\net8.0\refint\ZypEngine.dll
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\obj\Debug\net8.0\ZypEngine.pdb
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\obj\Debug\net8.0\ZypEngine.genruntimeconfig.cache
C:\Users\avirt\source\repos\CosmoEngine\ZypEngine\ZypEngine\obj\Debug\net8.0\ref\ZypEngine.dll

```

### Файл: obj\Debug\net8.0\ZypEngine.csproj.Up2Date *(бинарный файл)*

### Файл: obj\Debug\net8.0\ZypEngine.dll *(бинарный файл)*

### Файл: obj\Debug\net8.0\ZypEngine.GeneratedMSBuildEditorConfig.editorconfig *(бинарный файл)*

### Файл: obj\Debug\net8.0\ZypEngine.GlobalUsings.g.cs *(бинарный файл)*

### Файл: obj\Debug\net8.0\ZypEngine.pdb *(бинарный файл)*


## Директория: obj\Debug\net8.0\ref

### Файл: obj\Debug\net8.0\ref\KnifeEngine.dll *(бинарный файл)*

### Файл: obj\Debug\net8.0\ref\KnightEngine.dll *(бинарный файл)*

### Файл: obj\Debug\net8.0\ref\ZypEngine.dll *(бинарный файл)*


## Директория: obj\Debug\net8.0\refint

### Файл: obj\Debug\net8.0\refint\KnifeEngine.dll *(бинарный файл)*

### Файл: obj\Debug\net8.0\refint\KnightEngine.dll *(бинарный файл)*

### Файл: obj\Debug\net8.0\refint\ZypEngine.dll *(бинарный файл)*


## Директория: Objects

### Файл: Objects\SpriteObject.cs *(бинарный файл)*


## Директория: Scenes


## Директория: Scenes\Examples

### Файл: Scenes\Examples\MainMenuScene.cs *(бинарный файл)*

### Файл: Scenes\Examples\PlatformerGameScene.cs *(бинарный файл)*

### Файл: Scenes\Examples\TopDownScene.cs *(бинарный файл)*

