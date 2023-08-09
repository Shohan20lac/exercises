// For more information see https://aka.ms/fsharp-console-apps
open AtomicTypes
open Person
open Assistance

printfn "Hello World"

// TODO: 

let NecessityLevels = [
    "Optional"
    "Preferred"
    "Mandatory"
]

let OccasionNames = [
    "Birthday"
    "EidUlAzha"
    "EidUlFitr"
    "EidEMiladUnNabi"
    "ShabEBarat"
    "Anniversary"
    "RegularDay"
]

let statesOfExistance = [
    "InTown"
    "AtHome"
    "Abroad"
]

let parents = [
    HusbandMom
    HusbandDad
    WifeMom
    WifeDad
]

let InPersonAssistances = [
    "allDay"
    "overnight"
    "medical"
]

let Necessity = [
    "Optional"
    "Preferred"
    "Mandatory"
]

let Transports = [
    "Private"
    "Public"
]

let mentalHealthStates = [
    "Euphoric"
    "Content"
    "Bored"
    "Lonely"
    "Depressed"
    "Suicidal"
]

let physicalHealthStates = [
    "Fully Functional"
    "Unconvenienced"
    "Injured"
    "SeverelyInjured"
]

let availabilityStates = [
    "Social"
    "MultiTasking"
    "Recluse"
]


let parentalStayState = {
    HusbandMom = InTown true
    HusbandDad = InTown true
    WifeMom    = InTown true
    WifeDad    = InTown true
}
    