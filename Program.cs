//*****************************************************************************
//** 3354. Make Array Elements Equal to Zero                        leetcode **
//*****************************************************************************
//** Zeros stand waiting, still and sly,                                     **
//** Each step we take makes numbers die.                                    **
//** Two paths may cleanse, but none may cheat                               **
//** The dance of balance ends complete.                                     **
//*****************************************************************************

int countValidSelections(int* nums, int numsSize) {
    int sum = 0;
    for(int i = 0; i < numsSize; i++)
    {
        sum += nums[i];
    }
    if(sum == 0)
    {
        return numsSize * 2;
    }
    int cur = 0;
    int res = 0;
    for(int i = 0; i < numsSize; i++)
    {
        cur += nums[i];
        if(sum % 2 == 0 && cur == sum / 2 && nums[i] == 0)
        {
            res += 2;
        }
        else if (sum % 2 && (cur == sum / 2 || cur == sum / 2 + 1) && nums[i] == 0)
        {
            res += 1;
        }
    }
    return res;
}