# Stateful Menu

This example shows how you can store state in a React function component, allowing you to manage certain UI concerns outside of the main Elmish application model.

It is just the out-of-the box SAFE Todo app with a push menu added. This menu uses the `React.useState` hook to store a bool which tracks whether it is open or closed.

For more advanced scenarios consider the `React.useElmish' hook [provided by Feliz](https://zaid-ajaj.github.io/Feliz/#/Hooks/UseElmish) to give the component its own separate MVU loop.
