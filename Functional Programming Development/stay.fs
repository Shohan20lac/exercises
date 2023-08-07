module stay

type InPersonAssistance = {
    allDay:    bool
    overnight: bool
    medical:   bool
}

type Assistance =
| VerbalInPerson
| VerbalOverPhone
| InPerson of InPersonAssistance

type AssistanceRequirement = {
    By:               Person
    From:             List<Person>
    Emotional:        Option<Assistance>
    Physical:         Option<Assistance>
    Medical:          Option<Assistance>
    Transportational: Option<Transport>
}

type PhysicalHealth =
| FullyOperational
| Unconvenienced   of Reason * Option<AssistanceRequirement>    // TODO: Address
| Injured          of Reason * AssistanceRequirement
| SeverelyInjured  of Reason * AssistanceRequirement

type MentalHealth =
| Euphoric
| Content
| Bored      of Reason
| Lonely     of Reason
| Depressed  of Reason
| Suicidal   of Reason

type PersonType =
| Husband
| Wife
| HusbandsMother
| HusbandsFather
| WifesMother
| WifesFather

type Person = {
    Name:           string
    PhysicalHealth: PhysicalHealth
    MentalHealth:   PhysicalHealth
    PersonType:     PersonType
}

type Wife = {
    CanAffordToNotBeEmotionallySupportedRightNow: bool
}

type Husband = {
    CanAffordToNotCodeRightNow: bool
}


type Child =
| Husband of Husband
| Wife    of Wife

type Parent = {
    Name:           string
    PhysicalHealth: PhysicalHealth
    MentalHealth:   MentalHealth
    IsParentOf:     Child
}

type OcassionName = 
| Birthday
| EidUlFitr
| EidUlAzha
| EidEMiladUnNabi
| ShabEBarat
| Other of OccassionName

type OccasionCategory =
| Cultural
| Social
| Religious
| Recreational
| Other

type Ocassion = {
    Name:     OcassionName
    Category: OccasionCategory
}

type AtHome = bool

type StateOfExistence = 
| InTown    of AtHome
| OutofTown of AtHome
| Abroad

type ParentalStayArray = {
    HusbandsMother: StateOfExistence
    HusbandsFather: StateOfExistence
    WifesMother:    StateOfExistence
    WifesFather:    StateOfExistence
}