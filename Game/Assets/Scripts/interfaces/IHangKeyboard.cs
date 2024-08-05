public interface IHangKeyboard
{
    delegate void HangKeyboardHangler(char key);
    event HangKeyboardHangler OnKeyPressed;
}
