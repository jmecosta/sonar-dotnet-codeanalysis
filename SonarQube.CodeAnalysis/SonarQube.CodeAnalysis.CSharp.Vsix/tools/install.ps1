param($installPath, $toolsPath, $package, $project)

$analyzersPath = join-path $toolsPath "analyzers"
$analyzerFilePath = join-path $analyzersPath "SonarQube.CodeAnalysis.CSharp.dll"
$project.Object.AnalyzerReferences.Add($analyzerFilePath)