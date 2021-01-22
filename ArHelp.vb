Public Class ArHelp

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

        RichTextBox1.Text = "الجندي:                                                                                  وهو من أكثر القطع وجوداً في هذه اللعبة؛ إذ إنّه يوجد لدى كلّ لاعبٍ ثمانية جنود، ويستطيع الجندي التحرّك حركةً واحدةً بشكلٍ مستقيم، ومع العلم أنّ أول حركةٍ له يمكنه فيها التحرّك مستطيلين إلى الأمام، ولا يمكن للجندي الرجوع إلى الخلف على الإطلاق، ويعتبر العديد من الناس أنّ الجندي لا قيمة له في هذه اللعبة إلّا أنّ له قيمةً كبيرةً جداً بما أنّه من أكثر القطع وجوداً في اللعبة وخصوصاً أنّه يمكن تبديل الجندي بأيّ قطعة من القطع ما عدا الملك عند وصوله إلى آخر مربعٍ في الرقعة، أمّا عن الطريقة التي يمكن للجندي أن يهزم من خلالها القطع الأخرى فهي بأن يتحرّك حركةً واحدةً بشكلٍ قطري عند وجود قطعةٍ من قطع الخصم في ذلك المربع، ويوجد الجنود في الصف الثاني لكلّ لاعب."

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        RichTextBox1.Text = "القلعة:                                                                                   هي القطعة التي توجد في زوايا الرقعة في بداية اللعبة، وتوجد لدى كلّ لاعب قلعتان، ويمكن للقلعة أن تتحرّك بشكلٍ أفقيٍّ أو عمودي من دون أي تقييد بالمربعات حتى وصولها إلى آخر الرقعة أو إلى المربّع الّذي يسبق أيّ قطعةٍ من القطع، أو يمكنها هدم قطعةٍ من قطع الخصم عند وجودها في طريقه."
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        RichTextBox1.Text = "الحصان:                                                                    وتوجد من هذه القطعة أربعة قطعٍ في الرقعة؛ بحيث توجد قطعتان لكلّ لاعب وتوجدان إلى جانب القلعة، وتستطيع هذه القطعة التحرّك بشكل حرف L؛ بحيث تتحرك مربعاً واحداً لأيّ جهةٍ مستقيمة، ومن ثمّ مربعين إلى أيّ جهةٍ أخرى بشكلٍ عمودي لحركته الأولى، وتتميز هذه القطعة بأنّها القطعة الوحيدة في اللعبة التي تستطيع أن تتجاوز القطع الموجودة في اللعبة ولا تتوقف عندها، وتستطيع هذه القطعة هزم أي قطعةٍ موجودةٍ من الخصم عند وجودها في آخر مربعٍ تقف عليه هذه القطعة  "
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        RichTextBox1.Text = "الفيل:                                                                            وهذه القطعة تشبه القلعة تماماً إلّا أنّها تتحرّك بشكلٍ قطريٍّ بدلاً من مستقيم، وتوجد هذه القطعة إلى جانب الحصان، وتوجد لدى كلّ لاعبٍ منها قطعتان."
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        RichTextBox1.Text = "الوزير:                                                                                                                   وهو أكثر القطع مرونةً في اللعبة؛ إذ إنّه يعادل الفيل والقلعة مجتمعتن؛ فيستطيع الوزير الحركة بشكلٍ مستقيمٍ وقطري، وتوجد منه قطعةً واحدةً لدى كلّ لاعب في النصف الأيمن إلى جانب الفيل الأيمن في الرقعة."
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        RichTextBox1.Text = " الملك:                                                                         وهو القطعة الّتي تحدّد فوز أو خسارة اللاعب، وتستطيع هذه القطعة الحركة كالوزير بشكلٍ مستقيمٍ وقطري ولكن مربعاً واحداً فقط، وتوجد هذه القطعة في المنتصف الأيسر من الرقعة إلى جانب الفيل الأيسر، ولا يمكن تحريك الملك إلى أيّ مربعٍ مهددٍ من قطع الخصم."
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox("  ( اضغط على القطعة المراد تحريكها فتظهر الأماكن التى يمكنك التحرك اليها ثم اضغط على المكان الذى تريد الذهاب اليه ويمكنك أيضا أن تضغط بزر الماوس الأيمن للتراجع قبل التحرك ( اذا كانت خاصية الالزام غير مفعلة")
    End Sub

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Panel1.Visible = False

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Panel1.Visible = True

    End Sub


    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class