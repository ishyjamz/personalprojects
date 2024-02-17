/* eslint-disable react/prop-types */
export function TodoItem({ id, title, completed, toggleTodo, deleteTodo }) {
    return (
        <li>
            <label>
                <input type='checkbox' onChange={e => toggleTodo(id, e.target.checked)}
                    checked={completed} />
                {title}
            </label>
            <button
                onClick={() => deleteTodo(id)}
                className='btn btn-danger'>Delete</button>
        </li>
    )
}