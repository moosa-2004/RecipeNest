import { useState, useEffect } from "react";

const API = "http://localhost:5011/api";

function App() {
  const [recipes, setRecipes] = useState([]);
  const [title, setTitle] = useState("");
  const [ingredients, setIngredients] = useState("");
  const [instructions, setInstructions] = useState("");

  // Fetch recipes
  const fetchRecipes = async () => {
    const res = await fetch(`${API}/Recipe`);
    const data = await res.json();
    setRecipes(data);
  };

  useEffect(() => {
    fetchRecipes();
  }, []);

  // Add recipe
  const addRecipe = async () => {
    if (!title || !ingredients || !instructions) {
      alert("Please fill all fields");
      return;
    }

    await fetch(`${API}/Recipe`, {
      method: "POST",
      headers: { "Content-Type": "application/json" },
      body: JSON.stringify({
        chefID: 1,
        title,
        ingredients,
        instructions,
        imagePath: ""
      })
    });

    setTitle("");
    setIngredients("");
    setInstructions("");
    fetchRecipes();
  };

  // Delete recipe
  const deleteRecipe = async (id) => {
    await fetch(`${API}/Recipe/${id}`, {
      method: "DELETE"
    });
    fetchRecipes();
  };

  return (
    <div style={{ padding: 20, fontFamily: "Arial" }}>
      <h1>🍲 RecipeNest</h1>

      <h2>Add Recipe</h2>
      <input
        placeholder="Title"
        value={title}
        onChange={(e) => setTitle(e.target.value)}
      />
      <br /><br />

      <input
        placeholder="Ingredients"
        value={ingredients}
        onChange={(e) => setIngredients(e.target.value)}
      />
      <br /><br />

      <input
        placeholder="Instructions"
        value={instructions}
        onChange={(e) => setInstructions(e.target.value)}
      />
      <br /><br />

      <button onClick={addRecipe}>Add Recipe</button>

      <h2 style={{ marginTop: 30 }}>All Recipes</h2>

      {recipes.length === 0 ? (
        <p>No recipes found</p>
      ) : (
        recipes.map((r) => (
          <div key={r.recipeID} style={{
            border: "1px solid gray",
            padding: 10,
            marginTop: 10
          }}>
            <h3>{r.title}</h3>
            <p><b>Ingredients:</b> {r.ingredients}</p>
            <p><b>Instructions:</b> {r.instructions}</p>
            <button onClick={() => deleteRecipe(r.recipeID)}>
              Delete
            </button>
          </div>
        ))
      )}
    </div>
  );
}

export default App;