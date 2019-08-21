/*
	Inversion of control :- It’s a generic term and implemented in several ways (events, delegates etc).
	Dependency injection :- DI is a subtype of IOC and is implemented by constructor injection, setter injection or method injection.
*/


// NOT Dependency Injection
public class TextEditor {

    private SpellChecker checker;

    public TextEditor() {
        this.checker = new SpellChecker(); // TextEditor has a direct dependency with SpellChecker
    }
}

// Dependency Injection
public class TextEditor {

    private IocSpellChecker checker;

    public TextEditor(IocSpellChecker checker) {
        this.checker = checker; // We provice the instance object in the constructor, also is a Interface
    }
}