import React from 'react';
import './styles.css';

interface Props {
    todo: string;
    setTodo: React.Dispatch<React.SetStateAction<string>>;
}

const InputField: React.FC<Props> = ({todo, setTodo}) => {
  return (
    <form className='input'>
        <input type="input" placeholder='You are a chicken nugget' className='input-box'
        value={todo} 
        onChange= {
            (e) => setTodo(e.target.value)
        }></input>
        <button className='input-submit' type='submit'>
            Woweee
        </button>
    </form>
  )
}

export default InputField

