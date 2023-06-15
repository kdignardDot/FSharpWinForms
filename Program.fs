open System.Windows.Forms
open Design.main

let messageBox() =
    ignore (MessageBox.Show("Testing Message Box."))

let exitApp() =
    Application.Exit()

let appendTextbox (text: string) =
    if tab1.Visible = true then
        tab1.Visible <- false
    else
        tab1.Visible <- true
    textBox1.AppendText(text + "\n")


buttonMessageBox.Click.AddHandler(fun _ _ -> messageBox())
buttonAddText.Click.AddHandler(fun _ _ -> appendTextbox(textBox2.Text))
buttonExit.Click.AddHandler(fun _ _ -> exitApp())
//button2.Click.Add(fun x -> test x |> ignore)

Application.Run(form)
