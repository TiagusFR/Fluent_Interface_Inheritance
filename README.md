Fluent Interface Inheritance pattern based in a Builder inheriting from another Builder. 

-Person: object that needs to build up. Once what is being constructed always takes a generic argument, a 'new type' is needed, not just a variable.

-PersonBuilder: base class Builder to construct 'Person' objects

-PersonInfoBuilder: built with the generic argument 'SELF', inheriting from itself. This enforces an inherirance chain, so A<B> is only an acceptable specialization if A derives from B, and other cases will fail the 'where' constraint.

-PersonJobBuilder: not a common inheritance, having itself plus 'SELF' generic argument. Then, all of its fluent interfaces return the correct type, not just the type of the owning class.
So, when adding another member like 'PersonDateOfBirthBuilder', once 'PersonJobBuilder' is already a 'PersonInfoBuilder', there's no need to restate explicity as part of the inheritance type list. 
