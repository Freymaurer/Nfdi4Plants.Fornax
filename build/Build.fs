﻿open BlackFox.Fake
open System.IO
open Fake.Core
open Fake.DotNet
open Fake.IO
open Fake.IO.FileSystemOperators
open Fake.IO.Globbing.Operators
open Fake.Tools

open Helpers

initializeContext()

open BasicTasks
open TestTasks
open PackageTasks
open ReleaseTasks
open ReleaseNotesTasks
open FornaxTasks

/// Referenced here to make ReleaseNotesTasks accessible.
let _ = updateReleaseNotes
let _ = watchFornax

/// Full release of nuget package for the prerelease version.
let _release = 
    BuildTask.createEmpty 
        "Release" 
        [clean; build; runTests; pack; createTag; publishNuget;]

/// Full release of nuget package for the prerelease version.
let _preRelease = 
    BuildTask.createEmpty 
        "PreRelease" 
        [setPrereleaseTag; clean; build; runTests; packPrerelease; createPrereleaseTag; publishNugetPrerelease]



[<EntryPoint>]
let main args = 
    runOrDefault build args
