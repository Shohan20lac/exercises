// For more information see https://aka.ms/fsharp-console-apps
open AtomicTypes
open Person
open Assistance

printfn "Hello World"

let person1 = {
    Name                     = "Shohan"
    PersonType               = PersonType.Husband
    PhysicalHealth           = PhysicalHealth.FullyOperational
    MentalHealth             = MentalHealth.Bored "Just Because"
    CompanionshipRequirement = {
        Physical         = None
        Emotional        = None
        Medical          = None
        Transportational = None
    }
}

printfn $"{person1}"

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

let StatesOfExistance = [
    "InTown"
    "AtHome"
    "Abroad"
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

