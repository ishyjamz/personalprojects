import { useState } from "react";

export function TodoForm(props) {

    const [newThing, setNewThing] = useState("");

    function handleSubmit(e) {
        e.preventDefault();

        if (newThing === "") {
            return
        }

        // eslint-disable-next-line react/prop-types
        props.onSubmit(newThing);

        setNewThing("");
    }


    return (
        <form onSubmit={handleSubmit} className='new-item-form'>
            <div className='form-row'>
                <label htmlFor='item'>New Item</label>
                <input value={newThing}
                    onChange={e => setNewThing(e.target.value)}
                    type='text' id='item' />
            </div>
            <button className='btn'>Add</button>
        </form>
    )
}