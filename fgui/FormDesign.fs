namespace Design

open System.Windows.Forms
open System.Drawing

module main =
    // Form
    let form = new Form(Text = "FSharp Form")
    form.Size <- Size(1164,678)

    // Buttons
    let buttonMessageBox = new Button(Text = "MessageBox")
    buttonMessageBox.Location <- new Point(12,14)
    buttonMessageBox.Size <- new Size(80,23)

    let buttonAddText = new Button(Text = "Add Text")
    buttonAddText.Location <- new Point(108,14)
    buttonAddText.Size <- new Size(80,23)

    let buttonExit = new Button(Text = "Exit")
    buttonExit.Location <- new Point(193,14)
    buttonExit.Size <- Size(80,23)

    // TextBoxes
    let textBox1 = new TextBox(Text = "1234")
    textBox1.Multiline <- true
    textBox1.Location <- new Point(8,469)
    textBox1.Size <- new Size(1128, 158)

    let textBox2 = new TextBox(Text = "")
    textBox2.Location <- Point(108,44)
    textBox2.Size <- Size(145,23)

    // Tab Controls
    let tab1 = new TabControl()
    tab1.Size <- Size(420,241)
    tab1.Location <- new Point(410, 44)

    form.Controls.Add(buttonMessageBox)
    form.Controls.Add(buttonAddText)
    form.Controls.Add(buttonExit)
    form.Controls.Add(textBox1)
    form.Controls.Add(tab1)
    form.Controls.Add(textBox2)