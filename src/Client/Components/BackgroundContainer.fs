module Client.Components.BackgroundContainer

open Feliz
open Feliz.Bulma

let render (children: seq<Fable.React.ReactElement>) =
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
                    prop.children children
                ]
            ]
        ]
    ]