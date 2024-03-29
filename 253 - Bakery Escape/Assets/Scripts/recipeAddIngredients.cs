﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class recipeAddIngredients : MonoBehaviour
{

    //vars
    
    public string IngredientName;
    public TextMeshProUGUI amountLabel;
    public TextMeshProUGUI ingredientNameLabel;
    public int amount;
    public Recipe theRecipe;

    public Button[] buttons;

    public Image icon; //shows when they have ingredient
    public Sprite qMark;
    public Sprite ingredientIcon;
    public bool isFound = false;


    // Start is called before the first frame update
    void Start()
    {
        icon.sprite = qMark;
        ingredientNameLabel.text = "...";
        foreach (Button b in buttons)
        {
            b.interactable = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void incAmount()
    {
        amount++;
        updateLabel();
    }

    public void decAmount()
    {
        if (amount > 0)
        {
            amount--;
            updateLabel();

        }
    }
    public void updateLabel()
    {
        amountLabel.text = amount.ToString();
        updateRecipe();
    }

    public void updateRecipe()
    {
        Debug.Log("UPDATING RECIPE: " + IngredientName + " " + amount);
        theRecipe.updateUserIngredients(IngredientName, amount);
    }

    public void hasBeenFound()
    {
        isFound = true;
        //runs when player collects this ingredient, so it can be used here
        icon.sprite = ingredientIcon;
        ingredientNameLabel.text = IngredientName;
        foreach(Button b in buttons)
        {
            b.interactable = true;
        }
    }
}
