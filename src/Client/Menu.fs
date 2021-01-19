module Menu

open System
open Feliz

let sideNavStyle (width : double) = [
    style.height (length.percent 100)
    style.width (length.px width)
    style.position.fixedRelativeToWindow
    style.top 0
    style.zIndex 1
    style.left 0
    style.backgroundColor (color.rgb (0,184,156))
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

let containerStyle (margin : int) = [
    style.transitionProperty [transitionProperty.marginLeft]
    style.transitionDuration (TimeSpan.FromSeconds 0.5)
    style.marginLeft margin
]

let view content =
    {| content = content |}
    |> React.functionComponent(fun (props: {| content : ReactElement seq |}) ->
        let (isOpen, setOpen) = React.useState(false)
        Html.div [
            prop.style (containerStyle(if isOpen then 250 else 68))
            prop.children [
                Html.div [
                    prop.style (sideNavStyle(if isOpen then 250.0 else 68.0))
                    prop.children [
                        Html.div[
                            prop.style menuButtonStyle
                            prop.onClick (fun _ -> setOpen (not isOpen))
                            prop.text "🍔"
                        ]
                    ]
                ]
                yield! props.content
            ]
        ]) 
    