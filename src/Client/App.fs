module Client.App

open Elmish
open Elmish.React

#if DEBUG
open Elmish.Debug
open Elmish.HMR
#endif

Program.mkProgram State.init State.update Index.render
#if DEBUG
|> Program.withConsoleTrace
#endif
|> Program.withReactSynchronous "elmish-app"
#if DEBUG
|> Program.withDebugger
#endif
|> Program.run
