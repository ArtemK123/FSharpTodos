module Components.HomePage

open Feliz
open Feliz.Bulma
open State

let render (_: Model) (_: Msg -> unit) =
    Bulma.hero [
        hero.isFullHeight
        color.isPrimary
        prop.style [
            style.backgroundSize "cover"
            style.backgroundImageUrl "https://unsplash.it/1200/900?random"
            style.backgroundPosition "no-repeat center center fixed"
        ]
        prop.children [
            Bulma.heroBody [
                Bulma.container [
                    Bulma.column [
                        column.isOffset3
                        column.is6
                        prop.children [
                            Bulma.box [
                                Bulma.block "Home page of SAFE stack demo app"
                                Bulma.block "Made by ArtemK123"
                                Bulma.block [
                                    RedirectButtons.ToTodoAppPage.render
                                ]
                                Bulma.block [
                                    RedirectButtons.ToTestPage.render
                                ]
                            ]
                        ]
                    ]
                ]
            ]
        ]
    ]
