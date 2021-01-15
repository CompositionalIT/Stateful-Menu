module Menu

open System
open Feliz
open Elmish

let sideNavStyle (width : double) = [
    style.height (length.percent 100)
    style.width (length.px width)
    style.position.fixedRelativeToWindow
    style.top 0
    style.zIndex 1
    style.left 0
    style.backgroundColor color.black
    style.overflowX.hidden
    style.transitionDurationSeconds 0.5
]

let menuButtonStyle = [
    style.position.absolute
    style.top 0
    style.right (length.px 10)
    style.fontSize (length.px 36)
    style.cursor.pointer
]

let view = React.functionComponent(fun () ->
    let (isOpen, setOpen) = React.useState(false)
    Html.div [
        if isOpen then
            prop.style (sideNavStyle 68.0)
        else
            prop.style (sideNavStyle 250.0)
        prop.children [
            Html.div[
                prop.style menuButtonStyle
                prop.onClick (fun _ -> setOpen (not isOpen))
                prop.text "🍔"
            ]
        ]
    ])